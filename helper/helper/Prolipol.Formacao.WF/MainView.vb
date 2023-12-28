Imports System.ComponentModel
Imports System.Configuration
Imports Prolipol.Formacao.Dapper
Imports Prolipol.Formacao.Dapper.Repositories
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Services
Imports Prolipol.Formacao.WF.Views

Public Class MainView
    <Browsable(False)>
    Public Shadows Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = Me.Font
        End Set
    End Property

    '
    Private _bookRepository As IBookRepository
    Private _borrowerRepository As IBorrowerRepository
    Private _loanRepository As ILoanRepository
    Private _bookService As IBookService
    Private _borrowerService As IBorrowerService
    Private _loanService As ILoanService
    Private _reportService As IReportService

    Private Sub MainView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
        GetBookCount()
        GetBorrowerCount()
        GetLoanCount()
        StatusToolStripStatusLabel.Text = "Finish!"
    End Sub

    ''' <summary>
    ''' To Initialize the services, repository and the connection db
    ''' </summary>
    Private Sub Initialize()
        ' Initialize the connection string from the configuration
        Dim connectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
        Dim databaseCreationScript = "DatabaseCreationScript.sql"

        Dim databaseInitializer As IDatabaseInitializer = New DatabaseInitializer(connectionString, databaseCreationScript)

        databaseInitializer.InitializeDatebase()

        ' Initialize the factory
        Dim dataAccessFactory = New DapperDataAccessFactory(connectionString)

        ' Initializing the repositories
        _bookRepository = New BookRepository(dataAccessFactory)
        _borrowerRepository = New BorrowerRepository(dataAccessFactory)
        _loanRepository = New LoanRepository(dataAccessFactory)

        ' Initializing the services
        _bookService = New BookService(_bookRepository)
        _borrowerService = New BorrowerService(_borrowerRepository)
        _loanService = New LoanService(_bookService, _borrowerService, _loanRepository)
        _reportService = New ReportService(_bookService, _borrowerService, _loanService)

        ' Subscribe to events


    End Sub

    ''' <summary>
    ''' Open the form to register new book
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddNewBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewBookViewToolStripMenuItem.Click
        Dim newBookView = New NewBookView(_bookService, AddressOf GetBookCount)
        newBookView.Show(Me)
    End Sub

    ''' <summary>
    ''' Open the form to manage a book
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ViewBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBooksToolStripMenuItem.Click
        Dim viewBook = New BookView(_bookService, _loanService, AddressOf GetBookCount)
        viewBook.Show(Me)
    End Sub

    ''' <summary>
    ''' Open the form to add a new borower
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddNewBorrowersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewBorrowersToolStripMenuItem.Click
        Dim newBorrowerView = New NewBorrowerView(_borrowerService, AddressOf GetBorrowerCount)
        newBorrowerView.Show(Me)
    End Sub

    ''' <summary>
    ''' Open thE form to manage a borrower
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ViewBorrowersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBorrowersToolStripMenuItem.Click
        Dim borrowersView = New BorrowersView(_borrowerService, _loanService, AddressOf GetBorrowerCount)
        borrowersView.Show(Me)
    End Sub

    ''' <summary>
    ''' Open the form to register a new Loan
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddNewLoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewLoanToolStripMenuItem.Click
        Dim newLoanView = New NewLoanView(_bookService, _borrowerService, _loanService, AddressOf GetLoanCount)
        newLoanView.Show(Me)
    End Sub

    ''' <summary>
    ''' Open the form to manage loans
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ViewLoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLoanToolStripMenuItem.Click
        Dim viewLoan = New LoanView(_loanService, AddressOf GetLoanCount)
        viewLoan.Show(Me)
    End Sub

    ''' <summary>
    ''' Open the form to see loans Reports
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LoansReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoansReportToolStripMenuItem.Click
        Dim loanReportView = New LoanReportView(_loanService)
        loanReportView.Show(Me)
    End Sub

    ''' <summary>
    ''' Open the form to see books reports
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BooksReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BooksReportToolStripMenuItem.Click
        Dim bookReportView = New BookReportView(_bookService)
        bookReportView.Show(Me)
    End Sub

    ''' <summary>
    ''' Open the form to see borrowers Reports
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BorrowersReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowersReportToolStripMenuItem.Click
        Dim borrowerReportView = New BorrowerReportView(_borrowerService)
        borrowerReportView.Show(Me)
    End Sub

    ''' <summary>
    ''' To show the total of a book registed
    ''' </summary>
    Private Sub GetBookCount()
        Dim bookCount = _bookService.GetBooks().Count()
        bookCountLabel.Text = bookCount
    End Sub

    ''' <summary>
    ''' To Show the total of a borrower registed on the system
    ''' </summary>
    Private Sub GetBorrowerCount()
        Dim borrowerCount = _borrowerService.GetBorrowers().Count()
        borrowersCountLabel.Text = borrowerCount
    End Sub

    ''' <summary>
    ''' To show the total of a loan registed
    ''' </summary>
    Private Sub GetLoanCount()
        Dim loanCount = _loanService.GetLoans().Count()
        loanCountLabel.Text = loanCount
    End Sub
End Class
