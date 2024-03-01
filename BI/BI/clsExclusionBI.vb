Imports Dato
Imports Entidad

Public Class clsExclusionBI

    Public Function listarExclusiones(ByVal codigo As Integer) As List(Of eExclusion)
        Dim daExclusion As New clsExclusionDA
        Return daExclusion.listarExclusiones(codigo)
    End Function

End Class
