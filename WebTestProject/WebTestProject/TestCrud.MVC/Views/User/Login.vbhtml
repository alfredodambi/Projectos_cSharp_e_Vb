@ModelType TestCrud.MVC.Models.Users
@Code
    ViewData("Title") = "Login"
End Code

<h2>@ViewData("Title")</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    @<div class="form-group">
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.Id)
        @Html.LabelFor(Function(model) model.UserName, New With {.style = "font-weight: bold; font-size: 18px;"})
        @Html.TextBoxFor(Function(model) model.UserName, New With {.class = "form-control", .style = "border: 1px solid #ccc; padding: 5px;"})
        @Html.ValidationMessageFor(Function(model) model.UserName, "", New With {.class = "text-danger"})
    </div>

    @<div class="form-group">
        @Html.LabelFor(Function(model) model.Passwords, New With {.style = "font-weight: bold; font-size: 18px;"})
        @Html.TextBoxFor(Function(model) model.Passwords, New With {.class = "form-control", .style = "border: 1px solid #ccc; padding: 5px;"})
        @Html.ValidationMessageFor(Function(model) model.Passwords, "", New With {.class = "text-danger"})
    </div>

    @<button type="submit" class="btn btn-primary" style="margin-top: 10px;">Fazer Login</button>
End Using

<div>
    @Html.ActionLink("Criar Conta", "Create")
</div>

<div>
    @Html.ActionLink("Voltar a pagina de usuarios", "Index")
</div>

