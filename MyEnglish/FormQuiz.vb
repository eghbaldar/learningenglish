Public Class FormQuiz

    Dim i As Integer = 0
    Private Sub FormQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tbSentencesRandom' table. You can move, or remove it, as needed.

        Me.TbSentencesRandomTableAdapter.Fill(Me.DataSet.tbSentencesRandom)
        lblFarsi.Text = DataGridView.Item(4, i).Value
        lblCount.Text = DataGridView.Rows.Count

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
                            lblCount.Text = Val(lblCount.Text) - 1
                            txtEnglish.Clear()
                        Else
                            If MessageBox.Show("Would you want try it again?" & vbCrLf & "[YES = Let's Try] [NO = Next Question]", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                txtEnglish.Select()
                            Else
                                MsgBox(DataGridView.Item(3, i).Value.ToString, MsgBoxStyle.Information, "The Correct Answer")
                                txtEnglish.Clear()
                                i += 1
                                lblFarsi.Text = DataGridView.Item(4, i).Value
                                lblCount.Text = Val(lblCount.Text) - 1
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

    Private Sub FormQuiz_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()
        Me.Hide()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class