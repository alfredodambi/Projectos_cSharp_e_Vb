<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnBookView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LoanToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReturnDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CancelRetunBookButton = New System.Windows.Forms.Button()
        Me.ReturnBookButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BorrrowerNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BookNameTextBox = New System.Windows.Forms.TextBox()
        Me.StartDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 185)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(346, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LoanToolStripStatusLabel
        '
        Me.LoanToolStripStatusLabel.Name = "LoanToolStripStatusLabel"
        Me.LoanToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Return Date:"
        '
        'ReturnDateDateTimePicker
        '
        Me.ReturnDateDateTimePicker.Location = New System.Drawing.Point(95, 115)
        Me.ReturnDateDateTimePicker.Name = "ReturnDateDateTimePicker"
        Me.ReturnDateDateTimePicker.Size = New System.Drawing.Size(235, 20)
        Me.ReturnDateDateTimePicker.TabIndex = 20
        '
        'CancelRetunBookButton
        '
        Me.CancelRetunBookButton.Location = New System.Drawing.Point(162, 150)
        Me.CancelRetunBookButton.Name = "CancelRetunBookButton"
        Me.CancelRetunBookButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelRetunBookButton.TabIndex = 19
        Me.CancelRetunBookButton.Text = "Cancel"
        Me.CancelRetunBookButton.UseVisualStyleBackColor = True
        '
        'ReturnBookButton
        '
        Me.ReturnBookButton.Location = New System.Drawing.Point(252, 150)
        Me.ReturnBookButton.Name = "ReturnBookButton"
        Me.ReturnBookButton.Size = New System.Drawing.Size(75, 23)
        Me.ReturnBookButton.TabIndex = 18
        Me.ReturnBookButton.Text = "Return Book"
        Me.ReturnBookButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Start Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Borrower:"
        '
        'BorrrowerNameTextBox
        '
        Me.BorrrowerNameTextBox.Enabled = False
        Me.BorrrowerNameTextBox.Location = New System.Drawing.Point(95, 50)
        Me.BorrrowerNameTextBox.Name = "BorrrowerNameTextBox"
        Me.BorrrowerNameTextBox.ReadOnly = True
        Me.BorrrowerNameTextBox.Size = New System.Drawing.Size(235, 20)
        Me.BorrrowerNameTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Book Name:"
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.Enabled = False
        Me.BookNameTextBox.Location = New System.Drawing.Point(95, 17)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.ReadOnly = True
        Me.BookNameTextBox.Size = New System.Drawing.Size(235, 20)
        Me.BookNameTextBox.TabIndex = 13
        '
        'StartDateDateTimePicker
        '
        Me.StartDateDateTimePicker.Enabled = False
        Me.StartDateDateTimePicker.Location = New System.Drawing.Point(95, 84)
        Me.StartDateDateTimePicker.Name = "StartDateDateTimePicker"
        Me.StartDateDateTimePicker.Size = New System.Drawing.Size(235, 20)
        Me.StartDateDateTimePicker.TabIndex = 12
        '
        'ReturnBookView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 207)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ReturnDateDateTimePicker)
        Me.Controls.Add(Me.CancelRetunBookButton)
        Me.Controls.Add(Me.ReturnBookButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BorrrowerNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BookNameTextBox)
        Me.Controls.Add(Me.StartDateDateTimePicker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ReturnBookView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return Book"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LoanToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents ReturnDateDateTimePicker As DateTimePicker
    Friend WithEvents CancelRetunBookButton As Button
    Friend WithEvents ReturnBookButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BorrrowerNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BookNameTextBox As TextBox
    Friend WithEvents StartDateDateTimePicker As DateTimePicker
End Class
