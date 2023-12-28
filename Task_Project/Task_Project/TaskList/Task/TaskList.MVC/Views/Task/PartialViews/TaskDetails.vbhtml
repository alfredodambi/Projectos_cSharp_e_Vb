@ModelType TaskList.Domain.Models.Tasks

<div>
    <h4>Ver Dados da Tarefa</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.State)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.State)
        </dd>

    </dl>
</div>
<p>
    <a class="btn btn-info btn-sm" href="@Url.Action("Edit", "task", New With {.id = Model.Id})">Editar Tarefa</a>
    <a class="btn btn-info btn-sm" href="@Url.Content("/Task/Index")">Ver a lista de Tarefas</a>
</p>