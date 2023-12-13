Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports estructuraVB.Binarytreesort

Namespace Poyecto_de_3er_semestre
    Friend Class Circular_list
        Private primero As Nodo = New Nodo()
        Private ultimo As Nodo = New Nodo()

        Public Sub New()
            primero = Nothing
            ultimo = Nothing
        End Sub

        Public Sub insertarNodo()
            Dim nuevo As Nodo = New Nodo()
            Console.Write("Ingrese el valor del nuevo valor:")
            nuevo.Dato = Integer.Parse(Console.ReadLine())

            If primero Is Nothing Then
                primero = nuevo
                primero.Siguiente = primero
                ultimo = primero
            Else
                ultimo.Siguiente = nuevo
                nuevo.Siguiente = primero
                ultimo = nuevo
            End If

            Console.WriteLine(vbLf & " Nodo ingresado con exito" & vbLf & vbLf)
        End Sub

        Public Sub desplegarlista()
            Dim actual As Nodo = New Nodo()
            actual = primero

            If actual IsNot Nothing Then

                Do
                    Console.WriteLine(" " & actual.Dato)
                    actual = actual.Siguiente
                Loop While actual <> primero
            Else
                Console.WriteLine(vbLf & " La lista se encuentra vacia" & vbLf)
            End If
        End Sub
    End Class

    Class Nod
        Private Dato As Integer
        Private Siguiente As Nodo

        Public Property dato As Integer
            Get
                Return dato
            End Get
            Set(ByVal value As Integer)
                Dato = value
            End Set
        End Property

        Public Property siguiente As Nodo
            Get
                Return siguiente
            End Get
            Set(ByVal value As Nodo)
                Siguiente = value
            End Set
        End Property
    End Class
End Namespace

