Imports System.Data.SqlClient
Imports BibliotecaConsole_Fase4.Modelos
Imports BibliotecaConsole_Fase4.Repositorios
Imports Dapper


Namespace Dados.Repositorio_Dapper
    Public Class RepositorioEmprestimo
        Implements IRepositorio(Of Transacao)
        'Declarando a string de conexão
        Private ReadOnly _stringDeConexao As String

        ''' <summary>
        ''' Contructor que inicializa a string de conexão
        ''' </summary>
        ''' <param name="stringDeConexao"></param>
        Public Sub New(stringDeConexao As String)
            _stringDeConexao = stringDeConexao
        End Sub

        ''' <summary>
        ''' Metodo para criar um emprestimo
        ''' </summary>
        ''' <param name="transacao">parametro do tipo transacao</param>
        Public Sub Criar(transacao As Transacao) Implements IRepositorio(Of Transacao).Criar
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "INSERT INTO Transacoes (Id_Livro, Id_Emprestador, DataDevolucao) VALUES (@Id_Livro, @Id_Emprestador, @DataDevolucao)"
                Dim parametros As New With {
                    .Id_Livro = transacao.Livro.Id,
                    .Id_Emprestador = transacao.Emprestador.Id,
                    .DataDevolucao = transacao.DataDevolucao
                }
                conexao.Execute(comandoSql, parametros)
            End Using
        End Sub

        ''' <summary>
        ''' Metodo que permite actualizar dados de um emprestimo, usado especificamente para o registo de devolução de um livro
        ''' </summary>
        ''' <param name="transacao">parametro do tipo transacao</param>
        Public Sub Actualizar(transacao As Transacao) Implements IRepositorio(Of Transacao).Actualizar
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "UPDATE Transacoes SET DataDevolvida = @DataDevolvida, ValorMulta = @ValorMulta WHERE Id = @Id"
                Dim parametros As New With {
                    .DataDevolvida = transacao.DataDevolvida,
                    .ValorMulta = transacao.ValorMulta,
                    .Id = transacao.Id
                }
                conexao.Execute(comandoSql, parametros)
            End Using
        End Sub

        ''' <summary>
        ''' Metodo para apagar uma transacao
        ''' </summary>
        ''' <param name="transacao"></param>
        Public Sub Remover(transacao As Transacao) Implements IRepositorio(Of Transacao).Remover
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "DELETE FROM Transacoes WHERE Id = @Id"
                Dim parametros As New With {
                    .Id = transacao.Id
                }
                conexao.Execute(comandoSql, parametros)
            End Using
        End Sub

        ''' <summary>
        ''' Funcao para procurar um livro por id
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns>Retornar um livro especifico</returns>
        Private Function BuscarPorId(id As Integer) As Transacao Implements IRepositorio(Of Transacao).BuscarPorId
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "SELECT * FROM Transacoes WHERE Id = @Id"
                Return conexao.QueryFirstOrDefault(Of Transacao)(comandoSql, New With {.Id = id})
            End Using
        End Function

        ''' <summary>
        ''' Funcao usada para  obter a lista de todos os emprestimos 
        ''' </summary>
        ''' <returns>Todos os emprestimos</returns>
        Private Function BuscarTodos() As IEnumerable(Of Transacao) Implements IRepositorio(Of Transacao).BuscarTodos
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "SELECT transacoes.Id, transacoes.DataDevolucao, transacoes.DataDevolvida, transacoes.ValorMulta, livros.*, emprestadores.*
                    From Transacoes
                    INNER JOIN Livros ON transacoes.Id_Livro = livros.Id 
                    INNER JOIN Emprestadores ON transacoes.Id_Emprestador = emprestadores.Id"

                Return conexao.Query(comandoSql, Function(transacao As Transacao, livro As Livro, emprestador As Emprestador)
                                                     If Not IsNothing(livro) And Not IsNothing(emprestador) Then
                                                         transacao.Livro = livro
                                                         transacao.Emprestador = emprestador
                                                     End If
                                                     Return transacao
                                                 End Function, splitOn:="Id, Id, Id")
            End Using
        End Function


    End Class
End Namespace
