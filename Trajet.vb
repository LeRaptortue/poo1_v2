Option Explicit On
Option Strict On

''' <summary>
''' CLasse TRAJET
''' 
''' Trajet en voiture de la ville de départ à la ville d'arrivée
''' </summary>
Public Class Trajet
    Private _départ As String = "ici"
    Private _arrivée As String = "là"
    Private d As String
    Private _distance As Distance

    Public Sub New(départ As String, arrivée As String, distance As Integer)
        _départ = départ
        _arrivée = arrivée
        _distance = New Distance(distance)
    End Sub
    Public Sub Saisir()
        Console.WriteLine(My.Resources.Depart)
        _départ = Console.ReadLine()
        Console.WriteLine(My.Resources.Arrivee)
        _arrivée = Console.ReadLine()
        Console.WriteLine(My.Resources.Distance)
        d = Console.ReadLine()
        _distance.LaDistance = CInt(d)
    End Sub

    Public Overrides Function ToString() As String
        Return _départ & " -> " & _arrivée & " (" & _distance & ")"
    End Function
End Class