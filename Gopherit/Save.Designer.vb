<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Save
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
        Me.FilenameTxt = New System.Windows.Forms.TextBox()
        Me.CleanChk = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StripChk = New System.Windows.Forms.CheckBox()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilenameTxt
        '
        Me.FilenameTxt.Location = New System.Drawing.Point(13, 13)
        Me.FilenameTxt.Name = "FilenameTxt"
        Me.FilenameTxt.Size = New System.Drawing.Size(355, 26)
        Me.FilenameTxt.TabIndex = 0
        '
        'CleanChk
        '
        Me.CleanChk.AutoSize = True
        Me.CleanChk.Checked = True
        Me.CleanChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CleanChk.Location = New System.Drawing.Point(6, 25)
        Me.CleanChk.Name = "CleanChk"
        Me.CleanChk.Size = New System.Drawing.Size(146, 24)
        Me.CleanChk.TabIndex = 1
        Me.CleanChk.Text = "Clean inline text"
        Me.CleanChk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StripChk)
        Me.GroupBox1.Controls.Add(Me.CleanChk)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 98)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gopher Menu"
        '
        'StripChk
        '
        Me.StripChk.AutoSize = True
        Me.StripChk.Location = New System.Drawing.Point(6, 55)
        Me.StripChk.Name = "StripChk"
        Me.StripChk.Size = New System.Drawing.Size(136, 24)
        Me.StripChk.TabIndex = 2
        Me.StripChk.Text = "Strip selectors"
        Me.StripChk.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(200, 149)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(81, 45)
        Me.CancelBtn.TabIndex = 11
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkBtn.Location = New System.Drawing.Point(287, 149)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(81, 45)
        Me.OkBtn.TabIndex = 12
        Me.OkBtn.Text = "OK"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(381, 206)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FilenameTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Save"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Save to file"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FilenameTxt As TextBox
    Friend WithEvents CleanChk As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StripChk As CheckBox
    Friend WithEvents CancelBtn As Button
    Friend WithEvents OkBtn As Button
End Class
