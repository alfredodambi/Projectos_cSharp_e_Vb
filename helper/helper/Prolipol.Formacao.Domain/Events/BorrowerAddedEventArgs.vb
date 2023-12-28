Imports Prolipol.Formacao.Domain.Models

Namespace Events
    Public Class BorrowerAddedEventArgs
        Inherits EventArgs

        Public ReadOnly Property Borrower As Borrower

        Public Sub New(ByVal borrower As Borrower)
            Me.Borrower = borrower
        End Sub
    End Class
End Namespace