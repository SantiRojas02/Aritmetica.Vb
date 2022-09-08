Module Module1

    Sub Main(args As String())

        Dim a, division, elevacion, raiz, valor_absoluto As Integer


        Console.Write("Ingrese un numero: ")

        a = Console.ReadLine()

        division = a / 2

        elevacion = a * 10

        raiz = a * 1 / 2

        valor_absoluto = -a

        Console.WriteLine("numero dividio en 2: " & division)
        Console.WriteLine("Numero a la decima: " & elevacion)
        Console.WriteLine("Raiz Cuadrada: " & raiz)
        Console.WriteLine("Valor Absoluto: " & valor_absoluto)



        Console.ReadKey()




    End Sub
   

End Module
