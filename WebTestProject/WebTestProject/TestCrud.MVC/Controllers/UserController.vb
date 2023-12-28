Imports System.Web.Mvc
Imports Microsoft.VisualBasic.ApplicationServices
'Imports TestCrud.MVC.Dapper
Imports TestCrud.MVC.EntityFramework
Imports TestCrud.MVC.Interfaces
Imports TestCrud.MVC.Models
Imports TestCrud.MVC.Services

Namespace Controllers
    Public Class UserController
        Inherits Controller

        Public connectionString As String = ConfigurationManager.ConnectionStrings("ConexaoDb").ConnectionString

        Private ReadOnly _userRepository As IUserRepository = New UserRepository(connectionString)
        Private ReadOnly _userService As UserService = New UserService(_userRepository)

        ' GET: User
        Function Index() As ActionResult
            Return View()
        End Function

        'Get: /User/Login
        Public Function Login() As ActionResult
            Return View()
        End Function

        ' Get: Create User
        Function Create() As ActionResult
            Return View()
        End Function

        'Post: Create User
        <HttpPost()>
        Function Create(user As Users) As ActionResult
            If ModelState.IsValid Then

                _userService.RegisterUser(user)
                Return RedirectToAction("Login")
            End If

            Return View(user)
        End Function

        'POST
        <HttpPost()>
        Public Function Login(userName As String, password As String)
            Dim user As Users = _userService.Login(userName, password)
            If user IsNot Nothing Then
                FormsAuthentication.SetAuthCookie(userName, False)
                Session("UserName") = userName
                Return RedirectToAction("Index")
            Else
                ModelState.AddModelError("", "Nome do Usuario ou senha Invalido")
                Return View()
            End If
        End Function
    End Class
End Namespace