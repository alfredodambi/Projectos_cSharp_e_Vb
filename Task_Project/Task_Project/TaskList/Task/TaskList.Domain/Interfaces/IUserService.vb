Imports TaskList.Domain.Models

Namespace Interfaces
    Public Interface IUserService

        ''' <summary>
        ''' Use for autenticate a user
        ''' </summary>
        ''' <param name="user"></param>
        ''' <returns></returns>
        Function Login(user As Users) As Boolean

        ''' <summary>
        ''' Use to create a user account
        ''' </summary>
        ''' <param name="user"></param>
        Sub SingUp(user As Users)

        ''' <summary>
        ''' Get a list of Users
        ''' </summary>
        ''' <returns>Returns a list of users</returns>
        Function GetAllUsers() As IEnumerable(Of Users)
    End Interface
End Namespace