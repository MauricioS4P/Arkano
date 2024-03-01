Imports System.Data.SqlClient

Module ModuleGeneral_DA
    Public codigoProyecto As String  ' variable que almacenara el numero de la campaña se ocupara para los procedimientos para reemplazar el numero de la campaña
    Public cnn As New SqlConnection("data source = 192.168.2.8; initial catalog = BDD_" & codigoProyecto & "; User Id= ck; Password=Power.2077")
    Public cnnG As New SqlConnection("data source = 192.168.2.8; initial catalog = BDD_GENERAL; User Id= ck; Password=Power.2077")

End Module
