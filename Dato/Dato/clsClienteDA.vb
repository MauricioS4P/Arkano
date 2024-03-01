Imports System.Data.SqlClient
Imports Entidad

Public Class clsClienteDA
    Dim con As New clsConexion
    Dim query As String
    Dim tipoConexion As Integer

    '********* Guarda los datos obtenidos de la venta ***************
    ''' <summary>
    ''' GUARDA LOS DATOS OBTENIDOS DE LA APLICACION DE VENTAS EN LA TABLA CLI
    ''' </summary>
    ''' <param name="_cliente"></param>
    ''' <remarks></remarks>
    Public Sub GuardaDatosCliente(ByVal _cliente As eCliente, ByVal _gestion As eGestion)


        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable
        Dim valido As Boolean


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Gestion].[pa_GuardaGestion]"

        cmd.Parameters.AddWithValue("@C_ID", _cliente.C_Id)
        cmd.Parameters.AddWithValue("@G_ESTADO", _gestion.G_Estado)
        cmd.Parameters.AddWithValue("@G_FECHA", _gestion.G_Fecha)
        cmd.Parameters.AddWithValue("@G_HORA", _gestion.G_Hora)
        cmd.Parameters.AddWithValue("@G_FECHA_VTA", _gestion.G_Fecha_Vta)
        cmd.Parameters.AddWithValue("@G_HORA_VTA", _gestion.G_Hora_Vta)
        cmd.Parameters.AddWithValue("@G_IDLLAMADA", _gestion.G_IdLlamada)
        cmd.Parameters.AddWithValue("@G_INTENTO", _gestion.G_Intento)
        cmd.Parameters.AddWithValue("@G_EJECUTIVO", _gestion.G_Ejecutivo)
        cmd.Parameters.AddWithValue("@G_IP_EJECUTIVO", _gestion.G_Ip_Ejecutivo)
        cmd.Parameters.AddWithValue("@G_FECHA_AGEN", _gestion.G_Fecha_Agen)
        cmd.Parameters.AddWithValue("@G_HORA_AGEN", _gestion.G_Hora_Agen)
        cmd.Parameters.AddWithValue("@G_OBS_AGEN", _gestion.G_Obs_Agen)
        cmd.Parameters.AddWithValue("@G_CONTACTO", _gestion.G_Contacto)
        cmd.Parameters.AddWithValue("@G_NO_CONTACTO", _gestion.G_No_Contacto)
        cmd.Parameters.AddWithValue("@G_CONTACTO_CON", _gestion.G_Contacto_Con)
        cmd.Parameters.AddWithValue("@G_CONTACTO_FLUJO", _gestion.G_Contacto_Flujo)
        cmd.Parameters.AddWithValue("@G_MOTIVO_NO_INTERESA", _gestion.G_Motivo_No_Interesa)
        cmd.Parameters.AddWithValue("@G_RUT", _gestion.G_Rut)
        cmd.Parameters.AddWithValue("@G_DV", _gestion.G_Dv)
        cmd.Parameters.AddWithValue("@G_PATERNO", _gestion.G_Paterno)
        cmd.Parameters.AddWithValue("@G_MATERNO", _gestion.G_Materno)
        cmd.Parameters.AddWithValue("@G_NOMBRE", _gestion.G_Nombre)
        cmd.Parameters.AddWithValue("@G_FECHANACIMIENTO", _gestion.G_Fecha_Nacimiento)
        cmd.Parameters.AddWithValue("@G_SEXO", _gestion.G_Sexo)
        cmd.Parameters.AddWithValue("@G_EMAIL", _gestion.G_Email)
        cmd.Parameters.AddWithValue("@G_CALLE", _gestion.G_Calle)
        cmd.Parameters.AddWithValue("@G_NRO", _gestion.G_Nro)
        cmd.Parameters.AddWithValue("@G_REFERENCIA", _gestion.G_Referencia)
        cmd.Parameters.AddWithValue("@G_COMUNA", _gestion.G_Comuna)
        cmd.Parameters.AddWithValue("@G_CIUDAD", _gestion.G_Ciudad)
        cmd.Parameters.AddWithValue("@G_FONO_CONTACTO", _gestion.G_Fono_Contacto)
        cmd.Parameters.AddWithValue("@G_TIPOCONTRATO", _gestion.G_TipoContrato)
        cmd.Parameters.AddWithValue("@G_PLAN", _gestion.G_Plan)
        cmd.Parameters.AddWithValue("@G_PRIMA_UF", _gestion.G_Prima_Uf)
        cmd.Parameters.AddWithValue("@G_PRIMA_PESOS", _gestion.G_Prima_Pesos)
        cmd.Parameters.AddWithValue("@G_VENTA", _gestion.G_Venta)
        cmd.Parameters.AddWithValue("@G_DATO1", _gestion.G_Dato1)
        cmd.Parameters.AddWithValue("@G_DATO2", _gestion.G_Dato2)
        cmd.Parameters.AddWithValue("@G_DATO3", _gestion.G_Dato3)
        cmd.Parameters.AddWithValue("@G_DATO4", _gestion.G_Dato4)
        cmd.Parameters.AddWithValue("@G_DATO5", _gestion.G_Dato5)
        cmd.Parameters.AddWithValue("@G_DATO6", _gestion.G_Dato6)
        cmd.Parameters.AddWithValue("@G_DATO7", _gestion.G_Dato7)
        cmd.Parameters.AddWithValue("@G_DATO8", _gestion.G_Dato8)
        cmd.Parameters.AddWithValue("@G_DATO9", _gestion.G_Dato9)
        cmd.Parameters.AddWithValue("@G_DATO10", _gestion.G_Dato10)
        cmd.Parameters.AddWithValue("@G_DATO12", _gestion.G_Dato12)
        cmd.Parameters.AddWithValue("@G_DATO13", _gestion.G_Dato13)
        cmd.Parameters.AddWithValue("@G_DATO14", _gestion.G_Dato14)
        cmd.Parameters.AddWithValue("@G_DATO15", _gestion.G_Dato15)
        cmd.Parameters.AddWithValue("@G_DATO16", _gestion.G_Dato16)
        cmd.Parameters.AddWithValue("@G_DATO17", _gestion.G_Dato17)
        cmd.Parameters.AddWithValue("@G_DATO18", _gestion.G_Dato18)
        cmd.Parameters.AddWithValue("@G_DATO19", _gestion.G_Dato19)
        cmd.Parameters.AddWithValue("@G_DATO20", _gestion.G_Dato20)
        cmd.Parameters.AddWithValue("@G_TIEMPO_POSTVIEW", _gestion.G_Tiempo_PostView)
        cmd.CommandText = sql
        valido = con.Ejecutar(cmd, 2)

        If valido = True Then
            MsgBox("Gestion ingresada Correctamente", vbInformation, "Informacion")
        Else
            MsgBox("Gestion no fue ingresada, revisar con Supervisor", vbObjectError, "Informacion")
        End If

    End Sub

    '********* Guarda los datos obtenidos de la venta en la tabla log ***************
    Public Sub GuardaDatosLog(ByVal _claveRegistroActual As String)
        'vlSqlParam.Clear()
        'query = "[GestionVenta].SP_" + nomcampania + "_LOG"
        'vlSqlParam.Add("@id", _claveRegistroActual, SqlDbType.Int)
        'vlSqlParam.Add("@fecha_ter_gestion", DateTime.Now.ToString("yyyyMMdd"), SqlDbType.VarChar)
        'vlSqlParam.Add("@hora_ter_gestion", DateTime.Now.ToString("HHmmss"), SqlDbType.VarChar)
        'tipoConexion = 2
        'con.Ejecutar(query, vlSqlParam, tipoConexion)
        'vlSqlParam.Clear()

    End Sub
    '********* Obtiene los datos del cliente para la venta***************
    Public Function BuscarCliente(ByVal WS_IDUSUARIO As String) As DataTable
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure
        sql = "[Gestion].[pa_BuscaCliente]"
        cmd.Parameters.AddWithValue("@usuario", WS_IDUSUARIO)
        cmd.CommandText = sql
        dt = con.TraeDatos(cmd, 2)

        If dt.Rows.Count <= 0 Then
            MsgBox("No hay registros por recorrer en campaña. Verifique con Supervisor", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion")
            Return dt
        ElseIf dt.Rows(0)("C_ID") = 0 Then
            MsgBox("No hay registros por recorrer en campaña. Verifique con Supervisor", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion")
            Return dt
        End If
        Return dt
    End Function

    '*********METODO PARA OBTENER CLIENTE PARA REGRABACION*******************
    Public Function GesCliente(ByVal Usuario As String, ByVal id As Integer) As DataTable
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Regrabacion].[pa_BuscaClienteRecuperacion]"
        cmd.Parameters.AddWithValue("@USUARIO", Usuario)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.CommandText = sql
        dt = con.TraeDatos(cmd, 2)

        Return dt


    End Function

End Class
