Imports MVC.Domain.Interfaces
Imports MVC.Domain.Models
Imports MVC.Domain.Services
Imports MVC.EntityFramework.Repository


Namespace Controllers


    Public Class AccountsController
        Inherits Controller

        ' GET: Accounts
        Public connectionString As String = ConfigurationManager.ConnectionStrings("ConexaoDb").ConnectionString

        Private ReadOnly _userRepository As IUserRepository = New UserRepository(connectionString)
        Private ReadOnly _userService As IUserService = New UserService(_userRepository)

        ' GET: Accounts
        Public Function Login() As ActionResult
            Try
                Return View()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function Signup() As ActionResult
            Return View()
        End Function

        Public Function Logout() As ActionResult
            FormsAuthentication.SignOut()
            Return RedirectToAction("Login")
        End Function

        <HttpPost>
        Public Function Login(user As Users) As ActionResult
            If Not String.IsNullOrEmpty(user.UserName) AndAlso Not String.IsNullOrEmpty(user.UserPassword) Then
                Dim IsValidUser As Boolean = _userService.Login(user)
                If IsValidUser Then
                    FormsAuthentication.SetAuthCookie(user.UserName, False)
                    TempData("SuccessMessage") = "Login feito com sucesso"
                    ModelState.Clear()
                    Return RedirectToAction("Index", "Product")
                End If
            End If
            ModelState.AddModelError("", "Usuário não encontrado")
            Return View()
        End Function

        <HttpPost>
        Public Function Signup(user As Users) As ActionResult
            If ModelState.IsValid Then
                _userService.Signup(user)

                Dim productExist = _userService.GetAllUsers().Any(Function(p) p.UserName = user.UserName)

                If productExist Then
                    ViewData("ErrorMessage") = "Já existe um usuario com o mesmo nome."
                Else
                    TempData("SuccessMessage") = "Cadastro bem-sucedido. Você pode fazer login agora."
                    Return RedirectToAction("Login")
                End If
            End If
            Return View()
        End Function
    End Class
End Namespace