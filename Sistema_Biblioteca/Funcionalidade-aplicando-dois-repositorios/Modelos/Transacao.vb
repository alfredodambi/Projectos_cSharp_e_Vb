Namespace Modelos
    Public Class Transacao

        ''' <summary>
        ''' Propriedade do campo livro que é do tipo livro(classe)
        ''' </summary>
        ''' <returns>retorna livros</returns>
        Public Property Livro As Livro

        ''' <summary>
        ''' Propriedade do campo emprestador que é do tipo emprestador(classe)
        ''' </summary>
        ''' <returns>retorna emprestadores</returns>
        Public Property Emprestador As Emprestador

        ''' <summary>
        ''' Propriedade do campo Data De Devoloção do tipo Date
        ''' </summary>
        ''' <returns>Retorna um valor do tipo date</returns>
        Public Property DataDevolucao As Date

        ''' <summary>
        ''' Propriedade do campo Data devolvida do tipo date
        ''' </summary>
        ''' <returns>Retorna um valor do tipo data</returns>
        Public Property DataDevolvida As Nullable(Of Date)

        ''' <summary>
        ''' Propiedade do campo Valor da Multa do tipo decimal
        ''' </summary>
        ''' <returns>Retorna um valor decimal (moeda)</returns>
        Public Property ValorMulta As Nullable(Of Decimal)

        Public Property Id As Integer

        Public Sub New(livro As Livro, emprestador As Emprestador, dataDevolucao As Date)
            Me.Livro = livro
            Me.Emprestador = emprestador
            Me.DataDevolucao = dataDevolucao
        End Sub

        ''' <summary>
        ''' Construtor usado pelo dapper
        ''' </summary>
        Public Sub New()
        End Sub


    End Class

    Partial Public Class Transacao
        '<ForeignKey("Id_Emprestador")>
        Public Property Id_Emprestador As Integer
        '<ForeignKey("Id_Livro")>
        Public Property Id_Livro As Integer
    End Class
End Namespace