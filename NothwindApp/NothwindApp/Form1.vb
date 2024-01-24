Imports System.Globalization
Imports Microsoft.Data.SqlClient

Public Class Form1

    Dim conString = "Server=(localdb)\mssqllocaldb;Database=Northwnd;Trusted_Connection=True;Encrypt=False"
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
End Class
