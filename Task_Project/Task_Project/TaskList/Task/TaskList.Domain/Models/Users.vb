Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Users

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Property Id As Integer

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <Required(ErrorMessage:="O nome o usuário é obrigatório")>
        Public Property UserName As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <Required(ErrorMessage:="A senha do Usuário é obrigatório")>
        Public Property UserPassword As String
    End Class
End Namespace