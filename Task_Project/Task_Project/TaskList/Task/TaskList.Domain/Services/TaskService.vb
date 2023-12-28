Imports TaskList.Domain.Interfaces
Imports TaskList.Domain.Models

Namespace Services
    Public Class TaskService
        Implements ITaskService

        Private ReadOnly _taskRepository As ITaskRepository

        Public Sub New(taskRepository As ITaskRepository)
            _taskRepository = taskRepository
        End Sub

        Public Sub CreateTask(task As Tasks) Implements ITaskService.CreateTask
            If task IsNot Nothing Then
                _taskRepository.Create(task)
            End If
        End Sub

        Public Sub UpdateTask(task As Tasks) Implements ITaskService.UpdateTask
            If task IsNot Nothing Then
                _taskRepository.Update(task)
            End If
        End Sub

        Public Sub DeleteTask(id As Integer) Implements ITaskService.DeleteTask
            If id <> 0 Then
                _taskRepository.Delete(id)
            End If
        End Sub

        Public Function GetAllTask() As IEnumerable(Of Tasks) Implements ITaskService.GetAllTask
            Return _taskRepository.GetAll()
        End Function

        Public Function GetTaskById(id As Integer) As Tasks Implements ITaskService.GetTaskById
            Return _taskRepository.GetById(id)
        End Function

        Public Function GetTaskByName(name As String) As IEnumerable(Of Tasks) Implements ITaskService.GetTaskByName
            If String.IsNullOrWhiteSpace(name) Then
                Throw New Exception("O nome não pode ser nulo ou vazio")
            End If
            Return _taskRepository.GetByName(name)
        End Function
    End Class
End Namespace