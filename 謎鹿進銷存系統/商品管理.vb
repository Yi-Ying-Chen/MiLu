Imports System.Data.SqlClient
Public Class 商品管理
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\資管\大三上\系分\謎鹿\謎鹿.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub 商品管理_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.商品' 資料表。您可以視需要進行移動或移除。
        Me.商品TableAdapter.Fill(Me.謎鹿DataSet.商品)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        訂單管理.Show()
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        會員管理.Show()
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
            Me.商品TableAdapter.FillByKeyword(Me.謎鹿DataSet.商品, Trim(ToolStripTextBox1.Text))
        Catch ex As Exception
            Me.商品TableAdapter.FillBysql(Me.謎鹿DataSet.商品, Trim(ToolStripTextBox1.Text))
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        conn.Open()

        Dim i As Integer = 商品DataGridView.CurrentRow.Index


        Dim m_商品編號 = 商品編號TextBox.Text
        Dim m_商品名稱 = 商品名稱TextBox.Text
        Dim m_庫存數量 = 庫存數量TextBox.Text
        Dim m_定價 = 定價TextBox.Text
        Dim m_種類 = 種類TextBox.Text
        Dim m_管理者編號 = 管理者編號TextBox.Text

        Dim sqladd As String = "INSERT INTO 商品(商品編號,商品名稱,庫存數量,定價,種類,管理者編號) VALUES('" & 商品編號TextBox.Text & "',N'" & 商品名稱TextBox.Text & "','" & 庫存數量TextBox.Text & "','" & 定價TextBox.Text & "',N'" & 種類TextBox.Text & "','" & 管理者編號TextBox.Text & "')"
        Dim add = New SqlCommand(sqladd, conn)
        Try
            add.ExecuteNonQuery()
        Catch ex2 As Exception
        End Try
        MsgBox("新增結束")
        conn.Close()

        Try
            Me.商品TableAdapter.InsertQuery(m_商品編號, m_商品名稱, m_庫存數量, m_定價, m_種類, m_管理者編號)
        Catch ex3 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        conn.Open()

        Dim i As Integer = 商品DataGridView.CurrentRow.Index


        Dim m_商品編號 = 商品編號TextBox.Text

        Dim sqldel As String = "DELETE FROM 商品 WHERE 商品編號 IN('" & 商品編號TextBox.Text & "')"
        Dim del = New SqlCommand(sqldel, conn)
        Try
            del.ExecuteNonQuery()
        Catch ex4 As Exception
            MsgBox("商品編號不存在")
        End Try
        MsgBox("刪除結束")
        conn.Close()

        Try
            Me.商品TableAdapter.DeleteQuery(m_商品編號)
        Catch ex5 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        conn.Open()

        Dim i As Integer = 商品DataGridView.CurrentRow.Index


        Dim m_商品編號 = 商品編號TextBox.Text
        Dim m_商品名稱 = 商品名稱TextBox.Text
        Dim m_庫存數量 = 庫存數量TextBox.Text
        Dim m_定價 = 定價TextBox.Text
        Dim m_種類 = 種類TextBox.Text
        Dim m_管理者編號 = 管理者編號TextBox.Text


        Dim sqlupd As String = "UPDATE 商品 Set 商品編號 = '" & 商品編號TextBox.Text & "',商品名稱 = N'" & 商品名稱TextBox.Text & "',庫存數量 = '" & 庫存數量TextBox.Text & "', 定價 = '" & 定價TextBox.Text & "', 種類 = N'" & 種類TextBox.Text & "', 管理者編號 = '" & 管理者編號TextBox.Text & "' WHERE ID = '" & ComboBox1.Text & "'"
        Dim upd = New SqlCommand(sqlupd, conn)
        Try
            upd.ExecuteNonQuery()
        Catch ex6 As Exception
        End Try
        MsgBox("修改結束")
        conn.Close()

        Try
            Me.商品TableAdapter.UpdateQuery(m_商品編號, m_商品名稱, m_庫存數量, m_定價, m_種類, m_管理者編號)
        Catch ex7 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.商品TableAdapter.Fill(Me.謎鹿DataSet.商品)
    End Sub
End Class