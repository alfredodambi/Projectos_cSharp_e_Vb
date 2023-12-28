Imports TaskList.Domain.Interfaces
Imports TaskList.Domain.Models

Namespace Repository
    Public Class UserRepository
        Implements IUserRepository

        Private ReadOnly _connectionString As String
        Public Sub New(connectionString)
            _connectionString = connectionString
        End Sub
        Public Sub Create(user As Users) Implements IRepository(Of Users).Create
            Using _context = New Context(_connectionString)
                If user IsNot Nothing Then
                    _context.Userss.Add(user)
                    _context.SaveChanges()
                End If
            End Using
        End Sub

        Public Sub Update(user As Users) Implements IRepository(Of Users).Update
            Using _context = New Context(_connectionString)
                If user IsNot Nothing Then
                    _context.Entry(user).State = Entity.EntityState.Modified
                    _context.SaveChanges()
                End If
            End Using
        End Sub

        Public Sub Delete(id As Integer) Implements IRepository(Of Users).Delete
            Using _context = New Context(_connectionString)
                Dim user = _context.Userss.Find(id)
                _context.Userss.Remove(user)
                _context.SaveChanges()
            End Using
        End Sub

        Public Function Login(user As Users) As Boolean Implements IUserRepository.Login
            Using _context = New Context(_connectionString)
                If user IsNot Nothing Then
                    Dim users = _context.Userss.Any(Function(u) u.UserName.ToLower() = user.UserName.ToLower() AndAlso u.UserPassword.ToLower() = user.UserPassword.ToLower())
                    Return users
                End If
                Return False
            End Using
        End Function

        Public Function GetAll() As IEnumerable(Of Users) Implements IRepository(Of Users).GetAll
            Using _context = New Context(_connectionString)
                Return _context.Userss.ToList
            End Using
        End Function

        Public Function GetById(id As Integer) As Users Implements IRepository(Of Users).GetById
            Using _context = New Context(_connectionString)
                Return _context.Userss.Find(id)
            End Using
        End Function
    End Class
End Namespace