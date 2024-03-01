Imports Dato
Imports Entidad
Public Class clsFlujoMtvoLlamadoBI

    Public Function BuscaMtvoLlamadoPorCC(ByVal codigo As Integer) As List(Of eFlujoMtvoLlamado)
        Dim daMotivoRechazo As New clsFlujoMtvoLlamadoDA
        Return daMotivoRechazo.BuscaMtvoLlamadoPorCC(codigo)
    End Function

End Class
