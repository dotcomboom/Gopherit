Imports System.IO

Public Class Form1
    Public curl = "curl.exe"

    Private Function CurlFetch(url As String)
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo(curl, url)
        oStartInfo.CreateNoWindow = True
        oStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        Return sOutput
    End Function
    Private Function JustDownload(url As String)
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo(curl)
        oStartInfo.Arguments = "-O " & url
        oStartInfo.UseShellExecute = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
        Process.Start(My.Computer.FileSystem.CurrentDirectory)
        Return True
    End Function

    Public Sub Go(sender As Object, e As EventArgs) Handles Button1.Click
        Me.UseWaitCursor = True
        Label1.Visible = True
        Me.Refresh()

        If Not ComboBox1.Text.Contains("://") Then
            ComboBox1.Text = "gopher://" & ComboBox1.Text
        End If
        Dim url = ComboBox1.Text
        TextBox2.Text = CurlFetch(url)

        Dim strReader As New IO.StringReader(TextBox2.Text)
        Dim CurrentLine = strReader.ReadLine

        Dim html = "<html><head><style>" & My.Settings.Stylesheet & "</style></head><body>"

        Do While (Not CurrentLine Is Nothing)

            Try
                CurrentLine = CurrentLine.Replace("error.host	1", "")

                Dim CLArray = CurrentLine.Split(vbTab)

                If CLArray(0).StartsWith("i") Then
                    html = html & "<pre class='i' title='Information'>" & CLArray(0).Substring(1) & "</pre>"
                ElseIf CLArray(0).StartsWith("3") Then
                    html = html & "<pre class='3' title='Error'>" & CLArray(0).Substring(1) & "</pre>"
                ElseIf CLArray(0).StartsWith("h") Then
                    html = html & "<pre class='h' title='HTML Document'><a target='_blank' href='" & CLArray(1).Replace("URL:", "") & "'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("0") Then
                    '0Caltrans California highway conditions	/calroads	gopher.floodgap.com	70
                    Dim text = CLArray(0).Substring(1)
                    Dim path = CLArray(1)
                    Dim server = CLArray(2)
                    Dim port = CLArray(3)
                    If Not path.StartsWith("/") Then
                        path = url.Replace("gopher://", "").Split("/").Skip(1).ToString
                        'MsgBox(path)
                    End If
                    If server Is Nothing Then
                        server = url.Replace("gopher://", "").Split("/")(0)
                    End If
                    If port Is Nothing Then
                        port = 70
                    End If
                    html = html & "<pre class='0' title='Text File'><a href='about:blank?url=gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(1) & "&txt=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("1") Then
                    Dim text = CLArray(0).Substring(1)
                    Dim path = CLArray(1)
                    Dim server = CLArray(2)
                    Dim port = CLArray(3)
                    If Not path.StartsWith("/") Then
                        path = url.Replace("gopher://", "").Split("/").Skip(1).ToString
                        'MsgBox(path)
                    End If
                    If server Is Nothing Then
                        server = url.Replace("gopher://", "").Split("/")(0)
                    End If
                    If port Is Nothing Then
                        port = 70
                    End If
                    html = html & "<pre class='1' title='Directory'><a href='about:blank?url=gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(1) & "'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("7") Then
                    html = html & "<pre class='7' title='Search'><a href='about:blank?url=gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(1) & "&search=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("9") Then
                    html = html & "<pre class='9' title='Binary File'><a href='about:blank?url=gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(1) & "&dl=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("5") Then
                    html = html & "<pre class='5' title='PC binary'><a href='about:blank?url=gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(1) & "&dl=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("g") Then
                    html = html & "<pre class='I' title='GIF image'><a href='about:blank?url=gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(1) & "&dl=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("I") Then
                    html = html & "<pre class='Im' title='Generic image'><a href='about:blank?url=gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(1) & "&dl=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                Else
                    html = html & "<pre title='Unknown'>" & CurrentLine & "</pre>"
                End If
            Catch ex As Exception
            End Try

            CurrentLine = strReader.ReadLine 'Reading the line for the next iteration
        Loop

        html = html & "</body></html>"


        WebBrowser1.DocumentText = html

        If ComboBox1.Items.Contains(url) Then
            ComboBox1.Items.Remove(url)
        End If
        ComboBox1.Items.Add(url)
        ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
        If ComboBox1.Items.Count > 1 Then
            Button6.Enabled = True
        Else
            Button6.Enabled = False
        End If

        Me.UseWaitCursor = False
        Label1.Visible = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.Stylesheet = "" Then
            My.Settings.Stylesheet = My.Settings.StyleDefault
        End If

        If Not My.Computer.FileSystem.FileExists(curl) Then
            MsgBox("Gopherit was unable to find curl.exe, the application used for getting resources from the Internet, in the working directory " & My.Computer.FileSystem.CurrentDirectory & ". You will need to download a Generic binary from https://curl.haxx.se/download.html#Win32 and put it into this directory.", MsgBoxStyle.Exclamation, "Curl not found")
            Application.Exit()
        End If

        WebBrowser1.Navigate("about:blank")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Text = "gopher://gopherproject.org"
        Go(sender, e)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ComboBox1.Text = "gopher://gopher.floodgap.com"
        Go(sender, e)
    End Sub

    Private Sub WebBrowser1_LocationChanged(sender As Object, e As EventArgs) Handles WebBrowser1.DocumentCompleted
        Console.WriteLine(WebBrowser1.Url.ToString)
        If WebBrowser1.Url.ToString.Replace("about:blank?url=", "").StartsWith("gopher://") Then
            If WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Contains("&txt=yes") Then
                ComboBox1.Text = WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Replace("&txt=yes", "")
                TabControl1.SelectTab(1)
                Go(sender, e)
            ElseIf WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Contains("&search=yes") Then
                ComboBox1.Text = WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Replace("&search=yes", "") & "?" & InputBox("Enter a query for the remote server to process.", "Query requested")
                TabControl1.SelectTab(0)
                Go(sender, e)
            ElseIf WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Contains("&dl=yes") Then
                Dim dlurl = WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Replace("&dl=yes", "")
                Dim dlurlsplit = dlurl.Split("/")
                If MsgBox("Download file " & dlurlsplit.Last & " to " & My.Computer.FileSystem.CurrentDirectory & "\" & dlurlsplit.Last & "?", MsgBoxStyle.YesNo, "Download file") = MsgBoxResult.Yes Then
                    JustDownload(dlurl)
                End If
                ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
                TabControl1.SelectTab(0)
                Go(sender, e)
            Else
                ComboBox1.Text = WebBrowser1.Url.ToString.Replace("about:blank?url=", "")
                TabControl1.SelectTab(0)
                Go(sender, e)
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox1.SelectedIndex = ComboBox1.Items.Count - 2
        Go(sender, e)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Settings.ShowDialog()
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Go(sender, e)
        End If
    End Sub
End Class
