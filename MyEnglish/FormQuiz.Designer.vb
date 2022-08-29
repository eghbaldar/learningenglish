<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQuiz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormQuiz))
        Me.lblFarsi = New System.Windows.Forms.Label()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatetimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnglishDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FarsiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbSentencesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New MyEnglish.DataSet()
        Me.TbSentencesTableAdapter = New MyEnglish.DataSetTableAdapters.tbSentencesTableAdapter()
        Me.TbSentencesRandomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbSentencesRandomTableAdapter = New MyEnglish.DataSetTableAdapters.tbSentencesRandomTableAdapter()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbSentencesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbSentencesRandomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFarsi
        '
        Me.lblFarsi.BackColor = System.Drawing.Color.Cornsilk
        Me.lblFarsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFarsi.Font = New System.Drawing.Font("B Nazanin", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblFarsi.Location = New System.Drawing.Point(12, 62)
        Me.lblFarsi.Name = "lblFarsi"
        Me.lblFarsi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFarsi.Size = New System.Drawing.Size(673, 134)
        Me.lblFarsi.TabIndex = 0
        Me.lblFarsi.Text = "فارسی"
        '
        'txtEnglish
        '
        Me.txtEnglish.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtEnglish.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnglish.Location = New System.Drawing.Point(12, 208)
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(673, 38)
        Me.txtEnglish.TabIndex = 1
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.IdDataGridViewTextBoxColumn, Me.DatetimeDataGridViewTextBoxColumn, Me.EnglishDataGridViewTextBoxColumn, Me.FarsiDataGridViewTextBoxColumn})
        Me.DataGridView.DataSource = Me.TbSentencesRandomBindingSource
        Me.DataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView.Location = New System.Drawing.Point(0, 268)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(698, 228)
        Me.DataGridView.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(12, 9)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(673, 53)
        Me.lblCount.TabIndex = 6
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatetimeDataGridViewTextBoxColumn
        '
        Me.DatetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime"
        Me.DatetimeDataGridViewTextBoxColumn.HeaderText = "datetime"
        Me.DatetimeDataGridViewTextBoxColumn.Name = "DatetimeDataGridViewTextBoxColumn"
        Me.DatetimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EnglishDataGridViewTextBoxColumn
        '
        Me.EnglishDataGridViewTextBoxColumn.DataPropertyName = "english"
        Me.EnglishDataGridViewTextBoxColumn.HeaderText = "english"
        Me.EnglishDataGridViewTextBoxColumn.Name = "EnglishDataGridViewTextBoxColumn"
        Me.EnglishDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FarsiDataGridViewTextBoxColumn
        '
        Me.FarsiDataGridViewTextBoxColumn.DataPropertyName = "farsi"
        Me.FarsiDataGridViewTextBoxColumn.HeaderText = "farsi"
        Me.FarsiDataGridViewTextBoxColumn.Name = "FarsiDataGridViewTextBoxColumn"
        Me.FarsiDataGridViewTextBoxColumn.ReadOnly = True
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
        'TbSentencesTableAdapter
        '
        Me.TbSentencesTableAdapter.ClearBeforeFill = True
        '
        'TbSentencesRandomBindingSource
        '
        Me.TbSentencesRandomBindingSource.DataMember = "tbSentencesRandom"
        Me.TbSentencesRandomBindingSource.DataSource = Me.DataSet
        '
        'TbSentencesRandomTableAdapter
        '
        Me.TbSentencesRandomTableAdapter.ClearBeforeFill = True
        '
        'FormQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(700, 253)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.txtEnglish)
        Me.Controls.Add(Me.lblFarsi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbSentencesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbSentencesRandomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFarsi As Label
    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataSet As DataSet
    Friend WithEvents TbSentencesBindingSource As BindingSource
    Friend WithEvents TbSentencesTableAdapter As DataSetTableAdapters.tbSentencesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatetimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnglishDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FarsiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblCount As Label
    Friend WithEvents TbSentencesRandomBindingSource As BindingSource
    Friend WithEvents TbSentencesRandomTableAdapter As DataSetTableAdapters.tbSentencesRandomTableAdapter
End Class
