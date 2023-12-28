@ModelType TaskList.Domain.Models.Users
@Code
    ViewData("Title") = "SignUp"
End Code

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Criar Conta</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
     <div class="form-group">
         <label for="UserName" class="font-weight-bold" style="font-size: 18px;">Nome de Usuário</label>
         <div class="col-md-10">
             @Html.EditorFor(Function(model) model.UserName, New With {.htmlAttributes = New With {.class = "form-control"}})
             @Html.ValidationMessageFor(Function(model) model.UserName, "", New With {.class = "text-danger"})
         </div>
     </div>

     <div class="form-group">
         <label for="UserName" class="font-weight-bold" style="font-size: 18px;">Senha do Usuário</label>
         <div class="col-md-10">
             @Html.EditorFor(Function(model) model.UserPassword, New With {.htmlAttributes = New With {.class = "form-control"}})
             @Html.ValidationMessageFor(Function(model) model.UserPassword, "", New With {.class = "text-danger"})
         </div>
     </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Criar Conta" class="btn btn-info btn-sm" />
                <a class="btn btn-info btn-sm" href="@Url.Content("/Account/Login")">Voltar para fazer Login</a>
            </div>
        </div>
    </div>
End Using

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
