@ModelType IEnumerable(Of MVC.Domain.Models.Client)

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
                @If User.IsInRole("Admin") OrElse User.IsInRole("Alfredo") Then
                    @<a Class="btn btn-success btn-sm" href="@Url.Action("Edit", "Client", New With {.id = item.Id})">Editar</a>
                    @<a Class="btn btn-info btn-sm" href="@Url.Action("Details", "Client", New With {.id = item.Id})">Ver detalhes</a>
                    @<a Class="btn btn-warning btn-sm" href="@Url.Action("Delete", "Client", New With {.id = item.Id})">Eliminar</a>
                End If
            </td>
        </tr>
    Next

</table>
