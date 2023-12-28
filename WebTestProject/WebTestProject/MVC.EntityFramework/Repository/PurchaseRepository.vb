Imports System.Data.Entity
Imports MVC.Domain.Interfaces
Imports MVC.Domain.Models

Namespace Repository
    Public Class PurchaseRepository
        Implements IPurchaseRepository

        Private ReadOnly _connectionString As String

        Public Sub New(connectionString As String)
            _connectionString = connectionString
        End Sub

        Public Sub Create(purchase As Purchase) Implements IRepository(Of Purchase).Create
            If purchase IsNot Nothing Then
                Using _context = New Context(_connectionString)
                    _context.Purchases.Add(purchase)
                    _context.SaveChanges()
                End Using
            End If
        End Sub

        Public Sub Update(purchase As Purchase) Implements IRepository(Of Purchase).Update
            If purchase IsNot Nothing Then
                Using _context = New Context(_connectionString)
                    _context.Entry(purchase).State = EntityState.Modified
                    _context.SaveChanges()
                End Using
            End If
        End Sub

        Public Sub Delete(id As Integer) Implements IRepository(Of Purchase).Delete
            Using _context = New Context(_connectionString)
                Dim purchase = _context.Purchases.Find(id)
                _context.Purchases.Remove(purchase)
                _context.SaveChanges()
            End Using
        End Sub

        Public Function GetAll() As IEnumerable(Of Purchase) Implements IRepository(Of Purchase).GetAll
            Using _context = New Context(_connectionString)
                Return _context.Purchases.ToList
            End Using
        End Function

        Public Function GetById(id As Integer) As Purchase Implements IRepository(Of Purchase).GetById
            Using _context = New Context(_connectionString)
                Return _context.Purchases.Find(id)
            End Using
        End Function
    End Class
End Namespace