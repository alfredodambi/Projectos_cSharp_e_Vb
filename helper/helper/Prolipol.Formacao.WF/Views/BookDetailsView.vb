Imports System.Net
Imports System.Threading
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models
Imports Prolipol.Formacao.WF.DataTables

Public Class BookDetailsView

    Private ReadOnly _bookService As IBookService
    Private ReadOnly _loanService As ILoanService
    Private ReadOnly _bookId As Integer

    Public Sub New(bookService As IBookService, loanService As ILoanService, bookId As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _bookService = bookService
        _loanService = loanService
        _bookId = bookId

        ReturnBookButton.Enabled = False
    End Sub

    Private Sub BookDetailsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLoans()
    End Sub

    Public Async Sub LoadLoans()
        BookToolStripStatusLabel.Text = "Loading books data..."

        Dim foundBorrower = Await Task.Run(Function() _bookService.GetBook(_bookId))

        Dim loans = Await Task.Run(Function() _loanService.GetLoans().Where(Function(l) l.Book.Id = _bookId))

        Dim loansDataTable = New LoanDataTable(loans)

        BookToolStripStatusLabel.Text = "Finished!"

        BookInLoanDatagridView.DataSource = loansDataTable.Build(Nothing)

        idBookTextBox.Text = foundBorrower.Id
        nameBookTextBox.Text = foundBorrower.Title
        authorBookTextBox.Text = foundBorrower.Author
        isAvailableBookCheckBox.Checked = foundBorrower.IsAvailable

    End Sub
    ''' <summary>
    ''' Closing the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseBookDetailsButton.Click
        Close()
    End Sub
End Class