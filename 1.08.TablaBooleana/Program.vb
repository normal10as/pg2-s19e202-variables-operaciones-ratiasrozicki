Imports System

Module Program
    Sub Main(args As String())
        Dim verdadero As Boolean = True
        Dim falso As Boolean = False
        Console.WriteLine(vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "OPERADORES LOGICOS" & vbCrLf)

        Console.WriteLine("<<<<<<<---------Tabla AND--------->>>>>>")
        Console.WriteLine("verdadero y verdadero: " & (verdadero And verdadero))
        Console.WriteLine("verdadero y falso: " & (verdadero And falso))
        Console.WriteLine("falso y falso: " & (falso And falso))
        Console.WriteLine("falso y verdadero: " & (falso And verdadero) & vbCrLf)

        Console.WriteLine("<<<<<<<---------Tabla NOT--------->>>>>>")
        Console.WriteLine("verdadero: " & (Not falso))
        Console.WriteLine("falso: " & (Not verdadero) & vbCrLf)

        Console.WriteLine("<<<<<<<---------Tabla OR--------->>>>>>")
        Console.WriteLine("verdadero o verdadero: " & (verdadero Or verdadero))
        Console.WriteLine("verdadero o falso: " & (verdadero Or falso))
        Console.WriteLine("falso o verdadero: " & (falso Or verdadero))
        Console.WriteLine("falso o falso:" & (falso Or falso) & vbCrLf)

        Console.WriteLine("<<<<<<<---------Tabla XOR--------->>>>>>")
        Console.WriteLine("versadero xor verdadero: " & (verdadero Xor verdadero))
        Console.WriteLine("verdadero xor falso: " & (verdadero Xor falso))
        Console.WriteLine("falso xor verdadero: " & (falso Xor verdadero))
        Console.WriteLine("falso xor falso: " & (falso Xor falso))
    End Sub
End Module
