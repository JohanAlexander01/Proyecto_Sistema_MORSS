Public Class EntPagos
    Private IdPago As Integer
    Private IdSolicitud As Integer
    Private Monto As Decimal
    Private NumVoucher As String
    Private FechaPago As Date
    Private MontoCopias As Decimal
    Private NumVoucherCopias As String
    Private FechaPagoCopias As Date


    Public Property gIdPago As Integer
        Get
            Return IdPago
        End Get
        Set(value As Integer)
            IdPago = value
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

    Public Property gMonto As Decimal
        Get
            Return Monto
        End Get
        Set(value As Decimal)
            Monto = value
        End Set
    End Property

    Public Property gNumVoucher As String
        Get
            Return NumVoucher
        End Get
        Set(value As String)
            NumVoucher = value
        End Set
    End Property

    Public Property gFechaPago As Date
        Get
            Return FechaPago
        End Get
        Set(value As Date)
            FechaPago = value
        End Set
    End Property
    Public Property gMontoCopias As Decimal
        Get
            Return MontoCopias
        End Get
        Set(value As Decimal)
            MontoCopias = value
        End Set
    End Property
    Public Property gNumVoucherCopias As String
        Get
            Return NumVoucherCopias
        End Get
        Set(value As String)
            NumVoucherCopias = value
        End Set
    End Property
    Public Property gFechaPagoCopias As Date
        Get
            Return FechaPagoCopias
        End Get
        Set(value As Date)
            FechaPagoCopias = value
        End Set
    End Property

    ' constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal IdPago As Integer, ByVal IdSolicitud As Integer, ByVal Monto As Decimal,
                  ByVal NumVoucher As String, ByVal FechaPago As Date, ByVal MontoCopias As Decimal,
                   ByVal NumVoucherCopias As String, ByVal FechaPagoCopias As Date)

        gIdPago = IdPago
        gIdSolicitud = IdSolicitud
        gMonto = Monto
        gNumVoucher = NumVoucher
        gFechaPago = FechaPago
        gMontoCopias = MontoCopias
        gNumVoucherCopias = NumVoucherCopias
        gFechaPagoCopias = FechaPagoCopias
    End Sub
End Class
