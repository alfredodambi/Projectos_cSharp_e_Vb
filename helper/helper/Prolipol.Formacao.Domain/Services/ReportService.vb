Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Namespace Services
    Public Class ReportService
        Implements IReportService

        Private ReadOnly _bookService As IBookService
        Private ReadOnly _borrowerService As IBorrowerService
        Private ReadOnly _loanService As ILoanService

        Public Sub New(bookService As IBookService, borrowerService As IBorrowerService, loanService As ILoanService)
            _bookService = bookService
            _borrowerService = borrowerService
            _loanService = loanService
        End Sub

        Public Function GenerateAvailableBooksReport() As IEnumerable(Of String) Implements IReportService.GenerateAvailableBooksReport
            Dim report As New List(Of String)

            report.Add("===== Available Books Report =====" & vbCrLf)

            Dim foundBooks = _bookService.GetBooks()

            If foundBooks.Count() < 1 Then
                report.Add("No books found!")
            Else
                For Each book In foundBooks
                    report.Add($"Title: {book.Title}, Author: {book.Author}, Is Available: {If(book.IsAvailable, "Yes", "No")}")
                Next
            End If

            report.Add(vbCrLf)

            Return report
        End Function

        Public Function GenerateLoansReport() As IEnumerable(Of String) Implements IReportService.GenerateLoansReport
            Dim report As New List(Of String)

            report.Add("===== All Loans Report =====" & vbCrLf)

            Dim foundLoans = _loanService.GetLoans()

            If foundLoans.Count() < 1 Then
                report.Add("No loans found!")
            Else
                For Each loan In foundLoans
                    report.Add($"'{loan.Book.Title} by {loan.Book.Author}' ({loan.Borrower.Name}) - from {FormatDateTime(loan.StartDate, DateFormat.ShortDate)} to {FormatDateTime(loan.ExpiryDate, DateFormat.ShortDate)} [{If(loan.ReturnedOn.HasValue(), "returned", "pending")}]")
                Next
            End If

            report.Add(vbCrLf)

            Return report
        End Function

        Public Function GenerateOverdueLoansReport() As IEnumerable(Of String) Implements IReportService.GenerateOverdueLoansReport
            Dim report As New List(Of String)

            Dim foundLoans = _loanService.GetLoans()

            ' watchout here, no check for foundLoans

            Dim overdueLoans As IEnumerable(Of Loan) = foundLoans.Where(Function(l) l.ExpiryDate <= Date.UtcNow()).ToList()

            report.Add("===== Overdue Loans Report =====" & vbCrLf)

            If overdueLoans.Count() < 1 Then
                report.Add("No overdue loans found!")
            Else
                For Each overdueLoan In overdueLoans
                    report.Add($"'{overdueLoan.Book.Title}, {overdueLoan.Book.Author}' ({overdueLoan.Borrower.Name}) - from {FormatDateTime(overdueLoan.StartDate, DateFormat.ShortDate)} to {FormatDateTime(overdueLoan.ExpiryDate, DateFormat.ShortDate)} [{If(overdueLoan.ReturnedOn.HasValue(), "returned", "pending")}]")
                Next
            End If

            report.Add(vbCrLf)

            Return report
        End Function
    End Class
End Namespace