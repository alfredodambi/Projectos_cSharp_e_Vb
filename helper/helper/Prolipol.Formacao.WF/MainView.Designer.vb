<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainView
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainView))
        Me.loanCountLabel = New System.Windows.Forms.Label()
        Me.borrowersCountLabel = New System.Windows.Forms.Label()
        Me.bookCountLabel = New System.Windows.Forms.Label()
        Me.lbl_ActiveLoans = New System.Windows.Forms.Label()
        Me.lbl_RegisteredBorrowers = New System.Windows.Forms.Label()
        Me.lbl_AvailableBooks = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AddNewBookViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AddNewBorrowersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBorrowersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AddNewLoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LoansReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowersReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'loanCountLabel
        '
        Me.loanCountLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loanCountLabel.AutoSize = True
        Me.loanCountLabel.Location = New System.Drawing.Point(155, 63)
        Me.loanCountLabel.Name = "loanCountLabel"
        Me.loanCountLabel.Size = New System.Drawing.Size(14, 15)
        Me.loanCountLabel.TabIndex = 5
        Me.loanCountLabel.Text = "0"
        Me.loanCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'borrowersCountLabel
        '
        Me.borrowersCountLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.borrowersCountLabel.AutoSize = True
        Me.borrowersCountLabel.Location = New System.Drawing.Point(155, 63)
        Me.borrowersCountLabel.Name = "borrowersCountLabel"
        Me.borrowersCountLabel.Size = New System.Drawing.Size(14, 15)
        Me.borrowersCountLabel.TabIndex = 4
        Me.borrowersCountLabel.Text = "0"
        Me.borrowersCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bookCountLabel
        '
        Me.bookCountLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookCountLabel.AutoSize = True
        Me.bookCountLabel.Location = New System.Drawing.Point(158, 63)
        Me.bookCountLabel.Name = "bookCountLabel"
        Me.bookCountLabel.Size = New System.Drawing.Size(14, 15)
        Me.bookCountLabel.TabIndex = 3
        Me.bookCountLabel.Text = "0"
        Me.bookCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_ActiveLoans
        '
        Me.lbl_ActiveLoans.AutoSize = True
        Me.lbl_ActiveLoans.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lbl_ActiveLoans.Location = New System.Drawing.Point(68, 13)
        Me.lbl_ActiveLoans.Name = "lbl_ActiveLoans"
        Me.lbl_ActiveLoans.Size = New System.Drawing.Size(101, 17)
        Me.lbl_ActiveLoans.TabIndex = 2
        Me.lbl_ActiveLoans.Text = "Active Loans"
        '
        'lbl_RegisteredBorrowers
        '
        Me.lbl_RegisteredBorrowers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegisteredBorrowers.AutoSize = True
        Me.lbl_RegisteredBorrowers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lbl_RegisteredBorrowers.Location = New System.Drawing.Point(88, 13)
        Me.lbl_RegisteredBorrowers.Name = "lbl_RegisteredBorrowers"
        Me.lbl_RegisteredBorrowers.Size = New System.Drawing.Size(81, 17)
        Me.lbl_RegisteredBorrowers.TabIndex = 1
        Me.lbl_RegisteredBorrowers.Text = "Borrowers"
        '
        'lbl_AvailableBooks
        '
        Me.lbl_AvailableBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_AvailableBooks.AutoSize = True
        Me.lbl_AvailableBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lbl_AvailableBooks.Location = New System.Drawing.Point(120, 13)
        Me.lbl_AvailableBooks.Name = "lbl_AvailableBooks"
        Me.lbl_AvailableBooks.Size = New System.Drawing.Size(52, 17)
        Me.lbl_AvailableBooks.TabIndex = 0
        Me.lbl_AvailableBooks.Text = "Books"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.ToolStripDropDownButton2, Me.ToolStripSeparator2, Me.ToolStripDropDownButton3, Me.ToolStripSeparator3, Me.ToolStripDropDownButton4, Me.ToolStripSeparator4, Me.HelpToolStripButton, Me.ToolStripSeparator5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(666, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewBookViewToolStripMenuItem, Me.ViewBooksToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripDropDownButton1.Text = "Books"
        '
        'AddNewBookViewToolStripMenuItem
        '
        Me.AddNewBookViewToolStripMenuItem.Image = CType(resources.GetObject("AddNewBookViewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddNewBookViewToolStripMenuItem.Name = "AddNewBookViewToolStripMenuItem"
        Me.AddNewBookViewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewBookViewToolStripMenuItem.Text = "Add New Book"
        Me.AddNewBookViewToolStripMenuItem.ToolTipText = "Add New Book"
        '
        'ViewBooksToolStripMenuItem
        '
        Me.ViewBooksToolStripMenuItem.Image = CType(resources.GetObject("ViewBooksToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewBooksToolStripMenuItem.Name = "ViewBooksToolStripMenuItem"
        Me.ViewBooksToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewBooksToolStripMenuItem.Text = "View Book"
        Me.ViewBooksToolStripMenuItem.ToolTipText = "View Book"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewBorrowersToolStripMenuItem, Me.ViewBorrowersToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripDropDownButton2.Text = "Borrowers"
        '
        'AddNewBorrowersToolStripMenuItem
        '
        Me.AddNewBorrowersToolStripMenuItem.Image = CType(resources.GetObject("AddNewBorrowersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddNewBorrowersToolStripMenuItem.Name = "AddNewBorrowersToolStripMenuItem"
        Me.AddNewBorrowersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewBorrowersToolStripMenuItem.Text = "Add New Borrowers"
        Me.AddNewBorrowersToolStripMenuItem.ToolTipText = "Add New Borrowers"
        '
        'ViewBorrowersToolStripMenuItem
        '
        Me.ViewBorrowersToolStripMenuItem.Image = CType(resources.GetObject("ViewBorrowersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewBorrowersToolStripMenuItem.Name = "ViewBorrowersToolStripMenuItem"
        Me.ViewBorrowersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewBorrowersToolStripMenuItem.Text = "View Borrowers"
        Me.ViewBorrowersToolStripMenuItem.ToolTipText = "View Borrowers"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewLoanToolStripMenuItem, Me.ViewLoanToolStripMenuItem})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripDropDownButton3.Text = "Loans"
        '
        'AddNewLoanToolStripMenuItem
        '
        Me.AddNewLoanToolStripMenuItem.Image = CType(resources.GetObject("AddNewLoanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddNewLoanToolStripMenuItem.Name = "AddNewLoanToolStripMenuItem"
        Me.AddNewLoanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewLoanToolStripMenuItem.Text = "Add New Loan"
        Me.AddNewLoanToolStripMenuItem.ToolTipText = "Add New Loan"
        '
        'ViewLoanToolStripMenuItem
        '
        Me.ViewLoanToolStripMenuItem.Image = CType(resources.GetObject("ViewLoanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewLoanToolStripMenuItem.Name = "ViewLoanToolStripMenuItem"
        Me.ViewLoanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewLoanToolStripMenuItem.Text = "View Loan"
        Me.ViewLoanToolStripMenuItem.ToolTipText = "View Loan"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton4
        '
        Me.ToolStripDropDownButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoansReportToolStripMenuItem, Me.BooksReportToolStripMenuItem, Me.BorrowersReportToolStripMenuItem})
        Me.ToolStripDropDownButton4.Image = CType(resources.GetObject("ToolStripDropDownButton4.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton4.Name = "ToolStripDropDownButton4"
        Me.ToolStripDropDownButton4.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripDropDownButton4.Text = "Report"
        '
        'LoansReportToolStripMenuItem
        '
        Me.LoansReportToolStripMenuItem.Image = CType(resources.GetObject("LoansReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoansReportToolStripMenuItem.Name = "LoansReportToolStripMenuItem"
        Me.LoansReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoansReportToolStripMenuItem.Text = "Loans"
        Me.LoansReportToolStripMenuItem.ToolTipText = "Loans Reports"
        '
        'BooksReportToolStripMenuItem
        '
        Me.BooksReportToolStripMenuItem.Image = CType(resources.GetObject("BooksReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BooksReportToolStripMenuItem.Name = "BooksReportToolStripMenuItem"
        Me.BooksReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BooksReportToolStripMenuItem.Text = "Books"
        Me.BooksReportToolStripMenuItem.ToolTipText = "Books Report"
        '
        'BorrowersReportToolStripMenuItem
        '
        Me.BorrowersReportToolStripMenuItem.Image = CType(resources.GetObject("BorrowersReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BorrowersReportToolStripMenuItem.Name = "BorrowersReportToolStripMenuItem"
        Me.BorrowersReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BorrowersReportToolStripMenuItem.Text = "Borrowers"
        Me.BorrowersReportToolStripMenuItem.ToolTipText = "Borrowers Report"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "Help"
        Me.HelpToolStripButton.ToolTipText = "Help"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(666, 150)
        Me.Panel2.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lbl_RegisteredBorrowers)
        Me.Panel4.Controls.Add(Me.borrowersCountLabel)
        Me.Panel4.Location = New System.Drawing.Point(232, 35)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(189, 100)
        Me.Panel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.loanCountLabel)
        Me.Panel5.Controls.Add(Me.lbl_ActiveLoans)
        Me.Panel5.Location = New System.Drawing.Point(454, 35)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(189, 100)
        Me.Panel5.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbl_AvailableBooks)
        Me.Panel3.Controls.Add(Me.bookCountLabel)
        Me.Panel3.Location = New System.Drawing.Point(12, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(189, 100)
        Me.Panel3.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 498)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(666, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusToolStripStatusLabel
        '
        Me.StatusToolStripStatusLabel.Name = "StatusToolStripStatusLabel"
        Me.StatusToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'MainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(666, 520)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libray System"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_ActiveLoans As Label
    Friend WithEvents lbl_RegisteredBorrowers As Label
    Friend WithEvents lbl_AvailableBooks As Label
    Friend WithEvents loanCountLabel As Label
    Friend WithEvents borrowersCountLabel As Label
    Friend WithEvents bookCountLabel As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents AddNewBookViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents AddNewBorrowersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBorrowersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AddNewLoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewLoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton4 As ToolStripDropDownButton
    Friend WithEvents LoansReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowersReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
End Class
