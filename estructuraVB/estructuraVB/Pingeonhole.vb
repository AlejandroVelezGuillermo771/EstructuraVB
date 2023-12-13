Imports Poyecto_de_3er_semestre
Imports System

Class Pingeonhole
    Public Shared Sub Pinge()
        Dim array As Integer() = New Integer(-1) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Pigeonhole Sort")
            Console.WriteLine("3. Mostrar array")
            Console.WriteLine("4. Regresar a Algoritmos")
            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    array = AgregarValor(array, valor)
                Case 2
                    PigeonholeSort(array)
                    Console.WriteLine("Array ordenado con Pigeonhole Sort")
                Case 3
                    MostrarArray(array)
                Case 4
                    Algoritmos.Ordenamiento()
                Case Else
                    Console.WriteLine("Opción no válida")
            End Select
        Loop While True
    End Sub

    Private Shared Function ObtenerOpcion() As Integer
        Console.Write("Ingrese su opción: ")
        Return Integer.Parse(Console.ReadLine())
    End Function

    Private Shared Function AgregarValor(ByVal array As Integer(), ByVal valor As Integer) As Integer()
        Dim newArray As Integer() = New Integer(array.Length + 1 - 1) {}
        array.Copy(array, newArray, array.Length)
        newArray(array.Length) = valor
        Return newArray
    End Function

    Private Shared Sub MostrarArray(ByVal array As Integer())
        Console.WriteLine("Contenido del array:")

        For Each valor In array
            Console.Write(valor & " ")
        Next

        Console.WriteLine()
    End Sub

    Private Shared Sub PigeonholeSort(ByVal array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        Dim min As Integer = array(0)
        Dim max As Integer = array(0)

        For i As Integer = 1 To array.Length - 1
            If array(i) < min Then min = array(i)
            If array(i) > max Then max = array(i)
        Next

        Dim rango As Integer = max - min + 1
        Dim pigeonHoles As Integer() = New Integer(rango - 1) {}

        For i As Integer = 0 To rango - 1
            pigeonHoles(i) = 0
        Next

        For i As Integer = 0 To array.Length - 1
            pigeonHoles(array(i) - min) += 1
        Next

        Dim indice As Integer = 0

        For i As Integer = 0 To rango - 1

            While pigeonHoles(i) > 0
                array(indice) = i + min
                indice += 1
                pigeonHoles(i) -= 1
            End While
        Next
    End Sub
End Class
