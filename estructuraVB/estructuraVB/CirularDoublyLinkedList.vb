Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports estructuraVB.Binarytreesort

Namespace Poyecto_de_3er_semestre
    Friend Class CirularDoublyLinkedList
        Private primero As Nodo = New Nodo()
        Private ultimo As Nodo = New Nodo()

        Public Sub New()
            primero = Nothing
            ultimo = Nothing
        End Sub

        Public Sub insertarNodo()
            Dim nuevo As Nodo = New Nodo()
            Console.Write("Ingrese el dato del nuevo Nodo:")
            nuevo.Dato = Integer.Parse(Console.ReadLine())

            If primero Is Nothing Then
                primero = nuevo
                ultimo = nuevo
                primero.Siguiente = primero
                primero.Atras = ultimo
            Else
                ultimo.Siguiente = nuevo
                nuevo.Atras = ultimo
                nuevo.Siguiente = primero
                ultimo = nuevo
                primero.Atras = ultimo
            End If

            Console.WriteLine(" " & vbLf & " Nuevo nodo ingresado con exito:")
        End Sub

        Public Sub desplegarlistaPU()
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

        Public Sub desplegarlistasUP()
            Dim actual As Nodo = New Nodo()
            actual = ultimo

            If actual IsNot Nothing Then

                Do
                    Console.WriteLine(" " & actual.Dato)
                    actual = actual.Atras
                Loop While actual <> ultimo
            Else
                Console.WriteLine(vbLf & " La lista se encuentra vacia" & vbLf)
            End If
        End Sub
    End Class
End Namespace

Class Nod
    Private Dato As Integer
    Private Siguiente As Nod
    Private Atras As Nod

    Public Property dato As Integer
        Get
            Return dato
        End Get
        Set(ByVal value As Integer)
            Dato = value
        End Set
    End Property

    Public Property siguiente As Nod
        Get
            Return siguiente
        End Get
        Set(ByVal value As Nod)
            Siguiente = value
        End Set
    End Property

    Public Property atras As Nod
        Get
            Return atras
        End Get
        Set(ByVal value As Nod)
            Atras = value
        End Set
    End Property
End Class

