Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models
Imports Prolipol.Formacao.WF.DataTables
Imports System.IO

Public Class BookReportView

    Private _bookReport As IBookService
    Public Sub New(bookReport As IBookService)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _bookReport = bookReport
    End Sub

    Private Async Sub BookReportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadBooks()
    End Sub

    Private Async Function LoadBooks() As Task
        Try
            Await Task.Delay(1)
            BookReportToolStripStatusLabel.Text = "Loading Book´s Data..."
            Dim books = Await Task.Run(Function() _bookReport.GetBooks())
            Dim dataTable = New BookDataTable(books)
            BooksReportDatagridView.DataSource = dataTable.Build(Function(b) b.Id)
            BookReportToolStripStatusLabel.Text = $"Book(s) Found(s) : {books.Count()}"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="dataGridView"></param>
    ''' <param name="filePath"></param>
    Private Sub PrintReportAsTxt(dataGridView As DataGridView, filePath As String)
        Using writer As New StreamWriter(filePath)

            writer.Write("===== Available Books Report =====" & vbCrLf)
            For Each column As DataGridViewColumn In dataGridView.Columns
                writer.Write(column.HeaderText & vbTab)
            Next

            writer.WriteLine()

            For Each row As DataGridViewRow In dataGridView.Rows
                For Each cell As DataGridViewCell In row.Cells
                    writer.Write(cell.Value.ToString() & vbTab)
                Next
                writer.WriteLine()
            Next
        End Using
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PrintBookReportButton_Click(sender As Object, e As EventArgs) Handles PrintBookReportButton.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "TEXT FILES|*.txt"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            PrintReportAsTxt(BooksReportDatagridView, saveFileDialog.FileName)
            BookReportToolStripStatusLabel.Text = "Report saved sucessfully!"
        End If
    End Sub
End Class