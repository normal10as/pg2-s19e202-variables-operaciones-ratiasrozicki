Imports System

Module Ecuacion
    Sub Main(args As String())
        Dim a As Integer = 1
        Dim b As Integer = 5
        Dim c As Integer = 2
        Console.WriteLine("Valos de las variables: a=1; b=5; c=2")
        Console.WriteLine("La Ecuacion es: x=(b^2-4ac)/2a")
        Console.WriteLine("RESULTADO: " & ((b ^ 2 - 4 * a * c) / 2 * a))
        Console.Read()
    End Sub
End Module
