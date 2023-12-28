<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewBookView
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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.BorrowerDetailsToolStripStatusLabell = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BookToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AddNewBookButton = New System.Windows.Forms.Button()
        Me.CancelNewBookBottom = New System.Windows.Forms.Button()
        Me.NewBookErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bookNameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorNameLabel = New System.Windows.Forms.Label()
        Me.authorNameTextBox = New System.Windows.Forms.TextBox()
        Me.BookNameLabel = New System.Windows.Forms.Label()
        Me.StatusStrip.SuspendLayout()
        CType(Me.NewBookErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.Gainsboro
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowerDetailsToolStripStatusLabell, Me.BookToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 150)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(384, 22)
        Me.StatusStrip.TabIndex = 4
        Me.StatusStrip.Text = "StatusStrip"
        '
        'BorrowerDetailsToolStripStatusLabell
        '
        Me.BorrowerDetailsToolStripStatusLabell.Name = "BorrowerDetailsToolStripStatusLabell"
        Me.BorrowerDetailsToolStripStatusLabell.Size = New System.Drawing.Size(0, 17)
        '
        'BookToolStripStatusLabel
        '
        Me.BookToolStripStatusLabel.Name = "BookToolStripStatusLabel"
        Me.BookToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'AddNewBookButton
        '
        Me.AddNewBookButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddNewBookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewBookButton.Location = New System.Drawing.Point(283, 112)
        Me.AddNewBookButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AddNewBookButton.Name = "AddNewBookButton"
        Me.AddNewBookButton.Size = New System.Drawing.Size(75, 23)
        Me.AddNewBookButton.TabIndex = 13
        Me.AddNewBookButton.Text = "Create"
        Me.AddNewBookButton.UseVisualStyleBackColor = True
        '
        'CancelNewBookBottom
        '
        Me.CancelNewBookBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelNewBookBottom.CausesValidation = False
        Me.CancelNewBookBottom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelNewBookBottom.Location = New System.Drawing.Point(200, 112)
        Me.CancelNewBookBottom.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CancelNewBookBottom.Name = "CancelNewBookBottom"
        Me.CancelNewBookBottom.Size = New System.Drawing.Size(75, 23)
        Me.CancelNewBookBottom.TabIndex = 12
        Me.CancelNewBookBottom.Text = "Cancel"
        Me.CancelNewBookBottom.UseVisualStyleBackColor = True
        '
        'NewBookErrorProvider
        '
        Me.NewBookErrorProvider.ContainerControl = Me
        '
        'bookNameTextBox
        '
        Me.bookNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookNameTextBox.Location = New System.Drawing.Point(92, 28)
        Me.bookNameTextBox.Name = "bookNameTextBox"
        Me.bookNameTextBox.Size = New System.Drawing.Size(266, 20)
        Me.bookNameTextBox.TabIndex = 18
        '
        'AuthorNameLabel
        '
        Me.AuthorNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuthorNameLabel.AutoSize = True
        Me.AuthorNameLabel.Location = New System.Drawing.Point(16, 84)
        Me.AuthorNameLabel.Name = "AuthorNameLabel"
        Me.AuthorNameLabel.Size = New System.Drawing.Size(69, 13)
        Me.AuthorNameLabel.TabIndex = 17
        Me.AuthorNameLabel.Text = "Author Name"
        '
        'authorNameTextBox
        '
        Me.authorNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.authorNameTextBox.Location = New System.Drawing.Point(92, 77)
        Me.authorNameTextBox.Name = "authorNameTextBox"
        Me.authorNameTextBox.Size = New System.Drawing.Size(266, 20)
        Me.authorNameTextBox.TabIndex = 19
        '
        'BookNameLabel
        '
        Me.BookNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookNameLabel.AutoSize = True
        Me.BookNameLabel.Location = New System.Drawing.Point(16, 35)
        Me.BookNameLabel.Name = "BookNameLabel"
        Me.BookNameLabel.Size = New System.Drawing.Size(63, 13)
        Me.BookNameLabel.TabIndex = 16
        Me.BookNameLabel.Text = "Book Name"
        '
        'NewBookView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 172)
        Me.Controls.Add(Me.BookNameLabel)
        Me.Controls.Add(Me.bookNameTextBox)
        Me.Controls.Add(Me.AuthorNameLabel)
        Me.Controls.Add(Me.authorNameTextBox)
        Me.Controls.Add(Me.AddNewBookButton)
        Me.Controls.Add(Me.CancelNewBookBottom)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "NewBookView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Book"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.NewBookErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents BorrowerDetailsToolStripStatusLabell As ToolStripStatusLabel
    Friend WithEvents BookToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents AddNewBookButton As Button
    Friend WithEvents CancelNewBookBottom As Button
    Friend WithEvents NewBookErrorProvider As ErrorProvider
    Friend WithEvents bookNameTextBox As TextBox
    Friend WithEvents AuthorNameLabel As Label
    Friend WithEvents authorNameTextBox As TextBox
    Friend WithEvents BookNameLabel As Label
End Class
