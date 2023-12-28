Imports Dapper
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Namespace Repositories
    Public Class BookRepository
        Implements IBookRepository

        ' database
        Private ReadOnly _books As ICollection(Of Book)
        Private ReadOnly _dataAccessFactory As DataAccessFactory(Of IDbConnection)

        Public Sub New(dataAccessFactory As DataAccessFactory(Of IDbConnection))
            _books = New HashSet(Of Book)
            _dataAccessFactory = dataAccessFactory
        End Sub

        Public Function [Get](id As Integer) As Book Implements IRepository(Of Integer, Book).Get
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "SELECT * FROM Books LEFT JOIN Loans ON Loans.Book_Id = Books.Id AND Loans.ReturnedOn <> NULL WHERE Books.Id = @id"
                Dim mapCallback = Function(book As Book, loan As Loan)
                                      If (book IsNot Nothing) And (loan IsNot Nothing) Then
                                          book.LoanTo(loan)
                                      End If
                                      Return book
                                  End Function
                Return connection.Query(sqlCommand, mapCallback, New With {id}).SingleOrDefault()
            End Using
        End Function

        Public Function GetAll() As IEnumerable(Of Book) Implements IRepository(Of Integer, Book).GetAll
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "SELECT * FROM Books LEFT JOIN Loans ON Loans.Book_Id = Books.Id AND Loans.ReturnedOn <> NULL"
                Dim mapCallback = Function(book As Book, loan As Loan)
                                      If (book IsNot Nothing) And (loan IsNot Nothing) Then
                                          book.LoanTo(loan)
                                      End If
                                      Return book
                                  End Function
                Return connection.Query(sqlCommand, mapCallback)
            End Using
        End Function

        Public Function GetByTitle(bookTitle As String) As Book Implements IBookRepository.GetByTitle
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "SELECT * FROM Books INNER JOIN Loans ON Loans.Book_Id = Books.Id AND Loans.ReturnedOn <> NULL WHERE Books.Title = @bookTitle"
                Dim mapCallback = Function(book As Book, loan As Loan)
                                      If Not IsNothing(book) Then
                                          book.LoanTo(loan)
                                      End If
                                      Return book
                                  End Function
                Return connection.Query(sqlCommand, mapCallback, New With {bookTitle}).SingleOrDefault()
            End Using
        End Function

        Public Function Create(entity As Book) As Book Implements IRepository(Of Integer, Book).Create
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "INSERT INTO Books(Title, Author, IsAvailable) OUTPUT INSERTED.* VALUES (@Title, @Author, @IsAvailable)"
                Return connection.QuerySingleOrDefault(Of Book)(sqlCommand, entity)
            End Using
        End Function

        Public Function Update(id As Integer, entity As Book) As Book Implements IRepository(Of Integer, Book).Update
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "UPDATE Books SET Title=@Title, Author=@Author, IsAvailable=@IsAvailable OUTPUT INSERTED.* WHERE Books.Id = @Id"
                Return connection.QuerySingleOrDefault(Of Book)(sqlCommand, entity)
            End Using
        End Function

        Public Function Delete(id As Integer) As Boolean Implements IRepository(Of Integer, Book).Delete
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "DELETE FROM Books WHERE Id = @id"
                Dim affectedRows = connection.Execute(sqlCommand, New With {.id = id})
                Return affectedRows > 0
            End Using
        End Function
    End Class
End Namespace