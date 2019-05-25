Imports System.Math


Module Mayor
    Dim numero1, numero2, numero3, mayor1, mayor2 As Integer
    Sub Main(args As String())
        Console.Write("Ingrese el Primer numero: ")
        numero1 = Console.ReadLine()
        Console.Write("Ingrese el Segundo numero: ")
        numero2 = Console.ReadLine()
        Console.Write("Ingrese el Tercer numero: ")
        numero3 = Console.ReadLine()
        mayor1 = Max(numero1, numero2)
        mayor2 = Max(mayor1, numero3)
        Console.WriteLine("El mayor es: " & mayor2)
    End Sub
End Module
