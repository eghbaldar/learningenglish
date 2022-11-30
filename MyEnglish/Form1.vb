Imports System.ComponentModel
Imports System.IO
Imports System.Media
Imports AxWMPLib
Imports WMPLib

Public Class Form1

    Private Sub txtEnglish_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEnglish.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtEnglish.Text.Length > 0 Then
                txtFarsi.Select()
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            Me.Hide()
            FormQuiz.Show()
        End If
    End Sub

    Private Sub txtFarsi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFarsi.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtEnglish.Text.Length > 0 And txtFarsi.Text.Length > 0 Then

                Dim ds As New DataSetTableAdapters.tbSentencesTableAdapter

                If lblUpdateID.Text.Trim.Length = 0 Then 'ADD
                    ds.InsertSentence(txtEnglish.Text.Trim, txtFarsi.Text.Trim)
                    MsgBox("Added", MsgBoxStyle.Information, "")
                Else
                    ds.UpdateSentence(txtEnglish.Text.Trim, txtFarsi.Text.Trim, Val(lblUpdateID.Text))
                    lblUpdateID.Text = Nothing
                    MsgBox("Updated", MsgBoxStyle.Information, "")
                End If

                Me.TbSentencesTableAdapter.Fill(Me.DataSet.tbSentences, "")
                txtEnglish.Clear()
                txtEnglish.Select()
                txtFarsi.Clear()
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            Me.Hide()
            FormQuiz.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbSentencesTableAdapter.Fill(Me.DataSet.tbSentences, "")
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        If DataGridView.Rows.Count > 0 Then

        End If
    End Sub

    Private Sub DataGridView_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles DataGridView.DataBindingComplete
        Dim _contextmenu As New ContextMenuStrip
        _contextmenu.Items.Add("Update")
        _contextmenu.Items.Add("-")
        _contextmenu.Items.Add("Delete")
        AddHandler _contextmenu.ItemClicked, AddressOf contextmenu_click
        For Each rw As DataGridViewRow In DataGridView.Rows
            For Each c As DataGridViewCell In rw.Cells
                c.ContextMenuStrip = _contextmenu
            Next
        Next
        _contextmenu.RightToLeft = False

    End Sub

    Private Sub contextmenu_click(ByVal sender As System.Object, ByVal e As ToolStripItemClickedEventArgs)
        Dim ds As New DataSetTableAdapters.tbSentencesTableAdapter
        Dim clickCell_ID As DataGridViewCell = DataGridView.CurrentRow.Cells(0)
        Select Case e.ClickedItem.Text
            Case "Update"
                lblUpdateID.Text = clickCell_ID.Value.ToString
                txtEnglish.Text = ds.GetDataSelectBy(clickCell_ID.Value).Rows(0).Item(2).ToString
                txtFarsi.Text = ds.GetDataSelectBy(clickCell_ID.Value).Rows(0).Item(3).ToString
                txtEnglish.Select()
            Case "Delete"
                If MessageBox.Show("Sure?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    ds.DeleteSentence(Val(clickCell_ID.Value))
                    Me.TbSentencesTableAdapter.Fill(Me.DataSet.tbSentences, "")
                    txtEnglish.Select()
                End If
        End Select
    End Sub

    Private Sub BtnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click
        Me.Hide()
        FormQuiz.Show()
    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        frmShow.ShowDialog()
    End Sub

    Private Sub BtnHideShow_Click(sender As Object, e As EventArgs) Handles btnHideShow.Click
        If btnHideShow.Text.Trim.ToLower = "hide" Then
            Me.Size = New Size(749, 350)
            btnHideShow.Text = "Show"
        Else
            Me.Size = New Size(749, 625)
            btnHideShow.Text = "Hide"
        End If
    End Sub

    Private Sub TxtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        Me.TbSentencesTableAdapter.Fill(Me.DataSet.tbSentences, txtSearch.Text.Trim)
    End Sub

    Shared URL() As String
    Dim URL_LENGTH As Integer
    Dim URL_CURRENT As Integer
    Dim FirstMyLoop As Integer
    Dim MyLoop As Byte

    Private Sub BtnPronunciation_Click(sender As Object, e As EventArgs) Handles btnPronunciation.Click
        Dim op As New FolderBrowserDialog
        op.ShowDialog()

        URL = Directory.GetFiles(op.SelectedPath)
        'To remove the files in which there are not standard audio format
        For i As Integer = 0 To URL.Length - 1
            If Path.GetExtension(URL(i)) <> ".wav" And Path.GetExtension(URL(i)) <> ".mp3" Then
                URL = URL.Except({URL(i)}).ToArray
            End If
        Next
        '----------------------------
        URL_LENGTH = URL.Length
        URL_CURRENT = 0
        FirstMyLoop = Val(InputBox("What would like to repeat it?")) - 1
        MyLoop = FirstMyLoop
        AxWindowsMediaPlayer1.URL = URL(URL_CURRENT)
        SetPronunciationaWord()
    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsMediaEnded Then
            Timer1.Interval = 100
            Timer1.Enabled = True
        End If
    End Sub

    Sub SetPronunciationaWord()
        Me.Text = Path.GetFileNameWithoutExtension(URL(URL_CURRENT)).ToUpper
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (MyLoop > 0) And URL_CURRENT < URL_LENGTH Then
            AxWindowsMediaPlayer1.URL = URL(URL_CURRENT)
            SetPronunciationaWord()
            Timer1.Enabled = False
            MyLoop -= 1
        Else
            If URL_CURRENT < URL_LENGTH Then
                MyLoop = FirstMyLoop
                AxWindowsMediaPlayer1.URL = URL(URL_CURRENT)
                SetPronunciationaWord()
                URL_CURRENT += 1
                Timer1.Enabled = False
            Else
                URL_CURRENT = 0
                MyLoop = 0
                Timer1.Enabled = False
                Me.Text = "My English v10.1"
            End If
        End If

    End Sub
End Class
