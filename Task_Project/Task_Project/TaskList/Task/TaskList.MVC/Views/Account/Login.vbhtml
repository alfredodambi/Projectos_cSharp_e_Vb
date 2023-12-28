@ModelType TaskList.Domain.Models.Users
@Code
    ViewData("Title") = "Login"
    Dim successMessage As String = TempData("SuccessMessage")
End Code

<div class="container">
    <div class="row justify-content-center">
        <div class="col-md-6">
            <br />
            <h2>Fazer Login</h2>

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

                  @<div Class="form-group">
                        <div Class="col-md-offset-2 col-md-10">
                            <input type = "submit" value="Fazer o login" Class="btn btn-info btn-sm" />
                            <a Class="btn btn-info btn-sm" href="@Url.Content("/Account/SignUp")">Criar Conta</a>
                        </div>
                    </div>
            End Using
        </div>
    </div>
</div>

    @If Not String.IsNullOrEmpty(successMessage) Then
        @<div Class="alert alert-success">
            @successMessage
        </div>
    End If


@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
