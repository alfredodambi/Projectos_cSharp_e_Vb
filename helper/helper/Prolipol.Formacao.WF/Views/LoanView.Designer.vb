<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LoanStatusToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchBorrowerNameTextBox = New System.Windows.Forms.TextBox()
        Me.SearchBookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.SearchIdLoanTextBox = New System.Windows.Forms.TextBox()
        Me.ViewDetailsLoanButton = New System.Windows.Forms.Button()
        Me.CloseLoanButton = New System.Windows.Forms.Button()
        Me.SearchLoanButton = New System.Windows.Forms.Button()
        Me.EditLoanButton = New System.Windows.Forms.Button()
        Me.DeleteLoanButton = New System.Windows.Forms.Button()
        Me.loansDataGridView = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.loansDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanStatusToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 360)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(555, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LoanStatusToolStripStatusLabel
        '
        Me.LoanStatusToolStripStatusLabel.Name = "LoanStatusToolStripStatusLabel"
        Me.LoanStatusToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SearchBorrowerNameTextBox)
        Me.GroupBox1.Controls.Add(Me.SearchBookTitleTextBox)
        Me.GroupBox1.Controls.Add(Me.SearchIdLoanTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 83)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Loan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Borrower Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Book Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Id"
        '
        'SearchBorrowerNameTextBox
        '
        Me.SearchBorrowerNameTextBox.Location = New System.Drawing.Point(260, 45)
        Me.SearchBorrowerNameTextBox.Name = "SearchBorrowerNameTextBox"
        Me.SearchBorrowerNameTextBox.Size = New System.Drawing.Size(171, 20)
        Me.SearchBorrowerNameTextBox.TabIndex = 2
        '
        'SearchBookTitleTextBox
        '
        Me.SearchBookTitleTextBox.Location = New System.Drawing.Point(83, 45)
        Me.SearchBookTitleTextBox.Name = "SearchBookTitleTextBox"
        Me.SearchBookTitleTextBox.Size = New System.Drawing.Size(171, 20)
        Me.SearchBookTitleTextBox.TabIndex = 1
        '
        'SearchIdLoanTextBox
        '
        Me.SearchIdLoanTextBox.Location = New System.Drawing.Point(18, 45)
        Me.SearchIdLoanTextBox.Name = "SearchIdLoanTextBox"
        Me.SearchIdLoanTextBox.Size = New System.Drawing.Size(57, 20)
        Me.SearchIdLoanTextBox.TabIndex = 0
        '
        'ViewDetailsLoanButton
        '
        Me.ViewDetailsLoanButton.Location = New System.Drawing.Point(12, 329)
        Me.ViewDetailsLoanButton.Name = "ViewDetailsLoanButton"
        Me.ViewDetailsLoanButton.Size = New System.Drawing.Size(75, 23)
        Me.ViewDetailsLoanButton.TabIndex = 3
        Me.ViewDetailsLoanButton.Text = "View Details"
        Me.ViewDetailsLoanButton.UseVisualStyleBackColor = True
        '
        'CloseLoanButton
        '
        Me.CloseLoanButton.Location = New System.Drawing.Point(468, 329)
        Me.CloseLoanButton.Name = "CloseLoanButton"
        Me.CloseLoanButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseLoanButton.TabIndex = 4
        Me.CloseLoanButton.Text = "Close"
        Me.CloseLoanButton.UseVisualStyleBackColor = True
        '
        'SearchLoanButton
        '
        Me.SearchLoanButton.Location = New System.Drawing.Point(468, 21)
        Me.SearchLoanButton.Name = "SearchLoanButton"
        Me.SearchLoanButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchLoanButton.TabIndex = 5
        Me.SearchLoanButton.Text = "Search"
        Me.SearchLoanButton.UseVisualStyleBackColor = True
        '
        'EditLoanButton
        '
        Me.EditLoanButton.Location = New System.Drawing.Point(95, 329)
        Me.EditLoanButton.Name = "EditLoanButton"
        Me.EditLoanButton.Size = New System.Drawing.Size(75, 23)
        Me.EditLoanButton.TabIndex = 6
        Me.EditLoanButton.Text = "Edit"
        Me.EditLoanButton.UseVisualStyleBackColor = True
        '
        'DeleteLoanButton
        '
        Me.DeleteLoanButton.Location = New System.Drawing.Point(176, 329)
        Me.DeleteLoanButton.Name = "DeleteLoanButton"
        Me.DeleteLoanButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteLoanButton.TabIndex = 7
        Me.DeleteLoanButton.Text = "Delete"
        Me.DeleteLoanButton.UseVisualStyleBackColor = True
        '
        'loansDataGridView
        '
        Me.loansDataGridView.AllowUserToAddRows = False
        Me.loansDataGridView.AllowUserToDeleteRows = False
        Me.loansDataGridView.AllowUserToResizeRows = False
        Me.loansDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loansDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.loansDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.loansDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.loansDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.loansDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.loansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.loansDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.loansDataGridView.EnableHeadersVisualStyles = False
        Me.loansDataGridView.GridColor = System.Drawing.SystemColors.Window
        Me.loansDataGridView.Location = New System.Drawing.Point(12, 102)
        Me.loansDataGridView.Name = "loansDataGridView"
        Me.loansDataGridView.ReadOnly = True
        Me.loansDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.loansDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.loansDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(2)
        Me.loansDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.loansDataGridView.RowTemplate.ReadOnly = True
        Me.loansDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.loansDataGridView.ShowCellErrors = False
        Me.loansDataGridView.ShowCellToolTips = False
        Me.loansDataGridView.ShowEditingIcon = False
        Me.loansDataGridView.ShowRowErrors = False
        Me.loansDataGridView.Size = New System.Drawing.Size(531, 221)
        Me.loansDataGridView.TabIndex = 8
        '
        'LoanView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 382)
        Me.Controls.Add(Me.loansDataGridView)
        Me.Controls.Add(Me.DeleteLoanButton)
        Me.Controls.Add(Me.EditLoanButton)
        Me.Controls.Add(Me.SearchLoanButton)
        Me.Controls.Add(Me.CloseLoanButton)
        Me.Controls.Add(Me.ViewDetailsLoanButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "LoanView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Manage"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.loansDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchBorrowerNameTextBox As TextBox
    Friend WithEvents SearchBookTitleTextBox As TextBox
    Friend WithEvents SearchIdLoanTextBox As TextBox
    Friend WithEvents ViewDetailsLoanButton As Button
    Friend WithEvents CloseLoanButton As Button
    Friend WithEvents SearchLoanButton As Button
    Friend WithEvents LoanStatusToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents EditLoanButton As Button
    Friend WithEvents DeleteLoanButton As Button
    Friend WithEvents loansDataGridView As DataGridView
End Class
