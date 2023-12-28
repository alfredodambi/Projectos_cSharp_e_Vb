Imports BibliotecaConsole_Fase4.Modelos
Imports BibliotecaConsole_Fase4.Repositorios
Imports BibliotecaConsole_Fase4.Eventos
Imports System.Transactions

Namespace Servicos
    Public Class ServicoEmprestimo

        '
        Private Const CONST_VALOR_MULTA_DIARIA As Decimal = 1.5D
        Private ReadOnly _repositorioLivro As IRepositorioLivro
        Private ReadOnly _repositorioEmprestador As IRepositorio(Of Emprestador)
        Private ReadOnly _repositorioEmprestimo As IRepositorio(Of Transacao)

        'Eventos
        Public Event EmprestimoRegistrado As EventHandler(Of EventoEmprestimo)
        Public Event DevolucaoRegistrada As EventHandler(Of EventoDevolucao)

        'Construtor da classe
        Public Sub New(repositorioLivro As IRepositorioLivro, repositorioEmprestador As IRepositorio(Of Emprestador), repositorioEmprestimo As IRepositorio(Of Transacao))
            _repositorioLivro = repositorioLivro
            _repositorioEmprestador = repositorioEmprestador
            _repositorioEmprestimo = repositorioEmprestimo
        End Sub

        ''' <summary>
        ''' 'Serviço usado para o registo de um emprestimo
        ''' </summary>
        ''' <param name="idLivro">Paramentro que recebe o id do livro</param>
        ''' <param name="idEmprestador">Parametro do id do emprestador </param>
        Public Sub RegistrarEmprestimo(idLivro As Integer, idEmprestador As Integer)

            Dim livro As Livro = _repositorioLivro.BuscarPorId(idLivro)
            Dim emprestador As Emprestador = _repositorioEmprestador.BuscarPorId(idEmprestador)

            'verifica se o livro existe
            If livro Is Nothing Then
                Throw New InvalidOperationException("O livro indicado não existe")
            End If
            'Verifica se o emprestador existe
            If emprestador Is Nothing Then
                Throw New InvalidOperationException("O emprestador indicado não existe")
            End If

            'Verifica a disponibilidade do livro
            If Not livro.Disponivel Then
                Throw New InvalidOperationException("O livro indicado não está disponível, escolha outro")
            End If

            Using escopoTransacao As New TransactionScope()

                livro.Disponivel = False

                _repositorioLivro.ActualizarDisponibilidade(livro, False)

                Dim dataDevolucaoLivro As Date = Date.Today.AddDays(7)
                Dim transacao As New Transacao(livro, emprestador, dataDevolucaoLivro)


                _repositorioEmprestimo.Criar(transacao)
                escopoTransacao.Complete()
                RaiseEvent EmprestimoRegistrado(Me, New EventoEmprestimo(transacao))
            End Using
        End Sub

        ''' <summary>
        ''' Serviço usado para a devolução de um livro emprestado
        ''' </summary>
        ''' <param name="idLivro">Parametro id do livro</param>
        ''' <param name="idEmprestador">Paramentro id do emprestador</param>
        Public Sub RegistrarDevolucao(idLivro As Integer, idEmprestador As Integer)
            If idLivro < 1 Then
                Throw New ArgumentException("Insira um código de livro válido")
            End If

            If idEmprestador < 1 Then
                Throw New ArgumentException("Insira um código de emprestador válido")
            End If

            Dim emprestimoExistente = _repositorioEmprestimo.BuscarTodos().SingleOrDefault(Function(emprestimo) emprestimo.Livro.Id = idLivro AndAlso emprestimo.Emprestador.Id = idEmprestador)

            'Verifica no banco de dados se um emprestimo existe
            Dim transacao As Transacao = emprestimoExistente


            If transacao Is Nothing Then
                Throw New InvalidOperationException("A transação indicada não existe")
            End If

            If transacao.DataDevolvida.HasValue Then
                Throw New InvalidOperationException("O livro já foi Devolvido")
            End If

            Using escopoTransacao As New TransactionScope()


                transacao.DataDevolvida = Date.Today
                transacao.Livro.Disponivel = True

                _repositorioLivro.ActualizarDisponibilidade(transacao.Livro, True)


                'Calcula a diferença de dias entre a data da devolução e a data devolvida do livro
                Dim diasDeAtraso As Integer = DateDiff(DateInterval.Day, transacao.DataDevolucao, transacao.DataDevolvida.Value)

                'Calculo do valor da multa
                If diasDeAtraso > 0 Then
                    Dim valorDaMulta As Decimal = diasDeAtraso * CONST_VALOR_MULTA_DIARIA
                    transacao.ValorMulta = valorDaMulta
                End If

                _repositorioEmprestimo.Actualizar(transacao)
                escopoTransacao.Complete()
                RaiseEvent DevolucaoRegistrada(Me, New EventoDevolucao(transacao))
            End Using

        End Sub

        ''' <summary>
        ''' Servico usado para gerar uma multa quando a data da entrega do livro por parte do emprestador ultrapassa a data definida
        ''' </summary>
        ''' <returns>Retorna o valor da multa do emprestimo</returns>
        Public Function GerarRelatorioMultas() As String
            Dim resultado As String = "Multas" & vbCrLf
            Dim valorTotalMulta As Decimal = 0

            'Pegar todos os emprestidos registados no banco de dados
            Dim listaDeEmprestimos = _repositorioEmprestimo.BuscarTodos()

            'Estrutura para recebe todos os emprestimos que possuem multas
            For Each transacao As Transacao In listaDeEmprestimos
                If transacao.ValorMulta > 0 Then
                    resultado += "Título: " & transacao.Livro.Titulo & vbCrLf
                    resultado += "Autor: " & transacao.Livro.Autores & vbCrLf
                    resultado += "Emprestador: " & transacao.Emprestador.Nome & vbCrLf
                    resultado += "Valor da multa: " & transacao.ValorMulta.ToString("C") & vbCrLf & vbCrLf

                    valorTotalMulta += transacao.ValorMulta
                End If
            Next

            If valorTotalMulta > 0 Then
                resultado += "Total de multas a pagar: " & valorTotalMulta.ToString("C") & vbCrLf
            Else
                resultado += "Não há multas a pagar." & vbCrLf
            End If

            Return resultado
        End Function

        ''' <summary>
        ''' Serviço que mostra o relatorio(lista) dos livros emprestados que se encontram em atraso para entrega
        ''' </summary>
        ''' <returns>Retorna os livros em atrasos</returns>
        Public Function GerarRelatorioLivroEmAtraso() As String

            Dim resultado As String = "Mostrar Relatório de Devolução em Atraso" & vbCrLf

            'Variavel que recebe do banco de dados todos os emprestimos(livros) que ainda não foram devolvidos
            Dim listaDeEmprestimo = _repositorioEmprestimo.BuscarTodos().Where(Function(emprestimo) Not emprestimo.DataDevolvida.HasValue AndAlso emprestimo.DataDevolucao < Date.Today)

            'Estrutura que mostra a lista de emprestimos em atraso(não devolvidos)
            For Each transacao As Transacao In listaDeEmprestimo
                resultado += "Título: " & transacao.Livro.Titulo & vbCrLf
                resultado += "Autor: " & transacao.Livro.Autores & vbCrLf
                resultado += "Emprestador: " & transacao.Emprestador.Nome & vbCrLf
                resultado += "Data de devolução: " & transacao.DataDevolucao.ToString("d") & vbCrLf & vbCrLf
            Next

            If resultado = "Mostrar Relatório de Devolução em Atraso" & vbCrLf Then
                resultado += "Não há livros em atraso." & vbCrLf
            End If

            Return resultado
        End Function

        ''' <summary>
        ''' Serviço que mostra a lista de livros emprestados
        ''' </summary>
        ''' <returns>Retorna a lista de livros emprestados</returns>
        Public Function BuscarTodosEmprestimos() As IEnumerable(Of Transacao)
            Return _repositorioEmprestimo.BuscarTodos()
        End Function
    End Class
End Namespace


