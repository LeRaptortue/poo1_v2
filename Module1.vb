Option Explicit On
Option Strict On
Imports System.Data.SQLite
Imports System.IO

Module Module1

    Sub Main()
        Aide()
        Dim req As String = "select * from trajet"
        Try
            sql.sql(req)
        Catch e As Exception
            MsgBox(e.ToString)
            Environment.Exit(99)
        End Try
        Logs.Instance().Trace("Démarrage du Module")
        Dim maClio = New Voiture("TopMoumoute")
        maClio.test()
        Dim voyage = New Trajet(CType(Saisir("Ville A", "String"), String), CType(Saisir("ville B", "String"), String), CType(Saisir("Distance", "Integer"), Integer))
        Console.WriteLine(Environment.NewLine)
        Console.WriteLine(voyage)
        Console.ReadKey()
        Logs.Instance().Trace("Arrêt du Module")
    End Sub
End Module