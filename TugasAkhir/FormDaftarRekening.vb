Public Class FormDaftarRekening



    Sub tampil()
        Dim ButtonEdit As New DataGridViewButtonColumn
        ButtonEdit.Text = "Edit"
        ButtonEdit.HeaderText = "Edit"
        ButtonEdit.FlatStyle = FlatStyle.Popup
        ButtonEdit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ButtonEdit.DefaultCellStyle.ForeColor = Color.Maroon
        ButtonEdit.Width = 40

        Dim ButtonDelete As New DataGridViewButtonColumn
        ButtonDelete.Text = "Delete"
        ButtonDelete.HeaderText = "Delete"
        ButtonDelete.FlatStyle = FlatStyle.Popup
        ButtonDelete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ButtonDelete.DefaultCellStyle.ForeColor = Color.Red
        ButtonDelete.Width = 40



        Try
            Call KoneksiDatabase.KoneksiDatabase()
            Dim str As String
            str = "SELECT A.RekeningId
      ,A.NoRekening
      ,A.NIK
      ,A.Nama
      ,A.TempatLahir
      ,A.TanggalLahir
      ,A.Alamat
      ,A.JenisKelamin
      ,A.Agama
      ,A.StatusPerkawinan
      ,A.Pekerjaan
      ,B.UserName as Createdby
      ,A.CreatedDate
        FROM TableRekening  A
		JOIN TableUser B
			ON A.CreatedBy = B.IdUser"
            cmd = New SqlClient.SqlCommand(str, Conn)
            Dim adapter As New SqlClient.SqlDataAdapter(cmd)
            Using Ds As New DataSet
                adapter.Fill(Ds, 0)
                DataGridView1.DataSource = Ds.Tables(0)
                DataGridView1.Columns.Add(ButtonEdit)
                DataGridView1.Columns.Add(ButtonDelete)
            End Using



        Catch ex As Exception
            MsgBox("ERROR")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FormMenu.Show()
    End Sub

    Private Sub FormDaftarRekening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "Edit" Then
            Dim FormPendaftaranRekening = New FormPendaftaranRekening()

            Dim TanggalLahir = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            FormPendaftaranRekening.DateTimePicker_TanggalLahir.Value = TanggalLahir
            FormPendaftaranRekening.TextBox_Alamat.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
            FormPendaftaranRekening.TextBox_Nama.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            FormPendaftaranRekening.TextBox_KTP.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            FormPendaftaranRekening.TextBox_TempatLahir.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            FormPendaftaranRekening.ComboBox1_JenisKelamin.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(7).Value
            FormPendaftaranRekening.ComboBox_Agama.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(9).Value
            FormPendaftaranRekening.ComboBox_StatusPerkawinan.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(10).Value
            FormPendaftaranRekening.ComboBox_Pekerjaan.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(11).Value
            FormPendaftaranRekening.TextBox_RekeningId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            FormPendaftaranRekening.TextBox_KTP.Enabled = False
            FormPendaftaranRekening.Show()
            Me.Hide()
            'MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        End If
        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "Delete" Then
            Dim RekeningId = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Call KoneksiDatabase.KoneksiDatabase()
            Dim str As String
            str = "DELETE FROM TableRekening WHERE RekeningId = '" & RekeningId & "'"
            cmd = New SqlClient.SqlCommand(str, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil di delete")
            DataGridView1.Columns.Clear()
            tampil()
        End If
    End Sub

End Class