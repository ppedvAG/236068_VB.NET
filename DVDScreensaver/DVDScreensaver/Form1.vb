Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hallo")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim speedx As Integer = 2
    Dim speedy As Integer = 2

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Button1.Left += speedx
        Button1.Top += speedy

        If Button1.Right >= ClientSize.Width Or Button1.Left <= 0 Then
            speedx *= -1
            Task.Run(Sub() Console.Beep())
        End If

        If Button1.Bottom >= ClientSize.Height Or Button1.Top <= 0 Then
            speedy *= -1
            Task.Run(Sub() Console.Beep())
        End If

    End Sub
End Class
