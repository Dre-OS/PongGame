Public Class Form2
    Private Sub BtStart_Click(sender As Object, e As EventArgs) Handles BtStart.Click
        Me.Hide()
        Dim form1 As New Form1()
        AddHandler form1.FormClosed, AddressOf Form1Closed
        form1.Show()
    End Sub

    Private Sub Form1Closed(sender As Object, e As FormClosedEventArgs)
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("                 Thank you for playing!

  Game Creators: Ramos
                             Sagabaen
                             Pingol")
        Me.Close()
    End Sub
End Class
