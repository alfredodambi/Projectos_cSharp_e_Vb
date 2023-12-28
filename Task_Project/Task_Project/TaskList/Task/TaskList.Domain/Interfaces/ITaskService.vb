Imports TaskList.Domain.Models

Namespace Interfaces
    Public Interface ITaskService

        ''' <summary>
        ''' Get a llist of task
        ''' </summary>
        ''' <returns>Return all the list of task</returns>
        Function GetAllTask() As IEnumerable(Of Tasks)
        ''' <summary>
        ''' Get a task by its Id
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns>Returns a task</returns>
        Function GetTaskById(id As Integer) As Tasks
        ''' <summary>
        ''' Create a task
        ''' </summary>
        ''' <param name="task"></param>
        Sub CreateTask(task As Tasks)

        ''' <summary>
        ''' Use to update a task
        ''' </summary>
        ''' <param name="task"></param>
        Sub UpdateTask(task As Tasks)
        ''' <summary>
        ''' Use to delete a specify Task
        ''' </summary>
        ''' <param name="id"></param>
        Sub DeleteTask(id As Integer)
        ''' <summary>
        ''' Get a List of Task by its name
        ''' </summary>
        ''' <param name="name"></param>
        ''' <returns></returns>
        Function GetTaskByName(name As String) As IEnumerable(Of Tasks)
    End Interface
End Namespace