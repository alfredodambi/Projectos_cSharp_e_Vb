Imports Prolipol.Formacao.Domain.Models

Namespace Interfaces
    Public Interface IBorrowerRepository
        Inherits IRepository(Of Integer, Borrower)
        Function GetByName(name As String) As Borrower
        'Function VerifyIfBorrowerHasLoan(borrower As Borrower) As Boolean

    End Interface
End Namespace
