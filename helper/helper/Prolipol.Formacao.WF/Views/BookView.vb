Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models
Imports Prolipol.Formacao.WF.DataTables


Public Class BookView

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property IdBook As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property nameBook As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property authorBook As String

    Private ReadOnly _bookService As IBookService
    Private ReadOnly _loanService As ILoanService
    Private _updateBookCountMethod As Action

    Private _selectedBookId As Integer
    Public Property SelectedBookId As Integer
        Get
            Return _selectedBookId
        End Get
        Set(value As Integer)
            _selectedBookId = value
        End Set
    End Property

    Public Sub New(bookService As IBookService, loanService As ILoanService, GetBookCount As Action)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _bookService = bookService
        _loanService = loanService
        _updateBookCountMethod = GetBookCount
        AddHandler BooksDataGridView.SelectionChanged, AddressOf OnSelectedBookChanged
    End Sub

    Private Async Sub BookView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadBooks()
    End Sub

    Private Sub OnSelectedBookChanged(sender As Object, e As EventArgs)
        Dim selectedRows = CType(sender, DataGridView).SelectedRows

        If selectedRows.Count > 0 Then
            SelectedBookId = selectedRows(0).Cells("ID").Value
        End If

        ViewBookDetailsButtons.Enabled = SelectedBookId > 0
        EditBookButton.Enabled = SelectedBookId > 0
        DeleteBookButton.Enabled = SelectedBookId > 0
    End Sub

    ''' <summary>
    ''' Show the list of books on db
    ''' </summary>
    ''' <returns></returns>
    Private Async Function LoadBooks() As Task
        Try

            Await Task.Delay(1)

            BookViewToolStripStatusLabel.Text = "Loading Books..."

            Dim books = Await Task.Run(Function() _bookService.GetBooks())

            Dim dataTable = New BookDataTable(books)
            BooksDataGridView.DataSource = dataTable.Build(Function(b) b.Id)

            BookViewToolStripStatusLabel.Text = $"Found ({books.Count()}) books"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Seach filters from books
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub searchBookButton_Click(sender As Object, e As EventArgs) Handles searchBookButton.Click
        Try
            Integer.TryParse(idBookTextBox.Text, IdBook)
            nameBook = nameBookTextBox.Text
            authorBook = autorBookTextBox.Text

            Dim books = Await Task.Run(Function() _bookService.GetBooks())

            If IdBook > 0 Then
                books = books.Where(Function(b) b.Id.ToString().Contains(IdBook))
            End If

            If nameBook.Length > 0 Then
                books = books.Where(Function(b) b.Title.ToString().Contains(nameBook))
            End If

            If authorBook.Length > 0 Then
                books = books.Where(Function(b) b.Author.ToString().Contains(authorBook))
            End If

            Dim dataTable = New BookDataTable(books)
            BooksDataGridView.DataSource = dataTable.Build(Function(b) b.Id)
            BookViewToolStripStatusLabel.Text = $"Found ({books.Count()}) books"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ViewBookDetailsButtons_Click(sender As Object, e As EventArgs) Handles ViewBookDetailsButtons.Click
        Try
            Dim bookDetailsView = New BookDetailsView(_bookService, _loanService, SelectedBookId)
            bookDetailsView.Show(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub EditBookButton_Click(sender As Object, e As EventArgs) Handles EditBookButton.Click
        OnSelectedBookChanged(BooksDataGridView, EventArgs.Empty)
        Try
            If SelectedBookId > 0 Then
                Dim bookId As Integer = CInt(BooksDataGridView.SelectedRows(0).Cells("ID").Value)
                Dim books = Await Task.Run(Function() _bookService.GetBooks())
                Dim book = books.FirstOrDefault(Function(b) b.Id = bookId)
                If book IsNot Nothing Then
                    Dim bookViewUpdate As UpdateBookView = New UpdateBookView(_bookService, book)
                    bookViewUpdate.ShowDialog()
                    Await LoadBooks()
                End If
            Else
                MessageBox.Show("Book not Found.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Async Sub DeleteBookButton_Click(sender As Object, e As EventArgs) Handles DeleteBookButton.Click
        OnSelectedBookChanged(BooksDataGridView, EventArgs.Empty)
        Try
            If SelectedBookId > 0 Then

                Dim selectedBookId As Integer = CInt(BooksDataGridView.SelectedRows(0).Cells("Id").Value)
                Dim books = Await Task.Run(Function() _bookService.GetBooks())

                Dim book = books.FirstOrDefault(Function(b) b.Id = selectedBookId)
                If book IsNot Nothing Then
                    If _bookService.IsBookAvailable(book.Id) = False Then
                        MessageBox.Show("You can´t delete this book, because is loan.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else

                        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this Book?",
                                                            "Confirm Delete",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question)
                        If confirmResult = DialogResult.Yes Then
                            _bookService.DeleteBook(book)
                            MessageBox.Show("Book Deleted")
                            _updateBookCountMethod.Invoke()
                            Await LoadBooks()
                        End If
                    End If
                End If
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
    Private Sub NewSearchButton_Click(sender As Object, e As EventArgs) Handles NewSearchBookButton.Click
        idBookTextBox.Text = ""
        nameBookTextBox.Text = ""
        autorBookTextBox.Text = ""
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeBookButton.Click
        Close()
    End Sub


End Class