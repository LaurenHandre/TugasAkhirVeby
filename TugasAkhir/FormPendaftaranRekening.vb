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
        RadioButton_Lakilaki.Checked() = True
        RadioButton_Perempuan.Checked = False
        ComboBox_Agama.SelectedIndex = 0
        ComboBox_Pekerjaan.SelectedIndex = 0
        ComboBox_StatusPerkawinan.SelectedIndex = 0

    End Sub

    Private Sub FormPendaftaranRekening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton_Lakilaki.Checked() = True
        ComboBox_Agama.SelectedIndex = 0
        ComboBox_Pekerjaan.SelectedIndex = 0
        ComboBox_StatusPerkawinan.SelectedIndex = 0
    End Sub
End Class