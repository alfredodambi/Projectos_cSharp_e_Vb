<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookDetailsView
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.isAvailableBookCheckBox = New System.Windows.Forms.CheckBox()
        Me.authorBookTextBox = New System.Windows.Forms.TextBox()
        Me.nameBookTextBox = New System.Windows.Forms.TextBox()
        Me.idBookTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReturnBookButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.BookToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CloseBookDetailsButton = New System.Windows.Forms.Button()
        Me.BookInLoanDatagridView = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BookInLoanDatagridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(523, 254)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.isAvailableBookCheckBox)
        Me.TabPage1.Controls.Add(Me.authorBookTextBox)
        Me.TabPage1.Controls.Add(Me.nameBookTextBox)
        Me.TabPage1.Controls.Add(Me.idBookTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(515, 228)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Is Available"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Author Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Book Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id"
        '
        'isAvailableBookCheckBox
        '
        Me.isAvailableBookCheckBox.AutoSize = True
        Me.isAvailableBookCheckBox.Enabled = False
        Me.isAvailableBookCheckBox.Location = New System.Drawing.Point(84, 143)
        Me.isAvailableBookCheckBox.Name = "isAvailableBookCheckBox"
        Me.isAvailableBookCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.isAvailableBookCheckBox.TabIndex = 3
        Me.isAvailableBookCheckBox.UseVisualStyleBackColor = True
        '
        'authorBookTextBox
        '
        Me.authorBookTextBox.Enabled = False
        Me.authorBookTextBox.Location = New System.Drawing.Point(84, 106)
        Me.authorBookTextBox.Name = "authorBookTextBox"
        Me.authorBookTextBox.ReadOnly = True
        Me.authorBookTextBox.Size = New System.Drawing.Size(410, 20)
        Me.authorBookTextBox.TabIndex = 2
        '
        'nameBookTextBox
        '
        Me.nameBookTextBox.Enabled = False
        Me.nameBookTextBox.Location = New System.Drawing.Point(84, 70)
        Me.nameBookTextBox.Name = "nameBookTextBox"
        Me.nameBookTextBox.ReadOnly = True
        Me.nameBookTextBox.Size = New System.Drawing.Size(410, 20)
        Me.nameBookTextBox.TabIndex = 1
        '
        'idBookTextBox
        '
        Me.idBookTextBox.Enabled = False
        Me.idBookTextBox.Location = New System.Drawing.Point(84, 33)
        Me.idBookTextBox.Name = "idBookTextBox"
        Me.idBookTextBox.ReadOnly = True
        Me.idBookTextBox.Size = New System.Drawing.Size(410, 20)
        Me.idBookTextBox.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BookInLoanDatagridView)
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(515, 228)
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 193)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 29)
        Me.TableLayoutPanel2.TabIndex = 2
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 305)
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
        'CloseBookDetailsButton
        '
        Me.CloseBookDetailsButton.Location = New System.Drawing.Point(456, 272)
        Me.CloseBookDetailsButton.Name = "CloseBookDetailsButton"
        Me.CloseBookDetailsButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseBookDetailsButton.TabIndex = 2
        Me.CloseBookDetailsButton.Text = "&Close"
        Me.CloseBookDetailsButton.UseVisualStyleBackColor = True
        '
        'BookInLoanDatagridView
        '
        Me.BookInLoanDatagridView.AllowUserToAddRows = False
        Me.BookInLoanDatagridView.AllowUserToDeleteRows = False
        Me.BookInLoanDatagridView.AllowUserToResizeRows = False
        Me.BookInLoanDatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BookInLoanDatagridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.BookInLoanDatagridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BookInLoanDatagridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BookInLoanDatagridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BookInLoanDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookInLoanDatagridView.EnableHeadersVisualStyles = False
        Me.BookInLoanDatagridView.GridColor = System.Drawing.SystemColors.Window
        Me.BookInLoanDatagridView.Location = New System.Drawing.Point(3, 3)
        Me.BookInLoanDatagridView.MultiSelect = False
        Me.BookInLoanDatagridView.Name = "BookInLoanDatagridView"
        Me.BookInLoanDatagridView.ReadOnly = True
        Me.BookInLoanDatagridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BookInLoanDatagridView.RowHeadersVisible = False
        Me.BookInLoanDatagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BookInLoanDatagridView.ShowCellErrors = False
        Me.BookInLoanDatagridView.ShowCellToolTips = False
        Me.BookInLoanDatagridView.ShowEditingIcon = False
        Me.BookInLoanDatagridView.ShowRowErrors = False
        Me.BookInLoanDatagridView.Size = New System.Drawing.Size(506, 184)
        Me.BookInLoanDatagridView.TabIndex = 3
        '
        'BookDetailsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(547, 327)
        Me.Controls.Add(Me.CloseBookDetailsButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "BookDetailsView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details Of The Book"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BookInLoanDatagridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents CloseBookDetailsButton As Button
    Friend WithEvents idBookTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents isAvailableBookCheckBox As CheckBox
    Friend WithEvents authorBookTextBox As TextBox
    Friend WithEvents nameBookTextBox As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ReturnBookButton As Button
    Friend WithEvents BookToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents BookInLoanDatagridView As DataGridView
End Class
