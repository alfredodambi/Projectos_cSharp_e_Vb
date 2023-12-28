Namespace Models
    Public Class Book
        Public Property Id As Integer
        Public Property Title As String
        Public Property Author As String
        Public Property LoanedTo As Loan
        Public Property IsAvailable As Boolean

        Private Sub New()

        End Sub

        Public Sub New(title As String, author As String)
            Me.New()
            Me.Title = title
            Me.Author = author
            Me.IsAvailable = True
        End Sub

        Public Sub LoanTo(ByVal loan As Loan)
            ' Validate
            If IsNothing(loan) Then
                Throw New ArgumentNullException(NameOf(loan))
            End If

            If Not IsAvailable Then
                Throw New InvalidOperationException($"Book '{Title}' by {Author} already borrowed, it's unavailable")
            End If

            IsAvailable = False
            LoanedTo = loan
        End Sub

        Public Sub ReturnBook()
            ' Validate
            If IsAvailable Then
                Throw New InvalidOperationException($"Book '{Title}' by {Author} already returned")
            End If

            IsAvailable = True
            LoanedTo = Nothing
        End Sub

        Public Function Reduce(ByRef title, ByRef author, ByRef isAvailable) As Tuple(Of String, String, Boolean)
            title = Me.Title
            author = Me.Author
            isAvailable = Me.IsAvailable

            Return New Tuple(Of String, String, Boolean)(Me.Title, Me.Author, Me.IsAvailable)
        End Function

        Public Sub Deconstruct(ByRef title, ByRef author, ByRef isAvailable)
            title = Me.Title
            author = Me.Author
            isAvailable = Me.IsAvailable
        End Sub
    End Class
End Namespace