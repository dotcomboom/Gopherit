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
        Me.SSTabCtl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.SSGuideLbl = New System.Windows.Forms.Label()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ResetBookmarksChk = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.URLHandlerBtn = New System.Windows.Forms.Button()
        Me.HandleGuideLbl = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BrowseLocationBtn = New System.Windows.Forms.Button()
        Me.DownloadLocationTxt = New System.Windows.Forms.TextBox()
        Me.AskDownloadsChk = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.ForeBtn = New System.Windows.Forms.Button()
        Me.FontBtn = New System.Windows.Forms.Button()
        Me.ResetAllBtn = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.iResetBtn = New System.Windows.Forms.Button()
        Me.iColorBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SSTabCtl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkBtn.Location = New System.Drawing.Point(578, 473)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(81, 45)
        Me.OkBtn.TabIndex = 10
        Me.OkBtn.Text = "OK"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SSTabCtl)
        Me.GroupBox1.Controls.Add(Me.SSGuideLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 340)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Styles and Scripts"
        '
        'SSTabCtl
        '
        Me.SSTabCtl.Controls.Add(Me.TabPage1)
        Me.SSTabCtl.Controls.Add(Me.TabPage2)
        Me.SSTabCtl.Location = New System.Drawing.Point(6, 104)
        Me.SSTabCtl.Name = "SSTabCtl"
        Me.SSTabCtl.SelectedIndex = 0
        Me.SSTabCtl.Size = New System.Drawing.Size(297, 230)
        Me.SSTabCtl.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(289, 197)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stylesheet"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 6)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(277, 135)
        Me.TextBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(91, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.Button12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(289, 197)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "JavaScript"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 6)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(277, 135)
        Me.TextBox3.TabIndex = 3
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(91, 147)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(114, 41)
        Me.Button12.TabIndex = 4
        Me.Button12.Text = "Clear"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'SSGuideLbl
        '
        Me.SSGuideLbl.Location = New System.Drawing.Point(6, 22)
        Me.SSGuideLbl.Name = "SSGuideLbl"
        Me.SSGuideLbl.Size = New System.Drawing.Size(297, 91)
        Me.SSGuideLbl.TabIndex = 0
        Me.SSGuideLbl.Text = "You can customize the stylesheet Gopherit uses when it renders gophermaps as HTML" &
    ", and add JavaScript code for extra functionality."
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(491, 473)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(81, 45)
        Me.CancelBtn.TabIndex = 9
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ResetBookmarksChk)
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
        Me.ResetBookmarksChk.Location = New System.Drawing.Point(6, 25)
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
        Me.URLHandlerBtn.Location = New System.Drawing.Point(27, 93)
        Me.URLHandlerBtn.Name = "URLHandlerBtn"
        Me.URLHandlerBtn.Size = New System.Drawing.Size(127, 80)
        Me.URLHandlerBtn.TabIndex = 1
        Me.URLHandlerBtn.Text = "Set as URL Handler"
        Me.URLHandlerBtn.UseVisualStyleBackColor = True
        '
        'HandleGuideLbl
        '
        Me.HandleGuideLbl.Location = New System.Drawing.Point(6, 23)
        Me.HandleGuideLbl.Name = "HandleGuideLbl"
        Me.HandleGuideLbl.Size = New System.Drawing.Size(178, 67)
        Me.HandleGuideLbl.TabIndex = 0
        Me.HandleGuideLbl.Text = "You can set Gopherit to handle gopher:// URLs in your web browser."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.BrowseLocationBtn)
        Me.GroupBox4.Controls.Add(Me.DownloadLocationTxt)
        Me.GroupBox4.Controls.Add(Me.AskDownloadsChk)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 357)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(325, 100)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Downloads"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Location:"
        '
        'BrowseLocationBtn
        '
        Me.BrowseLocationBtn.Location = New System.Drawing.Point(281, 52)
        Me.BrowseLocationBtn.Name = "BrowseLocationBtn"
        Me.BrowseLocationBtn.Size = New System.Drawing.Size(33, 29)
        Me.BrowseLocationBtn.TabIndex = 2
        Me.BrowseLocationBtn.Text = "..."
        Me.BrowseLocationBtn.UseVisualStyleBackColor = True
        '
        'DownloadLocationTxt
        '
        Me.DownloadLocationTxt.Location = New System.Drawing.Point(86, 55)
        Me.DownloadLocationTxt.Name = "DownloadLocationTxt"
        Me.DownloadLocationTxt.ReadOnly = True
        Me.DownloadLocationTxt.Size = New System.Drawing.Size(189, 26)
        Me.DownloadLocationTxt.TabIndex = 1
        '
        'AskDownloadsChk
        '
        Me.AskDownloadsChk.AutoSize = True
        Me.AskDownloadsChk.Location = New System.Drawing.Point(10, 25)
        Me.AskDownloadsChk.Name = "AskDownloadsChk"
        Me.AskDownloadsChk.Size = New System.Drawing.Size(205, 24)
        Me.AskDownloadsChk.TabIndex = 0
        Me.AskDownloadsChk.Text = "Ask before downloading"
        Me.AskDownloadsChk.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BackBtn)
        Me.GroupBox5.Controls.Add(Me.ForeBtn)
        Me.GroupBox5.Controls.Add(Me.FontBtn)
        Me.GroupBox5.Location = New System.Drawing.Point(343, 267)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(168, 139)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Plain Text/Mapper"
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.White
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Location = New System.Drawing.Point(106, 26)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(53, 53)
        Me.BackBtn.TabIndex = 2
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'ForeBtn
        '
        Me.ForeBtn.BackColor = System.Drawing.Color.Black
        Me.ForeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForeBtn.Location = New System.Drawing.Point(106, 80)
        Me.ForeBtn.Name = "ForeBtn"
        Me.ForeBtn.Size = New System.Drawing.Size(53, 53)
        Me.ForeBtn.TabIndex = 1
        Me.ForeBtn.UseVisualStyleBackColor = False
        '
        'FontBtn
        '
        Me.FontBtn.Location = New System.Drawing.Point(7, 26)
        Me.FontBtn.Name = "FontBtn"
        Me.FontBtn.Size = New System.Drawing.Size(86, 107)
        Me.FontBtn.TabIndex = 0
        Me.FontBtn.Text = "Font"
        Me.FontBtn.UseVisualStyleBackColor = True
        '
        'ResetAllBtn
        '
        Me.ResetAllBtn.Location = New System.Drawing.Point(12, 473)
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
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 535)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.ResetAllBtn)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OkBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.SSTabCtl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OkBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SSGuideLbl As Label
    Friend WithEvents CancelBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ResetBookmarksChk As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents URLHandlerBtn As Button
    Friend WithEvents HandleGuideLbl As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BrowseLocationBtn As Button
    Friend WithEvents DownloadLocationTxt As TextBox
    Friend WithEvents AskDownloadsChk As CheckBox
    Friend WithEvents Label3 As Label
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button12 As Button
End Class
