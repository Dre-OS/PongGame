Public Class Player
    Private Nname As String
    Private Sscore As Integer
    Private Pposition As Point
    Private MmovementStep As Integer

    Public Property Name As String
        Get
            Return Nname
        End Get
        Set(value As String)
            Nname = value
        End Set
    End Property

    Public Property Score As Integer
        Get
            Return Sscore
        End Get
        Set(value As Integer)
            Sscore = value
        End Set
    End Property

    Public Property Position As Point
        Get
            Return Pposition
        End Get
        Set(value As Point)
            Pposition = value
        End Set
    End Property

    Public Property MovementStep As Integer
        Get
            Return MmovementStep
        End Get
        Set(value As Integer)
            MmovementStep = value
        End Set
    End Property

    Public Sub New(ByVal name As String, ByVal position As Point, ByVal movementStep As Integer)
        Nname = name
        Pposition = position
        MmovementStep = movementStep
    End Sub

    Public Sub MoveUp()
        Pposition.Y = Math.Max(0, Pposition.Y - MmovementStep)
    End Sub

    Public Sub MoveDown(ByVal formHeight As Integer, ByVal playerHeight As Integer)
        Pposition.Y = Math.Min(formHeight - playerHeight, Pposition.Y + MmovementStep)
    End Sub
End Class
