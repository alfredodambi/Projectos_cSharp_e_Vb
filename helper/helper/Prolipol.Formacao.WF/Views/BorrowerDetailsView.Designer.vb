Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class BorrowerDetailsView
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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.BorrowerTabControl = New System.Windows.Forms.TabControl()
            Me.BorrowerDetailsTabPage = New System.Windows.Forms.TabPage()
            Me.BorrowerFullNameTextBox = New System.Windows.Forms.TextBox()
            Me.BorrowerDetailLabel = New System.Windows.Forms.Label()
            Me.BorrowerIDTextBox = New System.Windows.Forms.TextBox()
            Me.BorrowerIDLabel = New System.Windows.Forms.Label()
            Me.BorrowerLoansTabPage = New System.Windows.Forms.TabPage()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.BorrowerInLoansDataGridView = New System.Windows.Forms.DataGridView()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.ReturnBookButton = New System.Windows.Forms.Button()
            Me.CloseButton = New System.Windows.Forms.Button()
            Me.BorrowerDetailsStatusStrip = New System.Windows.Forms.StatusStrip()
            Me.BorrowerDetailsToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
            Me.BorrowerTabControl.SuspendLayout()
            Me.BorrowerDetailsTabPage.SuspendLayout()
            Me.BorrowerLoansTabPage.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.BorrowerInLoansDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.BorrowerDetailsStatusStrip.SuspendLayout()
            Me.SuspendLayout()
            '
            'BorrowerTabControl
            '
            Me.BorrowerTabControl.Controls.Add(Me.BorrowerDetailsTabPage)
            Me.BorrowerTabControl.Controls.Add(Me.BorrowerLoansTabPage)
            Me.BorrowerTabControl.Location = New System.Drawing.Point(12, 12)
            Me.BorrowerTabControl.Name = "BorrowerTabControl"
            Me.BorrowerTabControl.SelectedIndex = 0
            Me.BorrowerTabControl.Size = New System.Drawing.Size(486, 264)
            Me.BorrowerTabControl.TabIndex = 0
            '
            'BorrowerDetailsTabPage
            '
            Me.BorrowerDetailsTabPage.Controls.Add(Me.BorrowerFullNameTextBox)
            Me.BorrowerDetailsTabPage.Controls.Add(Me.BorrowerDetailLabel)
            Me.BorrowerDetailsTabPage.Controls.Add(Me.BorrowerIDTextBox)
            Me.BorrowerDetailsTabPage.Controls.Add(Me.BorrowerIDLabel)
            Me.BorrowerDetailsTabPage.Location = New System.Drawing.Point(4, 22)
            Me.BorrowerDetailsTabPage.Name = "BorrowerDetailsTabPage"
            Me.BorrowerDetailsTabPage.Padding = New System.Windows.Forms.Padding(3)
            Me.BorrowerDetailsTabPage.Size = New System.Drawing.Size(478, 238)
            Me.BorrowerDetailsTabPage.TabIndex = 0
            Me.BorrowerDetailsTabPage.Text = "Details"
            Me.BorrowerDetailsTabPage.UseVisualStyleBackColor = True
            '
            'BorrowerFullNameTextBox
            '
            Me.BorrowerFullNameTextBox.Enabled = False
            Me.BorrowerFullNameTextBox.Location = New System.Drawing.Point(85, 87)
            Me.BorrowerFullNameTextBox.Name = "BorrowerFullNameTextBox"
            Me.BorrowerFullNameTextBox.ReadOnly = True
            Me.BorrowerFullNameTextBox.Size = New System.Drawing.Size(366, 20)
            Me.BorrowerFullNameTextBox.TabIndex = 3
            '
            'BorrowerDetailLabel
            '
            Me.BorrowerDetailLabel.AutoSize = True
            Me.BorrowerDetailLabel.Location = New System.Drawing.Point(16, 94)
            Me.BorrowerDetailLabel.Name = "BorrowerDetailLabel"
            Me.BorrowerDetailLabel.Size = New System.Drawing.Size(54, 13)
            Me.BorrowerDetailLabel.TabIndex = 2
            Me.BorrowerDetailLabel.Text = "Full Name"
            '
            'BorrowerIDTextBox
            '
            Me.BorrowerIDTextBox.Enabled = False
            Me.BorrowerIDTextBox.Location = New System.Drawing.Point(85, 44)
            Me.BorrowerIDTextBox.Name = "BorrowerIDTextBox"
            Me.BorrowerIDTextBox.ReadOnly = True
            Me.BorrowerIDTextBox.Size = New System.Drawing.Size(366, 20)
            Me.BorrowerIDTextBox.TabIndex = 1
            '
            'BorrowerIDLabel
            '
            Me.BorrowerIDLabel.AutoSize = True
            Me.BorrowerIDLabel.Location = New System.Drawing.Point(16, 51)
            Me.BorrowerIDLabel.Name = "BorrowerIDLabel"
            Me.BorrowerIDLabel.Size = New System.Drawing.Size(16, 13)
            Me.BorrowerIDLabel.TabIndex = 0
            Me.BorrowerIDLabel.Text = "Id"
            '
            'BorrowerLoansTabPage
            '
            Me.BorrowerLoansTabPage.Controls.Add(Me.TableLayoutPanel1)
            Me.BorrowerLoansTabPage.Location = New System.Drawing.Point(4, 22)
            Me.BorrowerLoansTabPage.Name = "BorrowerLoansTabPage"
            Me.BorrowerLoansTabPage.Padding = New System.Windows.Forms.Padding(3)
            Me.BorrowerLoansTabPage.Size = New System.Drawing.Size(478, 238)
            Me.BorrowerLoansTabPage.TabIndex = 1
            Me.BorrowerLoansTabPage.Text = "Loans"
            Me.BorrowerLoansTabPage.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.AutoSize = True
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.7112!))
            Me.TableLayoutPanel1.Controls.Add(Me.BorrowerInLoansDataGridView, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(472, 232)
            Me.TableLayoutPanel1.TabIndex = 1
            '
            'BorrowerInLoansDataGridView
            '
            Me.BorrowerInLoansDataGridView.AllowUserToAddRows = False
            Me.BorrowerInLoansDataGridView.AllowUserToDeleteRows = False
            Me.BorrowerInLoansDataGridView.AllowUserToResizeRows = False
            Me.BorrowerInLoansDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.BorrowerInLoansDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
            Me.BorrowerInLoansDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
            Me.BorrowerInLoansDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.BorrowerInLoansDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.BorrowerInLoansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.BorrowerInLoansDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BorrowerInLoansDataGridView.EnableHeadersVisualStyles = False
            Me.BorrowerInLoansDataGridView.GridColor = System.Drawing.SystemColors.Window
            Me.BorrowerInLoansDataGridView.Location = New System.Drawing.Point(3, 3)
            Me.BorrowerInLoansDataGridView.MultiSelect = False
            Me.BorrowerInLoansDataGridView.Name = "BorrowerInLoansDataGridView"
            Me.BorrowerInLoansDataGridView.ReadOnly = True
            Me.BorrowerInLoansDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.BorrowerInLoansDataGridView.RowHeadersVisible = False
            Me.BorrowerInLoansDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.BorrowerInLoansDataGridView.ShowCellErrors = False
            Me.BorrowerInLoansDataGridView.ShowCellToolTips = False
            Me.BorrowerInLoansDataGridView.ShowEditingIcon = False
            Me.BorrowerInLoansDataGridView.ShowRowErrors = False
            Me.BorrowerInLoansDataGridView.Size = New System.Drawing.Size(466, 191)
            Me.BorrowerInLoansDataGridView.TabIndex = 0
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.ColumnCount = 4
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel2.Controls.Add(Me.ReturnBookButton, 0, 0)
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 200)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 29)
            Me.TableLayoutPanel2.TabIndex = 1
            '
            'ReturnBookButton
            '
            Me.ReturnBookButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.ReturnBookButton.Location = New System.Drawing.Point(3, 3)
            Me.ReturnBookButton.Name = "ReturnBookButton"
            Me.ReturnBookButton.Size = New System.Drawing.Size(75, 23)
            Me.ReturnBookButton.TabIndex = 1
            Me.ReturnBookButton.Text = "Return Book"
            Me.ReturnBookButton.UseVisualStyleBackColor = True
            '
            'CloseButton
            '
            Me.CloseButton.Location = New System.Drawing.Point(422, 282)
            Me.CloseButton.Name = "CloseButton"
            Me.CloseButton.Size = New System.Drawing.Size(75, 23)
            Me.CloseButton.TabIndex = 1
            Me.CloseButton.Text = "&Close"
            Me.CloseButton.UseVisualStyleBackColor = True
            '
            'BorrowerDetailsStatusStrip
            '
            Me.BorrowerDetailsStatusStrip.BackColor = System.Drawing.Color.Gainsboro
            Me.BorrowerDetailsStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowerDetailsToolStripStatusLabel})
            Me.BorrowerDetailsStatusStrip.Location = New System.Drawing.Point(0, 313)
            Me.BorrowerDetailsStatusStrip.Name = "BorrowerDetailsStatusStrip"
            Me.BorrowerDetailsStatusStrip.Size = New System.Drawing.Size(509, 22)
            Me.BorrowerDetailsStatusStrip.TabIndex = 2
            '
            'BorrowerDetailsToolStripStatusLabel
            '
            Me.BorrowerDetailsToolStripStatusLabel.Name = "BorrowerDetailsToolStripStatusLabel"
            Me.BorrowerDetailsToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
            '
            'BorrowerDetailsView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(509, 335)
            Me.Controls.Add(Me.BorrowerDetailsStatusStrip)
            Me.Controls.Add(Me.CloseButton)
            Me.Controls.Add(Me.BorrowerTabControl)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "BorrowerDetailsView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Borrower Details"
            Me.BorrowerTabControl.ResumeLayout(False)
            Me.BorrowerDetailsTabPage.ResumeLayout(False)
            Me.BorrowerDetailsTabPage.PerformLayout()
            Me.BorrowerLoansTabPage.ResumeLayout(False)
            Me.BorrowerLoansTabPage.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.BorrowerInLoansDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.BorrowerDetailsStatusStrip.ResumeLayout(False)
            Me.BorrowerDetailsStatusStrip.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents BorrowerTabControl As TabControl
        Friend WithEvents BorrowerDetailsTabPage As TabPage
        Friend WithEvents BorrowerLoansTabPage As TabPage
        Friend WithEvents BorrowerInLoansDataGridView As DataGridView
        Friend WithEvents CloseButton As Button
        Friend WithEvents BorrowerDetailsStatusStrip As StatusStrip
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents ReturnBookButton As Button
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents BorrowerDetailsToolStripStatusLabel As ToolStripStatusLabel
        Friend WithEvents BorrowerFullNameTextBox As TextBox
        Friend WithEvents BorrowerDetailLabel As Label
        Friend WithEvents BorrowerIDTextBox As TextBox
        Friend WithEvents BorrowerIDLabel As Label
    End Class
End Namespace