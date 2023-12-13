Imports Poyecto_de_3er_semestre
Imports System

Class Bucketsort
    Public Shared Sub BUCKET()
        Dim [exit] As Boolean = False

        Do
            Console.WriteLine("Menú:")
            Console.WriteLine("1. Bucket Sort")
            Console.WriteLine("2. Otra opción")
            Console.WriteLine("3. Regresar al menu de Algoritmos")
            Console.Write("Selecciona una opción: ")
            Dim [option] As String = Console.ReadLine()

            Select Case [option]
                Case "1"
                    RunBucketSort()
                Case "2"
                Case "3"
                    Algoritmos.Ordenamiento()
                Case Else
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.")
            End Select
        Loop While Not [exit]
    End Sub

    Private Shared Sub RunBucketSort()
        Console.WriteLine("Enter the number of elements:")
        Dim size As Integer = Integer.Parse(Console.ReadLine())
        Dim array As Single() = New Single(size - 1) {}
        Console.WriteLine("Enter the elements (floating-point numbers between 0 and 1):")

        For i As Integer = 0 To size - 1
            Console.Write($"Element {i + 1}: ")
            array(i) = Single.Parse(Console.ReadLine())
        Next

        Console.WriteLine(vbLf & "Original array:")

        For Each item In array
            Console.Write(item & " ")
        Next

        Console.WriteLine(vbLf & vbLf & "Bucket Sorted array:")
        BucketSort(array)
        Console.WriteLine("Press Enter to continue...")
        Console.ReadLine()
    End Sub

    Private Shared Sub BucketSort(ByVal array As Single())
    End Sub
End Class
