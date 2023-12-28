@ModelType MVC.Domain.Models.Product
@Code
    ViewData("Title") = "Apagar Um Producto"
    Dim successMessage As String = TempData("SuccessMessage")
    Dim errorMessage As String = ViewData("ErrorMessage")
End Code

<h2>@ViewData("Title")</h2>

@Html.Partial("PartialViews/ProductDelete", Model)
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
