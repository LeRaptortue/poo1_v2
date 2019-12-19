Public Class Decompte
    Private Shared _compte As Integer = 0
    Private Shared _instance As Decompte = Nothing

    Private Sub New()

    End Sub

    Public Shared Function Instance() As Decompte
        If (IsNothing(_instance)) Then
            _instance = New Decompte()
        End If
        Return _instance
    End Function
    Public Shared Sub Plus()
        _compte += 1
        Logs.Instance.Trace("+1 Comptage: " & _compte)
    End Sub
    Public Shared Sub Moins()
        _compte -= 1
        Logs.Instance.Trace("-1 Décomptage: " & _compte)
    End Sub
End Class
