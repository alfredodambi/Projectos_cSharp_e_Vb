@ModelType MVC.Domain.Models.Purchase
@Code
    ViewData("Title") = "Details"
End Code

<div>
    <h4>Ver detalhes da Compra</h4>
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
</div>
<p>
    <a class="btn btn-info btn-sm" href="@Url.Action("Edit", "Purchase", New With {.id = Model.Id})">Editar Compra</a>
    <a class="btn btn-info btn-sm" href="@Url.Content("/Purchase/Index")">Ver a lista de Compras</a>
</p>
