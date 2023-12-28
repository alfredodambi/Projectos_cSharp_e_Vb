Imports System.IO
Imports System.Threading
Imports Google.Apis
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Gmail.v1
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports Google.Apis.Gmail.v1.Data
Imports System.Runtime.Remoting
Imports System.Text
Imports System.Net.Mail
Imports InoveBoxTeste.Modelos
Imports InoveBoxTeste.Servicos
Imports Microsoft.VisualBasic.ApplicationServices
Imports Thread = Google.Apis.Gmail.v1.Data.Thread
Imports InoveBoxTeste.Interfaces
Imports Newtonsoft.Json
Imports System.Net.Mime

Module Programa
    <Obsolete>
    Sub Main()



        Dim credencial = ObterCredencial()
        'C:\Users\Lenovo\Documents\FORMACAO_PROLIPOL\Anotacoes.txt


        Dim _servicoEmail As IEmail = New ServicoEmail()

        Dim opcao As Integer = 0
        Do
            Console.WriteLine("--- SISTEMA TESTE INOVEBOX ---")
            Console.WriteLine("1- Caixa de Entrada")
            Console.WriteLine("2- Compor um Email")
            Console.WriteLine("3- Responder Email Sem Assunto")
            Console.WriteLine("4- Responder Email Com Assunto")
            Console.WriteLine("5- Reencaminhar Email")
            Console.WriteLine("6- Sair")

            opcao = Integer.Parse(Console.ReadLine())

            Select Case opcao
                Case 1
                    Console.WriteLine(" Caixa de Entrada ")

                    'ListaDeEmailsAsync().GetAwaiter().GetResult()
                    '_servicoEmail.MostrarListaDeEmails().GetAwaiter().GetResult()
                    'ListaDeEmailsAsync().GetAwaiter().GetResult()
                    ListaDeMensagensRecebidas()
                    'Console.WriteLine("Mensagens Enviadas")
                    'ListaDeMensagensEnviadas()
                    Console.ReadLine()
                Case 2
                    Console.WriteLine("Enviar um novo Email")

                    Dim mensagem As Email = New Email()
                    Try

                        'Console.WriteLine("Digite o email de origem: ")
                        'Dim emailDeOrigem As String = Console.ReadLine()
                        'mensagem.Origem = emailDeOrigem

                        'Console.WriteLine("Digite os emails de destino (separados por vírgula): ")
                        'Dim destinatariosEnviar As IEnumerable(Of String) = Console.ReadLine().Split(","c).Select(Function(s) s.Trim())
                        'mensagem.Destinatario = destinatariosEnviar

                        'Console.WriteLine("Digite o assunto do email: ")
                        'Dim assuntoDoEmail As String = Console.ReadLine()
                        'mensagem.Assunto = assuntoDoEmail

                        'Console.WriteLine("Digite o conteudo(mensagem) do email: ")
                        'Dim conteudoDoEmail As String = Console.ReadLine()
                        'mensagem.Conteudo = conteudoDoEmail

                        'Console.WriteLine("Digite os caminhos dos anexos (separados por vírgula):")
                        'Dim anexosEnviar As IEnumerable(Of String) = Console.ReadLine().Split(","c).Select(Function(s) s.Trim())
                        'mensagem.Anexo = anexosEnviar

                        '_servicoEmail.EnviarEmail(mensagem.Origem, mensagem.Destinatario, mensagem.Assunto, mensagem.Conteudo, mensagem.Anexo)
                        'Console.WriteLine("Email enviado com sucesso")

                        '    Dim emailOrigem As String = "inovebox2023@gmail.com"
                        '    Dim destinatarios As New List(Of String) From {"alfredodambi7@gmail.com"}
                        '    Dim assunto As String = "Assunto do email"
                        '    Dim corpo As String = "Conteúdo do email"
                        '    Dim anexos As New List(Of Anexo) From {
                        '    New Anexo() With {
                        '        .CaminhoArquivo = "C:\Users\Lenovo\Documents\FORMACAO_PROLIPOL\testes1.pdf",
                        '        .NomeArquivo = "testes1.pdf",
                        '        .ContentType = "application/pdf"
                        '    }
                        '}
                        '    _servicoEmail.EnviarEmail(emailOrigem, destinatarios, assunto, corpo, anexos)

                        'EnviarEmailComAnexo()
                        EnviarMaisDeUmAnexo()


                        Console.ReadLine()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                    Console.ReadLine()
                Case 3
                    ResponderEmailSemAssunto()
                Case 4
                    ResponderEmaillComAssunto()
                Case 5
                    ReencaminharMensagemEmail()
                Case 6
                    Console.WriteLine("Saindo...")
            End Select


        Loop While (opcao <> 6)
        Console.ReadLine()

    End Sub

    'Obter Credencial
    Private Function ObterCredencial() As Task(Of UserCredential)
        Dim idDoCliente As String = "" 'Removido
        Dim senhaDoCliente As String = "" 'Removido
        Dim escopo As String() = {GmailService.Scope.MailGoogleCom}

        Return GoogleWebAuthorizationBroker.AuthorizeAsync(
        New ClientSecrets With {.ClientId = idDoCliente, .ClientSecret = senhaDoCliente},
        escopo,
        "user",
        CancellationToken.None
    )
    End Function

    'Obter Servico
    Private Async Function ObterServico() As Task(Of GmailService)
        Dim credencial = Await ObterCredencial()

        Dim servico = New GmailService(New BaseClientService.Initializer() With {
                                    .HttpClientInitializer = credencial,
                                    .ApplicationName = "InoveBox"
                                })
        Return servico
    End Function

    'Enviar Email com um anexo
    Private Sub EnviarEmailComAnexo()

        Using servico = ObterServico().GetAwaiter().GetResult()
            'Dim attachmentPath As String = "C:\Users\PC-GTDF5Y1\Desktop\teste.txt"
            Dim caminhoDoAnexo As String = "C:\Users\PC-GTDF5Y1\Pictures\imagem.gif"
            'Dim attachmentContent As String = File.ReadAllText(attachmentPath)
            Dim conteudoDoAnexo As Byte() = File.ReadAllBytes(caminhoDoAnexo)
            'Dim attachmentBase64 As String = Convert.ToBase64String(Encoding.UTF8.GetBytes(attachmentContent))
            Dim anexoNaBase64 As String = Convert.ToBase64String(conteudoDoAnexo)


            Dim mensagem As New StringBuilder()
            mensagem.Append("To: alfredodambi7@gmail.com" & vbCrLf)
            mensagem.Append("From: inovebox2023@gmail.com" & vbCrLf)
            mensagem.Append("Subject: Teste de envio de e-mail com anexo" & vbCrLf)
            mensagem.Append("MIME-Version: 1.0" & vbCrLf)
            mensagem.Append("Content-Type: multipart/mixed; boundary=boundary" & vbCrLf)
            mensagem.Append(vbCrLf)
            mensagem.Append("--boundary" & vbCrLf)
            mensagem.Append("Content-Type: text/plain; charset=UTF-8" & vbCrLf)
            mensagem.Append(vbCrLf)
            mensagem.Append("Olá," & vbCrLf)
            mensagem.Append(vbCrLf)
            mensagem.Append("Este é um teste de envio de e-mail com anexo usando o Gmail API." & vbCrLf)
            mensagem.Append(vbCrLf)
            mensagem.Append("--boundary" & vbCrLf)
            'mensagem.Append("Content-Type: application/octet-stream" & vbCrLf)
            mensagem.Append("Content-Type: image/gif" & vbCrLf)
            mensagem.Append("Content-Transfer-Encoding: base64" & vbCrLf)
            'mensagem.Append("Content-Disposition: attachment; filename=teste.txt; " & vbCrLf)
            mensagem.Append("Content-Disposition: attachment; filename=imagem.gif; " & vbCrLf)
            mensagem.Append(vbCrLf)
            mensagem.Append(anexoNaBase64 & vbCrLf)
            mensagem.Append(vbCrLf)
            mensagem.Append("--boundary--" & vbCrLf)

            Dim raw As New Message()
            raw.Raw = ConverterBase(mensagem.ToString())

            servico.Users.Messages.Send(raw, "me").Execute()
        End Using
    End Sub

    'Enviar email com mais de um anexo
    Private Sub EnviarMaisDeUmAnexo()
        Using servico = ObterServico().GetAwaiter().GetResult()


            Dim origem As String = "inovebox2023@gmail.com"
            Dim destinatario As String = "alfredodambi7@gmail.com"
            Dim assunto As String = "Teste de envio de e-mail com anexo"
            Dim conteudo As String = "Olá, este é um teste de envio de e-mail com anexo dois anexos usando o Gmail API."

            Dim caminhoDosAnexos As New List(Of String)()
            caminhoDosAnexos.Add("C:\Users\PC-GTDF5Y1\Pictures\imagem.gif")
            caminhoDosAnexos.Add("C:\Users\PC-GTDF5Y1\Desktop\teste.txt")
            'attachmentPaths.Add("C:\Users\PC-GTDF5Y1\Desktop\work\testepdf.pdf")


            Dim mensagem As New StringBuilder()
            mensagem.Append($"To: {destinatario}" & vbCrLf)
            mensagem.Append($"From: {origem}" & vbCrLf)
            mensagem.Append($"Subject: {assunto}" & vbCrLf)
            mensagem.Append("MIME-Version: 1.0" & vbCrLf)
            mensagem.Append("Content-Type: multipart/mixed; boundary=boundary" & vbCrLf)
            mensagem.Append(vbCrLf)
            mensagem.Append("--boundary" & vbCrLf)
            mensagem.Append("Content-Type: text/plain; charset=UTF-8" & vbCrLf)
            mensagem.Append(vbCrLf)
            mensagem.Append(conteudo & vbCrLf)
            mensagem.Append(vbCrLf)
            mensagem.Append(vbCrLf)

            'Verificar se existe um anexo
            If caminhoDosAnexos.Count > 0 Then
                For Each caminhoDoAnexo As String In caminhoDosAnexos
                    Dim conteudoDoAnexo As Byte() = File.ReadAllBytes(caminhoDoAnexo)
                    Dim anexoNaBase64 As String = Convert.ToBase64String(conteudoDoAnexo)
                    Dim nomeDoAnexo As String = Path.GetFileName(caminhoDoAnexo)
                    mensagem.Append("--boundary" & vbCrLf)
                    mensagem.Append("Content-Type: application/octet-stream " & vbCrLf)
                    mensagem.Append("Content-Transfer-Encoding: base64" & vbCrLf)
                    mensagem.Append("Content-Disposition: attachment; filename=" & nomeDoAnexo & vbCrLf)
                    mensagem.Append(vbCrLf)
                    mensagem.Append(anexoNaBase64 & vbCrLf)
                    mensagem.Append(vbCrLf)
                Next
            End If

            mensagem.Append("--boundary--" & vbCrLf)

            Dim raw As New Message()
            raw.Raw = ConverterBase(mensagem.ToString())

            servico.Users.Messages.Send(raw, "me").Execute()
        End Using
    End Sub

    'Responder Email
    Private Sub ResponderEmail(mensagemId As String, destinatario As String, assunto As String, conteudo As String)
        Using servico = ObterServico().GetAwaiter().GetResult()
            Dim pedido = servico.Users.Messages.Get("me", mensagemId)
            Dim conversa As Message = pedido.Execute()

            Dim listaDeMensagemId As New List(Of String)()

            ' Obter todos os IDs de mensagens da conversa
            If conversa.Payload.Headers IsNot Nothing Then
                For Each cabecalho In conversa.Payload.Headers
                    If cabecalho.Name = "Message-ID" Then
                        listaDeMensagemId.Add(cabecalho.Value)
                    End If
                Next
            End If

            Dim responderMensagem As New StringBuilder()
            responderMensagem.Append("From: inovebox2023@gmail.com" & vbCrLf)
            responderMensagem.Append($"To: {destinatario}" & vbCrLf)
            responderMensagem.Append($"In-Reply-To: {mensagemId}" & vbCrLf)
            responderMensagem.Append($"Subject: Re: {assunto}" & vbCrLf)

            ' Definir o campo References com os IDs das mensagens anteriores
            Dim referencias As String = String.Join(" ", listaDeMensagemId)
            responderMensagem.Append($"References: {referencias}" & vbCrLf)
            responderMensagem.Append("MIME-Version: 1.0" & vbCrLf)
            responderMensagem.Append("Content-Type: text/plain; charset=UTF-8" & vbCrLf)
            responderMensagem.Append(vbCrLf)
            responderMensagem.Append(conteudo & vbCrLf)

            Dim mensagem As New Message()
            mensagem.ThreadId = conversa.ThreadId
            mensagem.Raw = ConverterBase(responderMensagem.ToString())
            servico.Users.Messages.Send(mensagem, "me").Execute()
        End Using
    End Sub

    ''' <summary>
    ''' Responder um Email sem precisar mudar(digitar) o assunto da conversa
    ''' </summary>
    Private Sub ResponderEmailSemAssunto()
        Using servico = ObterServico().GetAwaiter().GetResult()
            Dim idDoUsuario As String = "me"
            Dim consulta As String = "label:inbox"

            Dim pedido = servico.Users.Messages.List(idDoUsuario)
            pedido.Q = consulta
            Dim resposta = pedido.Execute()

            ' Verifique se há mensagens na resposta
            If resposta.Messages IsNot Nothing AndAlso resposta.Messages.Count > 0 Then

                For Each mensagem In resposta.Messages
                    Dim detalhesDoPedido = servico.Users.Messages.Get("me", mensagem.Id)
                    Dim detalhes = detalhesDoPedido.Execute()

                    Dim remetente = detalhes.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "From")?.Value
                    Dim assunto = detalhes.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "Subject")?.Value

                    Console.WriteLine("Remetente: " & remetente)
                    Console.WriteLine("Assunto: " & assunto)

                    Console.WriteLine("Deseja responder este email? (S/N)")
                    Dim respostaDoUsuario = Console.ReadLine()
                    If respostaDoUsuario.Trim().ToUpper() = "S" Then
                        Dim destinatario As String = remetente
                        Dim assuntos As String = assunto
                        Console.WriteLine("Escreva a tua resposta: ")
                        Dim conteudo As String = Console.ReadLine()

                        ResponderEmail(mensagem.Id, destinatario, assuntos, conteudo)
                        Console.WriteLine("E-mail respondido com sucesso")
                    End If
                Next
            Else
                Console.WriteLine("Nenhuma mensagem encontrada.")
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Responder um email editando o assunto, ou seja, como se fosse uma outra conversa
    ''' </summary>
    Private Sub ResponderEmaillComAssunto()
        Using servico = ObterServico().GetAwaiter().GetResult()
            Dim idDoUsuario As String = "me"
            Dim consulta As String = "label:inbox"

            Dim pedido = servico.Users.Messages.List(idDoUsuario)
            pedido.Q = consulta
            Dim resposta = pedido.Execute()

            ' Verifique se há mensagens na resposta
            If resposta.Messages IsNot Nothing AndAlso resposta.Messages.Count > 0 Then

                For Each mensagem In resposta.Messages
                    Dim detalhesDoPedido = servico.Users.Messages.Get("me", mensagem.Id)
                    Dim detalhes = detalhesDoPedido.Execute()

                    Dim remetente = detalhes.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "From")?.Value
                    Dim assunto = detalhes.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "Subject")?.Value

                    Console.WriteLine("Remetente: " & remetente)
                    Console.WriteLine("Assunto: " & assunto)

                    Console.WriteLine("Deseja responder este email? (S/N)")
                    Dim respostaDoUsuario = Console.ReadLine()
                    If respostaDoUsuario.Trim().ToUpper() = "S" Then
                        Dim destinatario As String = remetente
                        Console.WriteLine("Escreva o novo Assunto: ")
                        Dim assuntos As String = Console.ReadLine()
                        Console.WriteLine("Escreva a tua resposta: ")
                        Dim conteudo As String = Console.ReadLine()

                        ResponderEmail(mensagem.Id, destinatario, assuntos, conteudo)
                        Console.WriteLine("E-mail respondido com sucesso")
                    End If
                Next
            Else
                Console.WriteLine("Nenhuma mensagem encontrada.")
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Reencaminhar um email 
    ''' </summary>
    ''' <param name="mensagemId">id Da mensagem da caixa de entrada</param>
    ''' <param name="destinatario">email de destino</param>
    ''' <param name="assunto">Assunto do email</param>
    ''' <param name="conteudo">conteudo do email</param>
    Private Sub ReencaminharEmail(mensagemId As String, destinatario As String, assunto As String, conteudo As String)
        Using servico = ObterServico().GetAwaiter().GetResult()
            Dim pedido = servico.Users.Messages.Get("me", mensagemId)
            Dim conversa As Message = pedido.Execute()

            'Lista de id de mensagens das conversas
            Dim listaDeMensagemId As New List(Of String)()

            ' Obtendo as mensagens anteriores da conversa
            Dim mensagensAnteriores As List(Of String) = ObterMensagensAnteriores(conversa)

            ' Obter todos os IDs de mensagens da conversa
            If conversa.Payload.Headers IsNot Nothing Then
                For Each header In conversa.Payload.Headers
                    If header.Name = "Message-ID" Then
                        listaDeMensagemId.Add(header.Value)
                    End If
                Next
            End If

            Dim responderMensagem As New StringBuilder()
            responderMensagem.Append("From: inovebox2023@gmail.com" & vbCrLf)
            responderMensagem.Append($"To: {destinatario}" & vbCrLf)
            responderMensagem.Append($"In-Reply-To: {mensagemId}" & vbCrLf)
            responderMensagem.Append($"Subject: Fwd: {assunto}" & vbCrLf)

            ' Definir o campo References com os IDs das mensagens anteriores
            Dim referencias As String = String.Join(" ", listaDeMensagemId)
            responderMensagem.Append($"References: {referencias}" & vbCrLf)

            responderMensagem.Append("MIME-Version: 1.0" & vbCrLf)
            responderMensagem.Append("Content-Type: text/plain; charset=UTF-8" & vbCrLf)
            responderMensagem.Append(vbCrLf)
            responderMensagem.Append(conteudo & vbCrLf)
            responderMensagem.AppendLine()
            responderMensagem.AppendLine("--------- Forwarded message ---------")
            ' Adicionando as mensagens anteriores da conversa
            For Each mensagemAnterior In mensagensAnteriores
                responderMensagem.AppendLine(mensagemAnterior)
            Next


            Dim mensagem As New Message()
            mensagem.ThreadId = conversa.ThreadId
            mensagem.Raw = ConverterBase(responderMensagem.ToString())
            servico.Users.Messages.Send(mensagem, "me").Execute()
        End Using
    End Sub

    ''' <summary>
    ''' Reencaminhar as mensagens
    ''' </summary>
    Private Sub ReencaminharMensagemEmail()
        Using servico = ObterServico().GetAwaiter().GetResult()
            Dim idDoUsuario As String = "me"
            Dim consulta As String = "label:inbox"

            Dim pedido = servico.Users.Messages.List(idDoUsuario)
            pedido.Q = consulta
            Dim resposta = pedido.Execute()

            ' Verifique se há mensagens na resposta
            If resposta.Messages IsNot Nothing AndAlso resposta.Messages.Count > 0 Then

                For Each mensagem In resposta.Messages
                    Dim detalhesDoPedido = servico.Users.Messages.Get("me", mensagem.Id)
                    Dim detalhes = detalhesDoPedido.Execute()

                    Dim remetente = detalhes.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "From")?.Value
                    Dim assunto = detalhes.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "Subject")?.Value

                    Console.WriteLine("Remetente: " & remetente)
                    Console.WriteLine("Assunto: " & assunto)

                    Console.WriteLine("Deseja reencaminhar este email? (S/N)")
                    Dim respostaDoUsuario = Console.ReadLine()
                    If respostaDoUsuario.Trim().ToUpper() = "S" Then
                        Dim destinatario As String = remetente
                        Dim assuntos As String = assunto
                        Console.WriteLine("Escreva alguma coisa: ")
                        Dim conteudo As String = Console.ReadLine()

                        ReencaminharEmail(mensagem.Id, destinatario, assuntos, conteudo)
                        Console.WriteLine("E-mail reencaminhado com sucesso")
                        Console.WriteLine("---------------------------------")
                    End If
                Next
            Else
                Console.WriteLine("Nenhuma mensagem encontrada.")
            End If
        End Using
    End Sub

    Private Function ObterMensagensAnteriores(conversa As Message) As List(Of String)
        Dim mensagensAnteriores As New List(Of String)()

        ' Adicionando todas as informações do e-mail anterior
        If conversa.Payload.Headers IsNot Nothing Then
            Dim origemAnterior As String = conversa.Payload.Headers.FirstOrDefault(Function(h) h.Name = "From")?.Value
            If Not String.IsNullOrEmpty(origemAnterior) Then
                mensagensAnteriores.Add($"From: {origemAnterior}")
            End If

            Dim dataAnterior As String = conversa.Payload.Headers.FirstOrDefault(Function(h) h.Name = "Date")?.Value
            If Not String.IsNullOrEmpty(dataAnterior) Then
                mensagensAnteriores.Add($"Date: {dataAnterior}")
            End If

            Dim assuntoAnterior As String = conversa.Payload.Headers.FirstOrDefault(Function(h) h.Name = "Subject")?.Value
            If Not String.IsNullOrEmpty(assuntoAnterior) Then
                mensagensAnteriores.Add($"Subject: {assuntoAnterior}")
            End If

            Dim destinatarioAnterior As String = conversa.Payload.Headers.FirstOrDefault(Function(h) h.Name = "To")?.Value
            If Not String.IsNullOrEmpty(destinatarioAnterior) Then
                mensagensAnteriores.Add($"To: {destinatarioAnterior}")
            End If
        End If

        Return mensagensAnteriores
    End Function


    Private Sub ListaDeMensagensEnviadas()
        Using servico = ObterServico().GetAwaiter().GetResult()
            Dim pedido = servico.Users.Messages.List("me")
            pedido.MaxResults = 10
            pedido.Q = "in:Sent"
            Dim resposta = pedido.Execute()
            If resposta.Messages IsNot Nothing AndAlso resposta.Messages.Count > 0 Then
                For Each mensagem In resposta.Messages
                    Dim email = servico.Users.Messages.Get("me", mensagem.Id).Execute()
                    Dim origem As String = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "From")?.Value
                    Dim destino As String = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "To")?.Value
                    Dim assunto As String = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "Subject")?.Value

                    Console.WriteLine("------------------------------------------------------")
                    Console.WriteLine("De: " & origem)
                    Console.WriteLine("Id Da Mensagem: " & mensagem.Id)
                    Console.WriteLine("Tread da Mensagem: " & mensagem.ThreadId)
                    Console.WriteLine("Para: " & destino)
                    Console.WriteLine("Assunto: " & assunto)
                    Console.WriteLine("------------------------------------------------------")
                Next
            End If
        End Using
    End Sub

    Private Sub ListaDeMensagensRecebidas()
        Using servico = ObterServico().GetAwaiter().GetResult()
            Dim pedido = servico.Users.Messages.List("me")
            pedido.MaxResults = 10
            pedido.Q = "in:all"
            Dim resposta = pedido.Execute()
            If resposta.Messages IsNot Nothing AndAlso resposta.Messages.Count > 0 Then
                For Each mensagem In resposta.Messages
                    Dim email = servico.Users.Messages.Get("me", mensagem.Id).Execute()
                    Dim origem As String = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "From")?.Value
                    Dim destino As String = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "To")?.Value
                    Dim assunto As String = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "Subject")?.Value

                    Console.WriteLine("------------------------------------------------------")
                    Console.WriteLine("De: " & origem)
                    Console.WriteLine("Id Da Mensagem: " & mensagem.Id)
                    Console.WriteLine("Tread da Mensagem: " & mensagem.ThreadId)
                    'Console.WriteLine("MensagemID: " & email.Payload.Headers.FirstOrDefault(Function(h) h.Name.ToUpper.Contains("MESSAGE-ID"))?.Value)
                    Console.WriteLine("Para: " & destino)
                    Console.WriteLine("Assunto: " & assunto)
                    Console.WriteLine("------------------------------------------------------")
                Next
            End If
        End Using
    End Sub

    Private Async Function ListaDeEmailsAsync() As Task
        Using servico = Await ObterServico()
            Dim pedido = servico.Users.Messages.List("me")
            pedido.MaxResults = 5
            pedido.Q = "in:inbox"
            Dim contarMensagens As New Dictionary(Of String, Integer)()
            Dim resposta = Await pedido.ExecuteAsync()

            If resposta.Messages IsNot Nothing AndAlso resposta.Messages.Count > 0 Then
                For Each mensagem In resposta.Messages
                    Dim email = Await servico.Users.Messages.Get("me", mensagem.Id).ExecuteAsync()
                    Dim origem As String = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "From")?.Value
                    Dim destino As String = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "To")?.Value
                    Dim assunto As String = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "Subject")?.Value
                    Dim conteudo As String = email.Snippet
                    Dim data As Date = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "Date")?.Value

                    Dim perfil As Profile = Await servico.Users.GetProfile("me").ExecuteAsync()
                    Dim totalEmails As Integer = perfil.MessagesTotal

                    If email.Payload.MimeType = "multipart/mixed" AndAlso email.Payload.Parts IsNot Nothing Then
                        For Each anexo In email.Payload.Parts
                            If anexo.Filename IsNot Nothing AndAlso anexo.Body.AttachmentId IsNot Nothing Then
                                Dim anexoResponse = Await servico.Users.Messages.Attachments.Get("me", mensagem.Id, anexo.Body.AttachmentId).ExecuteAsync()

                                Dim dados As String = anexoResponse.Data.Trim()
                                If Not String.IsNullOrWhiteSpace(dados) AndAlso dados.Length Mod 4 = 0 Then
                                    Dim dadosDoFicheiro As Byte() = ConverterDeBase64ParaUrlString(dados)
                                    Dim caminhoDoFicheiro As String = Path.Combine("C:\Users\PC-GTDF5Y1\source\repos\InoveBoxTeste\InoveBoxTeste\Anexos", anexo.Filename)

                                    Using ficheiro As New FileStream(caminhoDoFicheiro, FileMode.Create, FileAccess.Write)
                                        Await ficheiro.WriteAsync(dadosDoFicheiro, 0, dadosDoFicheiro.Length)
                                    End Using

                                    Console.WriteLine("Anexo salvo em: " & caminhoDoFicheiro)
                                Else
                                    Console.WriteLine("A cadeia de entrada não é valida")
                                End If
                            End If
                        Next
                    Else
                        Console.WriteLine("Nenhum anexo encontrado!")
                    End If

                    Console.WriteLine("------------------------------------------------------")
                    Console.WriteLine("De: " & origem)
                    Console.WriteLine("Para: " & destino)
                    Console.WriteLine("Assunto: " & assunto)
                    Console.WriteLine("Conteudo: " & conteudo)
                    Console.WriteLine("Data: " & data)
                    Console.WriteLine("Conteudo: " & totalEmails)
                    Console.WriteLine("------------------------------------------------------")
                Next
            End If
        End Using
        Console.ReadLine()
    End Function

    Function ConverterBase(valor As String) As String
        Dim inputBytes = System.Text.Encoding.UTF8.GetBytes(valor)
        Return Convert.ToBase64String(inputBytes).Replace("+", "-").Replace("/", "_").Replace("=", "")
    End Function


    Private Function ConverterDeBase64ParaUrlString(stringDeConversao As String) As Byte()
        Dim base64 = stringDeConversao.Replace("-", "+").Replace("_", "/")
        Dim tamanho = If(base64.Length Mod 4 = 0, 0, 4 - base64.Length Mod 4)
        base64 = base64 & New String("=", tamanho)
        Return Convert.FromBase64String(base64)
    End Function


End Module
