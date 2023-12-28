Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Public Class NewLoanView

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property bookValue As Book

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property borrowerValue As Borrower
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property startDate As Date

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property expireDate As Date

    Private ReadOnly _getLoanCount As Action

    Private ReadOnly _loanService As ILoanService
    Private ReadOnly _bookService As IBookService
    Private ReadOnly _borrowerService As IBorrowerService

    Public Sub New(bookService As IBookService, borrowerService As IBorrowerService, loanService As ILoanService, getLoanCount As Action)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _bookService = bookService
        _borrowerService = borrowerService
        _loanService = loanService
        _getLoanCount = getLoanCount
    End Sub

    ''' <summary>
    ''' Adding list of book on the combobox
    ''' </summary>
    Private Async Sub LoadBooks()
        Try
            Dim books As IEnumerable(Of Book) = Await Task.Run(Function() _bookService.GetBooks().Where(Function(b) b.IsAvailable = True))
            FillBookCombobox(BookComboBox, books)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Adding list Of Borrowers on the combobox
    ''' </summary>
    Private Async Sub LoadBorrowers()
        Try
            Dim borrowers As IEnumerable(Of Borrower) = Await Task.Run(Function() _borrowerService.GetBorrowers())
            FillBorrowerComboBox(BorrowerComboBox, borrowers)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="comboBox"></param>
    ''' <param name="items"></param>
    Private Sub FillBookCombobox(comboBox As ComboBox, items As IEnumerable(Of Object))
        comboBox.DisplayMember = "Title"
        comboBox.ValueMember = "Id"
        comboBox.DataSource = items.ToList()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="comboBox"></param>
    ''' <param name="items"></param>
    Private Sub FillBorrowerComboBox(comboBox As ComboBox, items As IEnumerable(Of Object))
        comboBox.DisplayMember = "Name"
        comboBox.ValueMember = "Id"
        comboBox.DataSource = items.ToList()
    End Sub

    Private Sub NewLoanView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooks()
        LoadBorrowers()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BookComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BookComboBox.SelectedIndexChanged
        Try
            Dim selectedBook As Book = CType(BookComboBox.SelectedItem, Book)
            If selectedBook IsNot Nothing Then
                bookValue = selectedBook
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BorrowerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BorrowerComboBox.SelectedIndexChanged
        Try
            Dim selectedBorrower As Borrower = CType(BorrowerComboBox.SelectedItem, Borrower)
            If selectedBorrower IsNot Nothing Then
                borrowerValue = selectedBorrower
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelLoanButton.Click
        Close()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateLoanButton.Click
        Try
            If LoanFormValidating() Then
                startDate = StartLoanDateTimePicker.Value.Date
                expireDate = ExpireLoanDateTimePicker.Value.Date
                _loanService.LoanBook(bookValue, borrowerValue, startDate, expireDate)
                LoanToolStripStatusLabel.Text = "Loan Registered"
                _getLoanCount.Invoke()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function LoanFormValidating() As Boolean
        If bookValue Is Nothing Then
            MessageBox.Show("Please select a book.")
            Return False
        End If

        If borrowerValue Is Nothing Then
            MessageBox.Show("Please select a borrower.")
            Return False
        End If

        startDate = StartLoanDateTimePicker.Value.Date
        expireDate = ExpireLoanDateTimePicker.Value.Date

        If startDate >= expireDate Then
            MessageBox.Show("Start date cannot be the same or later than expire date.")
            Return False
        End If
        Return True
    End Function
End Class