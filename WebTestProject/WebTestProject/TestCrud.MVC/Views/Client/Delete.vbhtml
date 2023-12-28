@ModelType MVC.Domain.Models.Client
@Code
    ViewData("Title") = "Delete"
End Code

<div>
    <h4>Eliminar um cliente</h4>
    <hr />

    <h3>Desejas eliminar o cliente abaixo?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Apagar" class="btn btn-info btn-sm" /> |
            <a class="btn btn-info btn-sm" href="@Url.Content("/Client/Index")">Ver a lista de Cliente</a>
        </div>
    End Using
</div>
