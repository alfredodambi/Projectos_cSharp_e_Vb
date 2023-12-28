Imports BibliotecaConsole_Fase4.Modelos
Imports BibliotecaConsole_Fase4.Repositorios
Imports System.Data.Entity

Namespace Dados.Repositorio_EntityFramework
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
            Using contexto = New MeuContexto(_stringDeConexao)
                contexto.Emprestadores.Add(emprestador)
                contexto.SaveChanges()
            End Using


        End Sub
        ''' <summary>
        ''' Metodo que permite atualizar as informações de um emprestador existente no repositório
        ''' </summary>
        ''' <param name="emprestador"></param>
        Public Sub Actualizar(emprestador As Emprestador) Implements IRepositorio(Of Emprestador).Actualizar
            Using contexto = New MeuContexto(_stringDeConexao)
                contexto.Entry(emprestador).State = EntityState.Modified
                contexto.SaveChanges()
            End Using
        End Sub
        ''' <summary>
        ''' Metodo que permite remover um emprestador específico do repositório.
        ''' </summary>
        ''' <param name="emprestador"></param>
        Public Sub Remover(emprestador As Emprestador) Implements IRepositorio(Of Emprestador).Remover
            Using contexto = New MeuContexto(_stringDeConexao)
                contexto.Emprestadores.Remove(emprestador)
            End Using
        End Sub

        Public Function BuscaPorNome(nome As String) As Emprestador Implements IRepositorioEmprestador.BuscaPorNome
            Using contexto = New MeuContexto(_stringDeConexao)
                Dim resultado = contexto.Emprestadores.Find(nome)
                Return resultado
            End Using
        End Function

        ''' <summary>
        ''' Funcao que  permite obter um emprestador específico com base em seu id a partir do repositório
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Function BuscarPorId(id As Integer) As Emprestador Implements IRepositorio(Of Emprestador).BuscarPorId
            Using contexto = New MeuContexto(_stringDeConexao)
                Dim resultado = contexto.Emprestadores.Find(id)
                Return resultado
            End Using
        End Function


        ''' <summary>
        ''' permite obter todos os emprestadores do repositório como uma lista de objetos Emprestador
        ''' </summary>
        ''' <returns></returns>
        Public Function BuscarTodos() As IEnumerable(Of Emprestador) Implements IRepositorio(Of Emprestador).BuscarTodos
            Using contexto = New MeuContexto(_stringDeConexao)
                Return contexto.Emprestadores.ToList()
            End Using

        End Function
    End Class
End Namespace