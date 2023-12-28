Imports BibliotecaConsole_Fase4.Modelos

Namespace Repositorios
    Public Interface IRepositorioEmprestador
        Inherits IRepositorio(Of Emprestador)
        Function BuscaPorNome(nome As String) As Emprestador
    End Interface
End Namespace


