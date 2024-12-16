Public Class 訂單管理
    Private Sub 訂單管理_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.訂單' 資料表。您可以視需要進行移動或移除。
        Me.訂單TableAdapter.Fill(Me.謎鹿DataSet.訂單)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        商品管理.Show()
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
End Class