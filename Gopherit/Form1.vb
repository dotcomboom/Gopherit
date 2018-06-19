Imports System.IO

Public Class Form1
    Public curl = "curl.exe"

    Public Shared Function FindCurl()
        Dim fileName = "curl.exe"
        If File.Exists(fileName) Then Return Path.GetFullPath(fileName)
        Dim values = Environment.GetEnvironmentVariable("PATH")

        For Each path In values.Split(";"c)
            Dim fullPath = path & fileName
            If File.Exists(fullPath) Then Return fullPath
        Next

        Return Nothing
    End Function

    Public Sub Go(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ComboBox1.Text.Contains("://") Then
            ComboBox1.Text = "gopher://" & ComboBox1.Text
        End If

        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo(curl, ComboBox1.Text)
        oStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        TextBox2.Text = sOutput

        Dim strReader As New IO.StringReader(TextBox2.Text)
        Dim CurrentLine = strReader.ReadLine

        Dim html = "<html><head><style>.i{color:green}.h{color:blue}.0 a{color:gray}.1 a{color:orange}.7 a{color:purple}</style></head><body>"

        Do While (Not CurrentLine Is Nothing)

            Try
                CurrentLine = CurrentLine.Replace("error.host	1", "")

                Dim CLArray = CurrentLine.Split(vbTab)

                If CLArray(0).StartsWith("i") Then
                    html = html & "<pre class='i' title='Information'>" & CLArray(0).Substring(1) & "</pre>"
                ElseIf CLArray(0).StartsWith("h") Then
                    html = html & "<pre class='h' title='HTML Document'><a target='_blank' href='" & CLArray(1).Replace("URL:", "") & "'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("0") Then
                    '0Caltrans California highway conditions	/calroads	gopher.floodgap.com	70
                    html = html & "<pre class='0' title='Text File'><a href='about:blank?url=gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(1) & "&txt=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("1") Then
                    html = html & "<pre class='1' title='Directory'><a href='about:blank?url=gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(1) & "'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("7") Then
                    html = html & "<pre class='7' title='Search'><a href='about:blank?url=gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(1) & "&search=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                Else
                    html = html & "<pre title='Unknown'>" & CurrentLine & "</pre>"
                End If
            Catch ex As Exception
            End Try

            CurrentLine = strReader.ReadLine 'Reading the line for the next iteration
        Loop

        html = html & "</body></html>"


        WebBrowser1.DocumentText = html

        Dim cbtemp = ComboBox1.Text
        If ComboBox1.Items.Contains(cbtemp) Then
            ComboBox1.Items.Remove(cbtemp)
        End If
        ComboBox1.Items.Add(cbtemp)
        ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
        If ComboBox1.Items.Count > 1 Then
            Button6.Enabled = True
        Else
            Button6.Enabled = False
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        curl = FindCurl()

        If curl = Nothing Then
            MsgBox("Gopherit was unable to find curl.exe, the application used for getting resources from the Internet, in the working directory " & My.Computer.FileSystem.CurrentDirectory & " or your PATH. You will need to download a Generic binary from https://curl.haxx.se/download.html#Win32 and put it into the working directory.", MsgBoxStyle.Exclamation, "Curl not found")
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
            Else
                ComboBox1.Text = WebBrowser1.Url.ToString.Replace("about:blank?url=", "")
                TabControl1.SelectTab(0)
                Go(sender, e)
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox1.SelectedIndex = ComboBox1.Items.Count - 2
    End Sub
End Class
