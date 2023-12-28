Imports MVC.Domain.Interfaces
Imports MVC.Domain.Models

Namespace Services
    Public Class ClientService
        Implements IClientService

        Private ReadOnly _clientRepository As IClientRepository

        Public Sub New(clientRepository As IClientRepository)
            _clientRepository = clientRepository
        End Sub
        Public Sub CreateClient(client As Client) Implements IClientService.CreateClient
            If client IsNot Nothing Then
                _clientRepository.Create(client)
            End If
        End Sub

        Public Sub UpdateClient(client As Client) Implements IClientService.UpdateClient
            If client IsNot Nothing Then
                _clientRepository.Update(client)
            End If
        End Sub

        Public Sub DeleteClient(id As Integer) Implements IClientService.DeleteClient
            If id <> 0 Then
                _clientRepository.Delete(id)
            End If
        End Sub

        Public Function GetAllClient() As IEnumerable(Of Client) Implements IClientService.GetAllClient
            Return _clientRepository.GetAll()
        End Function

        Public Function GetClientById(id As Integer) As Client Implements IClientService.GetClientById
            Return _clientRepository.GetById(id)
        End Function

        Public Function GetClientByName(name As String) As IEnumerable(Of Client) Implements IClientService.GetClientByName
            Return _clientRepository.GetName(name)
        End Function

        Public Function GetClientByEmail(email As String) As IEnumerable(Of Client) Implements IClientService.GetClientByEmail
            Return _clientRepository.GetEmail(email)
        End Function

        Public Function GetClientByAddress(address As String) As IEnumerable(Of Client) Implements IClientService.GetClientByAddress
            Return _clientRepository.GetAddress(address)
        End Function
    End Class
End Namespace