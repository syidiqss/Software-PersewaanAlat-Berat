Imports System.Data.Odbc
Public Class ClsCtlAlat : Implements InfProses
    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_alat,3)) from alat_berat", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "AB" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function TambahData(Ob As Object) As OdbcCommand Implements InfProses.TambahData
        Dim data As New ClsEntAlat
        data = Ob
        CMD = New OdbcCommand("insert into alat_berat values('" & data.IdAlat & "','" & data.Nama & "','" & data.Harga & "','" & data.IdJenis & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntAlat
        data = Ob
        CMD = New OdbcCommand("update alat_berat set nama_alat ='" & data.Nama & "', harga ='" & data.Harga & "', id_jenis = '" & data.IdJenis & "' where id_alat='" & data.IdAlat & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function hapusData(kunci As String) As OdbcCommand Implements InfProses.hapusData
        CMD = New OdbcCommand("delete from alat_berat " & "where id_alat='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from alat_berat", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_alat_berat")
            Dim grid As New DataView(DTS.Tables("Tabel_alat_berat"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("Select * from alat_berat where nama_alat " & " like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cari_alat_berat")
            Dim grid As New DataView(DTS.Tables("cari_alat_berat"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
