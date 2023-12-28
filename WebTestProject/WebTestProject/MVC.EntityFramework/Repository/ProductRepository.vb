Imports System.Data.Entity
Imports MVC.Domain.Models
Imports MVC.Domain.Interfaces

Namespace Repository
    Public Class ProductRepository
        Implements IProductRepository


        Private ReadOnly _connectionString As String

        Public Sub New(connectionString As String)
            _connectionString = connectionString
        End Sub
        Public Sub Create(product As Product) Implements IRepository(Of Product).Create
            Using _context = New Context(_connectionString)
                If Not _context.Products.Any(Function(p) p.Name = product.Name) Then
                    _context.Products.Add(product)
                    _context.SaveChanges()
                End If
            End Using
        End Sub

        Public Sub Update(product As Product) Implements IRepository(Of Product).Update
            Using _context = New Context(_connectionString)
                If Not _context.Products.Any(Function(p) p.Name = product.Name) Then
                    _context.Entry(product).State = EntityState.Modified
                    _context.SaveChanges()
                End If
            End Using
        End Sub

        Public Sub Delete(id As Integer) Implements IRepository(Of Product).Delete
            Using _context = New Context(_connectionString)
                Dim product As Product = _context.Products.Find(id)
                If product IsNot Nothing Then
                    _context.Products.Remove(product)
                    _context.SaveChanges()
                End If
            End Using
        End Sub

        Public Function GetByName(name As String) As IEnumerable(Of Product) Implements IProductRepository.GetByName
            Using _context = New Context(_connectionString)
                Return _context.Products.Where(Function(p) p.Name.Contains(name)).ToList()
            End Using
        End Function

        Public Function GetByPrice(price As Decimal) As IEnumerable(Of Product) Implements IProductRepository.GetByPrice
            Using _context = New Context(_connectionString)
                Return _context.Products.Where(Function(p) p.Price = price).ToList()
            End Using
        End Function

        Public Function GetAll() As IEnumerable(Of Product) Implements IRepository(Of Product).GetAll
            Using _context = New Context(_connectionString)
                Return _context.Products.ToList
            End Using
        End Function

        Public Function GetById(id As Integer) As Product Implements IRepository(Of Product).GetById
            Using _context = New Context(_connectionString)
                Dim product As Product = _context.Products.Find(id)
                Return product
            End Using
        End Function
    End Class
End Namespace