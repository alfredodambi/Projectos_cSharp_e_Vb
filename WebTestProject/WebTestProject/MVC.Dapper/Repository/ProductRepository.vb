Imports System.Data.SqlClient
Imports Dapper
Imports MVC.Domain.Models
Imports MVC.Domain.Interfaces

Namespace Repository
    Public Class ProductRepository
        Implements IProductRepository

        Private ReadOnly _connectionString As String


        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="connectionString"></param>
        Public Sub New(connectionString As String)
            _connectionString = connectionString
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="product"></param>
        Public Sub Create(product As Product) Implements IRepository(Of Product).Create
            Using connection As New SqlConnection(_connectionString)
                Dim commandSql As String = "INSERT INTO Product (Name, Price) VALUES (@Name, @Price)"
                connection.Execute(commandSql, New With {product.Name, product.Price})
            End Using
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="product"></param>
        Public Sub Update(product As Product) Implements IRepository(Of Product).Update
            Dim productId = GetById(product.Id)
            Using connnection As New SqlConnection(_connectionString)
                Dim commandSql As String = "UPDATE Product SET Name = @Name, Price = @Price WHERE Id = @Id"
                Dim updateLine As Integer = connnection.Execute(commandSql, New With {.Name = product.Name, .Price = product.Price, .Id = product.Id})
            End Using
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="id"></param>
        Public Sub Delete(id As Integer) Implements IRepository(Of Product).Delete
            Using connection As New SqlConnection(_connectionString)
                Dim commandSql As String = "DELETE FROM Product WHERE Id = @Id"
                Dim removedLine As Integer = connection.Execute(commandSql, New With {.Id = id})
            End Using
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="name"></param>
        ''' <returns></returns>
        Public Function GetByName(name As String) As IEnumerable(Of Product) Implements IProductRepository.GetByName
            Dim result As List(Of Product)
            Using connection As New SqlConnection(_connectionString)
                Dim commandSql As String = "SELECT * FROM Product WHERE Name = @Name"
                result = connection.Query(Of Product)(commandSql, New With {.Name = name})
                Return result
            End Using
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="price"></param>
        ''' <returns></returns>
        Public Function GetByPrice(price As Decimal) As IEnumerable(Of Product) Implements IProductRepository.GetByPrice
            Dim result As List(Of Product)
            Using connection As New SqlConnection(_connectionString)
                Dim commandSql As String = "SELECT * FROM Product WHERE Price = @Price"
                result = connection.Query(Of Product)(commandSql, New With {.Price = price})
                Return result
            End Using
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Function GetAll() As IEnumerable(Of Product) Implements IRepository(Of Product).GetAll
            Dim result As List(Of Product)
            Using connection As New SqlConnection(_connectionString)
                Dim commandSql As String = "SELECT * FROM Product"
                result = connection.Query(Of Product)(commandSql).ToList()
            End Using
            Return result
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Function GetById(id As Integer) As Product Implements IRepository(Of Product).GetById
            Dim result As Product
            Using connection As New SqlConnection(_connectionString)
                Dim commandSql As String = "SELECT * FROM Product WHERE Id = @Id"
                result = connection.QueryFirstOrDefault(Of Product)(commandSql, New With {.Id = id})
            End Using
            Return result
        End Function
    End Class
End Namespace