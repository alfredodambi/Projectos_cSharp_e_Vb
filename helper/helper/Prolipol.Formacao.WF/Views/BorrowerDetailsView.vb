Imports System.Threading
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models
Imports Prolipol.Formacao.WF.DataTables

Namespace Views
    Public Class BorrowerDetailsView

        Private ReadOnly _borrowerService As IBorrowerService
        Private ReadOnly _borrowerId As Integer
        Private CancellationToken As CancellationToken
        Private CancellationTokenSource As CancellationTokenSource


        Public Sub New(borrowerService As IBorrowerService, borrowerId As Integer)
            ' This call is required by the designer.
            InitializeComponent()

            _borrowerService = borrowerService
            _borrowerId = borrowerId

            ' Add any initialization after the InitializeComponent() call.
            CancellationTokenSource = New CancellationTokenSource()
            CancellationToken = CancellationTokenSource.Token
            ReturnBookButton.Enabled = False
        End Sub

        Private Sub BorrowerDetailsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadLoans()
        End Sub



        ''' <summary>
        ''' Show the data on datagrid
        ''' </summary>
        Public Async Sub LoadLoans()
            BorrowerDetailsToolStripStatusLabel.Text = "Loading borrower's data..."

            Dim foundBorrower = Await Task.Run(Function() _borrowerService.GetBorrower(_borrowerId), CancellationToken)

            Dim loansDataTable = New LoanDataTable(foundBorrower.Loans)

            BorrowerDetailsToolStripStatusLabel.Text = "Finished!"

            BorrowerInLoansDataGridView.DataSource = loansDataTable.Build(Nothing)

            BorrowerIDTextBox.Text = foundBorrower.Id
            BorrowerFullNameTextBox.Text = foundBorrower.Name
        End Sub


        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
            Close()
        End Sub


    End Class
End Namespace