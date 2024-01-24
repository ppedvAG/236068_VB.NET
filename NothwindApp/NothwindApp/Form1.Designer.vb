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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        DataGridView1 = New DataGridView()
        Button7 = New Button()
        FlowLayoutPanel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.BackColor = Color.DarkSalmon
        FlowLayoutPanel1.Controls.Add(Button1)
        FlowLayoutPanel1.Controls.Add(Button2)
        FlowLayoutPanel1.Controls.Add(Label1)
        FlowLayoutPanel1.Controls.Add(TextBox1)
        FlowLayoutPanel1.Controls.Add(Button3)
        FlowLayoutPanel1.Controls.Add(Button4)
        FlowLayoutPanel1.Controls.Add(Button5)
        FlowLayoutPanel1.Controls.Add(Button6)
        FlowLayoutPanel1.Controls.Add(Button7)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(906, 192)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(254, 42)
        Button1.TabIndex = 0
        Button1.Text = "Laden alle Employees"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button2.Location = New Point(263, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(202, 42)
        Button2.TabIndex = 1
        Button2.Text = "Neuer Employee"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(471, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 32)
        Label1.TabIndex = 2
        Label1.Text = "Suche:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Left
        TextBox1.Location = New Point(561, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 39)
        TextBox1.TabIndex = 3
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button3.Location = New Point(767, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(103, 42)
        Button3.TabIndex = 4
        Button3.Text = "Suchen"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.AutoSize = True
        Button4.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button4.Location = New Point(3, 51)
        Button4.Name = "Button4"
        Button4.Size = New Size(258, 42)
        Button4.TabIndex = 5
        Button4.Text = "Bogus 100 Employees"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.AutoSize = True
        Button5.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button5.Location = New Point(267, 51)
        Button5.Name = "Button5"
        Button5.Size = New Size(420, 42)
        Button5.TabIndex = 6
        Button5.Text = "Nur alle aus diesem Jahrtausend (VB)"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.AutoSize = True
        Button6.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button6.Location = New Point(3, 99)
        Button6.Name = "Button6"
        Button6.Size = New Size(508, 42)
        Button6.TabIndex = 7
        Button6.Text = "Nur alle aus diesem Jahrtausend (Linq Query)"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 192)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.RowTemplate.Height = 41
        DataGridView1.Size = New Size(906, 258)
        DataGridView1.TabIndex = 1
        ' 
        ' Button7
        ' 
        Button7.AutoSize = True
        Button7.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button7.Location = New Point(3, 147)
        Button7.Name = "Button7"
        Button7.Size = New Size(527, 42)
        Button7.TabIndex = 8
        Button7.Text = "Nur alle aus diesem Jahrtausend (Linq Lambda)"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(906, 450)
        Controls.Add(DataGridView1)
        Controls.Add(FlowLayoutPanel1)
        Name = "Form1"
        Text = "Form1"
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button

End Class
