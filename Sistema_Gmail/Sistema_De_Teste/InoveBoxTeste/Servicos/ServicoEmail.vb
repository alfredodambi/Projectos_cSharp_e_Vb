Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Gmail.v1
Imports Google.Apis.Gmail.v1.Data
Imports Google.Apis.Services
Imports InoveBoxTeste.Interfaces
Imports InoveBoxTeste.Modelos
Imports System.IO
Imports System.Net.Mail
Imports System.Text
Imports System.Threading
Imports System.Web

Namespace Servicos
    Public Class ServicoEmail
        Implements IEmail

        Private _servico As GmailService
        Public Sub New()
            Dim credencial As UserCredential = ObterCredencial().GetAwaiter.GetResult()
            Dim initializer As New BaseClientService.Initializer()
            initializer.HttpClientInitializer = credencial
            initializer.ApplicationName = "InoveBox"
            _servico = New GmailService(initializer)
        End Sub

        Public Function ObterCredencial()
            Dim escopo As String() = {GmailService.Scope.GmailModify}
            Dim idDoCliente As String = "280570157718-u7iltcf286v1q252b6gkmop0f9t7io2m.apps.googleusercontent.com"
            Dim senhaDoCliente As String = "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"

            Return GoogleWebAuthorizationBroker.AuthorizeAsync(
                                New ClientSecrets With {.ClientId = idDoCliente, .ClientSecret = senhaDoCliente},
                                escopo,
                                "user",
                                CancellationToken.None
                            )
        End Function

        Public Async Function MostrarListaDeEmails() As Task Implements IEmail.MostrarListaDeEmails

            Dim pedido = _servico.Users.Messages.List("me")
            pedido.MaxResults = 10
            pedido.Q = "in:inbox"
            Dim resposta = Await pedido.ExecuteAsync()
            If resposta.Messages IsNot Nothing AndAlso resposta.Messages.Count > 0 Then
                For Each mensagem In resposta.Messages
                    Dim email = Await _servico.Users.Messages.Get("me", mensagem.Id).ExecuteAsync()
                    Dim origem As String = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "From")?.Value
                    Dim destino As String = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "To")?.Value
                    Dim assunto As String = email.Payload.Headers.FirstOrDefault(Function(emails) emails.Name = "Subject")?.Value

                    'Lista para os nomes e extensao do anexo
                    Dim listaDeAnexo As New List(Of String)()
                    'Mostrar o total de anexos
                    Dim totalDeAnexos As Integer = 0
                    If email.Payload.MimeType = "multipart/mixed" AndAlso email.Payload.Parts IsNot Nothing Then
                        For Each part In email.Payload.Parts
                            If part.Body IsNot Nothing AndAlso part.Body.AttachmentId IsNot Nothing Then
                                totalDeAnexos += 1
                            End If

                            'Obter Nome e extensao de um anexo
                            If part.Filename IsNot Nothing AndAlso part.Body IsNot Nothing AndAlso part.Body.AttachmentId IsNot Nothing Then
                                Dim nome As String = part.Filename
                                Dim extensao As String = Path.GetExtension(nome)
                                Dim anexos As String = "Nome: " & nome & "| Extensao: " & extensao
                                listaDeAnexo.Add(anexos)
                            End If

                            'Salvar Anexo numa do email numa pasta
                            If part.Filename IsNot Nothing AndAlso part.Body IsNot Nothing AndAlso part.Body.AttachmentId IsNot Nothing Then

                                Dim anexoResponse = Await _servico.Users.Messages.Attachments.Get("me", mensagem.Id, part.Body.AttachmentId).ExecuteAsync()
                                Dim dados As String = anexoResponse.Data.Trim()
                                If Not String.IsNullOrWhiteSpace(dados) AndAlso dados.Length Mod 4 = 0 Then
                                    Dim dadosDoFicheiro As Byte() = ConverterDeBase64ParaUrlString(dados)
                                    Dim caminhoDoFicheiro As String = Path.Combine("C:\Users\PC-GTDF5Y1\source\repos\InoveBoxTeste\InoveBoxTeste\Anexos", part.Filename)

                                    Using ficheiro As New FileStream(caminhoDoFicheiro, FileMode.Create, FileAccess.Write)
                                        Await ficheiro.WriteAsync(dadosDoFicheiro, 0, dadosDoFicheiro.Length)
                                    End Using

                                    Console.WriteLine("Anexo salvo em: " & caminhoDoFicheiro)
                                Else
                                    Console.WriteLine("A cadeia de entrada não é valida")
                                End If


                            End If
                        Next
                    End If
                    Console.WriteLine("------------------------------------------------------")
                    Console.WriteLine("De: " & origem)
                    Console.WriteLine("Para: " & destino)
                    Console.WriteLine("Assunto: " & assunto)
                    Console.WriteLine("Total de Anexos: " & totalDeAnexos)
                    For Each anexo In listaDeAnexo
                        Console.WriteLine(anexo)
                        Console.WriteLine("------------------------------------------------------")
                    Next
                    Console.WriteLine("------------------------------------------------------")

                Next
            End If
        End Function

        Public Async Function EnviarEmail(emailOrigem As String, destinatarios As IEnumerable(Of String), assunto As String, corpo As String, anexos As IEnumerable(Of Anexo)) As Task Implements IEmail.EnviarEmail
            If String.IsNullOrEmpty(emailOrigem) Then
                Console.WriteLine("Email de origem inválido.")
                Return
            End If

            If destinatarios Is Nothing OrElse Not destinatarios.Any() Then
                Console.WriteLine("Destinatários inválidos.")
                Return
            End If

            If String.IsNullOrEmpty(assunto) Then
                Console.WriteLine("Assunto inválido.")
                Return
            End If

            If String.IsNullOrEmpty(corpo) Then
                Console.WriteLine("Corpo inválido.")
                Return
            End If

            Dim mensagem As New Message()
            mensagem.Raw = CriarEmail(emailOrigem, destinatarios, assunto, corpo, anexos)
            Await _servico.Users.Messages.Send(mensagem, "me").ExecuteAsync()
            'Dim enviarMensagem As Message = Await pedidos.ExecuteAsync()
        End Function

        Private Function CriarEmail(emailOrigem As String, destinatarios As IEnumerable(Of String), assunto As String, corpo As String, anexos As IEnumerable(Of Anexo)) As String
            Try
                Dim criarMensagem As New System.Text.StringBuilder()

                criarMensagem.AppendLine("From: " & emailOrigem)
                criarMensagem.AppendLine("To: " & String.Join(",", destinatarios))
                criarMensagem.AppendLine("Subject: " & assunto)
                criarMensagem.AppendLine("Content-Type: text/html; charset=utf-8")
                criarMensagem.AppendLine()
                criarMensagem.AppendLine(corpo)
                criarMensagem.AppendLine()


                If anexos IsNot Nothing AndAlso anexos.Any() Then
                    For Each anexo As Anexo In anexos
                        criarMensagem.AppendLine("--next-part")
                        criarMensagem.AppendLine("Content-Type: " & anexo.ContentType)
                        criarMensagem.AppendLine("Content-Disposition: attachment; filename=""" & anexo.NomeArquivo & """")
                        criarMensagem.AppendLine("Content-Transfer-Encoding: base64")
                        criarMensagem.AppendLine()

                        Dim dados As Byte() = File.ReadAllBytes(anexo.CaminhoArquivo)

                        criarMensagem.AppendLine(Convert.ToBase64String(dados))
                    Next
                End If

                criarMensagem.AppendLine("--next-part--")

                Return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(criarMensagem.ToString()))
            Catch ex As Exception
                Console.WriteLine("Ocorreu um erro ao salvar o e-mail como texto: " & ex.Message)
                Return String.Empty
            End Try
        End Function

        Private Function ConverterDeBase64ParaUrlString(stringDeConversao As String) As Byte()
            Dim base64 = stringDeConversao.Replace("-", "+").Replace("_", "/")
            Dim tamanho = If(base64.Length Mod 4 = 0, 0, 4 - base64.Length Mod 4)
            base64 = base64 & New String("=", tamanho)
            Return Convert.FromBase64String(base64)
        End Function

        Private Function Base64UrlEncode(ByVal input As String) As String
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim base64String As String = Convert.ToBase64String(inputBytes)
            Return HttpUtility.UrlEncode(base64String)
        End Function
    End Class


End Namespace