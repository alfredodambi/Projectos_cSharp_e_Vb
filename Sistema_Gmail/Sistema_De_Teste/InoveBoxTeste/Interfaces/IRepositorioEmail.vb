Imports Google.Apis.Gmail.v1.Data
Imports InoveBoxTeste.Modelos

Namespace Interfaces
    Public Interface IRepositorioEmail

        Function MostrarListaDeEmails() As Task
        Function EnviarEmail(ByVal emailOrigem As String, ByVal destinatarios As IEnumerable(Of String), ByVal assunto As String, ByVal corpo As String, ByVal anexos As IEnumerable(Of Anexo)) As Task
    End Interface
End Namespace