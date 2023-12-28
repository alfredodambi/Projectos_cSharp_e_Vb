@ModelType MVC.Domain.Models.Product
@Code
    ViewData("Title") = "Ver Detalhes"
End Code

<h2>@ViewData("Title")</h2>
@Html.Partial("PartialViews/ProductDetail", Model)

<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
