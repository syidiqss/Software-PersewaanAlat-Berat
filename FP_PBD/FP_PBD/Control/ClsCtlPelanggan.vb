Imports System.Data.Odbc
Public Class ClsCtlPelanggan : Implements InfProses
    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_pelanggan,3)) from pelanggan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "P0" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function TambahData(Ob As Object) As OdbcCommand Implements InfProses.TambahData
        Dim data As New ClsEntPelanggan
        data = Ob
        CMD = New OdbcCommand("insert into pelanggan values('" & data.IdPelanggan & "','" & data.NamaPelanggan & "','" & data.AlamatPelanggan & "','" & data.NoHP & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntPelanggan
        data = Ob
        CMD = New OdbcCommand("update pelanggan set nama_pelanggan ='" & data.NamaPelanggan & "', alamat_pelanggan ='" & data.AlamatPelanggan & "', nohp_pelanggan ='" & data.NoHP & "' where id_pelanggan='" & data.IdPelanggan & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function hapusData(kunci As String) As OdbcCommand Implements InfProses.hapusData
        CMD = New OdbcCommand("delete from pelanggan " & "where id_pelanggan='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from pelanggan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_pelanggan")
            Dim grid As New DataView(DTS.Tables("Tabel_pelanggan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("Select * from pelanggan where nama_pelanggan " & " like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cari_pelanggan")
            Dim grid As New DataView(DTS.Tables("cari_pelanggan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
