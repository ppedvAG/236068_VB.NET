Public Interface IEmployeeRepository

    Sub SaveAll(employees As List(Of Employee))

    Function GetAll() As List(Of Employee)

End Interface
