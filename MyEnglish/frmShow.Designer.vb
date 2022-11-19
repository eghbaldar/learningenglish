<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShow
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
        Me.lblFarsi = New System.Windows.Forms.Label()
        Me.lblEn = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.picStar = New System.Windows.Forms.PictureBox()
        Me.BtnExit = New System.Windows.Forms.Label()
        CType(Me.picStar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFarsi
        '
        Me.lblFarsi.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblFarsi.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFarsi.Font = New System.Drawing.Font("B Nazanin", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblFarsi.Location = New System.Drawing.Point(0, 0)
        Me.lblFarsi.Name = "lblFarsi"
        Me.lblFarsi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFarsi.Size = New System.Drawing.Size(584, 267)
        Me.lblFarsi.TabIndex = 0
        Me.lblFarsi.Text = "شسیشسیش"
        Me.lblFarsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEn
        '
        Me.lblEn.BackColor = System.Drawing.Color.Thistle
        Me.lblEn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEn.Location = New System.Drawing.Point(0, 267)
        Me.lblEn.Name = "lblEn"
        Me.lblEn.Size = New System.Drawing.Size(584, 104)
        Me.lblEn.TabIndex = 1
        Me.lblEn.Text = "asdasd"
        Me.lblEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEn.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblID.Location = New System.Drawing.Point(60, 35)
        Me.lblID.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 2
        '
        'picStar
        '
        Me.picStar.BackColor = System.Drawing.Color.LemonChiffon
        Me.picStar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picStar.Image = Global.MyEnglish.My.Resources.Resources.starempty
        Me.picStar.InitialImage = Global.MyEnglish.My.Resources.Resources.starempty
        Me.picStar.Location = New System.Drawing.Point(260, 12)
        Me.picStar.Name = "picStar"
        Me.picStar.Size = New System.Drawing.Size(65, 67)
        Me.picStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStar.TabIndex = 3
        Me.picStar.TabStop = False
        Me.picStar.Tag = "0"
        '
        'BtnExit
        '
        Me.BtnExit.AutoSize = True
        Me.BtnExit.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnExit.Location = New System.Drawing.Point(476, 65)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(24, 13)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Exit"
        '
        'frmShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 371)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.picStar)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblEn)
        Me.Controls.Add(Me.lblFarsi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmShow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picStar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFarsi As Label
    Friend WithEvents lblEn As Label
    Friend WithEvents lblID As Label
    Friend WithEvents picStar As PictureBox
    Friend WithEvents BtnExit As Label
End Class
