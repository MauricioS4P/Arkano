Public Class eBancos

    Private _id_Banco As Integer
    Private _descripcionBanco As String

    Public Property id_Banco As String
        Get
            Return _id_Banco
        End Get
        Set(value As String)
            _id_Banco = value
        End Set
    End Property

    Public Property descripcionBanco As String
        Get
            Return _descripcionBanco
        End Get
        Set(value As String)
            _descripcionBanco = value
        End Set
    End Property


End Class
