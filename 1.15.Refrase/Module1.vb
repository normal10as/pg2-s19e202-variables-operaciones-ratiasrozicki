Module Refrase

    Sub Main()
        Dim palabras, cortar_frase(), cortar_palabra(), resultado As String
        Dim frase As String = "Aunque la cadena sea de oro, sirve para lo mismo."

        Console.Write("Ingrese dos palabras: ")
        palabras = Console.ReadLine()
        cortar_frase = frase.Split(" ")
        cortar_palabra = palabras.Split(" ")
        Console.WriteLine(cortar_palabra(0))
        resultado = Replace(frase, "la", " ,." & cortar_palabra(0) & " ,.")
        Console.WriteLine(resultado)
        Console.ReadLine()
    End Sub

End Module
