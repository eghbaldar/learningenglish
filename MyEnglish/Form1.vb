Public Class Form1

    Private Sub txtEnglish_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEnglish.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtEnglish.Text.Length > 1 Then
                txtFarsi.Select()
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            FormQuiz.ShowDialog()
        End If
    End Sub

    Private Sub txtFarsi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFarsi.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtEnglish.Text.Length > 1 And txtFarsi.Text.Length > 1 Then

                Dim ds As New DataSetTableAdapters.tbSentencesTableAdapter
                ds.InsertSentence(txtEnglish.Text.Trim, txtFarsi.Text.Trim)
                Me.TbSentencesTableAdapter.Fill(Me.DataSet.tbSentences)

                MsgBox("درج شد")
                txtEnglish.Clear()
                txtEnglish.Select()
                txtFarsi.Clear()
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            FormQuiz.ShowDialog()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TbSentencesTableAdapter.Fill(Me.DataSet.tbSentences)
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        If DataGridView.Rows.Count > 0 Then
            If MessageBox.Show("Sure?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim ds As New DataSetTableAdapters.tbSentencesTableAdapter
                ds.DeleteSentence(Val(DataGridView.Item(0, e.RowIndex).Value.ToString))
                Me.TbSentencesTableAdapter.Fill(Me.DataSet.tbSentences)
                txtEnglish.Select()
            End If
        End If
    End Sub

End Class
