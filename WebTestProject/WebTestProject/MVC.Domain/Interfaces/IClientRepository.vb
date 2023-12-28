Imports MVC.Domain.Models

Namespace Interfaces
    Public Interface IClientRepository
        Inherits IRepository(Of Client)

        Function GetName(name As String) As IEnumerable(Of Client)
        Function GetEmail(email As String) As IEnumerable(Of Client)
        Function GetAddress(address As String) As IEnumerable(Of Client)
    End Interface
End Namespace