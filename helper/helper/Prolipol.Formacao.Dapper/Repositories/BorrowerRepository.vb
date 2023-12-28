Imports Dapper
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Namespace Repositories
    Public Class BorrowerRepository
        Implements IBorrowerRepository

        ' database
        Private ReadOnly _dataAccessFactory As DataAccessFactory(Of IDbConnection)

        Public Sub New(dataAccessFactory As DataAccessFactory(Of IDbConnection))
            _dataAccessFactory = dataAccessFactory
        End Sub

        Public Function [Get](id As Integer) As Borrower Implements IRepository(Of Integer, Borrower).Get
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim lookup = New Dictionary(Of Integer, Borrower)()
                Dim sqlCommand = "SELECT * FROM Borrowers 
                    LEFT JOIN Loans ON Loans.Borrower_Id = Borrowers.Id 
                        LEFT JOIN Books ON Books.Id = Loans.Book_Id
                WHERE Borrowers.Id = @id"
                Dim mapCallback = Function(borrower As Borrower, loan As Loan, book As Book)
                                      Dim newBorrower As Borrower = Nothing
                                      If Not lookup.TryGetValue(borrower.Id, newBorrower) Then
                                          newBorrower = borrower
                                          lookup.Add(borrower.Id, newBorrower)
                                      End If
                                      If Not IsNothing(loan) Then
                                          loan.Borrower = newBorrower
                                          loan.Book = book
                                      End If
                                      newBorrower.Loans.Add(loan)
                                      Return newBorrower
                                  End Function
                connection.Query(sqlCommand, mapCallback, New With {id}).AsQueryable()
                Return lookup.Values.SingleOrDefault()
            End Using
        End Function

        Public Function GetByName(name As String) As Borrower Implements IBorrowerRepository.GetByName
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim lookup = New Dictionary(Of Integer, Borrower)()
                Dim sqlCommand = "SELECT * FROM Borrowers 
                    LEFT JOIN Loans ON Loans.Borrower_Id = Borrowers.Id 
                        LEFT JOIN Books ON Books.Id = Loans.Book_Id
                WHERE Borrowers.Name = @name"
                Dim mapCallback = Function(borrower As Borrower, loan As Loan, book As Book)
                                      Dim newBorrower As Borrower = Nothing
                                      If Not lookup.TryGetValue(borrower.Id, newBorrower) Then
                                          newBorrower = borrower
                                          lookup.Add(borrower.Id, newBorrower)
                                      End If
                                      If Not IsNothing(loan) Then
                                          loan.Borrower = newBorrower
                                          loan.Book = book
                                      End If
                                      newBorrower.Loans.Add(loan)
                                      Return newBorrower
                                  End Function
                connection.Query(sqlCommand, mapCallback, New With {name}).SingleOrDefault()
                Return lookup.Values.SingleOrDefault()
            End Using
        End Function

        Public Function GetAll() As IEnumerable(Of Borrower) Implements IRepository(Of Integer, Borrower).GetAll
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim lookup = New Dictionary(Of Integer, Borrower)()
                Dim sqlCommand = "SELECT * FROM Borrowers 
                    LEFT JOIN Loans ON Loans.Borrower_Id = Borrowers.Id 
                        LEFT JOIN Books ON Books.Id = Loans.Book_Id"
                Dim mapCallback = Function(borrower As Borrower, loan As Loan, book As Book)
                                      Dim newBorrower As Borrower = Nothing
                                      If Not lookup.TryGetValue(borrower.Id, newBorrower) Then
                                          newBorrower = borrower
                                          lookup.Add(borrower.Id, newBorrower)
                                      End If
                                      If Not IsNothing(loan) Then
                                          loan.Borrower = newBorrower
                                          loan.Book = book
                                      End If
                                      newBorrower.Loans.Add(loan)
                                      Return newBorrower
                                  End Function
                connection.Query(sqlCommand, mapCallback)
                Return lookup.Values.AsEnumerable()
            End Using
        End Function

        Public Function Create(entity As Borrower) As Borrower Implements IRepository(Of Integer, Borrower).Create
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "INSERT INTO Borrowers(Name) OUTPUT INSERTED.* VALUES (@Name)"
                Return connection.QuerySingleOrDefault(Of Borrower)(sqlCommand, entity)
            End Using
        End Function

        Public Function Update(id As Integer, entity As Borrower) As Borrower Implements IRepository(Of Integer, Borrower).Update
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "UPDATE Borrowers SET Name=@Name  OUTPUT INSERTED.* WHERE Id = @Id"
                Return connection.QuerySingleOrDefault(Of Borrower)(sqlCommand, entity)
            End Using
        End Function

        Public Function Delete(id As Integer) As Boolean Implements IRepository(Of Integer, Borrower).Delete
            Using connection = _dataAccessFactory.CreateDbConnection()
                Dim sqlCommand = "DELETE FROM Borrowers WHERE Id = @id"
                Dim affectedRows = connection.Execute(sqlCommand, New With {.id = id})
                Return affectedRows > 0
            End Using
        End Function
    End Class
End Namespace