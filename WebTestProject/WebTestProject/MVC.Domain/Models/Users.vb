Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Users
        Public Property Id As Integer

        <Required(ErrorMessage:="O nome do usuário é obrigatório")>
        Public Property UserName As String

        <Required(ErrorMessage:="A senha do usuário é obrigatório")>
        Public Property UserPassword As String
    End Class
End Namespace