Imports Entidad

Public Class eProyecto

    Private _idCRM As Int32
    Private _nombre As String
    Private _codigo As String
    Private _idtipoCampania As Int32
    Private _adicionales As Boolean
    Private _beneficiarios As Boolean
    Private _medioPago As Boolean
    Private _servidorBDD As String
    Private _idTelefonia As Integer
    Private _rutCompleto As Boolean
    Private _servidorTelefonia As String
    Private _validaRut As Boolean
    Private _restriccionPlan As Boolean
    Private _noContacto1Intento As Boolean
    Private _validacionCalidadTO As Boolean
    Private _estadoLLamada As Boolean
    Private _tomaPaisProfesion As Boolean
    Private _ConWhatsapp As Boolean
    Public Sub New(idCRM As Integer, nombre As String, codigo As String, idtipoCampania As Integer, adicionales As Boolean, beneficiarios As Boolean, medioPago As Boolean, servidorBDD As String, idTelefonia As Integer, rutcompleto As Boolean, servidorTelefonia As String, validaRut As Boolean, restriccionPlan As Boolean, noContacto1Intento As Boolean, validacionCalidadTO As Boolean, estadoLLamada As Boolean, tomaPaisProfesion As Boolean, ConWhatsapp As Boolean)
        _idCRM = idCRM
        _nombre = nombre
        _codigo = codigo
        _idtipoCampania = idtipoCampania
        _adicionales = adicionales
        _beneficiarios = beneficiarios
        _medioPago = medioPago
        Me.ServidorBDD = servidorBDD
        Me.IdTelefonia = idTelefonia
        _rutCompleto = rutcompleto
        _servidorTelefonia = servidorTelefonia
        _validaRut = validaRut
        _restriccionPlan = restriccionPlan
        _noContacto1Intento = noContacto1Intento
        _validacionCalidadTO = validacionCalidadTO
        _estadoLLamada = estadoLLamada
        _tomaPaisProfesion = tomaPaisProfesion
        _ConWhatsapp = ConWhatsapp

    End Sub

    Public Sub New()
        _idCRM = 0
        _nombre = ""
        _codigo = ""
        _idtipoCampania = 0
        _adicionales = False
        _beneficiarios = False
        _medioPago = False
        Me.ServidorBDD = ""
        Me.IdTelefonia = 0
        _rutCompleto = False
        _servidorTelefonia = ""
        _validaRut = False
        _restriccionPlan = False
        _noContacto1Intento = False
        _validacionCalidadTO = False
        _estadoLLamada = False
        _tomaPaisProfesion = False
        _ConWhatsapp = False

    End Sub


    Public Property idCRM() As Int32
        Get
            Return _idCRM
        End Get
        Set(ByVal value As Int32)
            _idCRM = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property codigo() As String

        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property



    Public Property idtipoCampania() As Int32
        Get
            Return _idtipoCampania
        End Get
        Set(ByVal value As Int32)
            _idtipoCampania = value
        End Set
    End Property

    Public Property adicionales() As Boolean
        Get
            Return _adicionales
        End Get
        Set(ByVal value As Boolean)
            _adicionales = value
        End Set
    End Property

    Public Property beneficiarios() As Boolean
        Get
            Return _beneficiarios
        End Get
        Set(ByVal value As Boolean)
            _beneficiarios = value
        End Set
    End Property

    Public Property medioPago() As Boolean
        Get
            Return _medioPago
        End Get
        Set(ByVal value As Boolean)
            _medioPago = value
        End Set
    End Property

    Public Property ServidorBDD As String
        Get
            Return _servidorBDD
        End Get
        Set(value As String)
            _servidorBDD = value
        End Set
    End Property

    Public Property IdTelefonia As Integer
        Get
            Return _idTelefonia
        End Get
        Set(value As Integer)
            _idTelefonia = value
        End Set
    End Property

    Public Property RutCompleto As Boolean
        Get
            Return _rutCompleto
        End Get
        Set(value As Boolean)
            _rutCompleto = value
        End Set
    End Property

    Public Property ServidorTelefonia As String
        Get
            Return _servidorTelefonia
        End Get
        Set(value As String)
            _servidorTelefonia = value
        End Set
    End Property

    Public Property validaRut() As Boolean
        Get
            Return _validaRut
        End Get
        Set(ByVal value As Boolean)
            _validaRut = value
        End Set
    End Property

    Public Property restriccionPlan() As Boolean
        Get
            Return _restriccionPlan
        End Get
        Set(ByVal value As Boolean)
            _restriccionPlan = value
        End Set
    End Property

    Public Property noContacto1Intento() As Boolean
        Get
            Return _noContacto1Intento
        End Get
        Set(ByVal value As Boolean)
            _noContacto1Intento = value
        End Set
    End Property

    Public Property ValidacionCalidadTO As Boolean
        Get
            Return _validacionCalidadTO
        End Get
        Set(value As Boolean)
            _validacionCalidadTO = value
        End Set
    End Property

    Public Property estadoLlamada As Boolean
        Get
            Return _estadoLLamada
        End Get
        Set(value As Boolean)
            _estadoLLamada = value
        End Set
    End Property

    Public Property TomaPaisProfesion As Boolean
        Get
            Return _tomaPaisProfesion
        End Get
        Set(value As Boolean)
            _tomaPaisProfesion = value
        End Set
    End Property

    Public Property ConWhatsapp As Boolean
        Get
            Return _ConWhatsapp
        End Get
        Set(value As Boolean)
            _ConWhatsapp = value
        End Set
    End Property
End Class
