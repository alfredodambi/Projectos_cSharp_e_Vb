@ModelType MVC.Domain.Models.Product
@Code
    ViewData("Title") = "Apagar Um Producto"
End Code

<h3>Tens Certeza que queres eliminar este producto?</h3>

    <dl class="dl-horizontal">
        <dt>ID:</dt>
        <dd>@Model.ID</dd>
        <dt>Nome:</dt>
        <dd>@Model.Name</dd>
        <dt>Preço:</dt>
        <dd>@Model.Price</dd>
   </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-primary" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using


