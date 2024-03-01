Public Class eMarcaxModelo
    Private _IdModelo As Int16
    Private _MARCA_Ripley As String
    Private _MODELO_Ripley As String
    Private _COD_MODELO_Ripley As String

    Public Property IdModelo() As Int16
        Get
            Return _IdModelo
        End Get
        Set(ByVal value As Int16)
            _IdModelo = value
        End Set
    End Property

    Public Property MARCA_Ripley() As String
        Get
            Return _MARCA_Ripley
        End Get
        Set(ByVal value As String)
            _MARCA_Ripley = value
        End Set
    End Property

    Public Property MODELO_Ripley() As String
        Get
            Return _MODELO_Ripley
        End Get
        Set(ByVal value As String)
            _MODELO_Ripley = value
        End Set
    End Property
    Public Property COD_MODELO_Ripley() As String
        Get
            Return _COD_MODELO_Ripley
        End Get
        Set(ByVal value As String)
            _COD_MODELO_Ripley = value
        End Set
    End Property
End Class
