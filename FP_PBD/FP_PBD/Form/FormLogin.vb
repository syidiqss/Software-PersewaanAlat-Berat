Public Class FormLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        DTGrid = CtlLogin.login(txtUsername.Text).ToTable
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("Silahkan isikan username dan password anda")
        ElseIf txtUsername.Text = "" Then
            MsgBox("Silahkan isikan username anda")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Silahkan isikan password anda")
        Else
            If DTGrid.Rows.Count > 0 Then
                EntLog.IdAdmin = DTGrid.Rows(0).Item(0)
                EntLog.User = DTGrid.Rows(0).Item(1)
                EntLog.Pass = DTGrid.Rows(0).Item(2)
                EntLog.Email = DTGrid.Rows(0).Item(3)

                IDLOGIN = EntLog.IdAdmin
                NAMALOGIN = EntLog.User

                If txtPassword.Text = EntLog.Pass Then
                    MenuUtama.Show()
                    txtPassword.Text = ""
                    txtUsername.Text = ""
                    Me.Hide()
                Else
                    MessageBox.Show("PASSWORD SALAH!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Text = ""
                    txtUsername.Focus()
                End If
            Else
                MessageBox.Show("ID tidak dikenal!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtUsername.Text = ""
                txtUsername.Focus()
            End If
        End If
    End Sub

    Private Sub TxtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        txtUsername.Text = ""
    End Sub

    Private Sub TxtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        txtPassword.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            CheckBox1.Checked = False
            txtPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.PasswordChar = "*"
    End Sub
End Class
