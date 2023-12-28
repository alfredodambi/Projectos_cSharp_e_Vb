Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Public Class ReturnBookView


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property startDate As Date

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property ReturnDate As Date

    Private ReadOnly _loanService As ILoanService
    Private _loan As Loan

    Public Sub New(loanService As ILoanService, loan As Loan)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        _loanService = loanService
        _loan = loan

        BookNameTextBox.Text = _loan.Book.Title
        BorrrowerNameTextBox.Text = _loan.Borrower.Name
        StartDateDateTimePicker.Value = _loan.StartDate
    End Sub

    ''' <summary>
    ''' Returning a book
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReturnBookButton_Click(sender As Object, e As EventArgs) Handles ReturnBookButton.Click
        If ReturnBookValidatingForm() Then
            Try
                If _loan IsNot Nothing Then
                    ReturnDate = ReturnDateDateTimePicker.Value
                    'Return a book 
                    _loanService.ReturnBook(_loan, ReturnDate)
                    LoanToolStripStatusLabel.Text = $"Book Returned Id: {_loan.Id}, Title: {_loan.Book.Title}, Date Return: {ReturnDate}"
                    Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Validating the data
    ''' </summary>
    ''' <returns></returns>
    Public Function ReturnBookValidatingForm() As Boolean
        startDate = StartDateDateTimePicker.Value.Date
        ReturnDate = ReturnDateDateTimePicker.Value.Date

        If startDate >= ReturnDate Then
            MessageBox.Show("Start date cannot be the same or later than return date.")
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' Close the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CancelRetunBookButton_Click(sender As Object, e As EventArgs) Handles CancelRetunBookButton.Click
        Close()
    End Sub
End Class