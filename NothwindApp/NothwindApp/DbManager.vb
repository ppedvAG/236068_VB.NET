Imports Microsoft.Data.SqlClient

Public Class DbManager

    Public ReadOnly Property ConString As String

    Public Sub New(conString As String)

        If String.IsNullOrWhiteSpace(conString) Then '    'If conString = Nothing Or conString.Trim() = "" Then
            Throw New ArgumentException("ConString darf nicht leer sein", "conString")
        End If

        Me.ConString = conString
    End Sub

    Public Function GetAllEmployees(Optional such As String = Nothing) As List(Of Employee)

        Dim con As SqlConnection
        Try
            con = New SqlConnection(ConString)
            con.Open()

            Dim cmd = New SqlCommand
            cmd.Connection = con
            If String.IsNullOrWhiteSpace(such) Then
                cmd.CommandText = "SELECT * FROM Employees ORDER BY BirthDate"
            Else
                cmd.CommandText = "SELECT * FROM Employees WHERE FirstName LIKE '%'+ @suche +'%' OR LastName LIKE '%' + @suche + '%' ORDER BY BirthDate"
                cmd.Parameters.AddWithValue("suche", such)
            End If

            Dim reader = cmd.ExecuteReader()

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
        Catch ex As Exception
            'logger
            Debug.WriteLine($"SQL Fehler:{ex.Message}")
            Throw
        Finally
            con.Close()
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

        Dim con As SqlConnection

        Try
            con = New SqlConnection(ConString)

            Dim newEmp = New Employee()
            newEmp.FirstName = firstName
            newEmp.LastName = lastName
            newEmp.BirthDate = birthDate

            con.Open()

            Dim cmd = New SqlCommand()
            cmd.Connection = con
            'cmd.CommandText = $"INSERT INTO Employees (FirstName,LastName,BirthDate) VALUES ('{newEmp.FirstName}','{newEmp.LastName}','" + newEmp.BirthDate.ToString(New CultureInfo("EN-us")) + "')"
            cmd.CommandText = $"INSERT INTO Employees (FirstName,LastName,BirthDate) VALUES (@fName,@lname,@bdate)"
            cmd.Parameters.AddWithValue("fName", firstName)
            cmd.Parameters.AddWithValue("lName", lastName)
            cmd.Parameters.AddWithValue("bdate", birthDate)
            Dim rows = cmd.ExecuteNonQuery()

            Debug.WriteLine($"{rows} wurde hinzugefügt")
        Finally
            con.Close()
        End Try

    End Sub
End Class
