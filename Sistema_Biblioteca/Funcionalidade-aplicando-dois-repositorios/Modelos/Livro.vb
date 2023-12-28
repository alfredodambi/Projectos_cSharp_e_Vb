Namespace Modelos
    Public Class Livro
        ''' <summary>
        ''' Propriedade do campo id do livro do tipo inteiro
        ''' </summary>
        ''' <returns>Retorna um valor inteiro</returns>
        Public Property Id As Integer
        ''' <summary>
        ''' Propriedade do campo Titulo do tipo string
        ''' </summary>
        ''' <returns>Retorna uma string</returns>
        Public Property Titulo As String
        ''' <summary>
        ''' Propriedade do campo Autores do livros do tipo string
        ''' </summary>
        ''' <returns>Retorna uma string</returns>
        Public Property Autores As String
        ''' <summary>
        ''' Propriedade do campo Disponibilidade do livro do tipo bolean
        ''' </summary>
        ''' <returns>Retorna um valor boleano</returns>
        Public Property Disponivel As Boolean


        Public Sub New(tituloDoLivro As String, autoresDoLivro As String, disponivel As Boolean)
            Me.Titulo = tituloDoLivro
            Me.Autores = autoresDoLivro
            Me.Disponivel = disponivel
        End Sub

        ''' <summary>
        ''' Construtor usado pelo dapper no repositorio livro
        ''' </summary>
        Private Sub New()
        End Sub
    End Class
End Namespace