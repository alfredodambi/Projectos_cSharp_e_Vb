Imports BibliotecaConsole_Fase4.Modelos
Imports BibliotecaConsole_Fase4.Repositorios
Imports System.Data.Entity

Namespace Dados.Repositorio_EntityFramework
    Public Class RepositorioEmprestimo
        Implements IRepositorio(Of Transacao)
        Private ReadOnly _strincConexao As String
        ''' <summary>
        ''' Construtor que inicializa uma lista de livro vazia
        ''' </summary>
        Public Sub New(strincConexao As String)
            _strincConexao = strincConexao
        End Sub

        ''' <summary>
        ''' Metodo para criar um emprestimo
        ''' </summary>
        ''' <param name="transacao">parametro do tipo transacao</param>
        Public Sub Criar(transacao As Transacao) Implements IRepositorio(Of Transacao).Criar
            Using _contexto = New MeuContexto(_strincConexao)
                _contexto.Transacoes.Add(transacao)
                _contexto.SaveChanges()
            End Using
        End Sub

        ''' <summary>
        ''' Metodo que permite actualizar dados de um emprestimo, usado especificamente para o registo de devolução de um livro
        ''' </summary>
        ''' <param name="transacao">parametro do tipo transacao</param>
        Public Sub Actualizar(transacao As Transacao) Implements IRepositorio(Of Transacao).Actualizar
            Using _contexto = New MeuContexto(_strincConexao)
                _contexto.Entry(transacao).State = EntityState.Modified
                _contexto.SaveChanges()
            End Using
        End Sub

        ''' <summary>
        ''' Metodo para apagar uma transacao
        ''' </summary>
        ''' <param name="transacao"></param>
        Public Sub Remover(transacao As Transacao) Implements IRepositorio(Of Transacao).Remover
            Using _contexto = New MeuContexto(_strincConexao)
                _contexto.Transacoes.Remove(transacao)
                _contexto.SaveChanges()
            End Using
        End Sub

        ''' <summary>
        ''' Funcao para procurar um livro por id
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns>Retornar um livro especifico</returns>
        Private Function BuscarPorId(id As Integer) As Transacao Implements IRepositorio(Of Transacao).BuscarPorId
            Using _contexto = New MeuContexto(_strincConexao)
                Return _contexto.Transacoes.AsNoTracking.SingleOrDefault(Function(t) t.Id = id)
            End Using
        End Function

        ''' <summary>
        ''' Funcao usada para  obter a lista de todos os emprestimos 
        ''' </summary>
        ''' <returns>Todos os emprestimos</returns>
        Private Function BuscarTodos() As IEnumerable(Of Transacao) Implements IRepositorio(Of Transacao).BuscarTodos
            Using _contexto = New MeuContexto(_strincConexao)
                Return _contexto.Transacoes.Include("Emprestador").Include("Livro").ToList()
            End Using
        End Function

    End Class
End Namespace
