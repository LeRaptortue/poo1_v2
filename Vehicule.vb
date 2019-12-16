Option Explicit On
Option Strict On
Public Class Vehicule
    Private _chassis As String = "Carton"
    Private _carrosserie As String = "Jaune Poussin"
    Private _moteur As String = "Double V8 de la Mort"

    Private Property leMoteur As String
        Get
            Return _moteur
        End Get
        Set(value As String)
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Environment.NewLine & "> Chassis : " & _chassis & Environment.NewLine & "> Carroserie : " & _carrosserie & Environment.NewLine & "> Moteur : " & _moteur
    End Function
End Class
