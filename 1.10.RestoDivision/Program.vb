Imports System

Module RestoDivision
    Sub Main(args As String())
        Dim numero As Integer
        Dim m, resto
        Console.Write("Ingrese un numero entero: ")
        numero = Console.ReadLine()
        'Console.WriteLine(" " & (Math.Truncate(numero / 2)))
        m = (Math.Truncate(numero / 2))
        resto = numero - m - m
        Console.WriteLine("El RESTO ES: " & resto)
    End Sub
End Module
