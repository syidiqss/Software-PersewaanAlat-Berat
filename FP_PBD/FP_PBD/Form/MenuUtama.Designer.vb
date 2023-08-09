<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPelanggan = New System.Windows.Forms.Button()
        Me.btnAlat = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnJenis = New System.Windows.Forms.Button()
        Me.btnPengaturan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Orange
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.Location = New System.Drawing.Point(613, 112)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(113, 43)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "   Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(43, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Selamat Datang, "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(202, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "x"
        '
        'btnPelanggan
        '
        Me.btnPelanggan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPelanggan.BackgroundImage = CType(resources.GetObject("btnPelanggan.BackgroundImage"), System.Drawing.Image)
        Me.btnPelanggan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPelanggan.FlatAppearance.BorderSize = 0
        Me.btnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPelanggan.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPelanggan.ForeColor = System.Drawing.Color.Gray
        Me.btnPelanggan.Image = CType(resources.GetObject("btnPelanggan.Image"), System.Drawing.Image)
        Me.btnPelanggan.Location = New System.Drawing.Point(30, 261)
        Me.btnPelanggan.Name = "btnPelanggan"
        Me.btnPelanggan.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.btnPelanggan.Size = New System.Drawing.Size(162, 160)
        Me.btnPelanggan.TabIndex = 4
        Me.btnPelanggan.Text = "PELANGGAN"
        Me.btnPelanggan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPelanggan.UseVisualStyleBackColor = False
        '
        'btnAlat
        '
        Me.btnAlat.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAlat.BackgroundImage = CType(resources.GetObject("btnAlat.BackgroundImage"), System.Drawing.Image)
        Me.btnAlat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlat.FlatAppearance.BorderSize = 0
        Me.btnAlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlat.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlat.ForeColor = System.Drawing.Color.Gray
        Me.btnAlat.Image = CType(resources.GetObject("btnAlat.Image"), System.Drawing.Image)
        Me.btnAlat.Location = New System.Drawing.Point(206, 261)
        Me.btnAlat.Name = "btnAlat"
        Me.btnAlat.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.btnAlat.Size = New System.Drawing.Size(166, 160)
        Me.btnAlat.TabIndex = 5
        Me.btnAlat.Text = "ALAT BERAT"
        Me.btnAlat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAlat.UseVisualStyleBackColor = False
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTransaksi.BackgroundImage = CType(resources.GetObject("btnTransaksi.BackgroundImage"), System.Drawing.Image)
        Me.btnTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.ForeColor = System.Drawing.Color.Gray
        Me.btnTransaksi.Image = CType(resources.GetObject("btnTransaksi.Image"), System.Drawing.Image)
        Me.btnTransaksi.Location = New System.Drawing.Point(550, 261)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.btnTransaksi.Size = New System.Drawing.Size(166, 160)
        Me.btnTransaksi.TabIndex = 6
        Me.btnTransaksi.Text = "TRANSAKSI"
        Me.btnTransaksi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTransaksi.UseVisualStyleBackColor = False
        '
        'btnJenis
        '
        Me.btnJenis.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnJenis.BackgroundImage = CType(resources.GetObject("btnJenis.BackgroundImage"), System.Drawing.Image)
        Me.btnJenis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnJenis.FlatAppearance.BorderSize = 0
        Me.btnJenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJenis.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJenis.ForeColor = System.Drawing.Color.Gray
        Me.btnJenis.Image = CType(resources.GetObject("btnJenis.Image"), System.Drawing.Image)
        Me.btnJenis.Location = New System.Drawing.Point(378, 261)
        Me.btnJenis.Name = "btnJenis"
        Me.btnJenis.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.btnJenis.Size = New System.Drawing.Size(166, 160)
        Me.btnJenis.TabIndex = 7
        Me.btnJenis.Text = "JENIS ALAT"
        Me.btnJenis.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnJenis.UseVisualStyleBackColor = False
        '
        'btnPengaturan
        '
        Me.btnPengaturan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPengaturan.BackgroundImage = CType(resources.GetObject("btnPengaturan.BackgroundImage"), System.Drawing.Image)
        Me.btnPengaturan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPengaturan.FlatAppearance.BorderSize = 0
        Me.btnPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPengaturan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPengaturan.ForeColor = System.Drawing.Color.Orange
        Me.btnPengaturan.Image = CType(resources.GetObject("btnPengaturan.Image"), System.Drawing.Image)
        Me.btnPengaturan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPengaturan.Location = New System.Drawing.Point(613, 66)
        Me.btnPengaturan.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.btnPengaturan.Name = "btnPengaturan"
        Me.btnPengaturan.Size = New System.Drawing.Size(113, 43)
        Me.btnPengaturan.TabIndex = 8
        Me.btnPengaturan.Text = "   Akun"
        Me.btnPengaturan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPengaturan.UseVisualStyleBackColor = False
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(754, 450)
        Me.Controls.Add(Me.btnPengaturan)
        Me.Controls.Add(Me.btnJenis)
        Me.Controls.Add(Me.btnTransaksi)
        Me.Controls.Add(Me.btnAlat)
        Me.Controls.Add(Me.btnPelanggan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogout)
        Me.Name = "MenuUtama"
        Me.Text = "Pengaturan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPelanggan As Button
    Friend WithEvents btnAlat As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnJenis As Button
    Friend WithEvents btnPengaturan As Button
End Class
