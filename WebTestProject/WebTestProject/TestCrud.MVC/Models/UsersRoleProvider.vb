Imports System.Web.Security
Imports MVC.Domain.Models
Imports MVC.EntityFramework.Repository

Namespace Models
    Public Class UsersRoleProvider
        Inherits RoleProvider

        Public connectionString As String = ConfigurationManager.ConnectionStrings("ConexaoDb").ConnectionString
        Private _applicationName As String = ""

        Public Overrides Property ApplicationName As String
            Get
                Return _applicationName
            End Get
            Set(value As String)
                _applicationName = value
            End Set
        End Property

        ''' <summary>
        ''' Add users to specify functions
        ''' </summary>
        ''' <param name="usernames"></param>
        ''' <param name="roleNames"></param>
        Public Overrides Sub AddUsersToRoles(usernames As String(), roleNames As String())
            Using context As New Context(connectionString)
                For Each username In usernames
                    Dim user = context.Users.FirstOrDefault(Function(u) u.UserName = username)
                    If user IsNot Nothing Then
                        For Each roleName In roleNames
                            Dim role = context.RoleMasters.FirstOrDefault(Function(r) r.RollName = roleName)
                            If role IsNot Nothing Then
                                Dim roleMapping As New UserRoleMapping()
                                roleMapping.UserId = user.Id
                                roleMapping.RoleId = role.Id
                                context.UserRolesMappings.Add(roleMapping)
                            End If
                        Next
                    End If
                Next
                context.SaveChanges()
            End Using
        End Sub


        ''' <summary>
        ''' Create a new User Function
        ''' </summary>
        ''' <param name="roleName"></param>
        Public Overrides Sub CreateRole(roleName As String)
            Using context As New Context(connectionString)
                Dim role As New RoleMaster()
                role.RollName = roleName
                context.RoleMasters.Add(role)
                context.SaveChanges()
            End Using
        End Sub

        ''' <summary>
        ''' Use to Delete a user function
        ''' </summary>
        ''' <param name="roleName"></param>
        ''' <param name="throwOnPopulatedRole"></param>
        ''' <returns></returns>
        Public Overrides Function DeleteRole(roleName As String, throwOnPopulatedRole As Boolean) As Boolean
            Using context As New Context(connectionString)
                Dim role = context.RoleMasters.FirstOrDefault(Function(r) r.RollName = roleName)
                If role IsNot Nothing Then
                    'If Not throwOnPopulatedRole OrElse Not role.UserRolesMappings.Any() Then
                    context.RoleMasters.Remove(role)
                    context.SaveChanges()
                    Return True
                    'End If
                End If
                Return False
            End Using
        End Function

        ''' <summary>
        ''' Use to find users that belongs to a specify function
        ''' </summary>
        ''' <param name="roleName"></param>
        ''' <param name="usernameToMatch"></param>
        ''' <returns>Return a matriz of userNames</returns>
        Public Overrides Function FindUsersInRole(roleName As String, usernameToMatch As String) As String()
            Using context As New Context(connectionString)
                Dim usersInRole = (From user In context.Users
                                   Join roleMapping In context.UserRolesMappings
                                   On user.Id Equals roleMapping.UserId
                                   Join role In context.RoleMasters
                                   On roleMapping.RoleId Equals role.Id
                                   Where role.RollName = roleName AndAlso user.UserName.Contains(usernameToMatch)
                                   Select user.UserName).ToArray()
                Return usersInRole
            End Using
        End Function

        ''' <summary>
        ''' Get all the user Functions
        ''' </summary>
        ''' <returns>Return all the user Functions</returns>
        Public Overrides Function GetAllRoles() As String()
            Using context As New Context(connectionString)
                Dim allRoles = (From role In context.RoleMasters
                                Select role.RollName).ToArray()
                Return allRoles
            End Using
        End Function

        ''' <summary>
        ''' Get all User Function by username
        ''' </summary>
        ''' <param name="username"></param>
        ''' <returns>Return User Functions(Roles) a user belongs to</returns>
        Public Overrides Function GetRolesForUser(username As String) As String()
            Using context As New Context(connectionString)
                Dim userRoles = (From user In context.Users
                                 Join roleMapping In context.UserRolesMappings
                                 On user.Id Equals roleMapping.UserId
                                 Join role In context.RoleMasters
                                 On roleMapping.RoleId Equals role.Id
                                 Where user.UserName = username
                                 Select role.RollName).ToArray()
                Return userRoles
            End Using
        End Function

        ''' <summary>
        ''' Get the users that belongs to a hole(function)
        ''' </summary>
        ''' <param name="roleName"></param>
        ''' <returns>Return a matriz with user that belongs to a specify function</returns>
        Public Overrides Function GetUsersInRole(roleName As String) As String()
            Using context As New Context(connectionString)
                Dim usersInRole = (From user In context.Users
                                   Join roleMapping In context.UserRolesMappings
                                   On user.Id Equals roleMapping.UserId
                                   Join role In context.RoleMasters
                                   On roleMapping.RoleId Equals role.Id
                                   Where role.RollName = roleName
                                   Select user.UserName).ToArray()
                Return usersInRole
            End Using
        End Function

        ''' <summary>
        ''' Verify if a user belongs or is memberof a Role(User Functions)
        ''' </summary>
        ''' <param name="username"></param>
        ''' <param name="roleName"></param>
        ''' <returns></returns>
        Public Overrides Function IsUserInRole(username As String, roleName As String) As Boolean
            Using context As New Context(connectionString)
                Dim userInRole = (From user In context.Users
                                  Join roleMapping In context.UserRolesMappings
                                  On user.Id Equals roleMapping.UserId
                                  Join role In context.RoleMasters
                                  On roleMapping.RoleId Equals role.Id
                                  Where user.UserName = username AndAlso role.RollName = roleName
                                  Select user).Any()
                Return userInRole
            End Using
        End Function

        ''' <summary>
        ''' Remove a user to a role(user function)
        ''' </summary>
        ''' <param name="usernames"></param>
        ''' <param name="roleNames"></param>
        Public Overrides Sub RemoveUsersFromRoles(usernames As String(), roleNames As String())
            Using context As New Context(connectionString)
                For Each username In usernames
                    Dim user = context.Users.FirstOrDefault(Function(u) u.UserName = username)
                    If user IsNot Nothing Then
                        For Each roleName In roleNames
                            Dim role = context.RoleMasters.FirstOrDefault(Function(r) r.RollName = roleName)
                            If role IsNot Nothing Then
                                Dim roleMapping = context.UserRolesMappings.FirstOrDefault(
                                    Function(mapping) mapping.UserId = user.Id AndAlso mapping.RoleId = role.Id)

                                If roleMapping IsNot Nothing Then
                                    context.UserRolesMappings.Remove(roleMapping)
                                End If
                            End If
                        Next
                    End If
                Next
                context.SaveChanges()
            End Using
        End Sub

        ''' <summary>
        ''' Verify if a Role Exists
        ''' </summary>
        ''' <param name="roleName"></param>
        ''' <returns></returns>
        Public Overrides Function RoleExists(roleName As String) As Boolean
            Using context As New Context(connectionString)
                Return context.RoleMasters.Any(Function(r) r.RollName = roleName)
            End Using
        End Function
    End Class
End Namespace

