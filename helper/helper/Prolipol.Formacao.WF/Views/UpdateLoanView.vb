Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Public Class UpdateLoanView


    Private ReadOnly _loanService As ILoanService
    Private _loan As Loan
    Public Sub New(loanService As ILoanService, loan As Loan)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        _loanService = loanService
        _loan = loan
    End Sub


    Private Sub UpdateLoanView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInitialData()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub LoadInitialData()
        IdLoanTextBox.Text = _loan.Id
        BookNameTextBox.Text = _loan.Book.Title
        BorrowerNameTextBox.Text = _loan.Borrower.Name
        StartLoanDateTimePicker.Value = _loan.StartDate
        ExpiryLoanDateTimePicker.Value = _loan.ExpiryDate
        LoanToolStripStatusLabel.Text = "Finished!"
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UpdateLoanButton_Click(sender As Object, e As EventArgs) Handles UpdateLoanButton.Click
        If LoanFormValidating() Then
            Try
                _loan.Id = IdLoanTextBox.Text
                _loan.Book.Title = BookNameTextBox.Text
                _loan.Borrower.Name = BorrowerNameTextBox.Text
                _loan.StartDate = StartLoanDateTimePicker.Value
                _loan.ExpiryDate = ExpiryLoanDateTimePicker.Value

                _loanService.UpdateLoan(_loan)
                LoanToolStripStatusLabel.Text = "Loan Updated SucessFully"

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CancelLoanButton_Click(sender As Object, e As EventArgs) Handles CancelLoanButton.Click
        Close()
    End Sub

    ''' <summary>
    ''' Validating components in the form
    ''' </summary>
    ''' <returns></returns>
    Private Function LoanFormValidating() As Boolean
        Dim isValid As Boolean = True
        Dim validationErrors As New List(Of String)

        If String.IsNullOrWhiteSpace(BookNameTextBox.Text) Then
            validationErrors.Add("Book name is required.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(BorrowerNameTextBox.Text) Then
            validationErrors.Add("Borrower name is required.")
            isValid = False
        End If

        If ExpiryLoanDateTimePicker.Value <= StartLoanDateTimePicker.Value Then
            validationErrors.Add("Expiry date must be after start date.")
            isValid = False
        End If

        If Not isValid Then
            Dim errorMessage As String = String.Join(Environment.NewLine, validationErrors)
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Return isValid
    End Function
End Class