<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ListBox1 = New ListBox()
        Button1 = New Button()
        TrackBar1 = New TrackBar()
        Button2 = New Button()
        Button3 = New Button()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 32
        ListBox1.Location = New Point(12, 178)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(776, 612)
        ListBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 126)
        Button1.Name = "Button1"
        Button1.Size = New Size(268, 46)
        Button1.TabIndex = 1
        Button1.Text = "Erstelle 10 Einträge"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TrackBar1
        ' 
        TrackBar1.BackColor = Color.White
        TrackBar1.Location = New Point(12, 12)
        TrackBar1.Maximum = 50
        TrackBar1.Minimum = 1
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Size = New Size(776, 90)
        TrackBar1.TabIndex = 2
        TrackBar1.Value = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(286, 126)
        Button2.Name = "Button2"
        Button2.Size = New Size(248, 46)
        Button2.TabIndex = 3
        Button2.Text = "In Datei speichern"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(540, 126)
        Button3.Name = "Button3"
        Button3.Size = New Size(248, 46)
        Button3.TabIndex = 3
        Button3.Text = "Aus Datei lesen"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(806, 814)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TrackBar1)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Form1"
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
