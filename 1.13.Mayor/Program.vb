Imports System

Module Mayor
    Dim numero1, numero2, numero3 As Integer
    Dim mayor
    Sub Main(args As String())
        mayor = numero1
        Console.Write("Ingrese el Primer numero: ")
        numero1 = Console.ReadLine()
        Console.Write("Ingrese el Segundo numero: ")
        numero2 = Console.ReadLine()
        Console.Write("Ingrese el Tercer numero: ")
        numero3 = Console.ReadLine()
        If numero1 >= numero2 And numero1 >= numero3 Then
            mayor = numero1
        End If
        If numero2 >= numero1 And numero2 >= numero3 Then
            mayor = numero2
        End If
        If numero3 >= numero2 And numero3 >= numero1 Then
            mayor = numero3
        End If
        Console.WriteLine("El mayor es: " & mayor)
    End Sub
End Module
