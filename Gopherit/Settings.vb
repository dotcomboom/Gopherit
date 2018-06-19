Public Class Settings
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = My.Settings.StyleDefault
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Stylesheet = TextBox1.Text
        If CheckBox1.Checked Then
            My.Settings.Bookmarks.Clear()
            My.Settings.Bookmarks.Add("gopher.floodgap.com")
            My.Settings.Bookmarks.Add("gopherproject.org")
            CheckBox1.Checked = False
        End If
        Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Stylesheet
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class