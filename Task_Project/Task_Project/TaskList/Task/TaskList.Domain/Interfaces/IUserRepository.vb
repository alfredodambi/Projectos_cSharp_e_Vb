Imports TaskList.Domain.Models

Namespace Interfaces
    Public Interface IUserRepository
        Inherits IRepository(Of Users)

        ''' <summary>
        ''' Used to autenticate an user
        ''' </summary>
        ''' <param name="user"></param>
        ''' <returns></returns>
        Function Login(user As Users) As Boolean

    End Interface
End Namespace