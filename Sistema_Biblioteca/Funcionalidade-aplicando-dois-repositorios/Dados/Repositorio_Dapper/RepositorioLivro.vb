Imports BibliotecaConsole_Fase4.Modelos
Imports Dapper
Imports System.Data.SqlClient
Imports System.Configuration
Imports BibliotecaConsole_Fase4
Imports BibliotecaConsole_Fase4.Repositorios

Namespace Dados.Repositorio_Dapper
    Public Class RepositorioLivro
        Implements IRepositorioLivro

        Private _stringDeConexao As String
        ''' <summary>
        ''' Construtor que inicializa uma lista de livro vazia
        ''' </summary>
        Public Sub New(stringDeConexao As String)
            _stringDeConexao = stringDeConexao
        End Sub

        ''' <summary>
        ''' Metodo para adicionar um id numa lista de livros no repositorio
        ''' </summary>
        ''' <param name="livro"></param>
        Public Sub Criar(livro As Livro) Implements IRepositorio(Of Livro).Criar
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "INSERT INTO Livros (Titulo, Autores, Disponivel) VALUES (@Titulo, @Autores, @Disponivel)"
                conexao.Execute(comandoSql, New With {livro.Titulo, livro.Autores, livro.Disponivel})
            End Using
        End Sub

        ''' <summary>
        ''' Metodo para actualizar os dados de um livro
        ''' </summary>
        ''' <param name="livro"></param>
        Public Sub Actualizar(livro As Livro) Implements IRepositorio(Of Livro).Actualizar
            Dim livroNoBancoDeDados = BuscarPorId(livro.Id)
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql = "UPDATE Livros SET Titulo = @Titulo, Autores = @Autores, Disponivel = @Disponivel WHERE Id = @Id"
                Dim linhaDeActualizacao As Integer = conexao.Execute(comandoSql, New With {livro.Id})
            End Using
        End Sub

        ''' <summary>
        ''' Metodo para remover um livro do repositorio
        ''' </summary>
        ''' <param name="livro"></param>
        Public Sub Remover(livro As Livro) Implements IRepositorio(Of Livro).Remover
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "DELETE FROM Livros WHERE Id = @Id"
                Dim linhaRemovida = conexao.Execute(comandoSql, New With {livro.Id})
            End Using
        End Sub



        Public Sub ActualizarDisponibilidade(livro As Livro, Disponibilidade As Boolean) Implements IRepositorioLivro.ActualizarDisponibilidade
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "UPDATE Livros SET Disponivel = @disponivel WHERE Id = @id"
                'Dim parametros As New With {
                '    .disponivel = Disponibilidade,
                '    .id = livro.Id
                '}
                conexao.Execute(comandoSql, livro)
            End Using
        End Sub

        ''' <summary>
        ''' permite obter um livro específico com base em seu ID a partir do repositório.
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns>retorna o id de um livro</returns>
        Public Function BuscarPorId(id As Integer) As Livro Implements IRepositorio(Of Livro).BuscarPorId
            Dim resultado As Livro
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "SELECT * FROM Livros WHERE Id = @Id"
                resultado = conexao.QueryFirstOrDefault(Of Livro)(comandoSql, New With {Key .Id = id})
            End Using
            Return resultado
        End Function


        ''' <summary>
        '''  Metdo que permite obter todos os livros do repositório
        ''' </summary>
        ''' <returns>retorna uma lista de livros</returns>
        Public Function BuscarTodos() As IEnumerable(Of Livro) Implements IRepositorio(Of Livro).BuscarTodos
            Dim resultado As List(Of Livro)
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "SELECT * FROM Livros"
                resultado = conexao.Query(Of Livro)(comandoSql).ToList()
            End Using
            Return resultado
        End Function

        Public Function BuscaPorTitulo(titulo As String) As Livro Implements IRepositorioLivro.BuscaPorTitulo
            Using conexao As New SqlConnection(_stringDeConexao)
                Dim comandoSql As String = "SELECT * FROM Livros WHERE Titulo = @titulo"
                Dim resultado = conexao.QueryFirstOrDefault(Of Livro)(comandoSql, New With {.Titulo = titulo})
                Return resultado
            End Using
        End Function


    End Class
End Namespace