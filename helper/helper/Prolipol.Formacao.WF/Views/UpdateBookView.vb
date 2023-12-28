Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Public Class UpdateBookView



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property idBook As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property TitleBook As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property AuthorBook As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property IsAvailableBook As Boolean

    Private ReadOnly _bookService As IBookService
    Private _book As Book

    Public Sub New(bookService As IBookService, book As Book)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        _bookService = bookService
        _book = book
    End Sub

    Private Sub UpdateBookView_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        IdBookTextBox.Text = _book.Id.ToString()
        BookNameTextBox.Text = _book.Title
        AuthorBookTextBox.Text = _book.Author
        IsAvailableBookCheckBox.Checked = _book.IsAvailable
        BookToolStripStatusLabel.Text = "Finished!"
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UpdateBookButton_sClick(sender As Object, e As EventArgs) Handles UpdateBookButton.Click
        If UpdateBookValidateForm() Then

            idBook = IdBookTextBox.Text
            TitleBook = BookNameTextBox.Text
            AuthorBook = AuthorBookTextBox.Text
            IsAvailableBook = Boolean.Parse(If(IsAvailableBookCheckBox.Checked, True, False))

            _book.Id = idBook
            _book.Title = TitleBook
            _book.Author = AuthorBook
            _book.IsAvailable = IsAvailableBook

            Try
                _bookService.UpdateBook(_book)
                BookToolStripStatusLabel.Text = "Book update Sucessfully!"
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CancelBookButton_Click(sender As Object, e As EventArgs) Handles CancelBookButton.Click
        Close()
    End Sub

    ''' <summary>
    ''' Validating the book name
    ''' </summary>
    ''' <returns></returns>
    Private Function BookNameValidating() As Boolean
        If String.IsNullOrWhiteSpace(BookNameTextBox.Text) Then
            Me.UpdateBookErrorProvider.SetError(BookNameTextBox, "Please enter the book title")
            Return False
        Else
            Me.UpdateBookErrorProvider.SetError(BookNameTextBox, String.Empty)
            Return True
        End If
    End Function

    ''' <summary>
    ''' Validating the author Book Names
    ''' </summary>
    ''' <returns></returns>
    Private Function AuthorNameValidating() As Boolean
        If String.IsNullOrWhiteSpace(AuthorBookTextBox.Text) Then
            Me.UpdateBookErrorProvider.SetError(AuthorBookTextBox, "Please enter the author's name")
            Return False
        Else
            Me.UpdateBookErrorProvider.SetError(AuthorBookTextBox, String.Empty)
            Return True
        End If
    End Function

    ''' <summary>
    ''' Validating both textbox in the form
    ''' </summary>
    ''' <returns></returns>
    Private Function UpdateBookValidateForm() As Boolean
        Dim isValid As Boolean = True
        Dim validationErrors As New List(Of String)

        If Not BookNameValidating() Then
            validationErrors.Add("Book title is required.")
            isValid = False
        End If

        If Not AuthorNameValidating() Then
            validationErrors.Add("Author's name is required.")
            isValid = False
        End If

        If Not isValid Then
            Dim errorMessage As String = String.Join(Environment.NewLine, validationErrors)
            MessageBox.Show(errorMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Return isValid
    End Function
End Class