Module ballLogic
    Private rand As New System.Random()

    Public Sub moveBall()
        pongTable.pongBall.Location = New Point(pongTable.pongBall.Location.X + pongVars.XVelocity,
                                                pongTable.pongBall.Location.Y + pongVars.YVelocity)
    End Sub

    Public Sub increaseVelocity() ' Increases the ball's speed very slowly throughout the game.
        pongVars.ballSpeed += 0.00001
    End Sub

    Public Sub horizontalBounce() ' Used to bounce the ball off of the bottom and top of the form.
        pongVars.YVelocity *= -1
    End Sub

    Public Sub verticalBounce() ' Used to bounce the ball off of the different paddles.
        If pongTable.pongBall.Bounds.IntersectsWith(pongVars.rightBounce(0)) Then
            XVelocity *= -1
            YVelocity = rand.Next(-7, -3)
        End If

        If pongTable.pongBall.Bounds.IntersectsWith(pongVars.rightBounce(1)) Then
            XVelocity *= -1
            YVelocity = rand.Next(0.001, 1.2)
        End If

        If pongTable.pongBall.Bounds.IntersectsWith(pongVars.rightBounce(2)) Then
            XVelocity *= -1
            YVelocity = rand.Next(4, 8)
        End If

        If pongTable.pongBall.Bounds.IntersectsWith(pongVars.leftBounce(0)) Then
            XVelocity *= -1
            YVelocity = rand.Next(-7, -3)
        End If

        If pongTable.pongBall.Bounds.IntersectsWith(pongVars.leftBounce(1)) Then
            XVelocity *= -1
            YVelocity = rand.Next(0.001, 1.2)
        End If

        If pongTable.pongBall.Bounds.IntersectsWith(pongVars.leftBounce(2)) Then
            XVelocity *= -1
            YVelocity = rand.Next(4, 8)
        End If

        If pongTable.pongBall.Bounds.IntersectsWith(pongTable.leftPaddle.Bounds) Then
            XVelocity *= -1
            YVelocity = rand.Next(0.0001, 1.2)
        End If
    End Sub
End Module
