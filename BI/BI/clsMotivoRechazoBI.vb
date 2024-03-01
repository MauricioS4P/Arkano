Imports Dato
Imports Entidad

Public Class clsMotivoRechazoBI

    Public Function BuscarMotivoRechazoPorSponsor(ByVal codigo As Integer) As List(Of eMotivoRechazo)
        Dim daMotivoRechazo As New clsMotivoRechazoDA
        Return daMotivoRechazo.BuscarMotivoRechazoPorSponsor(codigo)
    End Function

    Public Function BuscaMotivoRechazoCampaniaPorId(ByVal _idMotivosObjecion As Int32) As eMotivoRechazoCampania
        Dim daMotivoRechazo As New clsMotivoRechazoDA
        Return daMotivoRechazo.BuscaMotivoRechazoCampaniaPorId(_idMotivosObjecion)
    End Function

End Class
