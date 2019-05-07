Imports System

Module SumatoriaMedia
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Console.WriteLine("Ingrese el primer numero")
        a = Console.ReadLine()
        Console.WriteLine("ngrese el Segundo numero")
        b = Console.ReadLine()
        Console.WriteLine("ngrese el tercer numero")
        c = Console.ReadLine()
        Console.WriteLine("ngrese el curto numero")
        d = Console.ReadLine()

        Console.WriteLine("La sumatoria es: " & a + b + c + d)
        Console.WriteLine("La media es: " & (a + b + c + d) / 2)
    End Sub
End Module
