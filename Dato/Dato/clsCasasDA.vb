Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports Entidad

Public Class clsCasasDA
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
    Public Function listarCasas() As List(Of eCasas)

        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Entidad].[pa_ListaCasasS4P]"
        cmd.CommandText = sql
        dt = con.TraeDatos(cmd, 1)

        Dim listCasas As New List(Of eCasas)

        For x As Int16 = 0 To dt.Rows.Count - 1
            Dim row As New eCasas

            row.IdCasa = IIf(IsDBNull(dt.Rows(x)("IdCasa")), Nothing, dt.Rows(x)("IdCasa"))
            row.NombreCasa = IIf(IsDBNull(dt.Rows(x)("NombreCasa")), Nothing, dt.Rows(x)("NombreCasa"))
            row.IpCasa = IIf(IsDBNull(dt.Rows(x)("IpCasa")), Nothing, dt.Rows(x)("IpCasa"))
            listCasas.Add(row)
        Next

        Return listCasas

    End Function

End Class
