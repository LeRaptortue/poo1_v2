Option Explicit On
Option Strict On

Public Class Voiture
    Inherits Vehicule
    Protected _roues As String = "4x195/55R16"

    Public Property lesRoues As String
        Get
            Return _roues
        End Get
        Set(value As String)
            _roues = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & Chr(13) & Chr(10) & "> Roues : " & _roues
    End Function
End Class
