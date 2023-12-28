Namespace Models
    Public Class Borrower
        Public Property Id As Integer
        Public Property Name As String
        Public ReadOnly Property Loans As ICollection(Of Loan)

        Private Sub New()
            Loans = New HashSet(Of Loan)
        End Sub

        Public Sub New(name As String)
            Me.New()
            Me.Name = name
        End Sub

        Public Sub LoanBook(ByVal loan As Loan)
            ' Validate
            If IsNothing(loan) Then
                Throw New ArgumentNullException(NameOf(loan))
            End If

            Dim existingLoan = Loans.Any(Function(l) Not IsNothing(l) AndAlso l.Id = loan.Id)

            If existingLoan Then
                Throw New InvalidOperationException("This book was already borrowed")
            End If

            Loans.Add(loan)
        End Sub
    End Class
End Namespace