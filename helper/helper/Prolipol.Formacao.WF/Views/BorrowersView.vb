Imports System.Threading
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models
Imports Prolipol.Formacao.Domain.Services
Imports Prolipol.Formacao.WF.DataTables

Namespace Views
    Public Class BorrowersView

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Property BorrowerId As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Property BorrowerFullName As String

        Private ReadOnly _borrowerService As IBorrowerService
        Private _loanService As ILoanService
        Private ReadOnly _GetBorrowerCount As Action

        Private _selectedBorrowerId As Integer
        Public Property SelectedBorrowerId As Integer
            Get
                Return _selectedBorrowerId
            End Get
            Set(value As Integer)
                _selectedBorrowerId = value
            End Set
        End Property

        Public Sub New(borrowerService As IBorrowerService, loanService As ILoanService, GetBorrowerCount As Action)
            ' This call is required by the designer.
            InitializeComponent()

            _borrowerService = borrowerService
            _loanService = loanService
            _GetBorrowerCount = GetBorrowerCount
            ' Add any initialization after the InitializeComponent() call.
            AddHandler BorrowersDataGridView.SelectionChanged, AddressOf OnSelectedBorrowerChanged
        End Sub

        Private Async Sub BorrowersView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Await LoadBorrowers()
        End Sub

        ''' <summary>
        ''' Load the list of Borrower
        ''' </summary>
        ''' <returns></returns>
        Private Async Function LoadBorrowers() As Task
            Try
                Await Task.Delay(1)

                BorrowersToolStripStatusLabel.Text = "Loading borrowers..."

                Dim loadedBorrowers = Await Task.Run(Function() _borrowerService.GetBorrowers())

                Dim dataTable = New BorrowerDataTable(loadedBorrowers)

                BorrowersToolStripStatusLabel.Text = $"Found ({loadedBorrowers.Count()}) borrowers"
                BorrowersDataGridView.DataSource = dataTable.Build(Function(b) b.Name.Contains("j"))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Function

        Private Sub OnSelectedBorrowerChanged(sender As Object, e As EventArgs)
            Dim selectedRows = CType(sender, DataGridView).SelectedRows

            If selectedRows.Count > 0 Then
                SelectedBorrowerId = selectedRows(0).Cells("ID").Value
            End If

            DetailsBorrowerButton.Enabled = SelectedBorrowerId > 0
            EditBorrowerButton.Enabled = SelectedBorrowerId > 0
            DeleteBorrowerButton.Enabled = SelectedBorrowerId > 0
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Async Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchBorrowerButton.Click

            Integer.TryParse(BorrowerIDTextBox.Text, BorrowerId)
            BorrowerFullName = BorrowerFullNameTextBox.Text

            ' process everything here
            Dim borrowers = Await Task.Run(Function() _borrowerService.GetBorrowers())
            If BorrowerId > 0 Then
                borrowers = borrowers.Where(Function(b) b.Id.ToString().Contains(BorrowerId))
            End If

            If BorrowerFullName.Length > 0 Then
                borrowers = borrowers.Where(Function(b) b.Name.ToLower().Contains(BorrowerFullName.ToLower()))
            End If

            Dim dataTable = New BorrowerDataTable(borrowers)
            BorrowersDataGridView.DataSource = dataTable.Build(Function(b) b.Name.Contains("j"))
            BorrowersToolStripStatusLabel.Text = $"Borrower Found(s) {borrowers.Count}"

        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsBorrowerButton.Click
            Try
                Dim borrowerDetailsView = New BorrowerDetailsView(_borrowerService, SelectedBorrowerId)

                borrowerDetailsView.Show(Me)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BorrowerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles BorrowerIDTextBox.TextChanged
            Integer.TryParse(CType(sender, TextBox).Text, BorrowerId)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BorrowerFullNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles BorrowerFullNameTextBox.TextChanged
            BorrowerFullName = CType(sender, TextBox).Text
        End Sub

        ''' <summary>
        ''' Close the form
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseBorrowerButton.Click
            Close()
        End Sub

        ''' <summary>
        ''' Clean the seach textbox
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub NewSearchButton_Click(sender As Object, e As EventArgs) Handles NewSearchBorrowerButton.Click
            BorrowerIDTextBox.Text = ""
            BorrowerFullNameTextBox.Text = ""
        End Sub

        ''' <summary>
        ''' Edit value from a selectedBorrower
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Async Sub EditBorrowerButton_Click(sender As Object, e As EventArgs) Handles EditBorrowerButton.Click
            OnSelectedBorrowerChanged(BorrowersDataGridView, EventArgs.Empty)
            Try
                If SelectedBorrowerId > 0 Then
                    Dim borrowerId As Integer = CInt(BorrowersDataGridView.SelectedRows(0).Cells("ID").Value)
                    Dim borrowers = Await Task.Run(Function() _borrowerService.GetBorrowers())
                    Dim borrower = borrowers.FirstOrDefault(Function(b) b.Id = borrowerId)
                    If borrower IsNot Nothing Then
                        Dim borrowerUpdateView As UpdateBorrowerView = New UpdateBorrowerView(_borrowerService, borrower)
                        borrowerUpdateView.ShowDialog()
                        Await LoadBorrowers()
                    End If
                Else
                    MessageBox.Show("Book not Found.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        ''' <summary>
        ''' Delete a borrower
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Async Sub DeleteBorrowerButton_Click(sender As Object, e As EventArgs) Handles DeleteBorrowerButton.Click
            OnSelectedBorrowerChanged(BorrowersDataGridView, EventArgs.Empty)
            Try
                If SelectedBorrowerId > 0 Then

                    Dim selectedBorrowerId As Integer = CInt(BorrowersDataGridView.SelectedRows(0).Cells("ID").Value)
                    Dim borrowers = _borrowerService.GetBorrowers()
                    Dim borrower = borrowers.FirstOrDefault(Function(b) b.Id = selectedBorrowerId)
                    Dim borrowerWithLoan = Await Task.Run(Function() _loanService.GetLoans().Where(Function(l) l.Borrower.Id = borrower.Id).ToList())

                    If borrowerWithLoan.Count = 0 Then
                        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this borrower?",
                                                            "Confirm Delete",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question)
                        If confirmResult = DialogResult.Yes Then
                            _borrowerService.DeleteBorrower(borrower)
                            BorrowersToolStripStatusLabel.Text = $"Borrower Deleted Successfully"
                            _GetBorrowerCount.Invoke()
                            Await LoadBorrowers()
                        End If
                    Else
                        MessageBox.Show("You can´t delete, because is associated with a loan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Please select a borrower to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace