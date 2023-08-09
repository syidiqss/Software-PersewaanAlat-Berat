Public Class ClsEntAlat
    Private _idAlat As String
    Private _nama As String
    Private _harga As String
    Private _idJenis As String

    Public Property IdAlat As String
        Get
            Return _idAlat
        End Get
        Set(value As String)
            _idAlat = value
        End Set
    End Property

    Public Property Nama As String
        Get
            Return _nama
        End Get
        Set(value As String)
            _nama = value
        End Set
    End Property

    Public Property Harga As String
        Get
            Return _harga
        End Get
        Set(value As String)
            _harga = value
        End Set
    End Property

    Public Property IdJenis As String
        Get
            Return _idJenis
        End Get
        Set(value As String)
            _idJenis = value
        End Set
    End Property
End Class
