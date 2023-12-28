@ModelType MVC.Domain.Models.Users

@Code
    ViewData("Title") = "Login"
    Dim successMessage As String = TempData("SuccessMessage")
End Code

<div class="container">
    <div class="row justify-content-center">
        <div class="col-md-6">
            <br />
            <h2>@ViewData("Title")</h2>

            @Using (Html.BeginForm())
                @Html.AntiForgeryToken()
                @<div class="form-group">
                    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                    @Html.HiddenFor(Function(model) model.Id)
                    <label for="UserName" class="font-weight-bold" style="font-size: 18px;">Nome de Usuário</label>
                    @Html.TextBoxFor(Function(model) model.UserName, New With {.class = "form-control", .style = "border: 1px solid #ccc; padding: 5px;"})
                    @Html.ValidationMessageFor(Function(model) model.UserName, "", New With {.class = "text-danger"})
                </div>

                @<div class="form-group">
                    <label for="UserPassword" class="font-weight-bold" style="font-size: 18px;">Senha</label>
                    @Html.TextBoxFor(Function(model) model.UserPassword, New With {.class = "form-control", .style = "border: 1px solid #ccc; padding: 5px;"})
                    @Html.ValidationMessageFor(Function(model) model.UserPassword, "", New With {.class = "text-danger"})
                </div>

                @<button type="submit" class="btn btn-primary" style="margin-top: 10px;">Fazer Login</button>
                @Html.ActionLink("Criar Conta", "Signup", "", New With {.class = "btn btn-primary", .style = "margin-top: 0; color: white; text-decoration: underline;"})

            End Using
        </div>
    </div>
</div>

@If Not String.IsNullOrEmpty(successMessage) Then
    @<div Class="alert alert-success">
        @successMessage
    </div>
End If