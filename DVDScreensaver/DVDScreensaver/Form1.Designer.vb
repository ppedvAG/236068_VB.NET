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
        components = New ComponentModel.Container()
        Timer1 = New Timer(components)
        MyButton1 = New MyButton()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1
        ' 
        ' MyButton1
        ' 
        MyButton1.Location = New Point(151, 146)
        MyButton1.Name = "MyButton1"
        MyButton1.Size = New Size(453, 184)
        MyButton1.TabIndex = 1
        MyButton1.Text = "📀 DVD"
        MyButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        MyButton1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(800, 450)
        Controls.Add(MyButton1)
        Name = "Form1"
        Text = "4 paints"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MyButton1 As MyButton

End Class
