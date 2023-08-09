Public Class FormAdmin
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        btnEdit.Enabled = st
        btnReset.Enabled = Not st
        btnSimpan.Enabled = Not st
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGAdmin.Rows(br)
                txtId.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtUsername.Text = .Cells(2).Value.ToString
                txtPassword.Text = .Cells(3).Value.ToString
                txtEmail.Text = .Cells(4).Value.ToString
            End With
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = CtlAdmin.tampilData.ToTable
        DGAdmin.DataSource = DTGrid
        modeProses = 0

        baris = DTGrid.Rows.Count - 1
        DGAdmin.Rows(DTGrid.Rows.Count - 1).Selected = True
        DGAdmin.CurrentCell = DGAdmin.Item(1, baris)
        AturButton(True)
        IsiBox(baris)

    End Sub

    Private Sub DGJenis_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGAdmin.CellMouseClick
        baris = e.RowIndex
        DGAdmin.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub DataSaya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        txtPassword.PasswordChar = "*"
        txtId.Enabled = False
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        AturButton(False)
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        txtNama.Enabled = True
        txtEmail.Enabled = True
        txtUsername.Focus()
        modeProses = 2
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSimpan.Click
        With EntAdmin
            .IdAdmin = txtId.Text
            .Nama = txtNama.Text
            .User = txtUsername.Text
            .Pass = txtPassword.Text
            .Email = txtEmail.Text
        End With

        CtlAdmin.updateData(EntAdmin)

        MsgBox("data telah disimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            CheckBox1.Checked = False
            txtPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        txtNama.Enabled = False
        txtEmail.Enabled = False
        RefreshGrid()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        MenuUtama.Show()
    End Sub
End Class