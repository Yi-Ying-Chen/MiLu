Imports System.Data.SqlClient
Public Class 管理者登入
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\資管\大三上\系分\謎鹿\謎鹿.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        登入.Show()
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Dim strSQL = " SELECT * FROM [管理者] WHERE 帳號 = '" & TextBox1.Text & "'"

        Dim cmd = New SqlCommand(strSQL, conn)
        cmd.ExecuteNonQuery()

        Dim dr As SqlDataReader = cmd.ExecuteReader

        dr.Read()
        Try
            If dr(0) = 0 Then
                MsgBox("帳號錯誤")
                conn.Close()
            Else
                管理者介面.Show()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("帳號錯誤")
            conn.Close()
        End Try
    End Sub

End Class