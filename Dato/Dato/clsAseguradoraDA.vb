Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports Entidad
Public Class clsAseguradoraDA
    Dim con As New clsConexion 'SE CREA OBJETO DE CLSCONEXION PARA PODER CONECTARNOS A BASE DE DATOS
    Dim query As String 'VARIABLE QUE ALMACENARA EL PROCEDIMIENTO ALMACENDADO A CONSULTAR
    Dim tipoConexion As Integer 'VARIABLE QUE ALMACENARA LA BASE A LA CUAL CONSULTAR
    'VARIABLE QUE ALMACENARA LOS PARAMETROS A LA BASE DE DATOS
    Dim Tabla As New DataTable

    Public Function BuscaAseguradora() As List(Of eAseguradora)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable

        cmd.CommandType = CommandType.StoredProcedure
        sql = "[Config].[ListaCompañias]"
        cmd.CommandText = sql
        dt = con.TraeDatos(cmd, 1)

        Dim lstAseguradora As New List(Of eAseguradora)

        If dt.Rows.Count > 0 Then
            Dim MtvoLlamado As New eAseguradora
            MtvoLlamado.idCompania = 0
            MtvoLlamado.Nombre = "---No Ingresado---"
            lstAseguradora.Add(MtvoLlamado)

            For x As Int16 = 0 To dt.Rows.Count - 1
                Dim row As New eAseguradora
                row.idCompania = IIf(IsDBNull(dt.Rows(x)("idCompania")), Nothing, dt.Rows(x)("idCompania"))
                row.Nombre = IIf(IsDBNull(dt.Rows(x)("Nombre")), Nothing, dt.Rows(x)("Nombre"))
                lstAseguradora.Add(row)
            Next

        Else
            MsgBox("Campaña no tiene los Motivos de llamado Configurados. Revisar con Desarrollo", vbExclamation, "Informacion")
        End If

        Return lstAseguradora
    End Function
End Class
