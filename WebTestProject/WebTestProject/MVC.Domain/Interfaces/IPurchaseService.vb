Imports MVC.Domain.Models

Namespace Interfaces
    Public Interface IPurchaseService
        Function GetAllPurchase() As IEnumerable(Of Purchase)
        Function GetPurchaseById(id As Integer) As Purchase
        Sub CreatePurchase(purchase As Purchase)
        Sub UpdatePurchase(purchase As Purchase)
        Sub DeletePurchase(id As Integer)
    End Interface
End Namespace