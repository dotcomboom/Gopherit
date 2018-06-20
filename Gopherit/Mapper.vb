Public Class Mapper

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim itemtype = ComboBox1.SelectedItem.ToString.Substring(0, 1)
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
        Label1.Text = "1. Text"
        Button1.Enabled = True
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        If textpathserverport.Contains(itemtype) Then
            If itemtype = "h" Then
                TextBox3.Text = "(URL: http://example.com)"
                Label1.Text = Label1.Text & vbNewLine & "2. Path on server OR '(URL: http://example.com)'" & vbNewLine & "3. Server" & vbNewLine & "4. Port"
            Else
                Label1.Text = Label1.Text & vbNewLine & "2. Path on server" & vbNewLine & "3. Server" & vbNewLine & "4. Port"
            End If
        ElseIf textidkserverport.Contains(itemtype) Then
            TextBox3.Text = "a"
            TextBox3.Enabled = False
            Label1.Text = Label1.Text & vbNewLine & "2. 'a'" & vbNewLine & "3. Server" & vbNewLine & "4. Port"
        ElseIf text.Contains(itemtype) Then
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.AppendText(vbNewLine)
        TextBox1.AppendText(ComboBox1.SelectedItem.ToString.Substring(0, 1))
        TextBox1.AppendText(TextBox2.Text)
        'can be disabled and "a"
        TextBox1.AppendText(vbTab)
        TextBox1.AppendText(TextBox3.Text)
        If TextBox4.Enabled Then
            TextBox1.AppendText(vbTab)
            TextBox1.AppendText(TextBox4.Text)
        End If
        If TextBox5.Enabled Then
            TextBox1.AppendText(vbTab)
            TextBox1.AppendText(TextBox5.Text)
        End If

        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Text = "70"
    End Sub
End Class