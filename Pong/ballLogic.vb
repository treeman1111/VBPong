Module ballLogic
    Private rand As New System.Random()

#Region "Move the ball"
    ''' <summary>
    ''' Moves the pongBall based on the ball's current X and Y coordinates and the pongVars X and Y velocities.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub moveBall()
        pongTable.pongBall.Location = New Point(pongTable.pongBall.Location.X + pongVars.XVelocity,
                                                pongTable.pongBall.Location.Y + pongVars.YVelocity)
    End Sub
#End Region

#Region "Horizontal ball bounce"
    ''' <summary>
    ''' Reverses the YVelocity in pongVars.
    ''' </summary>
    ''' <remarks>This sub is called if the ball hits the top or bottom edge of the form.</remarks>
    Public Sub horizontalBounce() ' Used to bounce the ball off of the bottom and top of the form.
        pongVars.YVelocity *= -1
    End Sub
#End Region

#Region "Bounce rectangle population of arrays"
    ''' <summary>
    ''' Populate the rightBounce and leftBounce rectangle arrays with eight different rectangles.
    ''' These eight rectangles divide each paddle into eight equal pieces and are used to change the angle of bounce
    ''' when the ball impacts on the paddle.
    ''' </summary>
    ''' <remarks>Here's how the 'bounce rectangles' would look if they were visible:
    ''' [leftPaddle] --> rectangle 0
    ''' [          ] --> rectangle 1
    ''' [          ] --> rectangle n</remarks>
    Public Sub generateBounceRects()
        Dim leftPaddle As PictureBox = pongTable.leftPaddle
        Dim rightPaddle As PictureBox = pongTable.rightPaddle
        For r As UShort = 0 To 7
            rightBounce(r) = New Rectangle(rightPaddle.Location.X, rightPaddle.Top + ((r * rightPaddle.Height) / 8),
                                           rightPaddle.Width, rightPaddle.Height)
        Next

        For l As UShort = 0 To 7
            leftBounce(l) = New Rectangle(leftPaddle.Location.X, leftPaddle.Top + ((l * leftPaddle.Height) / 8),
                                          leftPaddle.Width, leftPaddle.Height / 8)
        Next
    End Sub
#End Region

#Region "Vertical ball bounce"
    ''' <summary>
    ''' Changes the ball's X and Y velocities in pongVars.
    ''' </summary>
    ''' <remarks>Called when the ball intersects with one of the bounce rectangles for the left or right paddles.</remarks>
    Public Sub verticalBounce() ' Used to bounce the ball off of the different paddles.

    End Sub
#End Region
End Module
