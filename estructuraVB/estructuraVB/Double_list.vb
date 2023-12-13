Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Poyecto_de_3er_semestre
    Friend Class Double_list
        Private primero As Nodo = New Nodo()
        Private ultimo As Nodo = New Nodo()

        Public Sub New()
            primero = Nothing
            ultimo = Nothing
        End Sub

        Public Sub insertarNodo()
            Dim nuevo As Nodo = New Nodo()
            Console.Write("Ingrese el nuevo dato que contendra el Nodo:")
            nuevo.Dato = Integer.Parse(Console.ReadLine())

            If primero Is Nothing Then
                primero = nuevo
                primero.Siguiente = Nothing
                primero.Atras = Nothing
                ultimo = primero
            Else
                ultimo.Siguiente = nuevo
                nuevo.Siguiente = Nothing
                nuevo.Atras = ultimo
                ultimo = nuevo
            End If

            Console.Write(vbLf & " Nuevo noodo ingresado con exito" & vbLf)
        End Sub

        Public Sub desplegarlista()
            Dim actual As Nodo = New Nodo()
            actual = primero

            While actual IsNot Nothing
                Console.WriteLine(" " & actual.Dato)
                actual = actual.Siguiente
            End While
        End Sub

        Public Sub desplegarlistaa()
            Dim actual As Nodo = New Nodo()
            actual = ultimo

            While actual IsNot Nothing
                Console.WriteLine(" " & actual.Dato)
                actual = actual.Atras
            End While
        End Sub
    End Class
End Namespace

Class Nodo
    Private dato As Integer
    Private siguiente As Nodo
    Private atras As Nodo

    Public Property Dato As Integer
        Get
            Return Dato
        End Get
        Set(ByVal value As Integer)
            dato = value
        End Set
    End Property

    Public Property Siguiente As Nodo
        Get
            Return Siguiente
        End Get
        Set(ByVal value As Nodo)
            siguiente = value
        End Set
    End Property

    Public Property Atras As Nodo
        Get
            Return Atras
        End Get
        Set(ByVal value As Nodo)
            atras = value
        End Set
    End Property
End Class
