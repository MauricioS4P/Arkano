Imports Dato
Imports Entidad
Public Class clsCasasBI

    Public Function listarCasas() As List(Of eCasas)
        Dim daCasas As New clsCasasDA
        Return daCasas.listarCasas()
    End Function

End Class
