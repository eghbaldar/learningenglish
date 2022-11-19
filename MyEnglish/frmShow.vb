Imports System.IO

Public Class frmShow
    Private Sub frmShow_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblFarsi.Height = Me.Height / 2
        picStar.Location = New Point((Me.Width / 2) - (picStar.Width / 2), 10)
        lblID.Location = New Point(10, 10)
        BtnExit.Location = New Point(10, 30)
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
        lblID.Text = Me.Tag
        CheckStar(Me.Tag)

    End Sub

    Private Sub CheckStar(id As Long)
        Dim ds As New DataSetTableAdapters.tbSentencesTableAdapter
        Select Case Convert.ToBoolean(ds.GetDataSelectBy(Val(Me.Tag)).Rows(0).Item(4))
            Case False
                picStar.Image = My.Resources.starempty
                picStar.Tag = 0
            Case True
                picStar.Image = My.Resources.starfull
                picStar.Tag = 1
        End Select
    End Sub

    Public Sub ClickHandler(sender As Object, e As MouseEventArgs) Handles lblFarsi.MouseClick, lblEn.MouseClick

        'Next Sentence
        If e.Button = MouseButtons.Right Then GoLeft()
        'Previous Sentence
        If e.Button = MouseButtons.Left Then GoRight()

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        If keyData = Keys.Escape Then Me.Close()
        'Set Star
        If keyData = Keys.Enter Then GoEnter()
        'Next Sentence
        If keyData = Keys.Right Then GoRight()
        'Previous Sentence
        If keyData = Keys.Left Then GoLeft()

        Return MyBase.ProcessCmdKey(msg, keyData)


    End Function

    Private Sub GoEnter()
        Dim ds As New DataSetTableAdapters.tbSentencesTableAdapter
        Select Case picStar.Tag
            Case 0
                picStar.Tag = 1
                picStar.Image = My.Resources.starfull
                ds.UpdateStar(1, Val(Me.Tag))
            Case 1
                picStar.Tag = 0
                picStar.Image = My.Resources.starempty
                ds.UpdateStar(0, Val(Me.Tag))
        End Select
    End Sub

    Private Sub GoRight()
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
            lblID.Text = Me.Tag
            CheckStar(Me.Tag)
        End If
    End Sub

    Private Sub GoLeft()
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
        lblID.Text = Me.Tag
        CheckStar(Me.Tag)
    End Sub

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

    Private Sub PicStar_Click(sender As Object, e As EventArgs) Handles picStar.Click
        GoEnter()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

End Class