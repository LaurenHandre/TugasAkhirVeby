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
End Class