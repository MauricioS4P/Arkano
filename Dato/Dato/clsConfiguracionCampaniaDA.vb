Imports System.Data.SqlClient
Imports Entidad

Public Class clsConfiguracionCampaniaDA




    Dim cnn As New SqlConnection("data source = 192.168.2.8; initial catalog = BDD_GENERAL; User Id= ck; Password=Power.2077")

    Dim con As New clsConexion 'SE CREA OBJETO DE CLSCONEXION PARA PODER CONECTARNOS A BASE DE DATOS
    Dim query As String 'VARIABLE QUE ALMACENARA EL PROCEDIMIENTO ALMACENDADO A CONSULTAR
    Dim tipoConexion As Integer 'VARIABLE QUE ALMACENARA LA BASE A LA CUAL CONSULTAR
    '  'VARIABLE QUE ALMACENARA LOS PARAMETROS A LA BASE DE DATOS
    Dim dt As New DataTable



    Public Function ObtenerConfiguracionCampania(ByRef codigo As String) As eProyecto

        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Config].[pa_ListaCampanaPorId]"
        cmd.Parameters.AddWithValue("@codigo", codigo)
        cmd.CommandText = sql
        dt = con.TraeDatos(cmd, 1)

        Dim row As New eProyecto
        For x As Int16 = 0 To dt.Rows.Count - 1

            row.codigo = IIf(dt.Rows(x)("codigo") Is DBNull.Value, Nothing, dt.Rows(x)("codigo"))
            row.IdTelefonia = IIf(dt.Rows(x)("IdTelefonia") Is DBNull.Value, Nothing, dt.Rows(x)("IdTelefonia"))
            row.nombre = IIf(dt.Rows(x)("nombreCampaña") Is DBNull.Value, Nothing, dt.Rows(x)("nombreCampaña"))
            row.ServidorBDD = IIf(dt.Rows(x)("servidor") Is DBNull.Value, Nothing, dt.Rows(x)("servidor"))
            row.RutCompleto = IIf(dt.Rows(x)("rutCompleto") Is DBNull.Value, Nothing, dt.Rows(x)("rutCompleto"))
            row.ServidorTelefonia = IIf(dt.Rows(x)("rutaServidor") Is DBNull.Value, Nothing, dt.Rows(x)("rutaServidor"))
            row.validaRut = IIf(dt.Rows(x)("validaRut") Is DBNull.Value, False, dt.Rows(x)("validaRut"))
            row.restriccionPlan = IIf(dt.Rows(x)("restriccionPlan") Is DBNull.Value, False, dt.Rows(x)("restriccionPlan"))
            row.ConWhatsapp = IIf(dt.Rows(x)("ConWhatsapp") Is DBNull.Value, False, dt.Rows(x)("ConWhatsapp"))
        Next

        codigoProyecto = row.ServidorBDD

        Return row



    End Function

End Class

