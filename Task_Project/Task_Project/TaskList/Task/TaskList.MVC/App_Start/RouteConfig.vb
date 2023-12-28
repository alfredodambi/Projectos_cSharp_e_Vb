Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}
        )


        routes.MapRoute(
            name:="TaskList",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Task", .action = "Index"}
        )

        routes.MapRoute(
          name:="CreateTask",
          url:="Task/create",
          defaults:=New With {.controller = "Task", .action = "Create"}
      )

        routes.MapRoute(
            name:="TaskDetails",
            url:="Task/{id}",
            defaults:=New With {.controler = "Task", .action = "Details"}
        )

        routes.MapRoute(
            name:="EditTask",
            url:="Task/Edit/{id}",
            defaults:=New With {.controller = "Task", .action = "Edit"}
        )

        routes.MapRoute(
            name:="DeleteTask",
            url:="Task/Delete/{id}",
            defaults:=New With {.controller = "Task", .action = "Delete"}
        )
    End Sub
End Module