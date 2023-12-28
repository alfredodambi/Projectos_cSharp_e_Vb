Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Models
    Public Class Purchase
        Public Property Id As Integer

        <Required(ErrorMessage:="A data da compra é obrigatória")>
        Public Property PurchaseDate As DateTime

        Public Property ClientId As Integer
        Public Property ProductId As Integer

        <ForeignKey("ClientId")>
        Public Property Client As Client

        <ForeignKey("ProductId")>
        Public Property Product As Product

        <Required(ErrorMessage:="A quantidade é obrigatória")>
        Public Property Quantity As Integer

        <Required(ErrorMessage:="O valor total é obrigatório")>
        Public Property TotalAmount As Decimal
    End Class
End Namespace