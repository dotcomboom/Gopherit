Imports System.ComponentModel
Imports System.IO

Public Class Form1
    Public curl = Path.GetDirectoryName(Application.ExecutablePath) & "\curl.exe"

    Private Function SaveBookmarks()
        My.Settings.Bookmarks.Clear()
        Try
            For Each item In BookmarksLsV.Items
                My.Settings.Bookmarks.Add(item.text)
            Next
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Private Function LoadBookmarks()
        Try
            BookmarksLsV.Items.Clear()
            For Each item In My.Settings.Bookmarks
                BookmarksLsV.Items.Add(item)
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

    Public Sub Go(sender As Object, e As EventArgs) Handles GoBtn.Click
        Dim qsplit = AddressCmb.Text.Split("?")
        If qsplit.Count > 1 Then
            AddressCmb.Text = "gopher://" & qsplit(0).Replace("gopher://", "").Replace("//", "/") & "?" & String.Join("", qsplit.Skip(1))
        Else
            AddressCmb.Text = "gopher://" & AddressCmb.Text.Replace("gopher://", "").Replace("//", "/")
        End If

        Dim url = AddressCmb.Text

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
        Catch ex As Exception
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

        UrlLbl.Text = url

        Me.UseWaitCursor = True
        StatusLbl.Text = "Fetching"
        StatusLbl.ForeColor = Color.YellowGreen
        Refresh()

        TextBox2.Text = CurlFetch(url)

        StatusLbl.Text = "Parsing"
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

        StatusLbl.Text = "Finishing"
        Refresh()

        WebBrowser1.DocumentText = html

        If AddressCmb.Items.Contains(url) Then
            AddressCmb.Items.Remove(url)
        End If
        AddressCmb.Items.Add(url)
        AddressCmb.SelectedIndex = AddressCmb.Items.Count - 1
        If AddressCmb.Items.Count > 1 Then
            BackBtn.Enabled = True
        Else
            BackBtn.Enabled = False
        End If

        TextBox2.SelectionStart = TextBox2.TextLength
        TextBox2.SelectionStart = 0
        TextBox2.DeselectAll()

        Me.UseWaitCursor = False
        StatusLbl.Text = "Ready"
        StatusLbl.ForeColor = Color.Green
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
        CoreLayout.RowStyles.Item(CoreLayout.GetRow(BookmarksLsV) + 1).Height = My.Settings.BookmarksHeight
        If My.Settings.BookmarksHeight = 0 Then
            BookmarksLsV.Enabled = False
        Else
            BookmarksLsV.Enabled = True
        End If
        If My.Settings.SearchBarEnabled Then
            TableLayoutPanel1.ColumnStyles.Item(TableLayoutPanel1.ColumnCount - 1).Width = 64
            TableLayoutPanel1.ColumnStyles.Item(TableLayoutPanel1.ColumnCount - 2).Width = 150
        Else
            TableLayoutPanel1.ColumnStyles.Item(TableLayoutPanel1.ColumnCount - 1).Width = 0
            TableLayoutPanel1.ColumnStyles.Item(TableLayoutPanel1.ColumnCount - 2).Width = 0
        End If

        LoadBookmarks()

        WebBrowser1.Navigate("about:blank")

        Dim args = Environment.GetCommandLineArgs()
        If args.Count > 1 Then
            AddressCmb.Text = args(1)
            Go(sender, e)
            Refresh()
        End If
    End Sub

    Private Sub WebBrowser1_LocationChanged(sender As Object, e As EventArgs) Handles WebBrowser1.DocumentCompleted
        Console.WriteLine(WebBrowser1.Url.ToString)

        If WebBrowser1.Url.ToString.Replace("about:blank?url=", "").StartsWith("gopher://") Then
            If WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Contains("&txt=yes") Then
                AddressCmb.Text = WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Replace("&txt=yes", "").Replace(" ", "%20")
                Go(sender, e)
            ElseIf WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Contains("&search=yes") Then
                AddressCmb.Text = WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Replace("&search=yes", "") & "?" & InputBox("Enter a query for the remote server to process.", "Query requested").Replace(" ", "%20")
                Go(sender, e)
            ElseIf WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Contains("&dl=yes") Then
                Dim dlurl = WebBrowser1.Url.ToString.Replace("about:blank?url=", "").Replace("&dl=yes", "").Replace(" ", "%20")
                Dim dlurlsplit = dlurl.Split("/")
                If My.Settings.AskBeforeDownloading Then
                    If MsgBox("Download file " & dlurlsplit.Last & " to " & My.Settings.DownloadDir & "\" & dlurlsplit.Last & "?", MsgBoxStyle.YesNo, "Download file") = MsgBoxResult.Yes Then
                        JustDownload(dlurl)
                    End If
                Else
                    JustDownload(dlurl)
                End If
                AddressCmb.SelectedIndex = AddressCmb.Items.Count - 1
                Go(sender, e)
            Else
                AddressCmb.Text = WebBrowser1.Url.ToString.Replace("about:blank?url=", "")
                Go(sender, e)
            End If
        End If

        Try
            Dim type = AddressCmb.Text.Replace("gopher://", "").Split("/")(1)
            If type = 0 Then
                TabCtl.SelectTab(1)
            Else
                TabCtl.SelectTab(0)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click, BackBtn.Click
        AddressCmb.SelectedIndex = AddressCmb.Items.Count - 2
        Dim current = AddressCmb.Items.Item(AddressCmb.Items.Count - 1)
        AddressCmb.Items.Remove(current)
        'ComboBox1.Items.Insert(0, current)
        Go(sender, e)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles SettingsStatusBtn.Click
        If Settings.ShowDialog() = DialogResult.OK Then
            CoreLayout.RowStyles.Item(CoreLayout.GetRow(BookmarksLsV) + 1).Height = My.Settings.BookmarksHeight
            If My.Settings.BookmarksHeight = 0 Then
                BookmarksLsV.Enabled = False
            Else
                BookmarksLsV.Enabled = True
            End If
            If My.Settings.SearchBarEnabled Then
                TableLayoutPanel1.ColumnStyles.Item(TableLayoutPanel1.ColumnCount - 1).Width = 64
                TableLayoutPanel1.ColumnStyles.Item(TableLayoutPanel1.ColumnCount - 2).Width = 150
            Else
                TableLayoutPanel1.ColumnStyles.Item(TableLayoutPanel1.ColumnCount - 1).Width = 0
                TableLayoutPanel1.ColumnStyles.Item(TableLayoutPanel1.ColumnCount - 2).Width = 0
            End If
            LoadBookmarks()
            TextBox2.Font = My.Settings.PTFont
            TextBox2.BackColor = My.Settings.PTBackColor
            TextBox2.ForeColor = My.Settings.PTForeColor
            BackColor = My.Settings.InterfaceBackColor
            Refresh()
        End If
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles AddressCmb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Go(sender, e)
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles BookmarkCMS.Opening
        If BookmarksLsV.SelectedItems.Count = 1 Then
            RemoveBookmarkToolStripMenuItem.Enabled = True
            RemoveBookmarkToolStripMenuItem.Text = "Remove bookmark"
        End If
        If AddressCmb.Items.Count > 0 Then
            Dim page = AddressCmb.Items.Item(AddressCmb.Items.Count - 1).replace("gopher://", "")
            BookmarkThisPageToolStripMenuItem.Enabled = True
            BookmarkThisPageToolStripMenuItem.Text = "Bookmark " & page
        Else
            BookmarkThisPageToolStripMenuItem.Enabled = False
            BookmarkThisPageToolStripMenuItem.Text = "Bookmark this page"
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles BookmarksLsV.DoubleClick
        If BookmarksLsV.SelectedItems.Count = 1 Then
            AddressCmb.Text = BookmarksLsV.SelectedItems.Item(0).Text
            Go(sender, e)
        End If
        BookmarksLsV.SelectedItems.Clear()
    End Sub

    Private Sub RemoveBookmarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveBookmarkToolStripMenuItem.Click
        Try
            BookmarksLsV.Items.Remove(BookmarksLsV.SelectedItems.Item(0))
            SaveBookmarks()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BookmarkThisPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarkThisPageToolStripMenuItem.Click, BookmarkToolStripMenuItem.Click
        Dim page = AddressCmb.Items.Item(AddressCmb.Items.Count - 1).replace("gopher://", "").replace(":70", "").TrimEnd("/")
        BookmarksLsV.Items.Add(page)
        SaveBookmarks()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveBookmarks()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles MapperStatusBtn.Click
        Dim mpr As New Mapper
        mpr.Show()
    End Sub

    Private Sub ContextMenuStrip2_Opening(sender As Object, e As CancelEventArgs) Handles BrowserCMS.Opening
        If AddressCmb.Items.Count > 0 Then
            BrowserCMS.Enabled = True
            If AddressCmb.Items.Count > 1 Then
                BackToolStripMenuItem.Enabled = True
            Else
                BackToolStripMenuItem.Enabled = False
            End If
        Else
            BrowserCMS.Enabled = False
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        AddressCmb.SelectedIndex = AddressCmb.Items.Count - 1
        Go(sender, e)
    End Sub

    Private Sub SaveToFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToFileToolStripMenuItem.Click
        Dim url = AddressCmb.Items.Item(AddressCmb.Items.Count - 1).replace("gopher://", "")
        Dim ss = url.split("/")
        Save.FilenameTxt.Text = url.Replace("/", "-").replace(":", "_").replace("?", "!")
        If Not Save.FilenameTxt.Text.Contains(".txt") Then
            Save.FilenameTxt.AppendText(".txt")
        End If
        Try
            If ss(1) = "0" Then
                Save.GroupBox1.Enabled = False
            End If
        Catch ex As Exception
        End Try
        Save.content = TextBox2.Text
        Save.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        AddressCmb.Text = My.Settings.SearchService & "?" & SearchTxt.Text.Replace(" ", "%20")
        Go(sender, e)
    End Sub

    Private Sub SearchTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddressCmb.Text = My.Settings.SearchService & "?" & SearchTxt.Text.Replace(" ", "%20")
            Go(sender, e)
        End If
    End Sub
End Class
