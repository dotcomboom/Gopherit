Imports System.Security.Principal
Imports Microsoft.Win32

Public Class Settings
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = My.Settings.StyleDefault
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        My.Settings.Stylesheet = TextBox1.Text
        My.Settings.JavaScript = TextBox3.Text
        If ResetBookmarksChk.Checked Then
            My.Settings.Bookmarks.Clear()
            My.Settings.Bookmarks.Add("tilde.town/1/~dcb/gopherit")
            My.Settings.Bookmarks.Add("gopherproject.org/1")
            My.Settings.Bookmarks.Add("gopher.floodgap.com/1")
            ResetBookmarksChk.Checked = False
        End If
        My.Settings.AskBeforeDownloading = AskDownloadsChk.Checked
        My.Settings.InterfaceBackColor = iColorBtn.BackColor
        My.Settings.DownloadDir = DownloadLocationTxt.Text
        My.Settings.PTFont = FontBtn.Font
        My.Settings.PTForeColor = ForeBtn.BackColor
        My.Settings.PTBackColor = BackBtn.BackColor
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
        DownloadLocationTxt.Text = My.Settings.DownloadDir
        TextBox3.Text = My.Settings.JavaScript
        FontBtn.Font = My.Settings.PTFont
        ForeBtn.BackColor = My.Settings.PTForeColor
        BackBtn.BackColor = My.Settings.PTBackColor
        AskDownloadsChk.Checked = My.Settings.AskBeforeDownloading
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If isElevated Then
            URLHandlerBtn.Text = "Set as URL Handler"
            URLHandlerBtn.Enabled = True
        Else
            URLHandlerBtn.Text = "Administrative privileges required"
            URLHandlerBtn.Enabled = False
        End If
        BackColor = My.Settings.InterfaceBackColor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles URLHandlerBtn.Click
        If MsgBox("This will set " & Application.ExecutablePath & " as the URL handler for gopher:// links in the Windows Registry.", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
            Dim gopher = Registry.ClassesRoot.CreateSubKey("gopher")
            gopher.SetValue("URL Protocol", "")
            Dim DefaultIcon = gopher.CreateSubKey("DefaultIcon")
            DefaultIcon.SetValue("", Application.ExecutablePath & ",0")
            Dim shell = gopher.CreateSubKey("shell")
            Dim open = shell.CreateSubKey("open")
            Dim command = open.CreateSubKey("command")
            command.SetValue("", """" & Application.ExecutablePath & """" & " " & """%1""")
            URLHandlerBtn.Text = "Done"
            URLHandlerBtn.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BrowseLocationBtn.Click
        Dim opendir As New FolderBrowserDialog
        opendir.Description = "Select the Downloads directory to use."
        opendir.SelectedPath = DownloadLocationTxt.Text
        If opendir.ShowDialog = DialogResult.OK Then
            DownloadLocationTxt.Text = opendir.SelectedPath
        End If
    End Sub

    Private Sub ResetSettings(sender As Object, e As EventArgs) Handles ResetAllBtn.Click
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ForeBtn.Click, BackBtn.Click, iColorBtn.Click
        Dim color As New ColorDialog
        color.Color = sender.BackColor
        If color.ShowDialog() = DialogResult.OK Then
            sender.Backcolor = color.Color
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles FontBtn.Click
        Dim font As New FontDialog
        font.Font = FontBtn.Font
        If font.ShowDialog() = DialogResult.OK Then
            FontBtn.Font = font.Font
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles iResetBtn.Click
        iColorBtn.BackColor = SystemColors.Control
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox3.Clear()
    End Sub
End Class