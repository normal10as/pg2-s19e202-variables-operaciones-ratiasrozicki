Imports System

Module Aritmetica
    Sub Main(args As String())
        Dim entero1 As Integer = 8
        Dim entero2 As Integer = 10
        Dim flotante1 As Double = 1.5
        Dim flotante2 As Double = 2.5
        Console.WriteLine("suma enteros: " & entero1 + entero2)
        Console.WriteLine("suma entero-flotante: " & entero1 + flotante1)
        Console.WriteLine("suma flotantes: " & flotante1 + flotante2)
        Console.WriteLine("resta enteros: " & entero1 - entero2)
        Console.WriteLine("resta entero-flotante: " & entero1 - flotante1)
        Console.WriteLine("resta flotantes: " & flotante1 / flotante2)
        Console.WriteLine("division enteros: " & entero1 / entero2)
        Console.WriteLine("division entero-flotante: " & entero1 - flotante1)
        Console.WriteLine("division flotantes: " & flotante1 / flotante2)
        Console.WriteLine("multiplicacion enteros: " & entero1 * entero2)
        Console.WriteLine("multiplicacion entero-flotante: " & entero1 * flotante1)
        Console.WriteLine("multiplicacion flotantes: " & flotante1 * flotante2)
        Console.Read()
    End Sub
End Module
