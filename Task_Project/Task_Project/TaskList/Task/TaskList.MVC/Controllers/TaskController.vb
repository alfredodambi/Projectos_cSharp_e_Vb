Imports System.Web.Mvc
Imports Newtonsoft.Json
Imports TaskList.Domain.Interfaces
Imports TaskList.Domain.Models
Imports TaskList.Domain.Services
Imports TaskList.EntityFramework.Repository
'Imports TaskList.Dapper.Repository


Namespace Controllers
    <Authorize>
    Public Class TaskController
        Inherits Controller

        ' GET: Task

        Private ReadOnly _connectionString = ConfigurationManager.ConnectionStrings("ConnectionDb").ConnectionString

        Private ReadOnly _taskRepository As ITaskRepository = New TaskRepository(_connectionString)
        Private ReadOnly _taskService As ITaskService = New TaskService(_taskRepository)

        <Authorize(Roles:="Admin,User,Other")>
        Function Index(searchString As String) As ActionResult
            Dim task = If(String.IsNullOrEmpty(searchString), _taskService.GetAllTask(), _taskService.GetTaskByName(searchString))
            Return View(task)
        End Function

        ' GET: Task/Details/5
        <Authorize(Roles:="Admin,User,Other")>
        Function Details(ByVal id As Integer) As ActionResult
            Dim task = _taskService.GetTaskById(id)
            Return View(task)
        End Function

        ' GET: Task/Create
        <Authorize(Roles:="Admin,User,Other")>
        Function Create() As ActionResult
            Try
                Return View(New Tasks())
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        ' POST: Task/Create
        <HttpPost()>
        Function Create(task As Tasks) As ActionResult
            Try
                'Check if the data passed Are valid
                If ModelState.IsValid Then
                    _taskService.CreateTask(task)
                    TempData("SuccessMessage") = "Registado"
                    Return RedirectToAction("Index")
                End If
                Return View()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' GET: Task/Edit/5
        <Authorize(Roles:="Admin,User")>
        Function Edit(id As Integer) As ActionResult
            Try
                Dim task = _taskService.GetTaskById(id)
                If task Is Nothing Then
                    Return HttpNotFound()
                End If
                Return View(task)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        ' POST: Task/Edit/5
        <HttpPost()>
        Function Edit(newTask As Tasks) As ActionResult
            Try
                'Check if the data passed Are valid
                If ModelState.IsValid Then
                    '_taskService.GetAllTask().Where(Function(t) t.State = "Finalizada" OrElse t.State = "Terminada")
                    _taskService.UpdateTask(newTask)
                    TempData("SuccessMessage") = "Dados da tarefa Actualizado com sucesso!"
                    ModelState.Clear()
                    Return RedirectToAction("Index")
                End If
                Return View()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' GET: Task/Delete/5
        <Authorize(Roles:="Admin")>
        Function Delete(id As Integer) As ActionResult
            Try
                Dim task = _taskService.GetTaskById(id)
                'Check if the task is not nothing
                If task Is Nothing Then
                    Return HttpNotFound()
                End If
                Return View(task)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        ' POST: Task/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        Function ConfirmDelete(id As Integer) As ActionResult
            Try
                _taskService.DeleteTask(id)
                TempData("SuccessMessage") = "Tarefa eliminada com sucesso!"
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace