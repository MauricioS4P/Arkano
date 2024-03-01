Imports Dato
Imports Entidad
Public Class clsAseguradoraBI

    Public Function BuscaAseguradora(ByVal codigo As Integer) As List(Of eAseguradora)
        Dim daAseguradora As New clsAseguradoraDA
        Return daAseguradora.BuscaAseguradora()
    End Function

End Class
