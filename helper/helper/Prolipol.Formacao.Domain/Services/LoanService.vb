Imports Prolipol.Formacao.Domain.Events
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Namespace Services
    Public Class LoanService
        Implements ILoanService

        Private ReadOnly _loanRepository As ILoanRepository
        Private ReadOnly _bookService As IBookService
        Private ReadOnly _borrowerService As IBorrowerService

        Public Event BookBorrowed As EventHandler(Of BookBorrowedEventArgs) Implements ILoanService.BookBorrowed
        Public Event BorrowFailed As EventHandler(Of BorrowFailedEventArgs) Implements ILoanService.BorrowFailed
        Public Event BookReturned As EventHandler(Of BookReturnedEventArgs) Implements ILoanService.BookReturned
        Public Event BookReturnFailed As EventHandler(Of BookReturnFailedEventArgs) Implements ILoanService.BookReturnFailed

        ' TODO: Create the events for the service endpoints

        Public Sub New(bookService As IBookService, borrowerService As IBorrowerService, loanRepository As ILoanRepository)
            _bookService = bookService
            _borrowerService = borrowerService
            _loanRepository = loanRepository
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="book"></param>
        ''' <param name="borrower"></param>
        ''' <param name="loanDate"></param>
        ''' <param name="expiryDate"></param>
        Public Sub LoanBook(book As Book, borrower As Borrower, loanDate As Date, expiryDate As Date) Implements ILoanService.LoanBook
            Try
                ' Validade the request
                ValidateRequest(book, borrower, loanDate, expiryDate)

                ' Create the loan
                Dim newLoan As Loan = New Loan(book, borrower, loanDate, expiryDate)

                book.LoanTo(newLoan)

                borrower.LoanBook(newLoan)

                ' Save the loan
                ' TODO: update book state then save the loan into the database
                Dim bookUpdated = _bookService.UpdateBook(book)
                _loanRepository.Create(newLoan)

                RaiseEvent BookBorrowed(Me, New BookBorrowedEventArgs(book, borrower))
            Catch ex As Exception
                ' Handle loan based errors, and rollback changes if necessary
                RaiseEvent BorrowFailed(Me, New BorrowFailedEventArgs(book, borrower))

                Throw
            End Try
        End Sub

        Public Sub ReturnBook(loan As Loan, returnDate As Date) Implements ILoanService.ReturnBook
            Try
                ' Validate

                loan.ReturnBook(returnDate)

                ' Update de loan
                ' TODO: update book state then update the loan in the database
                Dim bookUpdated = _bookService.UpdateBook(loan.Book)
                _loanRepository.Update(loan.Id, loan)

                RaiseEvent BookReturned(Me, New BookReturnedEventArgs(loan))
            Catch ex As Exception
                ' Handle loan based errors, and rollback changes if necessary
                RaiseEvent BookReturnFailed(Me, New BookReturnFailedEventArgs(loan))

                Throw
            End Try
        End Sub

        Public Function GetLoans() As IEnumerable(Of Loan) Implements ILoanService.GetLoans
            Return _loanRepository.GetAll()
        End Function

        Private Sub ValidateRequest(book As Book, borrower As Borrower, loanDate As Date, expiryDate As Date)
            ' Validations
            If IsNothing(book) Then
                Throw New ArgumentNullException(NameOf(book))
            End If

            If IsNothing(borrower) Then
                Throw New ArgumentNullException(NameOf(borrower))
            End If

            If expiryDate <= loanDate Then
                Throw New ArgumentOutOfRangeException(NameOf(expiryDate))
            End If
        End Sub

        Public Function UpdateLoan(loan As Loan) As Boolean Implements ILoanService.UpdateLoan

            Dim updatedLoan = _loanRepository.Update(loan.Id, loan)

            If IsNothing(updatedLoan) Then
                Return False
            End If

            Return True
        End Function

        Public Sub DeleteLoan(loan As Loan) Implements ILoanService.DeleteLoan
            Dim bookUpdated = _bookService.UpdateBook(loan.Book)
            _loanRepository.Delete(loan.Id)
        End Sub


    End Class
End Namespace