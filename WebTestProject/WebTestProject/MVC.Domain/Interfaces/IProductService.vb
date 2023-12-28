Imports MVC.Domain.Models

Namespace Interfaces
    Public Interface IProductService

        ''' <summary>
        ''' Get a list of product
        ''' </summary>
        ''' <returns></returns>
        Function GetAllProduct() As IEnumerable(Of Product)

        ''' <summary>
        ''' Get a specify product by Id
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Function GetProductById(id As Integer) As Product

        ''' <summary>
        ''' Create a product
        ''' </summary>
        ''' <param name="product"></param>
        Sub CreateProduct(product As Product)

        ''' <summary>
        ''' Update data of a specify product
        ''' </summary>
        ''' <param name="product"></param>
        Sub UpdateProduct(product As Product)


        ''' <summary>
        ''' Delete a product by Id
        ''' </summary>
        ''' <param name="id"></param>
        Sub DeleteProduct(id As Integer)

        ''' <summary>
        ''' Get a list of product according the name
        ''' </summary>
        ''' <param name="name"></param>
        ''' <returns></returns>
        Function GetByName(name As String) As IEnumerable(Of Product)

        ''' <summary>
        ''' Get a list of product according the id or price
        ''' </summary>
        ''' <param name="value"></param>
        ''' <returns></returns>
        Function GetByPrice(value As Decimal) As IEnumerable(Of Product)
    End Interface
End Namespace