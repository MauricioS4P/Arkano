
Public Class eTelefonos

    Private _telefono As String
    Private _datosTelefono As String
    Private _mensaje As String



    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property datosTelefono() As String
        Get
            Return _datosTelefono
        End Get
        Set(ByVal value As String)
            _datosTelefono = value
        End Set
    End Property

    Public Property mensaje() As String
        Get
            Return _mensaje
        End Get
        Set(ByVal value As String)
            _mensaje = value
        End Set
    End Property


End Class
