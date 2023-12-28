Imports System.Reflection

Namespace DataTables
    Public MustInherit Class BaseDataTable(Of T)
        Inherits DataTable

        Protected ReadOnly _values As IEnumerable(Of T)
        Public Shadows ReadOnly Property TableName As String = $"{GetType(T).FullName}DataTable"

        Public Sub New(values As IEnumerable(Of T))
            MyBase.New()
            _values = values
        End Sub

        Public MustOverride Function Build(fields As Func(Of T, Boolean)) As DataTable
        'Dim filteredValues = _values.Where(fields)

        'For Each filteredValue In filteredValues
        'Dim values As New List(Of Object)

        'Dim propertyInfos = filteredValue.GetType().GetProperties(BindingFlags.GetProperty)

        'For Each propertyInfo In propertyInfos
        'Dim fieldName = NameOf(PropertyInfo.Name)
        'If Not Columns.Contains(fieldName) Then
        '                Columns.Add(fieldName, propertyInfo.PropertyType)
        '            End If
        'Dim value = PropertyInfo.GetValue(filteredValue, Nothing)
        '            values.Add(value)
        '        Next

        '        Rows.Add(values)
        '    Next



        ''For Each value In _values
        ''    Rows.Add(value.Id, value.Name)
        ''Next

        'Return Me
    End Class
End Namespace