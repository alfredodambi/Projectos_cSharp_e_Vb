Imports System.Data.Entity
Imports System.Runtime.Remoting
Imports MVC.Domain.Interfaces
Imports MVC.Domain.Models

Namespace Repository
    Public Class ClientRepository
        Implements IClientRepository


        Private ReadOnly _connectionString As String

        Public Sub New(connectionString As String)
            _connectionString = connectionString
        End Sub
        Public Sub Create(client As Client) Implements IRepository(Of Client).Create
            Using context = New Context(_connectionString)
                If Not context.Clients.Any(Function(c) c.Name = client.Name) Then
                    context.Clients.Add(client)
                    context.SaveChanges()
                End If
            End Using
        End Sub

        Public Sub Update(client As Client) Implements IRepository(Of Client).Update
            Using context = New Context(_connectionString)
                If Not context.Clients.Any(Function(c) c.Name = client.Name) Then
                    context.Entry(client).State = EntityState.Modified
                    context.SaveChanges()
                End If
            End Using
        End Sub

        Public Sub Delete(id As Integer) Implements IRepository(Of Client).Delete
            Using context = New Context(_connectionString)
                Dim client = context.Clients.Find(id)
                If client IsNot Nothing Then
                    context.Clients.Remove(client)
                    context.SaveChanges()
                End If
            End Using
        End Sub

        Public Function GetName(name As String) As IEnumerable(Of Client) Implements IClientRepository.GetName
            Using context = New Context(_connectionString)
                Return context.Clients.Where(Function(c) c.Name.Contains(name)).ToList
            End Using
        End Function

        Public Function GetEmail(email As String) As IEnumerable(Of Client) Implements IClientRepository.GetEmail
            Using context = New Context(_connectionString)
                Return context.Clients.Where(Function(c) c.Email.Contains(email)).ToList
            End Using
        End Function

        Public Function GetAddress(address As String) As IEnumerable(Of Client) Implements IClientRepository.GetAddress
            Using context = New Context(_connectionString)
                Return context.Clients.Where(Function(c) c.Address.Contains(address)).ToList
            End Using
        End Function

        Public Function GetAll() As IEnumerable(Of Client) Implements IRepository(Of Client).GetAll
            Using context = New Context(_connectionString)
                Return context.Clients.ToList
            End Using
        End Function

        Public Function GetById(id As Integer) As Client Implements IRepository(Of Client).GetById
            Using context = New Context(_connectionString)
                Return context.Clients.Find(id)
            End Using
        End Function
    End Class
End Namespace