Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports Entidad
Public Class clsMarcaDA
    Dim con As New Dato.clsConexion 'SE CREA OBJETO DE CLSCONEXION PARA PODER CONECTARNOS A BASE DE DATOS
    Dim query As String 'VARIABLE QUE ALMACENARA EL PROCEDIMIENTO ALMACENDADO A CONSULTAR
    Dim tipoConexion As Integer 'VARIABLE QUE ALMACENARA LA BASE A LA CUAL CONSULTAR
    'VARIABLE QUE ALMACENARA LOS PARAMETROS A LA BASE DE DATOS
    Dim Tabla As New DataTable

    Public Function ListaMarca() As List(Of eMarca)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable
        Dim listMarca As New List(Of eMarca)


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Config].[MarcaAltasRipley]"
        cmd.CommandText = sql
        dt = con.TraeDatos(cmd, 1)

        If dt.Rows.Count > 0 Then

            Dim tipomarca As New eMarca

            tipomarca.Id_Ripley = 0
            tipomarca.MARCA_Ripley = "---No ingresado---"
            listMarca.Add(tipomarca)

            For x As Int16 = 0 To dt.Rows.Count - 1
                Dim row As New eMarca
                row.Id_Ripley = IIf(IsDBNull(dt.Rows(x)("Id_Ripley")), Nothing, dt.Rows(x)("Id_Ripley"))
                row.MARCA_Ripley = IIf(IsDBNull(dt.Rows(x)("MARCA_Ripley")), Nothing, dt.Rows(x)("MARCA_Ripley"))
                listMarca.Add(row)
            Next

        End If

        Return listMarca

    End Function
    Public Function ListaModeloxMarca() As List(Of eMarcaxModelo)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim dt As New DataTable
        Dim listModelo As New List(Of eMarcaxModelo)


        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Config].[MarcaModeloAltasRipley]"
        cmd.CommandText = sql
        dt = con.TraeDatos(cmd, 1)

        If dt.Rows.Count > 0 Then

            Dim tipomodelo As New eMarcaxModelo

            tipomodelo.IdModelo = 0
            tipomodelo.MODELO_Ripley = "---No ingresado---"
            listModelo.Add(tipomodelo)

            For x As Int16 = 0 To dt.Rows.Count - 1
                Dim row As New eMarcaxModelo
                row.IdModelo = IIf(IsDBNull(dt.Rows(x)("IdModelo")), Nothing, dt.Rows(x)("IdModelo"))
                row.MODELO_Ripley = IIf(IsDBNull(dt.Rows(x)("MODELO_Ripley")), Nothing, dt.Rows(x)("MODELO_Ripley"))
                row.MARCA_Ripley = IIf(IsDBNull(dt.Rows(x)("MARCA_Ripley")), Nothing, dt.Rows(x)("MARCA_Ripley"))
                listModelo.Add(row)
            Next

        End If

        Return listModelo

    End Function
End Class
