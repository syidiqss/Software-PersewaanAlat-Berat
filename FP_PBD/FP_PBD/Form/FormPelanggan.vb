Public Class FormPelanggan
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
            With DGPelanggan.Rows(br)
                txtId.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                TxtAlamat.Text = .Cells(2).Value.ToString
                txtNohp.Text = .Cells(3).Value.ToString
            End With
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = CtlPelanggan.tampilData.ToTable
        DGPelanggan.DataSource = DTGrid
        modeProses = 0

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPelanggan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPelanggan.CurrentCell = DGPelanggan.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        txtId.Enabled = False

    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = CtlPelanggan.cariData(kunci).ToTable
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPelanggan.DataSource = DTGrid
            DGPelanggan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPelanggan.CurrentCell = DGPelanggan.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub DGCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPelanggan.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGPelanggan.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub

    Private Sub btnTambah_Click_1(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        Dim c = New ClsCtlPelanggan
        modeProses = 1
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtNohp.Text = ""
        txtId.Text = c.kodebaru()
        txtNama.Focus()
    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturButton(False)
        modeProses = 2
        txtNama.Focus()
    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntPelanggan
            .IdPelanggan = txtId.Text
            .NamaPelanggan = txtNama.Text
            .AlamatPelanggan = txtAlamat.Text
            .NoHP = txtNohp.Text
        End With

        If modeProses = 1 Then
            CtlPelanggan.TambahData(EntPelanggan)
        ElseIf modeProses = 2 Then
            CtlPelanggan.updateData(EntPelanggan)
        End If
        MsgBox("data telah disimpan", MsgBoxStyle.Information, "info")
        RefreshGrid()
    End Sub

    Private Sub btnHapus_Click_1(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("apakah anda yakin akan menghapus " & txtId.Text & "-" & txtNama.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            CtlPelanggan.hapusData(txtId.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        MenuUtama.Show()
    End Sub
End Class