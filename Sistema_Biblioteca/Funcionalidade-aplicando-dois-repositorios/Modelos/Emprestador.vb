Namespace Modelos
    Public Class Emprestador
        ''' <summary>
        ''' Propriedade do campo id do emprestador do tipo inteiro
        ''' </summary>
        ''' <returns>Retorna um valor do tipo inteiro</returns>
        Public Property Id As Integer

        ''' <summary>
        ''' Propriedade do campo Nome do Emprestador do tipo string
        ''' </summary>
        ''' <returns>Retorna um valor do tipo string</returns>
        Public Property Nome As String


        Public Sub New(nome As String)
            Me.Nome = nome
        End Sub

        ''' <summary>
        ''' Constructor criado para ser usado pelo repositorio emprestador(dapper)
        ''' </summary>
        Public Sub New()
        End Sub
    End Class
End Namespace