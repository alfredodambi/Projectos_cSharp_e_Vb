Imports Prolipol.Formacao.Domain.Events
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Namespace Services
    Public Class BookService
        Implements IBookService

        Private ReadOnly _bookRepository As IBookRepository

        Public Event BookAdded As EventHandler(Of BookAddedEventArgs) Implements IBookService.BookAdded

        ' TODO: Create the events for the service endpoints

        Public Sub New(bookRepository As IBookRepository)
            _bookRepository = bookRepository
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Function GetBooks() As IEnumerable(Of Book) Implements IBookService.GetBooks
            Return _bookRepository.GetAll()
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="book"></param>
        Public Sub AddBook(book As Book) Implements IBookService.AddBook
            ' Validations
            Dim existingBook = _bookRepository.GetByTitle(book.Title)

            If Not IsNothing(existingBook) Then
                Throw New InvalidOperationException("Book already exists")
            End If

            ' Save the book
            Dim insertedBook = _bookRepository.Create(book)

            If IsNothing(insertedBook) Then
                Throw New InvalidOperationException("Unable to register book")
            End If

            RaiseEvent BookAdded(Me, New BookAddedEventArgs(insertedBook))
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="bookId"></param>
        ''' <returns></returns>
        Public Function IsBookAvailable(bookId As Integer) As Boolean Implements IBookService.IsBookAvailable
            If IsNothing(bookId) Then
                Throw New ArgumentNullException(NameOf(bookId))
            End If

            Dim foundBook = _bookRepository.Get(bookId)

            If IsNothing(foundBook) Then
                Throw New InvalidOperationException("Book doesn't exist")
            End If

            Return foundBook.IsAvailable
        End Function

        Public Function GetBook(id As Integer) As Book Implements IBookService.GetBook
            If id < 1 Then
                Throw New ArgumentException(NameOf(id))
            End If

            Dim foundBook = _bookRepository.Get(id)

            Return foundBook
        End Function

        Public Function GetBookByTitle(title As String) As Book Implements IBookService.GetBookByTitle
            If String.IsNullOrWhiteSpace(title) Then
                Throw New ArgumentNullException(NameOf(title))
            End If

            Dim foundBook = _bookRepository.GetByTitle(title)

            Return foundBook
        End Function

        Public Function UpdateBook(book As Book) As Boolean Implements IBookService.UpdateBook
            If book.Id < 1 Then
                Throw New ArgumentException(NameOf(book.Id))
            End If

            Dim foundBook = _bookRepository.Get(book.Id)

            If IsNothing(foundBook) Then
                Throw New InvalidOperationException("Book doesn't exist")
            End If

            Dim updatedBook = _bookRepository.Update(book.Id, book)

            If IsNothing(updatedBook) Then
                Return False
            End If

            Return True
        End Function

        Public Sub DeleteBook(book As Book) Implements IBookService.DeleteBook
            _bookRepository.Delete(book.Id)
        End Sub
    End Class
End Namespace