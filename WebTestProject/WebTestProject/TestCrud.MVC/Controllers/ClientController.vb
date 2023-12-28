Imports System.Net
Imports System.Runtime.Remoting.Contexts
Imports System.Web.Mvc
Imports MVC.Domain.Interfaces
Imports MVC.Domain.Models
Imports MVC.Domain.Services
Imports MVC.EntityFramework.Repository
Imports TestCrud.MVC.Models

Namespace Controllers
    <Authorize>
    Public Class ClientController
        Inherits Controller

        Private ReadOnly _connectionString = ConfigurationManager.ConnectionStrings("ConexaoDB").ConnectionString

        Private ReadOnly _clientRepository As IClientRepository = New ClientRepository(_connectionString)
        Private ReadOnly _clientService As IClientService = New ClientService(_clientRepository)

        ' GET: Client
        Function Index() As ActionResult
            Dim client = _clientService.GetAllClient()
            Return View(client)
        End Function

        ' GET: Client/Details/5
        <CustomAuthorizeAttribute(Roles:="Admin,Alfredo")>
        Function Details(ByVal id As Integer) As ActionResult

            Dim client = _clientService.GetClientById(id)
            If client IsNot Nothing Then
                Return View(client)
            End If
            Return RedirectToAction("Index")
        End Function

        ' GET: Client/Create
        <CustomAuthorizeAttribute(Roles:="Admin,Alfredo")>
        Function Create() As ActionResult
            Try
                Return View()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' POST: Client/Create
        <HttpPost()>
        Function Create(client As Client) As ActionResult
            Try
                If ModelState.IsValid Then
                    'Add new client to the list

                    Dim clientExist = _clientService.GetAllClient().Any(Function(c) c.Name = client.Name)

                    If clientExist Then
                        ViewData("ErrorMessage") = "Já existe um cliente com o mesmo nome."
                    Else
                        'Message when the client was sucessfully created
                        _clientService.CreateClient(client)
                        TempData("SuccessMessage") = "Registado com sucesso"
                        ModelState.Clear()
                    End If
                End If
                Return View()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' GET: Client/Edit/5
        <CustomAuthorizeAttribute(Roles:="Admin,Alfredo")>
        Function Edit(ByVal id As Integer) As ActionResult
            Try
                '
                Dim client = _clientService.GetClientById(id)
                If client Is Nothing Then
                    Return HttpNotFound()
                End If
                Return View(client)
                Return RedirectToAction("Index")
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' POST: Client/Edit/5
        <HttpPost()>
        Function Edit(newClient As Client) As ActionResult
            Try
                If ModelState.IsValid Then

                    Dim clientExist = _clientService.GetAllClient().Any(Function(c) c.Name = newClient.Name)

                    If clientExist Then
                        ViewData("ErrorMessage") = "Já existe um cliente com o mesmo nome."
                    Else
                        'Message when the client was sucessfully created
                        _clientService.UpdateClient(newClient)
                        TempData("SuccessMessage") = "Dados Actualizado com sucesso!"
                        ModelState.Clear()
                        Return RedirectToAction("Index")
                    End If

                End If
                Return View("Edit", newClient)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' GET: Client/Delete/5
        <CustomAuthorizeAttribute(Roles:="Admin,Alfredo")>
        Function Delete(ByVal id As Integer) As ActionResult
            Try
                Dim client = _clientService.GetClientById(id)
                If client IsNot Nothing Then
                    Return View(client)
                End If
                Return RedirectToAction("Index")
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' POST: Client/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        Function ConfirmDelete(ByVal id As Integer) As ActionResult
            Try
                _clientService.DeleteClient(id)
                TempData("SuccessMessage") = "Cliente eliminado com sucesso!"
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace