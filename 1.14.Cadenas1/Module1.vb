Module Cadenas1
    Dim palabra, a, o, invertir As String
    Sub Main()
        Console.Write("Ingrese una palabra que contenga una letra A y O: ")
        palabra = Console.ReadLine()
        a = InStr(1, palabra, "a")
        o = InStr(1, palabra, "o")
        invertir = StrReverse(palabra)
        Console.WriteLine("AA: " & a)
        Console.WriteLine("OO: " & o)
        Console.WriteLine("Invertida: " & invertir)
        Console.ReadLine()
    End Sub

End Module
