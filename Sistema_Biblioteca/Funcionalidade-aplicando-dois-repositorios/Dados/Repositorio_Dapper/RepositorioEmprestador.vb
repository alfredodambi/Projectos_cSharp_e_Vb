Imports BibliotecaConsole_Fase4.Modelos
Imports Dapper
Imports System.Data.SqlClient
Imports System.Configuration
Imports BibliotecaConsole_Fase4.Repositorios

Namespace Dados.Repositorio_Dapper
    Public Class RepositorioEmprestador
        Implements IRepositorioEmprestador

        Private ReadOnly _stringDeConexao As String
        ''' <summary>
        ''' Construtor que inicializa a string de conexao
        ''' </summary>
        ''' <param name="stringDeConexao"></param>
        Public Sub New(stringDeConexao As String)
            _stringDeConexao = stringDeConexao
        End Sub


        ''' <summary>
        ''' Metodo que permite adicionar um novo emprestador a lista de emprestadores do repositorio
        ''' </summary>
        ''' <param name="emprestador">parametro que recebe o id e adiciona na lista emprestadores </param>
        Public Sub Criar(emprestador As Emprestador) Implements IRepositorio(Of Emprestador).Criar
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "INSERT INTO Emprestadores (Nome) VALUES (@Nome)"
                conexao.Execute(comandoSql, New With {emprestador.Nome})
            End Using


        End Sub
        ''' <summary>
        ''' Metodo que permite atualizar as informações de um emprestador existente no repositório
        ''' </summary>
        ''' <param name="emprestador"></param>
        Public Sub Actualizar(emprestador As Emprestador) Implements IRepositorio(Of Emprestador).Actualizar
            Dim comandoSql = "UPDATE Emprestadores SET Nome = @Nome WHERE Id = @Id"
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim linhaDeActualizacao As Integer = conexao.Execute(comandoSql, New With {emprestador.Id})
            End Using
        End Sub
        ''' <summary>
        ''' Metodo que permite remover um emprestador específico do repositório.
        ''' </summary>
        ''' <param name="emprestador"></param>
        Public Sub Remover(emprestador As Emprestador) Implements IRepositorio(Of Emprestador).Remover
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "DELETE FROM Emprestadores WHERE Id = @Id"
                conexao.Execute(comandoSql, New With {emprestador.Id})
            End Using
        End Sub

        Public Function BuscaPorNome(nome As String) As Emprestador Implements IRepositorioEmprestador.BuscaPorNome
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "SELECT * FROM Emprestadores WHERE Nome = @nome"
                Dim resultado = conexao.QueryFirstOrDefault(Of Emprestador)(comandoSql, New With {.Nome = nome})
                Return resultado
            End Using
        End Function

        ''' <summary>
        ''' Funcao que  permite obter um emprestador específico com base em seu id a partir do repositório
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Function BuscarPorId(id As Integer) As Emprestador Implements IRepositorio(Of Emprestador).BuscarPorId
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "SELECT * FROM Emprestadores WHERE Id = @id"
                Return conexao.QueryFirstOrDefault(Of Emprestador)(comandoSql, New With {Key .id = id})
            End Using
        End Function


        ''' <summary>
        ''' permite obter todos os emprestadores do repositório como uma lista de objetos Emprestador
        ''' </summary>
        ''' <returns></returns>
        Public Function BuscarTodos() As IEnumerable(Of Emprestador) Implements IRepositorio(Of Emprestador).BuscarTodos
            Dim resultado As List(Of Emprestador)
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "SELECT * FROM Emprestadores"
                resultado = conexao.Query(Of Emprestador)(comandoSql)
            End Using
            Return resultado
        End Function
    End Class
End Namespace