Public Class Form1
    Private WithEvents moveTimer As New Timer()
    Private movementStep As Integer = 80
    Private formWidth As Integer
    Private formHeight As Integer
    Private ballSpeedX As Integer = 6
    Private ballSpeedY As Integer = 6
    Private scorePlayer1 As Integer = 0
    Private scorePlayer2 As Integer = 0
    Private ticksPassed As Integer = 0
    Private scoringState As Boolean = False
    Private Const speedIncreaseInterval As Integer = 6900
    Private Const scoringDelay As Integer = 1000

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formWidth = Me.ClientSize.Width
        formHeight = Me.ClientSize.Height
        moveTimer.Interval = 10
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
        If Not scoringState Then
            Ball.Left += ballSpeedX
            Ball.Top += ballSpeedY
            ticksPassed += 1
            If ticksPassed >= speedIncreaseInterval / moveTimer.Interval Then
                ticksPassed = 0
                IncreaseBallSpeed()
            End If
        End If
        If Ball.Left <= 0 Then
            scorePlayer2 += 1
            p2score.Text = scorePlayer2.ToString()
            If scorePlayer2 >= 10 Then
                moveTimer.Stop()
                MessageBox.Show("Player 2 wins!")
                Me.Close()
            Else
                ResetBall()
                StartScoringDelay()
            End If
        ElseIf Ball.Right >= formWidth Then
            scorePlayer1 += 1
            p1score.Text = scorePlayer1.ToString()
            If scorePlayer1 >= 10 Then
                moveTimer.Stop()
                MessageBox.Show("Player 1 wins!")
                Me.Close()
            Else
                ResetBall()
                StartScoringDelay()
            End If
        End If
        If Ball.Top <= 0 OrElse Ball.Bottom >= formHeight Then
            ballSpeedY *= -1
        End If
        If Ball.Bounds.IntersectsWith(p1.Bounds) OrElse Ball.Bounds.IntersectsWith(p2.Bounds) Then
            ballSpeedX *= -1
        End If
    End Sub
    Private Sub ResetBall()
        Ball.Left = formWidth \ 2
        Ball.Top = formHeight \ 2
        ballSpeedX = Math.Sign(ballSpeedX) * 6
        ballSpeedY = Math.Sign(ballSpeedY) * 6
    End Sub
    Private Sub IncreaseBallSpeed()
        If ballSpeedX > 0 Then
            ballSpeedX += 1
        Else
            ballSpeedX -= 1
        End If

        If ballSpeedY > 0 Then
            ballSpeedY += 1
        Else
            ballSpeedY -= 1
        End If
    End Sub
    Private Sub StartScoringDelay()
        scoringState = True
        moveTimer.Stop()
        Dim scoringDelayTimer As New Timer()
        scoringDelayTimer.Interval = scoringDelay
        AddHandler scoringDelayTimer.Tick, Sub()
                                               scoringDelayTimer.Stop()
                                               moveTimer.Start()
                                               scoringState = False
                                           End Sub
        scoringDelayTimer.Start()
    End Sub
End Class
