Public Class eAseguradora

    Private _idCompania As Int64
    Private _Nombre As String

    Public Sub New()
        idCompania = 0
        Nombre = ""
    End Sub

    Public Property idCompania() As Int32
        Get
            Return _idCompania
        End Get
        Set(ByVal value As Int32)
            _idCompania = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
End Class
