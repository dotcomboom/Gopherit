<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.SSGuideLbl = New System.Windows.Forms.Label()
        Me.SSTabCtl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.StyleTxt = New System.Windows.Forms.TextBox()
        Me.StyleResetBtn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.JavaTxt = New System.Windows.Forms.TextBox()
        Me.JavaClearBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ResetBookmarksChk = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.URLHandlerBtn = New System.Windows.Forms.Button()
        Me.HandleGuideLbl = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DownloadLocationBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DownloadLocationTxt = New System.Windows.Forms.TextBox()
        Me.AskDownloadsChk = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ForeBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.FontBtn = New System.Windows.Forms.Button()
        Me.ResetAllBtn = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.iResetBtn = New System.Windows.Forms.Button()
        Me.iColorBtn = New System.Windows.Forms.Button()
        Me.BookmarksHeight = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SSTabCtl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.BookmarksHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkBtn.Location = New System.Drawing.Point(582, 476)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(81, 45)
        Me.OkBtn.TabIndex = 10
        Me.OkBtn.Text = "OK"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 339)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Styles and Scripts"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.SSGuideLbl, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.SSTabCtl, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(303, 314)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'SSGuideLbl
        '
        Me.SSGuideLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SSGuideLbl.Location = New System.Drawing.Point(3, 0)
        Me.SSGuideLbl.Name = "SSGuideLbl"
        Me.SSGuideLbl.Size = New System.Drawing.Size(297, 82)
        Me.SSGuideLbl.TabIndex = 0
        Me.SSGuideLbl.Text = "You can customize the stylesheet Gopherit uses when it renders gophermaps as HTML" &
    ", and add JavaScript code for extra functionality."
        '
        'SSTabCtl
        '
        Me.SSTabCtl.Controls.Add(Me.TabPage1)
        Me.SSTabCtl.Controls.Add(Me.TabPage2)
        Me.SSTabCtl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SSTabCtl.Location = New System.Drawing.Point(3, 85)
        Me.SSTabCtl.Name = "SSTabCtl"
        Me.SSTabCtl.SelectedIndex = 0
        Me.SSTabCtl.Size = New System.Drawing.Size(297, 226)
        Me.SSTabCtl.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(289, 193)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stylesheet"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.StyleTxt, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.StyleResetBtn, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(283, 187)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'StyleTxt
        '
        Me.StyleTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StyleTxt.Location = New System.Drawing.Point(3, 3)
        Me.StyleTxt.Multiline = True
        Me.StyleTxt.Name = "StyleTxt"
        Me.StyleTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StyleTxt.Size = New System.Drawing.Size(277, 141)
        Me.StyleTxt.TabIndex = 1
        '
        'StyleResetBtn
        '
        Me.StyleResetBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StyleResetBtn.Location = New System.Drawing.Point(100, 150)
        Me.StyleResetBtn.Margin = New System.Windows.Forms.Padding(100, 3, 100, 3)
        Me.StyleResetBtn.Name = "StyleResetBtn"
        Me.StyleResetBtn.Size = New System.Drawing.Size(83, 34)
        Me.StyleResetBtn.TabIndex = 2
        Me.StyleResetBtn.Text = "Reset"
        Me.StyleResetBtn.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(290, 193)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "JavaScript"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.JavaTxt, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.JavaClearBtn, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(284, 187)
        Me.TableLayoutPanel5.TabIndex = 5
        '
        'JavaTxt
        '
        Me.JavaTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JavaTxt.Location = New System.Drawing.Point(3, 3)
        Me.JavaTxt.Multiline = True
        Me.JavaTxt.Name = "JavaTxt"
        Me.JavaTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.JavaTxt.Size = New System.Drawing.Size(278, 141)
        Me.JavaTxt.TabIndex = 3
        '
        'JavaClearBtn
        '
        Me.JavaClearBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JavaClearBtn.Location = New System.Drawing.Point(100, 150)
        Me.JavaClearBtn.Margin = New System.Windows.Forms.Padding(100, 3, 100, 3)
        Me.JavaClearBtn.Name = "JavaClearBtn"
        Me.JavaClearBtn.Size = New System.Drawing.Size(84, 34)
        Me.JavaClearBtn.TabIndex = 4
        Me.JavaClearBtn.Text = "Clear"
        Me.JavaClearBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(495, 476)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(81, 45)
        Me.CancelBtn.TabIndex = 9
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Location = New System.Drawing.Point(327, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 59)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bookmarks"
        '
        'ResetBookmarksChk
        '
        Me.ResetBookmarksChk.AutoSize = True
        Me.ResetBookmarksChk.Location = New System.Drawing.Point(3, 3)
        Me.ResetBookmarksChk.Name = "ResetBookmarksChk"
        Me.ResetBookmarksChk.Size = New System.Drawing.Size(78, 24)
        Me.ResetBookmarksChk.TabIndex = 0
        Me.ResetBookmarksChk.Text = "Reset"
        Me.ResetBookmarksChk.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.URLHandlerBtn)
        Me.GroupBox3.Controls.Add(Me.HandleGuideLbl)
        Me.GroupBox3.Location = New System.Drawing.Point(327, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 184)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "URL Handler"
        '
        'URLHandlerBtn
        '
        Me.URLHandlerBtn.Location = New System.Drawing.Point(6, 107)
        Me.URLHandlerBtn.Name = "URLHandlerBtn"
        Me.URLHandlerBtn.Size = New System.Drawing.Size(169, 66)
        Me.URLHandlerBtn.TabIndex = 1
        Me.URLHandlerBtn.Text = "Set as URL Handler"
        Me.URLHandlerBtn.UseVisualStyleBackColor = True
        '
        'HandleGuideLbl
        '
        Me.HandleGuideLbl.Location = New System.Drawing.Point(6, 23)
        Me.HandleGuideLbl.Name = "HandleGuideLbl"
        Me.HandleGuideLbl.Size = New System.Drawing.Size(169, 81)
        Me.HandleGuideLbl.TabIndex = 0
        Me.HandleGuideLbl.Text = "You can set Gopherit to handle gopher:// URLs in your web browser."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DownloadLocationBtn)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.DownloadLocationTxt)
        Me.GroupBox4.Controls.Add(Me.AskDownloadsChk)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 357)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(309, 104)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Downloads"
        '
        'DownloadLocationBtn
        '
        Me.DownloadLocationBtn.Location = New System.Drawing.Point(217, 22)
        Me.DownloadLocationBtn.Name = "DownloadLocationBtn"
        Me.DownloadLocationBtn.Size = New System.Drawing.Size(86, 34)
        Me.DownloadLocationBtn.TabIndex = 6
        Me.DownloadLocationBtn.Text = "Browse"
        Me.DownloadLocationBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Location:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DownloadLocationTxt
        '
        Me.DownloadLocationTxt.Location = New System.Drawing.Point(82, 60)
        Me.DownloadLocationTxt.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.DownloadLocationTxt.Name = "DownloadLocationTxt"
        Me.DownloadLocationTxt.ReadOnly = True
        Me.DownloadLocationTxt.Size = New System.Drawing.Size(221, 26)
        Me.DownloadLocationTxt.TabIndex = 3
        '
        'AskDownloadsChk
        '
        Me.AskDownloadsChk.AutoSize = True
        Me.AskDownloadsChk.Location = New System.Drawing.Point(6, 28)
        Me.AskDownloadsChk.Name = "AskDownloadsChk"
        Me.AskDownloadsChk.Size = New System.Drawing.Size(205, 24)
        Me.AskDownloadsChk.TabIndex = 0
        Me.AskDownloadsChk.Text = "Ask before downloading"
        Me.AskDownloadsChk.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox5.Location = New System.Drawing.Point(327, 267)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(168, 139)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Plain Text/Mapper"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ForeBtn, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BackBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FontBtn, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(9)
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(162, 114)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'ForeBtn
        '
        Me.ForeBtn.BackColor = System.Drawing.Color.Black
        Me.ForeBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForeBtn.Location = New System.Drawing.Point(108, 60)
        Me.ForeBtn.Name = "ForeBtn"
        Me.ForeBtn.Size = New System.Drawing.Size(42, 42)
        Me.ForeBtn.TabIndex = 1
        Me.ForeBtn.UseVisualStyleBackColor = False
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.White
        Me.BackBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Location = New System.Drawing.Point(108, 12)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(42, 42)
        Me.BackBtn.TabIndex = 2
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'FontBtn
        '
        Me.FontBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontBtn.Location = New System.Drawing.Point(12, 12)
        Me.FontBtn.Name = "FontBtn"
        Me.TableLayoutPanel2.SetRowSpan(Me.FontBtn, 2)
        Me.FontBtn.Size = New System.Drawing.Size(90, 90)
        Me.FontBtn.TabIndex = 0
        Me.FontBtn.Text = "Font"
        Me.FontBtn.UseVisualStyleBackColor = True
        '
        'ResetAllBtn
        '
        Me.ResetAllBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ResetAllBtn.Location = New System.Drawing.Point(12, 476)
        Me.ResetAllBtn.Name = "ResetAllBtn"
        Me.ResetAllBtn.Size = New System.Drawing.Size(164, 45)
        Me.ResetAllBtn.TabIndex = 12
        Me.ResetAllBtn.Text = "Reset All Settings"
        Me.ResetAllBtn.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.iResetBtn)
        Me.GroupBox6.Controls.Add(Me.iColorBtn)
        Me.GroupBox6.Location = New System.Drawing.Point(517, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(142, 155)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Interface"
        '
        'iResetBtn
        '
        Me.iResetBtn.Location = New System.Drawing.Point(27, 88)
        Me.iResetBtn.Name = "iResetBtn"
        Me.iResetBtn.Size = New System.Drawing.Size(94, 43)
        Me.iResetBtn.TabIndex = 4
        Me.iResetBtn.Text = "Default"
        Me.iResetBtn.UseVisualStyleBackColor = True
        '
        'iColorBtn
        '
        Me.iColorBtn.BackColor = System.Drawing.SystemColors.Control
        Me.iColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iColorBtn.Location = New System.Drawing.Point(47, 29)
        Me.iColorBtn.Name = "iColorBtn"
        Me.iColorBtn.Size = New System.Drawing.Size(53, 53)
        Me.iColorBtn.TabIndex = 3
        Me.iColorBtn.UseVisualStyleBackColor = False
        '
        'BookmarksHeight
        '
        Me.BookmarksHeight.Location = New System.Drawing.Point(92, 3)
        Me.BookmarksHeight.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.BookmarksHeight.Name = "BookmarksHeight"
        Me.BookmarksHeight.Size = New System.Drawing.Size(83, 26)
        Me.BookmarksHeight.TabIndex = 13
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BookmarksHeight, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ResetBookmarksChk, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(178, 34)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 538)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.ResetAllBtn)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OkBtn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.SSTabCtl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.BookmarksHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OkBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StyleResetBtn As Button
    Friend WithEvents StyleTxt As TextBox
    Friend WithEvents SSGuideLbl As Label
    Friend WithEvents CancelBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ResetBookmarksChk As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents URLHandlerBtn As Button
    Friend WithEvents HandleGuideLbl As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents AskDownloadsChk As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents FontBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents ForeBtn As Button
    Friend WithEvents ResetAllBtn As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents iResetBtn As Button
    Friend WithEvents iColorBtn As Button
    Friend WithEvents SSTabCtl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents JavaTxt As TextBox
    Friend WithEvents JavaClearBtn As Button
    Friend WithEvents DownloadLocationTxt As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents DownloadLocationBtn As Button
    Friend WithEvents BookmarksHeight As NumericUpDown
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
