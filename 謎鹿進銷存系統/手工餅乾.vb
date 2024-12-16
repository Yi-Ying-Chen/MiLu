Imports System.Data.SqlClient
Public Class 手工餅乾
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\資管\大三上\系分\謎鹿\謎鹿.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        耳環.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        吊飾.Show()
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        指甲油.Show()
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        便籤夾.Show()
        Me.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        購物車.Show()
        Me.Visible = False

        購物車.Label48.Text = Val(購物車.Label14.Text) + Val(購物車.Label15.Text) + Val(購物車.Label16.Text) + Val(購物車.Label17.Text) + Val(購物車.Label18.Text) + Val(購物車.Label19.Text) + Val(購物車.Label20.Text) + Val(購物車.Label21.Text) + Val(購物車.Label30.Text) + Val(購物車.Label31.Text) + Val(購物車.Label32.Text) + Val(購物車.Label33.Text) + Val(購物車.Label43.Text) + Val(購物車.Label45.Text) + Val(購物車.Label51.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        訂單.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (TextBox1.Text = "小橘花朵" Or TextBox1.Text = "雙園耳環" Or TextBox1.Text = "螺旋金" Or TextBox1.Text = "毛球") Then
            MsgBox("該商品位於耳環類別")
        End If
        If (TextBox1.Text = "艷紫碎花" Or TextBox1.Text = "亮黃碎花" Or TextBox1.Text = "柔橘碎花" Or TextBox1.Text = "甜粉碎花") Then
            MsgBox("該商品位於吊飾類別")
        End If
        If (TextBox1.Text = "Sandcastles沙堡" Or TextBox1.Text = "Blush酡顏" Or TextBox1.Text = "Agate紅瑪瑙" Or TextBox1.Text = "Olive橄欖") Then
            MsgBox("該商品位於指甲油類別")
        End If
        If (TextBox1.Text = "萌柴便籤夾") Then
            MsgBox("該商品位於便籤夾類別")
        End If
        If (TextBox1.Text = "謎鹿手工餅乾") Then
            MsgBox("該商品位於手工餅乾類別")
        End If
    End Sub

    Private Sub 手工餅乾_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.購物車' 資料表。您可以視需要進行移動或移除。
        Me.購物車TableAdapter.Fill(Me.謎鹿DataSet.購物車)
        Label11.Text = 登入.TextBox1.Text

        Dim myReader1 As SqlDataReader
        Dim mySqlCommand1 As SqlCommand

        mySqlCommand1 = New SqlCommand("SELECT 庫存數量 from 商品 WHERE 商品編號= '" & Label2.Text & "'", conn)
        Try
            conn.Open()
            myReader1 = mySqlCommand1.ExecuteReader()
            Do While (myReader1.Read())
                Label5.Text = myReader1("庫存數量").ToString() '→給Label值
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            If Not (myReader1 Is Nothing) Then
                myReader1.Close()
            End If

            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        conn.Open()

        購物車.Label10.Text = Val(購物車.Label10.Text) + Val(耳環.TextBox2.Text)
        購物車.Label11.Text = Val(購物車.Label11.Text) + Val(耳環.TextBox3.Text)
        購物車.Label12.Text = Val(購物車.Label12.Text) + Val(耳環.TextBox4.Text)
        購物車.Label13.Text = Val(購物車.Label13.Text) + Val(耳環.TextBox5.Text)
        購物車.Label25.Text = Val(購物車.Label25.Text) + Val(吊飾.TextBox5.Text)
        購物車.Label24.Text = Val(購物車.Label24.Text) + Val(吊飾.TextBox3.Text)
        購物車.Label23.Text = Val(購物車.Label23.Text) + Val(吊飾.TextBox4.Text)
        購物車.Label22.Text = Val(購物車.Label22.Text) + Val(吊飾.TextBox2.Text)
        購物車.Label37.Text = Val(購物車.Label37.Text) + Val(指甲油.TextBox3.Text)
        購物車.Label36.Text = Val(購物車.Label36.Text) + Val(指甲油.TextBox2.Text)
        購物車.Label35.Text = Val(購物車.Label35.Text) + Val(指甲油.TextBox4.Text)
        購物車.Label34.Text = Val(購物車.Label34.Text) + Val(指甲油.TextBox5.Text)
        購物車.Label44.Text = Val(購物車.Label44.Text) + Val(便籤夾.TextBox3.Text)
        購物車.Label46.Text = Val(購物車.Label46.Text) + Val(TextBox3.Text)

        購物車.Label14.Text = 290 * 耳環.TextBox2.Text
        購物車.Label15.Text = 190 * 耳環.TextBox3.Text
        購物車.Label16.Text = 190 * 耳環.TextBox4.Text
        購物車.Label17.Text = 290 * 耳環.TextBox5.Text
        購物車.Label21.Text = 200 * 吊飾.TextBox2.Text
        購物車.Label20.Text = 200 * 吊飾.TextBox3.Text
        購物車.Label19.Text = 200 * 吊飾.TextBox4.Text
        購物車.Label18.Text = 200 * 吊飾.TextBox5.Text
        購物車.Label32.Text = 380 * 指甲油.TextBox2.Text
        購物車.Label33.Text = 380 * 指甲油.TextBox3.Text
        購物車.Label31.Text = 380 * 指甲油.TextBox4.Text
        購物車.Label30.Text = 290 * 指甲油.TextBox5.Text
        購物車.Label43.Text = 85 * 便籤夾.TextBox3.Text
        購物車.Label45.Text = 30 * TextBox3.Text

        購物車.Label48.Text = Val(購物車.Label14.Text) + Val(購物車.Label15.Text) + Val(購物車.Label16.Text) + Val(購物車.Label17.Text) + Val(購物車.Label18.Text) + Val(購物車.Label19.Text) + Val(購物車.Label20.Text) + Val(購物車.Label21.Text) + Val(購物車.Label30.Text) + Val(購物車.Label31.Text) + Val(購物車.Label32.Text) + Val(購物車.Label33.Text) + Val(購物車.Label43.Text) + Val(購物車.Label45.Text) + Val(購物車.Label51.Text)

        Dim m_會員編號 = 耳環.Label6.Text
        Dim m_運費 = 購物車.Label51.Text
        Dim m_總金額 = 購物車.Label48.Text
        Dim m_購物車編號 = 耳環.Label6.Text + "cart"

        Dim sqladd As String = "INSERT INTO 購物車(會員編號,運費,總金額,購物車編號) VALUES('" & 耳環.Label6.Text & "','" & 購物車.Label51.Text & "','" & 購物車.Label48.Text & "',,'" & 耳環.Label6.Text + "cart" & "')"
        Dim add = New SqlCommand(sqladd, conn)
        Try
            add.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        conn.Close()

        Try
            購物車TableAdapter.InsertQuery(m_會員編號, m_運費, m_總金額, m_購物車編號)
        Catch ex2 As Exception
            MsgBox("請先清空購物車後，重新確認購買數量~", 64)
        End Try

        MsgBox("完成新增")

        Me.購物車DataGridView.Refresh()
        Me.購物車BindingSource.DataSource = 購物車TableAdapter.GetData()
        Me.購物車BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim m_會員編號 = 耳環.Label6.Text

        購物車.Label10.Text = Nothing
        購物車.Label11.Text = Nothing
        購物車.Label12.Text = Nothing
        購物車.Label13.Text = Nothing
        購物車.Label14.Text = Nothing
        購物車.Label15.Text = Nothing
        購物車.Label16.Text = Nothing
        購物車.Label17.Text = Nothing
        購物車.Label18.Text = Nothing
        購物車.Label19.Text = Nothing
        購物車.Label20.Text = Nothing
        購物車.Label21.Text = Nothing
        購物車.Label22.Text = Nothing
        購物車.Label23.Text = Nothing
        購物車.Label24.Text = Nothing
        購物車.Label25.Text = Nothing
        購物車.Label30.Text = Nothing
        購物車.Label31.Text = Nothing
        購物車.Label32.Text = Nothing
        購物車.Label33.Text = Nothing
        購物車.Label34.Text = Nothing
        購物車.Label35.Text = Nothing
        購物車.Label36.Text = Nothing
        購物車.Label37.Text = Nothing
        購物車.Label43.Text = Nothing
        購物車.Label44.Text = Nothing
        購物車.Label45.Text = Nothing
        購物車.Label46.Text = Nothing

        conn.Open()
        Dim sqldel As String = "DELETE FROM 購物車 WHERE 會員編號 IN ('" & 耳環.Label6.Text & "')"
        Dim del = New SqlCommand(sqldel, conn)
        del.ExecuteNonQuery()
        MsgBox("刪除成功!!!")
        conn.Close()

        Me.購物車TableAdapter.DeleteQuery(m_會員編號)

        購物車DataGridView.Refresh()
        Me.購物車BindingSource.DataSource = 購物車TableAdapter.GetData()
        Me.購物車BindingSource.ResetBindings(False)
    End Sub
End Class