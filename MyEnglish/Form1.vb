Imports System.ComponentModel

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

End Class
