Public Class EntSolicitudes
    'Campos - variables
    Private IdSolicitud As Integer
    Private Idusuario As Integer
    Private NumSolicitud As Integer
    Private ApellidosNombres As String
    Private DNI As String
    Private Celular As String
    Private Direccion As String
    Private TipoDocumento As String
    Private Copias As String
    Private Estado As String
    Private FechaRegistro As Date

    'Propiedades
    Public Property gIdSolicitud As Integer
        Get
            Return IdSolicitud
        End Get
        Set(value As Integer)
            IdSolicitud = value
        End Set
    End Property
    Public Property gNumSolicitud As Integer
        Get
            Return NumSolicitud
        End Get
        Set(value As Integer)
            NumSolicitud = value
        End Set
    End Property

    Public Property gIdUsuario As Integer
        Get
            Return Idusuario
        End Get
        Set(value As Integer)
            Idusuario = value
        End Set
    End Property

    Public Property gApellidosNombres As String
        Get
            Return ApellidosNombres
        End Get
        Set(value As String)
            ApellidosNombres = value
        End Set
    End Property

    Public Property gDNI As String
        Get
            Return DNI
        End Get
        Set(value As String)
            DNI = value
        End Set
    End Property

    Public Property gCelular As String
        Get
            Return Celular
        End Get
        Set(value As String)
            Celular = value
        End Set
    End Property

    Public Property gDireccion As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property

    Public Property gTipoDocumento As String
        Get
            Return TipoDocumento
        End Get
        Set(value As String)
            TipoDocumento = value
        End Set
    End Property

    Public Property gCopias As String
        Get
            Return Copias
        End Get
        Set(value As String)
            Copias = value
        End Set
    End Property

    Public Property gEstado As String
        Get
            Return Estado
        End Get
        Set(value As String)
            Estado = value
        End Set
    End Property

    Public Property gFechaRegistro As Date
        Get
            Return FechaRegistro
        End Get
        Set(value As Date)
            FechaRegistro = value
        End Set
    End Property

    'Constructores
    Public Sub New()

    End Sub
    Public Sub New(ByVal IdSolicitud As Integer, ByVal NumSolicitud As String, ByVal IdUsuario As Integer, ByVal Nombres As String,
                   ByVal ApellidosNombres As String, ByVal DNI As String, ByVal Celular As String,
                   ByVal Direccion As String, ByVal TipoDocumento As String, ByVal Copias As String,
                   ByVal Estado As String, ByVal FechaRegistro As Date)

        gIdSolicitud = IdSolicitud
        gNumSolicitud = NumSolicitud
        gIdusuario = IdUsuario
        gApellidosNombres = ApellidosNombres
        gDNI = DNI
        gCelular = Celular
        gDireccion = Direccion
        gTipoDocumento = TipoDocumento
        gCopias = Copias
        gEstado = Estado
        gFechaRegistro = FechaRegistro
    End Sub
End Class
