Public Class Form1
    Dim TextDisplay() As String
    Dim TextDisplaySentence() As String
    Dim TextUser() As String
    Dim UserLoc As Integer
    Dim Miss As Integer
    Dim startTime As Integer
    Dim timeRem As Integer
    Dim textLoaded As Boolean
    Dim sessionStart As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + ") Then
        'Else
        '    My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + ")
        'End If


        txtWPM.Text = "60"
        RTBDisplay.ReadOnly = True
        RTBDisplay.ShortcutsEnabled = False
        RTBUser.ReadOnly = True
        RTBUser.ShortcutsEnabled = False
        RTBUser.Text = "press start"
    End Sub

    Private Sub btBrowse_Click(sender As Object, e As EventArgs) Handles btBrowse.Click
        Dim OpenFile As New OpenFileDialog()

        OpenFile.DefaultExt = "*.txt"
        OpenFile.Filter = "Text Files|*.txt"

        If (OpenFile.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Dim temp As String
            temp = My.Computer.FileSystem.ReadAllText(OpenFile.FileName)
            temp = Replace(temp, vbCrLf, " ")
            TextDisplay = temp.Split(" ")
            temp = Replace(temp, ". ", ".")
            TextDisplaySentence = temp.Split(".")

            txtFileName.Text = OpenFile.FileName
            textLoaded = True
            LoadTimer()
            'For i = 0 To TextDisplaySentence.Length - 1
            '    If i = TextDisplaySentence.Length - 1 Then
            '        RTBDisplay.AppendText(TextDisplaySentence(i))
            '    Else
            '        RTBDisplay.AppendText(TextDisplaySentence(i) + "." + vbCrLf)
            '    End If

            'Next
            If TextDisplaySentence.Length > 1 Then
                RTBDisplay.AppendText(TextDisplaySentence(0) + "." + vbCrLf + TextDisplaySentence(1) + ".")
            Else
                RTBDisplay.AppendText(TextDisplaySentence(0) + ".")
            End If

        End If


    End Sub


    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        If sessionStart = True Then
            Submit()
            LoadTimer()
        End If

    End Sub

    Private Sub RTBUser_SelectionChanged(sender As Object, e As EventArgs) Handles RTBUser.SelectionChanged
        Dim CursorLoc As Integer

        CursorLoc = RTBUser.SelectionStart

        For i = 0 To TextDisplaySentence.Length - 1
            CursorLoc = CursorLoc - TextDisplaySentence(i).Length - 2
            If CursorLoc < 1 Then
                RTBDisplay.Clear()
                RTBDisplay.AppendText(TextDisplaySentence(i) + "." + vbCrLf + TextDisplaySentence(i + 1) + ".")
                Exit For
            End If
        Next
    End Sub

    Private Sub btStart_Click(sender As Object, e As EventArgs) Handles btStart.Click

        If textLoaded = True Then
            RTBDisplay.Clear()
            RTBUser.Clear()

            lblWPM.Text = "00"
            lblScore.Text = "00"

            If TextDisplaySentence.Length > 1 Then
                RTBDisplay.AppendText(TextDisplaySentence(0) + "." + vbCrLf + TextDisplaySentence(1) + ".")
            Else
                RTBDisplay.AppendText(TextDisplaySentence(0) + ".")
            End If

            Timer1.Enabled = True
            RTBUser.ReadOnly = False
            RTBUser.Focus()
            sessionStart = True

        Else
            MsgBox("ASDF")
        End If

    End Sub

    Private Sub txtWPM_TextChanged(sender As Object, e As EventArgs) Handles txtWPM.TextChanged
        LoadTimer()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If CInt(lblSec.Text = 0) Then
            If CInt(lblMin.Text) = 0 Then
                Submit()
                Exit Sub

            End If

            lblMin.Text = CStr(CInt(lblMin.Text) - 1)
            If CInt(lblMin.Text) < 10 Then
                lblMin.Text = "0" + lblMin.Text
            End If
            lblSec.Text = "59"
        Else
            lblSec.Text = CStr(CInt(lblSec.Text) - 1)
            If CInt(lblSec.Text) < 10 Then
                lblSec.Text = "0" + lblSec.Text
            End If
        End If

        timeRem = timeRem - 1
    End Sub

    Function Submit() As Nullable

        Dim temp As String
        Dim Accuracy As Double
        Dim WPM As Integer

        If (RTBUser.Text = "") Then
            RTBUser.Clear()
            sessionStart = False
            Timer1.Enabled = False
            RTBUser.ReadOnly = True
            LoadTimer()
            Exit Function
        End If


        Timer1.Enabled = False
        RTBUser.ReadOnly = True

        temp = RTBUser.Text
        Miss = 0

        temp = Replace(temp, ControlChars.Lf, " ")
        TextUser = temp.Split(" ")

        For i = 0 To TextUser.Length - 1
            If TextUser(i) = TextDisplay(i) Then
            Else
                Miss = Miss + 1
            End If

            If i = TextDisplay.Length - 1 Then Exit For
        Next


        If (TextUser.Length < TextDisplay.Length) Then
            Miss = Miss + TextDisplay.Length - TextUser.Length
        Else
            Miss = Miss + TextUser.Length - TextDisplay.Length
        End If

        Accuracy = (TextDisplay.Length - Miss) / TextDisplay.Length * 100

        If startTime = timeRem Then
            timeRem = timeRem - 1
        End If
        WPM = TextUser.Length / (startTime - timeRem) * 60
        lblWPM.Text = WPM

        lblScore.Text = CInt(Accuracy)
        sessionStart = False
    End Function

    Function LoadTimer() As Nullable
        Dim WPM As Integer
        If (textLoaded = True) Then
            If txtWPM.Text = "" Then
                WPM = 0
            Else
                WPM = CInt(txtWPM.Text)
            End If

            If WPM = 0 Then
                lblMin.Text = "00"
                lblSec.Text = "00"
            Else


                startTime = TextDisplay.Length / WPM * 60

                lblMin.Text = CStr((startTime - (startTime Mod 60)) / 60)
                lblSec.Text = CStr(startTime Mod 60)

                If CInt(lblMin.Text) < 10 Then
                    lblMin.Text = "0" + lblMin.Text
                End If

                If CInt(lblSec.Text) < 10 Then
                    lblSec.Text = "0" + lblSec.Text
                End If

                timeRem = startTime
            End If

        End If
    End Function
End Class
