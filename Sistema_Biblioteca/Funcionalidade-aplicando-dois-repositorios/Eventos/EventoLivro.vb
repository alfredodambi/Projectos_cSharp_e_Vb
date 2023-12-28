Imports BibliotecaConsole_Fase4.Modelos

Namespace Eventos
    Public Class EventoLivro
        Inherits EventArgs

        Public Property Livro As Livro

        Public Sub New(livro As Livro)
            Me.Livro = livro
        End Sub

    End Class
End Namespace
