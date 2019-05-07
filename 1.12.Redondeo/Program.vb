Imports System

Module Redondeo
    Dim numero As Decimal
    Sub Main(args As String())
        Console.Write("Ingrese un numero Real: ")
        numero = Console.ReadLine()
        Console.WriteLine("Por exceso: " & Math.Ceiling(numero))
        Console.WriteLine("Por defecto: " & Math.Floor(numero))
        Console.WriteLine("Por redondeo: " & Math.Round(numero))
        Console.WriteLine("POR: " & Math.Truncate(numero))
    End Sub
End Module
