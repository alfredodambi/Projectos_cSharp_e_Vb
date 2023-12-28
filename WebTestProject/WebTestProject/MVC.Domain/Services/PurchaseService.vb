Imports MVC.Domain.Interfaces
Imports MVC.Domain.Models

Namespace Services
    Public Class PurchaseService
        Implements IPurchaseService

        Private ReadOnly _purchaseRepository As IPurchaseRepository

        Public Sub New(purchaseRepository As IPurchaseRepository)
            _purchaseRepository = purchaseRepository
        End Sub
        Public Sub CreatePurchase(purchase As Purchase) Implements IPurchaseService.CreatePurchase
            If purchase IsNot Nothing Then
                _purchaseRepository.Create(purchase)
            End If
        End Sub

        Public Sub UpdatePurchase(purchase As Purchase) Implements IPurchaseService.UpdatePurchase
            If purchase IsNot Nothing Then
                _purchaseRepository.Update(purchase)
            End If
        End Sub

        Public Sub DeletePurchase(id As Integer) Implements IPurchaseService.DeletePurchase
            _purchaseRepository.Delete(id)
        End Sub

        Public Function GetAllPurchase() As IEnumerable(Of Purchase) Implements IPurchaseService.GetAllPurchase
            Return _purchaseRepository.GetAll()
        End Function

        Public Function GetPurchaseById(id As Integer) As Purchase Implements IPurchaseService.GetPurchaseById
            Return _purchaseRepository.GetById(id)
        End Function
    End Class
End Namespace