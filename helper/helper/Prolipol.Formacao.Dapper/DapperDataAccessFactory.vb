Imports System.Data.SqlClient

Public Class DapperDataAccessFactory
    Inherits DataAccessFactory(Of IDbConnection)

    Public Sub New(connectionString As String)
        MyBase.New(connectionString)
    End Sub

    Public Overrides Function CreateDbConnection() As IDbConnection
        Return New SqlConnection(_connectionString)
    End Function
End Class