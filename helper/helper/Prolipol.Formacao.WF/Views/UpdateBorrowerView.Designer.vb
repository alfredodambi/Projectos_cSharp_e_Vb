<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateBorrowerView
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BorrowerIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BorrowerFullNameTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameLabel = New System.Windows.Forms.Label()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.BorrowerToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UpdateBorrowerButton = New System.Windows.Forms.Button()
        Me.CancelBorrowerButton = New System.Windows.Forms.Button()
        Me.BorrowerUpdateErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.BorrowerUpdateErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BorrowerIdTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BorrowerFullNameTextBox)
        Me.GroupBox1.Controls.Add(Me.FullNameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower Information"
        '
        'BorrowerIdTextBox
        '
        Me.BorrowerIdTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BorrowerIdTextBox.Enabled = False
        Me.BorrowerIdTextBox.Location = New System.Drawing.Point(69, 31)
        Me.BorrowerIdTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BorrowerIdTextBox.Name = "BorrowerIdTextBox"
        Me.BorrowerIdTextBox.ReadOnly = True
        Me.BorrowerIdTextBox.Size = New System.Drawing.Size(277, 20)
        Me.BorrowerIdTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id"
        '
        'BorrowerFullNameTextBox
        '
        Me.BorrowerFullNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BorrowerFullNameTextBox.Location = New System.Drawing.Point(69, 72)
        Me.BorrowerFullNameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BorrowerFullNameTextBox.Name = "BorrowerFullNameTextBox"
        Me.BorrowerFullNameTextBox.Size = New System.Drawing.Size(277, 20)
        Me.BorrowerFullNameTextBox.TabIndex = 3
        '
        'FullNameLabel
        '
        Me.FullNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FullNameLabel.AutoSize = True
        Me.FullNameLabel.Location = New System.Drawing.Point(7, 75)
        Me.FullNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FullNameLabel.Name = "FullNameLabel"
        Me.FullNameLabel.Size = New System.Drawing.Size(54, 13)
        Me.FullNameLabel.TabIndex = 2
        Me.FullNameLabel.Text = "Full Name"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowerToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 163)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(383, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'BorrowerToolStripStatusLabel
        '
        Me.BorrowerToolStripStatusLabel.Name = "BorrowerToolStripStatusLabel"
        Me.BorrowerToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'UpdateBorrowerButton
        '
        Me.UpdateBorrowerButton.Location = New System.Drawing.Point(296, 131)
        Me.UpdateBorrowerButton.Name = "UpdateBorrowerButton"
        Me.UpdateBorrowerButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBorrowerButton.TabIndex = 2
        Me.UpdateBorrowerButton.Text = "Update"
        Me.UpdateBorrowerButton.UseVisualStyleBackColor = True
        '
        'CancelBorrowerButton
        '
        Me.CancelBorrowerButton.Location = New System.Drawing.Point(215, 131)
        Me.CancelBorrowerButton.Name = "CancelBorrowerButton"
        Me.CancelBorrowerButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelBorrowerButton.TabIndex = 3
        Me.CancelBorrowerButton.Text = "Cancel"
        Me.CancelBorrowerButton.UseVisualStyleBackColor = True
        '
        'BorrowerUpdateErrorProvider
        '
        Me.BorrowerUpdateErrorProvider.ContainerControl = Me
        '
        'UpdateBorrowerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 185)
        Me.Controls.Add(Me.CancelBorrowerButton)
        Me.Controls.Add(Me.UpdateBorrowerButton)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.FullName = "UpdateBorrowerView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Borrower"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.BorrowerUpdateErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents BorrowerIdTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BorrowerFullNameTextBox As TextBox
    Friend WithEvents FullNameLabel As Label
    Friend WithEvents UpdateBorrowerButton As Button
    Friend WithEvents CancelBorrowerButton As Button
    Friend WithEvents BorrowerToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents BorrowerUpdateErrorProvider As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
End Class
