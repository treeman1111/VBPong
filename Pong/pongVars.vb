Module pongVars
    Friend Enum Difficulty ' An enumeration used to define the speed of the ball on different levels of difficulty.
        Noob = 5
        Easy = 7
        Normal = 9
        Hard = 11
        Danger = 13
    End Enum

    Friend gameRunning As Boolean = False ' A boolean value used to indicate if the game is currently running or paused.
    Friend XVelocity As Single ' The ball's x-velocity.
    Friend YVelocity As Single ' The ball's y-velocity.
    Friend computerScore As UShort = 0 ' The computer player's score.
    Friend playerScore As UShort = 0 ' The human player's score.

    Friend decorationHeight As UShort = SystemInformation.CaptionHeight ' The height of the window decoration.
End Module
