Namespace Modelos
    Public Class Email

        Public Property Origem As String
        'Public Property Destinatario As String
        Public Property Destinatario As IEnumerable(Of String)

        Public Property Assunto As String
        Public Property Conteudo As String

        Public Property Anexo As IEnumerable(Of Anexo)

    End Class
End Namespace