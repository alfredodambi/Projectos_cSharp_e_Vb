Imports MVC.Domain.Models

Namespace Interfaces
    Public Interface IUserRepository
        Inherits IRepository(Of Users)

        Function Login(user As Users) As Boolean

    End Interface
End Namespace