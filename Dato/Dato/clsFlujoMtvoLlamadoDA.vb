Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports Entidad
Public Class clsFlujoMtvoLlamadoDA

    Dim con As New clsConexion 'SE CREA OBJETO DE CLSCONEXION PARA PODER CONECTARNOS A BASE DE DATOS
    Dim query As String 'VARIABLE QUE ALMACENARA EL PROCEDIMIENTO ALMACENDADO A CONSULTAR
    Dim tipoConexion As Integer 'VARIABLE QUE ALMACENARA LA BASE A LA CUAL CONSULTAR
    'VARIABLE QUE ALMACENARA LOS PARAMETROS A LA BASE DE DATOS
    Dim Tabla As New DataTable

    Public Function BuscaMtvoLlamadoPorCC(ByVal _codigo As Integer) As List(Of eFlujoMtvoLlamado)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable
        Dim listTipoContrato As New List(Of eTipoContrato)

        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Entidad].[pa_Listamotivollamada]"
        cmd.Parameters.AddWithValue("@codigoCampana", _codigo)
        cmd.CommandText = sql
        dt = con.TraeDatos(cmd, 1)

        Dim lstMotivoRechazo As New List(Of eFlujoMtvoLlamado)

        If dt.Rows.Count > 0 Then
            Dim MtvoLlamado As New eFlujoMtvoLlamado
            MtvoLlamado.IdRealiza = 0
            MtvoLlamado.CmdDescripcion = "---No Ingresado---"
            lstMotivoRechazo.Add(MtvoLlamado)

            For x As Int16 = 0 To dt.Rows.Count - 1
                Dim row As New eFlujoMtvoLlamado
                row.IdRealiza = IIf(IsDBNull(dt.Rows(x)("IdRealiza")), Nothing, dt.Rows(x)("IdRealiza"))
                row.CmdDescripcion = IIf(IsDBNull(dt.Rows(x)("CmdDescripcion")), Nothing, dt.Rows(x)("CmdDescripcion"))
                lstMotivoRechazo.Add(row)
            Next

        Else
            MsgBox("Campaña no tiene los Motivos de llamado Configurados. Revisar con Desarrollo", vbExclamation, "Informacion")
        End If

        Return lstMotivoRechazo
    End Function
End Class
