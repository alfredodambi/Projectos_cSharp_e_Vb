Imports Prolipol.Formacao.Domain.Events
Imports Prolipol.Formacao.Domain.Models

Namespace Interfaces
    Public Interface IBorrowerService
        Event BorrowerAdded As EventHandler(Of BorrowerAddedEventArgs)
        Sub RegisterBorrower(borrower As Borrower)
        Function GetBorrower(id As Integer) As Borrower
        Function GetBorrowerByName(name As String) As Borrower
        Function UpdateBorrower(borrower As Borrower) As Boolean
        Function GetBorrowers() As IEnumerable(Of Borrower)
        Sub DeleteBorrower(borrower As Borrower)
        Function BorrowerNameExists(name As String) As Boolean
    End Interface
End Namespace
