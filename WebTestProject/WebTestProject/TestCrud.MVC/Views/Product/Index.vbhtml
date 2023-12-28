@ModelType IEnumerable(Of MVC.Domain.Models.Product)
@Code
    ViewData("Title") = "Lista de Productos"
    Dim successMessage As String = TempData("SuccessMessage")
    Dim errorMessage As String = ViewData("ErrorMessage")
End Code



<div Class="container">
    <div Class="row justify-content-center">
        <div Class="col-md-9">
            <h2>@ViewData("Title")</h2>
            <hr />

            @Html.Partial("PartialViews/ProductSearch", Model)

            <hr />

            @Html.Partial("PartialViews/ProductList", Model)

            @If User.IsInRole("Admin") OrElse User.IsInRole("Alfredo") Then
                @<a Class="btn btn-info btn-sm" href="@Url.Content("/Product/Create")">Adicionar Produto</a>
            End If
            <a class="btn btn-info btn-sm" href="@Url.Content("~/Client/Create")">Adicionar Cliente</a>
            <a class="btn btn-info btn-sm" href="@Url.Content("~/Purchase/Create")">Registar Compra</a>

        </div>
    </div>
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