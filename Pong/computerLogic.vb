Module computerLogic
    Public Sub trackBall()
        pongTable.rightPaddle.Location = New Point(pongTable.rightPaddle.Location.X, pongTable.pongBall.Location.Y)
    End Sub
End Module
