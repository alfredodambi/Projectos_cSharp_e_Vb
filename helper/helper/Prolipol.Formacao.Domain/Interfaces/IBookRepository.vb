Imports Prolipol.Formacao.Domain.Models

Namespace Interfaces
    Public Interface IBookRepository
        Inherits IRepository(Of Integer, Book)

        Function GetByTitle(ByVal bookTitle As String) As Book
    End Interface
End Namespace