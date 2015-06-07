Module pongGame
#Region "Start a new game of pong"
    ''' <summary>
    ''' Restarts the pong game: sets the score of the player and computer to zero, resets the paddle locations, and starts the game.
    ''' </summary>
    ''' <remarks>Called when Keys.N is pressed in pongTable.</remarks>
    Friend Sub resetPong()
        pongVars.playerScore = 0
        pongVars.computerScore = 0
        pongTable.leftPaddle.Location = New Point(pongTable.leftPaddle.Location.X, pongTable.Height / 2)
        pongTable.rightPaddle.Location = New Point(pongTable.rightPaddle.Location.X, pongTable.Height / 2)
        pongVars.gameRunning = True
        pongTable.pongTimer.Enabled = True
    End Sub
#End Region

#Region "Actions for if a player just scored. (insert Beavis and Butthead joke)"
    ''' <summary>
    ''' This sub provides the methods to deal with a computer or player score. This mainly involves repositioning the ball and
    ''' setting its X and Y velocity in a way that makes it so that the ball travels in the direction opposite of the person
    ''' who was just scored upon.
    ''' </summary>
    ''' <remarks>Called whenerver computerScore or playerScore increased by one from the if statements at the bottom of the timer1_tick
    ''' event in pongTable.vb.</remarks>
    Friend Sub setupNextRound()
        pongTable.pongTable_Load(Nothing, Nothing)
    End Sub
#End Region

#Region "Update Scores"
    ''' <summary>
    ''' Add one point to the scored point total of the player that scored.
    ''' </summary>
    ''' <remarks>This sub is called from pongTable's pongTimer_Tick event.</remarks>
    Friend Sub updateScores()
        pongTable.lblComputerScore.Text = pongVars.computerScore
        pongTable.lblPlayerScore.Text = pongVars.playerScore
    End Sub
#End Region

#Region "Actions for if the game has been won"
    ''' <summary>
    ''' Runs any actions required if one of the players wins the game (by scoring eleven points).
    ''' </summary>
    ''' <param name="winner">The name of the winner as a string. Can be either 'computer' or 'human.'</param>
    ''' <remarks>This sub is checked from within the setupNextRound Sub</remarks>
    Friend Sub finishGame(ByVal winner As String)
        Select Case winner
            Case "computer"

            Case "human"
        End Select
    End Sub
#End Region
End Module
