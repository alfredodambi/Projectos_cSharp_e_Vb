Imports MVC.Domain.Models

Namespace Interfaces
    Public Interface IClientService

        Function GetAllClient() As IEnumerable(Of Client)
        Function GetClientById(id As Integer) As Client
        Sub CreateClient(client As Client)
        Sub UpdateClient(client As Client)
        Sub DeleteClient(id As Integer)
        Function GetClientByName(name As String) As IEnumerable(Of Client)
        Function GetClientByEmail(email As String) As IEnumerable(Of Client)
        Function GetClientByAddress(address As String) As IEnumerable(Of Client)

    End Interface
End Namespace