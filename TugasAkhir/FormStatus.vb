Public Class FormStatus
    Private Sub FormStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_Status.SelectedIndex = 0
        TextBox_Status.Hide()
        TextBox_PenarikanId.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim FormDaftarPenarikan = New FormDaftarPenarikan()
        FormDaftarPenarikan.Show()
    End Sub

    Private Sub ComboBox_Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Status.SelectedIndexChanged
        Dim data = ComboBox_Status.SelectedItem
        If data = "Reject" Then
            TextBox_AlasanPenolakan.Enabled = True
        Else

            TextBox_AlasanPenolakan.Enabled = False
        End If
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Dim Str As String
        If ComboBox_Status.SelectedItem = TextBox_Status.Text Then
            MsgBox("Status Sama Dengan Sebelumnya !")
        ElseIf ComboBox_Status.SelectedItem = "Done" Then

            Dim TanggalPenarikan = DateTimePicker_JamPenarikan.Value.ToString("dd/MM/yyyy")
            Dim JamPenarikan = DateTimePicker_JamPenarikan.Value.ToString("hh:mm")
            Dim time = TimeSpan.Parse(JamPenarikan)
            Dim Total = Convert.ToDateTime(TanggalPenarikan).Add(time)
            If DateTime.Now < Total Then
                MsgBox("Waktu Penarikan Tidak Sekarang. Silahkan Menunggu Sampai Waktu Yang Ditentukan")
            Else
                Call KoneksiDatabase.KoneksiDatabase()
                Str = "UPDATE TablePenarikan 
                        SET FlowStatus = '" & ComboBox_Status.SelectedItem & "'
                where PenarikanId = '" & TextBox_PenarikanId.Text & "'"
                cmd = New SqlClient.SqlCommand(Str, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil di ubah")
                Dim FormDaftarPenarikan = New FormDaftarPenarikan
                FormDaftarPenarikan.Show()
                Me.Hide()
            End If
        ElseIf ComboBox_Status.SelectedItem = "Reject" Then
            If TextBox_AlasanPenolakan.Text = "" Then
                MsgBox("Alasan Penolaan Mohon Diisi")
            Else
                Call KoneksiDatabase.KoneksiDatabase()
                Str = "UPDATE TablePenarikan 
                        SET FlowStatus = '" & ComboBox_Status.SelectedItem & "',
                            AlasanPenolakan = '" & TextBox_AlasanPenolakan.Text & "' 
                where PenarikanId = '" & TextBox_PenarikanId.Text & "'"
                cmd = New SqlClient.SqlCommand(Str, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil di ubah")
                Dim FormDaftarPenarikan = New FormDaftarPenarikan
                FormDaftarPenarikan.Show()
                Me.Hide()
            End If

        Else
        End If
    End Sub
End Class