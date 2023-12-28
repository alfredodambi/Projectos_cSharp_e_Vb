<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoanDetailsView
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExpiryLoanDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartLoanDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BookNameTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerNameTextBox = New System.Windows.Forms.TextBox()
        Me.IdLoanTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReturnBookButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LoanToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.loansDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.loansDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(523, 257)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ExpiryLoanDateTimePicker)
        Me.TabPage1.Controls.Add(Me.StartLoanDateTimePicker)
        Me.TabPage1.Controls.Add(Me.BookNameTextBox)
        Me.TabPage1.Controls.Add(Me.BorrowerNameTextBox)
        Me.TabPage1.Controls.Add(Me.IdLoanTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(515, 231)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Expiry Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Start Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Borrower Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Book Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Id"
        '
        'ExpiryLoanDateTimePicker
        '
        Me.ExpiryLoanDateTimePicker.Enabled = False
        Me.ExpiryLoanDateTimePicker.Location = New System.Drawing.Point(108, 171)
        Me.ExpiryLoanDateTimePicker.Name = "ExpiryLoanDateTimePicker"
        Me.ExpiryLoanDateTimePicker.Size = New System.Drawing.Size(389, 20)
        Me.ExpiryLoanDateTimePicker.TabIndex = 4
        '
        'StartLoanDateTimePicker
        '
        Me.StartLoanDateTimePicker.Enabled = False
        Me.StartLoanDateTimePicker.Location = New System.Drawing.Point(108, 134)
        Me.StartLoanDateTimePicker.Name = "StartLoanDateTimePicker"
        Me.StartLoanDateTimePicker.Size = New System.Drawing.Size(389, 20)
        Me.StartLoanDateTimePicker.TabIndex = 3
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.Enabled = False
        Me.BookNameTextBox.Location = New System.Drawing.Point(108, 68)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.ReadOnly = True
        Me.BookNameTextBox.Size = New System.Drawing.Size(389, 20)
        Me.BookNameTextBox.TabIndex = 2
        '
        'BorrowerNameTextBox
        '
        Me.BorrowerNameTextBox.Enabled = False
        Me.BorrowerNameTextBox.Location = New System.Drawing.Point(108, 101)
        Me.BorrowerNameTextBox.Name = "BorrowerNameTextBox"
        Me.BorrowerNameTextBox.ReadOnly = True
        Me.BorrowerNameTextBox.Size = New System.Drawing.Size(389, 20)
        Me.BorrowerNameTextBox.TabIndex = 1
        '
        'IdLoanTextBox
        '
        Me.IdLoanTextBox.Enabled = False
        Me.IdLoanTextBox.Location = New System.Drawing.Point(108, 30)
        Me.IdLoanTextBox.Name = "IdLoanTextBox"
        Me.IdLoanTextBox.ReadOnly = True
        Me.IdLoanTextBox.Size = New System.Drawing.Size(389, 20)
        Me.IdLoanTextBox.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.loansDataGridView)
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(515, 231)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Loan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.ReturnBookButton, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 196)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 29)
        Me.TableLayoutPanel2.TabIndex = 3
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
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 308)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(547, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LoanToolStripStatusLabel
        '
        Me.LoanToolStripStatusLabel.Name = "LoanToolStripStatusLabel"
        Me.LoanToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(460, 275)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
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
        Me.loansDataGridView.Location = New System.Drawing.Point(6, 5)
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
        Me.loansDataGridView.Size = New System.Drawing.Size(503, 185)
        Me.loansDataGridView.TabIndex = 9
        '
        'LoanDetailsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 330)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "LoanDetailsView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Details"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.loansDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents CloseButton As Button
    Friend WithEvents StartLoanDateTimePicker As DateTimePicker
    Friend WithEvents BookNameTextBox As TextBox
    Friend WithEvents BorrowerNameTextBox As TextBox
    Friend WithEvents IdLoanTextBox As TextBox
    Friend WithEvents ExpiryLoanDateTimePicker As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ReturnBookButton As Button
    Friend WithEvents LoanToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents loansDataGridView As DataGridView
End Class
