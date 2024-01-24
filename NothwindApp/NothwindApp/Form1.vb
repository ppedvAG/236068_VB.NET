Imports System.Globalization
Imports Bogus
Imports Microsoft.Data.SqlClient

Public Class Form1

    Dim conString As String = "Server=(localdb)\mssqllocaldb;Database=Northwnd;Trusted_Connection=True;Encrypt=False"
    Dim dbm As DbManager = New DbManager(conString)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            DataGridView1.DataSource = dbm.GetAllEmployees()

        Catch ex As SqlException
            MessageBox.Show($"Datenbank-Fehler: {ex.Message} {vbCrLf}Server: {ex.Server}{vbCrLf}State: {ex.State}{vbCrLf}Source: {ex.Source}{vbCrLf}")
        Catch ex As Exception
            MessageBox.Show($"Fehler: {ex.Message}")
        End Try

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim empAsObj = DataGridView1.CurrentRow.DataBoundItem

        If TypeOf empAsObj Is Employee Then 'typprüfung
            Dim emp = CType(empAsObj, Employee) 'casting
            MessageBox.Show($"Jo, ist ein Employee: {emp.FirstName}")

            'Dim empAsButton = CType(empAsObj, Button) '-> Fehler
        End If

        'moderner: trycast
        Dim empTryCast = TryCast(empAsObj, Employee)
        If empTryCast IsNot Nothing Then
            MessageBox.Show($"Jo, ist ein Employee: {empTryCast.FirstName}")
        Else
            MessageBox.Show("Das ist kein Employee")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try

            dbm.AddNewEmployee("NEU", "NEU", DateTime.Now.AddYears(-20))

            MessageBox.Show("Done")
        Catch ex As TooOldOrBirthdateInFutureException
            MessageBox.Show($"HR-Policy-Fehler: {ex.Message} {vbCrLf}Datum: {ex.Today}{vbCrLf}BirthDate: {ex.Birthdate}")
        Catch ex As SqlException
            MessageBox.Show($"Datenbank-Fehler: {ex.Message} {vbCrLf}Server: {ex.Server}{vbCrLf}State: {ex.State}{vbCrLf}Source: {ex.Source}{vbCrLf}")
        Catch ex As Exception
            MessageBox.Show($"Fehler: {ex.Message}")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try

            DataGridView1.DataSource = dbm.GetAllEmployees(TextBox1.Text)

        Catch ex As SqlException
            MessageBox.Show($"Datenbank-Fehler: {ex.Message} {vbCrLf}Server: {ex.Server}{vbCrLf}State: {ex.State}{vbCrLf}Source: {ex.Source}{vbCrLf}")
        Catch ex As Exception
            MessageBox.Show($"Fehler: {ex.Message}")
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim faker = New Faker(Of Employee)("de")
        faker.UseSeed(5)
        faker.RuleFor(Function(x) x.FirstName, Function(x) x.Name.FirstName) _
             .RuleFor(Function(x) x.LastName, Function(x) x.Name.LastName) _
             .RuleFor(Function(x) x.BirthDate, Function(x) x.Date.Past(30))

        DataGridView1.DataSource = faker.Generate(100)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim emps = TryCast(DataGridView1.DataSource, List(Of Employee))
        If emps IsNot Nothing Then

            Dim newList = New List(Of Employee)
            For Each emp In emps
                If emp.BirthDate.Year >= 2000 Then
                    newList.Add(emp)
                End If
            Next

            newList.Sort(AddressOf MySortFunction)

            DataGridView1.DataSource = newList
        End If

    End Sub

    Public Function MySortFunction(x As Employee, y As Employee) As Integer
        If x.BirthDate > y.BirthDate Then
            Return 1
        ElseIf x.BirthDate < y.BirthDate Then
            Return -1
        Else
            Return 0
        End If
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim emps = TryCast(DataGridView1.DataSource, List(Of Employee))
        If emps IsNot Nothing Then

            Dim query = From emp In emps
                        Where emp.BirthDate.Year >= 2000
                        Order By emp.BirthDate.Year, emp.BirthDate.Month Descending
                        Select emp

            DataGridView1.DataSource = query.ToList

        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim emps = TryCast(DataGridView1.DataSource, List(Of Employee))
        If emps IsNot Nothing Then

            DataGridView1.DataSource = emps.Where(Function(emp) emp.BirthDate.Year >= 2000) _
                                           .OrderBy(Function(emp) emp.BirthDate.Year) _
                                           .ThenByDescending(Function(emp) emp.BirthDate.Month) _
                                           .ToList()

        End If
    End Sub
End Class
