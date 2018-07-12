Public Class Save
    Public content = ""
    Private Sub Save_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = My.Settings.InterfaceBackColor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OkBtn.Click

        Dim newcontent = ""
        Dim strReader As New IO.StringReader(content)
        Dim CurrentLine = strReader.ReadLine

        Do While (Not CurrentLine Is Nothing)
            If CurrentLine.Length > 0 Then
                If GroupBox1.Enabled Then
                    If StripChk.Checked Then
                        If CurrentLine.Contains(vbTab) Then
                            If Not CurrentLine.StartsWith("i") Then
                                CurrentLine = ""
                            End If
                        End If
                    End If
                    If CleanChk.Checked Then
                        If CurrentLine.StartsWith("i") Then
                            CurrentLine = CurrentLine.Substring(1).Split(vbTab)(0)
                        End If
                    End If
                End If
            End If
            newcontent = newcontent & CurrentLine & vbNewLine
            CurrentLine = strReader.ReadLine 'Reading the line for the next iteration
        Loop

        newcontent = newcontent.TrimEnd(vbNewLine)
        Try
            My.Computer.FileSystem.WriteAllText(My.Settings.DownloadDir & "/" & FilenameTxt.Text, newcontent, False)
            Process.Start(My.Settings.DownloadDir)
        Catch ex As Exception
            MsgBox("Check if there are any invalid filesystem characters." & vbNewLine & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Unable to write file")
        End Try
    End Sub
End Class