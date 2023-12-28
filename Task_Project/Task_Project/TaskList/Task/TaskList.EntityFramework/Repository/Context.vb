Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports TaskList.Domain.Models

Namespace Repository
    Public Class Context
        Inherits DbContext

        Public Property Taskes As DbSet(Of Tasks)
        Public Property Userss As DbSet(Of Users)
        Public Property RoleMasters As DbSet(Of RoleMaster)
        Public Property UserRolesMappings As DbSet(Of UserRolesMapping)
        Public Sub New(nameOrConnectionString As String)
            MyBase.New(nameOrConnectionString)
        End Sub

        Protected Overrides Sub OnModelCreating(modelbuilder As DbModelBuilder)
            MyBase.OnModelCreating(modelbuilder)

            modelbuilder.Entity(Of Tasks)() _
                .ToTable("Task") _
                .HasKey(Function(t) t.Id)

            modelbuilder.Entity(Of Users)() _
                .ToTable("Users") _
                .HasKey(Function(u) u.Id)

            modelbuilder.Entity(Of RoleMaster)() _
                .ToTable("RoleMaster") _
                .HasKey(Function(r) r.Id)

            modelbuilder.Entity(Of UserRolesMapping)() _
                .ToTable("UserRolesMapping") _
                .HasKey(Function(m) m.Id)

            modelbuilder.Entity(Of UserRolesMapping).HasRequired(Function(t) t.User).WithMany().HasForeignKey(Function(t) t.UserId)
            modelbuilder.Entity(Of UserRolesMapping).HasRequired(Function(t) t.Role).WithMany().HasForeignKey(Function(t) t.RoleId)

        End Sub
    End Class
End Namespace