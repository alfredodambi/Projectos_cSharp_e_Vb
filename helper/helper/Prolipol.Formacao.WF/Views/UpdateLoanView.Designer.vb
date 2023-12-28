<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateLoanView
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExpiryLoanDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartLoanDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BookNameTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerNameTextBox = New System.Windows.Forms.TextBox()
        Me.IdLoanTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LoanToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UpdateLoanButton = New System.Windows.Forms.Button()
        Me.CancelLoanButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ExpiryLoanDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.StartLoanDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.BookNameTextBox)
        Me.GroupBox1.Controls.Add(Me.BorrowerNameTextBox)
        Me.GroupBox1.Controls.Add(Me.IdLoanTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 207)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loan Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Expiry Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Start Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Borrower Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Book Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Id"
        '
        'ExpiryLoanDateTimePicker
        '
        Me.ExpiryLoanDateTimePicker.Location = New System.Drawing.Point(113, 164)
        Me.ExpiryLoanDateTimePicker.Name = "ExpiryLoanDateTimePicker"
        Me.ExpiryLoanDateTimePicker.Size = New System.Drawing.Size(389, 20)
        Me.ExpiryLoanDateTimePicker.TabIndex = 14
        '
        'StartLoanDateTimePicker
        '
        Me.StartLoanDateTimePicker.Location = New System.Drawing.Point(113, 127)
        Me.StartLoanDateTimePicker.Name = "StartLoanDateTimePicker"
        Me.StartLoanDateTimePicker.Size = New System.Drawing.Size(389, 20)
        Me.StartLoanDateTimePicker.TabIndex = 13
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.Enabled = False
        Me.BookNameTextBox.Location = New System.Drawing.Point(113, 61)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.ReadOnly = True
        Me.BookNameTextBox.Size = New System.Drawing.Size(389, 20)
        Me.BookNameTextBox.TabIndex = 12
        '
        'BorrowerNameTextBox
        '
        Me.BorrowerNameTextBox.Enabled = False
        Me.BorrowerNameTextBox.Location = New System.Drawing.Point(113, 94)
        Me.BorrowerNameTextBox.Name = "BorrowerNameTextBox"
        Me.BorrowerNameTextBox.ReadOnly = True
        Me.BorrowerNameTextBox.Size = New System.Drawing.Size(389, 20)
        Me.BorrowerNameTextBox.TabIndex = 11
        '
        'IdLoanTextBox
        '
        Me.IdLoanTextBox.Enabled = False
        Me.IdLoanTextBox.Location = New System.Drawing.Point(113, 23)
        Me.IdLoanTextBox.Name = "IdLoanTextBox"
        Me.IdLoanTextBox.ReadOnly = True
        Me.IdLoanTextBox.Size = New System.Drawing.Size(389, 20)
        Me.IdLoanTextBox.TabIndex = 10
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 253)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(547, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LoanToolStripStatusLabel
        '
        Me.LoanToolStripStatusLabel.Name = "LoanToolStripStatusLabel"
        Me.LoanToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'UpdateLoanButton
        '
        Me.UpdateLoanButton.Location = New System.Drawing.Point(460, 225)
        Me.UpdateLoanButton.Name = "UpdateLoanButton"
        Me.UpdateLoanButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateLoanButton.TabIndex = 2
        Me.UpdateLoanButton.Text = "Update"
        Me.UpdateLoanButton.UseVisualStyleBackColor = True
        '
        'CancelLoanButton
        '
        Me.CancelLoanButton.Location = New System.Drawing.Point(379, 225)
        Me.CancelLoanButton.Name = "CancelLoanButton"
        Me.CancelLoanButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelLoanButton.TabIndex = 3
        Me.CancelLoanButton.Text = "Cancel"
        Me.CancelLoanButton.UseVisualStyleBackColor = True
        '
        'UpdateLoanView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 275)
        Me.Controls.Add(Me.CancelLoanButton)
        Me.Controls.Add(Me.UpdateLoanButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "UpdateLoanView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Loan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ExpiryLoanDateTimePicker As DateTimePicker
    Friend WithEvents StartLoanDateTimePicker As DateTimePicker
    Friend WithEvents BookNameTextBox As TextBox
    Friend WithEvents BorrowerNameTextBox As TextBox
    Friend WithEvents IdLoanTextBox As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents UpdateLoanButton As Button
    Friend WithEvents CancelLoanButton As Button
    Friend WithEvents LoanToolStripStatusLabel As ToolStripStatusLabel
End Class
