Imports Prolipol.Formacao.Domain.Events
Imports Prolipol.Formacao.Domain.Models

Namespace Interfaces
    Public Interface ILoanService
        Event BookBorrowed As EventHandler(Of BookBorrowedEventArgs)
        Event BorrowFailed As EventHandler(Of BorrowFailedEventArgs)
        Event BookReturned As EventHandler(Of BookReturnedEventArgs)
        Event BookReturnFailed As EventHandler(Of BookReturnFailedEventArgs)
        Sub LoanBook(book As Book, borrower As Borrower, loanDate As Date, expiryDate As Date)
        Sub ReturnBook(loan As Loan, returnDate As Date)
        Function GetLoans() As IEnumerable(Of Loan)
        Function UpdateLoan(loan As Loan) As Boolean
        Sub DeleteLoan(loan As Loan)
    End Interface
End Namespace
