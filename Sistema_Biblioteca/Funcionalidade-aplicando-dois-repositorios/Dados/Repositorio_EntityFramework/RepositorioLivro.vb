Imports BibliotecaConsole_Fase4.Modelos
Imports BibliotecaConsole_Fase4.Repositorios
Imports System.Data.Entity

Namespace Dados.Repositorio_EntityFramework
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
            Using contexto = New MeuContexto(_stringDeConexao)
                contexto.Livros.Add(livro)
                contexto.SaveChanges()
            End Using
        End Sub

        ''' <summary>
        ''' Metodo para actualizar os dados de um livro
        ''' </summary>
        ''' <param name="livro"></param>
        Public Sub Actualizar(livro As Livro) Implements IRepositorio(Of Livro).Actualizar
            Using contexto = New MeuContexto(_stringDeConexao)
                contexto.Entry(livro).State = EntityState.Modified
                contexto.SaveChanges()
            End Using
        End Sub

        ''' <summary>
        ''' Metodo para remover um livro do repositorio
        ''' </summary>
        ''' <param name="livro"></param>
        Public Sub Remover(livro As Livro) Implements IRepositorio(Of Livro).Remover
            Using contexto = New MeuContexto(_stringDeConexao)
                contexto.Livros.Remove(livro)
                contexto.SaveChanges()
            End Using
        End Sub



        Public Sub ActualizarDisponibilidade(livro As Livro, Disponibilidade As Boolean) Implements IRepositorioLivro.ActualizarDisponibilidade
            Using contexto = New MeuContexto(_stringDeConexao)
                contexto.Entry(livro).State = EntityState.Modified
                contexto.SaveChanges()
            End Using
        End Sub

        ''' <summary>
        ''' permite obter um livro específico com base em seu ID a partir do repositório.
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns>retorna o id de um livro</returns>
        Public Function BuscarPorId(id As Integer) As Livro Implements IRepositorio(Of Livro).BuscarPorId
            Using contexto = New MeuContexto(_stringDeConexao)
                Dim resultado = contexto.Livros.Find(id)
                Return resultado
            End Using
        End Function


        ''' <summary>
        '''  Metdo que permite obter todos os livros do repositório
        ''' </summary>
        ''' <returns>retorna uma lista de livros</returns>
        Public Function BuscarTodos() As IEnumerable(Of Livro) Implements IRepositorio(Of Livro).BuscarTodos
            Using contexto = New MeuContexto(_stringDeConexao)
                Dim resultado = contexto.Livros.ToList()
                Return resultado
            End Using

        End Function

        Public Function BuscaPorTitulo(titulo As String) As Livro Implements IRepositorioLivro.BuscaPorTitulo
            Using contexto = New MeuContexto(_stringDeConexao)
                Dim resultado = contexto.Livros.Find(titulo)
                Return resultado
            End Using
        End Function


    End Class
End Namespace