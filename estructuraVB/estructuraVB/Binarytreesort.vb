Imports Poyecto_de_3er_semestre
Imports System
Imports System.Diagnostics

Class Binarytreesort
    Class Nodo
        Public Valor As Integer
        Public Izquierda As Nodo
        Public Derecha As Nodo

        Public Sub New(ByVal valor As Integer)
            valor = valor
            Izquierda = CSharpImpl.__Assign(Derecha, Nothing)
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class

    Shared raiz As Nodo = Nothing

    Public Shared Sub BINARYTREESORT()
        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Binary Tree Sort")
            Console.WriteLine("3. Mostrar en orden")
            Console.WriteLine("4. Regresar al Menu de Estructuras")
            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    raiz = AgregarValor(raiz, valor)
                Case 2
                    Console.WriteLine("Ordenando con Binary Tree Sort")
                    BinaryTreeSort(raiz)
                Case 3
                    Console.WriteLine("Mostrando en orden:")
                    MostrarEnOrden(raiz)
                    Console.WriteLine()
                Case 4
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

    Private Shared Function AgregarValor(ByVal nodo As Nodo, ByVal valor As Integer) As Nodo
        If nodo Is Nothing Then Return New Nodo(valor)

        If valor < nodo.Valor Then
            nodo.Izquierda = AgregarValor(nodo.Izquierda, valor)
        ElseIf valor > nodo.Valor Then
            nodo.Derecha = AgregarValor(nodo.Derecha, valor)
        End If

        Return nodo
    End Function

    Private Shared Sub BinaryTreeSort(ByRef nodo As Nodo)
        If nodo Is Nothing Then Return
        BinaryTreeSort(nodo.Izquierda)
        Console.Write(nodo.Valor & " ")
        BinaryTreeSort(nodo.Derecha)
    End Sub

    Private Shared Sub MostrarEnOrden(ByVal nodo As Nodo)
        BinaryTreeSort(nodo)
    End Sub

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class
