@ModelType TaskList.Domain.Models.Tasks

<div>
    <h4>Eliminar uma Tarefa</h4>
    <hr />

    <h3>Desejas eliminar a tarefa abaixo?</h3>
    <hr />
    <dl class="dl-horizontal">
        <dt>ID</dt>
        <dd>@Model.ID</dd>
        <dt>Nome</dt>
        <dd>@Model.Name</dd>
        <dt>Estado</dt>
        <dd>@Model.State</dd>
    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Eliminar" class="btn btn-info btn-sm" /> |
            <a class="btn btn-info btn-sm" href="@Url.Content("/Task/Index")">Ver a lista de Tarefas</a>
        </div>
    End Using
</div>
