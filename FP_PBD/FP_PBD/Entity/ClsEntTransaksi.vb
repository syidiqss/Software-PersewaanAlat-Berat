Public Class ClsEntTransaksi
    Private _idTrans As String
    Private _idPelanggan As String
    Private _idAlat As String
    Private _idAdmin As String
    Private _waktu As String
    Private _tanggal As String
    Private _statusSewa As String

    Public Property IdTrans As String
        Get
            Return _idTrans
        End Get
        Set(value As String)
            _idTrans = value
        End Set
    End Property

    Public Property IdPelanggan As String
        Get
            Return _idPelanggan
        End Get
        Set(value As String)
            _idPelanggan = value
        End Set
    End Property

    Public Property IdAlat As String
        Get
            Return _idAlat
        End Get
        Set(value As String)
            _idAlat = value
        End Set
    End Property

    Public Property IdAdmin As String
        Get
            Return _idAdmin
        End Get
        Set(value As String)
            _idAdmin = value
        End Set
    End Property

    Public Property Waktu As String
        Get
            Return _waktu
        End Get
        Set(value As String)
            _waktu = value
        End Set
    End Property

    Public Property StatusSewa As String
        Get
            Return _statusSewa
        End Get
        Set(value As String)
            _statusSewa = value
        End Set
    End Property

    Public Property Tanggal As String
        Get
            Return _tanggal
        End Get
        Set(value As String)
            _tanggal = value
        End Set
    End Property
End Class
