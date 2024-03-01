Public Class eFlujoMtvoLlamado

    Private _IdRealiza As Int64
    Private _CmdDescripcion As String
    Private _CodigoCampaña As String
    Private _activo As Boolean

    Public Sub New()
        IdRealiza = 0
        CmdDescripcion = ""
        CodigoCampaña = ""
        activo = False

    End Sub

    Public Property IdRealiza() As Int32
        Get
            Return _IdRealiza
        End Get
        Set(ByVal value As Int32)
            _IdRealiza = value
        End Set
    End Property

    Public Property CmdDescripcion() As String
        Get
            Return _CmdDescripcion
        End Get
        Set(ByVal value As String)
            _CmdDescripcion = value
        End Set
    End Property

    Public Property CodigoCampaña() As String
        Get
            Return _CodigoCampaña
        End Get
        Set(ByVal value As String)
            _CodigoCampaña = value
        End Set
    End Property

    Public Property activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property
End Class
