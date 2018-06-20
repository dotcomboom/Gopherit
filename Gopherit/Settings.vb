Imports System.Security.Principal
Imports Microsoft.Win32

Public Class Settings
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = My.Settings.StyleDefault
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Stylesheet = TextBox1.Text
        If CheckBox1.Checked Then
            My.Settings.Bookmarks.Clear()
            My.Settings.Bookmarks.Add("tilde.town/1/~dcb/gopherit")
            My.Settings.Bookmarks.Add("gopherproject.org/1")
            My.Settings.Bookmarks.Add("gopher.floodgap.com/1")
            CheckBox1.Checked = False
        End If
        My.Settings.AskBeforeDownloading = CheckBox2.Checked
        My.Settings.DownloadDir = TextBox2.Text
        My.Settings.PTFont = Button6.Font
        My.Settings.PTForeColor = Button7.BackColor
        My.Settings.PTBackColor = Button8.BackColor
        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DownloadDir) Then
            Try
                My.Computer.FileSystem.CreateDirectory(My.Settings.DownloadDir)
            Catch ex As Exception
                My.Settings.DownloadDir = My.Computer.FileSystem.CurrentDirectory & "\Downloads"
                If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DownloadDir) Then
                    My.Computer.FileSystem.CreateDirectory(My.Settings.DownloadDir)
                End If
            End Try
        End If
        Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Stylesheet
        TextBox2.Text = My.Settings.DownloadDir
        Button6.Font = My.Settings.PTFont
        Button7.BackColor = My.Settings.PTForeColor
        Button8.BackColor = My.Settings.PTBackColor
        CheckBox2.Checked = My.Settings.AskBeforeDownloading
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If isElevated Then
            Button4.Text = "Set as URL Handler"
            Button4.Enabled = True
        Else
            Button4.Text = "Administrative privileges required"
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("This will set " & Application.ExecutablePath & " as the URL handler for gopher:// links in the Windows Registry.", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
            Dim gopher = Registry.ClassesRoot.CreateSubKey("gopher")
            gopher.SetValue("URL Protocol", "")
            Dim DefaultIcon = gopher.CreateSubKey("DefaultIcon")
            DefaultIcon.SetValue("", Application.ExecutablePath & ",0")
            Dim shell = gopher.CreateSubKey("shell")
            Dim open = shell.CreateSubKey("open")
            Dim command = open.CreateSubKey("command")
            command.SetValue("", """" & Application.ExecutablePath & """" & " " & """%1""")
            Button4.Text = "Done"
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim opendir As New FolderBrowserDialog
        opendir.Description = "Select the Downloads directory to use."
        opendir.SelectedPath = TextBox2.Text
        If opendir.ShowDialog = DialogResult.OK Then
            TextBox2.Text = opendir.SelectedPath
        End If
    End Sub

    Private Sub ResetSettings(sender As Object, e As EventArgs) Handles Button9.Click
        If MsgBox("Reset all settings? (This doesn't include the URL handler)", MsgBoxStyle.YesNo, "Initialize") = MsgBoxResult.Yes Then
            My.Settings.Reset()
            My.Settings.Stylesheet = My.Settings.StyleDefault
            My.Settings.DownloadDir = My.Computer.FileSystem.CurrentDirectory & "\Downloads"
            If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DownloadDir) Then
                My.Computer.FileSystem.CreateDirectory(My.Settings.DownloadDir)
            End If
            Close()
        End If
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click, Button8.Click
        Dim color As New ColorDialog
        color.Color = sender.BackColor
        If color.ShowDialog() = DialogResult.OK Then
            sender.Backcolor = color.Color
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim font As New FontDialog
        font.Font = Button6.Font
        If font.ShowDialog() = DialogResult.OK Then
            Button6.Font = font.Font
        End If
    End Sub
End Class