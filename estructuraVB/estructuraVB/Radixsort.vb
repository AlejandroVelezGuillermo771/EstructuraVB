Imports Poyecto_de_3er_semestre
Imports System
Imports System.Collections.Generic

Class Radixsort
    Public Shared Sub Radix()
        Dim array As Integer() = New Integer(-1) {}

        Do
            Console.WriteLine("1. Agregar valor")
            Console.WriteLine("2. Ordenar con Radix Sort")
            Console.WriteLine("3. Mostrar array")
            Console.WriteLine("4. Regresar a Algoritmos")
            Dim opcion As Integer = ObtenerOpcion()

            Select Case opcion
                Case 1
                    Console.Write("Ingrese un valor: ")
                    Dim valor As Integer = Integer.Parse(Console.ReadLine())
                    array = AgregarValor(array, valor)
                Case 2
                    RadixSort(array)
                    Console.WriteLine("Array ordenado con Radix Sort")
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

    Private Shared Sub RadixSort(ByVal array As Integer())
        If array.Length = 0 Then
            Console.WriteLine("El array está vacío. No hay nada que ordenar.")
            Return
        End If

        Dim maximo As Integer = EncontrarMaximo(array)
                ''' Cannot convert ForStatementSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: op
''' Actual value was MultiplyAssignmentStatement.
'''    at ICSharpCode.CodeConverter.Util.VBUtil.GetExpressionOperatorTokenKind(SyntaxKind op)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.MakeAssignmentStatement(AssignmentExpressionSyntax node)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
'''    at ICSharpCode.CodeConverter.VB.MethodBodyVisitor.ConvertForToSimpleForNext(ForStatementSyntax node, StatementSyntax& block)
'''    at ICSharpCode.CodeConverter.VB.MethodBodyVisitor.VisitForStatement(ForStatementSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
''' 
''' Input: 
''' 
        // Realizar el sort para cada dígito
        For (Int() exp = 1; maximo / exp > 0; exp *= 10)
        {
            ContarSort(array, exp);
        }

''' 
    End Sub

    Private Shared Sub ContarSort(ByVal array As Integer(), ByVal exp As Integer)
        Dim n As Integer = array.Length
        Dim resultado As Integer() = New Integer(n - 1) {}
        Dim contador As Integer() = New Integer(9) {}

        For i As Integer = 0 To 10 - 1
            contador(i) = 0
        Next

        For i As Integer = 0 To n - 1
            contador((array(i) / exp) Mod 10) += 1
        Next

        For i As Integer = 1 To 10 - 1
            contador(i) += contador(i - 1)
        Next

        For i As Integer = n - 1 To 0
            resultado(contador((array(i) / exp) Mod 10) - 1) = array(i)
            contador((array(i) / exp) Mod 10) -= 1
        Next

        array.Copy(resultado, array, n)
    End Sub

    Private Shared Function EncontrarMaximo(ByVal array As Integer()) As Integer
        Dim maximo As Integer = array(0)

        For Each valor In array

            If valor > maximo Then
                maximo = valor
            End If
        Next

        Return maximo
    End Function
End Class
