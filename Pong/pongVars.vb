Module pongVars
    Public Enum Difficulty ' An enumeration used to define the speed of the ball on different levels of difficulty.
        Noob = 5
        Easy = 7
        Normal = 9
        Hard = 11
        Danger = 13
    End Enum

    Public gameRunning As Boolean = False ' A boolean value used to indicate if the game is currently running or paused.
    Public ballSpeed As UShort = 1 ' The speed of the ball (increases slowly over time).
    Public XVelocity As Single = 5 ' The ball's x-velocity.
    Public YVelocity As Single = 5 ' The ball's y-velocity.
    Public computerScore As UShort = 0 ' The computer player's score.
    Public playerScore As UShort = 0 ' The human player's score.

    Public dashedPen As New Pen(Brushes.White, 2) ' The pen used to draw the line through the middle of the form.

    Public rightBounce(2) As Rectangle ' The rectangles associated with the right paddle used to determine angle of ball bounce.
    Public leftBounce(2) As Rectangle ' Above, except for the left paddle.x
End Module
