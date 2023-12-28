Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models
Imports Prolipol.Formacao.WF.DataTables

Public Class LoanDetailsView


    Private ReadOnly _loanService As ILoanService
    Private _loan As Loan

    Public Sub New(loanServico As ILoanService, loan As Loan)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _loanService = loanServico
        _loan = loan
    End Sub

    Private Sub LoanDetailsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadInitialData()
        LoadLoans()
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

        If _loan.ReturnedOn.HasValue Then
            ReturnBookButton.Enabled = False
        Else
            ReturnBookButton.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    Private Async Sub LoadLoans()
        Try
            Dim loans = Await Task.Run(Function() _loanService.GetLoans().Where(Function(l) l.Id = _loan.Id))
            Dim dataTable = New LoanDataTable(loans)
            loansDataGridView.DataSource = dataTable.Build(Function(l) l.Id)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReturnBookButton_Click(sender As Object, e As EventArgs) Handles ReturnBookButton.Click
        Dim confirmReturnBook As DialogResult = MessageBox.Show("Are you Sure that that you want to Return this book?", "Please Confirm", MessageBoxButtons.YesNo)
        If confirmReturnBook = DialogResult.Yes Then

            If _loan IsNot Nothing Then
                Dim returnBookView As ReturnBookView = New ReturnBookView(_loanService, _loan)
                returnBookView.ShowDialog()
                LoadLoans()
                ReturnBookButton.Enabled = False
            End If
        End If
    End Sub
End Class