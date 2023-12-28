Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        'Rota padrão do ASP.NET MVC
        'routes.MapRoute(
        '    name:="Default",
        '    url:="{controller}/{action}/{id}",
        '    defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}
        ')

        'Defining personalized roots
        routes.MapRoute(
            name:="ProductList",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Product", .action = "Index", .id = UrlParameter.Optional}
        )

        routes.MapRoute(
            name:="CreateProduct",
            url:="Product/create",
            defaults:=New With {.controller = "Product", .action = "Create"}
        )

        routes.MapRoute(
            name:="ProductDetails",
            url:="Product/{id}",
            defaults:=New With {.controler = "Product", .action = "Details"}
        )

        routes.MapRoute(
            name:="EditProduct",
            url:="Product/Edit/{id}",
            defaults:=New With {.controller = "Product", .action = "Edit"}
        )

        routes.MapRoute(
            name:="DelteProduct",
            url:="Product/Delete/{id}",
            defaults:=New With {.controller = "Product", .action = "Delete"}
        )


    End Sub
End Module