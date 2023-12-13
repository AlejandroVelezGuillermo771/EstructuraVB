Imports Poyecto_de_3er_semestre
Imports System

Class Cocktailsort
    Public Shared Sub COCK()
        Dim [exit] As Boolean = False
        Dim array As Integer() = Nothing

        Do
            Console.WriteLine("Menú:")
            Console.WriteLine("1. Cocktail Sort")
            Console.WriteLine("2. Otra opción")
            Console.WriteLine("3. Regresar al menu de Algoritmos")
            Console.Write("Selecciona una opción: ")
            Dim [option] As String = Console.ReadLine()

            Select Case [option]
                Case "1"
                    array = GetIntArrayFromUser()
                    Console.WriteLine(vbLf & "Original array:")
                    PrintArray(array)
                    CocktailSort(array)
                    Console.WriteLine(vbLf & "Cocktail Sorted array:")
                    PrintArray(array)
                Case "2"
                Case "3"
                    Algoritmos.Ordenamiento()
                Case Else
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.")
            End Select
        Loop While Not [exit]
    End Sub

    Private Shared Sub CocktailSort(ByVal array As Integer())
        Dim swapped As Boolean

        Do
            swapped = False

            For i As Integer = 0 To array.Length - 2

                If array(i) > array(i + 1) Then
                    Swap(array(i), array(i + 1))
                    swapped = True
                End If
            Next

            If Not swapped Then Exit Do
            swapped = False

            For i As Integer = array.Length - 2 To 0

                If array(i) > array(i + 1) Then
                    Swap(array(i), array(i + 1))
                    swapped = True
                End If
            Next
        Loop While swapped
    End Sub

    Private Shared Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub

    Private Shared Function GetIntArrayFromUser() As Integer()
        Console.WriteLine("Enter the number of elements:")
        Dim size As Integer = Integer.Parse(Console.ReadLine())
        Dim array As Integer() = New Integer(size - 1) {}
        Console.WriteLine("Enter the elements (integer numbers):")

        For i As Integer = 0 To size - 1
            Console.Write($"Element {i + 1}: ")
            array(i) = Integer.Parse(Console.ReadLine())
        Next

        Return array
    End Function

    Private Shared Sub PrintArray(ByVal array As Integer())
        For Each item In array
            Console.Write(item & " ")
        Next

        Console.WriteLine()
    End Sub
End Class
