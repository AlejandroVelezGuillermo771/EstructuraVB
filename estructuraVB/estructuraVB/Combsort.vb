Imports Poyecto_de_3er_semestre
Imports System

Class Combsort
    Public Shared Sub COMB()
        Dim array As Integer() = New Integer(-1) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Combsort")
            Console.WriteLine("3. Mostrar array")
            Console.WriteLine("4. Regresar al Menu de Algoritmos")
            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    array = AgregarValor(array, valor)
                Case 2
                    COMB(array)
                    Console.WriteLine("Array ordenado con Combsort")
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

    Private Shared Sub COMB(ByVal array As Integer())
        Dim gap As Integer = array.Length
        Dim swapped As Boolean = True

        While gap > 1 OrElse swapped
            If gap > 1 Then gap = CInt((gap / 1.3))
            Dim i As Integer = 0
            swapped = False

            While i + gap < array.Length

                If array(i) > array(i + gap) Then
                    Swap(array(i), array(i + gap))
                    swapped = True
                End If

                i += 1
            End While
        End While
    End Sub

    Private Shared Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub
End Class
