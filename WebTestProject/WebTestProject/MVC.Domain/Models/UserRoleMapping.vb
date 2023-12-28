Imports System.ComponentModel.DataAnnotations.Schema

Namespace Models
    Public Class UserRoleMapping
        Public Property Id As Integer
        Public Property UserId As Integer
        Public Property RoleId As Integer

        <ForeignKey("UserID")>
        Public Property User As Users

        <ForeignKey("RoleID")>
        Public Property Role As RoleMaster
    End Class
End Namespace