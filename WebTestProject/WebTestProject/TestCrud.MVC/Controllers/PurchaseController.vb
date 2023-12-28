Imports System.Web.Mvc
Imports System.Web.Services.Description
Imports MVC.Domain.Interfaces
Imports MVC.Domain.Models
Imports MVC.Domain.Services
Imports MVC.EntityFramework.Repository
Imports TestCrud.MVC.Models

Namespace Controllers
    <Authorize>
    Public Class PurchaseController
        Inherits Controller


        Private ReadOnly _connectionString = ConfigurationManager.ConnectionStrings("ConexaoDB").ConnectionString

        Private ReadOnly _purchaseRepository As IPurchaseRepository = New PurchaseRepository(_connectionString)
        Private ReadOnly _purchaseService As IPurchaseService = New PurchaseService(_purchaseRepository)

        Private ReadOnly _productRepository As IProductRepository = New ProductRepository(_connectionString)
        Private ReadOnly _productService As IProductService = New ProductService(_productRepository)

        Private ReadOnly _clientRepository As IClientRepository = New ClientRepository(_connectionString)
        Private ReadOnly _clientService As IClientService = New ClientService(_clientRepository)
        ' GET: Purchase
        Function Index() As ActionResult
            Dim purchases = _purchaseService.GetAllPurchase()
            Return View(purchases)
        End Function

        ' GET: Purchase/Details/5
        <CustomAuthorizeAttribute(Roles:="Admin,Alfredo")>
        Function Details(ByVal id As Integer) As ActionResult
            Dim purchase = _purchaseService.GetPurchaseById(id)
            If purchase IsNot Nothing Then
                Return View(purchase)
            End If
            Return RedirectToAction("Index")
        End Function

        ' GET: Purchase/Create
        <CustomAuthorizeAttribute(Roles:="Admin,Alfredo")>
        Function Create() As ActionResult
            Try
                'Get all the product and Client
                Dim productList As List(Of Product) = _productService.GetAllProduct()
                Dim clientList As List(Of Client) = _clientService.GetAllClient()

                'Conerting the list em SelectList
                Dim productSelectList As New SelectList(productList, "Id", "Name")
                Dim clientSelectList As New SelectList(clientList, "Id", "Name")

                ViewData("Products") = productSelectList
                ViewData("Clients") = clientSelectList

                Return View()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' POST: Purchase/Create
        <HttpPost()>
        Function Create(ByVal purchase As Purchase) As ActionResult
            Try
                If ModelState.IsValid Then
                    _purchaseService.CreatePurchase(purchase)
                    TempData("SuccessMessage") = "Registado com sucesso"
                    ModelState.Clear()
                End If
                Return View()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' GET: Purchase/Edit/5
        <CustomAuthorizeAttribute(Roles:="Admin,Alfredo")>
        Function Edit(ByVal id As Integer) As ActionResult
            Try
                Dim purchase = _purchaseService.GetPurchaseById(id)
                If purchase IsNot Nothing Then
                    Return View(purchase)
                End If
                Return RedirectToAction("Index")
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' POST: Purchase/Edit/5
        <HttpPost()>
        Function Edit(newPurchase As Purchase) As ActionResult
            Try
                If ModelState.IsValid Then
                    _purchaseService.UpdatePurchase(newPurchase)
                    TempData("SuccessMessage") = "Dados Actualizado com sucesso!"
                    ModelState.Clear()
                    Return RedirectToAction("Index")
                End If
                Return View()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' GET: Purchase/Delete/5
        <CustomAuthorizeAttribute(Roles:="Admin,Alfredo")>
        Function Delete(ByVal id As Integer) As ActionResult
            Try
                Dim purchase = _purchaseService.GetPurchaseById(id)
                If purchase IsNot Nothing Then
                    Return View(purchase)
                End If
                Return RedirectToAction("Index")
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' POST: Purchase/Delete/5
        <HttpPost()>
        Function ConfirmDelete(Id As Integer) As ActionResult
            Try

                _purchaseService.DeletePurchase(Id)
                TempData("SuccessMessage") = "Compra eliminada com sucesso!"
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        'Private Sub LoadNamesForPurchase(purchase As Purchase)
        '    Dim client As Client = _clientService.GetClientById(purchase.ClientId)
        '    Dim product As Product = _productService.GetProductById(purchase.ProductId)

        '    If client IsNot Nothing Then
        '        purchase.ClientId = client.Name
        '    End If

        '    If product IsNot Nothing Then
        '        purchase.ProductId = product.Name
        '    End If
        'End Sub
    End Class
End Namespace