Imports BibliotecaConsole_Fase4.Modelos

Namespace Repositorios
    Public Interface IRepositorioLivro
        Inherits IRepositorio(Of Livro)
        Sub ActualizarDisponibilidade(livro As Livro, Disponibilidade As Boolean)

        Function BuscaPorTitulo(titulo As String) As Livro

    End Interface
End Namespace
