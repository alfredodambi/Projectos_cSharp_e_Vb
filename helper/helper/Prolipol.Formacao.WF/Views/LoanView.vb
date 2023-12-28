Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models
Imports Prolipol.Formacao.WF.DataTables

Public Class LoanView

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property LoanId As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property BookName As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property BorrowerName As String

    Public SelectedLoanId As Integer

    Private _loanService As ILoanService

    Private ReadOnly _getLoanCount As Action

    Public Sub New(loanService As ILoanService, getLoanCount As Action)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _loanService = loanService
        _getLoanCount = getLoanCount

    End Sub

    Private Sub LoanView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLoans()
    End Sub

    ''' <summary>
    ''' load list of loan
    ''' </summary>
    Private Async Sub LoadLoans()
        Try
            Await Task.Delay(1)

            LoanStatusToolStripStatusLabel.Text = "Loading Loans..."

            Dim loans = Await Task.Run(Function() _loanService.GetLoans())
            Dim dataTable = New LoanDataTable(loans)

            loansDataGridView.DataSource = dataTable.Build(Function(l) l.Id)

            LoanStatusToolStripStatusLabel.Text = $"Loan(s) Found(s) {loans.Count()}"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Search filters parameters from a loan
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchLoanButton.Click
        Integer.TryParse(SearchIdLoanTextBox.Text, LoanId)
        BookName = SearchBookTitleTextBox.Text
        BorrowerName = SearchBorrowerNameTextBox.Text

        Dim loans = Await Task.Run(Function() _loanService.GetLoans())

        If LoanId > 0 Then
            loans = loans.Where(Function(l) l.Id.ToString().Contains(LoanId))
        End If

        If BookName.Length > 0 Then
            loans = loans.Where(Function(l) l.Book.Title.ToString().Contains(BookName))
        End If

        If BorrowerName.Length > 0 Then
            loans = loans.Where(Function(l) l.Borrower.Name.ToString().Contains(BorrowerName))
        End If

        Dim dataTable = New LoanDataTable(loans)

        loansDataGridView.DataSource = dataTable.Build(Function(l) l.Id)
        LoanStatusToolStripStatusLabel.Text = $"Loan(s) Found(s) {loans.Count()}"
    End Sub

    ''' <summary>
    ''' See details from a loan
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub ViewDetailsButton_Click(sender As Object, e As EventArgs) Handles ViewDetailsLoanButton.Click
        Try
            If loansDataGridView.SelectedRows.Count > 0 Then
                Dim selectedLoan As Integer = CInt(loansDataGridView.SelectedRows(0).Cells("ID").Value)
                Dim loans = Await Task.Run(Function() _loanService.GetLoans())

                Dim loan As Loan = loans.FirstOrDefault(Function(l) l.Id = selectedLoan)

                If loan IsNot Nothing Then
                    Dim loanDetail As LoanDetailsView = New LoanDetailsView(_loanService, loan)
                    loanDetail.ShowDialog()
                    LoadLoans()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Delete a lona
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteLoanButton_Click(sender As Object, e As EventArgs) Handles DeleteLoanButton.Click
        Try
            If loansDataGridView.SelectedRows.Count > 0 Then

                Dim selectedLoan As Integer = CInt(loansDataGridView.SelectedRows(0).Cells("ID").Value)
                Dim loans = _loanService.GetLoans()
                Dim loan = loans.FirstOrDefault(Function(l) l.Id = selectedLoan)

                If loan IsNot Nothing Then
                    If loan.ReturnedOn.HasValue Then
                        MessageBox.Show("This loan has been returned On, you can´t edit")
                    Else
                        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this Loan?",
                                                            "Confirm Delete",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question)

                        If confirmResult = DialogResult.Yes Then
                            'Dim books = _book
                            loan.Book.IsAvailable = True
                            _loanService.DeleteLoan(loan)
                            'LoanStatusToolStripStatusLabel.Text = "Loan Delete SucessFully"
                            MessageBox.Show("Loan Delete SucessFully")
                            _getLoanCount.Invoke()

                            LoadLoans()
                        End If
                    End If
                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Edit loan data
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub EditLoanButton_Click(sender As Object, e As EventArgs) Handles EditLoanButton.Click
        Try
            If loansDataGridView.SelectedRows.Count > 0 Then
                Dim selectedLoan As Integer = CInt(loansDataGridView.SelectedRows(0).Cells("ID").Value)
                Dim loans = Await Task.Run(Function() _loanService.GetLoans())

                Dim loan As Loan = loans.FirstOrDefault(Function(l) l.Id = selectedLoan)

                If loan IsNot Nothing Then
                    If loan.ReturnedOn.HasValue Then
                        MessageBox.Show("This loan has been returned On, you can´t edit")
                    Else
                        Dim loanUpdateView As UpdateLoanView = New UpdateLoanView(_loanService, loan)
                        loanUpdateView.ShowDialog()
                        LoadLoans()
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Close the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseLoanButton.Click
        Close()
    End Sub
End Class