Imports BibliotecaConsole_Fase4.Modelos
'Imports BibliotecaConsole_Fase4.Dados.Repositorio_Dapper
Imports BibliotecaConsole_Fase4.Dados.Repositorio_EntityFramework
Imports BibliotecaConsole_Fase4.Eventos
Imports BibliotecaConsole_Fase4.Servicos
Imports System.Data.SqlClient
Imports System.Configuration
Imports Dapper
Imports BibliotecaConsole_Fase4.Repositorios

Module Programa

    Public stringDeConexao As String = ConfigurationManager.ConnectionStrings("ConexaoDb").ConnectionString

    'Livro
    Private ReadOnly _repositorioLivro As IRepositorioLivro = New RepositorioLivro(stringDeConexao)
    Private ReadOnly _servicoLivro As ServicoLivro = New ServicoLivro(_repositorioLivro)
    'Emprestador
    Private ReadOnly _repositorioEmprestador As IRepositorio(Of Emprestador) = New RepositorioEmprestador(stringDeConexao)
    Private ReadOnly _servicoEmprestador As ServicoEmprestador = New ServicoEmprestador(_repositorioEmprestador)
    'Emprestimos
    Private ReadOnly _repositorioEmprestimo As IRepositorio(Of Transacao) = New RepositorioEmprestimo(stringDeConexao)
    Private ReadOnly _servicoEmprestimo As ServicoEmprestimo = New ServicoEmprestimo(_repositorioLivro, _repositorioEmprestador, _repositorioEmprestimo)

    Sub Main()
        Dim opcao As Integer = 0
        Do
            Inicializar()
            ImprimirMenu()
            Console.Write("Escolha uma opção: ")
            Integer.TryParse(Console.ReadLine(), opcao)
            Select Case opcao
                Case 1
                    MenuCadastrarLivro()
                Case 2
                    Try
                        MenuCadastrarEmprestador()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                Case 3
                    MenuCadastrarEmprestimo()
                Case 4
                    MenuCadastrarDevolucao()
                Case 5
                    MenuListarEmprestimosEmAtraso()
                Case 6
                    MenuListarMultas()
                Case 7
                    MenuListarLivros()
                Case 8
                    MenuListarEmprestadores()
                Case 9
                    MenuListrarEmprestimos()
                Case 10
                    Console.WriteLine("Saindo...")
                Case Else
                    Console.WriteLine("Opção inválida.")
            End Select
            Console.WriteLine()
        Loop While opcao <> 10
    End Sub

    'CADASTROS

    ''' <summary>
    ''' Metodo que faz o cadastro de livros
    ''' </summary>
    Private Sub MenuCadastrarLivro()
        Console.WriteLine("Cadastrar Livro")
        Dim nomeDoLivro As String
        Dim nomeDoAutor As String
        Dim valor As String
        Dim Disponilidade As Boolean


        Console.Write("Digite o nome do Livro: ")
        nomeDoLivro = Console.ReadLine()

        Console.Write("Digite o nome do Autor: ")
        nomeDoAutor = Console.ReadLine()

        Console.Write("O livro está disponivel para emprestimo( True - Sim or False - Não) : ")
        valor = Console.ReadLine()

        Boolean.TryParse(valor, Disponilidade)

        ' Registar livro
        _servicoLivro.RegistarLivro(nomeDoLivro, nomeDoAutor, Disponilidade)
        Console.ReadLine()
    End Sub

    ''' <summary>
    ''' Metodo que faz o cadastro dos emprestadores
    ''' </summary>
    Private Sub MenuCadastrarEmprestador()

        Console.WriteLine("Cadastrar Emprestador")

        Dim nomeDoEmprestador As String

        Console.Write("Digite o nome do Emprestador: ")
        nomeDoEmprestador = Console.ReadLine()

        ' Registrar um novo emprestador
        _servicoEmprestador.RegistrarEmprestador(nomeDoEmprestador)
        Console.ReadLine()
    End Sub

    ''' <summary>
    ''' Metodo que faz o cadastro de emprestimos
    ''' </summary>
    Private Sub MenuCadastrarEmprestimo()
        Console.WriteLine("Cadastrar Emprestimo")

        Dim codigoDoLivro As Integer
        Dim codigoDoEmprestador As Integer

        Console.Write("Digite o codigo do Livro: ")
        codigoDoLivro = Console.ReadLine()

        Console.Write("Digite o codigo do Emprestador: ")
        codigoDoEmprestador = Console.ReadLine()
        _servicoEmprestimo.RegistrarEmprestimo(codigoDoLivro, codigoDoEmprestador)
        Console.WriteLine("Empréstimo registrado com sucesso.")

    End Sub

    ''' <summary>
    ''' Metodo que faz o cadastro de uma devolucao
    ''' </summary>
    Private Sub MenuCadastrarDevolucao()
        Console.WriteLine("Cadatrar Devolução ")
        Dim codigoDoLivro As Integer
        Dim codigoDoEmprestador As Integer

        Console.Write("Digite o codigo do Livro: ")
        codigoDoLivro = Console.ReadLine()

        Console.Write("Digite o codigo do Emprestador: ")
        codigoDoEmprestador = Console.ReadLine()

        _servicoEmprestimo.RegistrarDevolucao(codigoDoLivro, codigoDoEmprestador)

    End Sub


    'LISTAS 

    ''' <summary>
    ''' Metodo que mostra a lista de livro emprestados em atraso
    ''' </summary>
    Private Sub MenuListarEmprestimosEmAtraso()
        Console.WriteLine(" Mostrar Relatorio de Devolução em Atraso")
        Dim relatorioLivroEmAtraso As String = _servicoEmprestimo.GerarRelatorioLivroEmAtraso()
        Console.WriteLine("Relatório de Livros em Atraso:")
        Console.WriteLine(relatorioLivroEmAtraso)
    End Sub

    ''' <summary>
    ''' Metodo que mostra a lista de emprestimos com multas
    ''' </summary>
    Private Sub MenuListarMultas()
        Console.WriteLine(" Multas ")
        Dim relatorioMultas As String = _servicoEmprestimo.GerarRelatorioMultas()
        Console.WriteLine("Relatório de Multas:")
        Console.WriteLine(relatorioMultas)
    End Sub

    ''' <summary>
    ''' Metodo que mostra a lista de livros cadastrados
    ''' Tem duas opcões a primeira onde procura um livro especifico com id, e aoutra que mostra todos os livros cadastrados
    ''' </summary>
    Private Sub MenuListarLivros()
        Console.WriteLine("------------------------------------")
        Console.WriteLine("----- Lista de Livros -----")

        Dim id As Integer
        Console.WriteLine("Digite o codigo do livro que desejas ver: ")
        id = Console.ReadLine()

        ' Obtém um livro por ID
        Dim livro As Livro = _servicoLivro.ObterLivroPorId(id)
        If livro IsNot Nothing Then
            Console.WriteLine($"Livro encontrado: Id = {livro.Id}, Título = {livro.Titulo}, Autores = {livro.Autores}")
        Else
            Console.WriteLine("Livro não encontrado")
        End If
        Console.WriteLine("------------------------------------")

        ' Obtém todos os livros
        Dim livros As IEnumerable(Of Livro) = _servicoLivro.ObterTodosLivros()
        If livros IsNot Nothing AndAlso livros.Any() Then
            Console.WriteLine("Lista de livros:")
            For Each livroItem In livros
                Console.WriteLine($"Id = {livroItem.Id}, Título = {livroItem.Titulo}, Autores = {livroItem.Autores}, Disponibilidade = {livroItem.Disponivel}")
            Next
        Else
            Console.WriteLine("Não há livros cadastrados")
        End If

        Console.WriteLine("------------------------------------")
    End Sub

    ''' <summary>
    ''' Metodo que mostra a lista de emprestadores cadastrados
    ''' Tem duas opcões a primeira onde procura um emprestador especifico com id, e aoutra que mostra todos os emprestadores cadastrados
    ''' </summary>
    Private Sub MenuListarEmprestadores()
        Console.WriteLine("------------------------------------")
        Console.WriteLine("----- Lista de Emprestadores -----")

        Dim id As Integer
        Console.WriteLine("Digite o codigo do livro que desejas ver: ")
        id = Console.ReadLine()

        ' Obter um emprestador por ID
        Dim emprestador As Emprestador = _servicoEmprestador.ObterEmprestadorPorId(id)
        If emprestador IsNot Nothing Then
            Console.WriteLine($"Emprestador encontrado: Id = {emprestador.Id}, Nome: {emprestador.Nome}")
        Else
            Console.WriteLine("Emprestador não encontrado")
        End If
        Console.WriteLine("------------------------------------")

        'Obter todos os emprestadores
        Dim emprestadores As IEnumerable(Of Emprestador) = _servicoEmprestador.ObterTodosEmprestadores()
        If emprestadores IsNot Nothing AndAlso emprestadores.Any() Then
            Console.WriteLine("Lista de Emprestardores:")
            For Each emprestadorItem In emprestadores
                Console.WriteLine($"Id = {emprestadorItem.Id}, Nome: {emprestadorItem.Nome}")
            Next
        Else
            Console.WriteLine("Não há Emprestadores cadastrados")
        End If

        Console.WriteLine("------------------------------------")
    End Sub


    ''' <summary>
    ''' Metodo que mostra a lista de emprestimos cadastrados
    ''' 
    ''' </summary>
    Private Sub MenuListrarEmprestimos()

        Console.WriteLine("------------------------------------")
        Console.WriteLine("----- Lista de Livros Emprestados -----")


        Dim transacoes As IEnumerable(Of Transacao) = _servicoEmprestimo.BuscarTodosEmprestimos()
        If transacoes IsNot Nothing AndAlso transacoes.Any() Then
            For Each emprestimoItem In transacoes
                Console.WriteLine($"Codigo Do Emprestimo = {emprestimoItem.Id}, Titulo do Livro: {emprestimoItem.Livro.Titulo} , Nome do Emprestador: {emprestimoItem.Emprestador.Nome} ,  Data Da Devolução: {emprestimoItem.DataDevolucao}, Data Devolvida: {emprestimoItem.DataDevolvida}, Multa: {emprestimoItem.ValorMulta}")
                Console.WriteLine("------------------------------------")
            Next
            Console.WriteLine("------------------------------------")
        Else
            Console.WriteLine("Não há Livros Emprestados")
        End If

        Console.WriteLine("------------------------------------")

    End Sub



    'EVENTOS

    Private Sub LivroRegistradoHandler(sender As Object, evento As EventoLivro)
        Dim livro As Livro = evento.Livro
        Console.WriteLine("O Livro foi registrado com Sucesso!")
        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("Título Registrado: {0}", livro.Titulo)
        Console.WriteLine("Autor(es) Registrado: {0}", livro.Autores)
        Console.WriteLine("-----------------------------------------")
    End Sub

    Private Sub EmprestadorRegistradoHandler(sender As Object, e As EventoEmprestador)
        Dim emprestador As Emprestador = e.Emprestador
        Console.WriteLine("O Emprestador foi registrado com Sucesso!")
        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("Nome registrado: {0}", emprestador.Nome)
        Console.WriteLine("-----------------------------------------")
        Console.ReadLine()

    End Sub

    ' Manipulador de eventos para o evento EmprestimoRegistrado
    Private Sub EmprestimoRegistradoHandler(sender As Object, evento As EventoEmprestimo)
        Console.WriteLine("O Empréstimo foi registrado com Sucesso!")
        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("Livro: " & evento.Transacao.Livro.Titulo)
        Console.WriteLine("Emprestador: " & evento.Transacao.Emprestador.Nome)
        Console.WriteLine("Data de devolução: " & evento.Transacao.DataDevolucao.ToString("dd/MM/yyyy"))
        Console.WriteLine("-----------------------------------------")
        Console.WriteLine()
        Console.ReadLine()
    End Sub
    ' Manipulador de eventos para o evento DevolucaoRegistrada
    Private Sub DevolucaoRegistradaHandler(sender As Object, evento As EventoDevolucao)
        Console.WriteLine("A Devolução foi  registrada:")
        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("Livro: " & evento.Transacao.Livro.Titulo)
        Console.WriteLine("Emprestador: " & evento.Transacao.Emprestador.Nome)
        Console.WriteLine("-----------------------------------------")


        If evento.Transacao.DataDevolvida.HasValue Then
            Console.WriteLine("Data de devolução: " & evento.Transacao.DataDevolvida.Value.ToString("dd/MM/yyyy"))
            Console.WriteLine("Valor da multa: " & evento.Transacao.ValorMulta & " Kz")
            Console.WriteLine("-----------------------------------------")
        Else
            Console.WriteLine("Livro devolvido dentro do prazo estipulado.")
        End If

        Console.WriteLine()
    End Sub

    Private Sub ImprimirMenu()
        Console.WriteLine("=== MENU ===")
        Console.WriteLine("1 - Cadastrar Livro")
        Console.WriteLine("2 - Cadastrar Emprestador")
        Console.WriteLine("3 - Cadastrar Emprestimo")
        Console.WriteLine("4 - Cadastrar Devolucao")
        Console.WriteLine("5 - Relatorio de devolucao em atraso")
        Console.WriteLine("6 - Multas")
        Console.WriteLine("7 - Lista de Livros")
        Console.WriteLine("8 - Lista de Emprestadores")
        Console.WriteLine("9 - Lista de Emprestimos")
        Console.WriteLine("10 - Sair")
    End Sub
    Private Sub Inicializar()
        'stringDeConexao = 


        AddHandler _servicoEmprestimo.EmprestimoRegistrado, AddressOf EmprestimoRegistradoHandler
        AddHandler _servicoEmprestimo.DevolucaoRegistrada, AddressOf DevolucaoRegistradaHandler
        AddHandler _servicoEmprestador.EmprestadorRegistrado, AddressOf EmprestadorRegistradoHandler
        AddHandler _servicoLivro.LivroRegistrado, AddressOf LivroRegistradoHandler

    End Sub

End Module
