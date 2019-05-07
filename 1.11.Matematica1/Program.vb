Imports System.Math

Module Matematica1
    Sub Main(args As String())
        Dim numero As Integer = 1
        Dim valorabsoluto
        While numero <> 0
            Console.Write("Ingrese un numero: ")
            numero = Console.ReadLine()
            If numero <> 0 Then
                valorabsoluto = Abs(numero)
                Console.WriteLine("Valor ABS: " & valorabsoluto)
                Console.WriteLine("Decima potencia del valor ABS es: " & valorabsoluto ^ 10)
                Console.WriteLine("Raiz Cuadrada del valor ABS es: " & valorabsoluto ^ (1 / 2))
                Console.WriteLine("Raiz Cuadrada del valor ABS es: " & Sqrt(valorabsoluto))
            End If
        End While
    End Sub
End Module
