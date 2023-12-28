Imports System.Configuration
Imports Prolipol.Formacao.Dapper
Imports Prolipol.Formacao.Dapper.Repositories
Imports Prolipol.Formacao.Domain.Events
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models
Imports Prolipol.Formacao.Domain.Services

Module Program
    Private _bookRepository As IBookRepository
    Private _borrowerRepository As IBorrowerRepository
    Private _loanRepository As ILoanRepository
    Private _bookService As IBookService
    Private _borrowerService As IBorrowerService
    Private _loanService As ILoanService
    Private _reportService As IReportService

    Sub Main()
        ' Initialize all the settings
        Initialize()
        Try
            ' Create book intances
            Dim book1 = New Book("Introduction to Module 4 of VB.NET", "Alfredo Dambi")
            Dim book2 = New Book("Introduction to Module 3 of C#.NET", "ALfredo Dambi")

            ' Register books
            '_bookService.AddBook(book1)
            '_bookService.AddBook(book2)

            ' Create borrower instances
            Dim borrower1 = New Borrower("Jon Doe")
            Dim borrower2 = New Borrower("Jane Smith")

            ' Register borrowers
            '_borrowerService.RegisterBorrower(borrower1)
            '_borrowerService.RegisterBorrower(borrower2)

            Dim bk1 = _bookService.GetBook(1)
            Dim brw1 = _borrowerService.GetBorrower(1)

            Dim bk2 = _bookService.GetBook(2)
            Dim brw2 = _borrowerService.GetBorrower(2)

            ' Register loans
            '_loanService.LoanBook(bk1, brw1, New Date(2023, 4, 17), New Date(2023, 5, 17))
            '_loanService.LoanBook(bk2, brw2, New Date(2023, 5, 16), New Date(2023, 6, 16))


            Dim borrowers = _borrowerService.GetBorrowers()

            ' Check if the borrower collection was affected after the loan
            'PrintBorrowersLoans(borrowers)

            ' Return all the books
            'ReturnBooks()

            ' Check if the borrowe collection was affected after the return
            'PrintBorrowersLoans(borrowers)

            ' Print after reports
            PrintAvailableBooksReport()
            PrintAllLoansReport()
            PrintOverdueLoansReport()
        Catch ex As Exception
            ' Log the exception
            Console.WriteLine($"Erro: {ex.Message}")

            ' Handle the exception
        Finally
            QuitPromp()
        End Try
    End Sub

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
        RegisterEvents()
    End Sub

    Private Sub PrintBorrowersLoans(borrowers As IEnumerable(Of Borrower))
        ' Check if the borrower collection was affected after the loan
        For Each borrower In borrowers
            For Each loan In borrower.Loans.AsEnumerable()
                Dim isAvailable = If(loan.Book.IsAvailable, "Available", "Not Available")
                Dim returned = If(loan.ReturnedOn.HasValue(), "returned", "pending")
                Console.WriteLine($"Book: {loan.Book.Title} [{isAvailable}], Borrower: {borrower.Name} [{returned}]")
            Next
        Next
    End Sub

    Private Sub ReturnBooks()
        Dim loans = _loanService.GetLoans()

        ' Returning the books
        For Each loan In loans
            If loan.ReturnedOn.HasValue Then
                Continue For
            End If
            _loanService.ReturnBook(loan, New Date(2023, 5, 21))
            'Exit For
        Next
    End Sub

    Private Sub RegisterEvents()
        AddHandler _bookService.BookAdded, AddressOf OnBookAdded
        AddHandler _borrowerService.BorrowerAdded, AddressOf OnBorrowerAdded
        AddHandler _loanService.BookBorrowed, AddressOf OnBookBorrowed
        AddHandler _loanService.BorrowFailed, AddressOf OnBorrowFailed
        AddHandler _loanService.BookReturned, AddressOf OnBookReturned
        AddHandler _loanService.BookReturnFailed, AddressOf OnBookReturnFailed
    End Sub

    Private Sub OnBookReturnFailed(sender As Object, e As BookReturnFailedEventArgs)
        Console.WriteLine($"Book return failed: {e.Loan.Book.Title} from {e.Loan.Borrower.Name}")
    End Sub

    Private Sub OnBookReturned(sender As Object, e As BookReturnedEventArgs)
        Console.WriteLine($"Book has been returned: {e.Loan.Book.Title} from {e.Loan.Borrower.Name} on {FormatDateTime(e.Loan.ReturnedOn.Value, DateFormat.ShortDate)}")
    End Sub

    Private Sub OnBorrowFailed(sender As Object, e As BorrowFailedEventArgs)
        Console.WriteLine($"Borrow failed: {e.Book.Title} to {e.Borrower.Name}")
    End Sub

    Private Sub OnBookBorrowed(sender As Object, e As BookBorrowedEventArgs)
        Console.WriteLine($"Book loaned: {e.Book.Title} to {e.Borrower.Name}")
    End Sub

    Private Sub OnBorrowerAdded(sender As Object, e As BorrowerAddedEventArgs)
        Console.WriteLine($"New borrower added: {e.Borrower.Name}")
    End Sub

    Private Sub OnBookAdded(sender As Object, e As BookAddedEventArgs)
        Console.WriteLine($"New book added: {e.Book.Title}")
    End Sub

    Private Sub PrintAvailableBooksReport()
        Dim availableBooksReport = _reportService.GenerateAvailableBooksReport()
        For Each line In availableBooksReport
            Console.WriteLine(line)
        Next
    End Sub

    Private Sub PrintAllLoansReport()
        Dim allLoansReport = _reportService.GenerateLoansReport()
        For Each line In allLoansReport
            Console.WriteLine(line)
        Next
    End Sub

    Private Sub PrintOverdueLoansReport()
        Dim overdueLoansReport = _reportService.GenerateOverdueLoansReport()
        For Each line In overdueLoansReport
            Console.WriteLine(line)
        Next
    End Sub

    Private Sub QuitPromp()
        Console.Write(vbCrLf & "Pressione qualquer tecla para sair.")
        Console.ReadKey()
    End Sub
End Module
