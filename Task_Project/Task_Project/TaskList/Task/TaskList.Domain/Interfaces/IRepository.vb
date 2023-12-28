Namespace Interfaces
    Public Interface IRepository(Of T)

        ''' <summary>
        ''' Get the all objects in a list
        ''' </summary>
        ''' <returns></returns>
        Function GetAll() As IEnumerable(Of T)

        ''' <summary>
        '''Get a Specify object by its ID
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Function GetById(id As Integer) As T

        ''' <summary>
        ''' Create an object
        ''' </summary>
        ''' <param name="value"></param>
        Sub Create(value As T)

        ''' <summary>
        ''' Update an object
        ''' </summary>
        ''' <param name="value"></param>
        Sub Update(value As T)

        ''' <summary>
        ''' Delete an object by its ID
        ''' </summary>
        ''' <param name="id"></param>
        Sub Delete(id As Integer)
    End Interface
End Namespace