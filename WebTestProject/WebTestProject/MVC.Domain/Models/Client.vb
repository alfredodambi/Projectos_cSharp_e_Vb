Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Client
        Public Property Id As Integer

        <Required(ErrorMessage:="O nome é um campo obrigatório")>
        Public Property Name As String


        <Required(ErrorMessage:="O email é um campo obrigatório")>
        <EmailAddress(ErrorMessage:="O Endereço de e-mail digitado está incorrecto")>
        Public Property Email As String

        <Required(ErrorMessage:="O telefone é um campo obrigatório")>
        <RegularExpression("^\d+$", ErrorMessage:="Apenas números são permitidos")>
        Public Property Phone As Integer

        <Required(ErrorMessage:="O Endereço é um campo obrigatório")>
        Public Property Address As String
    End Class
End Namespace