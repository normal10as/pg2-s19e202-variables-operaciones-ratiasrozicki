Imports System

Module VariablesConsola
    Sub Main(args As String())
        Dim apellido As String
        Dim nombre As String
        Dim fechaN As Date
        Console.WriteLine("Ingrese su Apellido: ")
        nombre = Console.ReadLine()
        Console.WriteLine("Ingrese Apellido: ")
        apellido = Console.ReadLine()
        Console.WriteLine("Ingrese su Fecha de nacimiento: ")
        fechaN = Console.ReadLine()
        Console.WriteLine(" Apellido: " & apellido & " Nombre: " & nombre & " Fecha de Nacimiento: " & fechaN)
        Console.Read()
    End Sub
End Module
