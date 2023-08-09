Imports System.Data.Odbc
Module ModKoneksi
    Public DTR As OdbcDataReader
    Public CMD As New OdbcCommand
    Public DTA As New OdbcDataAdapter
    Public DTS As New DataSet
    Public DTT As New DataTable
    Public DTGrid As New DataTable
    Public strKon = "Driver={MySQL ODBC 8.0 ANSI Driver};Database=fp_pbd;server:localhost;uid=root"
    Public koneksi As New OdbcConnection(strKon)

    Public Function BUKAKONEKSI() As OdbcConnection
        Try
            If koneksi.State = ConnectionState.Closed Then koneksi.Open()
        Catch ex As Exception

        End Try
        Return koneksi
    End Function
    Public Function TUTUPKONEKSI() As OdbcConnection
        koneksi.Close()
        Return koneksi
    End Function
End Module
