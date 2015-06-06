Module pongGame
    Public Sub resetPong()
        pongVars.playerScore = 0
        pongVars.computerScore = 0
        pongTable.leftPaddle.Location = New Point(pongTable.leftPaddle.Location.X, pongTable.Height / 2)
        pongTable.rightPaddle.Location = New Point(pongTable.rightPaddle.Location.X, pongTable.Height / 2)
        pongVars.gameRunning = True
        pongTable.pongTimer.Enabled = True
    End Sub
End Module
