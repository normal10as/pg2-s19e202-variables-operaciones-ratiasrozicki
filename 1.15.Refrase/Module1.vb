Module Refrase

    Sub Main()
        Dim frase As String = " Aunque la cadena sea de oro, sirve para lo mismo."
        Dim palabra_actual, palabra_nueva, frasenueva As String
        Console.WriteLine(frase)
        Console.WriteLine("Ingrese palabra a reemplazar: ")
        palabra_actual = Console.ReadLine()
        Console.WriteLine("Ingrese palabra nueva: ")
        palabra_nueva = Console.ReadLine()
        Dim palabra_actual1 = " " + palabra_actual + " "
        Dim palabra_nueva1 = " " + palabra_nueva + " "
        frasenueva = (Replace(frase, palabra_actual1, palabra_nueva1, 1, -1, 1))
        palabra_actual1 = " " + palabra_actual + ","
        palabra_nueva1 = " " + palabra_nueva + ","
        frasenueva = (Replace(frasenueva, palabra_actual1, palabra_nueva1, 1, -1, 1))
        palabra_actual1 = " " + palabra_actual + "."
        palabra_nueva1 = " " + palabra_nueva + "."
        frasenueva = (Replace(frasenueva, palabra_actual1, palabra_nueva1, 1, 1, 1))
        Console.WriteLine(frasenueva)
        Console.ReadLine()
    End Sub

End Module
