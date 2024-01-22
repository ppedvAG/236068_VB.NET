Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For index = 1 To TrackBar1.Value
            ListBox1.Items.Add($"Eintrag #{index}")
        Next

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Button1.Text = $"Erstelle {TrackBar1.Value} Einträge"
    End Sub

    Dim file As String = "einträge.txt"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sw As StreamWriter = New StreamWriter(file)

        'old style
        'For index = 0 To ListBox1.Items.Count - 1
        '    sw.WriteLine(ListBox1.Items(index))
        'Next

        For Each item In ListBox1.Items
            sw.WriteLine(item)
        Next

        sw.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sr As StreamReader = New StreamReader(file)

        ListBox1.Items.Clear()
        While Not sr.EndOfStream
            ListBox1.Items.Add(sr.ReadLine)
        End While

        sr.Close()
    End Sub
End Class
