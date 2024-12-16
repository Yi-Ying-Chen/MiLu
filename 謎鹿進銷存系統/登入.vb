Imports System.Data.SqlClient
Public Class 登入
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\資管\大三上\系分\謎鹿\謎鹿.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        註冊.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn.Open()
        Dim strSQL = " SELECT * FROM [會員] WHERE 帳號 = '" & TextBox1.Text & "' And 密碼 = '" & TextBox2.Text & "'"

        Dim cmd = New SqlCommand(strSQL, conn)
        cmd.ExecuteNonQuery()

        Dim dr As SqlDataReader = cmd.ExecuteReader

        dr.Read()
        Try
            If dr(0) = 0 Then
                MsgBox("帳號或密碼錯誤")
                conn.Close()
            Else
                耳環.Show()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("帳號或密碼錯誤")
            conn.Close()
        End Try
    End Sub

    Private Sub Label4_DoubleClick(sender As Object, e As EventArgs) Handles Label4.DoubleClick
        管理者登入.Show()
    End Sub
End Class
