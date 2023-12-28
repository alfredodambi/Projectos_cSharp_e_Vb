<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewLoanView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BookComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BorrowerComboBox = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LoanToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExpireLoanDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartLoanDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CreateLoanButton = New System.Windows.Forms.Button()
        Me.CancelLoanButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BookComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select the book"
        '
        'BookComboBox
        '
        Me.BookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BookComboBox.FormattingEnabled = True
        Me.BookComboBox.Location = New System.Drawing.Point(9, 49)
        Me.BookComboBox.Name = "BookComboBox"
        Me.BookComboBox.Size = New System.Drawing.Size(209, 21)
        Me.BookComboBox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BorrowerComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(273, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 94)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Borrower Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select the Borrower"
        '
        'BorrowerComboBox
        '
        Me.BorrowerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BorrowerComboBox.FormattingEnabled = True
        Me.BorrowerComboBox.Location = New System.Drawing.Point(13, 49)
        Me.BorrowerComboBox.Name = "BorrowerComboBox"
        Me.BorrowerComboBox.Size = New System.Drawing.Size(209, 21)
        Me.BorrowerComboBox.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 248)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(538, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LoanToolStripStatusLabel
        '
        Me.LoanToolStripStatusLabel.Name = "LoanToolStripStatusLabel"
        Me.LoanToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ExpireLoanDateTimePicker)
        Me.GroupBox3.Controls.Add(Me.StartLoanDateTimePicker)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(512, 92)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Loan Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Start Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Expire Date"
        '
        'ExpireLoanDateTimePicker
        '
        Me.ExpireLoanDateTimePicker.Location = New System.Drawing.Point(274, 48)
        Me.ExpireLoanDateTimePicker.Name = "ExpireLoanDateTimePicker"
        Me.ExpireLoanDateTimePicker.Size = New System.Drawing.Size(209, 20)
        Me.ExpireLoanDateTimePicker.TabIndex = 3
        '
        'StartLoanDateTimePicker
        '
        Me.StartLoanDateTimePicker.Location = New System.Drawing.Point(9, 48)
        Me.StartLoanDateTimePicker.Name = "StartLoanDateTimePicker"
        Me.StartLoanDateTimePicker.Size = New System.Drawing.Size(209, 20)
        Me.StartLoanDateTimePicker.TabIndex = 2
        '
        'CreateLoanButton
        '
        Me.CreateLoanButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateLoanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreateLoanButton.Location = New System.Drawing.Point(450, 213)
        Me.CreateLoanButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CreateLoanButton.Name = "CreateLoanButton"
        Me.CreateLoanButton.Size = New System.Drawing.Size(75, 23)
        Me.CreateLoanButton.TabIndex = 5
        Me.CreateLoanButton.Text = "Create"
        Me.CreateLoanButton.UseVisualStyleBackColor = True
        '
        'CancelLoanButton
        '
        Me.CancelLoanButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelLoanButton.CausesValidation = False
        Me.CancelLoanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelLoanButton.Location = New System.Drawing.Point(366, 213)
        Me.CancelLoanButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CancelLoanButton.Name = "CancelLoanButton"
        Me.CancelLoanButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelLoanButton.TabIndex = 4
        Me.CancelLoanButton.Text = "Cancel"
        Me.CancelLoanButton.UseVisualStyleBackColor = True
        '
        'NewLoanView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 270)
        Me.Controls.Add(Me.CreateLoanButton)
        Me.Controls.Add(Me.CancelLoanButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "NewLoanView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registe New Loan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BookComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BorrowerComboBox As ComboBox
    Friend WithEvents CreateLoanButton As Button
    Friend WithEvents CancelLoanButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ExpireLoanDateTimePicker As DateTimePicker
    Friend WithEvents StartLoanDateTimePicker As DateTimePicker
    Friend WithEvents LoanToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
End Class
