Imports System.IO
Imports System.Text.RegularExpressions
Public Class MapSettingsCustomizerForm

    Private Sub DirectoryBrowseButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DirectoryBrowseButton.Click
        If (osuDirectoryBrowseDialog.ShowDialog() = DialogResult.OK) Then
            DirectoryInputBox.Text = osuDirectoryBrowseDialog.SelectedPath
        End If
    End Sub

    Public Function ConstructArgs() As String

        Dim mode As String = ""
        If CreateModeRadioButton.Checked = True Then
            mode = "create"
        ElseIf UpdateModeRadioButton.Checked = True Then
            mode = "update"
        ElseIf DeleteModeRadioButton.Checked = True Then
            mode = "delete"
        End If

        Dim name As String = NameInputBox.Text
        Dim path As String = ("""" & DirectoryInputBox.Text & """")

        Dim fromHP As Double = FromOldHPBar.Value / 10.0
        Dim toHP As Double = ToOldHPBar.Value / 10.0

        Dim fromCS As Double = FromOldCSBar.Value / 10.0
        Dim toCS As Double = ToOldCSBar.Value / 10.0

        Dim fromAR As Double = FromOldARBar.Value / 10.0
        Dim toAR As Double = ToOldARBar.Value / 10.0

        Dim fromOD As Double = FromOldODBar.Value / 10.0
        Dim toOD As Double = ToOldODBar.Value / 10.0

        Dim newHP As Double = Convert.ToDouble(NewHPBox.Text)
        Dim newCS As Double = Convert.ToDouble(NewCSBox.Text)
        Dim newAR As Double = Convert.ToDouble(NewARBox.Text)
        Dim newOD As Double = Convert.ToDouble(NewODBox.Text)

        Dim relHP As Boolean = NewHPRelative.Checked
        Dim relCS As Boolean = NewCSRelative.Checked
        Dim relAR As Boolean = NewARRelative.Checked
        Dim relOD As Boolean = NewODRelative.Checked

        Dim oldMaps As Boolean = IncludeOldMaps.Checked

        Dim args As String = "-" & mode & " -name " & name & " -path " & path & " -fromHP " & fromHP & " -toHP " & toHP &
        " -fromCS " & fromCS & " -toCS " & toCS & " -fromAR " & fromAR & " -toAR " & toAR &
        " -fromOD " & fromOD & " -toOD " & toOD & " -newHP " & newHP & " -newCS " & newCS &
        " -newAR " & newAR & " -newOD " & newOD & " -relHP " & relHP & " -relCS " & relCS &
        " -relAR " & relAR & " -relOD " & relOD & " -oldMaps " & oldMaps

        Return (args)
    End Function

    Private Sub ProcessMapsButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProcessMapsButton.Click
        Hide()
        If (DirectoryInputBox.Text.Length > 0) Then
            If (NameInputBox.Text.Length > 0) Then
                Dim answer As DialogResult = DialogResult.No
                If CreateModeRadioButton.Checked = True Then
                    answer = MessageBox.Show("Are you sure you want to create beatmaps called " & NameInputBox.Text & " with the specified settings?", "Create beatmaps", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                ElseIf UpdateModeRadioButton.Checked = True Then
                    answer = MessageBox.Show("Are you sure you want to update beatmaps called " & NameInputBox.Text & " with the specified settings?", "Update beatmaps", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                ElseIf DeleteModeRadioButton.Checked = True Then
                    answer = MessageBox.Show("Are you sure you want to delete beatmaps called " & NameInputBox.Text & " with the specified settings?", "Delete beatmaps", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                End If
                If answer = DialogResult.Yes Then
                    Try
                        Dim Args As String() = Regex.Matches(ConstructArgs(), "(""[^""]+""|[\S]+)").Cast(Of Match)().[Select](Function(m) m.Value).ToArray()
                        For i As Integer = 0 To Args.Length - 1
                            Args(i) = Args(i).Replace("""", "")
                        Next
                        Main(Args)
                    Catch ex As Exception
                        MessageBox.Show("Error: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Console.WriteLine("Cancelled")
                    End Try
                End If
            Else
                MessageBox.Show("Beatmap name prefix not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Console.WriteLine("Cancelled")
            End If
        Else
            MessageBox.Show("Songs folder path not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine("Cancelled")
        End If
        Show()
    End Sub

    Private Sub BatchfileSaveDialog_FileOk(ByVal sender As Object, ByVal e As ComponentModel.CancelEventArgs) Handles BatchfileSaveDialog.FileOk
        Try
            Dim batchfile As String = ("@ECHO OFF" & Environment.NewLine & """" & Application.ExecutablePath & """" & " " & ConstructArgs() & Environment.NewLine & "pause").Trim()
            File.WriteAllText(BatchfileSaveDialog.FileName, batchfile)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BatchfileSaveDialog.FileName = ""
    End Sub

    Private Sub BatchfileSaveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BatchfileSaveButton.Click
        BatchfileSaveDialog.ShowDialog()
    End Sub

    Private Sub NameInputBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NameInputBox.TextChanged
        NameInputBox.Text = NameInputBox.Text.Replace(" ", "")
    End Sub

    Private Sub NewHPRelative_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NewHPRelative.CheckedChanged
        If (NewHPRelative.Checked) Then
            NewHPBar.Enabled = False
            NewHPBox.Text = "0"
        Else
            NewHPBar.Enabled = True
            NewHPBox.Text = Convert.ToString(NewHPBar.Value / 10.0)
        End If
    End Sub

    Private Sub NewCSRelative_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NewCSRelative.CheckedChanged
        If (NewCSRelative.Checked) Then
            NewCSBar.Enabled = False
            NewCSBox.Text = "0"
        Else
            NewCSBar.Enabled = True
            NewCSBox.Text = Convert.ToString(NewCSBar.Value / 10.0)
        End If
    End Sub

    Private Sub NewARRelative_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NewARRelative.CheckedChanged
        If (NewARRelative.Checked) Then
            NewARBar.Enabled = False
            NewARBox.Text = "0"
        Else
            NewARBar.Enabled = True
            NewARBox.Text = Convert.ToString(NewARBar.Value / 10.0)
        End If
    End Sub

    Private Sub NewODRelative_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NewODRelative.CheckedChanged
        If (NewODRelative.Checked) Then
            NewODBar.Enabled = False
            NewODBox.Text = "0"
        Else
            NewODBar.Enabled = True
            NewODBox.Text = Convert.ToString(NewODBar.Value / 10.0)
        End If
    End Sub

    Private Sub FromOldHPBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles FromOldHPBar.Scroll
        If FromOldHPBar.Value > ToOldHPBar.Value Then
            FromOldHPBar.Value = ToOldHPBar.Value
        End If
        FromOldHPLabel.Text = "From " & FromOldHPBar.Value / 10.0
    End Sub

    Private Sub FromOldCSBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles FromOldCSBar.Scroll
        If FromOldCSBar.Value > ToOldCSBar.Value Then
            FromOldCSBar.Value = ToOldCSBar.Value
        End If
        FromOldCSLabel.Text = "From " & FromOldCSBar.Value / 10.0
    End Sub

    Private Sub FromOldARBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles FromOldARBar.Scroll
        If FromOldARBar.Value > ToOldARBar.Value Then
            FromOldARBar.Value = ToOldARBar.Value
        End If
        FromOldARLabel.Text = "From " & FromOldARBar.Value / 10.0
    End Sub

    Private Sub FromOldODBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles FromOldODBar.Scroll
        If FromOldODBar.Value > ToOldODBar.Value Then
            FromOldODBar.Value = ToOldODBar.Value
        End If
        FromOldODLabel.Text = "From " & FromOldODBar.Value / 10.0
    End Sub
    Private Sub ToOldHPBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles ToOldHPBar.Scroll
        If ToOldHPBar.Value < FromOldHPBar.Value Then
            ToOldHPBar.Value = FromOldHPBar.Value
        End If
        ToOldHPLabel.Text = "To " & ToOldHPBar.Value / 10.0
    End Sub

    Private Sub ToOldCSBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles ToOldCSBar.Scroll
        If ToOldCSBar.Value < FromOldCSBar.Value Then
            ToOldCSBar.Value = FromOldCSBar.Value
        End If
        ToOldCSLabel.Text = "To " & ToOldCSBar.Value / 10.0
    End Sub

    Private Sub ToOldARBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles ToOldARBar.Scroll
        If ToOldARBar.Value < FromOldARBar.Value Then
            ToOldARBar.Value = FromOldARBar.Value
        End If
        ToOldARLabel.Text = "To " & ToOldARBar.Value / 10.0
    End Sub

    Private Sub ToOldODBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles ToOldODBar.Scroll
        If ToOldODBar.Value < FromOldODBar.Value Then
            ToOldODBar.Value = FromOldODBar.Value
        End If
        ToOldODLabel.Text = "To " & ToOldODBar.Value / 10.0
    End Sub

    Private Sub NewHPBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles NewHPBar.Scroll
        NewHPBox.Text = Convert.ToString(NewHPBar.Value / 10.0)
    End Sub

    Private Sub NewCSBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles NewCSBar.Scroll
        NewCSBox.Text = Convert.ToString(NewCSBar.Value / 10.0)
    End Sub

    Private Sub NewARBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles NewARBar.Scroll
        NewARBox.Text = Convert.ToString(NewARBar.Value / 10.0)
    End Sub

    Private Sub NewODBar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles NewODBar.Scroll
        NewODBox.Text = Convert.ToString(NewODBar.Value / 10.0)
    End Sub

    Private Sub DirectoryFindButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DirectoryDetectButton.Click
        Try
            Dim taSongs As String() = Convert.ToString(Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Classes\osu\DefaultIcon", "", """C\"",0")).Split(CType("""", Char()))
            DirectoryInputBox.Text = taSongs(1).Replace("osu!.exe", "Songs")
        Catch ex As Exception
            MessageBox.Show("Can't find osu! folder from registry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub NewHPBox_TextChanged(sender As Object, e As EventArgs) Handles NewHPBox.TextChanged
        If NewHPRelative.Checked = False Then
            Dim d As Double = 0
            Double.TryParse(NewHPBox.Text, d)
            If d > 10 Then
                d = 10
                NewHPBox.Text = "10"
                NewHPBox.SelectAll()
            End If
            If d < 0 Then
                d = 0
                NewHPBox.Text = "0"
                NewHPBox.SelectAll()
            End If
            NewHPBar.Value = Convert.ToInt32(d * 10)
        End If
    End Sub

    Private Sub NewCSBox_TextChanged(sender As Object, e As EventArgs) Handles NewCSBox.TextChanged
        If NewCSRelative.Checked = False Then
            Dim d As Double = 0
            Double.TryParse(NewCSBox.Text, d)
            If d > 10 Then
                d = 10
                NewCSBox.Text = "10"
                NewCSBox.SelectAll()
            End If
            If d < 0 Then
                d = 0
                NewCSBox.Text = "0"
                NewCSBox.SelectAll()
            End If
            NewCSBar.Value = Convert.ToInt32(d * 10)
        End If
    End Sub

    Private Sub NewARBox_TextChanged(sender As Object, e As EventArgs) Handles NewARBox.TextChanged
        If NewARRelative.Checked = False Then
            Dim d As Double = 0
            Double.TryParse(NewARBox.Text, d)
            If d > 10 Then
                d = 10
                NewARBox.Text = "10"
                NewARBox.SelectAll()
            End If
            If d < 0 Then
                d = 0
                NewARBox.Text = "0"
                NewARBox.SelectAll()
            End If
            NewARBar.Value = Convert.ToInt32(d * 10)
        End If
    End Sub

    Private Sub NewODBox_TextChanged(sender As Object, e As EventArgs) Handles NewODBox.TextChanged
        If NewODRelative.Checked = False Then
            Dim d As Double = 0
            Double.TryParse(NewODBox.Text, d)
            If d > 10 Then
                d = 10
                NewODBox.Text = "10"
                NewODBox.SelectAll()
            End If
            If d < 0 Then
                d = 0
                NewODBox.Text = "0"
                NewODBox.SelectAll()
            End If
            NewODBar.Value = Convert.ToInt32(d * 10)
        End If
    End Sub

    Private Sub DubuLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DubuLink.LinkClicked
        Process.Start("https://osu.ppy.sh/u/Dubu")
    End Sub

    Private Sub JTFLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles JTFLink.LinkClicked
        Process.Start("https://osu.ppy.sh/u/JTF195")
    End Sub
End Class