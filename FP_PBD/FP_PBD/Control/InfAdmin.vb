Imports System.Data.Odbc

Public Interface InfAdmin
    Function updateData(Ob As Object) As OdbcCommand
    Function tampilData() As DataView

End Interface
