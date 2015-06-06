<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pongTable
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
        Me.leftPaddle = New System.Windows.Forms.PictureBox()
        Me.rightPaddle = New System.Windows.Forms.PictureBox()
        Me.pongBall = New System.Windows.Forms.PictureBox()
        Me.pongTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.leftPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pongBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leftPaddle
        '
        Me.leftPaddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.leftPaddle.BackColor = System.Drawing.Color.White
        Me.leftPaddle.Location = New System.Drawing.Point(6, 239)
        Me.leftPaddle.MaximumSize = New System.Drawing.Size(14, 112)
        Me.leftPaddle.Name = "leftPaddle"
        Me.leftPaddle.Size = New System.Drawing.Size(14, 112)
        Me.leftPaddle.TabIndex = 0
        Me.leftPaddle.TabStop = False
        '
        'rightPaddle
        '
        Me.rightPaddle.BackColor = System.Drawing.Color.White
        Me.rightPaddle.Location = New System.Drawing.Point(1117, 239)
        Me.rightPaddle.MaximumSize = New System.Drawing.Size(14, 112)
        Me.rightPaddle.Name = "rightPaddle"
        Me.rightPaddle.Size = New System.Drawing.Size(14, 112)
        Me.rightPaddle.TabIndex = 1
        Me.rightPaddle.TabStop = False
        '
        'pongBall
        '
        Me.pongBall.BackColor = System.Drawing.Color.White
        Me.pongBall.Location = New System.Drawing.Point(24, 2)
        Me.pongBall.Name = "pongBall"
        Me.pongBall.Size = New System.Drawing.Size(21, 21)
        Me.pongBall.TabIndex = 2
        Me.pongBall.TabStop = False
        '
        'pongTimer
        '
        Me.pongTimer.Interval = 1
        '
        'pongTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1135, 591)
        Me.Controls.Add(Me.pongBall)
        Me.Controls.Add(Me.rightPaddle)
        Me.Controls.Add(Me.leftPaddle)
        Me.Name = "pongTable"
        Me.Text = "Pong!"
        CType(Me.leftPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pongBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pongTimer As System.Windows.Forms.Timer
    Friend WithEvents leftPaddle As System.Windows.Forms.PictureBox
    Friend WithEvents rightPaddle As System.Windows.Forms.PictureBox
    Friend WithEvents pongBall As System.Windows.Forms.PictureBox

End Class
