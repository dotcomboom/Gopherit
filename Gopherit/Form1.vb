Imports System.ComponentModel
Imports System.IO

Public Class Form1
    Public curl = Path.GetDirectoryName(Application.ExecutablePath) & "\curl.exe"

    Private Function SaveBookmarks()
        My.Settings.Bookmarks.Clear()
        Try
            For Each item In ListView1.Items
                My.Settings.Bookmarks.Add(item.text)
            Next
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Private Function LoadBookmarks()
        Try
            ListView1.Items.Clear()
            For Each item In My.Settings.Bookmarks
                ListView1.Items.Add(item)
                Refresh()
            Next
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
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
        Dim cur = My.Computer.FileSystem.CurrentDirectory

        My.Computer.FileSystem.CurrentDirectory = My.Settings.DownloadDir
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo(curl)
        oStartInfo.Arguments = "-O " & url
        oStartInfo.UseShellExecute = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
        Process.Start(My.Computer.FileSystem.CurrentDirectory)

        My.Computer.FileSystem.CurrentDirectory = cur
        Return True
    End Function

    Public Sub Go(sender As Object, e As EventArgs) Handles Button1.Click
        Dim qsplit = ComboBox1.Text.Split("?")
        If qsplit.Count > 1 Then
            ComboBox1.Text = "gopher://" & qsplit(0).Replace("gopher://", "").Replace("//", "/") & "?" & String.Join("", qsplit.Skip(1))
        Else
            ComboBox1.Text = "gopher://" & ComboBox1.Text.Replace("gopher://", "").Replace("//", "/")
        End If

        Dim url = ComboBox1.Text

        Dim slashsplit = url.Replace("gopher://", "").Split("/")
        If slashsplit.Count < 2 Then
            'fixes domains to have an item type in url
            'gopher.floodgap.com
            'we add /1 to that as 1 (directory) is the default item type for gopher urls
            url = "gopher://" & url.Replace("gopher://", "").Replace("/", "") & "/1"
        End If

        Try
            If slashsplit(1).Length > 1 Then
                'fixes urls without item types
                'gopher.floodgap.com/potato
                'slashsplit(1) is potato
                'and we uh replace that with "1/potato" as 1 (directory) is the default item type for gopher urls
                url = "gopher://" & url.Replace("gopher://", "").Replace(slashsplit(1), "1/" & slashsplit(1))
            End If
        Catch ex As exception
        End Try

        If slashsplit.Count > 2 Then
            'test.test/9/nice.exe
            'test.test
            '9
            'nice.exe
            Dim binarytypes = {"h", "9", "5", "4", "6", "g", "I", "s"}
            If binarytypes.Contains(slashsplit(1)) Then

                If My.Settings.AskBeforeDownloading Then
                    If MsgBox("Download file " & slashsplit.Last & " to " & My.Settings.DownloadDir & "\" & slashsplit.Last & "?", MsgBoxStyle.YesNo, "Download file") = MsgBoxResult.Yes Then
                        JustDownload(url)
                    End If
                Else
                    JustDownload(url)
                End If

                Exit Sub
            End If
        End If
        Me.UseWaitCursor = True
        Label1.Text = "Fetching"
        Label1.ForeColor = Color.YellowGreen
        Refresh()

        TextBox2.Text = CurlFetch(url)

        Label1.Text = "Parsing"
        Refresh()

        Dim strReader As New IO.StringReader(TextBox2.Text)
        Dim CurrentLine = strReader.ReadLine

        Dim html = "<html><head><style>" & My.Settings.Stylesheet & "</style></head><body>"

        Do While (Not CurrentLine Is Nothing)

            Try
                Dim CLArray = CurrentLine.Split(vbTab)

                If Not CLArray(1).StartsWith("/") Then 'in the case of on-gopher resources
                    If Not CLArray(1).StartsWith("URL:") Then 'in the case of off-gopher resources
                        If Not CLArray(1) = "a" Then 'in the case of telnet selectors
                            CLArray(1) = "/" & CLArray(1)
                        End If
                    End If
                End If

                If CLArray(0).StartsWith("i") Then
                    html = html & "<pre class='i' title='Inline text'>" & CLArray(0).Substring(1) & "</pre>"
                ElseIf CLArray(0).StartsWith("3") Then
                    html = html & "<pre class='3' title='Error'>" & CLArray(0).Substring(1) & "</pre>"
                ElseIf CLArray(0).StartsWith("h") Then
                    If CLArray(1).Contains("URL:") Then
                        Dim surl = CLArray(1).Replace("URL:", "")
                        html = html & "<pre class='h' title='Off-gopher resource: " & surl & "'><a target='_blank' href='" & surl & "'>" & CLArray(0).Substring(1) & "</a></pre>"
                    Else
                        Dim surl = "gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(0).Substring(0, 1) & CLArray(1)
                        html = html & "<pre class='h' title='HTML Document: " & surl & "'><a href='about:blank?url=" & surl & "&dl=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                    End If
                ElseIf CLArray(0).StartsWith("0") Then
                    '0Caltrans California highway conditions	/calroads	gopher.floodgap.com	70
                    Dim surl = "gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(0).Substring(0, 1) & CLArray(1)
                    html = html & "<pre class='0' title='Text File: " & surl & "'><a href='about:blank?url=" & surl & "&txt=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("8") Then
                    '8Dura-Europe BBS	a	dura-bbs.net	6359
                    Dim surl = "telnet:" & CLArray(2) & ":" & CLArray(3)
                    html = html & "<pre class='8' title='Telnet Session: " & surl & "'><a href='" & surl & "'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("1") Then
                    Dim surl = "gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(0).Substring(0, 1) & CLArray(1)
                    html = html & "<pre class='1' title='Directory: " & surl & "'><a href='about:blank?url=" & surl & "'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("7") Then
                    Dim surl = "gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(0).Substring(0, 1) & CLArray(1)
                    html = html & "<pre class='7' title='Search: " & surl & "'><a href='about:blank?url=" & surl & "&search=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("9") Then
                    Dim surl = "gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(0).Substring(0, 1) & CLArray(1)
                    html = html & "<pre class='9' title='Binary File: " & surl & "'><a href='about:blank?url=" & surl & "&dl=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("5") Then
                    Dim surl = "gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(0).Substring(0, 1) & CLArray(1)
                    html = html & "<pre class='5' title='PC binary: " & surl & "'><a href='about:blank?url=" & surl & "&dl=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("4") Then
                    Dim surl = "gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(0).Substring(0, 1) & CLArray(1)
                    html = html & "<pre class='4' title='HQX filer: " & surl & "'><a href='about:blank?url=" & surl & "&dl=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("6") Then
                    Dim surl = "gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(0).Substring(0, 1) & CLArray(1)
                    html = html & "<pre class='6' title='UNIX uuencoded file: " & surl & "'><a href='about:blank?url=" & surl & "&dl=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("g") Then
                    Dim surl = "gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(0).Substring(0, 1) & CLArray(1)
                    html = html & "<pre class='I' title='GIF image: " & surl & "'><a href='about:blank?url=" & surl & "&dl=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("I") Then
                    Dim surl = "gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(0).Substring(0, 1) & CLArray(1)
                    html = html & "<pre class='Im' title='Generic image: " & surl & "'><a href='about:blank?url=" & surl & "&dl=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                ElseIf CLArray(0).StartsWith("s") Then
                    Dim surl = "gopher://" & CLArray(2) & ":" & CLArray(3) & "/" & CLArray(0).Substring(0, 1) & CLArray(1)
                    html = html & "<pre class='s' title='Sound: " & surl & "'><a href='about:blank?url=" & surl & "&dl=yes'>" & CLArray(0).Substring(1) & "</a></pre>"
                Else
                    html = html & "<pre title='Unknown'>" & CurrentLine & "</pre>"
                End If
            Catch ex As Exception
            End Try

            CurrentLine = strReader.ReadLine 'Reading the line for the next iteration
        Loop

        html = html & "<script>" & My.Settings.JavaScript & "</script></body></html>"

        Label1.Text = "Finishing"
        Refresh()

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

        TextBox2.SelectionStart = TextBox2.TextLength
        TextBox2.SelectionStart = 0
        TextBox2.DeselectAll()

        Me.UseWaitCursor = False
        Label1.Text = "Ready"
        Label1.ForeColor = Color.Green
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Gopherit (Release " & Application.ProductVersion(0) & ")"

        If My.Settings.Stylesheet = "" Then
            My.Settings.Stylesheet = My.Settings.StyleDefault
        End If

        If My.Settings.DownloadDir = "" Then
            My.Settings.DownloadDir = My.Computer.FileSystem.CurrentDirectory & "\Downloads"
        End If

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

        My.Computer.FileSystem.CurrentDirectory = Path.GetDirectoryName(Application.ExecutablePath)

        If Not My.Computer.FileSystem.FileExists(curl) Then
            MsgBox("Gopherit was unable to find curl.exe, the application used for getting resources from the Internet, in the working directory " & My.Computer.FileSystem.CurrentDirectory & ". You will need to download a Generic binary from https://curl.haxx.se/download.html#Win32 and put it into this directory.", MsgBoxStyle.Exclamation, "Curl not found")
            Application.Exit()
        End If

        TextBox2.Font = My.Settings.PTFont
        TextBox2.BackColor = My.Settings.PTBackColor
        TextBox2.ForeColor = My.Settings.PTForeColor
        BackColor = My.Settings.InterfaceBackColor

        LoadBookmarks()

        WebBrowser1.Navigate("about:blank")

        Dim args = Environment.GetCommandLineArgs()
        If args.Count > 1 Then
            ComboBox1.Text = args(1)
            Refresh()
            Go(sender, e)
        End If
    End Sub

    Private Sub WebBrowser1_LocationChanged(sender As Object, e As EventArgs) Handles WebBrowser1.DocumentCompleted
        Console.WriteLine(WebBrowser1.Url.ToString)
        Dim type = ComboBox1.Text.Replace("gopher://", "").Split("/")(1)
        Try
            If type = 0 Then
                TabControl1.SelectTab(1)
            Else
                TabControl1.SelectTab(0)
            End If
        Catch ex As Exception
        End Try

        If WebBrowser1.Url.ToString.Replace("about:blank?url=", "").StartsWith("gopher://") Then
            If WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Contains("&txt=yes") Then
                ComboBox1.Text = WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Replace("&txt=yes", "")
                Go(sender, e)
            ElseIf WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Contains("&search=yes") Then
                ComboBox1.Text = WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Replace("&search=yes", "") & "?" & InputBox("Enter a query for the remote server to process.", "Query requested").Replace(" ", "%20")
                Go(sender, e)
            ElseIf WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Contains("&dl=yes") Then
                Dim dlurl = WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Replace("&dl=yes", "")
                Dim dlurlsplit = dlurl.Split("/")
                If My.Settings.AskBeforeDownloading Then
                    If MsgBox("Download file " & dlurlsplit.Last & " to " & My.Settings.DownloadDir & "\" & dlurlsplit.Last & "?", MsgBoxStyle.YesNo, "Download file") = MsgBoxResult.Yes Then
                        JustDownload(dlurl)
                    End If
                Else
                    JustDownload(dlurl)
                End If
                ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
                Go(sender, e)
            Else
                ComboBox1.Text = WebBrowser1.Url.ToString.Replace("about:blank?url=", "")
                Go(sender, e)
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click, BackToolStripMenuItem.Click
        ComboBox1.SelectedIndex = ComboBox1.Items.Count - 2
        Dim current = ComboBox1.Items.Item(ComboBox1.Items.Count - 1)
        ComboBox1.Items.Remove(current)
        'ComboBox1.Items.Insert(0, current)
        Go(sender, e)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Settings.ShowDialog() = DialogResult.OK Then
            LoadBookmarks()
            TextBox2.Font = My.Settings.PTFont
            TextBox2.BackColor = My.Settings.PTBackColor
            TextBox2.ForeColor = My.Settings.PTForeColor
            BackColor = My.Settings.InterfaceBackColor
            Refresh()
        End If
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Go(sender, e)
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListView1.SelectedItems.Count = 1 Then
            RemoveBookmarkToolStripMenuItem.Enabled = True
            RemoveBookmarkToolStripMenuItem.Text = "Remove bookmark"
        End If
        If ComboBox1.Items.Count > 0 Then
            Dim page = ComboBox1.Items.Item(ComboBox1.Items.Count - 1).replace("gopher://", "")
            BookmarkThisPageToolStripMenuItem.Enabled = True
            BookmarkThisPageToolStripMenuItem.Text = "Bookmark " & page
        Else
            BookmarkThisPageToolStripMenuItem.Enabled = False
            BookmarkThisPageToolStripMenuItem.Text = "Bookmark this page"
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.ItemActivate
        If ListView1.SelectedItems.Count = 1 Then
            ComboBox1.Text = ListView1.SelectedItems.Item(0).Text
            Go(sender, e)
        End If
        ListView1.SelectedItems.Clear()
    End Sub

    Private Sub RemoveBookmarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveBookmarkToolStripMenuItem.Click
        Try
            ListView1.Items.Remove(ListView1.SelectedItems.Item(0))
            SaveBookmarks()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BookmarkThisPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarkThisPageToolStripMenuItem.Click, BookmarkToolStripMenuItem.Click
        Dim page = ComboBox1.Items.Item(ComboBox1.Items.Count - 1).replace("gopher://", "").replace(":70", "").TrimEnd("/")
        ListView1.Items.Add(page)
        SaveBookmarks()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveBookmarks()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mpr As New Mapper
        mpr.show
    End Sub

    Private Sub ContextMenuStrip2_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStrip2.Opening
        If ComboBox1.Items.Count > 0 Then
            ContextMenuStrip2.Enabled = True
            If ComboBox1.Items.Count > 1 Then
                BackToolStripMenuItem.Enabled = True
            Else
                BackToolStripMenuItem.Enabled = False
            End If
        Else
            ContextMenuStrip2.Enabled = False
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
        Go(sender, e)
    End Sub
End Class
