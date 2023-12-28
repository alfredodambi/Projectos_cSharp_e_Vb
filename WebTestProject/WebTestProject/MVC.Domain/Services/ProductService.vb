Imports MVC.Domain.Interfaces
Imports MVC.Domain.Models

Namespace Services
    Public Class ProductService
        Implements IProductService

        Private ReadOnly _repositoryService As IProductRepository

        Public Sub New(repositoryService As IProductRepository)
            _repositoryService = repositoryService
        End Sub

        Public Sub CreateProduct(product As Product) Implements IProductService.CreateProduct
            If product IsNot Nothing Then
                _repositoryService.Create(product)
            End If
        End Sub

        Public Sub UpdateProduct(product As Product) Implements IProductService.UpdateProduct
            If product IsNot Nothing Then
                _repositoryService.Update(product)
            End If
        End Sub

        Public Sub DeleteProduct(id As Integer) Implements IProductService.DeleteProduct
            If id <> 0 Then
                _repositoryService.Delete(id)
            End If
        End Sub

        Public Function GetAllProduct() As IEnumerable(Of Product) Implements IProductService.GetAllProduct
            Return _repositoryService.GetAll()
        End Function

        Public Function GetProductById(id As Integer) As Product Implements IProductService.GetProductById
            Return _repositoryService.GetById(id)
        End Function

        Public Function GetByName(name As String) As IEnumerable(Of Product) Implements IProductService.GetByName
            If String.IsNullOrWhiteSpace(name) Then
                Throw New InvalidCastException("O nome não pode ser vazio ou nulo")
            End If
            Return _repositoryService.GetByName(name)
        End Function

        Public Function GetByPrice(value As Decimal) As IEnumerable(Of Product) Implements IProductService.GetByPrice
            Return _repositoryService.GetByPrice(value)
        End Function
    End Class
End Namespace