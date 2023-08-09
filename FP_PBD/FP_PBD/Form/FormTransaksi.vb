Imports System.Data.Odbc
Public Class FormTransaksi
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
            With DGTransaksi.Rows(br)
                txtId.Text = .Cells(0).Value.ToString
                cmbStatus.Text = .Cells(1).Value.ToString
                DateTimePicker1.Text = .Cells(2).Value.ToString
                txtWaktu.Text = .Cells(3).Value.ToString
                cmbPelanggan.Text = .Cells(5).Value.ToString
                cmbAlat.Text = .Cells(6).Value.ToString
            End With
        End If
    End Sub

    Sub TampilJenis()
        CMD = New OdbcCommand("select id_alat from alat_berat", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        cmbAlat.Items.Clear()
        Do While DTR.Read
            cmbAlat.Items.Add(DTR.Item("id_alat"))
        Loop
        BUKAKONEKSI.Close()

    End Sub
    Sub TampilNama()
        CMD = New OdbcCommand("select id_pelanggan from pelanggan", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        cmbPelanggan.Items.Clear()
        Do While DTR.Read
            cmbPelanggan.Items.Add(DTR.Item("id_pelanggan"))
        Loop
        BUKAKONEKSI.Close()
    End Sub
    Private Sub RefreshGrid()
        DTGrid = CtlTrans.tampilData.ToTable
        DGTransaksi.DataSource = DTGrid
        modeProses = 0

        If DTGrid.Rows.Count - 1 Then
            baris = DTGrid.Rows.Count - 1
            DGTransaksi.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGTransaksi.CurrentCell = DGTransaksi.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        TampilNama()
        TampilJenis()
        txtId.Enabled = False
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = CtlTrans.cariData(kunci).ToTable
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGTransaksi.DataSource = DTGrid
            DGTransaksi.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGTransaksi.CurrentCell = DGTransaksi.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub DGTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTransaksi.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGTransaksi.Rows(baris).Selected = True
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

    Private Sub CmbAlat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlat.SelectedIndexChanged
        CMD = New OdbcCommand("select * from alat_berat where id_alat='" & cmbAlat.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtAlat.Text = DTR.Item("nama_alat")
        Else
            MsgBox("Alat berat yang dipilih tidak tersedia")
        End If
    End Sub

    Private Sub CmbPelanggan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPelanggan.SelectedIndexChanged
        CMD = New OdbcCommand("select * from pelanggan where id_pelanggan='" & cmbPelanggan.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtNama.Text = DTR.Item("nama_pelanggan")
        Else
            MsgBox("Pelanggan tersebut tidak terdaftar")
        End If
    End Sub

    Private Sub btnTambah_Click_1(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        Dim c = New ClsCtlTransaksi
        modeProses = 1
        txtNama.Text = ""
        DateTimePicker1.Refresh()
        cmbAlat.Enabled = True
        cmbPelanggan.Enabled = True
        cmbStatus.Enabled = True
        cmbStatus.Refresh()
        DateTimePicker1.Enabled = True
        txtWaktu.Enabled = True
        txtWaktu.Text = ""
        txtAlat.Text = ""
        txtId.Text = c.kodebaru()
        txtNama.Focus()
    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturButton(False)
        modeProses = 2
        cmbStatus.Enabled = True
        txtNama.Focus()
    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        RefreshGrid()
        AturButton(True)
        cmbStatus.Enabled = False
        modeProses = 0
    End Sub

    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntTrans
            .IdTrans = txtId.Text
            .StatusSewa = cmbStatus.Text
            .Tanggal = DateTimePicker1.Value.ToString
            .IdAdmin = IDLOGIN
            .IdPelanggan = cmbPelanggan.Text
            .IdAlat = cmbAlat.Text
            .Waktu = txtWaktu.Text
        End With

        If modeProses = 1 Then
            CtlTrans.TambahData(EntTrans)
        ElseIf modeProses = 2 Then
            CtlTrans.updateData(EntTrans)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")
        RefreshGrid()
    End Sub

    Private Sub btnHapus_Click_1(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("apakah anda yakin akan menghapus " & txtId.Text & "-" & txtNama.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            CtlTrans.hapusData(txtId.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        MenuUtama.Show()
    End Sub
End Class