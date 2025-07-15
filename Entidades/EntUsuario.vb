Public Class EntUsuario
    'Campos - Variables
    Private IdUsuario As Integer
    Private Nombres As String
    Private ApellidoPaterno As String
    Private ApellidoMaterno As String
    Private DNI As String
    Private Sexo As String
    Private Usuario As String
    Private Contraseña As String
    Private Rol As String
    Private Area As String
    Private Activo As String
    Private FechaRegistro As Date

    'Propiedades
    Public Property gIdUsuario As Integer
        Get
            Return IdUsuario
        End Get
        Set(value As Integer)
            IdUsuario = value
        End Set
    End Property

    Public Property gNombres As String
        Get
            Return Nombres
        End Get
        Set(value As String)
            Nombres = value
        End Set
    End Property

    Public Property gApellidoPaterno As String
        Get
            Return ApellidoPaterno
        End Get
        Set(value As String)
            ApellidoPaterno = value
        End Set
    End Property

    Public Property gApellidoMaterno As String
        Get
            Return ApellidoMaterno
        End Get
        Set(value As String)
            ApellidoMaterno = value
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
    Public Property gSexo As String
        Get
            Return Sexo
        End Get
        Set(value As String)
            Sexo = value
        End Set
    End Property

    Public Property gUsuario As String
        Get
            Return Usuario
        End Get
        Set(value As String)
            Usuario = value
        End Set
    End Property

    Public Property gContraseña As String
        Get
            Return Contraseña
        End Get
        Set(value As String)
            Contraseña = value
        End Set
    End Property

    Public Property gRol As String
        Get
            Return Rol
        End Get
        Set(value As String)
            Rol = value
        End Set
    End Property
    Public Property gArea As String
        Get
            Return Area
        End Get
        Set(value As String)
            Area = value
        End Set
    End Property

    Public Property gActivo As String
        Get
            Return Activo
        End Get
        Set(value As String)
            Activo = value
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
    Public Sub New(ByVal IdUsuario As Integer, ByVal Nombres As String, ByVal ApellidoPaterno As String,
                   ByVal ApellidoMaterno As String, ByVal DNI As String, ByVal Sexo As String, ByVal Usuario As String,
                   ByVal Contraseña As String, ByVal Rol As String, ByVal Area As String, ByVal Activo As String,
                   ByVal FechaRegistro As Date)
        gIdUsuario = IdUsuario
        gNombres = Nombres
        gApellidoPaterno = ApellidoPaterno
        gApellidoMaterno = ApellidoMaterno
        gDNI = DNI
        gSexo = Sexo
        gUsuario = Usuario
        gContraseña = Contraseña
        gRol = Rol
        gArea = Area
        gActivo = Activo
        gFechaRegistro = FechaRegistro

    End Sub
End Class
