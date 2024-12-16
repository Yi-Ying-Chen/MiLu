Imports System.Data.SqlClient
Public Class 會員管理
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\資管\大三上\系分\謎鹿\謎鹿.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub 會員管理_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.會員' 資料表。您可以視需要進行移動或移除。
        Me.會員TableAdapter.Fill(Me.謎鹿DataSet.會員)
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.會員' 資料表。您可以視需要進行移動或移除。
        Me.會員TableAdapter.Fill(Me.謎鹿DataSet.會員)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        商品管理.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        訂單管理.Show()
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        商品銷售紀錄.Show()
        Me.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        會員購買紀錄.Show()
        Me.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        管理者登入.Show()
        Me.Visible = False
    End Sub

    Private Sub 搜尋_Click(sender As Object, e As EventArgs) Handles 搜尋.Click
        Try
            Try
                Me.會員TableAdapter.FillByKeyword(Me.謎鹿DataSet.會員, Trim(ToolStripTextBox1.Text))
            Catch ex As Exception
                Me.會員TableAdapter.FillBysql(Me.謎鹿DataSet.會員, Trim(ToolStripTextBox1.Text))
            End Try

        Catch ex2 As Exception
            Me.會員TableAdapter.FillByemail(Me.謎鹿DataSet.會員, Trim(ToolStripTextBox1.Text))
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        conn.Open()

        Dim i As Integer = 會員DataGridView.CurrentRow.Index


        Dim m_會員編號 = 會員編號TextBox.Text
        Dim m_帳號 = 帳號TextBox.Text
        Dim m_密碼 = 密碼TextBox.Text
        Dim m_姓名 = 姓名TextBox.Text
        Dim m_電話 = 電話TextBox.Text
        Dim m_住址 = 住址TextBox.Text
        Dim m_email = EmailTextBox.Text

        Dim sqladd As String = "INSERT INTO 會員(會員編號,帳號,密碼,姓名,電話,住址,email) VALUES('" & 會員編號TextBox.Text & "','" & 帳號TextBox.Text & "','" & 密碼TextBox.Text & "',N'" & 姓名TextBox.Text & "','" & 電話TextBox.Text & "',N'" & 住址TextBox.Text & "','" & EmailTextBox.Text & "')"
        Dim add = New SqlCommand(sqladd, conn)
        Try
            add.ExecuteNonQuery()
        Catch ex3 As Exception
            MsgBox("會員編號已存在")
        End Try
        MsgBox("新增結束")
        conn.Close()

        Try
            Me.會員TableAdapter.InsertQuery(m_會員編號, m_帳號, m_密碼, m_姓名, m_電話, m_住址, m_email)
        Catch ex4 As Exception
        End Try
        Me.會員DataGridView.Refresh()
        Me.會員BindingSource.DataSource = 會員TableAdapter.GetData()
        Me.會員BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        conn.Open()

        Dim i As Integer = 會員DataGridView.CurrentRow.Index


        Dim m_會員編號 = 會員編號TextBox.Text

        Dim sqldel As String = "DELETE FROM 會員 WHERE 會員編號 IN('" & 會員編號TextBox.Text & "')"
        Dim del = New SqlCommand(sqldel, conn)
        Try
            del.ExecuteNonQuery()
        Catch ex5 As Exception
            MsgBox("會員編號不存在")
        End Try
        MsgBox("刪除結束")
        conn.Close()

        Try
            Me.會員TableAdapter.DeleteQuery(m_會員編號)
        Catch ex6 As Exception
        End Try
        Me.會員DataGridView.Refresh()
        Me.會員BindingSource.DataSource = 會員TableAdapter.GetData()
        Me.會員BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        conn.Open()

        Dim i As Integer = 會員DataGridView.CurrentRow.Index


        Dim m_會員編號 = 會員編號TextBox.Text
        Dim m_帳號 = 帳號TextBox.Text
        Dim m_密碼 = 密碼TextBox.Text
        Dim m_姓名 = 姓名TextBox.Text
        Dim m_電話 = 電話TextBox.Text
        Dim m_住址 = 住址TextBox.Text
        Dim m_email = EmailTextBox.Text

        Dim sqlupd As String = "UPDATE 會員 Set 會員編號 = '" & 會員編號TextBox.Text & "',帳號 = N'" & 帳號TextBox.Text & "',密碼 = '" & 密碼TextBox.Text & "', 姓名 = N'" & 姓名TextBox.Text & "', 電話 = '" & 電話TextBox.Text & "', 住址 = N'" & 住址TextBox.Text & "', email = '" & EmailTextBox.Text & "' WHERE ID = '" & ComboBox1.Text & "'"
        Dim upd = New SqlCommand(sqlupd, conn)
        Try
            upd.ExecuteNonQuery()
        Catch ex7 As Exception
        End Try
        MsgBox("修改結束")
        conn.Close()

        Try
            Me.會員TableAdapter.UpdateQuery(m_會員編號, m_帳號, m_密碼, m_姓名, m_電話, m_住址, m_email)
        Catch ex8 As Exception
        End Try
        Me.會員DataGridView.Refresh()
        Me.會員BindingSource.DataSource = 會員TableAdapter.GetData()
        Me.會員BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.會員TableAdapter.Fill(Me.謎鹿DataSet.會員)
    End Sub
End Class