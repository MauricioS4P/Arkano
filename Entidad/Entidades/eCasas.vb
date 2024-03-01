Public Class eCasas


    Private _idCasa As Int32
    Private _NombreCasa As String
    Private _IpCasa As String

    Public Property IdCasa As Integer
        Get
            Return _idCasa
        End Get
        Set(value As Integer)
            _idCasa = value
        End Set
    End Property

    Public Property NombreCasa As String
        Get
            Return _NombreCasa
        End Get
        Set(value As String)
            _NombreCasa = value
        End Set
    End Property

    Public Property IpCasa As String
        Get
            Return _IpCasa
        End Get
        Set(value As String)
            _IpCasa = value
        End Set
    End Property
End Class
