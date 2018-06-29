<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mapper
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mapper))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ItemDescLbl = New System.Windows.Forms.Label()
        Me.value4 = New System.Windows.Forms.TextBox()
        Me.value3 = New System.Windows.Forms.TextBox()
        Me.value2 = New System.Windows.Forms.TextBox()
        Me.value1 = New System.Windows.Forms.TextBox()
        Me.ItemCmb = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.OpenBtn = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.AcceptsTab = True
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(384, 435)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddBtn)
        Me.GroupBox1.Controls.Add(Me.ItemDescLbl)
        Me.GroupBox1.Controls.Add(Me.value4)
        Me.GroupBox1.Controls.Add(Me.value3)
        Me.GroupBox1.Controls.Add(Me.value2)
        Me.GroupBox1.Controls.Add(Me.value1)
        Me.GroupBox1.Controls.Add(Me.ItemCmb)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 321)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insert"
        '
        'AddBtn
        '
        Me.AddBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddBtn.Enabled = False
        Me.AddBtn.Location = New System.Drawing.Point(152, 282)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(46, 33)
        Me.AddBtn.TabIndex = 7
        Me.AddBtn.Text = "+"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ItemDescLbl
        '
        Me.ItemDescLbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemDescLbl.Location = New System.Drawing.Point(10, 190)
        Me.ItemDescLbl.Name = "ItemDescLbl"
        Me.ItemDescLbl.Size = New System.Drawing.Size(188, 128)
        Me.ItemDescLbl.TabIndex = 6
        Me.ItemDescLbl.Text = "Select an item type."
        '
        'value4
        '
        Me.value4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.value4.Enabled = False
        Me.value4.Location = New System.Drawing.Point(9, 157)
        Me.value4.Name = "value4"
        Me.value4.Size = New System.Drawing.Size(189, 26)
        Me.value4.TabIndex = 5
        Me.value4.Text = "70"
        '
        'value3
        '
        Me.value3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.value3.Enabled = False
        Me.value3.Location = New System.Drawing.Point(9, 123)
        Me.value3.Name = "value3"
        Me.value3.Size = New System.Drawing.Size(189, 26)
        Me.value3.TabIndex = 4
        '
        'value2
        '
        Me.value2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.value2.Enabled = False
        Me.value2.Location = New System.Drawing.Point(9, 91)
        Me.value2.Name = "value2"
        Me.value2.Size = New System.Drawing.Size(189, 26)
        Me.value2.TabIndex = 3
        '
        'value1
        '
        Me.value1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.value1.Enabled = False
        Me.value1.Location = New System.Drawing.Point(9, 59)
        Me.value1.Name = "value1"
        Me.value1.Size = New System.Drawing.Size(189, 26)
        Me.value1.TabIndex = 2
        '
        'ItemCmb
        '
        Me.ItemCmb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ItemCmb.FormattingEnabled = True
        Me.ItemCmb.Items.AddRange(New Object() {"0 Text File", "1 Directory", "3 Error", "4 HQX filer", "5 PC binary", "6 UNIX uuencoded file", "7 Search Service", "8 Telnet session", "9 Binary file", "g GIF image", "s Sound", "I Generic image", "h HTML Document or Off-Gopher Resource"})
        Me.ItemCmb.Location = New System.Drawing.Point(9, 25)
        Me.ItemCmb.Name = "ItemCmb"
        Me.ItemCmb.Size = New System.Drawing.Size(189, 28)
        Me.ItemCmb.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 435)
        Me.Panel2.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SaveBtn)
        Me.GroupBox2.Controls.Add(Me.OpenBtn)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 114)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "File"
        '
        'SaveBtn
        '
        Me.SaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBtn.Location = New System.Drawing.Point(118, 25)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(77, 77)
        Me.SaveBtn.TabIndex = 1
        Me.SaveBtn.Text = "Save As"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'OpenBtn
        '
        Me.OpenBtn.Location = New System.Drawing.Point(25, 25)
        Me.OpenBtn.Name = "OpenBtn"
        Me.OpenBtn.Size = New System.Drawing.Size(77, 77)
        Me.OpenBtn.TabIndex = 0
        Me.OpenBtn.Text = "Open"
        Me.OpenBtn.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(598, 435)
        Me.SplitContainer1.SplitterDistance = 384
        Me.SplitContainer1.TabIndex = 3
        '
        'Mapper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 435)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(620, 491)
        Me.Name = "Mapper"
        Me.Text = "Mapper"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ItemCmb As ComboBox
    Friend WithEvents ItemDescLbl As Label
    Friend WithEvents value4 As TextBox
    Friend WithEvents value3 As TextBox
    Friend WithEvents value2 As TextBox
    Friend WithEvents value1 As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents OpenBtn As Button
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
