Imports Poyecto_de_3er_semestre
Imports System

Class Margesort
    Public Shared Sub Marge()
        Dim array As Integer() = New Integer(-1) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Merge Sort")
            Console.WriteLine("3. Mostrar array")
            Console.WriteLine("4. Regresar a Algoritmos")
            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    array = AgregarValor(array, valor)
                Case 2
                    MergeSort(array)
                    Console.WriteLine("Array ordenado con Merge Sort")
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

    Private Shared Sub MergeSort(ByVal array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        Dim aux As Integer() = New Integer(array.Length - 1) {}
        MergeSort(array, aux, 0, array.Length - 1)
    End Sub

    Private Shared Sub MergeSort(ByVal array As Integer(), ByVal aux As Integer(), ByVal izquierda As Integer, ByVal derecha As Integer)
        If izquierda < derecha Then
            Dim medio As Integer = (izquierda + derecha) / 2
            MergeSort(array, aux, izquierda, medio)
            MergeSort(array, aux, medio + 1, derecha)
            Merge(array, aux, izquierda, medio, derecha)
        End If
    End Sub

    Private Shared Sub Merge(ByVal array As Integer(), ByVal aux As Integer(), ByVal izquierda As Integer, ByVal medio As Integer, ByVal derecha As Integer)
        For i As Integer = izquierda To derecha
            aux(i) = array(i)
        Next

        Dim indiceIzquierda As Integer = izquierda
        Dim indiceDerecha As Integer = medio + 1
        Dim indiceActual As Integer = izquierda

        While indiceIzquierda <= medio AndAlso indiceDerecha <= derecha

            If aux(indiceIzquierda) <= aux(indiceDerecha) Then
                array(indiceActual) = aux(indiceIzquierda)
                indiceIzquierda += 1
            Else
                array(indiceActual) = aux(indiceDerecha)
                indiceDerecha += 1
            End If

            indiceActual += 1
        End While

        While indiceIzquierda <= medio
            array(indiceActual) = aux(indiceIzquierda)
            indiceIzquierda += 1
            indiceActual += 1
        End While
    End Sub
End Class
