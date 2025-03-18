Public Class Animal
    'Dim movement As String

    'properties------------------------------------------------------------
    Private _movement As String
    Public Property movement() As String
        Get
            Return _movement
        End Get
        Set(ByVal value As String)
            _movement = value
        End Set
    End Property

    Private _skinType As String
    Public Property skinType() As String
        Get
            Return _skinType
        End Get
        Set(ByVal value As String)
            _skinType = value
        End Set
    End Property

    Private _speak As String
    Public Property speak() As String
        Get
            Return _speak
        End Get
        Set(ByVal value As String)
            _speak = value
        End Set
    End Property

    'fields----------------------------------------------------------------
    Sub New()
        Me.movement = "Animals can move... except sponges..."
        Me.skinType = "I'm not sure if sponges have fur..."
    End Sub

    Sub Move()
        Console.WriteLine(Me.movement)
    End Sub
    'methods---------------------------------------------------------------
End Class
