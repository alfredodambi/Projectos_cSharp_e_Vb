Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class RoleMaster

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Property Id As Integer

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <Required(ErrorMessage:="A função do usuário é obrigatória")>
        Public Property RollName As String

    End Class
End Namespace