Public Class FormDaftarPenarikan
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FormMenu.Show()
    End Sub

    Sub tampil()
        Dim ButtonEdit As New DataGridViewButtonColumn
        ButtonEdit.Text = "Edit"
        ButtonEdit.HeaderText = "Edit"
        ButtonEdit.FlatStyle = FlatStyle.Popup
        ButtonEdit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ButtonEdit.DefaultCellStyle.ForeColor = Color.Maroon
        ButtonEdit.Width = 40

        Try
            Call KoneksiDatabase.KoneksiDatabase()
            Dim str As String
            str = "SELECT A.PenarikanId
                  ,A.NoRekening
                  ,A.JumlahPenarikan
                  ,A.TanggalPenarikan
                  ,A.JamPenarikan
                  ,A.KTP
                  ,A.SuratPengantar
                  ,B.UserName as CreatedBy
                  ,A.FlowStatus as Status
                  ,AlasanPenolakan
                  ,A.CreatedDate
              FROM TablePenarikan A
	            JOIN TableUser B
		            ON A.CreatedBy = B.IdUser"
            cmd = New SqlClient.SqlCommand(str, Conn)
            Dim adapter As New SqlClient.SqlDataAdapter(cmd)
            Using Ds As New DataSet
                adapter.Fill(Ds, 0)
                DataGridView1.DataSource = Ds.Tables(0)
                DataGridView1.Columns.Add(ButtonEdit)
            End Using

        Catch ex As Exception
            MsgBox("ERROR")
        End Try
    End Sub

    Private Sub FormDaftarPenarikan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "KTP" Then

            Dim FILE_NAME As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

            If System.IO.File.Exists(FILE_NAME) = True Then
                Process.Start(FILE_NAME)
            Else
                MsgBox("File Does Not Exist")
            End If



        End If
        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "SuratPengantar" Then

            Dim FILE_NAME As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

            If System.IO.File.Exists(FILE_NAME) = True Then
                Process.Start(FILE_NAME)
            Else
                MsgBox("File Does Not Exist")
            End If


        End If



        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "Edit" Then
            If DataGridView1.Rows(e.RowIndex).Cells(8).Value = "Submitted" Then
                Call KoneksiDatabase.KoneksiDatabase()
                Dim str As String
                str = "SELECT	B.NIK,
		                    B.Nama,
		                    B.TempatLahir,
		                    B.TanggalLahir,
		                    B.Alamat,
		                    A.JumlahPenarikan,
		                    A.TanggalPenarikan,
		                    A.JamPenarikan,
							A.FlowStatus,
							A.PenarikanId
                    FROM TablePenarikan A 
	                    JOIN TableRekening B
		                    ON A.NoRekening = B.NoRekening
                   WHERE Penarikanid = '" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & "'"
                cmd = New SqlClient.SqlCommand(str, Conn)
                cmd.ExecuteNonQuery()
                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader)

                If dt.Rows.Count = 0 Then
                    MsgBox("Error Data Tidak Ditemukan", MsgBoxStyle.Information, "Error")
                Else
                    Dim formStatus = New FormStatus

                    formStatus.TextBox_NIK.Text = dt.Rows(0).Item(0).ToString().Trim()
                    formStatus.TextBox_Nama.Text = dt.Rows(0).Item(1).ToString().Trim()
                    formStatus.TextBox_Tempat.Text = dt.Rows(0).Item(2).ToString().Trim()
                    formStatus.DateTimePicker_TanggalLahir.Value = dt.Rows(0).Item(3)
                    formStatus.TextBox_Alamat.Text = dt.Rows(0).Item(4).ToString().Trim()
                    formStatus.TextBox_JumlahPenarikan.Text = dt.Rows(0).Item(5).ToString().Trim()
                    formStatus.DateTimePicker_TanggalPenarikan.Value = dt.Rows(0).Item(6)
                    formStatus.DateTimePicker_JamPenarikan.Format = DateTimePickerFormat.Time
                    formStatus.DateTimePicker_JamPenarikan.CustomFormat = "hh:mm"
                    Dim Today = System.DateTime.Now.Date
                    Dim Answer = Today.Add(dt.Rows(0).Item(7))
                    formStatus.DateTimePicker_JamPenarikan.Value = Answer
                    formStatus.TextBox_Status.Text = dt.Rows(0).Item(8)
                    formStatus.TextBox_PenarikanId.Text = dt.Rows(0).Item(9)
                    formStatus.Show()
                    Me.Hide()

                End If

            Else
                MsgBox("Status Sudah Berubah")

            End If

            'Me.Hide()
            'MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        End If

    End Sub
End Class