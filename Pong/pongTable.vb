Public Class pongTable

#Region "Keyboard Inputs"
    ''' <summary>
    ''' Checks for keyboard input on the pongTable. 
    ''' </summary>
    ''' <param name="sender">An Object.</param>
    ''' <param name="e">A KeyEventArg.</param>
    ''' <remarks>The following keyboard shortcuts are currently supported: p [pauses and unpauses];
    ''' d [changes the difficulty level]; n [starts a new game]; and q [exits the application].</remarks>
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
                resetPong() ' Start a new game of pong
            Case Keys.Q
                Me.Close() ' Close the Pong window and terminate the process associated with it.
        End Select
    End Sub
#End Region

#Region "Paint event"
    ''' <summary>
    ''' Used to draw a dashed line down the middle of the form when it is first painted and, perhaps inappropriately, to correctly
    ''' position the labels that are used to keep track of score: lblComputerScore and lblPlayerScore and to position the ball in it's
    ''' starting location.
    ''' </summary>
    ''' <param name="sender">An Object.</param>
    ''' <param name="e">A PaintEventArg.</param>
    ''' <remarks></remarks>
    Private Sub pongTable_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        pongVars.dashedPen.DashStyle = Drawing2D.DashStyle.Dash ' Set the dash style of the pen created in pongVars to Drawing2D.DashStyle.Dash.
        e.Graphics.DrawLine(pongVars.dashedPen, New Point(Me.Width / 2, 0), New Point(Me.Width / 2, Me.Height)) ' Draw the bisecting line.

        ' Position the two score labels
        lblComputerScore.Location = New Point((Me.Width / 2) + 20, 6)
        lblPlayerScore.Location = New Point(((Me.Width / 2) - lblPlayerScore.Width - 20), 6)

        ' Center the ball in the middle of the form.
        pongBall.Location = New Point((Me.Width / 2) - (pongBall.Width / 2), (Me.Height / 2) - (pongBall.Height / 2))
    End Sub
#End Region

#Region "Timer tick"
    ''' <summary>
    ''' The main part of the application, where the pongBall and rightPaddle are moved, score is recorded, and bounce rectangles are created
    ''' for both the left and right paddles.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub pongTimer_Tick(sender As Object, e As EventArgs) Handles pongTimer.Tick
        ballLogic.moveBall()
        ballLogic.generateBounceRects()
        computerLogic.trackBall()
        ballLogic.verticalBounce()

        If pongBall.Top <= 0 Or pongBall.Bottom() >= Me.Height - 40 Then
            ballLogic.horizontalBounce()
        End If

        If pongBall.Left <= leftPaddle.Right Then
            pongVars.computerScore += 1
        End If

        If pongBall.Right >= rightPaddle.Left Then
            pongVars.playerScore += 1
        End If
    End Sub
#End Region

#Region "Mouse movement of leftPaddle"
    ''' <summary>
    ''' Used to move the paddle on the left side of the form. If the mouse's position is greater than the y-position of 6
    ''' and less than the y-position of me.height - leftpaddle.height - 40, then move the leftPaddle to the mouse's current
    ''' y-pos.
    ''' </summary>
    ''' <param name="sender">An Object</param>
    ''' <param name="e">A MouseEventArg</param>
    ''' <remarks></remarks>
    Private Sub pongTable_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Location.Y > 6 And e.Location.Y < Me.Height - leftPaddle.Height - 40 And pongVars.gameRunning Then
            leftPaddle.Location = New Point(leftPaddle.Location.X, e.Location.Y)
        End If
    End Sub
#End Region
End Class
