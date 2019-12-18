Option Explicit On
Option Strict On

Module Module1

    Sub Main()
        Aide()
        Logs.Instance().Trace("Démarrage du Module")
        Dim voyage = New Trajet(CType(Saisir("Ville A", "String"), String), CType(Saisir("ville B", "String"), String), CType(Saisir("Distance", "Integer"), Integer))
        System.Console.WriteLine(Environment.NewLine)
        System.Console.WriteLine(voyage)
        System.Console.ReadKey()
        Logs.Instance().Trace("Arrêt du Module")
    End Sub
End Module