Imports System

Module ConcatenacionImplicitaExplicita
    Sub Main(args As String())
        Dim nombredeepremsa As String
        Dim alturadecalle As Integer
        Dim fechainicioactividad As Date
        Dim nombredecalle As String
        Dim a, b, c, d
        Console.WriteLine("Ingrese el Nombre de la Empresa")
        nombredeepremsa = Console.ReadLine()
        Console.WriteLine("Ingrese la altura de la Calle")
        alturadecalle = Console.ReadLine()
        Console.WriteLine("Ingrese fecha inicio de actividad")
        fechainicioactividad = Console.ReadLine()
        Console.WriteLine("Ingrese el nombre de la calle")
        nombredecalle = Console.ReadLine()
        Console.WriteLine(nombredeepremsa & " " & alturadecalle & " " & fechainicioactividad & " " & nombredecalle)
        a = Convert.ToString(nombredeepremsa)
        b = Convert.ToString(alturadecalle)
        c = Convert.ToString(fechainicioactividad)
        d = Convert.ToString(nombredecalle)
        Console.WriteLine(a + " " + b + " " + c + " " + d)
        Console.Read()
    End Sub
End Module
