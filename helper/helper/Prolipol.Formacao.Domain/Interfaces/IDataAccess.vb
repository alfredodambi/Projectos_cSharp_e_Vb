Namespace Interfaces
    Public Interface IDataAccess(Of In TId, T)
        Function [Get](ByVal id As TId) As T
        Function GetAll() As IEnumerable(Of T)
        Function Create(ByVal entity As T) As T
        Function Update(ByVal id As TId, ByVal entity As T) As T
        Function Delete(ByVal id As TId) As Boolean
    End Interface
End Namespace