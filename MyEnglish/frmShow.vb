Imports System.IO

Public Class frmShow
    Private Sub frmShow_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblFarsi.Height = Me.Height / 2

        ''''''''''''''''''''''''''''''''''''' READ FILE
        Dim strPath As String = String.Format("{0}\", Environment.CurrentDirectory)
        Dim line As String
        Try
            Using reader As New StreamReader("lastReview.txt")
                line = reader.ReadLine()
            End Using
        Catch ex As Exception
            If Err.Number = 53 Then
                MsgBox("There is no needed the text file for saving last Id of senetence. Please create a *.txt named: lastReview next to EXE file. Thanks")
                Me.Close()
            End If
        End Try
        '''''''''''''''''''''''''''''''''''''
        If Val(line) <> 0 Then 'It means there is a LAST ID based on our LAST REVIEW
            Dim ds As New DataSetTableAdapters.Sentences_NextTableAdapter
            lblFarsi.Text = ds.GetData(Val(line)).Rows(0).Item(3).ToString
            lblEn.Text = ds.GetData(Val(line)).Rows(0).Item(2).ToString
            Me.Tag = ds.GetData(Val(line)).Rows(0).Item(0).ToString
            lblEn.Visible = False
        Else 'It means start the first sentence
            Dim ds As New DataSetTableAdapters.Sentences_FirstTableAdapter
            lblFarsi.Text = ds.GetData().Rows(0).Item(3).ToString
            lblEn.Text = ds.GetData().Rows(0).Item(2).ToString
            Me.Tag = ds.GetData().Rows(0).Item(0).ToString
        End If
        '''''''''''''''''''''''''''''''''''''
        lblID.Location = New Point(10, 10)
        lblID.Text = Me.Tag

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If

        'Next Sentence
        If keyData = Keys.Right Then
            If lblEn.Visible = False Then
                lblEn.Visible = True
            Else

                Dim ds As New DataSetTableAdapters.Sentences_NextTableAdapter
                lblFarsi.Text = ds.GetData(Val(Me.Tag)).Rows(0).Item(3).ToString
                lblEn.Text = ds.GetData(Val(Me.Tag)).Rows(0).Item(2).ToString
                Me.Tag = ds.GetData(Val(Me.Tag)).Rows(0).Item(0).ToString
                lblEn.Visible = False
                '''''''''''''''''''''''''''''''''' WRITE IN FILE FOR KEEP LAST SENTENCE ID
                Dim strPath As String = String.Format("{0}\", Environment.CurrentDirectory)
                System.IO.File.WriteAllText(strPath & "\lastReview.txt", "") 'cleaning the all text
                Using writer As New StreamWriter(strPath & "\lastReview.txt", True)
                    writer.Write(Me.Tag)
                End Using
                ''''''''''''''''''''''''''''''''''
            End If
        End If
        'Previous Sentence
        If keyData = Keys.Left Then
            Me.Tag = Str(Val(Me.Tag) - 1)
            Dim ds As New DataSetTableAdapters.Sentences_NextTableAdapter
            lblFarsi.Text = ds.GetData(Val(Me.Tag) - 1).Rows(0).Item(3).ToString
            lblEn.Text = ds.GetData(Val(Me.Tag) - 1).Rows(0).Item(2).ToString
            lblEn.Visible = True
            '''''''''''''''''''''''''''''''''' WRITE IN FILE FOR KEEP LAST SENTENCE ID
            Dim strPath As String = String.Format("{0}\", Environment.CurrentDirectory)
            System.IO.File.WriteAllText(strPath & "\lastReview.txt", "") 'cleaning the all text
            Using writer As New StreamWriter(strPath & "\lastReview.txt", True)
                writer.Write(Me.Tag)
            End Using
            ''''''''''''''''''''''''''''''''''
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)


    End Function

    Private Sub LblID_Click(sender As Object, e As EventArgs) Handles lblID.Click
        Dim ds As New DataSetTableAdapters.tbSentencesTableAdapter
        Dim FA = InputBox("", "", lblFarsi.Text).Trim
        Dim EN = InputBox("", "", lblEn.Text).Trim
        If FA <> Nothing And EN <> Nothing Then
            ds.UpdateSentence(EN, FA, Val(lblID.Text))
            lblEn.Text = EN
            lblFarsi.Text = FA
        End If
    End Sub

End Class