Namespace Models
    Public Class CustomAuthorizeAttribute
        Inherits AuthorizeAttribute

        Protected Overrides Sub HandleUnauthorizedRequest(filterContext As AuthorizationContext)
            'Veriry if a user is authenticated
            If Not filterContext.HttpContext.User.Identity.IsAuthenticated Then
                'User not authenticated, return (Unauthorized) 
                filterContext.Result = New HttpStatusCodeResult(System.Net.HttpStatusCode.Unauthorized)
            Else
                'User Authenticated, but not authotized (Forbidden)
                Dim result = New ViewResult()
                result.ViewName = "/Views/Accounts/Unauthorized.vbhtml"
                result.ViewBag.ErrorMessage = "Você não tem permissão para acessar esta página."
                filterContext.Result = result
            End If
        End Sub
    End Class
End Namespace