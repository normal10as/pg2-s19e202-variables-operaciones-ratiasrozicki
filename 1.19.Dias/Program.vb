Imports System

Module Dias
    Enum Diasdesemana
        Domingo = 1
        Lunes = 2
        Martes = 3
        Miercoles = 4
        Jueves = 5
        Viernes = 6
        Sabado = 7
    End Enum
    Sub Main(args As String())
        Dim dias As Diasdesemana
        Console.WriteLine("Ingrese un dia de la semana de 1 a 7: ")
        dias = Console.ReadLine()
        Console.WriteLine("el dia seleccionado es : " & dias.ToString)
    End Sub
End Module
