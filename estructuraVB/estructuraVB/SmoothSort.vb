Imports Poyecto_de_3er_semestre
Imports System

Public Class SmoothSort
    Private array As Integer()
    Private size As Integer

    Public Sub New(ByVal inputArray As Integer())
        array = inputArray
        size = inputArray.Length
    End Sub

    Public Sub Sort()
        For i As Integer = 0 To size - 1
            SiftDown(i)
        Next

        For i As Integer = size - 1 To 0 + 1
            Swap(0, i)
            SiftUp(0, i - 1)
        Next
    End Sub

    Private Sub SiftDown(ByVal i As Integer)
        Dim leftChild As Integer
        Dim rightChild As Integer
        Dim j As Integer

        While 2 * i + 1 < size
            leftChild = 2 * i + 1
            rightChild = leftChild + 1
            j = i

            If rightChild < size AndAlso array(rightChild) > array(j) Then
                j = rightChild
            End If

            If array(leftChild) > array(j) Then
                j = leftChild
            End If

            If i = j Then
                Exit While
            End If

            Swap(i, j)
            i = j
        End While
    End Sub

    Private Sub SiftUp(ByVal i As Integer, ByVal last As Integer)
        While i < last
            Dim j As Integer = 2 * i + 1

            If j + 1 <= last AndAlso array(j) < array(j + 1) Then
                j += 1
            End If

            If j <= last AndAlso array(i) < array(j) Then
                Swap(i, j)
                i = j
            Else
                Exit While
            End If
        End While
    End Sub

    Private Sub Swap(ByVal i As Integer, ByVal j As Integer)
        Dim temp As Integer = array(i)
        array(i) = array(j)
        array(j) = temp
    End Sub
End Class

Class Smooth
    Public Shared Sub Smoot()
        Dim [exit] As Boolean = False
        Dim array As Integer() = Nothing

        Do
            Console.WriteLine("Menú:")
            Console.WriteLine("1. Smooth Sort")
            Console.WriteLine("2. Regresar a Algoritmos")
            Console.Write("Selecciona una opción: ")
            Dim [option] As String = Console.ReadLine()

            Select Case [option]
                Case "1"
                    array = GetIntArrayFromUser()
                    Console.WriteLine(vbLf & "Original array:")
                    PrintArray(array)
                    Dim smoothSort As SmoothSort = New SmoothSort(array)
                    smoothSort.Sort()
                    Console.WriteLine(vbLf & "Smooth Sorted array:")
                    PrintArray(array)
                Case "2"
                    Algoritmos.Ordenamiento()
                Case Else
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.")
            End Select
        Loop While Not [exit]
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
