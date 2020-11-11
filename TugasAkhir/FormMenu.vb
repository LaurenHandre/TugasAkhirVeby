Public Class FormMenu
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Test = FormLogin.UserName

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim FormPendaftaran = New FormPendaftaran()
        FormPendaftaran.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim FormPendaftaranRekening = New FormPendaftaranRekening()
        FormPendaftaranRekening.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim FormDaftarRekening = New FormDaftarRekening()
        FormDaftarRekening.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim FormDaftarPenarikan = New FormDaftarPenarikan()
        FormDaftarPenarikan.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim FormLogin = New FormLogin()
        FormLogin.Show()
    End Sub
End Class