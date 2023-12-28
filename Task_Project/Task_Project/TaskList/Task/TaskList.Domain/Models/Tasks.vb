Imports System.ComponentModel.DataAnnotations
Imports System.Runtime.CompilerServices

Namespace Models
    Public Class Tasks

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Property Id As Integer

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <Required(ErrorMessage:="O nome da tarefa é obrigatório")>
        Public Property Name As String
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <Required(ErrorMessage:="O estado da tarefa é obrigatório")>
        Public Property State As String

    End Class
End Namespace