@ModelType IEnumerable(Of TaskList.Domain.Models.Tasks)
@Code
    ViewData("Title") = "Index"
    Dim successMessage As String = TempData("SuccessMessage")
    Dim errorMessage As String = ViewData("ErrorMessage")
End Code

@Html.Partial("PartialViews/TaskList", Model)

@If User.IsInRole("Admin") OrElse User.IsInRole("User") OrElse User.IsInRole("Other") Then
    @<a Class="btn btn-info btn-sm" href="@Url.Content("/Task/Create")">Adicionar Tarefa</a>
End If

@If Not String.IsNullOrEmpty(successMessage) Then
    @<div Class="alert alert-success">
        @successMessage
    </div>  End If

@If Not String.IsNullOrEmpty(errorMessage) Then
    @<div class="alert alert-danger">
        @errorMessage
    </div>  End If
