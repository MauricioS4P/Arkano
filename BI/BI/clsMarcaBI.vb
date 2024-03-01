Imports Dato
Imports Entidad

Public Class clsMarcaBI
    Public Function ListaMarca() As List(Of eMarca)
        Dim datipoMarca As New clsMarcaDA
        Return datipoMarca.ListaMarca()
    End Function
    Public Function BuscaModeloxMarca() As List(Of eMarcaxModelo)
        Dim datipomodelo As New clsMarcaDA
        Return datipomodelo.ListaModeloxMarca()

    End Function
End Class
