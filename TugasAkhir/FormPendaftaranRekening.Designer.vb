<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPendaftaranRekening
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox_Pekerjaan = New System.Windows.Forms.ComboBox()
        Me.ComboBox_StatusPerkawinan = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Agama = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_Alamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker_TanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_TempatLahir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_KTP = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.TextBox_RekeningId = New System.Windows.Forms.TextBox()
        Me.ComboBox1_JenisKelamin = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(23, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(257, 69)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ComboBox1_JenisKelamin)
        Me.Panel1.Controls.Add(Me.TextBox_RekeningId)
        Me.Panel1.Controls.Add(Me.ComboBox_Pekerjaan)
        Me.Panel1.Controls.Add(Me.ComboBox_StatusPerkawinan)
        Me.Panel1.Controls.Add(Me.ComboBox_Agama)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextBox_Alamat)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DateTimePicker_TanggalLahir)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox_TempatLahir)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox_Nama)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox_KTP)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Location = New System.Drawing.Point(23, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1432, 545)
        Me.Panel1.TabIndex = 12
        '
        'ComboBox_Pekerjaan
        '
        Me.ComboBox_Pekerjaan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Pekerjaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Pekerjaan.FormattingEnabled = True
        Me.ComboBox_Pekerjaan.Items.AddRange(New Object() {"Pegawai Swasta", "PNS", "Freelancer"})
        Me.ComboBox_Pekerjaan.Location = New System.Drawing.Point(956, 247)
        Me.ComboBox_Pekerjaan.Name = "ComboBox_Pekerjaan"
        Me.ComboBox_Pekerjaan.Size = New System.Drawing.Size(422, 33)
        Me.ComboBox_Pekerjaan.TabIndex = 74
        '
        'ComboBox_StatusPerkawinan
        '
        Me.ComboBox_StatusPerkawinan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_StatusPerkawinan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_StatusPerkawinan.FormattingEnabled = True
        Me.ComboBox_StatusPerkawinan.Items.AddRange(New Object() {"Menikah", "Belum Menikah", "Janda/Duda"})
        Me.ComboBox_StatusPerkawinan.Location = New System.Drawing.Point(958, 172)
        Me.ComboBox_StatusPerkawinan.Name = "ComboBox_StatusPerkawinan"
        Me.ComboBox_StatusPerkawinan.Size = New System.Drawing.Size(422, 33)
        Me.ComboBox_StatusPerkawinan.TabIndex = 73
        '
        'ComboBox_Agama
        '
        Me.ComboBox_Agama.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Agama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Agama.FormattingEnabled = True
        Me.ComboBox_Agama.Items.AddRange(New Object() {"Islam", "Kristen", "Katolik", "Budha", "Hindu", "Kong Hu-Chu"})
        Me.ComboBox_Agama.Location = New System.Drawing.Point(956, 97)
        Me.ComboBox_Agama.Name = "ComboBox_Agama"
        Me.ComboBox_Agama.Size = New System.Drawing.Size(422, 33)
        Me.ComboBox_Agama.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(740, 251)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 29)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Pekerjaan"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(740, 176)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 29)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Status Perkawinan"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(740, 98)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 29)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Agama"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(740, 32)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 29)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Jenis Kelamin"
        '
        'TextBox_Alamat
        '
        Me.TextBox_Alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Alamat.Location = New System.Drawing.Point(249, 320)
        Me.TextBox_Alamat.Multiline = True
        Me.TextBox_Alamat.Name = "TextBox_Alamat"
        Me.TextBox_Alamat.Size = New System.Drawing.Size(422, 95)
        Me.TextBox_Alamat.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 321)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 29)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Alamat"
        '
        'DateTimePicker_TanggalLahir
        '
        Me.DateTimePicker_TanggalLahir.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_TanggalLahir.Location = New System.Drawing.Point(249, 258)
        Me.DateTimePicker_TanggalLahir.Name = "DateTimePicker_TanggalLahir"
        Me.DateTimePicker_TanggalLahir.Size = New System.Drawing.Size(422, 22)
        Me.DateTimePicker_TanggalLahir.TabIndex = 56
        Me.DateTimePicker_TanggalLahir.Tag = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 251)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 29)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Tanggal Lahir"
        '
        'TextBox_TempatLahir
        '
        Me.TextBox_TempatLahir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TempatLahir.Location = New System.Drawing.Point(249, 175)
        Me.TextBox_TempatLahir.Name = "TextBox_TempatLahir"
        Me.TextBox_TempatLahir.Size = New System.Drawing.Size(422, 30)
        Me.TextBox_TempatLahir.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 176)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 29)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Tempat Lahir"
        '
        'TextBox_Nama
        '
        Me.TextBox_Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nama.Location = New System.Drawing.Point(249, 97)
        Me.TextBox_Nama.Name = "TextBox_Nama"
        Me.TextBox_Nama.Size = New System.Drawing.Size(422, 30)
        Me.TextBox_Nama.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 29)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Nama"
        '
        'TextBox_KTP
        '
        Me.TextBox_KTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_KTP.Location = New System.Drawing.Point(249, 31)
        Me.TextBox_KTP.Name = "TextBox_KTP"
        Me.TextBox_KTP.Size = New System.Drawing.Size(422, 30)
        Me.TextBox_KTP.TabIndex = 50
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(33, 32)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(61, 29)
        Me.Label31.TabIndex = 49
        Me.Label31.Text = "KTP"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.TugasAkhir.My.Resources.Resources.LogoBankJateng
        Me.PictureBox2.Location = New System.Drawing.Point(450, -9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(591, 148)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.Location = New System.Drawing.Point(980, 713)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(213, 49)
        Me.btn_reset.TabIndex = 40
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(1242, 713)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(213, 49)
        Me.btn_save.TabIndex = 39
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'TextBox_RekeningId
        '
        Me.TextBox_RekeningId.Location = New System.Drawing.Point(947, 355)
        Me.TextBox_RekeningId.Name = "TextBox_RekeningId"
        Me.TextBox_RekeningId.Size = New System.Drawing.Size(293, 22)
        Me.TextBox_RekeningId.TabIndex = 76
        '
        'ComboBox1_JenisKelamin
        '
        Me.ComboBox1_JenisKelamin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1_JenisKelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1_JenisKelamin.FormattingEnabled = True
        Me.ComboBox1_JenisKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.ComboBox1_JenisKelamin.Location = New System.Drawing.Point(956, 28)
        Me.ComboBox1_JenisKelamin.Name = "ComboBox1_JenisKelamin"
        Me.ComboBox1_JenisKelamin.Size = New System.Drawing.Size(422, 33)
        Me.ComboBox1_JenisKelamin.TabIndex = 77
        '
        'FormPendaftaranRekening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TugasAkhir.My.Resources.Resources.Blue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1483, 791)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPendaftaranRekening"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents TextBox_Nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_KTP As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBox_Alamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker_TanggalLahir As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_TempatLahir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox_Agama As ComboBox
    Friend WithEvents ComboBox_StatusPerkawinan As ComboBox
    Friend WithEvents ComboBox_Pekerjaan As ComboBox
    Friend WithEvents TextBox_RekeningId As TextBox
    Friend WithEvents ComboBox1_JenisKelamin As ComboBox
End Class
