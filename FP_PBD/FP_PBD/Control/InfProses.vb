Imports System.Data.Odbc

Public Interface InfProses
    Function TambahData(Ob As Object) As OdbcCommand
    Function updateData(Ob As Object) As OdbcCommand
    Function hapusData(kunci As String) As OdbcCommand
    Function tampilData() As DataView
    Function cariData(kunci As String) As DataView

End Interface
