Namespace Interfaces
    Public Interface ISynchronizeInvoke
        Function Invoke(method As [Delegate], args() As Object) As Object
        Function BeginInvoke(method As [Delegate], args() As Object) As IAsyncResult
        Function EndInvoke(result As IAsyncResult) As Object
        ReadOnly Property InvokeRequired As Boolean
    End Interface
End Namespace