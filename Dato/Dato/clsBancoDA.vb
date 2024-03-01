Imports System.Data.SqlClient
Imports Entidad
Public Class clsBancoDA

    Dim con As New clsConexion 'SE CREA OBJETO DE CLSCONEXION PARA PODER CONECTARNOS A BASE DE DATOS
    Dim query As String 'VARIABLE QUE ALMACENARA EL PROCEDIMIENTO ALMACENDADO A CONSULTAR
    Dim tipoConexion As Integer 'VARIABLE QUE ALMACENARA LA BASE A LA CUAL CONSULTAR
    ' Dim vlSqlParam As New cm 'VARIABLE QUE ALMACENARA LOS PARAMETROS A LA BASE DE DATOS
    Dim Tabla As New DataTable

    Public Function buscaBanco(ByVal _codCampana As Integer, ByVal tipoCuenta As Integer) As List(Of eBancos)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable

        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Entidad].[pa_buscarBanco]"
        cmd.Parameters.AddWithValue("@codCampana", _codCampana)
        cmd.Parameters.AddWithValue("@tipoPago", tipoCuenta)
        cmd.CommandText = sql
        dt = con.TraeDatos(cmd, 1)

        Dim lstBancos As New List(Of eBancos)

        For x As Int16 = 0 To dt.Rows.Count - 1
            Dim row As New eBancos

            row.id_Banco = IIf(IsDBNull(dt.Rows(x)("Id_Banco")), Nothing, dt.Rows(x)("Id_Banco"))
            row.descripcionBanco = IIf(IsDBNull(dt.Rows(x)("DescripcionBanco")), Nothing, dt.Rows(x)("DescripcionBanco"))

            lstBancos.Add(row)
        Next

        Return lstBancos

    End Function

End Class
