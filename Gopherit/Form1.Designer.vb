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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.TabCtl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.BrowserCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookmarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.AddressCmb = New System.Windows.Forms.ComboBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.BookmarksLsV = New System.Windows.Forms.ListView()
        Me.BookmarkCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BookmarkThisPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveBookmarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.MapperBtn = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UrlLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabCtl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.BrowserCMS.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.BookmarkCMS.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GoBtn
        '
        Me.GoBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GoBtn.Location = New System.Drawing.Point(694, 3)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(58, 29)
        Me.GoBtn.TabIndex = 2
        Me.GoBtn.Text = "Go"
        Me.GoBtn.UseVisualStyleBackColor = True
        '
        'TabCtl
        '
        Me.TabCtl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabCtl.Controls.Add(Me.TabPage1)
        Me.TabCtl.Controls.Add(Me.TabPage2)
        Me.TabCtl.Location = New System.Drawing.Point(11, 154)
        Me.TabCtl.Name = "TabCtl"
        Me.TabCtl.SelectedIndex = 0
        Me.TabCtl.Size = New System.Drawing.Size(755, 411)
        Me.TabCtl.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(747, 378)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gopher Menu"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.ContextMenuStrip = Me.BrowserCMS
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(741, 372)
        Me.WebBrowser1.TabIndex = 2
        Me.WebBrowser1.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'BrowserCMS
        '
        Me.BrowserCMS.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BrowserCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.BackToolStripMenuItem, Me.BookmarkToolStripMenuItem, Me.SaveToFileToolStripMenuItem})
        Me.BrowserCMS.Name = "ContextMenuStrip2"
        Me.BrowserCMS.Size = New System.Drawing.Size(206, 124)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Enabled = False
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'BookmarkToolStripMenuItem
        '
        Me.BookmarkToolStripMenuItem.Name = "BookmarkToolStripMenuItem"
        Me.BookmarkToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.BookmarkToolStripMenuItem.Text = "Add bookmark"
        '
        'SaveToFileToolStripMenuItem
        '
        Me.SaveToFileToolStripMenuItem.Name = "SaveToFileToolStripMenuItem"
        Me.SaveToFileToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.SaveToFileToolStripMenuItem.Text = "Save to file"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(747, 378)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Plain text"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.ContextMenuStrip = Me.BrowserCMS
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(3, 3)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(741, 372)
        Me.TextBox2.TabIndex = 1
        '
        'AddressCmb
        '
        Me.AddressCmb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddressCmb.FormattingEnabled = True
        Me.AddressCmb.Location = New System.Drawing.Point(67, 3)
        Me.AddressCmb.Name = "AddressCmb"
        Me.AddressCmb.Size = New System.Drawing.Size(621, 28)
        Me.AddressCmb.TabIndex = 1
        Me.AddressCmb.Text = "gopher://tilde.town/1/~dcb/gopherit"
        '
        'BackBtn
        '
        Me.BackBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackBtn.Enabled = False
        Me.BackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.Location = New System.Drawing.Point(3, 3)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(58, 29)
        Me.BackBtn.TabIndex = 0
        Me.BackBtn.Text = "<"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'BookmarksLsV
        '
        Me.BookmarksLsV.ContextMenuStrip = Me.BookmarkCMS
        Me.BookmarksLsV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookmarksLsV.Location = New System.Drawing.Point(3, 3)
        Me.BookmarksLsV.MultiSelect = False
        Me.BookmarksLsV.Name = "BookmarksLsV"
        Me.TableLayoutPanel2.SetRowSpan(Me.BookmarksLsV, 2)
        Me.BookmarksLsV.Size = New System.Drawing.Size(649, 92)
        Me.BookmarksLsV.TabIndex = 4
        Me.BookmarksLsV.UseCompatibleStateImageBehavior = False
        Me.BookmarksLsV.View = System.Windows.Forms.View.List
        '
        'BookmarkCMS
        '
        Me.BookmarkCMS.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BookmarkCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookmarkThisPageToolStripMenuItem, Me.RemoveBookmarkToolStripMenuItem})
        Me.BookmarkCMS.Name = "ContextMenuStrip1"
        Me.BookmarkCMS.Size = New System.Drawing.Size(236, 64)
        '
        'BookmarkThisPageToolStripMenuItem
        '
        Me.BookmarkThisPageToolStripMenuItem.Name = "BookmarkThisPageToolStripMenuItem"
        Me.BookmarkThisPageToolStripMenuItem.Size = New System.Drawing.Size(235, 30)
        Me.BookmarkThisPageToolStripMenuItem.Text = "Add bookmark"
        '
        'RemoveBookmarkToolStripMenuItem
        '
        Me.RemoveBookmarkToolStripMenuItem.Enabled = False
        Me.RemoveBookmarkToolStripMenuItem.Name = "RemoveBookmarkToolStripMenuItem"
        Me.RemoveBookmarkToolStripMenuItem.Size = New System.Drawing.Size(235, 30)
        Me.RemoveBookmarkToolStripMenuItem.Text = "Remove bookmark"
        '
        'SettingsBtn
        '
        Me.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingsBtn.Location = New System.Drawing.Point(658, 3)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(94, 43)
        Me.SettingsBtn.TabIndex = 7
        Me.SettingsBtn.Text = "Settings"
        Me.SettingsBtn.UseVisualStyleBackColor = True
        '
        'MapperBtn
        '
        Me.MapperBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MapperBtn.Location = New System.Drawing.Point(658, 52)
        Me.MapperBtn.Name = "MapperBtn"
        Me.MapperBtn.Size = New System.Drawing.Size(94, 43)
        Me.MapperBtn.TabIndex = 8
        Me.MapperBtn.Text = "Mapper"
        Me.MapperBtn.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLbl, Me.UrlLbl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 568)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(778, 30)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLbl
        '
        Me.StatusLbl.ForeColor = System.Drawing.Color.Green
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(60, 25)
        Me.StatusLbl.Text = "Ready"
        Me.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UrlLbl
        '
        Me.UrlLbl.Margin = New System.Windows.Forms.Padding(0, 3, 5, 2)
        Me.UrlLbl.Name = "UrlLbl"
        Me.UrlLbl.Size = New System.Drawing.Size(698, 25)
        Me.UrlLbl.Spring = True
        Me.UrlLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BackBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AddressCmb, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GoBtn, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(755, 35)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BookmarksLsV, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SettingsBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MapperBtn, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(11, 50)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(755, 98)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 598)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabCtl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(456, 292)
        Me.Name = "Form1"
        Me.Text = "Gopherit"
        Me.TabCtl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.BrowserCMS.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.BookmarkCMS.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GoBtn As Button
    Friend WithEvents TabCtl As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents AddressCmb As ComboBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents BookmarksLsV As ListView
    Friend WithEvents BookmarkCMS As ContextMenuStrip
    Friend WithEvents BookmarkThisPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveBookmarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsBtn As Button
    Friend WithEvents MapperBtn As Button
    Friend WithEvents BrowserCMS As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookmarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLbl As ToolStripStatusLabel
    Friend WithEvents UrlLbl As ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
