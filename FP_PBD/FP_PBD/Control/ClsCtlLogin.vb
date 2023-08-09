Public Class ClsLogin
    Public Function login(username As String) As DataView
        Try
            DTA = New Odbc.OdbcDataAdapter("select  * from admin where USERNAME = '" & username & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Admin")
            Dim grid As New DataView(DTS.Tables("Cari_Admin"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
