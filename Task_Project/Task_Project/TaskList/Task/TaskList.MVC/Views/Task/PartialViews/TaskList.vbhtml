@ModelType IEnumerable(Of TaskList.Domain.Models.Tasks)

<h2>Lista de Tarefa</h2>


<hr />

@Html.Partial("PartialViews/TaskSearch", Model)

<hr />

<table class="table table-bordered">
    <tr>

        <th scope="col">Nome</th>
        <th scope="col">Estado</th>
        <th scope="col">Opções</th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Name)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.State)
            </td>
            <td>
                @If User.IsInRole("Admin") OrElse User.IsInRole("User") Then
                    @<a Class="btn btn-success btn-sm" href="@Url.Action("Edit", "Task", New With {.id = item.Id})">Editar</a>
                End If

                @If User.IsInRole("Admin") OrElse User.IsInRole("User") OrElse User.IsInRole("Other") Then
                    @<a Class="btn btn-info btn-sm" href="@Url.Action("Details", "Task", New With {.id = item.Id})">Ver detalhes</a>
                End If

                @If User.IsInRole("Admin") Then
                    @<a Class="btn btn-warning btn-sm" href="@Url.Action("Delete", "Task", New With {.id = item.Id})">Eliminar</a>
                End If

            </td>
        </tr>
    Next

</table>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section