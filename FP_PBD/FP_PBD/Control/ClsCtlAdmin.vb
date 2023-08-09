Imports System.Data.Odbc
Public Class ClsCtlAdmin : Implements InfAdmin
    Public Function updateData(Ob As Object) As OdbcCommand Implements InfAdmin.updateData
        Dim data As New ClsEntAdmin
        data = Ob
        CMD = New OdbcCommand("Update admin set nama = '" & data.Nama & "', username ='" & data.User & "', pass ='" & data.Pass & "', email = '" & data.Email & "' where id_admin ='" & data.IdAdmin & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfAdmin.tampilData
        Try
            DTA = New OdbcDataAdapter("SELECT * FROM admin where id_admin='" & IDLOGIN & "'", BUKAKONEKSI)

            DTS = New DataSet
            DTA.Fill(DTS, "admin")
            Dim grid As New DataView(DTS.Tables("admin"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
