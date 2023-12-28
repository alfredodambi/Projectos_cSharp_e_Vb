Public MustInherit Class DataAccessFactory(Of T)
    Private Protected ReadOnly _connectionString As String

    Public Sub New(connectionString As String)
        _connectionString = connectionString
    End Sub

    Public MustOverride Function CreateDbConnection() As T
End Class