Imports System.Data.SqlClient
Module KoneksiDatabase
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public Ds As DataSet
    Public cmd As SqlCommand
    Public MyDB As String
    Dim str As String

    Sub KoneksiDatabase()
        Try
            MyDB = "Data Source=DESKTOP-9DROQ2H\RENZSQL;initial catalog=TugasAkhir;integrated security=true"
            Conn = New SqlConnection(MyDB)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



End Module
