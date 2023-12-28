@ModelType MVC.Domain.Models.Client
@Code
    ViewData("Title") = "Details"
End Code

<div>
    <h4>Ver Dados do Cliente</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Phone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Phone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Address)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Address)
        </dd>

    </dl>
</div>
<p>
    
    <a class="btn btn-info btn-sm" href="@Url.Action("Edit", "Client", New With {.id = Model.Id})">Editar Cliente</a>
    <a class="btn btn-info btn-sm" href="@Url.Content("/Client/Index")">Ver a lista de Cliente</a>
</p>
