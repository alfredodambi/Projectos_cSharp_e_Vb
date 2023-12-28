@ModelType TaskList.Domain.Models.Tasks
@Code
    ViewData("Title") = If(Model.Id = 0, "Adicionar Tarefa", "Editar Tarefa")
    Dim successMessage As String = TempData("SuccessMessage")
    Dim errorMessage As String = ViewData("ErrorMessage")
End Code

<h4>@ViewData("Title")</h4>


@Html.Partial("PartialViews/TaskForm", Model)

@If Not String.IsNullOrEmpty(successMessage) Then
    @<div Class="alert alert-success">
        @successMessage
    </div>End If

@If Not String.IsNullOrEmpty(errorMessage) Then
    @<div class="alert alert-danger">
        @errorMessage
    </div>End If

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
