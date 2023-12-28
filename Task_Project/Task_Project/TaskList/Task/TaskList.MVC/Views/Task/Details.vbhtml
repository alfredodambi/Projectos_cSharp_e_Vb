@ModelType TaskList.Domain.Models.Tasks
@Code
    ViewData("Title") = "Details"
End Code

@Html.Partial("PartialViews/TaskDetails", Model)
