Imports BibliotecaConsole_Fase4.Modelos
Imports BibliotecaConsole_Fase4.Repositorios
Imports BibliotecaConsole_Fase4.Eventos

Namespace Servicos
    Public Class ServicoEmprestador
        Private ReadOnly _repositorioEmprestador As IRepositorioEmprestador

        Public Sub New(repositorioEmprestador As IRepositorio(Of Emprestador))
            _repositorioEmprestador = repositorioEmprestador
        End Sub

        'Evento
        Public Event EmprestadorRegistrado As EventHandler(Of EventoEmprestador)
        Public Sub RegistrarEmprestador(nome As String)
            ' Validações
            If String.IsNullOrWhiteSpace(nome) Then
                Throw New ArgumentException("Deve preencher o nome do emprestador")
            End If

            Dim emprestadorExistente = _repositorioEmprestador.BuscaPorNome(nome)

            If Not IsNothing(emprestadorExistente) Then
                Throw New ArgumentException("O nome do emprestador ja existe")
            End If

            Dim novoEmprestador As Emprestador = New Emprestador(nome)
            _repositorioEmprestador.Criar(novoEmprestador)
            ' Aciona o evento EmprestadorRegistrado
            RaiseEvent EmprestadorRegistrado(Me, New EventoEmprestador(novoEmprestador))

        End Sub

        ''' <summary>
        ''' Obter um emprestador por id
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns>Retorna um emprestador</returns>
        Public Function ObterEmprestadorPorId(id As Integer) As Emprestador
            Return _repositorioEmprestador.BuscarPorId(id)
        End Function

        ''' <summary>
        ''' Obter todos os emprestadores
        ''' </summary>
        ''' <returns>Retorna todos os emprestadores</returns>
        Public Function ObterTodosEmprestadores() As IEnumerable(Of Emprestador)
            Return _repositorioEmprestador.BuscarTodos()
        End Function

    End Class
End Namespace
