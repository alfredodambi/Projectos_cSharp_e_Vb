Imports BibliotecaConsole_Fase4.Modelos

Namespace Eventos
    Public Class EventoEmprestador
        Inherits EventArgs

        Public Property Emprestador As Emprestador

        Public Sub New(emprestador As Emprestador)
            Me.Emprestador = emprestador
        End Sub
    End Class
End Namespace
