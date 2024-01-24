Imports Microsoft.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conString = "Server=.;Database=Northwind;Trusted_Connection=True;Encrypt=False"
        conString = "Server=(localdb)\mssqllocaldb;Database=Northwnd;Trusted_Connection=True;Encrypt=False"

        Dim con = New SqlConnection(conString)
        con.Open()

        Dim cmd = New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Employees ORDER BY BirthDate"
        Dim reader = cmd.ExecuteReader

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
        con.Close()

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
End Class
