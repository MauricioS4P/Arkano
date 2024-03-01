Public Class eMarca 
    
    Private _Id_Ripley As Int16
    Private _MARCA_Ripley As String
    Private _COD_MARCA_Ripley As String

    Public Property Id_Ripley() As Int16
        Get
            Return _Id_Ripley
        End Get
        Set(ByVal value As Int16)
            _Id_Ripley = value
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

    Public Property COD_MARCA_Ripley() As String
        Get
            Return _COD_MARCA_Ripley
        End Get
        Set(ByVal value As String)
            _COD_MARCA_Ripley = value
        End Set
    End Property
End Class
