Imports System.Runtime.Serialization

Namespace Exceptions
    Public Class BorrowerAlreadyExistsException
        Inherits ApplicationException

        Private _fullName As String

        Public Property FullName As String
            Get
                Return _fullName
            End Get
            Private Set
                _fullName = Value
            End Set
        End Property

        Public Sub New(fullName As String)
            _fullName = fullName
        End Sub

        Public Sub New(message As String, fullName As String)
            MyBase.New(message)
            _fullName = fullName
        End Sub

        Public Sub New(message As String, innerException As Exception, fullName As String)
            MyBase.New(message, innerException)
            _fullName = fullName
        End Sub
    End Class
End Namespace