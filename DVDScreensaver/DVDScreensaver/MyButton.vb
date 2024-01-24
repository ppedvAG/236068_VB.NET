Imports System.Drawing.Drawing2D

Public Class MyButton
    Inherits Button

    Dim paintCount = 0
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)

        pevent.Graphics.FillRectangle(New SolidBrush(Parent.BackColor), ClientRectangle)

        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        If ClientRectangle.Contains(Me.PointToClient(Cursor.Position)) Then
            Dim myBrush = New LinearGradientBrush(ClientRectangle, Color.YellowGreen, Color.Aqua, LinearGradientMode.Vertical)
            pevent.Graphics.FillEllipse(myBrush, ClientRectangle)
        Else
            Dim myBrush = New LinearGradientBrush(ClientRectangle, Color.LightCoral, Color.Aqua, LinearGradientMode.Vertical)
            pevent.Graphics.FillEllipse(myBrush, ClientRectangle)
        End If


        Dim sf = New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'pevent.Graphics.DrawString(Text, New Font("Viner Hand ITC", 28, FontStyle.Bold), Brushes.Lime, ClientRectangle, sf)
        'pevent.Graphics.DrawString(Text, New Font("Segoe", 28, FontStyle.Bold), Brushes.Lime, ClientRectangle, sf)
        TextRenderer.DrawText(pevent.Graphics, Text, New Font("Viner Hand ITC", 28, FontStyle.Bold), ClientRectangle, Color.Violet)
        Parent.Text = $"{paintCount} paints"
        paintCount += 1
    End Sub


End Class
