Imports System.Data.Entity
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
            Using _context = New Context(_connectionString)
                If task IsNot Nothing Then
                    _context.Taskes.Add(task)
                    _context.SaveChanges()
                End If
            End Using
        End Sub

        Public Sub Update(task As Tasks) Implements IRepository(Of Tasks).Update
            Using _context = New Context(_connectionString)
                If task IsNot Nothing Then
                    _context.Entry(task).State = EntityState.Modified
                    _context.SaveChanges()
                End If
            End Using
        End Sub

        Public Sub Delete(id As Integer) Implements IRepository(Of Tasks).Delete
            Using _context = New Context(_connectionString)
                Dim task = _context.Taskes.Find(id)
                If task IsNot Nothing Then
                    _context.Taskes.Remove(task)
                    _context.SaveChanges()
                End If
            End Using
        End Sub

        Public Function GetByName(name As String) As IEnumerable(Of Tasks) Implements ITaskRepository.GetByName
            Using _context = New Context(_connectionString)
                Return _context.Taskes.Where(Function(t) t.Name.Contains(name)).ToList()
            End Using
        End Function

        Public Function GetAll() As IEnumerable(Of Tasks) Implements IRepository(Of Tasks).GetAll
            Using _context = New Context(_connectionString)
                Return _context.Taskes.ToList
            End Using
        End Function

        Public Function GetById(id As Integer) As Tasks Implements IRepository(Of Tasks).GetById
            Using _context = New Context(_connectionString)
                Dim task = _context.Taskes.Find(id)
                Return task
            End Using
        End Function
    End Class
End Namespace