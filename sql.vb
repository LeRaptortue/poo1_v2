Option Explicit On
Option Strict On
Imports System.Data.SQLite
Imports System.IO
Public Class sql
    Public Shared Sub sql(req As String)
        Dim dbFile = "C:\Users\apineau3\Desktop\SQLiteStudio\trajet"
        Dim connection As String = "Data Source=" & dbFile & ";Version=3"
        If Not File.Exists(dbFile) Then
            Logs.Instance().Trace($"Fichier de données SQLite *{dbFile}* introuvable")
            Throw New FileNotFoundException($"Fichier de données SQLite {dbFile} introuvable")
        End If
        Dim SQLConn As New SQLiteConnection
        Dim SQLcmd As New SQLiteCommand
        Dim SQLdr As SQLiteDataReader
        SQLConn.ConnectionString = connection
        Logs.Instance().Trace("Ouverture de la base")
        SQLConn.Open()
        SQLcmd.Connection = SQLConn
        SQLcmd.CommandText = req
        Try
            SQLdr = SQLcmd.ExecuteReader()
        Catch e As Exception
            MsgBox("Erreur d'exécution SQLite")
            Logs.Instance().Trace("Erreur d'exécution SQLite")
            SQLConn.Close()
            Environment.Exit(99)
        End Try
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
End Class
