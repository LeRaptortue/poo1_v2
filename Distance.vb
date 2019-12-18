Option Explicit On
Option Strict On

Public Class Distance
    Private _d As Integer = 0
    Private unite As String = " km"
    Public Sub New(distance As Integer)
        _d = distance
        Decompte.Plus()
    End Sub
    Protected Overrides Sub Finalize()
        Decompte.Instance().Moins()
    End Sub
    Public Property LaDistance As Integer
        Get
            Return _d
        End Get
        Set(value As Integer)
            _d = value
        End Set
    End Property
    Public Shared Widening Operator CType(v As Distance) As String
        Return v.ToString
    End Operator

    Public Shared Operator &(c1 As String, d1 As Distance) As String
        Return c1 & d1.ToString
        Return d1.ToString & c1
    End Operator
    Public Overrides Function ToString() As String
        Return _d & unite
    End Function
End Class