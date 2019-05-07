Imports System

Module EquivalenciaDias
    Sub Main(args As String())
        Dim diasporsemana As Integer = 7
        Dim horaspordia As Integer = 24
        Dim minutosporhora As Integer = 60
        Dim dia
        Console.Write("Ingrese un dia: ")
        dia = Console.ReadLine()
        Console.WriteLine("Numeros de semanas: " & dia / diasporsemana)
        Console.WriteLine("Numeros de horas: " & dia * horaspordia)
        Console.WriteLine("Numero de minutos: " & (dia * horaspordia) * minutosporhora)
        Console.WriteLine(dia)

    End Sub
End Module
