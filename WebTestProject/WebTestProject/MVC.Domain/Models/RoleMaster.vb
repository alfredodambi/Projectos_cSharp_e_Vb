Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class RoleMaster

        Public Property Id As Integer

        <Required(ErrorMessage:="O campo RollName é obrigatório")>
        Public Property RollName As String
    End Class
End Namespace