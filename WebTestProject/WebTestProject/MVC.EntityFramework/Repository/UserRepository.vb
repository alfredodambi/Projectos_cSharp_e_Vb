Imports System.Data.Entity
Imports Microsoft.VisualBasic.ApplicationServices
Imports MVC.Domain.Interfaces
Imports MVC.Domain.Models
Imports MVC.EntityFramework.Repository

Namespace Repository
    Public Class UserRepository
        Implements IUserRepository

        Private ReadOnly _connectionString As String

        Public Sub New(connectionString As String)
            _connectionString = connectionString
        End Sub

        Public Sub Create(users As Users) Implements IRepository(Of Users).Create
            Using context = New Context(_connectionString)
                If Not context.Users.Any(Function(p) p.UserName = users.UserName) Then
                    context.Users.Add(users)
                    context.SaveChanges()
                End If
            End Using
        End Sub

        Public Sub Update(users As Users) Implements IRepository(Of Users).Update
            Using context = New Context(_connectionString)
                context.Entry(users).State = EntityState.Modified
                context.SaveChanges()
            End Using
        End Sub

        Public Sub Delete(id As Integer) Implements IRepository(Of Users).Delete
            Using context = New Context(_connectionString)
                Dim user = context.Users.Find(id)
                context.Users.Remove(user)
                context.SaveChanges()
            End Using
        End Sub

        Public Function Login(user As Users) As Boolean Implements IUserRepository.Login
            Using context = New Context(_connectionString)
                If user IsNot Nothing Then
                    Dim isValidUser = context.Users.Any(Function(u) u.UserName.ToLower() = user.UserName.ToLower AndAlso u.UserPassword = user.UserPassword)
                    Return isValidUser
                End If
            End Using
            Return False
        End Function

        Public Function GetAll() As IEnumerable(Of Users) Implements IRepository(Of Users).GetAll
            Using context = New Context(_connectionString)
                Return context.Users.ToList
            End Using
        End Function

        Public Function GetById(id As Integer) As Users Implements IRepository(Of Users).GetById
            Using context = New Context(_connectionString)
                Dim user = context.Users.Find(id)
                Return user
            End Using
        End Function
    End Class
End Namespace