@ModelType MVC.Domain.Models.Purchase
@Code
    ViewData("Title") = "Delete"
End Code


<div>
    <h4>Eliminar uma Compra</h4>
    <hr />

    <h3>Desejas eliminar a compra abaixo?</h3>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.PurchaseDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PurchaseDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ClientId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ClientId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ProductId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ProductId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Quantity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Quantity)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TotalAmount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TotalAmount)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Apagar" class="btn btn-info btn-sm" /> |
            <a class="btn btn-info btn-sm" href="@Url.Content("/Purchase/Index")">Ver a lista de Compras</a>
        </div>
    End Using
</div>
