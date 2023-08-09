Public Class ClsEntJenis
    Private _idJenis As String
    Private _nama As String

    Public Property IdJenis As String
        Get
            Return _idJenis
        End Get
        Set(value As String)
            _idJenis = value
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
End Class
