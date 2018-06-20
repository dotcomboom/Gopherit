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
        Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Stylesheet
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
        MsgBox("""" & Application.ExecutablePath & """" & " " & """%1""")
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
End Class