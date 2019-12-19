Imports System.IO.File
Public Class Logs
    Private Shared _instance As Logs
    Private Shared _fichier As String = "P:\Algo\Visual Basic\Logs\logs" & DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") & ".txt"
    Public Shared Function Instance() As Logs
        If IsNothing(_instance) Then
            _instance = New Logs()
            WriteAllText(_fichier, "**" & My.Computer.Clock.LocalTime.ToString & " >** Première instance" & Environment.NewLine)
        End If
        Return _instance
    End Function
    Public Sub Trace(message As String)
        AppendAllText(_fichier, "**" & My.Computer.Clock.LocalTime.ToString & " >** " & message & Environment.NewLine)
    End Sub
End Class
