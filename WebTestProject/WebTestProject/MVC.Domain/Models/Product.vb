Imports System.ComponentModel.DataAnnotations

Namespace Models
Public Class Product


    Public Property Id As Integer

    <Required(ErrorMessage:="O nome do producto é obrigatório")>
    Public Property Name As String

    <RegularExpression("^(\d+|\d+\.\d+)$", ErrorMessage:="Insira um preço válido.")>
    Public Property Price As Decimal
End Class
End Namespace