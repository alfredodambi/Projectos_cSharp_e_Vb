<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanReportView
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ReportLoanToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrintLoanReportButton = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrintOverduoLoanButton = New System.Windows.Forms.Button()
        Me.LoanReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.OverduoLoanReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LoanReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OverduoLoanReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportLoanToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 316)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(547, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ReportLoanToolStripStatusLabel
        '
        Me.ReportLoanToolStripStatusLabel.Name = "ReportLoanToolStripStatusLabel"
        Me.ReportLoanToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(523, 301)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LoanReportDataGridView)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(515, 275)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Loan Report"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.PrintLoanReportButton, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 240)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 29)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'PrintLoanReportButton
        '
        Me.PrintLoanReportButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PrintLoanReportButton.Location = New System.Drawing.Point(3, 3)
        Me.PrintLoanReportButton.Name = "PrintLoanReportButton"
        Me.PrintLoanReportButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintLoanReportButton.TabIndex = 1
        Me.PrintLoanReportButton.Text = "Print"
        Me.PrintLoanReportButton.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.OverduoLoanReportDataGridView)
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(515, 275)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Overduo Loan Report"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.PrintOverduoLoanButton, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 240)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 29)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'PrintOverduoLoanButton
        '
        Me.PrintOverduoLoanButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PrintOverduoLoanButton.Location = New System.Drawing.Point(3, 3)
        Me.PrintOverduoLoanButton.Name = "PrintOverduoLoanButton"
        Me.PrintOverduoLoanButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintOverduoLoanButton.TabIndex = 1
        Me.PrintOverduoLoanButton.Text = "Print"
        Me.PrintOverduoLoanButton.UseVisualStyleBackColor = True
        '
        'LoanReportDataGridView
        '
        Me.LoanReportDataGridView.AllowUserToAddRows = False
        Me.LoanReportDataGridView.AllowUserToDeleteRows = False
        Me.LoanReportDataGridView.AllowUserToResizeRows = False
        Me.LoanReportDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoanReportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LoanReportDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.LoanReportDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.LoanReportDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LoanReportDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.LoanReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LoanReportDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.LoanReportDataGridView.EnableHeadersVisualStyles = False
        Me.LoanReportDataGridView.GridColor = System.Drawing.SystemColors.Window
        Me.LoanReportDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.LoanReportDataGridView.Name = "LoanReportDataGridView"
        Me.LoanReportDataGridView.ReadOnly = True
        Me.LoanReportDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LoanReportDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.LoanReportDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(2)
        Me.LoanReportDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.LoanReportDataGridView.RowTemplate.ReadOnly = True
        Me.LoanReportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LoanReportDataGridView.ShowCellErrors = False
        Me.LoanReportDataGridView.ShowCellToolTips = False
        Me.LoanReportDataGridView.ShowEditingIcon = False
        Me.LoanReportDataGridView.ShowRowErrors = False
        Me.LoanReportDataGridView.Size = New System.Drawing.Size(503, 228)
        Me.LoanReportDataGridView.TabIndex = 9
        '
        'OverduoLoanReportDataGridView
        '
        Me.OverduoLoanReportDataGridView.AllowUserToAddRows = False
        Me.OverduoLoanReportDataGridView.AllowUserToDeleteRows = False
        Me.OverduoLoanReportDataGridView.AllowUserToResizeRows = False
        Me.OverduoLoanReportDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OverduoLoanReportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OverduoLoanReportDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.OverduoLoanReportDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.OverduoLoanReportDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OverduoLoanReportDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.OverduoLoanReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OverduoLoanReportDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.OverduoLoanReportDataGridView.EnableHeadersVisualStyles = False
        Me.OverduoLoanReportDataGridView.GridColor = System.Drawing.SystemColors.Window
        Me.OverduoLoanReportDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.OverduoLoanReportDataGridView.Name = "OverduoLoanReportDataGridView"
        Me.OverduoLoanReportDataGridView.ReadOnly = True
        Me.OverduoLoanReportDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OverduoLoanReportDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.OverduoLoanReportDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(2)
        Me.OverduoLoanReportDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.OverduoLoanReportDataGridView.RowTemplate.ReadOnly = True
        Me.OverduoLoanReportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OverduoLoanReportDataGridView.ShowCellErrors = False
        Me.OverduoLoanReportDataGridView.ShowCellToolTips = False
        Me.OverduoLoanReportDataGridView.ShowEditingIcon = False
        Me.OverduoLoanReportDataGridView.ShowRowErrors = False
        Me.OverduoLoanReportDataGridView.Size = New System.Drawing.Size(503, 228)
        Me.OverduoLoanReportDataGridView.TabIndex = 10
        '
        'LoanReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 338)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LoanReportView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Report"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LoanReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OverduoLoanReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ReportLoanToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PrintLoanReportButton As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PrintOverduoLoanButton As Button
    Friend WithEvents LoanReportDataGridView As DataGridView
    Friend WithEvents OverduoLoanReportDataGridView As DataGridView
End Class
