Imports Prolipol.Formacao.Domain.Models

Namespace DataTables
    Public Class BorrowerDataTable
        Inherits BaseDataTable(Of Borrower)

        Public Sub New(values As IEnumerable(Of Borrower))
            MyBase.New(values)
        End Sub

        Public Overrides Function Build(fields As Func(Of Borrower, Boolean)) As DataTable
            Columns.Add("ID", GetType(Integer))
            Columns.Add("FULL NAME", GetType(String))

            For Each value In _values
                If value Is Nothing Then
                    Continue For
                End If
                Rows.Add(value.Id, value.Name)
            Next

            Return Me
        End Function
    End Class
End Namespace