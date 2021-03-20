Module Module1

    Sub Main()
        Dim numeros(3) As Integer
        Dim suma As Integer = 0

        For i = 0 To numeros.Length - 1 Step 1
            Console.WriteLine("ingrese un valor: " & i + 1)
            numeros(i) = Console.ReadLine()
            suma += numeros(i)
        Next

        Array.Sort(numeros)

        Console.WriteLine("suma total: " & suma)
        Console.ReadLine()
        Console.WriteLine(numeros)


    End Sub

End Module

