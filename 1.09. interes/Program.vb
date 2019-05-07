Imports System

Module Interes
    Sub Main(args As String())
        Dim m, r As Decimal
        Dim t As UShort
        Console.Write("Ingrese monto Invertido: ")
        m = Console.ReadLine()
        Console.Write("Interes Anual: ")
        r = Console.ReadLine()
        Console.Write("Ingrese dias de prestamo: ")
        t = Console.ReadLine()
        Console.WriteLine("((I=m*r*t) / (360*100))")
        Console.WriteLine("                           EL INTERES ES $: " & (m * r * t) / (360 * 100))
    End Sub
End Module