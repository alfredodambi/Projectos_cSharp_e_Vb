Imports MVC.Domain.Interfaces
Imports MVC.Domain.Models

Namespace Services
    Public Class UserService
        Implements IUserService

        Private ReadOnly _userRepository As IUserRepository

        Public Sub New(userRepository As IUserRepository)
            _userRepository = userRepository
        End Sub

        Private Function Login(user As Users) As Boolean Implements IUserService.Login
            Return _userRepository.Login(user)
        End Function

        Private Sub Signup(user As Users) Implements IUserService.Signup
            If user IsNot Nothing Then
                _userRepository.Create(user)
            End If
        End Sub

        Public Function GetAllUsers() As IEnumerable(Of Users) Implements IUserService.GetAllUsers
            Return _userRepository.GetAll()
        End Function
    End Class
End Namespace