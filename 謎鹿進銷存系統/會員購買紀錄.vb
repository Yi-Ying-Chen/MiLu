Public Class 會員購買紀錄
    Private Sub 會員購買紀錄_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.訂購' 資料表。您可以視需要進行移動或移除。
        Me.訂購TableAdapter.Fill(Me.謎鹿DataSet.訂購)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        商品管理.Show()
        Me.Visible = False
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        管理者登入.Show()
        Me.Visible = False
    End Sub

    Private Sub 搜尋_Click(sender As Object, e As EventArgs) Handles 搜尋.Click
        Try
            Me.訂購TableAdapter.FillByKeyword(Me.謎鹿DataSet.訂購, Trim(ToolStripTextBox1.Text))
        Catch ex As Exception
            Me.訂購TableAdapter.FillBysql(Me.謎鹿DataSet.訂購, Trim(ToolStripTextBox1.Text))
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.訂購TableAdapter.Fill(Me.謎鹿DataSet.訂購)
    End Sub
End Class