Public Class EntAtendidoArchivado
    Private Id As Integer
    Private IdSolicitud As Integer
    Private Estado As String
    Private FechaAtendidoArchivado As Date

    Public Property gId As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
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

    Public Property gEstado As String
        Get
            Return Estado
        End Get
        Set(value As String)
            Estado = value
        End Set
    End Property
    Public Property gFechaAtendidoArchivado As String
        Get
            Return FechaAtendidoArchivado
        End Get
        Set(value As String)
            FechaAtendidoArchivado = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal Id As Integer, ByVal IdSolicitud As Integer, ByVal Estado As String,
                   ByVal FechaAtendidoArchivado As Integer)
        gId = Id
        gIdSolicitud = IdSolicitud
        gEstado = Estado
        gFechaAtendidoArchivado = FechaAtendidoArchivado

    End Sub
End Class
