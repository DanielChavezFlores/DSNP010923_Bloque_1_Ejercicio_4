Module Module1

    Sub Main(Args As String())


        Dim aux1, suma, n, i As Integer
        Dim bandera As Boolean
        bandera = False

        While (bandera = False)


            Console.Clear()
            suma = 0
            Console.WriteLine("Ingrese el valor de N")
            n = Console.ReadLine()

            If (n <= 0) Then
                Console.WriteLine("Por favor ingrese un numero mayor que 0")
                bandera = False
            Else


                For i = 1 To n
                    Console.WriteLine(i & "+" & suma & "=" & suma + i)
                    suma = suma + i
                Next

                Console.WriteLine("La suma es:" & suma)
                Console.WriteLine("Si desea ingresar otro numero presione 1 sino cualquier tecla")
                aux1 = Console.ReadLine()
                If (aux1 = 1) Then
                    bandera = False
                Else
                    bandera = True
                End If
            End If
        End While
    End Sub

End Module
