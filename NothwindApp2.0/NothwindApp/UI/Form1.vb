Imports Bogus

Public Class Form1

    Dim conString As String = "Server=(localdb)\mssqllocaldb;Database=Northwnd;Trusted_Connection=True;Encrypt=False"

    Dim repo As IEmployeeRepository

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        repo = New DbManager(conString)
        'repo = New JsonManager("employees.json")


        'Binding
        TextBox3.DataBindings.Add("Text", TextBox2, "Text", True, DataSourceUpdateMode.OnPropertyChanged)
        TextBox3.DataBindings.Add("BackColor", TextBox2, "Text", True, DataSourceUpdateMode.OnPropertyChanged)
        Label2.DataBindings.Add("Text", TrackBar1, "Value")

        DataGridView1.AutoGenerateColumns = False
        BindingSource1.DataSource = New List(Of Employee)
        DataGridView1.DataSource = BindingSource1
        ListBox1.DataSource = BindingSource1
        vornameTextBox.DataBindings.Add("Text", BindingSource1, "FirstName")
        nachnameTextBox.DataBindings.Add("Text", BindingSource1, "LastName")
        gebDatumDateTimePicker.DataBindings.Add("Value", BindingSource1, "BirthDate", True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            BindingSource1.DataSource = repo.GetAll()

        Catch ex As Microsoft.Data.SqlClient.SqlException
            MessageBox.Show($"Datenbank-Fehler: {ex.Message} {vbCrLf}Server: {ex.Server}{vbCrLf}State: {ex.State}{vbCrLf}Source: {ex.Source}{vbCrLf}")
        Catch ex As Exception
            MessageBox.Show($"Fehler: {ex.Message}")
        End Try

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim empAsObj = BindingSource1.Current

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

            Dim newEmp = New Employee With {
                            .FirstName = "NEU",
                            .LastName = "NEU",
                            .BirthDate = Date.Now.AddYears(-200)}

            BindingSource1.Add(newEmp)

        Catch ex As Exception
            MessageBox.Show($"Fehler: {ex.Message}")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try

            'DataGridView1.DataSource = dbm.GetAllEmployees(TextBox1.Text)

        Catch ex As Microsoft.Data.SqlClient.SqlException
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

        BindingSource1.DataSource = faker.Generate(100)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim emps = TryCast(BindingSource1.DataSource, List(Of Employee))
        If emps IsNot Nothing Then

            Dim newList = New List(Of Employee)
            For Each emp In emps
                If emp.BirthDate.Year >= 2000 Then
                    newList.Add(emp)
                End If
            Next

            newList.Sort(AddressOf MySortFunction)

            BindingSource1.DataSource = newList
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

        Dim emps = TryCast(BindingSource1.DataSource, List(Of Employee))
        If emps IsNot Nothing Then

            Dim query = From emp In emps
                        Where emp.BirthDate.Year >= 2000
                        Order By emp.BirthDate.Year, emp.BirthDate.Month Descending
                        Select emp

            BindingSource1.DataSource = query.ToList

        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim emps = TryCast(BindingSource1.DataSource, List(Of Employee))
        If emps IsNot Nothing Then

            BindingSource1.DataSource = emps.Where(Function(emp) emp.BirthDate.Year >= 2000) _
                                           .OrderBy(Function(emp) emp.BirthDate.Year) _
                                           .ThenByDescending(Function(emp) emp.BirthDate.Month) _
                                           .ToList

        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try

            Dim emps = TryCast(BindingSource1.DataSource, List(Of Employee))

            If emps IsNot Nothing Then
                repo.SaveAll(emps)
                MessageBox.Show("Done")
            End If

        Catch ex As TooOldOrBirthdateInFutureException
            MessageBox.Show($"HR-Policy-Fehler: {ex.Message} {vbCrLf}Datum: {ex.Today}{vbCrLf}BirthDate: {ex.Birthdate}")
        Catch ex As Microsoft.Data.SqlClient.SqlException
            MessageBox.Show($"Datenbank-Fehler: {ex.Message} {vbCrLf}Server: {ex.Server}{vbCrLf}State: {ex.State}{vbCrLf}Source: {ex.Source}{vbCrLf}")
        Catch ex As Exception
            MessageBox.Show($"Fehler: {ex.Message}")
        End Try
    End Sub

    Private Sub ListBox1_Format(sender As Object, e As ListControlConvertEventArgs) Handles ListBox1.Format
        Dim emp = TryCast(e.Value, Employee)
        If emp IsNot Nothing Then
            e.Value = $"{emp.FirstName} {emp.LastName}"
        End If
    End Sub
End Class
