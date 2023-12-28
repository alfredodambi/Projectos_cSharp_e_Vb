Imports Dapper
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Namespace Repositories
    Public Class LoanRepository
        Implements ILoanRepository

        ' database
        Private ReadOnly _dataAccessFactory As DataAccessFactory(Of IDbConnection)

        Public Sub New(dataAccessFactory As DataAccessFactory(Of IDbConnection))
            _dataAccessFactory = dataAccessFactory
        End Sub

        Public Function [Get](id As Integer) As Loan Implements IRepository(Of Integer, Loan).Get
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "SELECT l.Id, l.StartDate, l.ExpiryDate, l.ReturnedOn, bk.*, br.* FROM Loans AS l
                    JOIN Books AS bk ON bk.Id = l.Book_Id
                    JOIN Borrowers AS br ON br.Id = l.Borrower_Id
                WHERE Id = @id"
                Dim mapCallback = Function(loan As Loan, book As Book, borrower As Borrower)
                                      If (loan IsNot Nothing) Then
                                          If (book IsNot Nothing) Then
                                              loan.Book = book
                                          End If
                                          If (borrower IsNot Nothing) Then
                                              loan.Borrower = borrower
                                          End If
                                      End If
                                      Return loan
                                  End Function
                Return connection.Query(sqlCommand, mapCallback, New With {id}).SingleOrDefault()
            End Using
        End Function

        Public Function GetAll() As IEnumerable(Of Loan) Implements IRepository(Of Integer, Loan).GetAll
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "SELECT * FROM Loans
                    LEFT JOIN Books ON Books.Id = Loans.Book_Id
                    LEFT JOIN Borrowers ON Borrowers.Id = Loans.Borrower_Id"
                Dim mapCallback = Function(loan As Loan, book As Book, borrower As Borrower)
                                      If (loan IsNot Nothing) Then
                                          If (book IsNot Nothing) Then
                                              loan.Book = book
                                          End If
                                          If (borrower IsNot Nothing) Then
                                              loan.Borrower = borrower
                                          End If
                                      End If
                                      Return loan
                                  End Function
                Return connection.Query(sqlCommand, mapCallback)
            End Using
        End Function

        Public Function Create(entity As Loan) As Loan Implements IRepository(Of Integer, Loan).Create
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "INSERT INTO Loans(Book_Id, Borrower_Id, StartDate, ExpiryDate) 
                    OUTPUT INSERTED.* 
                VALUES (@Book_Id, @Borrower_Id, @StartDate, @ExpiryDate)"
                Dim param = New With {
                    .Book_Id = entity.Book.Id,
                    .Borrower_Id = entity.Borrower.Id,
                    entity.StartDate,
                    entity.ExpiryDate
                }
                Return connection.QuerySingleOrDefault(Of Loan)(sqlCommand, param)
            End Using
        End Function

        Public Function Update(id As Integer, entity As Loan) As Loan Implements IRepository(Of Integer, Loan).Update
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "UPDATE Loans SET StartDate=@StartDate, ExpiryDate=@ExpiryDate, ReturnedOn=@ReturnedOn
                    OUTPUT INSERTED.* 
                WHERE Id = @Id"
                Return connection.QuerySingleOrDefault(Of Loan)(sqlCommand, entity)
            End Using
        End Function

        Public Function Delete(id As Integer) As Boolean Implements IRepository(Of Integer, Loan).Delete
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "DELETE FROM Loans WHERE Id = @id"
                Dim affectedRows = connection.Execute(sqlCommand, New With {.id = id})
                Return affectedRows > 0
            End Using
        End Function
    End Class
End Namespace