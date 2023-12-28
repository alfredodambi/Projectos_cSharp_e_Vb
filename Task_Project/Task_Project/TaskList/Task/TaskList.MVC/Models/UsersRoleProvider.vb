Imports TaskList.Domain.Models
Imports TaskList.EntityFramework.Repository

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

        Public Overrides Sub CreateRole(roleName As String)
            Using context As New Context(connectionString)
                Dim role As New RoleMaster()
                role.RollName = roleName
                context.RoleMasters.Add(role)
                context.SaveChanges()
            End Using
        End Sub

        Public Overrides Sub AddUsersToRoles(usernames() As String, roleNames() As String)
            Throw New NotImplementedException()
        End Sub

        Public Overrides Sub RemoveUsersFromRoles(usernames() As String, roleNames() As String)
            Throw New NotImplementedException()
        End Sub

        Public Overrides Function IsUserInRole(username As String, roleName As String) As Boolean
            Using context As New Context(connectionString)
                Dim userInRole = (From user In context.Userss
                                  Join roleMapping In context.UserRolesMappings
                                  On user.Id Equals roleMapping.UserId
                                  Join role In context.RoleMasters
                                  On roleMapping.RoleId Equals role.Id
                                  Where user.UserName = username AndAlso role.RollName = roleName
                                  Select user).Any()
                Return userInRole
            End Using
        End Function

        Public Overrides Function GetRolesForUser(username As String) As String()
            Using context As New Context(connectionString)
                Dim userRoles = (From user In context.Userss
                                 Join roleMapping In context.UserRolesMappings
                                 On user.Id Equals roleMapping.UserId
                                 Join role In context.RoleMasters
                                 On roleMapping.RoleId Equals role.Id
                                 Where user.UserName = username
                                 Select role.RollName).ToArray()
                Return userRoles
            End Using
        End Function

        Public Overrides Function DeleteRole(roleName As String, throwOnPopulatedRole As Boolean) As Boolean
            Using context As New Context(connectionString)
                Dim role = context.RoleMasters.FirstOrDefault(Function(r) r.RollName = roleName)
                If role IsNot Nothing Then
                    If Not throwOnPopulatedRole Then
                        context.RoleMasters.Remove(role)
                        context.SaveChanges()
                        Return True
                    End If
                End If
                    Return False
            End Using
        End Function

        Public Overrides Function RoleExists(roleName As String) As Boolean
            Using context As New Context(connectionString)
                Return context.RoleMasters.Any(Function(r) r.RollName = roleName)
            End Using
        End Function

        Public Overrides Function GetUsersInRole(roleName As String) As String()
            Using context As New Context(connectionString)
                Dim usersInRole = (From user In context.Userss
                                   Join roleMapping In context.UserRolesMappings
                                   On user.Id Equals roleMapping.UserId
                                   Join role In context.RoleMasters
                                   On roleMapping.RoleId Equals role.Id
                                   Where role.RollName = roleName
                                   Select user.UserName).ToArray()
                Return usersInRole
            End Using
        End Function

        Public Overrides Function GetAllRoles() As String()
            Using context As New Context(connectionString)
                Dim allRoles = (From role In context.RoleMasters
                                Select role.RollName).ToArray()
                Return allRoles
            End Using
        End Function

        Public Overrides Function FindUsersInRole(roleName As String, usernameToMatch As String) As String()
            Using context As New Context(connectionString)
                Dim usersInRole = (From user In context.Userss
                                   Join roleMapping In context.UserRolesMappings
                                   On user.Id Equals roleMapping.UserId
                                   Join role In context.RoleMasters
                                   On roleMapping.RoleId Equals role.Id
                                   Where role.RollName = roleName AndAlso user.UserName.Contains(usernameToMatch)
                                   Select user.UserName).ToArray()
                Return usersInRole
            End Using
        End Function
    End Class
End Namespace