Imports Poyecto_de_3er_semestre
Imports System

Class ArrayHelper
    Public Shared Function AgregarValor(ByVal array As Integer(), ByVal valor As Integer) As Integer()
        Dim newArray As Integer() = New Integer(array.Length + 1 - 1) {}
        array.Copy(array, newArray, array.Length)
        newArray(array.Length) = valor
        Return newArray
    End Function

    Public Shared Sub MostrarArray(ByVal array As Integer())
        Console.WriteLine("Contenido del array:")

        For Each valor In array
            Console.Write(valor & " ")
        Next

        Console.WriteLine()
    End Sub

    Public Shared Sub OrdenarArray(ByVal array As Integer(), ByVal algoritmo As String)
        Select Case algoritmo.ToLower()
            Case "bubblesort"
                BubbleSort(array)
                Console.WriteLine("Array ordenado con Bubble Sort")
            Case "selectionsort"
                SelectionSort(array)
                Console.WriteLine("Array ordenado con Selection Sort")
            Case "insertionsort"
                InsertionSort(array)
                Console.WriteLine("Array ordenado con Insertion Sort")
            Case Else
                Console.WriteLine("Algoritmo no válido")
        End Select
    End Sub

    Private Shared Sub BubbleSort(ByVal array As Integer())
    End Sub

    Private Shared Sub SelectionSort(ByVal array As Integer())
    End Sub

    Private Shared Sub InsertionSort(ByVal array As Integer())
    End Sub
End Class

Class ArrayHalper
    Public Shared Sub Array()
        Dim array As Integer() = New Integer(-1) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar array")
            Console.WriteLine("3. Mostrar array")
            Console.WriteLine("4. Regresar a Algoritmos")
            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    array = ArrayHelper.AgregarValor(array, valor)
                Case 2
                    Console.Write("Ingrese el nombre del algoritmo de ordenamiento (bubblesort, selectionsort, insertionsort, etc.): ")
                    Dim algoritmo As String = Console.ReadLine()
                    ArrayHelper.OrdenarArray(array, algoritmo)
                Case 3
                    ArrayHelper.MostrarArray(array)
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
End Class
