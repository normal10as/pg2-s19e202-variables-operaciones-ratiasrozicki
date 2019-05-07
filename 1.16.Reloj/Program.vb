Imports System.DateTime

Module Reloj
    Sub Main(args As String())
        Console.WriteLine("Día del año: " & Now.DayOfYear)
        Console.WriteLine("Mes: " & Now.Month)
        Console.WriteLine("Hora: " & Now.Hour)
        Console.WriteLine("Minutos: " & Now.Minute)
    End Sub
End Module
