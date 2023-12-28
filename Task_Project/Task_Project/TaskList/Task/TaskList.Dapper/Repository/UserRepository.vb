Imports System.Data.SqlClient
Imports Dapper
Imports TaskList.Domain.Interfaces
Imports TaskList.Domain.Models

Namespace Repository
    Public Class UserRepository
        Implements IUserRepository


        Private ReadOnly _connectionString As String

        Public Sub New(connectionString As String)
            _connectionString = connectionString
        End Sub

        Public Sub Create(user As Users) Implements IRepository(Of Users).Create
            Using _connection As New SqlConnection(_connectionString)
                Dim sqlCommand As String = "INSERT INTO Users (UserName, UserPassword) VALUES (@UserName, @UserPassword)"
                _connection.Execute(sqlCommand, New With {user.UserName, user.UserPassword})
            End Using
        End Sub

        Public Sub Update(user As Users) Implements IRepository(Of Users).Update
            Dim userId = GetById(user.Id)
            Using _connection As New SqlConnection(_connectionString)
                Dim sqlCommand As String = "UPDATE Users SET UserName = @UserName, UserPassword = @UserPassword WHERE Id = @Id"
                Dim updatedLine As Integer = _connection.Execute(sqlCommand, New With {.UserName = user.UserName, .UserPassword = user.UserPassword, .Id = user.Id})
            End Using
        End Sub

        Public Sub Delete(id As Integer) Implements IRepository(Of Users).Delete
            Using _connection As New SqlConnection(_connectionString)
                Dim sqlCommand As String = "DELETE FROM Users WHERE Id = @Id"
                Dim deletedLine As Integer = _connection.Execute(sqlCommand, New With {.Id = id})
            End Using
        End Sub

        Public Function Login(user As Users) As Boolean Implements IUserRepository.Login
            Using _connection As New SqlConnection(_connectionString)
                Dim sqlComand As String = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND UserPassword = @UserPassword"
                Dim userFound = _connection.ExecuteScalar(Of Integer)(sqlComand, New With {.UserName = user.UserName, .UserPassword = user.UserPassword})
                Return userFound > 0
            End Using
        End Function

        Public Function GetAll() As IEnumerable(Of Users) Implements IRepository(Of Users).GetAll
            Dim result As List(Of Users)
            Using _connection As New SqlConnection(_connectionString)
                Dim sqlCommand As String = "SELECT * FROM Users"
                result = _connection.Query(Of Users)(sqlCommand).ToList()
            End Using
            Return result
        End Function

        Public Function GetById(id As Integer) As Users Implements IRepository(Of Users).GetById
            Dim result As Users
            Using _connection As New SqlConnection(_connectionString)
                Dim sqlCommand As String = "SELECT * FROM Users WHERE Id = @Id"
                result = _connection.QueryFirstOrDefault(Of Users)(sqlCommand, New With {.Id = id})
            End Using
            Return result
        End Function
    End Class
End Namespace