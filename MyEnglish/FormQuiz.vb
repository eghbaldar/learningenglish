Public Class FormQuiz

    Dim i As Integer = 0
    Private Sub FormQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tbSentencesRandom' table. You can move, or remove it, as needed.

        Me.TbSentencesRandomTableAdapter.Fill(Me.DataSet.tbSentencesRandom)
        lblFarsi.Text = DataGridView.Item(4, i).Value
        lblCount.Text = DataGridView.Rows.Count
        lblID.Text = DataGridView.Item(1, i).Value
        CheckStar(Val(lblID.Text))
        Me.Tag = 0

    End Sub

    Private Sub CheckStar(id As Long)
        Dim ds As New DataSetTableAdapters.tbSentencesTableAdapter
        Select Case Convert.ToBoolean(ds.GetDataSelectBy(Val(id)).Rows(0).Item(4))
            Case False
                picStar.Image = My.Resources.starempty
                picStar.Tag = 0
            Case True
                picStar.Image = My.Resources.starfull
                picStar.Tag = 1
        End Select
    End Sub

    Private Sub TxtEnglish_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEnglish.KeyDown

        If i < DataGridView.Rows.Count Then
            If e.KeyCode = Keys.Enter Then
                e.Handled = True
                e.SuppressKeyPress = True
                Select Case Me.Tag.ToString
                    Case "0"
                        txtEnglish.Text = DataGridView.Item(3, i).Value.ToString.Trim.ToLower
                        Me.Tag = 1
                        lblID.Text = DataGridView.Item(1, i).Value
                        CheckStar(Val(lblID.Text))
                        i += 1
                    Case "1"
                        lblFarsi.Text = DataGridView.Item(4, i).Value
                        lblCount.Text = Val(lblCount.Text) - 1
                        txtEnglish.Clear()
                        lblID.Text = DataGridView.Item(1, i).Value
                        CheckStar(Val(lblID.Text))
                        Me.Tag = 0
                End Select
            End If
        Else
            ''''RESET!
            i = 0
            Me.Tag = 0
            txtEnglish.Clear()
            lblFarsi.Text = DataGridView.Item(4, i).Value
            lblCount.Text = DataGridView.Rows.Count
            MsgBox("Everything has just reseted! Good Luck Dude!")
        End If


        'Try
        '    If i <= DataGridView.Rows.Count Then
        '        If e.KeyCode = Keys.Enter Then
        '            If txtEnglish.Text.Length > 0 Then
        '                If txtEnglish.Text.Trim.ToLower = DataGridView.Item(3, i).Value.ToString.Trim.ToLower Then
        '                    MsgBox("Correct!", MsgBoxStyle.Information, "")
        '                    i += 1
        '                    lblFarsi.Text = DataGridView.Item(4, i).Value
        '                    lblCount.Text = Val(lblCount.Text) - 1
        '                    txtEnglish.Clear()
        '                Else
        '                    If MessageBox.Show("Would you want try it again?" & vbCrLf & "[YES = Let's Try] [NO = Next Question]", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '                        txtEnglish.Select()
        '                    Else
        '                        MsgBox(DataGridView.Item(3, i).Value.ToString, MsgBoxStyle.Information, "The Correct Answer")
        '                        txtEnglish.Clear()
        '                        i += 1
        '                        lblFarsi.Text = DataGridView.Item(4, i).Value
        '                        lblCount.Text = Val(lblCount.Text) - 1
        '                    End If

        '                End If
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    i = 0
        '    lblFarsi.Text = DataGridView.Item(4, i).Value
        '    txtEnglish.Clear()
        '    txtEnglish.Select()
        'End Try
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

    Private Sub PicStar_Click(sender As Object, e As EventArgs) Handles picStar.Click
        GoEnter()
    End Sub

    Private Sub GoEnter()
        Dim ds As New DataSetTableAdapters.tbSentencesTableAdapter
        Select Case picStar.Tag
            Case 0
                picStar.Tag = 1
                picStar.Image = My.Resources.starfull
                ds.UpdateStar(1, Val(lblID.Text))
            Case 1
                picStar.Tag = 0
                picStar.Image = My.Resources.starempty
                ds.UpdateStar(0, Val(lblID.Text))
        End Select
    End Sub

End Class