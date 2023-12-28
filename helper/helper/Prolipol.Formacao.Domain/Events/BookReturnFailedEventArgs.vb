Imports Prolipol.Formacao.Domain.Models

Namespace Events
    Public Class BookReturnFailedEventArgs
        Inherits EventArgs

        Public Property Loan As Loan

        Public Sub New(loan As Loan)
            Me.Loan = loan
        End Sub
    End Class
End Namespace