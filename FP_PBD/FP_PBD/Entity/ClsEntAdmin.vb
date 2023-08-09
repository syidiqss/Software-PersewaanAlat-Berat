Public Class ClsEntAdmin
    Private _idAdmin As String
    Private _nama As String
    Private _user As String
    Private _pass As String
    Private _email As String

    Public Property IdAdmin As String
        Get
            Return _idAdmin
        End Get
        Set(value As String)
            _idAdmin = value
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

    Public Property User As String
        Get
            Return _user
        End Get
        Set(value As String)
            _user = value
        End Set
    End Property

    Public Property Pass As String
        Get
            Return _pass
        End Get
        Set(value As String)
            _pass = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
End Class
