Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports Prolipol.Formacao.Domain.Interfaces

Public NotInheritable Class DatabaseInitializer
    Implements IDatabaseInitializer

    Private ReadOnly _connectionString As String
    Private ReadOnly _databaseCreationScript As String

    Public Sub New(connectionString As String, databaseCreationScript As String)
        _connectionString = connectionString
        _databaseCreationScript = databaseCreationScript
    End Sub

    Public Sub InitializeDatebase() Implements IDatabaseInitializer.InitializeDatebase
        If Not DatabaseExists() Then
            CreateDatabase()
        End If
    End Sub

    ' TODO: Fix this try-catch and return <either remove the try-catch or else>
    Private Function DatabaseExists() As Boolean
        Try
            Using connection = New SqlConnection(_connectionString)
                Dim selectDbCommand = "SELECT COUNT(*) FROM sys.databases WHERE name = @Name"
                Using sqlCommand = New SqlCommand(selectDbCommand, connection)
                    sqlCommand.Parameters.AddWithValue("@Name", GetDatabaseNameFromConnectionString())

                    connection.Open()

                    Return Convert.ToInt32(sqlCommand.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            ' Exception not handled properly?
            Return False
        End Try
    End Function

    Private Sub CreateDatabase()
        Using connection = New SqlConnection(GetMasterConnectionString())
            connection.Open()

            Dim databaseName = GetStringBuilderFromConnectionString().InitialCatalog

            ' Check if the database already exists, and creates if not
            Using checkDatabaseCommand As New SqlCommand($"IF DB_ID('{databaseName}') IS NULL BEGIN CREATE DATABASE [{databaseName}]; PRINT 'Database created successfully.'; END ELSE PRINT 'Database already exists.';", connection)
                checkDatabaseCommand.ExecuteNonQuery()
            End Using

            ' Use the database
            connection.ChangeDatabase(databaseName)

            ' load the creation script and executes the query
            Dim creationSqlCommand = File.ReadAllText(_databaseCreationScript)
            'Dim sqlStatements = SplitSqlStatements(creationSqlCommand)

            Using createTablesCommand As New SqlCommand(creationSqlCommand, connection)
                createTablesCommand.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function GetStringBuilderFromConnectionString() As SqlConnectionStringBuilder
        Return New SqlConnectionStringBuilder(_connectionString)
    End Function

    Private Function GetDatabaseNameFromConnectionString() As String
        Dim builder As New SqlConnectionStringBuilder(_connectionString)
        Return builder.InitialCatalog
    End Function

    Private Function GetMasterConnectionString() As String
        Dim builder As New SqlConnectionStringBuilder(_connectionString)
        builder.Remove("Initial Catalog")
        Return builder.ConnectionString
    End Function

    Private Function SplitSqlStatements(sqlScript As String) As IEnumerable(Of String)
        ' @from: https://stackoverflow.com/questions/18596876/go-statements-blowing-up-sql-execution-in-net/18597052#18597052

        ' Make line endings standard to match RegexOptions.Multiline
        sqlScript = Regex.Replace(sqlScript, "\r\n|\r|\n", Environment.NewLine)

        ' Split by GO statements
        Dim pattern = "^[\\t ]*GO[\\t ]*\\d*[\\t ]*(?:--.*)?$"
        Dim options As RegexOptions = RegexOptions.Multiline Or RegexOptions.IgnorePatternWhitespace Or RegexOptions.IgnoreCase
        Dim statements = Regex.Split(sqlScript, pattern, options)

        ' Remove empties, trim, and return
        Return statements.Where(Function(x) Not String.IsNullOrWhiteSpace(x)).Select(Function(x) x.Trim({Chr(32), Chr(10), Chr(13)}))
    End Function
End Class