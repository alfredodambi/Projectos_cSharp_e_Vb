Imports System.Web.Mvc
Imports TaskList.Domain.Interfaces
Imports TaskList.Domain.Models
Imports TaskList.Domain.Services
Imports TaskList.EntityFramework.Repository

Namespace Controllers
    Public Class AccountController
        Inherits Controller

        Private ReadOnly _connectionString = ConfigurationManager.ConnectionStrings("ConnectionDb").ConnectionString

        Private ReadOnly _userRepository As IUserRepository = New UserRepository(_connectionString)
        Private ReadOnly _userService As IUserService = New UserService(_userRepository)

        ' GET: Account
        Function Login() As ActionResult
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
            TempData("SuccessMessage") = "Saiste da tua conta"
            Return RedirectToAction("Login")
        End Function

        'Post Login
        <HttpPost>
        Public Function Login(user As Users) As ActionResult
            'Check if user property are empty
            If Not String.IsNullOrEmpty(user.UserName) AndAlso Not String.IsNullOrEmpty(user.UserPassword) Then
                Dim IsValidUser As Boolean = _userService.Login(user)
                'Check if the user that is used on login is valid
                If IsValidUser Then
                    FormsAuthentication.SetAuthCookie(user.UserName, False)
                    TempData("SuccessMessage") = "Login feito com sucesso"
                    'Clear the Form
                    ModelState.Clear()
                    Return RedirectToAction("Index", "Home")
                End If
            End If
            ModelState.AddModelError("", "Usuário não encontrado")
            Return View()
        End Function

        'Post SignUp
        <HttpPost>
        Public Function Signup(user As Users) As ActionResult
            'Check if the data passed Are valid
            If ModelState.IsValid Then
                'Check if the user already existe
                Dim userExists = _userService.GetAllUsers().Any(Function(u) u.UserName = user.UserName)

                If userExists Then
                    ViewData("ErrorMessage") = "Já existe um usuario com o mesmo nome."
                Else
                    'If the user doesn´t exist the account is created
                    _userService.SingUp(user)
                    TempData("SuccessMessage") = "Cadastro bem-sucedido. Você pode fazer login agora."
                    Return RedirectToAction("Login")
                End If

            End If
            Return View()
        End Function

    End Class
End Namespace