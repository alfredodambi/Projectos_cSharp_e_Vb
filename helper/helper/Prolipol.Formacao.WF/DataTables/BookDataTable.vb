Imports Prolipol.Formacao.Domain.Models

Namespace DataTables
    Public Class BookDataTable
        Inherits BaseDataTable(Of Book)

        Public Sub New(values As IEnumerable(Of Book))
            MyBase.New(values)
        End Sub

        Public Overrides Function Build(fields As Func(Of Book, Boolean)) As DataTable
            Columns.Add("ID", GetType(Integer))
            Columns.Add("TITLE", GetType(String))
            Columns.Add("AUTHOR", GetType(String))
            Columns.Add("AVAILABLE", GetType(String))



            For Each value In _values
                If value Is Nothing Then
                    Continue For
                End If
                Rows.Add(value.Id, value.Title, value.Author, If(value.IsAvailable, "Yes", "No"))
            Next
            Return Me
        End Function
    End Class
End Namespace