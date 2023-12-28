Imports TaskList.Domain.Models

Namespace Interfaces
    Public Interface ITaskRepository
        Inherits IRepository(Of Tasks)

        ''' <summary>
        ''' Get a Task By its Name
        ''' </summary>
        ''' <param name="name"></param>
        ''' <returns></returns>
        Function GetByName(name As String) As IEnumerable(Of Tasks)

    End Interface
End Namespace