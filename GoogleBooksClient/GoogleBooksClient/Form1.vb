Imports System.Net.Http
Imports System.Linq

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim url = $"https://www.googleapis.com/books/v1/volumes?q={TextBox1.Text}"

        Dim http = New HttpClient()

        Dim json = http.GetStringAsync(url).Result

        Dim br = System.Text.Json.JsonSerializer.Deserialize(Of BooksResult)(json)

        DataGridView1.DataSource = br.items.Select(Function(b) b.volumeInfo).ToList()

    End Sub
End Class
