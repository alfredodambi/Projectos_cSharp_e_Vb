Imports Prolipol.Formacao.Domain.Models

Namespace DataTables
    Public Class LoanDataTable
        Inherits BaseDataTable(Of Loan)

        Public Sub New(values As IEnumerable(Of Loan))
            MyBase.New(values)
        End Sub

        Public Overrides Function Build(fields As Func(Of Loan, Boolean)) As DataTable
            Columns.Add("ID", GetType(Integer))
            Columns.Add("BOOK TITLE", GetType(String))
            Columns.Add("BORROWER NAME", GetType(String))
            Columns.Add("START DATE", GetType(Date))
            Columns.Add("EXPIRY DATE", GetType(Date))
            Columns.Add("RETURNED ON", GetType(String))

            For Each value In _values
                If value Is Nothing Then
                    Continue For
                End If
                Rows.Add(value.Id, value.Book.Title, value.Borrower.Name, FormatDateTime(value.StartDate, DateFormat.ShortDate), FormatDateTime(value.ExpiryDate, DateFormat.ShortDate), If(value.ReturnedOn.HasValue(), FormatDateTime(value.ReturnedOn, DateFormat.ShortDate), "pending"))
            Next

            Return Me
        End Function
    End Class
End Namespace