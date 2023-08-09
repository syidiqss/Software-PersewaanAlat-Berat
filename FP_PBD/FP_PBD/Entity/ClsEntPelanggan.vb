Public Class ClsEntPelanggan
    Private _idPelanggan As String
    Private _namaPelanggan As String
    Private _alamatPelanggan As String
    Private _noHp As String

    Public Property IdPelanggan As String
        Get
            Return _idPelanggan
        End Get
        Set(value As String)
            _idPelanggan = value
        End Set
    End Property

    Public Property NamaPelanggan As String
        Get
            Return _namaPelanggan
        End Get
        Set(value As String)
            _namaPelanggan = value
        End Set
    End Property

    Public Property AlamatPelanggan As String
        Get
            Return _alamatPelanggan
        End Get
        Set(value As String)
            _alamatPelanggan = value
        End Set
    End Property

    Public Property NoHP As String
        Get
            Return _noHp
        End Get
        Set(value As String)
            _noHp = value
        End Set
    End Property
End Class
