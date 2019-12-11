Option Explicit On
Option Strict On

''' <summary>
''' CLasse TRAJET
''' 
''' Trajet en voiture de la ville de départ à la ville d'arrivée
''' </summary>
Public Class Trajet
    Private _arrivee As String
    Private _depart As String
    Private _distance As Integer

    Public Sub Saisir()
        System.Console.WriteLine(My.Resources.Depart)
        _depart = Console.ReadLine()
        System.Console.WriteLine(My.Resources.Arrivee)
        _arrivee = Console.ReadLine()
    End Sub

    Public Overrides Function ToString() As String
        Saisir()
        Return MyBase.ToString() & Chr(13) & Chr(10) & "Trajet >" & Chr(13) & Chr(10) & "Depart : " & _depart & " | Arrivee : " & _arrivee
    End Function
End Class
