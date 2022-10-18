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
        Me.SuspendLayout()
        '
        'lblFarsi
        '
        Me.lblFarsi.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblFarsi.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFarsi.Font = New System.Drawing.Font("W_kamposet kordi", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFarsi.Location = New System.Drawing.Point(0, 0)
        Me.lblFarsi.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblFarsi.Name = "lblFarsi"
        Me.lblFarsi.Size = New System.Drawing.Size(2133, 637)
        Me.lblFarsi.TabIndex = 0
        Me.lblFarsi.Text = "شسیشسیش"
        Me.lblFarsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEn
        '
        Me.lblEn.BackColor = System.Drawing.Color.Thistle
        Me.lblEn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEn.Location = New System.Drawing.Point(0, 637)
        Me.lblEn.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblEn.Name = "lblEn"
        Me.lblEn.Size = New System.Drawing.Size(2133, 436)
        Me.lblEn.TabIndex = 1
        Me.lblEn.Text = "asdasd"
        Me.lblEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEn.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblID.Location = New System.Drawing.Point(160, 83)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 32)
        Me.lblID.TabIndex = 2
        '
        'frmShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2133, 1073)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblEn)
        Me.Controls.Add(Me.lblFarsi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "frmShow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFarsi As Label
    Friend WithEvents lblEn As Label
    Friend WithEvents lblID As Label
End Class
