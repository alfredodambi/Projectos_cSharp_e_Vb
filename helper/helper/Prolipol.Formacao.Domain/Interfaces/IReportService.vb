Namespace Interfaces
    Public Interface IReportService
        Function GenerateAvailableBooksReport() As IEnumerable(Of String)
        Function GenerateLoansReport() As IEnumerable(Of String)
        Function GenerateOverdueLoansReport() As IEnumerable(Of String)
    End Interface
End Namespace
