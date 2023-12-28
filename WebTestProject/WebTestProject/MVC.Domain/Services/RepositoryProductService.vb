Imports MVC.Domain.Interfaces
Imports MVC.Domain.Models

Namespace Services
    Public Class RepositoryProductService
        Implements IProductRepository

        Private Shared _listProduct As New List(Of Product)()

        Public Sub Create(product As Product) Implements IRepository(Of Product).Create
            Dim nextId As Integer = If(_listProduct.Any(), _listProduct.Max(Function(p) p.Id) + 1, 1)
            product.Id = nextId
            _listProduct.Add(product)
        End Sub

        Public Sub Update(product As Product) Implements IRepository(Of Product).Update
            Dim products = _listProduct.FirstOrDefault(Function(p) p.Id = product.Id)
            If products IsNot Nothing Then
                products.Name = product.Name
                products.Price = product.Price
            End If
        End Sub

        Public Sub Delete(id As Integer) Implements IRepository(Of Product).Delete
            Dim product = _listProduct.FirstOrDefault(Function(p) p.Id = id)
            If product IsNot Nothing Then
                _listProduct.Remove(product)
            End If
        End Sub

        Public Function GetAll() As IEnumerable(Of Product) Implements IRepository(Of Product).GetAll
            Return _listProduct
        End Function

        Public Function GetById(id As Integer) As Product Implements IRepository(Of Product).GetById
            Return _listProduct.FirstOrDefault(Function(p) p.Id = id)
        End Function

        Public Function GetByName(name As String) As IEnumerable(Of Product) Implements IProductRepository.GetByName
            Return _listProduct.Where(Function(p) p.Name.Contains(name)).ToList
        End Function

        Public Function GetByPrice(price As Decimal) As IEnumerable(Of Product) Implements IProductRepository.GetByPrice
            Return _listProduct.Where(Function(p) p.Id = price OrElse p.Price = price).ToList()
        End Function
    End Class
End Namespace