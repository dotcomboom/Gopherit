Public Class Mapper

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ItemCmb.SelectedValueChanged
        Dim itemtype = ItemCmb.SelectedItem.ToString.Substring(0, 1)
        '0 Text File
        '1 Directory
        '3 Error
        '4 HQX filer
        '5 PC binary
        '6 UNIX uuencoded file
        '7 Search Service
        '8 Telnet session
        '9 Binary file
        'g GIF image
        's Sound
        'I Generic image
        'h HTML Document Or Off-Gopher Resource
        Dim textpathserverport = {"0", "1", "4", "5", "6", "7", "9", "g", "s", "I", "h"}
        Dim textidkserverport = {"8"}
        Dim text = "3"
        ItemDescLbl.Text = "1. Text"
        AddBtn.Enabled = True
        value1.Clear()
        value2.Clear()
        value3.Clear()
        value4.Clear()
        value1.Enabled = True
        value2.Enabled = True
        value3.Enabled = True
        value4.Enabled = True
        If textpathserverport.Contains(itemtype) Then
            If itemtype = "h" Then
                value2.Text = "URL: http://example.com"
                ItemDescLbl.Text = ItemDescLbl.Text & vbNewLine & "2. Path on server OR 'URL: http://example.com'" & vbNewLine & "3. Server" & vbNewLine & "4. Port"
            Else
                ItemDescLbl.Text = ItemDescLbl.Text & vbNewLine & "2. Path on server" & vbNewLine & "3. Server" & vbNewLine & "4. Port"
            End If
        ElseIf textidkserverport.Contains(itemtype) Then
            value2.Text = "a"
            value2.Enabled = False
            ItemDescLbl.Text = ItemDescLbl.Text & vbNewLine & "2. 'a'" & vbNewLine & "3. Server" & vbNewLine & "4. Port"
        ElseIf text.Contains(itemtype) Then
            value2.Enabled = False
            value3.Enabled = False
            value4.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        TextBox1.AppendText(vbNewLine)
        TextBox1.AppendText(ItemCmb.SelectedItem.ToString.Substring(0, 1))
        TextBox1.AppendText(value1.Text)
        'can be disabled and "a"
        TextBox1.AppendText(vbTab)
        TextBox1.AppendText(value2.Text)
        If value3.Enabled Then
            TextBox1.AppendText(vbTab)
            TextBox1.AppendText(value3.Text)
        End If
        If value4.Enabled Then
            TextBox1.AppendText(vbTab)
            TextBox1.AppendText(value4.Text)
        End If

        value1.Clear()
        value2.Clear()
        value3.Clear()
        value4.Text = "70"
    End Sub

    Private Sub Mapper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Font = My.Settings.PTFont
        TextBox1.BackColor = My.Settings.PTBackColor
        TextBox1.ForeColor = My.Settings.PTForeColor
        BackColor = My.Settings.InterfaceBackColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles OpenBtn.Click
        Dim open As New OpenFileDialog
        open.FileName = "gophermap"
        open.Title = "Open Gophermap"
        open.Filter = "Gophermap|gophermap|All files (*.*)|*.*"
        If open.ShowDialog = DialogResult.OK Then
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(open.FileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim save As New SaveFileDialog
        save.FileName = "gophermap"
        save.Title = "Save Gophermap"
        save.Filter = "Gophermap|gophermap|All files (*.*)|*.*"
        If save.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(save.FileName, TextBox1.Text, False)
        End If
    End Sub
End Class