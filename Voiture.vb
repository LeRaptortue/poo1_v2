Option Explicit On
Option Strict On

Public Class Voiture
    Inherits Vehicule
    Protected _roues As String

    Public Sub New(roue As String)
        _roues = roue
        Decompte.Plus()
    End Sub

    Protected Overrides Sub Finalize()
        Decompte.Instance().Moins()
        MyBase.Finalize()
    End Sub
    Public Property lesRoues As String
        Get
            Return _roues
        End Get
        Set(value As String)
            _roues = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & Environment.NewLine & "> Roues : " & _roues
    End Function
End Class
