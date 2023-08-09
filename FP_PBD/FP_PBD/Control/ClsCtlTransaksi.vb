Imports System.Data.Odbc
Public Class ClsCtlTransaksi : Implements InfProses
    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_transaksi,3)) from transaksi", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "TR" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function TambahData(Ob As Object) As OdbcCommand Implements InfProses.TambahData
        Dim data As New ClsEntTransaksi
        data = Ob
        CMD = New OdbcCommand("insert into transaksi values('" & data.IdTrans & "','" & data.StatusSewa & "',current_timestamp(),'" & data.Waktu & "','" & data.IdAdmin & "','" & data.IdPelanggan & "','" & data.IdAlat & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntTransaksi
        data = Ob
        CMD = New OdbcCommand("update transaksi set status_transaksi ='" & data.StatusSewa & "', tanggal =current_timestamp(), waktu ='" & data.Waktu & "', id_admin = '" & data.IdAdmin & "', id_alat = '" & data.IdAlat & "' where id_transaksi='" & data.IdTrans & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function hapusData(kunci As String) As OdbcCommand Implements InfProses.hapusData
        CMD = New OdbcCommand("delete from transaksi " & "where id_transaksi='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from transaksi", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_transaksi")
            Dim grid As New DataView(DTS.Tables("Tabel_transaksi"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("Select * from transaksi where id_transaksi " & " like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cari_transaksi")
            Dim grid As New DataView(DTS.Tables("cari_transaksi"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
