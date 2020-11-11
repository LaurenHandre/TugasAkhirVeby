Public Class FormPendaftaranRekening


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FormMenu.Show()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        TextBox_KTP.Clear()
        TextBox_Nama.Clear()
        TextBox_TempatLahir.Clear()
        TextBox_Alamat.Clear()
        ComboBox1_JenisKelamin.SelectedIndex = 0
        ComboBox_Agama.SelectedIndex = 0
        ComboBox_Pekerjaan.SelectedIndex = 0
        ComboBox_StatusPerkawinan.SelectedIndex = 0

    End Sub

    Private Sub FormPendaftaranRekening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_Agama.SelectedIndex = 0
        ComboBox1_JenisKelamin.SelectedIndex = 0
        ComboBox_Pekerjaan.SelectedIndex = 0
        ComboBox_StatusPerkawinan.SelectedIndex = 0
        TextBox_RekeningId.Hide()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim idUser = FormLogin.IdUser




        If TextBox_Nama.Text = "" Or TextBox_Alamat.Text = "" Or TextBox_KTP.Text = "" Or TextBox_TempatLahir.Text = "" Or ComboBox_Agama.Text = "" Or ComboBox_Pekerjaan.Text = "" Or ComboBox_StatusPerkawinan.Text = "" Then

            MsgBox("Isi Data-Data Tersebut ! ", MsgBoxStyle.Information, "Information")

        Else
            Dim regDate As DateTime = DateTime.Now
            Dim strDate As String = regDate.ToString("yyyyMMddHHmmss")

            Dim TanggalLahir As String = DateTimePicker_TanggalLahir.Value.ToString("yyyy-MM-dd HH:mm:ss")
            Try
                Call KoneksiDatabase.KoneksiDatabase()
                Dim str As String
                If (TextBox_RekeningId.Text = "") Then
                    Call KoneksiDatabase.KoneksiDatabase()
                    str = "SELECT  * FROM TableRekening where NIK ='" & TextBox_KTP.Text & "'"
                    cmd = New SqlClient.SqlCommand(str, Conn)
                    cmd.ExecuteNonQuery()
                    Dim dt As New DataTable
                    dt.Load(cmd.ExecuteReader)
                    If dt.Rows.Count = 0 Then
                        str = "INSERT INTO TableRekening(NoRekening,NIK,Nama,TempatLahir,TanggalLahir,Alamat,JenisKelamin,Agama,StatusPerkawinan,Pekerjaan,CreatedBy,CreatedDate) VALUES ('" & strDate & "','" & TextBox_KTP.Text & "','" & TextBox_Nama.Text & "','" & TextBox_TempatLahir.Text & "','" & TanggalLahir & "','" & TextBox_Alamat.Text & "','" & ComboBox1_JenisKelamin.Text & "','" & ComboBox_Agama.Text & "','" & ComboBox_StatusPerkawinan.Text & "','" & ComboBox_Pekerjaan.Text & "','" & idUser & "','" & DateTime.Now & "')"
                        cmd = New SqlClient.SqlCommand(str, Conn)
                        cmd.ExecuteNonQuery()
                        MsgBox("Berhasil di simpan")

                    Else

                        MsgBox("NIK Tersebut sudah dipakai", MsgBoxStyle.Exclamation, "Error Checked")
                    End If
                Else
                    str = "
                        UPDATE [dbo].[TableRekening]
                           SET [NIK] = '" & TextBox_KTP.Text & "'
                              ,[Nama] = '" & TextBox_Nama.Text & "'
                              ,[TempatLahir] = '" & TextBox_TempatLahir.Text & "'
                              ,[TanggalLahir] = '" & TanggalLahir & "'
                              ,[Alamat] = '" & TextBox_Alamat.Text & "'
                              ,[JenisKelamin] = '" & ComboBox1_JenisKelamin.Text & "'
                              ,[Agama] = '" & ComboBox_Agama.Text & "'
                              ,[StatusPerkawinan] = '" & ComboBox_StatusPerkawinan.Text & "'
                              ,[Pekerjaan] = '" & ComboBox_Pekerjaan.Text & "'
                              ,[CreatedBy] = '" & idUser & "'
                              ,[CreatedDate] = '" & DateTime.Now & "'
                         WHERE RekeningId = '" & TextBox_RekeningId.Text & "'
                        "
                    cmd = New SqlClient.SqlCommand(str, Conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Berhasil di simpan")
                End If


            Catch ex As Exception
                MsgBox("ERROR")
            End Try

        End If

        'For Each ctrl As RadioButton In grpb.Controls
        '    If ctrl.Checked Then Return ctrl
        'Next
    End Sub

    Private Function GetGroupBoxCheckedButton(grpb As GroupBox) As RadioButton
        Dim rButton As RadioButton = grpb.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()
        Return rButton
    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class