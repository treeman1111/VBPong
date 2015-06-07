Module ballLogic
#Region "Move the ball"
    ''' <summary>
    ''' Moves the pongBall based on the ball's current X and Y coordinates and the pongVars X and Y velocities.
    ''' </summary>
    ''' <remarks></remarks>
    Friend Sub moveBall()
        pongTable.pongBall.Location = New Point(pongTable.pongBall.Location.X + pongVars.XVelocity,
                                                pongTable.pongBall.Location.Y + pongVars.YVelocity)
    End Sub
#End Region

#Region "Horizontal ball bounce"
    ''' <summary>
    ''' Reverses the YVelocity in pongVars.
    ''' </summary>
    ''' <remarks>This sub is called if the ball hits the top or bottom edge of the form.</remarks>
    Friend Sub horizontalBounce() ' Used to bounce the ball off of the bottom and top of the form.
        pongVars.YVelocity *= -1
    End Sub
#End Region

#Region "Vertical ball bounce"
    ''' <summary>
    ''' Changes the ball's X and Y velocities in pongVars.
    ''' </summary>
    ''' <remarks>Called when the ball intersects with one of the paddles.</remarks>
    Friend Sub verticalBounce(ByVal paddle As String)
        Dim midPointOfIntersect As Short = pongTable.pongBall.Location.Y - (pongTable.pongBall.Height / 2)
        Dim paddleBisector As Short
        Dim ballDistToBisect As Short

        Select Case paddle
            Case "left"
                paddleBisector = pongTable.leftPaddle.Top + (pongTable.leftPaddle.Height / 2)
                ballDistToBisect = Math.Abs(midPointOfIntersect - paddleBisector)

                If midPointOfIntersect < paddleBisector Then ' The ball is above the halfway bisector of the paddle.
                    YVelocity = -ballDistToBisect / 7
                    XVelocity *= -1
                ElseIf midPointOfIntersect = paddleBisector Then
                    YVelocity = 0
                    XVelocity *= -1
                Else
                    YVelocity = ballDistToBisect / 7
                    XVelocity *= -1
                End If
            Case "right"
                paddleBisector = pongTable.rightPaddle.Top + (pongTable.rightPaddle.Height / 2)
                ballDistToBisect = Math.Abs(midPointOfIntersect - paddleBisector)

                If midPointOfIntersect < paddleBisector Then ' The ball is above the halfway bisector of the paddle.
                    YVelocity = -ballDistToBisect / 7
                    XVelocity *= -1
                ElseIf midPointOfIntersect = paddleBisector Then
                    YVelocity = 0
                    XVelocity *= -1
                Else
                    YVelocity = ballDistToBisect / 7
                    XVelocity *= -1
                End If
        End Select
    End Sub
#End Region
End Module
