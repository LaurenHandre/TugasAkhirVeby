<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStatus
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker_JamPenarikan = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DateTimePicker_TanggalPenarikan = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox_JumlahPenarikan = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox_Alamat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker_TanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_Tempat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_Nama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_NIK = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox_Status = New System.Windows.Forms.ComboBox()
        Me.TextBox_AlasanPenolakan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.TextBox_Status = New System.Windows.Forms.TextBox()
        Me.TextBox_PenarikanId = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.TugasAkhir.My.Resources.Resources.LogoBankJateng
        Me.PictureBox2.Location = New System.Drawing.Point(533, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(326, 148)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(25, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(257, 69)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.Controls.Add(Me.DateTimePicker_JamPenarikan)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.DateTimePicker_TanggalPenarikan)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.TextBox_JumlahPenarikan)
        Me.Panel2.Location = New System.Drawing.Point(762, 186)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(679, 235)
        Me.Panel2.TabIndex = 44
        '
        'DateTimePicker_JamPenarikan
        '
        Me.DateTimePicker_JamPenarikan.CustomFormat = ""
        Me.DateTimePicker_JamPenarikan.Enabled = False
        Me.DateTimePicker_JamPenarikan.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker_JamPenarikan.Location = New System.Drawing.Point(277, 158)
        Me.DateTimePicker_JamPenarikan.Name = "DateTimePicker_JamPenarikan"
        Me.DateTimePicker_JamPenarikan.ShowUpDown = True
        Me.DateTimePicker_JamPenarikan.Size = New System.Drawing.Size(363, 22)
        Me.DateTimePicker_JamPenarikan.TabIndex = 57
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(41, 163)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(172, 29)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "Jam Penarikan"
        '
        'DateTimePicker_TanggalPenarikan
        '
        Me.DateTimePicker_TanggalPenarikan.Enabled = False
        Me.DateTimePicker_TanggalPenarikan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_TanggalPenarikan.Location = New System.Drawing.Point(277, 91)
        Me.DateTimePicker_TanggalPenarikan.Name = "DateTimePicker_TanggalPenarikan"
        Me.DateTimePicker_TanggalPenarikan.Size = New System.Drawing.Size(363, 22)
        Me.DateTimePicker_TanggalPenarikan.TabIndex = 55
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(41, 96)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(216, 29)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "Tanggal Penarikan"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(266, 35)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 29)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Rp"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(41, 37)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(204, 29)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Jumlah Penarikan"
        '
        'TextBox_JumlahPenarikan
        '
        Me.TextBox_JumlahPenarikan.Enabled = False
        Me.TextBox_JumlahPenarikan.Location = New System.Drawing.Point(317, 32)
        Me.TextBox_JumlahPenarikan.Name = "TextBox_JumlahPenarikan"
        Me.TextBox_JumlahPenarikan.Size = New System.Drawing.Size(323, 22)
        Me.TextBox_JumlahPenarikan.TabIndex = 46
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.TextBox_Alamat)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.DateTimePicker_TanggalLahir)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextBox_Tempat)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBox_Nama)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBox_NIK)
        Me.Panel1.Location = New System.Drawing.Point(25, 186)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 478)
        Me.Panel1.TabIndex = 43
        '
        'TextBox_Alamat
        '
        Me.TextBox_Alamat.Enabled = False
        Me.TextBox_Alamat.Location = New System.Drawing.Point(221, 263)
        Me.TextBox_Alamat.Multiline = True
        Me.TextBox_Alamat.Name = "TextBox_Alamat"
        Me.TextBox_Alamat.Size = New System.Drawing.Size(309, 128)
        Me.TextBox_Alamat.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 263)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 29)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Alamat"
        '
        'DateTimePicker_TanggalLahir
        '
        Me.DateTimePicker_TanggalLahir.Enabled = False
        Me.DateTimePicker_TanggalLahir.Location = New System.Drawing.Point(221, 213)
        Me.DateTimePicker_TanggalLahir.Name = "DateTimePicker_TanggalLahir"
        Me.DateTimePicker_TanggalLahir.Size = New System.Drawing.Size(309, 22)
        Me.DateTimePicker_TanggalLahir.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 218)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 29)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Tanggal Lahir"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 153)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 29)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Tempat Lahir"
        '
        'TextBox_Tempat
        '
        Me.TextBox_Tempat.Enabled = False
        Me.TextBox_Tempat.Location = New System.Drawing.Point(221, 148)
        Me.TextBox_Tempat.Name = "TextBox_Tempat"
        Me.TextBox_Tempat.Size = New System.Drawing.Size(309, 22)
        Me.TextBox_Tempat.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 91)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 29)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Nama"
        '
        'TextBox_Nama
        '
        Me.TextBox_Nama.Enabled = False
        Me.TextBox_Nama.Location = New System.Drawing.Point(221, 86)
        Me.TextBox_Nama.Name = "TextBox_Nama"
        Me.TextBox_Nama.Size = New System.Drawing.Size(309, 22)
        Me.TextBox_Nama.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 29)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "NIK"
        '
        'TextBox_NIK
        '
        Me.TextBox_NIK.Enabled = False
        Me.TextBox_NIK.Location = New System.Drawing.Point(221, 27)
        Me.TextBox_NIK.Name = "TextBox_NIK"
        Me.TextBox_NIK.Size = New System.Drawing.Size(309, 22)
        Me.TextBox_NIK.TabIndex = 44
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.Controls.Add(Me.ComboBox_Status)
        Me.Panel3.Controls.Add(Me.TextBox_AlasanPenolakan)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(762, 429)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(679, 235)
        Me.Panel3.TabIndex = 44
        '
        'ComboBox_Status
        '
        Me.ComboBox_Status.FormattingEnabled = True
        Me.ComboBox_Status.Items.AddRange(New Object() {"Submitted", "Done", "Reject"})
        Me.ComboBox_Status.Location = New System.Drawing.Point(271, 35)
        Me.ComboBox_Status.Name = "ComboBox_Status"
        Me.ComboBox_Status.Size = New System.Drawing.Size(363, 24)
        Me.ComboBox_Status.TabIndex = 55
        '
        'TextBox_AlasanPenolakan
        '
        Me.TextBox_AlasanPenolakan.Enabled = False
        Me.TextBox_AlasanPenolakan.Location = New System.Drawing.Point(271, 96)
        Me.TextBox_AlasanPenolakan.Multiline = True
        Me.TextBox_AlasanPenolakan.Name = "TextBox_AlasanPenolakan"
        Me.TextBox_AlasanPenolakan.Size = New System.Drawing.Size(363, 128)
        Me.TextBox_AlasanPenolakan.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 29)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Alasan Penolakan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(266, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 29)
        Me.Label3.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 29)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Status"
        '
        'Button_Save
        '
        Me.Button_Save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(1228, 690)
        Me.Button_Save.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(213, 49)
        Me.Button_Save.TabIndex = 45
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'TextBox_Status
        '
        Me.TextBox_Status.Location = New System.Drawing.Point(595, 682)
        Me.TextBox_Status.Name = "TextBox_Status"
        Me.TextBox_Status.Size = New System.Drawing.Size(187, 22)
        Me.TextBox_Status.TabIndex = 46
        '
        'TextBox_PenarikanId
        '
        Me.TextBox_PenarikanId.Location = New System.Drawing.Point(808, 682)
        Me.TextBox_PenarikanId.Name = "TextBox_PenarikanId"
        Me.TextBox_PenarikanId.Size = New System.Drawing.Size(187, 22)
        Me.TextBox_PenarikanId.TabIndex = 47
        '
        'FormStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TugasAkhir.My.Resources.Resources.Blue
        Me.ClientSize = New System.Drawing.Size(1483, 768)
        Me.Controls.Add(Me.TextBox_PenarikanId)
        Me.Controls.Add(Me.TextBox_Status)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormStatus"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormStatus"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker_JamPenarikan As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents DateTimePicker_TanggalPenarikan As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox_JumlahPenarikan As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox_Alamat As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePicker_TanggalLahir As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_Tempat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_Nama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_NIK As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ComboBox_Status As ComboBox
    Friend WithEvents TextBox_AlasanPenolakan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button_Save As Button
    Friend WithEvents TextBox_Status As TextBox
    Friend WithEvents TextBox_PenarikanId As TextBox
End Class
