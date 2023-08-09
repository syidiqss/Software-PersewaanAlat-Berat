Imports System.Data.Odbc
Public Class ClsCtlJenis : Implements InfProses
    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_jenis,3)) from jenis_alat", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "JA" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function TambahData(Ob As Object) As OdbcCommand Implements InfProses.TambahData
        Dim data As New ClsEntJenis
        data = Ob
        CMD = New OdbcCommand("insert into jenis_alat values('" & data.IdJenis & "','" & data.Nama & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntJenis
        data = Ob
        CMD = New OdbcCommand("update jenis_alat set nama_jenis ='" & data.Nama & "' where id_jenis='" & data.IdJenis & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function hapusData(kunci As String) As OdbcCommand Implements InfProses.hapusData
        CMD = New OdbcCommand("delete from jenis_alat " & "where id_jenis='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from jenis_alat", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_jenis_alat")
            Dim grid As New DataView(DTS.Tables("Tabel_jenis_alat"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("Select * from jenis_alat where nama_jenis " & " like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cari_jenis_alat")
            Dim grid As New DataView(DTS.Tables("cari_jenis_alat"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
