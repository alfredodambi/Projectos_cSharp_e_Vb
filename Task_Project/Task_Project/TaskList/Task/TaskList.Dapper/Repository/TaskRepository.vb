Imports System.Data.SqlClient
Imports Dapper
Imports TaskList.Domain.Interfaces
Imports TaskList.Domain.Models

Namespace Repository
    Public Class TaskRepository
        Implements ITaskRepository

        Private ReadOnly _connectionString As String

        Public Sub New(connectionString As String)
            _connectionString = connectionString
        End Sub
        Public Sub Create(task As Tasks) Implements IRepository(Of Tasks).Create
            Using _connection As New SqlConnection(_connectionString)
                Dim commandSql As String = "INSERT INTO Task (Name, State) VALUES (@Name, @State)"
                _connection.Execute(commandSql, New With {task.Name, task.State})
            End Using
        End Sub

        Public Sub Update(task As Tasks) Implements IRepository(Of Tasks).Update
            Dim taskId = GetById(task.Id)
            Using _connection As New SqlConnection(_connectionString)
                Dim sqlCommand As String = "UPDATE Task SET Name = @Name, State = @State WHERE Id = @Id"
                Dim updatedLine As Integer = _connection.Execute(sqlCommand, New With {.Name = task.Name, .State = task.State, .Id = task.Id})
            End Using
        End Sub

        Public Sub Delete(id As Integer) Implements IRepository(Of Tasks).Delete
            Using _connection As New SqlConnection(_connectionString)
                Dim sqlCommand As String = "DELETE FROM Task WHERE Id = @Id"
                Dim deletedLine As Integer = _connection.Execute(sqlCommand, New With {.Id = id})
            End Using
        End Sub

        Public Function GetByName(name As String) As IEnumerable(Of Tasks) Implements ITaskRepository.GetByName
            Dim result As List(Of Tasks)
            Using _connection As New SqlConnection(_connectionString)
                Dim sqlCommand As String = "SELECT * FROM Task WHERE Name = @Name"
                result = _connection.Query(Of Tasks)(sqlCommand, New With {.Name = name})
            End Using
            Return result
        End Function

        Public Function GetAll() As IEnumerable(Of Tasks) Implements IRepository(Of Tasks).GetAll
            Dim result As List(Of Tasks)
            Using _connection As New SqlConnection(_connectionString)
                Dim sqlCommand As String = "SELECT * FROM Task"
                result = _connection.Query(Of Tasks)(sqlCommand).ToList()
            End Using
            Return result
        End Function

        Public Function GetById(id As Integer) As Tasks Implements IRepository(Of Tasks).GetById
            Dim result As Tasks
            Using _connection As New SqlConnection(_connectionString)
                Dim sqlCommand As String = "SELECT * FROM Task WHERE Id = @Id"
                result = _connection.QueryFirstOrDefault(Of Tasks)(sqlCommand, New With {.Id = id})
            End Using
            Return result
        End Function
    End Class
End Namespace