
Public Class FormLogin
    Public UserName As String
    Public IdUser As String


    Sub Login()
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Mohon isi Username atau Password", MsgBoxStyle.Information, "Informasi")
        Else
            Call KoneksiDatabase.KoneksiDatabase()
            Dim str As String

            str = "SELECT * FROM TableUser WHERE UserName = '" + TextBox1.Text + "' AND Password= '" + TextBox2.Text + "'"

            cmd = New SqlClient.SqlCommand(str, Conn)
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader)

            If dt.Rows.Count = 0 Then
                MsgBox("Username atau Password ada yang salah !", MsgBoxStyle.Exclamation, "Error Login")
                TextBox1.ForeColor = Color.Blue
            Else
                MsgBox("Berhasil Login", MsgBoxStyle.Information, "Success")
                UserName = dt.Rows(0).Item(1).ToString().Trim()
                IdUser = dt.Rows(0).Item(0).ToString().Trim()
                FormMenu.Show()
                Me.Hide()

            End If
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login()
    End Sub
End Class