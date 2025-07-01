Public Class EntResultadoBusqueda
    Private IdResultado As Integer
    Private IdSolicitud As Integer
    Private Estado As String
    Private NumFojas As String

    Public Property gIdResultado As Integer
        Get
            Return IdResultado
        End Get
        Set(value As Integer)
            IdResultado = value
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

    Public Property gNumFojas As String
        Get
            Return NumFojas
        End Get
        Set(value As String)
            NumFojas = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal IdResultado As Integer, ByVal IdSolicitud As String, ByVal Estado As String,
                   ByVal NumFojas As Integer)
        gIdResultado = IdResultado
        gIdSolicitud = IdSolicitud
        gEstado = Estado
        gNumFojas = NumFojas

    End Sub
End Class
