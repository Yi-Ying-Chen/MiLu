Imports System.Data.SqlClient
Public Class 註冊
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\資管\大三上\系分\謎鹿\謎鹿.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn.Open()

        Dim i As Integer = 會員DataGridView.CurrentRow.Index


        Dim m_會員編號 = TextBox1.Text
        Dim m_帳號 = TextBox1.Text
        Dim m_密碼 = TextBox2.Text
        Dim m_姓名 = TextBox4.Text
        Dim m_email = TextBox5.Text
        Dim m_電話 = TextBox6.Text
        Dim m_住址 = TextBox7.Text

        If (TextBox2.Text <> TextBox3.Text) Then
            MsgBox("密碼必須一致!!")
        End If


        Dim sqladd As String = "INSERT INTO 會員(會員編號,帳號,密碼,姓名,電話,住址,email) VALUES('" & TextBox1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "',N'" & TextBox4.Text & "','" & TextBox6.Text & "',N'" & TextBox7.Text & "','" & TextBox5.Text & "')"
        Dim add = New SqlCommand(sqladd, conn)
        add.ExecuteNonQuery()
        MsgBox("註冊成功!!!")
        conn.Close()

        Try
            Me.會員TableAdapter.InsertQuery(m_會員編號, m_帳號, m_密碼, m_姓名, m_電話, m_住址, m_email)
        Catch ex As Exception
        End Try

        Me.會員DataGridView.Refresh()
        Me.會員BindingSource.DataSource = 會員TableAdapter.GetData()
        Me.會員BindingSource.ResetBindings(False)

    End Sub

    Private Sub 註冊_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.會員' 資料表。您可以視需要進行移動或移除。
        Me.會員TableAdapter.Fill(Me.謎鹿DataSet.會員)

    End Sub
End Class