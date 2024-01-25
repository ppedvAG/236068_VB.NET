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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Button1 = New Button()
        Button2 = New Button()
        Button10 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        DataGridView1 = New DataGridView()
        FirstNameColumn = New DataGridViewTextBoxColumn()
        LastNameColumn = New DataGridViewTextBoxColumn()
        SaveFileDialog1 = New SaveFileDialog()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        SplitContainer1 = New SplitContainer()
        ListBox1 = New ListBox()
        nachnameTextBox = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        gebDatumDateTimePicker = New DateTimePicker()
        vornameTextBox = New TextBox()
        Label3 = New Label()
        TabPage2 = New TabPage()
        Label2 = New Label()
        TrackBar1 = New TrackBar()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        BindingSource1 = New BindingSource(components)
        FlowLayoutPanel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.BackColor = Color.DarkSalmon
        FlowLayoutPanel1.Controls.Add(Button1)
        FlowLayoutPanel1.Controls.Add(Button2)
        FlowLayoutPanel1.Controls.Add(Button10)
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
        FlowLayoutPanel1.Size = New Size(1334, 144)
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
        ' Button10
        ' 
        Button10.AutoSize = True
        Button10.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.SetFlowBreak(Button10, True)
        Button10.Location = New Point(471, 3)
        Button10.Name = "Button10"
        Button10.Size = New Size(170, 42)
        Button10.TabIndex = 11
        Button10.Text = "💾 Speichern"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(3, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 32)
        Label1.TabIndex = 2
        Label1.Text = "Suche:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Left
        TextBox1.Location = New Point(93, 52)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 39)
        TextBox1.TabIndex = 3
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button3.Location = New Point(299, 51)
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
        Button4.Location = New Point(408, 51)
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
        Button5.Location = New Point(672, 51)
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
        ' Button7
        ' 
        Button7.AutoSize = True
        Button7.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button7.Location = New Point(517, 99)
        Button7.Name = "Button7"
        Button7.Size = New Size(527, 42)
        Button7.TabIndex = 8
        Button7.Text = "Nur alle aus diesem Jahrtausend (Linq Lambda)"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {FirstNameColumn, LastNameColumn})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.RowTemplate.Height = 41
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(437, 422)
        DataGridView1.TabIndex = 1
        ' 
        ' FirstNameColumn
        ' 
        FirstNameColumn.DataPropertyName = "FirstName"
        FirstNameColumn.HeaderText = "Vorname"
        FirstNameColumn.MinimumWidth = 10
        FirstNameColumn.Name = "FirstNameColumn"
        FirstNameColumn.ReadOnly = True
        FirstNameColumn.Width = 200
        ' 
        ' LastNameColumn
        ' 
        LastNameColumn.DataPropertyName = "LastName"
        LastNameColumn.HeaderText = "Nachname"
        LastNameColumn.MinimumWidth = 10
        LastNameColumn.Name = "LastNameColumn"
        LastNameColumn.ReadOnly = True
        LastNameColumn.Width = 200
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.Filter = "JSON-Datei|*.json|Alle Dateitypen|*.*"
        SaveFileDialog1.Title = "Die JSON Datei"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 144)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1334, 482)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(SplitContainer1)
        TabPage1.Location = New Point(8, 46)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1318, 428)
        TabPage1.TabIndex = 0
        TabPage1.Text = "👨‍🏭 Employees"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(3, 3)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(DataGridView1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(ListBox1)
        SplitContainer1.Panel2.Controls.Add(nachnameTextBox)
        SplitContainer1.Panel2.Controls.Add(Label5)
        SplitContainer1.Panel2.Controls.Add(Label4)
        SplitContainer1.Panel2.Controls.Add(gebDatumDateTimePicker)
        SplitContainer1.Panel2.Controls.Add(vornameTextBox)
        SplitContainer1.Panel2.Controls.Add(Label3)
        SplitContainer1.Size = New Size(1312, 422)
        SplitContainer1.SplitterDistance = 437
        SplitContainer1.TabIndex = 2
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 32
        ListBox1.Location = New Point(44, 205)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(667, 196)
        ListBox1.TabIndex = 6
        ' 
        ' nachnameTextBox
        ' 
        nachnameTextBox.Location = New Point(180, 91)
        nachnameTextBox.Name = "nachnameTextBox"
        nachnameTextBox.Size = New Size(400, 39)
        nachnameTextBox.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(45, 94)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 32)
        Label5.TabIndex = 4
        Label5.Text = "Nachname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 32)
        Label4.TabIndex = 3
        Label4.Text = "Vorname"
        ' 
        ' gebDatumDateTimePicker
        ' 
        gebDatumDateTimePicker.Location = New Point(180, 136)
        gebDatumDateTimePicker.Name = "gebDatumDateTimePicker"
        gebDatumDateTimePicker.Size = New Size(400, 39)
        gebDatumDateTimePicker.TabIndex = 2
        ' 
        ' vornameTextBox
        ' 
        vornameTextBox.Location = New Point(180, 42)
        vornameTextBox.Name = "vornameTextBox"
        vornameTextBox.Size = New Size(400, 39)
        vornameTextBox.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(45, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 32)
        Label3.TabIndex = 0
        Label3.Text = "GebDatum"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(TrackBar1)
        TabPage2.Controls.Add(TextBox3)
        TabPage2.Controls.Add(TextBox2)
        TabPage2.Location = New Point(8, 46)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1318, 428)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Hallo Binding"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(612, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 32)
        Label2.TabIndex = 2
        Label2.Text = "Label2"
        ' 
        ' TrackBar1
        ' 
        TrackBar1.Location = New Point(611, 49)
        TrackBar1.Maximum = 100
        TrackBar1.Minimum = 10
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Size = New Size(208, 90)
        TrackBar1.TabIndex = 1
        TrackBar1.Value = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(209, 130)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(282, 39)
        TextBox3.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(130, 67)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(282, 39)
        TextBox2.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1334, 626)
        Controls.Add(TabControl1)
        Controls.Add(FlowLayoutPanel1)
        Name = "Form1"
        Text = "Form1"
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button10 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gebDatumDateTimePicker As DateTimePicker
    Friend WithEvents vornameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nachnameTextBox As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents FirstNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameColumn As DataGridViewTextBoxColumn

End Class
