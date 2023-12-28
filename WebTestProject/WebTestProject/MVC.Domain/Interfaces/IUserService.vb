Imports MVC.Domain.Models

Namespace Interfaces
    Public Interface IUserService

        Function Login(user As Users) As Boolean
        Sub Signup(user As Users)

        Function GetAllUsers() As IEnumerable(Of Users)
    End Interface
End Namespace