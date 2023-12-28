@ModelType MVC.Domain.Models.Product
@Code
    ViewData("Title") = If(Model.Id = 0, "Adicionar Produto", "Editar Producto")
    Dim successMessage As String = TempData("SuccessMessage")
    Dim errorMessage As String = ViewData("ErrorMessage")
End Code

<h2>@ViewData("Title")</h2>

@Html.Partial("PartialViews/ProductForm", Model)

<div>
    @Html.ActionLink("Voltar a pagina inicial", "Index")
</div>
@If Not String.IsNullOrEmpty(successMessage) Then
    @<div Class="alert alert-success">
        @successMessage
    </div>
End If

@If Not String.IsNullOrEmpty(errorMessage) Then
@<div class="alert alert-danger">
@errorMessage
    </div>
End If