Namespace Interfaces
    Public Interface IRepository(Of TId, TValue)
        Function [Get](ByVal id As TId) As TValue
        Function GetAll() As IEnumerable(Of TValue)
        Function Create(ByVal entity As TValue) As TValue
        Function Update(ByVal id As TId, ByVal entity As TValue) As TValue
        Function Delete(ByVal id As TId) As Boolean
    End Interface
End Namespace