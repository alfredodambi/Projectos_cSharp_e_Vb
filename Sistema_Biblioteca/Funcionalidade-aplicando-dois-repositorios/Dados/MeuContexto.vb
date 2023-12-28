Imports System.Data.Entity
Imports BibliotecaConsole_Fase4.Modelos

Namespace Dados
    Public Class MeuContexto
        Inherits DbContext

        Public Property Livros As DbSet(Of Livro)
        Public Property Emprestadores As DbSet(Of Emprestador)
        Public Property Transacoes As DbSet(Of Transacao)

        Public Sub New(nameOrConnectionString As String)
            MyBase.New(nameOrConnectionString)
        End Sub


        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            MyBase.OnModelCreating(modelBuilder)
            modelBuilder.Entity(Of Livro)() _
            .ToTable("Livros")

            modelBuilder.Entity(Of Emprestador)() _
            .ToTable("Emprestadores")

            modelBuilder.Entity(Of Transacao)() _
            .ToTable("Transacoes")

            modelBuilder.Entity(Of Transacao).HasRequired(Function(t) t.Emprestador).WithMany().HasForeignKey(Function(t) t.Id_Emprestador)

            modelBuilder.Entity(Of Transacao).HasRequired(Function(t) t.Livro).WithMany().HasForeignKey(Function(t) t.Id_Livro)

        End Sub

    End Class
End Namespace