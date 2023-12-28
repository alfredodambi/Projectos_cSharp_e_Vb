Imports System.Runtime.InteropServices
Imports System.Web.Mvc
'Imports MVC.Dapper.Repository
Imports MVC.EntityFramework.Repository
Imports MVC.Domain.Interfaces
Imports MVC.Domain.Services
Imports MVC.Domain.Models
Imports TestCrud.MVC.Models

Namespace Controllers
    <Authorize>
    Public Class ProductController
        Inherits Controller

        Public connectionString As String = ConfigurationManager.ConnectionStrings("ConexaoDb").ConnectionString


        Private ReadOnly _productRepository As IRepository(Of Product) = New ProductRepository(connectionString)
        Private ReadOnly _productService As IProductService = New ProductService(_productRepository)


        'GET PARTS - Get the data from the form on the view 

        ' GET: Product
        Function Index(searchString As String) As ActionResult
            'Personalize for the search
            Dim products = If(String.IsNullOrEmpty(searchString), _productService.GetAllProduct(), _productService.GetByName(searchString))
            Return View(products)
        End Function

        'Get: /Product/Create
        <CustomAuthorizeAttribute(Roles:="Admin,Alfredo")>
        Function Create() As ActionResult
            Try
                Return View(New Product())
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'Get: /Product/Details
        <CustomAuthorizeAttribute(Roles:="Admin,Alfredo")>
        Function Details(id As Integer) As ActionResult
            Try
                'Get the Product in The list
                Dim product As Product = _productService.GetProductById(id)

                If product Is Nothing Then
                    Return HttpNotFound()
                End If

                Return View(product)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'Get: /Product/Edit/
        <CustomAuthorizeAttribute(Roles:="Alfredo")>
        Function Edit(id As Integer) As ActionResult
            Try
                'Get the product in the list
                Dim product As Product = _productService.GetProductById(id)

                If product Is Nothing Then
                    Return HttpNotFound()
                End If

                Return View(product)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'Get /Product/Delete
        <CustomAuthorizeAttribute(Roles:="Alfredo")>
        Function Delete(id As Integer) As ActionResult
            Try
                'Get the product in the list
                Dim product = _productService.GetProductById(id)
                If product IsNot Nothing Then
                    Return View(product)
                End If
                Return RedirectToAction("Index")
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'POST PARTS - used to recieve the data, and the execute actions according the data that is processing

        'POST: /Product/Create
        <HttpPost()>
        Function Create(product As Product) As ActionResult
            Try
                'Check if the model is valid
                If ModelState.IsValid Then
                    'Add new product to the list

                    Dim productExist = _productService.GetAllProduct().Any(Function(p) p.Name = product.Name)

                    If productExist Then
                        ViewData("ErrorMessage") = "Já existe um produto com o mesmo nome."
                    Else
                        'Message when the product was sucessfully created
                        _productService.CreateProduct(product)
                        TempData("SuccessMessage") = "Registado"
                        ModelState.Clear()
                    End If
                End If
                Return View(New Product())
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'POST: /Product/Update
        <HttpPost()>
        Function Edit(newProduct As Product) As ActionResult
            Try
                'Check if the model is valid
                If ModelState.IsValid Then
                    Dim productUpdatedExist = _productService.GetAllProduct().Any(Function(p) p.Name = newProduct.Name)

                    If productUpdatedExist Then
                        ViewData("ErrorMessage") = "Já existe um produto com o mesmo nome."
                    Else
                        _productService.UpdateProduct(newProduct)
                        TempData("SuccessMessage") = "Dados Actualizado com sucesso!"
                        ModelState.Clear()
                    End If
                End If
                Return View("Edit", newProduct)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'POST: /Product/Delete
        <HttpPost()>
        <ActionName("Delete")>
        Function DeleteConfirmed(id As Integer) As ActionResult
            Try
                'Get the product
                _productService.DeleteProduct(id)
                TempData("SuccessMessage") = "Product eliminado com sucesso!"
                Return RedirectToAction("Index")
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
    End Class
End Namespace