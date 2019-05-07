Imports System

Module VariablesTipos
    Sub Main(args As String())
        Dim nombre As String = "Matias"
        Dim dni As Integer = 33999666
        Dim lugarNacimiento As String = "Obera Misiones Argentina"
        Dim fechaNacimiento As Date = "15/08/2000"
        Dim alturapersona As Byte = 1.78
        Dim argentino As Boolean = True
        Dim temperaturaambiente As Decimal = 17
        Dim Nombrecalle As String = "Pedro Mendez"
        Dim alturacalle As Integer = 2000
        Dim distanciaciudades As UShort = 1.5
        Dim profundidadmar As UShort = 2.5
        Dim cantidadabitantes As Integer = 40000000.0
        Dim pesoproducto As Decimal = 20.5
        Dim montoarticulo As Decimal = 25.9
        Console.WriteLine("Nombre: " & nombre & vbCrLf & "DNI: " & dni & vbCrLf &
                          "Lugar de nacimiento: " & lugarNacimiento & vbCrLf &
                          "Fecha de nacimiento: " & fechaNacimiento & vbCrLf &
                          "Altura corporal: " & alturapersona & vbCrLf &
                          "Argenino: " & argentino & vbCrLf &
                          "Temperatura ambiente: " & temperaturaambiente & vbCrLf &
                          "Nombre de calle: " & Nombrecalle & vbCrLf &
                          "Altura de calle: " & alturacalle & vbCrLf &
                          "Distancia entre ciudades: " & distanciaciudades & vbCrLf &
                          "Profundidad del mar: " & profundidadmar & vbCrLf &
                          "Cantida de habitantes: " & cantidadabitantes & vbCrLf &
                          "Peso de un producto: " & pesoproducto & vbCrLf &
                          "Monto de articulo: " & montoarticulo)
        Console.Read()
    End Sub
End Module
