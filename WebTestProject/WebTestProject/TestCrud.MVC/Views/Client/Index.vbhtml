@ModelType IEnumerable(Of MVC.Domain.Models.Client)
@Code
    ViewData("Title") = "Index"
    Dim successMessage As String = TempData("SuccessMessage")
    Dim errorMessage As String = ViewData("ErrorMessage")
End Code

<h2>Lista de Clientes</h2>

<table class="table table-bordered">
    <tr>
        <th scope="col">Nome</th>
        <th scope="col">Email</th>
        <th scope="col">Telefone</th>
        <th scope="col">Endereço</th>
        <th scope="col">Opções</th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Name)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Email)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Phone)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Address)
            </td>
            <td>
                <a class="btn btn-success btn-sm" href="@Url.Action("Edit", "Client", New With {.id = item.Id})">Editar</a>
                <a class="btn btn-info btn-sm" href="@Url.Action("Details", "Client", New With {.id = item.Id})">Ver detalhes</a>
                <a class="btn btn-warning btn-sm" href="@Url.Action("Delete", "Client", New With {.id = item.Id})">Eliminar</a>
            </td>
        </tr>
    Next

</table>


<a Class="btn btn-info btn-sm" href="@Url.Content("/Product/Index")">Voltar para a lista de Produto</a>
<a Class="btn btn-info btn-sm" href="@Url.Content("~/Client/Create")">Adicionar Cliente</a>

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