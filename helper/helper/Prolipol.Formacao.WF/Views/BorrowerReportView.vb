Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models
Imports Prolipol.Formacao.WF.DataTables
Imports System.IO

Public Class BorrowerReportView
    Private ReadOnly _borrowerReport As IBorrowerService

    Public Sub New(borrowerReport As IBorrowerService)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _borrowerReport = borrowerReport
    End Sub

    Private Sub BorrowerReportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBorrowers()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Private Async Sub loadBorrowers()
        Try
            Await Task.Delay(1)
            BorrowerReportToolStripStatusLabel.Text = "Loading Borrower´s data"
            Dim borrowers = Await Task.Run(Function() _borrowerReport.GetBorrowers())
            Dim dataTable = New BorrowerDataTable(borrowers)
            BorrowersReportDataGridView.DataSource = dataTable.Build(Function(b) b.Name.Contains("j"))
            BorrowerReportToolStripStatusLabel.Text = $"Borrower(s) Found(s): {borrowers.Count()} "
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Write data on a text File
    ''' </summary>
    ''' <param name="datagridView"></param>
    ''' <param name="filePath"></param>
    Private Sub PrintReportAsTxt(datagridView As DataGridView, filePath As String)
        Using writeText As New StreamWriter(filePath)

            writeText.Write("===== All Borrowers Report =====" & vbCrLf)
            writeText.WriteLine()
            For Each column As DataGridViewColumn In datagridView.Columns
                writeText.Write(column.HeaderText & vbTab)
            Next

            writeText.WriteLine()

            For Each row As DataGridViewRow In datagridView.Rows
                For Each cell As DataGridViewCell In row.Cells
                    writeText.Write(cell.Value.ToString & vbTab)
                Next
                writeText.WriteLine()
            Next
        End Using
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PrintBorrowerReportButton_Click(sender As Object, e As EventArgs) Handles PrintBorrowerReportButton.Click
        Dim saveFromDialog As New SaveFileDialog()
        saveFromDialog.Filter = "TEXT FILE|*.txt"

        If saveFromDialog.ShowDialog() = DialogResult.OK Then
            PrintReportAsTxt(BorrowersReportDataGridView, saveFromDialog.FileName)
            BorrowerReportToolStripStatusLabel.Text = "Report Saved Sucessfully!"
        End If
    End Sub
End Class