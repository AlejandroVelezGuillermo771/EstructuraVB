Imports Poyecto_de_3er_semestre
Imports System

Class Node
    Public Property Data As Integer
    Public Property [Next] As Node

    Public Sub New(ByVal data As Integer)
        data = data
        [Next] = Nothing
    End Sub
End Class

Class SimpleList
    Private head As Node

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub AgregarElemento(ByVal data As Integer)
        Dim nuevoNodo As Node = New Node(data)

        If head Is Nothing Then
            head = nuevoNodo
        Else
            Dim temp As Node = head

            While temp.[Next] IsNot Nothing
                temp = temp.[Next]
            End While

            temp.[Next] = nuevoNodo
        End If
    End Sub

    Public Sub MostrarLista()
        Dim temp As Node = head

        While temp IsNot Nothing
            Console.Write(temp.Data & " ")
            temp = temp.[Next]
        End While

        Console.WriteLine()
    End Sub
End Class

Class Simple_list
    Public Shared Sub List()
        Dim lista As SimpleList = New SimpleList()

        Do
            Console.WriteLine("1. Agregar elemento")
            Console.WriteLine("2. Mostrar lista")
            Console.WriteLine("3. Regresar al Menu de Estructuras")
            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    lista.AgregarElemento(valor)
                Case 2
                    Console.WriteLine("Contenido de la lista:")
                    lista.MostrarLista()
                Case 3
                    Program.Main()
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
