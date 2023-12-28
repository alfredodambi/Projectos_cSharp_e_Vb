<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateBookView
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IsAvailableBookCheckBox = New System.Windows.Forms.CheckBox()
        Me.AuthorBookTextBox = New System.Windows.Forms.TextBox()
        Me.BookNameTextBox = New System.Windows.Forms.TextBox()
        Me.IdBookTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.BookToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UpdateBookButton = New System.Windows.Forms.Button()
        Me.CancelBookButton = New System.Windows.Forms.Button()
        Me.UpdateBookErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.UpdateBookErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.IsAvailableBookCheckBox)
        Me.GroupBox1.Controls.Add(Me.AuthorBookTextBox)
        Me.GroupBox1.Controls.Add(Me.BookNameTextBox)
        Me.GroupBox1.Controls.Add(Me.IdBookTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Is Available"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Author Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Book Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Id"
        '
        'IsAvailableBookCheckBox
        '
        Me.IsAvailableBookCheckBox.AutoSize = True
        Me.IsAvailableBookCheckBox.Enabled = False
        Me.IsAvailableBookCheckBox.Location = New System.Drawing.Point(79, 142)
        Me.IsAvailableBookCheckBox.Name = "IsAvailableBookCheckBox"
        Me.IsAvailableBookCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.IsAvailableBookCheckBox.TabIndex = 11
        Me.IsAvailableBookCheckBox.UseVisualStyleBackColor = True
        '
        'AuthorBookTextBox
        '
        Me.AuthorBookTextBox.Location = New System.Drawing.Point(79, 105)
        Me.AuthorBookTextBox.Name = "AuthorBookTextBox"
        Me.AuthorBookTextBox.Size = New System.Drawing.Size(410, 20)
        Me.AuthorBookTextBox.TabIndex = 10
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.Location = New System.Drawing.Point(79, 69)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.Size = New System.Drawing.Size(410, 20)
        Me.BookNameTextBox.TabIndex = 9
        '
        'IdBookTextBox
        '
        Me.IdBookTextBox.Enabled = False
        Me.IdBookTextBox.Location = New System.Drawing.Point(79, 36)
        Me.IdBookTextBox.Name = "IdBookTextBox"
        Me.IdBookTextBox.ReadOnly = True
        Me.IdBookTextBox.Size = New System.Drawing.Size(410, 20)
        Me.IdBookTextBox.TabIndex = 8
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 242)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(547, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BookToolStripStatusLabel
        '
        Me.BookToolStripStatusLabel.Name = "BookToolStripStatusLabel"
        Me.BookToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'UpdateBookButton
        '
        Me.UpdateBookButton.Location = New System.Drawing.Point(460, 214)
        Me.UpdateBookButton.Name = "UpdateBookButton"
        Me.UpdateBookButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBookButton.TabIndex = 2
        Me.UpdateBookButton.Text = "Update"
        Me.UpdateBookButton.UseVisualStyleBackColor = True
        '
        'CancelBookButton
        '
        Me.CancelBookButton.Location = New System.Drawing.Point(379, 214)
        Me.CancelBookButton.Name = "CancelBookButton"
        Me.CancelBookButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelBookButton.TabIndex = 3
        Me.CancelBookButton.Text = "Cancel"
        Me.CancelBookButton.UseVisualStyleBackColor = True
        '
        'UpdateBookErrorProvider
        '
        Me.UpdateBookErrorProvider.ContainerControl = Me
        '
        'UpdateBookView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 264)
        Me.Controls.Add(Me.CancelBookButton)
        Me.Controls.Add(Me.UpdateBookButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "UpdateBookView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Book"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.UpdateBookErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IsAvailableBookCheckBox As CheckBox
    Friend WithEvents AuthorBookTextBox As TextBox
    Friend WithEvents BookNameTextBox As TextBox
    Friend WithEvents IdBookTextBox As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents UpdateBookButton As Button
    Friend WithEvents CancelBookButton As Button
    Friend WithEvents BookToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents UpdateBookErrorProvider As ErrorProvider
End Class
