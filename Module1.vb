Option Explicit On
Option Strict On
Imports System.Data.SQLite

Module Module1
    Sub sql(req As String)
        Dim connection As String = "Data Source=" & "C:\Users\apineau3\Desktop\SQLiteStudio\trajet" & ";Version=3"
        Dim SQLConn As New SQLiteConnection
        Dim SQLcmd As SQLiteCommand
        Dim SQLdr As SQLiteDataReader
        SQLConn.ConnectionString = connection
        SQLConn.Open()
        SQLcmd.Connection = SQLConn
        SQLcmd.CommandText = req
        SQLdr = SQLcmd.ExecuteReader()
        While SQLdr.Read()
            Console.WriteLine(SQLdr("depart").ToString)
        End While
        SQLdr.Close()
        SQLConn.Close()
    End Sub
    Sub Main()
        Aide()
        Dim req As String = "select * from trajet"
        sql(req)
        Logs.Instance().Trace("Démarrage du Module")
        Dim voyage = New Trajet(CType(Saisir("Ville A", "String"), String), CType(Saisir("ville B", "String"), String), CType(Saisir("Distance", "Integer"), Integer))
        System.Console.WriteLine(Environment.NewLine)
        System.Console.WriteLine(voyage)
        System.Console.ReadKey()
        Logs.Instance().Trace("Arrêt du Module")
    End Sub
End Module