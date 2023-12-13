Imports Poyecto_de_3er_semestre
Imports System

Class Heapsort
    Public Shared Sub Heap()
        Dim array As Integer() = New Integer(-1) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Heap Sort")
            Console.WriteLine("3. Mostrar array")
            Console.WriteLine("4. Regresar a Algoritmos")
            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    array = AgregarValor(array, valor)
                Case 2
                    HeapSort(array)
                    Console.WriteLine("Array ordenado con Heap Sort")
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

    Private Shared Sub HeapSort(ByVal array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        For i As Integer = array.Length / 2 - 1 To 0
            Heapify(array, array.Length, i)
        Next

        For i As Integer = array.Length - 1 To 0 + 1
            Swap(array(0), array(i))
            Heapify(array, i, 0)
        Next
    End Sub

    Private Shared Sub Heapify(ByVal array As Integer(), ByVal n As Integer, ByVal i As Integer)
        Dim max As Integer = i
        Dim izquierda As Integer = 2 * i + 1
        Dim derecha As Integer = 2 * i + 2

        If izquierda < n AndAlso array(izquierda) > array(max) Then
            max = izquierda
        End If

        If derecha < n AndAlso array(derecha) > array(max) Then
            max = derecha
        End If

        If max <> i Then
            Swap(array(i), array(max))
            Heapify(array, n, max)
        End If
    End Sub

    Private Shared Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub
End Class
