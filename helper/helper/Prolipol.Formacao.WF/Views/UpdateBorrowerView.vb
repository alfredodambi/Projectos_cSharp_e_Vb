Imports Prolipol.Formacao.Domain.Exceptions
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Public Class UpdateBorrowerView


    Private ReadOnly _borrowerService As IBorrowerService
    Private _borrower As Borrower

    Public Property id As Integer
    Public Property FullName As String

    Public Sub New(borrowerService As IBorrowerService, borrower As Borrower)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        _borrowerService = borrowerService
        _borrower = borrower

        BorrowerIdTextBox.Text = _borrower.Id
        BorrowerFullNameTextBox.Text = _borrower.Name
        BorrowerToolStripStatusLabel.Text = "Finished"
    End Sub

    Private Sub UpdateBorrowerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub UpdateBorrowerButton_Click(sender As Object, e As EventArgs) Handles UpdateBorrowerButton.Click
        If BorrowerFullNameValidating(True) Then

            Try
                FullName = BorrowerFullNameTextBox.Text

                If _borrowerService.BorrowerNameExists(FullName) Then
                    Throw New BorrowerAlreadyExistsException("Borrower with the same name already exists")
                End If

                _borrower.Id = BorrowerIdTextBox.Text
                _borrower.Name = FullName
                _borrowerService.UpdateBorrower(_borrower)
                BorrowerToolStripStatusLabel.Text = "Borrower Updated SuccessFully"

            Catch alreadyExistsException As BorrowerAlreadyExistsException
                MessageBox.Show("Borrower with same name already exists")
            Catch ex As Exception
                MessageBox.Show("Something went wrong")
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Close the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CancelBorrowerButton_Click(sender As Object, e As EventArgs) Handles CancelBorrowerButton.Click
        Close()
    End Sub

    ''' <summary>
    ''' Validating the borrower full name
    ''' </summary>
    ''' <param name="forceMessage"></param>
    ''' <returns></returns>
    Private Function BorrowerFullNameValidating(forceMessage As Boolean) As Boolean
        If String.IsNullOrWhiteSpace(BorrowerFullNameTextBox.Text) Then

            Const NAME_REQUIRED_ERROR_MSG As String = "Borrower's Full Name is required."

            BorrowerUpdateErrorProvider.SetError(BorrowerFullNameTextBox, NAME_REQUIRED_ERROR_MSG)

            If forceMessage Then
                If ToolTip1.Active Then
                    ToolTip1.SetToolTip(BorrowerFullNameTextBox, NAME_REQUIRED_ERROR_MSG)
                Else
                    MessageBox.Show(NAME_REQUIRED_ERROR_MSG, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

            Return False
        End If
        BorrowerUpdateErrorProvider.SetError(BorrowerFullNameTextBox, String.Empty)
        Return True
    End Function
End Class