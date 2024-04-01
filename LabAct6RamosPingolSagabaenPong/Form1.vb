Public Class Form1
    Private WithEvents moveTimer As New Timer()
    Private movementStep As Integer = 71 ' Adjust this value to control the speed of player movement
    Private formWidth As Integer
    Private formHeight As Integer
    Private ballSpeedX As Integer = 6
    Private ballSpeedY As Integer = 6

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formWidth = Me.ClientSize.Width
        formHeight = Me.ClientSize.Height

        ' Start the timer
        moveTimer.Interval = 10 ' Adjust this value for smoother movement
        moveTimer.Start()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W AndAlso p1.Top > 0 Then
            p1.Top = Math.Max(0, p1.Top - movementStep)
        ElseIf e.KeyCode = Keys.S AndAlso p1.Bottom < formHeight Then
            p1.Top = Math.Min(formHeight - p1.Height, p1.Top + movementStep)
        ElseIf e.KeyCode = Keys.Up AndAlso p2.Top > 0 Then
            p2.Top = Math.Max(0, p2.Top - movementStep)
        ElseIf e.KeyCode = Keys.Down AndAlso p2.Bottom < formHeight Then
            p2.Top = Math.Min(formHeight - p2.Height, p2.Top + movementStep)
        End If
    End Sub

    Private Sub moveTimer_Tick(sender As Object, e As EventArgs) Handles moveTimer.Tick
        ' Move the ball
        Ball.Left += ballSpeedX
        Ball.Top += ballSpeedY

        ' Check for collisions with form boundaries
        If Ball.Left <= 0 OrElse Ball.Right >= formWidth Then
            ballSpeedX *= -1 ' Reverse horizontal direction
        End If
        If Ball.Top <= 0 OrElse Ball.Bottom >= formHeight Then
            ballSpeedY *= -1 ' Reverse vertical direction
        End If

        ' Check for collisions with players
        If Ball.Bounds.IntersectsWith(p1.Bounds) OrElse Ball.Bounds.IntersectsWith(p2.Bounds) Then
            ballSpeedX *= -1 ' Reverse horizontal direction
        End If

        'If ball.Bounds.IntersectWith() Then

    End Sub
End Class
