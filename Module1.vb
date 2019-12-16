Option Explicit On
Option Strict On

Module Module1

    Sub Main()
        Aide()
        Dim maClio As New Voiture("Roue 90cm")
        Dim voyage = New Trajet(CType(Saisir("Ville A", "String"), String), CType(Saisir("ville B", "String"), String), CType(Saisir("Distance", "Integer"), Integer))
        System.Console.WriteLine(maClio)
        System.Console.WriteLine(Environment.NewLine)
        System.Console.WriteLine(voyage)
        System.Console.ReadKey()
    End Sub
End Module