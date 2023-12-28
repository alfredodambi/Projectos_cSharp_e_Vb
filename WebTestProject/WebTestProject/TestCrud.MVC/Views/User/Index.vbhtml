@ModelType TestCrud.MVC.Models.Users
@Code
    ViewData("Title") = "Usuarios"
End Code


@If Session("UserName") IsNot Nothing Then
    @<p>Usuário Logado: @Session("UserName").ToString()</p>
End If
<hr />
<h2>@ViewData("Title")</h2>

<div>
    @Html.ActionLink("Criar Conta", "Create")
</div>

<div>
    @Html.ActionLink("Fazer Login", "Login")
</div>

