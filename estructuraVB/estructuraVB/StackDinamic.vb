Imports estructura_de_datoss
Imports estructuraVB.estructura_de_datoss
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Poyecto_de_3er_semestre
    Friend Class StackDinamic
        Private Primero As Nodos = New Nodos()

        Public Sub New()
            Primero = Nothing
        End Sub

        Public Sub insertarNodo()
            Dim Nuevo As Nodos = New Nodos()
            Console.Write("Ingrese el dato que contendra el nuevo Nodo:")
            Nuevo.Dato = Integer.Parse(Console.ReadLine())
            Nuevo.Siguiente = Primero
            Primero = Nuevo
            Console.WriteLine(vbLf & " Nodo ingresado" & vbLf & vbLf)
        End Sub

        Public Sub desplegarPila()
            Dim Actual As Nodos = New Nodos()
            Actual = Primero

            If Primero IsNot Nothing Then

                While Actual IsNot Nothing
                    Console.WriteLine(" " & Actual.Dato)
                    Actual = Actual.Siguiente
                End While
            Else
                Console.WriteLine(vbLf & " La pila se encuentra vacia " & vbLf & vbLf)
            End If
        End Sub
    End Class
End Namespace

Namespace estructura_de_datoss
    Class Nodos
        Private dato As Integer
        Private siguiente As Nodos

        Public Property Dato As Integer
            Get
                Return Dato
            End Get
            Set(ByVal value As Integer)
                dato = value
            End Set
        End Property

        Public Property Siguiente As Nodos
            Get
                Return Siguiente
            End Get
            Set(ByVal value As Nodos)
                siguiente = value
            End Set
        End Property
    End Class
End Namespace
