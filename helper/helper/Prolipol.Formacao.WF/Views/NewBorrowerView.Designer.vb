Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class NewBorrowerView
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
            Me.components = New System.ComponentModel.Container()
            Me.FullNameTextBox = New System.Windows.Forms.TextBox()
            Me.FullNameLabel = New System.Windows.Forms.Label()
            Me.CancelBorrowerButton = New System.Windows.Forms.Button()
            Me.CreateBorrowerButton = New System.Windows.Forms.Button()
            Me.NewBorrowerErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.NewBorrowerToolTip = New System.Windows.Forms.ToolTip(Me.components)
            Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
            Me.BorrowersToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
            Me.BorrowerDetailsToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
            CType(Me.NewBorrowerErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.StatusStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'FullNameTextBox
            '
            Me.FullNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.NewBorrowerErrorProvider.SetIconPadding(Me.FullNameTextBox, 2)
            Me.FullNameTextBox.Location = New System.Drawing.Point(82, 35)
            Me.FullNameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.FullNameTextBox.Name = "FullNameTextBox"
            Me.FullNameTextBox.Size = New System.Drawing.Size(277, 23)
            Me.FullNameTextBox.TabIndex = 1
            '
            'FullNameLabel
            '
            Me.FullNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.FullNameLabel.AutoSize = True
            Me.FullNameLabel.Location = New System.Drawing.Point(13, 43)
            Me.FullNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.FullNameLabel.Name = "FullNameLabel"
            Me.FullNameLabel.Size = New System.Drawing.Size(61, 15)
            Me.FullNameLabel.TabIndex = 0
            Me.FullNameLabel.Text = "Full Name"
            '
            'CancelBorrowerButton
            '
            Me.CancelBorrowerButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CancelBorrowerButton.CausesValidation = False
            Me.CancelBorrowerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.CancelBorrowerButton.Location = New System.Drawing.Point(192, 74)
            Me.CancelBorrowerButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.CancelBorrowerButton.Name = "CancelBorrowerButton"
            Me.CancelBorrowerButton.Size = New System.Drawing.Size(75, 23)
            Me.CancelBorrowerButton.TabIndex = 1
            Me.CancelBorrowerButton.Text = "Cancel"
            Me.CancelBorrowerButton.UseVisualStyleBackColor = True
            '
            'CreateBorrowerButton
            '
            Me.CreateBorrowerButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CreateBorrowerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.CreateBorrowerButton.Location = New System.Drawing.Point(284, 74)
            Me.CreateBorrowerButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.CreateBorrowerButton.Name = "CreateBorrowerButton"
            Me.CreateBorrowerButton.Size = New System.Drawing.Size(75, 23)
            Me.CreateBorrowerButton.TabIndex = 2
            Me.CreateBorrowerButton.Text = "Create"
            Me.CreateBorrowerButton.UseVisualStyleBackColor = True
            '
            'NewBorrowerErrorProvider
            '
            Me.NewBorrowerErrorProvider.ContainerControl = Me
            '
            'NewBorrowerToolTip
            '
            Me.NewBorrowerToolTip.IsBalloon = True
            Me.NewBorrowerToolTip.ShowAlways = True
            '
            'StatusStrip1
            '
            Me.StatusStrip1.BackColor = System.Drawing.Color.Gainsboro
            Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowersToolStripStatusLabel, Me.BorrowerDetailsToolStripStatusLabel})
            Me.StatusStrip1.Location = New System.Drawing.Point(0, 112)
            Me.StatusStrip1.Name = "StatusStrip1"
            Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
            Me.StatusStrip1.Size = New System.Drawing.Size(383, 22)
            Me.StatusStrip1.TabIndex = 4
            Me.StatusStrip1.Text = "StatusStrip1"
            '
            'BorrowersToolStripStatusLabel
            '
            Me.BorrowersToolStripStatusLabel.Name = "BorrowersToolStripStatusLabel"
            Me.BorrowersToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
            '
            'BorrowerDetailsToolStripStatusLabel
            '
            Me.BorrowerDetailsToolStripStatusLabel.Name = "BorrowerDetailsToolStripStatusLabel"
            Me.BorrowerDetailsToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
            '
            'NewBorrowerView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(383, 134)
            Me.Controls.Add(Me.FullNameTextBox)
            Me.Controls.Add(Me.FullNameLabel)
            Me.Controls.Add(Me.StatusStrip1)
            Me.Controls.Add(Me.CreateBorrowerButton)
            Me.Controls.Add(Me.CancelBorrowerButton)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(526, 385)
            Me.Name = "NewBorrowerView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Create New Borrower"
            CType(Me.NewBorrowerErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
            Me.StatusStrip1.ResumeLayout(False)
            Me.StatusStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents CancelBorrowerButton As Button
        Friend WithEvents CreateBorrowerButton As Button
        Friend WithEvents FullNameTextBox As TextBox
        Friend WithEvents FullNameLabel As Label
        Friend WithEvents NewBorrowerErrorProvider As ErrorProvider
        Friend WithEvents NewBorrowerToolTip As ToolTip
        Friend WithEvents StatusStrip1 As StatusStrip
        Friend WithEvents BorrowersToolStripStatusLabel As ToolStripStatusLabel
        Friend WithEvents BorrowerDetailsToolStripStatusLabel As ToolStripStatusLabel
    End Class
End Namespace