Public Class FormPendaftaran
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FormMenu.Show()
    End Sub

    Private Sub FormPendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker_TanggalPenarikan.Format = DateTimePickerFormat.Custom
        DateTimePicker_TanggalPenarikan.CustomFormat = "MM/dd/yyyy"
        DateTimePicker_JamPenarikan.Format = DateTimePickerFormat.Time
        DateTimePicker_JamPenarikan.CustomFormat = "hh:mm"

    End Sub

    Private Sub Button_UploadKTP_Click(sender As Object, e As EventArgs) Handles Button_UploadKTP.Click
        Dim UploadKTP = OpenFileDialog1.ShowDialog()
        If UploadKTP = DialogResult.OK Then
            TextBox_UploadKTP.Text = OpenFileDialog1.FileName
        End If




    End Sub

    Private Sub Button_UploadSuratPengantar_Click(sender As Object, e As EventArgs) Handles Button_UploadSuratPengantar.Click
        Dim UploadSuratPengantar = OpenFileDialog1.ShowDialog()
        If UploadSuratPengantar = DialogResult.OK Then
            TextBox_UploadSuratPengantar.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        Call KoneksiDatabase.KoneksiDatabase()
        Dim str As String

        str = "SELECT * FROM TableRekening WHERE NoRekening = '" + TextBox_Account.Text + "'"

        cmd = New SqlClient.SqlCommand(str, Conn)
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        dt.Load(cmd.ExecuteReader)

        If dt.Rows.Count = 0 Then
            MsgBox("Username tidak punya rekening!", MsgBoxStyle.Exclamation, "Error Checked")
        Else
            TextBox_Account.Enabled = False
            TextBox_JumlahPenarikan.Enabled = True
            DateTimePicker_TanggalPenarikan.Enabled = True
            DateTimePicker_JamPenarikan.Enabled = True
            TextBox_NIK.Text = dt.Rows(0).Item(2).ToString().Trim()
            TextBox_Nama.Text = dt.Rows(0).Item(3).ToString().Trim()
            TextBox_Tempat.Text = dt.Rows(0).Item(4).ToString().Trim()
            TextBox_Alamat.Text = dt.Rows(0).Item(6).ToString().Trim()
            DateTimePicker_TanggalLahir.Value = dt.Rows(0).Item(5)
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Dim formPendaftaran = New FormPendaftaran
        formPendaftaran.Show()
        Me.Hide()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim idUser = FormLogin.IdUser
        Dim JamPenarikan = DateTimePicker_JamPenarikan.Value.ToString("hh:mm")
        Dim TanggalPenarikan = DateTimePicker_TanggalPenarikan.Value.ToString("yyyy-MM-dd")
        If TextBox_Account.Text = "" Or TextBox_JumlahPenarikan.Text = "" Or TextBox_UploadKTP.Text = "" Then
            MsgBox("Isi Data-Data Tersebut ! ", MsgBoxStyle.Information, "Information")
        Else
            Dim str As String
            Try
                Call KoneksiDatabase.KoneksiDatabase()
                str = "INSERT INTO [dbo].[TablePenarikan]
                                   ([NoRekening]
                                   ,[JumlahPenarikan]
                                   ,[TanggalPenarikan]
                                   ,[JamPenarikan]
                                   ,[KTP]
                                   ,[SuratPengantar]
                                   ,[FlowStatus]
                                   ,[CreatedBy]
                                   ,[CreatedDate])
                         VALUES
                                   ('" & TextBox_Account.Text & "'
                                   ,'" & TextBox_JumlahPenarikan.Text & "'
                                   ,'" & TanggalPenarikan & "'
                                   ,'" & JamPenarikan & "'
                                   ,'" & TextBox_UploadKTP.Text & "'
                                   ,'" & TextBox_UploadSuratPengantar.Text & "'
                                   ,'Submitted'
                                   ,'" & idUser & "'
                                   ,'" & DateTime.Now & "')"
                cmd = New SqlClient.SqlCommand(str, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil di simpan")
            Catch ex As Exception
                MsgBox("ERROR")
            End Try
        End If
    End Sub
End Class