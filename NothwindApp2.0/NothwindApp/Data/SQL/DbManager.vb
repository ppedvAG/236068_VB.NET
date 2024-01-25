Imports Microsoft.Data.SqlClient

Public Class DbManager
    Implements IEmployeeRepository

    Public ReadOnly Property ConString As String

    Public Sub New(conString As String)

        If String.IsNullOrWhiteSpace(conString) Then '    'If conString = Nothing Or conString.Trim() = "" Then
            Throw New ArgumentException("ConString darf nicht leer sein", "conString")
        End If

        Me.ConString = conString
    End Sub

    Public Function GetAllEmployees(Optional such As String = Nothing) As List(Of Employee)

        Try
            Using con = New SqlConnection(ConString)
                con.Open()

                Using cmd = New SqlCommand
                    cmd.Connection = con
                    If String.IsNullOrWhiteSpace(such) Then
                        cmd.CommandText = "SELECT * FROM Employees ORDER BY BirthDate"
                    Else
                        cmd.CommandText = "SELECT * FROM Employees WHERE FirstName LIKE '%'+ @suche +'%' OR LastName LIKE '%' + @suche + '%' ORDER BY BirthDate"
                        cmd.Parameters.AddWithValue("suche", such)
                    End If

                    Using reader = cmd.ExecuteReader()
                        Dim liste = New List(Of Employee)
                        While reader.Read
                            Dim emp = New Employee
                            emp.Id = reader.GetInt32(reader.GetOrdinal("EmployeeID"))
                            emp.FirstName = reader.GetString(reader.GetOrdinal("FirstName"))
                            emp.LastName = reader.GetString(reader.GetOrdinal("LastName"))
                            emp.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"))
                            liste.Add(emp)
                        End While

                        Return liste
                    End Using 'reader.Dispose()
                End Using 'cmd.Dispose()
            End Using 'con.Dispose() -> con.Close()
        Catch ex As Exception
            'logger
            Debug.WriteLine($"SQL Fehler:{ex.Message}")
            Throw
        End Try

    End Function

    Public Sub AddNewEmployee(firstName As String, lastName As String, birthDate As DateTime)

        If String.IsNullOrWhiteSpace(firstName) Then
            Throw New ArgumentException("firstName darf nicht leer sein", "firstName")
        End If

        If String.IsNullOrWhiteSpace(lastName) Then
            Throw New ArgumentException("lastName darf nicht leer sein", "lastName")
        End If

        If birthDate > DateTime.Now Or DateTime.Now.Year - birthDate.Year > 100 Then
            ' Throw New ArgumentException("birthDate darf nicht in der Zukunft liegen oder älter als 100 Jahre", "birthDate")
            Dim msg = "birthDate darf nicht in der Zukunft liegen oder älter als 100 Jahre"
            Throw New TooOldOrBirthdateInFutureException(msg, birthDate, DateTime.Now)
        End If

        Using con = New SqlConnection(ConString)

            Dim newEmp = New Employee()
            newEmp.FirstName = firstName
            newEmp.LastName = lastName
            newEmp.BirthDate = birthDate

            con.Open()

            Using cmd = New SqlCommand()
                cmd.Connection = con
                'cmd.CommandText = $"INSERT INTO Employees (FirstName,LastName,BirthDate) VALUES ('{newEmp.FirstName}','{newEmp.LastName}','" + newEmp.BirthDate.ToString(New CultureInfo("EN-us")) + "')"
                cmd.CommandText = $"INSERT INTO Employees (FirstName,LastName,BirthDate) VALUES (@fName,@lname,@bdate)"
                cmd.Parameters.AddWithValue("fName", firstName)
                cmd.Parameters.AddWithValue("lName", lastName)
                cmd.Parameters.AddWithValue("bdate", birthDate)
                Dim rows = cmd.ExecuteNonQuery()

                Debug.WriteLine($"{rows} wurde hinzugefügt")
            End Using
        End Using
    End Sub

    Private Sub UpdateEmployee(emp As Employee)
        Using con = New SqlConnection(ConString)
            con.Open()
            Using cmd = New SqlCommand()
                cmd.Connection = con
                cmd.CommandText = "UPDATE Employees SET FirstName = @fName, LastName = @lName, BirthDate = @bdate WHERE EmployeeId = @id"
                cmd.Parameters.AddWithValue("@fName", emp.FirstName)
                cmd.Parameters.AddWithValue("@lName", emp.LastName)
                cmd.Parameters.AddWithValue("@bdate", emp.BirthDate)
                cmd.Parameters.AddWithValue("@id", emp.Id)

                Dim rows = cmd.ExecuteNonQuery()
                Debug.WriteLine($"{rows} Reihe(n) aktualisiert")
            End Using
        End Using
    End Sub

    Public Sub SaveAll(employees As List(Of Employee)) Implements IEmployeeRepository.SaveAll

        For Each emp In employees
            If emp.Id = 0 Then
                AddNewEmployee(emp.FirstName, emp.LastName, emp.BirthDate)
            Else
                UpdateEmployee(emp)
            End If
        Next

    End Sub

    Public Function GetAll() As List(Of Employee) Implements IEmployeeRepository.GetAll
        Return GetAllEmployees()
    End Function
End Class
