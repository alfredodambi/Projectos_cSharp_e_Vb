Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models
Imports Prolipol.Formacao.WF.DataTables
Imports System.IO

Public Class LoanReportView

    Private ReadOnly _loanReport As ILoanService

    Public Sub New(loanReport As ILoanService)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _loanReport = loanReport

    End Sub
    Private Sub LoanReportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoansReport()
        OverduoLoansReport()
    End Sub


    ''' <summary>
    ''' Load loans to datagridView
    ''' </summary>
    Private Async Sub LoansReport()
        Try
            Await Task.Delay(1)
            ReportLoanToolStripStatusLabel.Text = "Loading Loan´s Data..."
            Dim loans = Await Task.Run(Function() _loanReport.GetLoans())
            Dim dataTable = New LoanDataTable(loans)
            LoanReportDataGridView.DataSource = dataTable.Build(Nothing)
            ReportLoanToolStripStatusLabel.Text = "Finished"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    ''' <summary>
    ''' Load loans Overduo to datagridView
    ''' </summary>
    Private Async Sub OverduoLoansReport()
        Dim overduoLoans = Await Task.Run(Function() _loanReport.GetLoans().Where(Function(l) l.ExpiryDate <= Date.UtcNow()).ToList())
        Dim dataTable = New LoanDataTable(overduoLoans)
        OverduoLoanReportDataGridView.DataSource = dataTable.Build(Nothing)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PrintLoanReportButton_Click(sender As Object, e As EventArgs) Handles PrintLoanReportButton.Click
        Dim saveFromDialog As New SaveFileDialog()
        saveFromDialog.Filter = "TEXT FILE|*.txt"

        If saveFromDialog.ShowDialog() = DialogResult.OK Then
            PrintReportLoanTxt(LoanReportDataGridView, saveFromDialog.FileName)
            ReportLoanToolStripStatusLabel.Text = "Report Saved Sucessfully!"
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PrintOverduoLoanButton_Click(sender As Object, e As EventArgs) Handles PrintOverduoLoanButton.Click
        Dim saveFromDialog As New SaveFileDialog()
        saveFromDialog.Filter = "TEXT FILE|*.txt"

        If saveFromDialog.ShowDialog() = DialogResult.OK Then
            PrintReportOverduoLoanTxt(OverduoLoanReportDataGridView, saveFromDialog.FileName)
            ReportLoanToolStripStatusLabel.Text = "Report Saved Sucessfully!"
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="dataGridView"></param>
    ''' <param name="filePath"></param>
    Private Sub PrintReportLoanTxt(dataGridView As DataGridView, filePath As String)
        Using writeText As New StreamWriter(filePath)

            writeText.Write("===== All Loans Report =====" & vbCrLf)
            writeText.WriteLine()

            For Each column As DataGridViewColumn In dataGridView.Columns
                writeText.Write(column.HeaderText & vbTab)
            Next
            writeText.WriteLine()

            For Each row As DataGridViewRow In dataGridView.Rows
                For Each cell As DataGridViewCell In row.Cells

                    If cell.Value IsNot Nothing Then
                        writeText.Write(cell.Value.ToString & vbTab)
                    Else
                        writeText.Write(vbTab)
                    End If

                Next
                writeText.WriteLine()
            Next

            writeText.WriteLine()
        End Using
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="dataGridView"></param>
    ''' <param name="filePath"></param>
    Private Sub PrintReportOverduoLoanTxt(dataGridView As DataGridView, filePath As String)
        Using writeText As New StreamWriter(filePath)

            writeText.Write("===== Overdue Loans Report =====" & vbCrLf)
            writeText.WriteLine()

            For Each column As DataGridViewColumn In dataGridView.Columns
                writeText.Write(column.HeaderText & vbTab)
            Next
            writeText.WriteLine()

            For Each row As DataGridViewRow In dataGridView.Rows
                For Each cell As DataGridViewCell In row.Cells

                    If cell.Value IsNot Nothing Then
                        writeText.Write(cell.Value.ToString & vbTab)
                    Else
                        writeText.Write(vbTab)
                    End If

                Next
                writeText.WriteLine()
            Next

            writeText.WriteLine()
        End Using
    End Sub
End Class