Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim movementStep As Integer = 50
        Dim Score As Integer = 0
        Dim formWidth As Integer = Me.ClientSize.Width
        Dim formHeight As Integer = Me.ClientSize.Height

        If e.KeyCode = Keys.W AndAlso p1.Top > 0 Then
            p1.Top = Math.Max(0, p1.Top - movementStep)
        End If

        If e.KeyCode = Keys.S AndAlso p1.Bottom < formHeight Then
            p1.Top = Math.Min(formHeight - p1.Height, p1.Top + movementStep)
        End If

        If e.KeyCode = Keys.Up AndAlso p2.Top > 0 Then
            p2.Top = Math.Max(0, p2.Top - movementStep)
        End If

        If e.KeyCode = Keys.Down AndAlso p2.Bottom < formHeight Then
            p2.Top = Math.Min(formHeight - p2.Height, p2.Top + movementStep)
        End If

        'If ball.Bounds.IntersectWith() Then

    End Sub
End Class
