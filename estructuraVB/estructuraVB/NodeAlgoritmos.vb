Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Poyecto_de_3er_semestre
    Friend Class NodeAlgoritmos
        Public Data As Integer
        Public Left, Right As NodeAlgoritmos

        Public Sub New(ByVal data As Integer)
            data = data
            Left = CSharpImpl.__Assign(Right, Nothing)
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
