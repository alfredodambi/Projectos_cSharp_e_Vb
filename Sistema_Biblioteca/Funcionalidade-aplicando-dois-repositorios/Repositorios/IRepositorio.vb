Namespace Repositorios
    Public Interface IRepositorio(Of T)
        Sub Criar(entidade As T)
        Sub Actualizar(entidade As T)
        Sub Remover(entidade As T)
        Function BuscarPorId(id As Integer) As T
        Function BuscarTodos() As IEnumerable(Of T)
    End Interface
End Namespace