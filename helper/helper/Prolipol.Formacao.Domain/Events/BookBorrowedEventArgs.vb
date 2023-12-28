Imports Prolipol.Formacao.Domain.Models

Namespace Events
    Public Class BookBorrowedEventArgs
        Inherits EventArgs

        Public Property Book As Book
        Public Property Borrower As Borrower

        Public Sub New(ByVal book As Book, ByVal borrower As Borrower)
            Me.Book = book
            Me.Borrower = borrower
        End Sub
    End Class
End Namespace