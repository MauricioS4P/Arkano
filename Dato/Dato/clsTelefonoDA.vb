Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports Entidad

Public Class clsTelefonoDA
    Dim con As New clsConexion 'SE CREA OBJETO DE CLSCONEXION PARA PODER CONECTARNOS A BASE DE DATOS
    Dim query As String 'VARIABLE QUE ALMACENARA EL PROCEDIMIENTO ALMACENDADO A CONSULTAR
    Dim tipoConexion As Integer 'VARIABLE QUE ALMACENARA LA BASE A LA CUAL CONSULTAR
    'VARIABLE QUE ALMACENARA LOS PARAMETROS A LA BASE DE DATOS
    Dim dt As New DataTable

    '****************Metodo para listar todas las comunas**********************************
    ''' <summary>
    ''' Metodo para listar todas las comunas
    ''' </summary>
    ''' <returns>List(Of clsComunaEnt)</returns>
    ''' <remarks></remarks>
    Public Function listarTelefonos(ByVal id As Integer) As List(Of eTelefonos)

        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "Gestion.pa_ListaTelefonos"
        cmd.Parameters.AddWithValue("@C_ID", id)
        cmd.CommandText = sql
        dt = con.TraeDatos(cmd, 2)

        Dim listTelefonos As New List(Of eTelefonos)

        For x As Int16 = 0 To dt.Rows.Count - 1
            Dim row As New eTelefonos

            row.telefono = IIf(IsDBNull(dt.Rows(x)("telefono")), Nothing, dt.Rows(x)("telefono"))
            row.datosTelefono = IIf(IsDBNull(dt.Rows(x)("datosTelefono")), Nothing, dt.Rows(x)("datosTelefono"))
            '  row.mensaje = IIf(IsDBNull(dt.Rows(x)("mensaje")), Nothing, dt.Rows(x)("mensaje"))
            listTelefonos.Add(row)
        Next

        Return listTelefonos

    End Function

End Class