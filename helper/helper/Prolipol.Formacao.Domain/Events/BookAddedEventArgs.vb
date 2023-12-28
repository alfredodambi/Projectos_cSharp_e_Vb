Imports Prolipol.Formacao.Domain.Models

Namespace Events
    Public Class BookAddedEventArgs
        Inherits EventArgs

        Public ReadOnly Property Book As Book
        Public Sub New(ByVal book As Book)
            Me.Book = book
        End Sub
    End Class
End Namespace