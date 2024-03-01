Imports System.Data.SqlClient


Public Class clsConexion

    Dim con As New SqlConnection("Data Source=192.168.2.8;Initial Catalog=BDD_GENERAL;Persist Security Info=True;User ID=ck;Password=Power.2077")
    Dim cmd As New SqlCommand
    Public Function CadenaConexion(ByVal IdBase As Integer) As String
        Dim stringConexion As String
        stringConexion = ""

        Select Case IdBase
            Case 1 '"GLOBAL"
                stringConexion = "Data Source = 192.168.2.8; Initial catalog=BDD_GENERAL; User Id= ck; Password=Power.2077"
            Case 2 '"BASEACTUAL"
                stringConexion = "Data Source = 192.168.2.8; Initial Catalog=" + codigoProyecto + ";Persist Security Info=True;User ID=ck;Password=Power.2077"
                'Case 3 '"SRVCS"
                '    stringConexion = "Data Source=152.231.73.174;Initial Catalog=Global;Persist Security Info=True;User ID=mg;Password=cordial.passs"
        End Select
        Return stringConexion
    End Function

    Private Function conectar(ByVal x As Integer, ByVal con As SqlConnection) As Boolean
        Try
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox("Problemas al abrir conexión a base de datos" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Informacion")
            Return False
        End Try
    End Function
    Private Sub desconectar(ByVal x As Integer, ByVal con As SqlConnection)
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("Problemas al cerrar conexión a base de datos" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Public Function Ejecutar(ByVal cmd As SqlCommand, ByVal idConexion As String) As Boolean

        Dim valido As Boolean

        Dim con As New SqlConnection(CadenaConexion(idConexion))
        Dim myTransaction As SqlTransaction
        Try

            If conectar(idConexion, con) = True Then
                myTransaction = con.BeginTransaction()
                Dim rows As Integer
                Try
                    cmd.Transaction = myTransaction
                    cmd.Connection = con
                    rows = cmd.ExecuteNonQuery
                    If rows > 0 Then
                        myTransaction.Commit()
                        valido = True
                    Else
                        myTransaction.Rollback()
                        valido = False
                    End If

                Catch ex As Exception
                    myTransaction.Rollback()
                    MsgBox("ERROR: nombre procedimiento " + cmd.ToString + " Detalle: " & vbNewLine, MsgBoxStyle.Critical, "Informacion")
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Informacion")
                    valido = False
                End Try
                desconectar(idConexion, con)
            End If
        Catch ex As Exception

        End Try

        Return valido

    End Function


    Public Function TraeDatos(ByVal cmd As SqlCommand, ByVal idConexion As String) As DataTable

        Dim con As New SqlConnection(CadenaConexion(idConexion))
        Dim myTransaction As SqlTransaction
        Dim DA As SqlDataAdapter
        Dim mitabla As New DataTable
        Try

            If conectar(idConexion, con) = True Then
                myTransaction = con.BeginTransaction()
                Dim dt As New DataTable
                Try
                    cmd.Transaction = myTransaction
                    cmd.Connection = con
                    DA = New SqlDataAdapter(cmd)
                    DA.Fill(mitabla)
                    If mitabla.Rows.Count > 0 Then
                        myTransaction.Commit()
                    Else
                        myTransaction.Rollback()

                    End If

                Catch ex As Exception
                    myTransaction.Rollback()
                    MsgBox("ERROR: nombre procedimiento " + cmd.ToString + " Detalle: " & vbNewLine, MsgBoxStyle.Critical, "Informacion")
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Informacion")

                Finally
                    desconectar(idConexion, con)
                End Try

            End If
        Catch ex As Exception

        End Try

        Return mitabla

    End Function



End Class
