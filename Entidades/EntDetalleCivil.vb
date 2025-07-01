Public Class EntDetalleCivil
    'campos - variables
    Private IdDetalle As Integer
    Private IdSolicitud As Integer
    Private TipoPartida As String
    Private Provincia As String
    Private Distrito As String
    Private Interesado As String
    Private FechaPartida As Date

    'propiedades
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

    Public Property gTipoPartida As String
        Get
            Return TipoPartida
        End Get
        Set(value As String)
            TipoPartida = value
        End Set
    End Property

    Public Property gProvincia As String
        Get
            Return Provincia
        End Get
        Set(value As String)
            Provincia = value
        End Set
    End Property

    Public Property gDistrito As String
        Get
            Return Distrito
        End Get
        Set(value As String)
            Distrito = value
        End Set
    End Property

    Public Property gInteresado As String
        Get
            Return Interesado
        End Get
        Set(value As String)
            Interesado = value
        End Set
    End Property

    Public Property gFechaPartida As Date
        Get
            Return FechaPartida
        End Get
        Set(value As Date)
            FechaPartida = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub
    Public Sub New(ByVal IdDetalle As Integer, ByVal IdSolicitud As Integer, ByVal TipoPartida As String,
                  ByVal Provincia As String, ByVal Distrito As String, ByVal Interesado As String,
                  ByVal FechaPartida As Date)

        gIdDetalle = IdDetalle
        gIdSolicitud = IdSolicitud
        gTipoPartida = TipoPartida
        gProvincia = Provincia
        gDistrito = Distrito
        gInteresado = Interesado
        gFechaPartida = FechaPartida
    End Sub
End Class
