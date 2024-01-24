Imports System.Globalization
Imports Microsoft.Data.SqlClient

Public Class Form1

    Dim conString = "Server=(localdb)\mssqllocaldb;Database=Northwnd;Trusted_Connection=True;Encrypt=False"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As SqlConnection

        Try
            con = New SqlConnection(conString)
            con.Open()

            Dim cmd = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM Employees ORDER BY BirthDate"
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

            DataGridView1.DataSource = liste

        Catch ex As SqlException
            MessageBox.Show($"Datenbank-Fehler: {ex.Message} {vbCrLf}Server: {ex.Server}{vbCrLf}State: {ex.State}{vbCrLf}Source: {ex.Source}{vbCrLf}")
        Catch ex As Exception
            MessageBox.Show($"Fehler: {ex.Message}")
        Finally
            con.Close()
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
            Dim newEmp = New Employee()
            newEmp.FirstName = "NEU"
            newEmp.LastName = "NEU"
            newEmp.BirthDate = DateTime.Now.AddYears(-30)

            Dim con = New SqlConnection(conString)
            con.Open()

            Dim cmd = New SqlCommand()
            cmd.Connection = con
            cmd.CommandText = $"INSERT INTO Employees (FirstName,LastName,BirthDate) VALUES ('{newEmp.FirstName}','{newEmp.LastName}','" + newEmp.BirthDate.ToString(New CultureInfo("EN-us")) + "')"
            Dim rows = cmd.ExecuteNonQuery()

            If rows = 1 Then
                MessageBox.Show("Ein neuer Employee wurde hinzugefügt")
            ElseIf rows = 0 Then
                MessageBox.Show("KEIN neuer Employee wurde hinzugefügt")
            Else
                MessageBox.Show("PANIK !!!!!!")
            End If

        Catch ex As SqlException
            MessageBox.Show($"Datenbank-Fehler: {ex.Message} {vbCrLf}Server: {ex.Server}{vbCrLf}State: {ex.State}{vbCrLf}Source: {ex.Source}{vbCrLf}")
        Catch ex As Exception
            MessageBox.Show($"Fehler: {ex.Message}")
        End Try

    End Sub
End Class
