Option Explicit On
Option Strict On
Imports System.Data.SQLite

Module Module1
    Sub sql(req As String)
        Dim connection As String = "Data Source=" & "C:\Users\apineau3\Desktop\SQLiteStudio\trajet" & ";Version=3"
        Dim SQLConn As New SQLiteConnection
        Dim SQLcmd As New SQLiteCommand
        Dim SQLdr As SQLiteDataReader
        SQLConn.ConnectionString = connection
        Logs.Instance().Trace("Ouverture de la base")
        SQLConn.Open()
        SQLcmd.Connection = SQLConn
        SQLcmd.CommandText = req
        SQLdr = SQLcmd.ExecuteReader()
        Logs.Instance().Trace("Données recuperées")
        While SQLdr.Read()
            Console.WriteLine(SQLdr("depart").ToString & " -> " & SQLdr("arrivee").ToString & " (" & SQLdr("distance").ToString & "km)")
        End While
        Logs.Instance().Trace("Connection en cours de fermeture")
        SQLdr.Close()
        SQLConn.Close()
        Console.WriteLine(Environment.NewLine)
        Logs.Instance().Trace("Connection à la base fermée")
    End Sub
    Sub Main()
        Aide()
        Dim req As String = "select * from trajet"
        sql(req)
        Logs.Instance().Trace("Démarrage du Module")
        Dim voyage = New Trajet(CType(Saisir("Ville A", "String"), String), CType(Saisir("ville B", "String"), String), CType(Saisir("Distance", "Integer"), Integer))
        Console.WriteLine(Environment.NewLine)
        Console.WriteLine(voyage)
        Console.ReadKey()
        Logs.Instance().Trace("Arrêt du Module")
    End Sub
End Module