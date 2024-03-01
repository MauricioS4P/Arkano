Imports Dato, Entidad
Public Class clsBancoBi

    Dim clsBancos As New clsBancoDA

    Public Function buscaBancos(ByVal codCampana As Integer, ByVal tipoCuenta As Integer) As List(Of eBancos)
        Return clsBancos.buscaBanco(codCampana, tipoCuenta)
    End Function

End Class
