<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.BookViewToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.searchBookButton = New System.Windows.Forms.Button()
        Me.closeBookButton = New System.Windows.Forms.Button()
        Me.ViewBookDetailsButtons = New System.Windows.Forms.Button()
        Me.NewSearchBookButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.autorBookTextBox = New System.Windows.Forms.TextBox()
        Me.nameBookTextBox = New System.Windows.Forms.TextBox()
        Me.idBookTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EditBookButton = New System.Windows.Forms.Button()
        Me.DeleteBookButton = New System.Windows.Forms.Button()
        Me.BooksDataGridView = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookViewToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 384)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(555, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BookViewToolStripStatusLabel
        '
        Me.BookViewToolStripStatusLabel.Name = "BookViewToolStripStatusLabel"
        Me.BookViewToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'searchBookButton
        '
        Me.searchBookButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchBookButton.Location = New System.Drawing.Point(468, 21)
        Me.searchBookButton.Name = "searchBookButton"
        Me.searchBookButton.Size = New System.Drawing.Size(75, 23)
        Me.searchBookButton.TabIndex = 6
        Me.searchBookButton.Text = "Search"
        Me.searchBookButton.UseVisualStyleBackColor = True
        '
        'closeBookButton
        '
        Me.closeBookButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBookButton.Location = New System.Drawing.Point(468, 354)
        Me.closeBookButton.Name = "closeBookButton"
        Me.closeBookButton.Size = New System.Drawing.Size(75, 23)
        Me.closeBookButton.TabIndex = 7
        Me.closeBookButton.Text = "Close"
        Me.closeBookButton.UseVisualStyleBackColor = True
        '
        'ViewBookDetailsButtons
        '
        Me.ViewBookDetailsButtons.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewBookDetailsButtons.Location = New System.Drawing.Point(12, 354)
        Me.ViewBookDetailsButtons.Name = "ViewBookDetailsButtons"
        Me.ViewBookDetailsButtons.Size = New System.Drawing.Size(75, 23)
        Me.ViewBookDetailsButtons.TabIndex = 8
        Me.ViewBookDetailsButtons.Text = "View Details"
        Me.ViewBookDetailsButtons.UseVisualStyleBackColor = True
        '
        'NewSearchBookButton
        '
        Me.NewSearchBookButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewSearchBookButton.Location = New System.Drawing.Point(468, 50)
        Me.NewSearchBookButton.Name = "NewSearchBookButton"
        Me.NewSearchBookButton.Size = New System.Drawing.Size(75, 23)
        Me.NewSearchBookButton.TabIndex = 18
        Me.NewSearchBookButton.Text = "New Search"
        Me.NewSearchBookButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.autorBookTextBox)
        Me.GroupBox1.Controls.Add(Me.nameBookTextBox)
        Me.GroupBox1.Controls.Add(Me.idBookTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 84)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Book"
        '
        'autorBookTextBox
        '
        Me.autorBookTextBox.Location = New System.Drawing.Point(273, 41)
        Me.autorBookTextBox.Name = "autorBookTextBox"
        Me.autorBookTextBox.Size = New System.Drawing.Size(149, 20)
        Me.autorBookTextBox.TabIndex = 52
        '
        'nameBookTextBox
        '
        Me.nameBookTextBox.Location = New System.Drawing.Point(121, 41)
        Me.nameBookTextBox.Name = "nameBookTextBox"
        Me.nameBookTextBox.Size = New System.Drawing.Size(128, 20)
        Me.nameBookTextBox.TabIndex = 51
        '
        'idBookTextBox
        '
        Me.idBookTextBox.Location = New System.Drawing.Point(18, 41)
        Me.idBookTextBox.Name = "idBookTextBox"
        Me.idBookTextBox.Size = New System.Drawing.Size(82, 20)
        Me.idBookTextBox.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Book Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Author Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Id"
        '
        'EditBookButton
        '
        Me.EditBookButton.Location = New System.Drawing.Point(93, 354)
        Me.EditBookButton.Name = "EditBookButton"
        Me.EditBookButton.Size = New System.Drawing.Size(75, 23)
        Me.EditBookButton.TabIndex = 20
        Me.EditBookButton.Text = "Edit"
        Me.EditBookButton.UseVisualStyleBackColor = True
        '
        'DeleteBookButton
        '
        Me.DeleteBookButton.Location = New System.Drawing.Point(174, 354)
        Me.DeleteBookButton.Name = "DeleteBookButton"
        Me.DeleteBookButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBookButton.TabIndex = 21
        Me.DeleteBookButton.Text = "Delete"
        Me.DeleteBookButton.UseVisualStyleBackColor = True
        '
        'BooksDataGridView
        '
        Me.BooksDataGridView.AllowUserToAddRows = False
        Me.BooksDataGridView.AllowUserToDeleteRows = False
        Me.BooksDataGridView.AllowUserToResizeRows = False
        Me.BooksDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BooksDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.BooksDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BooksDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BooksDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BooksDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.BooksDataGridView.EnableHeadersVisualStyles = False
        Me.BooksDataGridView.GridColor = System.Drawing.SystemColors.Window
        Me.BooksDataGridView.Location = New System.Drawing.Point(12, 112)
        Me.BooksDataGridView.Name = "BooksDataGridView"
        Me.BooksDataGridView.ReadOnly = True
        Me.BooksDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BooksDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.BooksDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(2)
        Me.BooksDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.BooksDataGridView.RowTemplate.ReadOnly = True
        Me.BooksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BooksDataGridView.ShowCellErrors = False
        Me.BooksDataGridView.ShowCellToolTips = False
        Me.BooksDataGridView.ShowEditingIcon = False
        Me.BooksDataGridView.ShowRowErrors = False
        Me.BooksDataGridView.Size = New System.Drawing.Size(531, 225)
        Me.BooksDataGridView.TabIndex = 22
        '
        'BookView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(555, 406)
        Me.Controls.Add(Me.BooksDataGridView)
        Me.Controls.Add(Me.DeleteBookButton)
        Me.Controls.Add(Me.EditBookButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NewSearchBookButton)
        Me.Controls.Add(Me.ViewBookDetailsButtons)
        Me.Controls.Add(Me.closeBookButton)
        Me.Controls.Add(Me.searchBookButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "BookView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Catalog"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents searchBookButton As Button
    Friend WithEvents BookViewToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents closeBookButton As Button
    Friend WithEvents ViewBookDetailsButtons As Button
    Friend WithEvents NewSearchBookButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents autorBookTextBox As TextBox
    Friend WithEvents nameBookTextBox As TextBox
    Friend WithEvents idBookTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EditBookButton As Button
    Friend WithEvents DeleteBookButton As Button
    Friend WithEvents BooksDataGridView As DataGridView
End Class
