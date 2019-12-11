Option Explicit On
Option Strict On

Module Module1
    Dim maClio As New Voiture()
    Dim voyage As New Trajet()
    Sub Main()
        System.Console.WriteLine(maClio)
        System.Console.WriteLine(Chr(13) & Chr(10))
        System.Console.WriteLine(voyage)
        System.Console.ReadKey()
    End Sub
End Module