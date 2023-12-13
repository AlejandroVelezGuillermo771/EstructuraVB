Imports Poyecto_de_3er_semestre
Imports System

Class Cou
    Public Shared Sub couting()
        Dim array As Integer() = New Integer(-1) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Counting Sort")
            Console.WriteLine("3. Mostrar array")
            Console.WriteLine("4. Regresar al Menu de Algoritmos")
            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    array = AgregarValor(array, valor)
                Case 2
                    CountingSort(array)
                    Console.WriteLine("Array ordenado con Counting Sort")
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

    Private Shared Sub CountingSort(ByVal array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        Dim max As Integer = array(0)
        Dim min As Integer = array(0)

        For i As Integer = 1 To array.Length - 1
            If array(i) > max Then max = array(i)
            If array(i) < min Then min = array(i)
        Next

        Dim range As Integer = max - min + 1
        Dim count As Integer() = New Integer(range - 1) {}
        Dim output As Integer() = New Integer(array.Length - 1) {}

        For i As Integer = 0 To range - 1
            count(i) = 0
        Next

        For i As Integer = 0 To array.Length - 1
            count(array(i) - min) += 1
        Next

        For i As Integer = 1 To range - 1
            count(i) += count(i - 1)
        Next

        For i As Integer = array.Length - 1 To 0
            output(count(array(i) - min) - 1) = array(i)
            count(array(i) - min) -= 1
        Next

        array.Copy(output, array, array.Length)
    End Sub
End Class
