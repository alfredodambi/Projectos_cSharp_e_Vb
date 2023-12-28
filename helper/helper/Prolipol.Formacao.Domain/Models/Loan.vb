Namespace Models
    Public Class Loan
        Public Property Id As Integer
        Public Property Book As Book
        Public Property Borrower As Borrower
        Public Property StartDate As Date
        Public Property ExpiryDate As Date
        Public Property ReturnedOn As Nullable(Of Date)

        Private Sub New()

        End Sub

        Public Sub New(book As Book, borrower As Borrower, startDate As Date, expiryDate As Date)
            Me.Book = book
            Me.Borrower = borrower
            Me.StartDate = startDate
            Me.ExpiryDate = expiryDate
        End Sub

        Public Sub ReturnBook(ByVal returnDate As Date)
            ' Validade
            If ReturnedOn.HasValue Then
                Throw New InvalidOperationException($"The book '{Book.Title}' has already been returned")
            End If

            Book.ReturnBook()
            ReturnedOn = returnDate
        End Sub
    End Class
End Namespace