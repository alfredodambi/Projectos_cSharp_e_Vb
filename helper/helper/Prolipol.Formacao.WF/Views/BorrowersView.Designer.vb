Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class BorrowersView
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
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.BorrowersDataGridView = New System.Windows.Forms.DataGridView()
            Me.CloseBorrowerButton = New System.Windows.Forms.Button()
            Me.SearchBorrowerButton = New System.Windows.Forms.Button()
            Me.SearchFiltersGroupBox = New System.Windows.Forms.GroupBox()
            Me.BorrowerFullNameTextBox = New System.Windows.Forms.TextBox()
            Me.BorrowerIDTextBox = New System.Windows.Forms.TextBox()
            Me.BorrowerFullNameLabel = New System.Windows.Forms.Label()
            Me.BorrowerIDLabel = New System.Windows.Forms.Label()
            Me.BorrowersStatusStrip = New System.Windows.Forms.StatusStrip()
            Me.BorrowersToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
            Me.DetailsBorrowerButton = New System.Windows.Forms.Button()
            Me.NewSearchBorrowerButton = New System.Windows.Forms.Button()
            Me.EditBorrowerButton = New System.Windows.Forms.Button()
            Me.DeleteBorrowerButton = New System.Windows.Forms.Button()
            CType(Me.BorrowersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SearchFiltersGroupBox.SuspendLayout()
            Me.BorrowersStatusStrip.SuspendLayout()
            Me.SuspendLayout()
            '
            'BorrowersDataGridView
            '
            Me.BorrowersDataGridView.AllowUserToAddRows = False
            Me.BorrowersDataGridView.AllowUserToDeleteRows = False
            Me.BorrowersDataGridView.AllowUserToResizeRows = False
            Me.BorrowersDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BorrowersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.BorrowersDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
            Me.BorrowersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
            Me.BorrowersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(2)
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.BorrowersDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.BorrowersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.BorrowersDataGridView.DefaultCellStyle = DataGridViewCellStyle10
            Me.BorrowersDataGridView.EnableHeadersVisualStyles = False
            Me.BorrowersDataGridView.GridColor = System.Drawing.SystemColors.Window
            Me.BorrowersDataGridView.Location = New System.Drawing.Point(12, 108)
            Me.BorrowersDataGridView.Name = "BorrowersDataGridView"
            Me.BorrowersDataGridView.ReadOnly = True
            Me.BorrowersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.BorrowersDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
            Me.BorrowersDataGridView.RowHeadersVisible = False
            DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(2)
            Me.BorrowersDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle12
            Me.BorrowersDataGridView.RowTemplate.ReadOnly = True
            Me.BorrowersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.BorrowersDataGridView.ShowCellErrors = False
            Me.BorrowersDataGridView.ShowCellToolTips = False
            Me.BorrowersDataGridView.ShowEditingIcon = False
            Me.BorrowersDataGridView.ShowRowErrors = False
            Me.BorrowersDataGridView.Size = New System.Drawing.Size(464, 221)
            Me.BorrowersDataGridView.TabIndex = 2
            '
            'CloseBorrowerButton
            '
            Me.CloseBorrowerButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CloseBorrowerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CloseBorrowerButton.Location = New System.Drawing.Point(401, 342)
            Me.CloseBorrowerButton.Name = "CloseBorrowerButton"
            Me.CloseBorrowerButton.Size = New System.Drawing.Size(75, 23)
            Me.CloseBorrowerButton.TabIndex = 3
            Me.CloseBorrowerButton.Text = "&Close"
            Me.CloseBorrowerButton.UseVisualStyleBackColor = True
            '
            'SearchBorrowerButton
            '
            Me.SearchBorrowerButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SearchBorrowerButton.Location = New System.Drawing.Point(401, 21)
            Me.SearchBorrowerButton.Name = "SearchBorrowerButton"
            Me.SearchBorrowerButton.Size = New System.Drawing.Size(75, 23)
            Me.SearchBorrowerButton.TabIndex = 4
            Me.SearchBorrowerButton.Text = "Search"
            Me.SearchBorrowerButton.UseVisualStyleBackColor = True
            '
            'SearchFiltersGroupBox
            '
            Me.SearchFiltersGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.SearchFiltersGroupBox.Controls.Add(Me.BorrowerFullNameTextBox)
            Me.SearchFiltersGroupBox.Controls.Add(Me.BorrowerIDTextBox)
            Me.SearchFiltersGroupBox.Controls.Add(Me.BorrowerFullNameLabel)
            Me.SearchFiltersGroupBox.Controls.Add(Me.BorrowerIDLabel)
            Me.SearchFiltersGroupBox.Location = New System.Drawing.Point(12, 12)
            Me.SearchFiltersGroupBox.Name = "SearchFiltersGroupBox"
            Me.SearchFiltersGroupBox.Size = New System.Drawing.Size(368, 90)
            Me.SearchFiltersGroupBox.TabIndex = 5
            Me.SearchFiltersGroupBox.TabStop = False
            Me.SearchFiltersGroupBox.Text = "Search Borrowers"
            '
            'BorrowerFullNameTextBox
            '
            Me.BorrowerFullNameTextBox.Location = New System.Drawing.Point(141, 39)
            Me.BorrowerFullNameTextBox.Name = "BorrowerFullNameTextBox"
            Me.BorrowerFullNameTextBox.Size = New System.Drawing.Size(208, 20)
            Me.BorrowerFullNameTextBox.TabIndex = 1
            '
            'BorrowerIDTextBox
            '
            Me.BorrowerIDTextBox.Location = New System.Drawing.Point(18, 39)
            Me.BorrowerIDTextBox.Name = "BorrowerIDTextBox"
            Me.BorrowerIDTextBox.Size = New System.Drawing.Size(98, 20)
            Me.BorrowerIDTextBox.TabIndex = 1
            '
            'BorrowerFullNameLabel
            '
            Me.BorrowerFullNameLabel.AutoSize = True
            Me.BorrowerFullNameLabel.Location = New System.Drawing.Point(138, 23)
            Me.BorrowerFullNameLabel.Name = "BorrowerFullNameLabel"
            Me.BorrowerFullNameLabel.Size = New System.Drawing.Size(99, 13)
            Me.BorrowerFullNameLabel.TabIndex = 0
            Me.BorrowerFullNameLabel.Text = "Borrower Full Name"
            '
            'BorrowerIDLabel
            '
            Me.BorrowerIDLabel.AutoSize = True
            Me.BorrowerIDLabel.Location = New System.Drawing.Point(15, 23)
            Me.BorrowerIDLabel.Name = "BorrowerIDLabel"
            Me.BorrowerIDLabel.Size = New System.Drawing.Size(63, 13)
            Me.BorrowerIDLabel.TabIndex = 0
            Me.BorrowerIDLabel.Text = "Borrower ID"
            '
            'BorrowersStatusStrip
            '
            Me.BorrowersStatusStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.BorrowersStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowersToolStripStatusLabel})
            Me.BorrowersStatusStrip.Location = New System.Drawing.Point(0, 378)
            Me.BorrowersStatusStrip.Name = "BorrowersStatusStrip"
            Me.BorrowersStatusStrip.Size = New System.Drawing.Size(488, 22)
            Me.BorrowersStatusStrip.TabIndex = 6
            Me.BorrowersStatusStrip.Text = "StatusStrip1"
            '
            'BorrowersToolStripStatusLabel
            '
            Me.BorrowersToolStripStatusLabel.Name = "BorrowersToolStripStatusLabel"
            Me.BorrowersToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
            '
            'DetailsBorrowerButton
            '
            Me.DetailsBorrowerButton.Location = New System.Drawing.Point(12, 342)
            Me.DetailsBorrowerButton.Name = "DetailsBorrowerButton"
            Me.DetailsBorrowerButton.Size = New System.Drawing.Size(75, 23)
            Me.DetailsBorrowerButton.TabIndex = 7
            Me.DetailsBorrowerButton.Text = "View Details"
            Me.DetailsBorrowerButton.UseVisualStyleBackColor = True
            '
            'NewSearchBorrowerButton
            '
            Me.NewSearchBorrowerButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.NewSearchBorrowerButton.Location = New System.Drawing.Point(401, 50)
            Me.NewSearchBorrowerButton.Name = "NewSearchBorrowerButton"
            Me.NewSearchBorrowerButton.Size = New System.Drawing.Size(75, 23)
            Me.NewSearchBorrowerButton.TabIndex = 8
            Me.NewSearchBorrowerButton.Text = "New Search"
            Me.NewSearchBorrowerButton.UseVisualStyleBackColor = True
            '
            'EditBorrowerButton
            '
            Me.EditBorrowerButton.Location = New System.Drawing.Point(93, 342)
            Me.EditBorrowerButton.Name = "EditBorrowerButton"
            Me.EditBorrowerButton.Size = New System.Drawing.Size(75, 23)
            Me.EditBorrowerButton.TabIndex = 10
            Me.EditBorrowerButton.Text = "Edit"
            Me.EditBorrowerButton.UseVisualStyleBackColor = True
            '
            'DeleteBorrowerButton
            '
            Me.DeleteBorrowerButton.Location = New System.Drawing.Point(174, 342)
            Me.DeleteBorrowerButton.Name = "DeleteBorrowerButton"
            Me.DeleteBorrowerButton.Size = New System.Drawing.Size(75, 23)
            Me.DeleteBorrowerButton.TabIndex = 11
            Me.DeleteBorrowerButton.Text = "Delete"
            Me.DeleteBorrowerButton.UseVisualStyleBackColor = True
            '
            'BorrowersView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(488, 400)
            Me.Controls.Add(Me.DeleteBorrowerButton)
            Me.Controls.Add(Me.EditBorrowerButton)
            Me.Controls.Add(Me.NewSearchBorrowerButton)
            Me.Controls.Add(Me.DetailsBorrowerButton)
            Me.Controls.Add(Me.BorrowersStatusStrip)
            Me.Controls.Add(Me.SearchFiltersGroupBox)
            Me.Controls.Add(Me.SearchBorrowerButton)
            Me.Controls.Add(Me.CloseBorrowerButton)
            Me.Controls.Add(Me.BorrowersDataGridView)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(504, 439)
            Me.MinimumSize = New System.Drawing.Size(504, 439)
            Me.Name = "BorrowersView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Borrowers Manage"
            CType(Me.BorrowersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SearchFiltersGroupBox.ResumeLayout(False)
            Me.SearchFiltersGroupBox.PerformLayout()
            Me.BorrowersStatusStrip.ResumeLayout(False)
            Me.BorrowersStatusStrip.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents BorrowersDataGridView As DataGridView
        Friend WithEvents CloseBorrowerButton As Button
        Friend WithEvents SearchBorrowerButton As Button
        Friend WithEvents SearchFiltersGroupBox As GroupBox
        Friend WithEvents BorrowerFullNameTextBox As TextBox
        Friend WithEvents BorrowerIDTextBox As TextBox
        Friend WithEvents BorrowerFullNameLabel As Label
        Friend WithEvents BorrowerIDLabel As Label
        Friend WithEvents BorrowersStatusStrip As StatusStrip
        Friend WithEvents BorrowersToolStripStatusLabel As ToolStripStatusLabel
        Friend WithEvents DetailsBorrowerButton As Button
        Friend WithEvents NewSearchBorrowerButton As Button
        Friend WithEvents EditBorrowerButton As Button
        Friend WithEvents DeleteBorrowerButton As Button
    End Class
End Namespace