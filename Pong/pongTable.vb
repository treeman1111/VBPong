Public Class pongTable
    Private Sub pongTable_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.P
                If pongVars.gameRunning Then
                    pongVars.gameRunning = False
                    pongTimer.Enabled = False
                Else
                    pongVars.gameRunning = True
                    pongTimer.Enabled = True
                End If
            Case Keys.D
                ' Change difficulty level
                ' Start a new game of pong
            Case Keys.N
                resetPong()
            Case Keys.Q
                Application.Exit() ' Close the Pong window and terminate the process associated with it.
        End Select
    End Sub

    Private Sub pongTable_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        pongVars.dashedPen.DashStyle = Drawing2D.DashStyle.Dash
        e.Graphics.DrawLine(pongVars.dashedPen, New Point(Me.Width / 2, 0), New Point(Me.Width / 2, Me.Height))
    End Sub

    Private Sub pongTimer_Tick(sender As Object, e As EventArgs) Handles pongTimer.Tick
        Dim GFX As Graphics = Me.CreateGraphics
        ballLogic.increaseVelocity()
        ballLogic.moveBall()
        computerLogic.trackBall()

        pongVars.rightBounce(0) = New Rectangle(rightPaddle.Location.X + rightPaddle.Width - 1, rightPaddle.Top, 1, 30)
        pongVars.rightBounce(1) = New Rectangle(rightPaddle.Location.X + rightPaddle.Width - 1, rightPaddle.Top + (rightPaddle.Height / 3), _
                                                1, 30)
        pongVars.rightBounce(2) = New Rectangle(rightPaddle.Location.X + rightPaddle.Width - 1, rightPaddle.Top + ((2 * rightPaddle.Height) / 3), _
                                                1, 30)

        pongVars.leftBounce(0) = New Rectangle(leftPaddle.Location.X + leftPaddle.Width - 1, leftPaddle.Top, 5, 30)
        pongVars.leftBounce(1) = New Rectangle(leftPaddle.Location.X + leftPaddle.Width - 1, leftPaddle.Top + (leftPaddle.Height / 3), 5, 30)
        pongVars.leftBounce(2) = New Rectangle(leftPaddle.Location.X + leftPaddle.Width - 1, leftPaddle.Top + ((2 * leftPaddle.Height) / 3), 5, 30)

        If pongBall.Top <= 0 Or pongBall.Bottom() >= Me.Height - 40 Then
            ballLogic.horizontalBounce()
        End If

        If pongBall.Left <= leftPaddle.Right Then
            pongVars.computerScore += 1
        End If

        If pongBall.Right >= rightPaddle.Left Then
            pongVars.playerScore += 1
        End If

        ballLogic.verticalBounce()
    End Sub

    Private Sub pongTable_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Location.Y > 6 And e.Location.Y < Me.Height - leftPaddle.Height - 40 Then
            leftPaddle.Location = New Point(leftPaddle.Location.X, e.Location.Y)
        End If
    End Sub
End Class
