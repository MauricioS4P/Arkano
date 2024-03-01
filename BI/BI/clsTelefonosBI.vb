Imports Dato
Imports Entidad
Public Class clsTelefonosBI

    Public Function listarTelefonos(ByVal id As Integer) As List(Of eTelefonos)
        Dim daTelefonos As New clsTelefonoDA
        Return daTelefonos.listarTelefonos(id)
    End Function

End Class