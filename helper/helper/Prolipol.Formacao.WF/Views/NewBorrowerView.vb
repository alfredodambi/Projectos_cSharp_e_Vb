Imports System.ComponentModel
Imports Prolipol.Formacao.Domain.Exceptions
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Namespace Views
    Public Class NewBorrowerView

        ''' <summary>
        ''' 
        ''' </summary>
        Private _fullName As String

        Private ReadOnly _borrowerService As IBorrowerService
        Private ReadOnly _GetBorrowerCount As Action

        Public Property HasChanged As Boolean

        Public Property FullName As String
            Get
                Return _fullName
            End Get
            Private Set
                _fullName = Value
                If Value.Length > 0 Then
                    HasChanged = True
                End If
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="borrowerService"></param>
        ''' <param name="GetBorrowerCount"></param>
        Public Sub New(borrowerService As IBorrowerService, GetBorrowerCount As Action)
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            CreateBorrowerButton.Enabled = False

            _borrowerService = borrowerService
            _GetBorrowerCount = GetBorrowerCount
        End Sub


        ''' <summary>
        ''' Validating textbox full Name
        ''' </summary>
        ''' <param name="forceMessage"></param>
        ''' <returns></returns>
        Private Function BorrwewrFullNameValidating(forceMessage As Boolean) As Boolean
            If String.IsNullOrWhiteSpace(FullName) Then

                Const NAME_REQUIRED_ERROR_MSG As String = "Borrower's Full Name is required."

                NewBorrowerErrorProvider.SetError(FullNameTextBox, NAME_REQUIRED_ERROR_MSG)

                If forceMessage Then
                    If NewBorrowerToolTip.Active Then
                        NewBorrowerToolTip.SetToolTip(FullNameTextBox, NAME_REQUIRED_ERROR_MSG)
                    Else
                        MessageBox.Show(NAME_REQUIRED_ERROR_MSG, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

                Return False
            End If
            NewBorrowerErrorProvider.SetError(FullNameTextBox, String.Empty)
            Return True
        End Function

        Private Sub FullNameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles FullNameTextBox.Validating
            BorrwewrFullNameValidating(True)
        End Sub

        ''' <summary>
        ''' Add the value from textbox to property fullname
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub FullNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FullNameTextBox.TextChanged
            FullName = FullNameTextBox.Text
            CreateBorrowerButton.Enabled = BorrwewrFullNameValidating(True)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelBorrowerButton.Click
            Dim cancellationResult As DialogResult

            Const PROMPT_MSG = "You didn't finish what you were doing, are you sure?"
            Const PROMT_CAPTION = "Unsaved data"

            If HasChanged Then
                cancellationResult = MessageBox.Show(PROMPT_MSG, PROMT_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            End If

            If cancellationResult = DialogResult.No Then
                Return
            End If

            Close()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CreateBorrowerButton_Click(sender As Object, e As EventArgs) Handles CreateBorrowerButton.Click
            If BorrwewrFullNameValidating(True) Then
                Try
                    _borrowerService.RegisterBorrower(New Borrower(FullName))
                    BorrowerDetailsToolStripStatusLabel.Text = "Borrower Added"
                    _GetBorrowerCount.Invoke()
                    ResetForm()
                Catch alreadyExistsException As BorrowerAlreadyExistsException
                    Const NAME_EXISTS_ERROR_MSG As String = "Borrower with the same name already exists"
                    NewBorrowerErrorProvider.SetError(FullNameTextBox, NAME_EXISTS_ERROR_MSG)
                    NewBorrowerToolTip.SetToolTip(FullNameTextBox, NAME_EXISTS_ERROR_MSG)
                Catch ex As Exception
                    MessageBox.Show("Something went wrong")
                End Try
            End If
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Private Sub ResetForm()
            FullNameTextBox.Clear()
            HasChanged = False
        End Sub

        ''' <summary>
        ''' Clean textBox
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CleanToolStripButton_Click(sender As Object, e As EventArgs)
            FullNameTextBox.Text = ""
        End Sub


    End Class
End Namespace