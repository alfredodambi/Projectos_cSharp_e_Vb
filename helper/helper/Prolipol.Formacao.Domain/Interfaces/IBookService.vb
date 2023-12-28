Imports Prolipol.Formacao.Domain.Events
Imports Prolipol.Formacao.Domain.Models

Namespace Interfaces
    Public Interface IBookService
        Event BookAdded As EventHandler(Of BookAddedEventArgs)
        Sub AddBook(book As Book)
        Function GetBook(id As Integer) As Book
        Function GetBookByTitle(title As String) As Book
        Function GetBooks() As IEnumerable(Of Book)
        Function UpdateBook(book As Book) As Boolean
        Function IsBookAvailable(bookId As Integer) As Boolean
        Sub DeleteBook(book As Book)
    End Interface
End Namespace