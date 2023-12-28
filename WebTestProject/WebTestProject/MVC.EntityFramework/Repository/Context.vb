Imports System.Data.Entity
Imports MVC.Domain.Models

Namespace Repository
    Public Class Context
        Inherits DbContext

        Public Property Products As DbSet(Of Product)
        Public Property Users As DbSet(Of Users)
        Public Property RoleMasters As DbSet(Of RoleMaster)
        Public Property UserRolesMappings As DbSet(Of UserRoleMapping)
        Public Property Clients As DbSet(Of Client)
        Public Property Purchases As DbSet(Of Purchase)
        Public Sub New(nameOrConnectionString As String)
            MyBase.New(nameOrConnectionString)
        End Sub

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            MyBase.OnModelCreating(modelBuilder)

            modelBuilder.Entity(Of Client)() _
                .ToTable("Client") _
                .HasKey(Function(c) c.Id)

            modelBuilder.Entity(Of Product)() _
                .ToTable("Product") _
                .HasKey(Function(e) e.Id)

            modelBuilder.Entity(Of Users)() _
               .ToTable("Users") _
               .HasKey(Function(e) e.Id)

            modelBuilder.Entity(Of RoleMaster)() _
               .ToTable("RoleMaster") _
               .HasKey(Function(e) e.Id)

            modelBuilder.Entity(Of UserRoleMapping)() _
               .ToTable("UserRolesMapping") _
               .HasKey(Function(e) e.Id)

            modelBuilder.Entity(Of Purchase)() _
                .ToTable("Purchases") _
                .HasKey(Function(e) e.Id)


            modelBuilder.Entity(Of UserRoleMapping).HasRequired(Function(t) t.User).WithMany().HasForeignKey(Function(t) t.UserId)
            modelBuilder.Entity(Of UserRoleMapping).HasRequired(Function(t) t.Role).WithMany().HasForeignKey(Function(t) t.RoleId)

            modelBuilder.Entity(Of Purchase).HasRequired(Function(p) p.Product).WithMany().HasForeignKey(Function(p) p.ProductId)
            modelBuilder.Entity(Of Purchase).HasRequired(Function(p) p.Client).WithMany().HasForeignKey(Function(p) p.ClientId)

        End Sub

    End Class
End Namespace