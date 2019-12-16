Option Explicit On
Option Strict On
Module Outils
    Function Saisir(nom As String, type As String) As Object
        Console.Write("Saisie " & nom & ": ")
        Dim val As String = Console.ReadLine()
        If type.Equals("String") Then
            Return val
        ElseIf type.Equals("Integer") And IsNumeric(val) Then
            Return CInt(val)
        Else
            Return Nothing
        End If
    End Function

    Sub Aide()
        Dim help As String
        Dim help1 As String
        Dim help2 As String
        Dim aide As String

        aide = "Ce Programme permet d'enregistrer un trajet effectué avec une voiture"
        help = "--help"
        help1 = "-help"
        help2 = "/?"

        For Each arg As String In My.Application.CommandLineArgs
            If arg.ToLower.StartsWith(help) Or arg.ToLower.StartsWith(help1) Or arg.ToLower.StartsWith(help2) Then
                Console.WriteLine(aide)
                End
            End If
        Next
    End Sub

    Function TestSaisir() As Boolean
        Dim val As Object

        val = Saisir("chaîne", "String")
        If TypeOf val IsNot String Then
            Return False
        End If
        val = Saisir("entier", "Integer")
        If TypeOf val IsNot Integer Then
            Return False
        End If
        val = Saisir("Un Truc", "tructruc")
        If val IsNot Nothing Then
            Return False
        End If
    End Function
End Module
