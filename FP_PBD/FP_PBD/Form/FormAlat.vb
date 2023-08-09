Imports System.Data.Odbc
Public Class FormAlat
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnEdit.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnReset.Enabled = Not st
        GroupBox1.Enabled = st
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGAlat.Rows(br)
                txtId.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtHarga.Text = .Cells(2).Value.ToString
                cmbJenis.Text = .Cells(3).Value.ToString
            End With
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = CtlAlat.tampilData.ToTable
        DGAlat.DataSource = DTGrid
        modeProses = 0

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGAlat.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGAlat.CurrentCell = DGAlat.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub FormAlat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        TampilJenis()
        txtId.Enabled = False

    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = CtlAlat.cariData(kunci).ToTable
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGAlat.DataSource = DTGrid
            DGAlat.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGAlat.CurrentCell = DGAlat.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub DGAlat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAlat.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGAlat.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnCari_Click_1(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub

    Sub TampilJenis()
        CMD = New OdbcCommand("select id_jenis from jenis_alat", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        cmbJenis.Items.Clear()
        Do While DTR.Read
            cmbJenis.Items.Add(DTR.Item("id_jenis"))
        Loop
        BUKAKONEKSI.Close()
    End Sub

    Private Sub cmbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenis.SelectedIndexChanged
        CMD = New OdbcCommand("select * from jenis_alat where id_jenis='" & cmbJenis.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtJenis.Text = DTR.Item("nama_jenis")
        Else
            MsgBox("Jenis alat tersebut tidak ada")
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        MenuUtama.Show()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        Dim c = New ClsCtlAlat
        modeProses = 1
        txtNama.Text = ""
        cmbJenis.Text = ""
        txtHarga.Text = ""
        txtId.Text = c.kodebaru()
        txtNama.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturButton(False)
        modeProses = 2
        txtNama.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntAlat
            .IdAlat = txtId.Text
            .Nama = txtNama.Text
            .IdJenis = cmbJenis.SelectedItem.ToString
            .Harga = txtHarga.Text
        End With

        If modeProses = 1 Then
            CtlAlat.TambahData(EntAlat)
        ElseIf modeProses = 2 Then
            CtlAlat.updateData(EntAlat)
        End If
        MsgBox("data telah disimpan", MsgBoxStyle.Information, "info")
        RefreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("apakah anda yakin akan menghapus " & txtId.Text & "-" & txtNama.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            CtlAlat.hapusData(txtId.Text)
        End If
        RefreshGrid()
    End Sub
End Class