Imports System.Security.AccessControl

Public Class EntDetalleJudicial
    'campos - variables

    Private IdDetalle As Integer
    Private IdSolicitud As Integer
    Private TipoProceso As String
    Private NumExpediente As String
    Private Materia As String
    Private Demandante As String
    Private Demandado As String

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

    Public Property gTipoProceso As String
        Get
            Return TipoProceso
        End Get
        Set(value As String)
            TipoProceso = value
        End Set
    End Property

    Public Property gNumExpediente As String
        Get
            Return NumExpediente
        End Get
        Set(value As String)
            NumExpediente = value
        End Set
    End Property

    Public Property gMateria As String
        Get
            Return Materia
        End Get
        Set(value As String)
            Materia = value
        End Set
    End Property

    Public Property gDemandante As String
        Get
            Return Demandante
        End Get
        Set(value As String)
            Demandante = value
        End Set
    End Property

    Public Property gDemandado As String
        Get
            Return Demandado
        End Get
        Set(value As String)
            Demandado = value
        End Set
    End Property

    'constructores
    Public Sub New()

    End Sub
    Public Sub New(ByVal IdDetalle As Integer, ByVal IdSolicitud As Integer, ByVal TipoProceso As String,
                   ByVal NumExpediente As String, ByVal Materia As String, ByVal Demandante As String,
                   ByVal Demandado As Date)

        gIdDetalle = IdDetalle
        gIdSolicitud = IdSolicitud
        gTipoProceso = TipoProceso
        gNumExpediente = NumExpediente
        gMateria = Materia
        gDemandante = Demandante
        gDemandado = Demandado
    End Sub
End Class
