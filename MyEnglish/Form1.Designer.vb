<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFarsi = New System.Windows.Forms.TextBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnglishDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarsiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbSentencesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New MyEnglish.DataSet()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUpdateID = New System.Windows.Forms.Label()
        Me.btnHideShow = New System.Windows.Forms.Button()
        Me.btnQuiz = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.TbSentencesTableAdapter = New MyEnglish.DataSetTableAdapters.tbSentencesTableAdapter()
        Me.btnPronunciation = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbSentencesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEnglish
        '
        Me.txtEnglish.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEnglish.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnglish.Location = New System.Drawing.Point(14, 45)
        Me.txtEnglish.Multiline = True
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(704, 84)
        Me.txtEnglish.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "English :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Nazanin", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(638, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(80, 43)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "فارسی:"
        '
        'txtFarsi
        '
        Me.txtFarsi.BackColor = System.Drawing.Color.PeachPuff
        Me.txtFarsi.Font = New System.Drawing.Font("B Nazanin", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtFarsi.Location = New System.Drawing.Point(14, 177)
        Me.txtFarsi.Multiline = True
        Me.txtFarsi.Name = "txtFarsi"
        Me.txtFarsi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFarsi.Size = New System.Drawing.Size(704, 103)
        Me.txtFarsi.TabIndex = 2
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.EnglishDataGridViewTextBoxColumn, Me.FarsiDataGridViewTextBoxColumn})
        Me.DataGridView.DataSource = Me.TbSentencesBindingSource
        Me.DataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView.Location = New System.Drawing.Point(0, 341)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(733, 245)
        Me.DataGridView.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'EnglishDataGridViewTextBoxColumn
        '
        Me.EnglishDataGridViewTextBoxColumn.DataPropertyName = "english"
        Me.EnglishDataGridViewTextBoxColumn.HeaderText = "English"
        Me.EnglishDataGridViewTextBoxColumn.Name = "EnglishDataGridViewTextBoxColumn"
        Me.EnglishDataGridViewTextBoxColumn.ReadOnly = True
        Me.EnglishDataGridViewTextBoxColumn.Width = 300
        '
        'FarsiDataGridViewTextBoxColumn
        '
        Me.FarsiDataGridViewTextBoxColumn.DataPropertyName = "farsi"
        Me.FarsiDataGridViewTextBoxColumn.HeaderText = "Farsi"
        Me.FarsiDataGridViewTextBoxColumn.Name = "FarsiDataGridViewTextBoxColumn"
        Me.FarsiDataGridViewTextBoxColumn.ReadOnly = True
        Me.FarsiDataGridViewTextBoxColumn.Width = 300
        '
        'TbSentencesBindingSource
        '
        Me.TbSentencesBindingSource.DataMember = "tbSentences"
        Me.TbSentencesBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.UpdateToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(113, 48)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'lblUpdateID
        '
        Me.lblUpdateID.Location = New System.Drawing.Point(644, 9)
        Me.lblUpdateID.Name = "lblUpdateID"
        Me.lblUpdateID.Size = New System.Drawing.Size(39, 22)
        Me.lblUpdateID.TabIndex = 5
        '
        'btnHideShow
        '
        Me.btnHideShow.Location = New System.Drawing.Point(14, 286)
        Me.btnHideShow.Name = "btnHideShow"
        Me.btnHideShow.Size = New System.Drawing.Size(704, 23)
        Me.btnHideShow.TabIndex = 6
        Me.btnHideShow.Text = "Hide"
        Me.btnHideShow.UseVisualStyleBackColor = True
        '
        'btnQuiz
        '
        Me.btnQuiz.Location = New System.Drawing.Point(643, 8)
        Me.btnQuiz.Name = "btnQuiz"
        Me.btnQuiz.Size = New System.Drawing.Size(75, 31)
        Me.btnQuiz.TabIndex = 7
        Me.btnQuiz.Text = "Stared !"
        Me.btnQuiz.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(569, 8)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 30)
        Me.btnShow.TabIndex = 8
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(14, 314)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(703, 21)
        Me.txtSearch.TabIndex = 9
        '
        'TbSentencesTableAdapter
        '
        Me.TbSentencesTableAdapter.ClearBeforeFill = True
        '
        'btnPronunciation
        '
        Me.btnPronunciation.Location = New System.Drawing.Point(443, 8)
        Me.btnPronunciation.Name = "btnPronunciation"
        Me.btnPronunciation.Size = New System.Drawing.Size(108, 31)
        Me.btnPronunciation.TabIndex = 10
        Me.btnPronunciation.Text = "Pronunciation"
        Me.btnPronunciation.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(155, 8)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(282, 31)
        Me.AxWindowsMediaPlayer1.TabIndex = 11
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 586)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.btnPronunciation)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnQuiz)
        Me.Controls.Add(Me.btnHideShow)
        Me.Controls.Add(Me.lblUpdateID)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFarsi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEnglish)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My English v10.2"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbSentencesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFarsi As TextBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents DataSet As DataSet
    Friend WithEvents TbSentencesBindingSource As BindingSource
    Friend WithEvents TbSentencesTableAdapter As DataSetTableAdapters.tbSentencesTableAdapter
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents EnglishDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarsiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblUpdateID As Label
    Friend WithEvents btnHideShow As Button
    Friend WithEvents btnQuiz As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnPronunciation As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer1 As Timer
End Class
