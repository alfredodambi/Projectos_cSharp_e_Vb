<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My Task List ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
        <div class="container">
            <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Toggle navigation" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
                <ul class="navbar-nav flex-grow-1">
                    @If User.Identity.IsAuthenticated Then
                        @<li>@Html.ActionLink("Pagina Inicial", "Index", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                        @<li>@Html.ActionLink("Tarefas", "Index", "Task", New With {.area = ""}, New With {.class = "nav-link"})</li>

                        @<ul Class="navbar-nav ml-auto">
                            <li Class="nav-item">@Html.ActionLink("Sair", "Logout", "Account", New With {.area = ""}, New With {.class = "nav-link"})</li>
                            <li Class="nav-item navbar-brand">@User.Identity.Name</li>
                        </ul>
                    Else
                        @<li>@Html.ActionLink("Login", "Login", "Accounts", New With {.area = ""}, New With {.class = "navbar-brand"})</li>
                    End If

                </ul>
            </div>
        </div>
    </nav>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My Task List ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
