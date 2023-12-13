Imports Poyecto_de_3er_semestre
Imports System

Class Gnomesort
    Public Shared Sub Gnome()
        Dim array As Integer() = New Integer(-1) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Gnome Sort")
            Console.WriteLine("3. Regresar a Algoritmos")
            Console.WriteLine("4. Salir")
            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    array = AgregarValor(array, valor)
                Case 2
                    GnomeSort(array)
                    Console.WriteLine("Array ordenado con Gnome Sort")
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

    Private Shared Sub GnomeSort(ByVal array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        Dim i As Integer = 0

        While i < array.Length

            If i = 0 OrElse array(i) >= array(i - 1) Then
                i += 1
            Else
                Swap(array(i), array(i - 1))
                i -= 1
            End If
        End While
    End Sub

    Private Shared Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub
End Class
