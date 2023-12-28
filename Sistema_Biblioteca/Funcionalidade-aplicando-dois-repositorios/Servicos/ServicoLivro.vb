Imports BibliotecaConsole_Fase4.Modelos
Imports BibliotecaConsole_Fase4.Repositorios
Imports BibliotecaConsole_Fase4.Eventos

Namespace Servicos
    Public Class ServicoLivro

        Private ReadOnly _repositorioLivro As IRepositorioLivro

        'Evento
        Public Event LivroRegistrado As EventHandler(Of EventoLivro)

        ''' <summary>
        ''' Construtor que inicializa o repositorio Livro
        ''' </summary>
        ''' <param name="repositorioLivro"></param>
        Public Sub New(repositorioLivro As IRepositorio(Of Livro))
            _repositorioLivro = repositorioLivro
        End Sub

        ''' <summary>
        ''' Metodo usado para fazer o registo de um livro
        ''' </summary>
        ''' <param name="titulo"></param>
        ''' <param name="autores"></param>
        Public Sub RegistarLivro(ByVal titulo As String, ByVal autores As String, ByVal disponibilidade As Boolean)

            ' Validações
            If String.IsNullOrWhiteSpace(titulo) Then
                Throw New ArgumentException("Deve preencher o título do livro")
            End If
            If String.IsNullOrWhiteSpace(autores) Then
                Throw New ArgumentException("Deve preencher o nome do(s) autor(es)")
            End If

            Dim livroExistente = _repositorioLivro.BuscaPorTitulo(titulo)

            If Not IsNothing(livroExistente) Then
                Throw New ArgumentException("O nome do livro já existe")
            End If


            Dim novoLivro As Livro = New Livro(titulo, autores, disponibilidade)
            _repositorioLivro.Criar(novoLivro)
            ' Aciona o evento LivroRegistrado
            RaiseEvent LivroRegistrado(Me, New EventoLivro(novoLivro))

        End Sub

        ''' <summary>
        ''' Obter livro por id
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns>Retorna um livro especifico</returns>
        Public Function ObterLivroPorId(id As Integer) As Livro
            Return _repositorioLivro.BuscarPorId(id)
        End Function

        ''' <summary>
        ''' Obter todos o livros
        ''' </summary>
        ''' <returns>Retorna todos os livros cadastrados</returns>
        Public Function ObterTodosLivros() As IEnumerable(Of Livro)
            Return _repositorioLivro.BuscarTodos()
        End Function



    End Class
End Namespace