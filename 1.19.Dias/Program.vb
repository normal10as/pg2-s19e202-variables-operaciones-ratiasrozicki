Imports System

Module Dias
    Enum Dias
        Domingo = 1
        Lunes = 2
        Martes = 3
        Miercoles = 4
        Jueves = 5
        Viernes = 6
        Sabado = 7
    End Enum
    Sub Main(args As String())
        Console.WriteLine(Dias.Domingo & ") " & Dias.Domingo.ToString())
        Console.WriteLine(Dias.Lunes & ") " & Dias.Lunes.ToString())
        Console.WriteLine(Dias.Martes & ") " & Dias.Martes.ToString())
        Console.WriteLine(Dias.Miercoles & ") " & Dias.Miercoles.ToString())
        Console.WriteLine(Dias.Jueves & ") " & Dias.Jueves.ToString())
        Console.WriteLine(Dias.Viernes & ") " & Dias.Viernes.ToString())
        Console.WriteLine(Dias.Sabado & ") " & Dias.Sabado.ToString())
    End Sub
End Module
