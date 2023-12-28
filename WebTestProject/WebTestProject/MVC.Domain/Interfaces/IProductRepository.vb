Imports MVC.Domain.Models

Namespace Interfaces
    Public Interface IProductRepository
        Inherits IRepository(Of Product)

        ''' <summary>
        ''' GET products by its Name
        ''' </summary>
        ''' <param name="name"></param>
        ''' <returns></returns>
        Function GetByName(name As String) As IEnumerable(Of Product)

        ''' <summary>
        ''' Get products by its prices
        ''' </summary>
        ''' <param name="price"></param>
        ''' <returns></returns>
        Function GetByPrice(price As Decimal) As IEnumerable(Of Product)
    End Interface
End Namespace