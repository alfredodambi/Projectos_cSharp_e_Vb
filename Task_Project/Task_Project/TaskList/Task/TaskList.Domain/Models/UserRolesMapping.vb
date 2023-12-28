Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Models
    Public Class UserRolesMapping

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Property Id As Integer

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <Required(ErrorMessage:="O código do usuário é obrigatório")>
        Public Property UserId As Integer

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <Required(ErrorMessage:="O código da função do usuário é obrigatório")>
        Public Property RoleId As Integer

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <ForeignKey("UserID")>
        Public Property User As Users

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <ForeignKey("RoleID")>
        Public Property Role As RoleMaster
    End Class
End Namespace