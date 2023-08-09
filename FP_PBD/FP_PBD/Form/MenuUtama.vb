Public Class MenuUtama
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = NAMALOGIN
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Apakah anda yakin untuk Log Out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            Me.Close()
            FormLogin.Show()
        End If
    End Sub

    Private Sub btnPengaturan_Click(sender As Object, e As EventArgs) Handles btnPengaturan.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

    Private Sub btnPelanggan_Click(sender As Object, e As EventArgs) Handles btnPelanggan.Click
        Me.Hide()
        FormPelanggan.Show()
    End Sub

    Private Sub btnAlat_Click(sender As Object, e As EventArgs) Handles btnAlat.Click
        Me.Hide()
        FormAlat.Show()
    End Sub

    Private Sub btnJenis_Click(sender As Object, e As EventArgs) Handles btnJenis.Click
        Me.Hide()
        FormJenis.Show()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Me.Hide()
        FormTransaksi.Show()
    End Sub
End Class