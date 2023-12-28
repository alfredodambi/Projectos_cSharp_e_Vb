@ModelType IEnumerable(Of MVC.Domain.Models.Purchase)
@Code
    ViewData("Title") = "Index"
    Dim successMessage As String = TempData("SuccessMessage")
    Dim errorMessage As String = ViewData("ErrorMessage")
End Code

<h2>Lista de Compras</h2>

<table class="table table-bordered">
    <tr>
        <th scope="col">Data da Compra</th>
        <th scope="col">Cliente</th>
        <th scope="col">Producto</th>
        <th scope="col">Quantidade</th>
        <th scope="col">Valor Total</th>
        <th scope="col">Opções</th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @item.PurchaseDate.ToString("dd/MM/yyyy")
            </td>
            <td>
                @item.ClientId
            </td>
            <td>
                @item.ProductId
            </td>
            <td>
                @item.Quantity
            </td>
            <td>
                @item.TotalAmount.ToString("C")
            </td>
            <td>
                <a class="btn btn-success btn-sm" href="@Url.Action("Edit", "Purchase", New With {.id = item.Id})">Editar</a>
                <a class="btn btn-info btn-sm" href="@Url.Action("Details", "Purchase", New With {.id = item.Id})">Ver detalhes</a>
                <a class="btn btn-warning btn-sm" href="@Url.Action("Delete", "Purchase", New With {.id = item.Id})">Eliminar</a>
            </td>
        </tr>
    Next

</table>

<a Class="btn btn-info btn-sm" href="@Url.Content("/Product/Index")">Voltar para a lista de Produto</a>
<a Class="btn btn-info btn-sm" href="@Url.Content("~/Client/Create")">Adicionar Cliente</a>
<a Class="btn btn-info btn-sm" href="@Url.Content("~/Purchase/Create")">Registar Compra</a>


@If Not String.IsNullOrEmpty(successMessage) Then
    @<div Class="alert alert-success">
        @successMessage
    </div>
End If

@If Not String.IsNullOrEmpty(errorMessage) Then
    @<div class="alert alert-danger">
        @errorMessage
    </div>
End If