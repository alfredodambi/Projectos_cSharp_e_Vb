<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Product Manager System</title>
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
                        @<li class="navbar-brand">Hello - @User.Identity.Name</li>
                        @<li>@Html.ActionLink("Logout", "Logout", "Accounts", New With {.area = ""}, New With {.class = "navbar-brand"})</li>
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
            <p>&copy; @DateTime.Now.Year - My Product Manager System</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
