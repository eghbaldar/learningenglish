Public Class FormQuiz

    Dim i As Integer = 0
    Private Sub FormQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TbSentencesTableAdapter.Fill(Me.DataSet.tbSentences)
        lblFarsi.Text = DataGridView.Item(4, i).Value

    End Sub

    Private Sub TxtEnglish_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEnglish.KeyDown
        Try
            If i <= DataGridView.Rows.Count Then
                If e.KeyCode = Keys.Enter Then
                    If txtEnglish.Text.Length > 0 Then
                        If txtEnglish.Text.Trim.ToLower = DataGridView.Item(3, i).Value.ToString.Trim.ToLower Then
                            MsgBox("Correct!", MsgBoxStyle.Information, "")
                            i += 1
                            lblFarsi.Text = DataGridView.Item(4, i).Value
                            txtEnglish.Clear()
                        Else
                            If MessageBox.Show("Would you want try it again?" & vbCrLf & "[YES = Let's Try] [NO = Next Question]", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                txtEnglish.Select()
                            Else
                                MsgBox(DataGridView.Item(3, i).Value.ToString, MsgBoxStyle.Information, "The Correct Answer")
                                txtEnglish.Clear()
                                i += 1
                                lblFarsi.Text = DataGridView.Item(4, i).Value
                            End If

                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            i = 0
            lblFarsi.Text = DataGridView.Item(4, i).Value
            txtEnglish.Clear()
            txtEnglish.Select()
        End Try
    End Sub

End Class