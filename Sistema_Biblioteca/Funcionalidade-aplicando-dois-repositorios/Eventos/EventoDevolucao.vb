Imports BibliotecaConsole_Fase4.Modelos

Namespace Eventos
    Public Class EventoDevolucao
        Inherits EventArgs

        Public Property Transacao As Transacao

        Public Sub New(transacao As Transacao)
            Me.Transacao = transacao
        End Sub
    End Class
End Namespace
