Public Class EntDetalleNotarial
    'campos - variables
    Private IdDetalle As Integer
    Private IdSolicitud As Integer
    Private Instrumento As String
    Private ActoProtocolar As String
    Private Notario As String
    Private FechaDocumento As String
    Private OtorgadoPor As String
    Private AFavor As String

    Public Property gIdDetalle As Integer
        Get
            Return IdDetalle
        End Get
        Set(value As Integer)
            IdDetalle = value
        End Set
    End Property

    Public Property gIdSolicitud As Integer
        Get
            Return IdSolicitud
        End Get
        Set(value As Integer)
            IdSolicitud = value
        End Set
    End Property

    Public Property gInstrumento As String
        Get
            Return Instrumento
        End Get
        Set(value As String)
            Instrumento = value
        End Set
    End Property
    Public Property gActoProtocolar As String
        Get
            Return ActoProtocolar
        End Get
        Set(value As String)
            ActoProtocolar = value
        End Set
    End Property

    Public Property gNotario As String
        Get
            Return Notario
        End Get
        Set(value As String)
            Notario = value
        End Set
    End Property

    Public Property gFechaDocumento As String
        Get
            Return FechaDocumento
        End Get
        Set(value As String)
            FechaDocumento = value
        End Set
    End Property

    Public Property gOtorgadoPor As String
        Get
            Return OtorgadoPor
        End Get
        Set(value As String)
            OtorgadoPor = value
        End Set
    End Property

    Public Property gAFavor As String
        Get
            Return AFavor
        End Get
        Set(value As String)
            AFavor = value
        End Set
    End Property

    ' constructores
    Public Sub New()

    End Sub
    Public Sub New(ByVal IdDetalle As Integer, ByVal IdSolicitud As Integer, ByVal Instrumento As String,
                   ByVal ActoProtocolar As String, ByVal Notario As String, ByVal OtorgadoPor As String, ByVal AFavor As String,
                   ByVal FechaDocumento As Date)

        gIdDetalle = IdDetalle
        gIdSolicitud = IdSolicitud
        gInstrumento = Instrumento
        gActoProtocolar = ActoProtocolar
        gNotario = Notario
        gOtorgadoPor = OtorgadoPor
        gAFavor = AFavor
        gFechaDocumento = FechaDocumento

    End Sub
End Class
