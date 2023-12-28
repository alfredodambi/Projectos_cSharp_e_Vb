Imports Prolipol.Formacao.Domain.Events
Imports Prolipol.Formacao.Domain.Exceptions
Imports Prolipol.Formacao.Domain.Interfaces
Imports Prolipol.Formacao.Domain.Models

Namespace Services
    Public Class BorrowerService
        Implements IBorrowerService

        Private ReadOnly _borrowerRepository As IBorrowerRepository

        Public Event BorrowerAdded As EventHandler(Of BorrowerAddedEventArgs) Implements IBorrowerService.BorrowerAdded

        ' TODO: Create the events for the service endpoints
        Public Sub New(borrowerRepository As IBorrowerRepository)
            _borrowerRepository = borrowerRepository
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Function GetBorrowers() As IEnumerable(Of Borrower) Implements IBorrowerService.GetBorrowers
            Return _borrowerRepository.GetAll()
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="borrower"></param>
        Public Sub RegisterBorrower(borrower As Borrower) Implements IBorrowerService.RegisterBorrower
            ' Validations
            If IsNothing(borrower) Then
                Throw New ArgumentNullException(NameOf(borrower))
            End If

            If String.IsNullOrWhiteSpace(borrower.Name) Then
                Throw New InvalidOperationException("Borrowers name must be valid")
            End If

            Dim existingBorrower = _borrowerRepository.GetByName(borrower.Name)

            If Not IsNothing(existingBorrower) Then
                Throw New BorrowerAlreadyExistsException("Borrower already registered", existingBorrower.Name)
            End If

            ' Save the borrower
            Dim insertedBorrower = _borrowerRepository.Create(borrower)

            If insertedBorrower.Id < 1 Then
                Throw New InvalidOperationException("Unable to register borrower")
            End If

            RaiseEvent BorrowerAdded(Me, New BorrowerAddedEventArgs(insertedBorrower))
        End Sub

        Public Function GetBorrower(id As Integer) As Borrower Implements IBorrowerService.GetBorrower
            If id < 1 Then
                Throw New ArgumentException(NameOf(id))
            End If

            Dim foundBorrower = _borrowerRepository.Get(id)

            Return foundBorrower
        End Function

        Public Function GetBorrowerByName(name As String) As Borrower Implements IBorrowerService.GetBorrowerByName
            If String.IsNullOrWhiteSpace(name) Then
                Throw New ArgumentNullException(NameOf(name))
            End If

            Dim foundBorrower = _borrowerRepository.GetByName(name)

            Return foundBorrower
        End Function

        Public Function UpdateBorrower(borrower As Borrower) As Boolean Implements IBorrowerService.UpdateBorrower
            If borrower.Id < 1 Then
                Throw New ArgumentException(NameOf(borrower.Id))
            End If

            Dim foundBorrower = _borrowerRepository.Get(borrower.Id)

            If IsNothing(foundBorrower) Then
                Throw New InvalidOperationException("Borrower doesn't exist")
            End If

            Dim updatedBorrower = _borrowerRepository.Update(borrower.Id, borrower)

            If IsNothing(updatedBorrower) Then
                Return False
            End If

            Return True
        End Function

        Public Sub DeleteBorrower(borrower As Borrower) Implements IBorrowerService.DeleteBorrower

            If borrower IsNot Nothing Then
                Dim isDeleted As Boolean = _borrowerRepository.Delete(borrower.Id)
            Else
                Throw New ArgumentException("Borrower not found.")
            End If
        End Sub

        Public Function BorrowerNameExists(name As String) As Boolean Implements IBorrowerService.BorrowerNameExists
            Dim existBorrower = _borrowerRepository.GetByName(name)

            If IsNothing(existBorrower) Then
                Return False
            End If

            Return True
        End Function
    End Class
End Namespace