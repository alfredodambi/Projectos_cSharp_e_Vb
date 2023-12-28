Imports System.Windows
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models


Public Class NewBookView


    ''' <summary>
    ''' 
    ''' </summary>
    Public bookName As String
    ''' <summary>
    ''' 
    ''' </summary>
    Public authorName As String

    ''' <summary>
    ''' 
    ''' </summary>
    Private _updateBookCountMethod As Action


    Private _bookService As IBookService
    Public Sub New(bookService As IBookService, GetBookCount As Action)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _bookService = bookService
        _updateBookCountMethod = GetBookCount
        AddNewBookButton.Enabled = False
    End Sub

    ''' <summary>
    ''' Craete a new Boook
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddNewBookButton_Click(sender As Object, e As EventArgs) Handles AddNewBookButton.Click
        Try
            'Verify if botho textbox has value
            If NewBookValidating() Then
                'Saving data
                _bookService.AddBook(New Book(bookName, authorName))
                'Show message
                BookToolStripStatusLabel.Text = $"Book Added {bookName}, author: {authorName}."
                'Update the total of book showed on main window
                _updateBookCountMethod.Invoke()
                'Clean the textBoxes
                NewBookResetForm()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Closing the fomr
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CancelNewBookBottom_Click(sender As Object, e As EventArgs) Handles CancelNewBookBottom.Click
        Close()
    End Sub

    ''' <summary>
    ''' Add the textbox value to the property bookName
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bookNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles bookNameTextBox.TextChanged
        bookName = bookNameTextBox.Text
        AddNewBookButton.Enabled = True
    End Sub

    ''' <summary>
    ''' Add the textbox value to the property authorName
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub authorNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles authorNameTextBox.TextChanged
        authorName = authorNameTextBox.Text
        AddNewBookButton.Enabled = True
    End Sub

    ''' <summary>
    ''' Validating the bookName property to don´t acept null or blank space value 
    ''' </summary>
    ''' <returns></returns>
    Private Function BookNameValidating() As Boolean
        If String.IsNullOrWhiteSpace(bookName) Then
            Me.NewBookErrorProvider.SetError(bookNameTextBox, "Please enter the book title")
            Return False
        Else
            Me.NewBookErrorProvider.SetError(bookNameTextBox, String.Empty)
            Return True
        End If
    End Function

    ''' <summary>
    ''' Validating AuthorName
    ''' </summary>
    ''' <returns></returns>
    Private Function AuthorNameValidating() As Boolean
        If String.IsNullOrWhiteSpace(authorName) Then
            Me.NewBookErrorProvider.SetError(authorNameTextBox, "Please enter the author's name")
            Return False
        Else
            Me.NewBookErrorProvider.SetError(authorNameTextBox, String.Empty)
            Return True
        End If
    End Function

    ''' <summary>
    ''' Validating both textboxes that exist in the form
    ''' </summary>
    ''' <returns></returns>
    Private Function NewBookValidating() As Boolean
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

    ''' <summary>
    ''' Clean the textboxes on the form
    ''' </summary>
    Public Sub NewBookResetForm()
        bookNameTextBox.Text = ""
        authorNameTextBox.Text = ""
        AddNewBookButton.Enabled = False
    End Sub


End Class