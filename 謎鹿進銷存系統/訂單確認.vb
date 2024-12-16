Imports System.Data.SqlClient
Public Class 訂單確認
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\資管\大三上\系分\謎鹿\謎鹿.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        購物車.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '新增訂單
        conn.Open()

        Dim t As Date
        t = Today

        Dim m_訂單編號 = 耳環.Label6.Text + 耳環.Label20.Text
        Dim m_付款方式 = ComboBox1.Text
        Dim m_取貨方式 = ComboBox2.Text
        Dim m_訂單日期 = t
        Dim m_會員編號 = 耳環.Label6.Text
        Dim m_購物車編號 = 耳環.Label6.Text + "cart"


        Dim sqladd As String = "INSERT INTO 訂單(訂單編號,付款方式,取貨方式,訂單日期,會員編號,購物車編號) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text & "',N'" & ComboBox1.Text & "',N'" & ComboBox2.Text & "','" & t & "','" & 耳環.Label6.Text & "','" & 耳環.Label6.Text + "cart" & "')"
        Dim add = New SqlCommand(sqladd, conn)
        add.ExecuteNonQuery()
        訂單.Show()
        Me.Visible = False
        MsgBox("購買成功!")
        conn.Close()

        Try
            Me.訂單TableAdapter.InsertQuery(m_訂單編號, m_付款方式, m_取貨方式, m_訂單日期, m_會員編號, m_購物車編號)
        Catch ex1 As Exception
        End Try

        Me.訂單DataGridView.Refresh()
        Me.訂單BindingSource.DataSource = 訂單TableAdapter.GetData()
        Me.訂單BindingSource.ResetBindings(False)

        '新增商品編號1紀錄
        conn.Open()
        Dim m_訂單編號1 = 耳環.Label6.Text + 耳環.Label20.Text + "a"
        Dim m_商品編號1 = 耳環.Label25.Text
        Dim m_訂購數量1 = 耳環.TextBox2.Text
        Dim m_價錢1 = 290 * Val(耳環.TextBox2.Text)

        Dim sqladd1 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "a" & "','" & 耳環.Label25.Text & "','" & 耳環.TextBox2.Text & "','" & 290 * Val(耳環.TextBox2.Text) & "')"
        Dim add1 = New SqlCommand(sqladd1, conn)
        add1.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號1, m_商品編號1, m_訂購數量1, m_價錢1)
        Catch ex2 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號1)
        conn.Open()
        Dim m_會員編號1 = 耳環.Label6.Text + "a" + 耳環.Label20.Text
        Dim m_商品編號1a = 耳環.Label25.Text
        Dim m_訂購數量1a = 耳環.TextBox2.Text

        Dim sqladd1a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "a" + 耳環.Label20.Text & "','" & 耳環.Label25.Text & "','" & 耳環.TextBox2.Text & "')"
        Dim add1a = New SqlCommand(sqladd1a, conn)
        add1a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號1, m_商品編號1a, m_訂購數量1a)
        Catch ex3 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號2紀錄
        conn.Open()
        Dim m_訂單編號2 = 耳環.Label6.Text + 耳環.Label20.Text + "b"
        Dim m_商品編號2 = 耳環.Label26.Text
        Dim m_訂購數量2 = 耳環.TextBox3.Text
        Dim m_價錢2 = 190 * Val(耳環.TextBox3.Text)

        Dim sqladd2 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "b" & "','" & 耳環.Label26.Text & "','" & 耳環.TextBox3.Text & "','" & 190 * Val(耳環.TextBox3.Text) & "')"
        Dim add2 = New SqlCommand(sqladd2, conn)
        add2.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號2, m_商品編號2, m_訂購數量2, m_價錢2)
        Catch ex4 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號2)
        conn.Open()
        Dim m_會員編號2 = 耳環.Label6.Text + "b" + 耳環.Label20.Text
        Dim m_商品編號2a = 耳環.Label26.Text
        Dim m_訂購數量2a = 耳環.TextBox3.Text

        Dim sqladd2a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "b" + 耳環.Label20.Text & "','" & 耳環.Label26.Text & "','" & 耳環.TextBox3.Text & "')"
        Dim add2a = New SqlCommand(sqladd2a, conn)
        add2a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號2, m_商品編號2a, m_訂購數量2a)
        Catch ex5 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號3紀錄
        conn.Open()
        Dim m_訂單編號3 = 耳環.Label6.Text + 耳環.Label20.Text + "c"
        Dim m_商品編號3 = 耳環.Label27.Text
        Dim m_訂購數量3 = 耳環.TextBox4.Text
        Dim m_價錢3 = 190 * Val(耳環.TextBox4.Text)

        Dim sqladd3 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "c" & "','" & 耳環.Label27.Text & "','" & 耳環.TextBox4.Text & "','" & 190 * Val(耳環.TextBox4.Text) & "')"
        Dim add3 = New SqlCommand(sqladd3, conn)
        add3.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號3, m_商品編號3, m_訂購數量3, m_價錢3)
        Catch ex6 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號3)
        conn.Open()
        Dim m_會員編號3 = 耳環.Label6.Text + "c" + 耳環.Label20.Text
        Dim m_商品編號3a = 耳環.Label27.Text
        Dim m_訂購數量3a = 耳環.TextBox4.Text

        Dim sqladd3a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "c" + 耳環.Label20.Text & "','" & 耳環.Label27.Text & "','" & 耳環.TextBox4.Text & "')"
        Dim add3a = New SqlCommand(sqladd3a, conn)
        add3a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號3, m_商品編號3a, m_訂購數量3a)
        Catch ex7 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號4紀錄
        conn.Open()
        Dim m_訂單編號4 = 耳環.Label6.Text + 耳環.Label20.Text + "d"
        Dim m_商品編號4 = 耳環.Label28.Text
        Dim m_訂購數量4 = 耳環.TextBox5.Text
        Dim m_價錢4 = 290 * Val(耳環.TextBox5.Text)

        Dim sqladd4 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "d" & "','" & 耳環.Label28.Text & "','" & 耳環.TextBox5.Text & "','" & 290 * Val(耳環.TextBox5.Text) & "')"
        Dim add4 = New SqlCommand(sqladd4, conn)
        add4.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號4, m_商品編號4, m_訂購數量4, m_價錢4)
        Catch ex8 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號4)
        conn.Open()
        Dim m_會員編號4 = 耳環.Label6.Text + "d" + 耳環.Label20.Text
        Dim m_商品編號4a = 耳環.Label28.Text
        Dim m_訂購數量4a = 耳環.TextBox5.Text

        Dim sqladd4a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "d" + 耳環.Label20.Text & "','" & 耳環.Label28.Text & "','" & 耳環.TextBox5.Text & "')"
        Dim add4a = New SqlCommand(sqladd4a, conn)
        add4a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號4, m_商品編號4a, m_訂購數量4a)
        Catch ex9 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號5紀錄
        conn.Open()
        Dim m_訂單編號5 = 耳環.Label6.Text + 耳環.Label20.Text + "e"
        Dim m_商品編號5 = 吊飾.Label12.Text
        Dim m_訂購數量5 = 吊飾.TextBox2.Text
        Dim m_價錢5 = 200 * Val(吊飾.TextBox2.Text)

        Dim sqladd5 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "e" & "','" & 吊飾.Label12.Text & "','" & 吊飾.TextBox2.Text & "','" & 200 * Val(吊飾.TextBox2.Text) & "')"
        Dim add5 = New SqlCommand(sqladd5, conn)
        add5.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號5, m_商品編號5, m_訂購數量5, m_價錢5)
        Catch ex10 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號5)
        conn.Open()
        Dim m_會員編號5 = 耳環.Label6.Text + "e" + 耳環.Label20.Text
        Dim m_商品編號5a = 吊飾.Label12.Text
        Dim m_訂購數量5a = 吊飾.TextBox2.Text

        Dim sqladd5a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "e" + 耳環.Label20.Text & "','" & 吊飾.Label12.Text & "','" & 吊飾.TextBox2.Text & "')"
        Dim add5a = New SqlCommand(sqladd5a, conn)
        add5a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號5, m_商品編號5a, m_訂購數量5a)
        Catch ex11 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號6紀錄
        conn.Open()
        Dim m_訂單編號6 = 耳環.Label6.Text + 耳環.Label20.Text + "f"
        Dim m_商品編號6 = 吊飾.Label13.Text
        Dim m_訂購數量6 = 吊飾.TextBox3.Text
        Dim m_價錢6 = 200 * Val(吊飾.TextBox3.Text)

        Dim sqladd6 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "f" & "','" & 吊飾.Label13.Text & "','" & 吊飾.TextBox3.Text & "','" & 200 * Val(吊飾.TextBox3.Text) & "')"
        Dim add6 = New SqlCommand(sqladd6, conn)
        add6.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號6, m_商品編號6, m_訂購數量6, m_價錢6)
        Catch ex12 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號6)
        conn.Open()
        Dim m_會員編號6 = 耳環.Label6.Text + "f" + 耳環.Label20.Text
        Dim m_商品編號6a = 吊飾.Label13.Text
        Dim m_訂購數量6a = 吊飾.TextBox3.Text

        Dim sqladd6a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "f" + 耳環.Label20.Text & "','" & 吊飾.Label13.Text & "','" & 吊飾.TextBox3.Text & "')"
        Dim add6a = New SqlCommand(sqladd6a, conn)
        add6a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號6, m_商品編號6a, m_訂購數量6a)
        Catch ex13 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號7紀錄
        conn.Open()
        Dim m_訂單編號7 = 耳環.Label6.Text + 耳環.Label20.Text + "g"
        Dim m_商品編號7 = 吊飾.Label14.Text
        Dim m_訂購數量7 = 吊飾.TextBox4.Text
        Dim m_價錢7 = 200 * Val(吊飾.TextBox4.Text)

        Dim sqladd7 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "g" & "','" & 吊飾.Label14.Text & "','" & 吊飾.TextBox4.Text & "','" & 200 * Val(吊飾.TextBox4.Text) & "')"
        Dim add7 = New SqlCommand(sqladd7, conn)
        add7.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號7, m_商品編號7, m_訂購數量7, m_價錢7)
        Catch ex14 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號7)
        conn.Open()
        Dim m_會員編號7 = 耳環.Label6.Text + "g" + 耳環.Label20.Text
        Dim m_商品編號7a = 吊飾.Label14.Text
        Dim m_訂購數量7a = 吊飾.TextBox4.Text

        Dim sqladd7a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "g" + 耳環.Label20.Text & "','" & 吊飾.Label14.Text & "','" & 吊飾.TextBox4.Text & "')"
        Dim add7a = New SqlCommand(sqladd7a, conn)
        add7a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號7, m_商品編號7a, m_訂購數量7a)
        Catch ex15 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號8紀錄
        conn.Open()
        Dim m_訂單編號8 = 耳環.Label6.Text + 耳環.Label20.Text + "h"
        Dim m_商品編號8 = 吊飾.Label15.Text
        Dim m_訂購數量8 = 吊飾.TextBox5.Text
        Dim m_價錢8 = 200 * Val(吊飾.TextBox5.Text)

        Dim sqladd8 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "h" & "','" & 吊飾.Label15.Text & "','" & 吊飾.TextBox5.Text & "','" & 200 * Val(吊飾.TextBox5.Text) & "')"
        Dim add8 = New SqlCommand(sqladd8, conn)
        add8.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號8, m_商品編號8, m_訂購數量8, m_價錢8)
        Catch ex16 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號8)
        conn.Open()
        Dim m_會員編號8 = 耳環.Label6.Text + "h" + 耳環.Label20.Text
        Dim m_商品編號8a = 吊飾.Label15.Text
        Dim m_訂購數量8a = 吊飾.TextBox5.Text

        Dim sqladd8a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "h" + 耳環.Label20.Text & "','" & 吊飾.Label15.Text & "','" & 吊飾.TextBox5.Text & "')"
        Dim add8a = New SqlCommand(sqladd8a, conn)
        add8a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號8, m_商品編號8a, m_訂購數量8a)
        Catch ex17 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號9紀錄
        conn.Open()
        Dim m_訂單編號9 = 耳環.Label6.Text + 耳環.Label20.Text + "i"
        Dim m_商品編號9 = 指甲油.Label12.Text
        Dim m_訂購數量9 = 指甲油.TextBox3.Text
        Dim m_價錢9 = 380 * Val(指甲油.TextBox3.Text)

        Dim sqladd9 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "i" & "','" & 指甲油.Label12.Text & "','" & 指甲油.TextBox3.Text & "','" & 380 * Val(指甲油.TextBox3.Text) & "')"
        Dim add9 = New SqlCommand(sqladd9, conn)
        add9.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號9, m_商品編號9, m_訂購數量9, m_價錢9)
        Catch ex18 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號9)
        conn.Open()
        Dim m_會員編號9 = 耳環.Label6.Text + "i" + 耳環.Label20.Text
        Dim m_商品編號9a = 指甲油.Label12.Text
        Dim m_訂購數量9a = 指甲油.TextBox3.Text

        Dim sqladd9a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "i" + 耳環.Label20.Text & "','" & 指甲油.Label12.Text & "','" & 指甲油.TextBox3.Text & "')"
        Dim add9a = New SqlCommand(sqladd9a, conn)
        add9a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號9, m_商品編號9a, m_訂購數量9a)
        Catch ex19 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號10紀錄
        conn.Open()
        Dim m_訂單編號10 = 耳環.Label6.Text + 耳環.Label20.Text + "j"
        Dim m_商品編號10 = 指甲油.Label13.Text
        Dim m_訂購數量10 = 指甲油.TextBox2.Text
        Dim m_價錢10 = 380 * Val(指甲油.TextBox2.Text)

        Dim sqladd10 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "j" & "','" & 指甲油.Label13.Text & "','" & 指甲油.TextBox2.Text & "','" & 380 * Val(指甲油.TextBox2.Text) & "')"
        Dim add10 = New SqlCommand(sqladd10, conn)
        add10.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號10, m_商品編號10, m_訂購數量10, m_價錢10)
        Catch ex20 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號10)
        conn.Open()
        Dim m_會員編號10 = 耳環.Label6.Text + "j" + 耳環.Label20.Text
        Dim m_商品編號10a = 指甲油.Label13.Text
        Dim m_訂購數量10a = 指甲油.TextBox2.Text

        Dim sqladd10a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "j" + 耳環.Label20.Text & "','" & 指甲油.Label13.Text & "','" & 指甲油.TextBox2.Text & "')"
        Dim add10a = New SqlCommand(sqladd10a, conn)
        add10a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號10, m_商品編號10a, m_訂購數量10a)
        Catch ex21 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號11紀錄
        conn.Open()
        Dim m_訂單編號11 = 耳環.Label6.Text + 耳環.Label20.Text + "k"
        Dim m_商品編號11 = 指甲油.Label14.Text
        Dim m_訂購數量11 = 指甲油.TextBox4.Text
        Dim m_價錢11 = 380 * Val(指甲油.TextBox4.Text)

        Dim sqladd11 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "k" & "','" & 指甲油.Label14.Text & "','" & 指甲油.TextBox4.Text & "','" & 380 * Val(指甲油.TextBox4.Text) & "')"
        Dim add11 = New SqlCommand(sqladd11, conn)
        add11.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號11, m_商品編號11, m_訂購數量11, m_價錢11)
        Catch ex22 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號11)
        conn.Open()
        Dim m_會員編號11 = 耳環.Label6.Text + "k" + 耳環.Label20.Text
        Dim m_商品編號11a = 指甲油.Label14.Text
        Dim m_訂購數量11a = 指甲油.TextBox4.Text

        Dim sqladd11a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "k" + 耳環.Label20.Text & "','" & 指甲油.Label14.Text & "','" & 指甲油.TextBox4.Text & "')"
        Dim add11a = New SqlCommand(sqladd11a, conn)
        add11a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號11, m_商品編號11a, m_訂購數量11a)
        Catch ex23 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號12紀錄
        conn.Open()
        Dim m_訂單編號12 = 耳環.Label6.Text + 耳環.Label20.Text + "l"
        Dim m_商品編號12 = 指甲油.Label15.Text
        Dim m_訂購數量12 = 指甲油.TextBox5.Text
        Dim m_價錢12 = 290 * Val(指甲油.TextBox5.Text)

        Dim sqladd12 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "l" & "','" & 指甲油.Label15.Text & "','" & 指甲油.TextBox5.Text & "','" & 290 * Val(指甲油.TextBox5.Text) & "')"
        Dim add12 = New SqlCommand(sqladd12, conn)
        add12.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號12, m_商品編號12, m_訂購數量12, m_價錢12)
        Catch ex24 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號12)
        conn.Open()
        Dim m_會員編號12 = 耳環.Label6.Text + "l" + 耳環.Label20.Text
        Dim m_商品編號12a = 指甲油.Label15.Text
        Dim m_訂購數量12a = 指甲油.TextBox5.Text

        Dim sqladd12a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "l" + 耳環.Label20.Text & "','" & 指甲油.Label15.Text & "','" & 指甲油.TextBox5.Text & "')"
        Dim add12a = New SqlCommand(sqladd12a, conn)
        add12a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號12, m_商品編號12a, m_訂購數量12a)
        Catch ex25 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號13紀錄
        conn.Open()
        Dim m_訂單編號13 = 耳環.Label6.Text + 耳環.Label20.Text + "m"
        Dim m_商品編號13 = 便籤夾.Label2.Text
        Dim m_訂購數量13 = 便籤夾.TextBox3.Text
        Dim m_價錢13 = 85 * Val(便籤夾.TextBox3.Text)

        Dim sqladd13 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "m" & "','" & 便籤夾.Label2.Text & "','" & 便籤夾.TextBox3.Text & "','" & 85 * Val(便籤夾.TextBox3.Text) & "')"
        Dim add13 = New SqlCommand(sqladd13, conn)
        add13.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號13, m_商品編號13, m_訂購數量13, m_價錢13)
        Catch ex26 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號13)
        conn.Open()
        Dim m_會員編號13 = 耳環.Label6.Text + "m" + 耳環.Label20.Text
        Dim m_商品編號13a = 便籤夾.Label2.Text
        Dim m_訂購數量13a = 便籤夾.TextBox3.Text

        Dim sqladd13a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "m" + 耳環.Label20.Text & "','" & 便籤夾.Label2.Text & "','" & 便籤夾.TextBox3.Text & "')"
        Dim add13a = New SqlCommand(sqladd13a, conn)
        add13a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號13, m_商品編號13a, m_訂購數量13a)
        Catch ex27 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '新增商品編號14紀錄
        conn.Open()
        Dim m_訂單編號14 = 耳環.Label6.Text + 耳環.Label20.Text + "n"
        Dim m_商品編號14 = 手工餅乾.Label2.Text
        Dim m_訂購數量14 = 手工餅乾.TextBox3.Text
        Dim m_價錢14 = 30 * Val(手工餅乾.TextBox3.Text)

        Dim sqladd14 As String = "INSERT INTO 紀錄(訂單編號,商品編號,訂購數量,價錢) VALUES('" & 耳環.Label6.Text + 耳環.Label20.Text + "n" & "','" & 手工餅乾.Label2.Text & "','" & 手工餅乾.TextBox3.Text & "','" & 30 * Val(手工餅乾.TextBox3.Text) & "')"
        Dim add14 = New SqlCommand(sqladd14, conn)
        add14.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.紀錄TableAdapter.InsertQuery(m_訂單編號14, m_商品編號14, m_訂購數量14, m_價錢14)
        Catch ex28 As Exception
        End Try

        Me.紀錄DataGridView.Refresh()
        Me.紀錄BindingSource.DataSource = 紀錄TableAdapter.GetData()
        Me.紀錄BindingSource.ResetBindings(False)

        '新增會員購買紀錄(商品編號14)
        conn.Open()
        Dim m_會員編號14 = 耳環.Label6.Text + "n" + 耳環.Label20.Text
        Dim m_商品編號14a = 手工餅乾.Label2.Text
        Dim m_訂購數量14a = 手工餅乾.TextBox3.Text

        Dim sqladd14a As String = "INSERT INTO 訂購(會員編號,商品編號,訂購數量) VALUES('" & 耳環.Label6.Text + "n" + 耳環.Label20.Text & "','" & 手工餅乾.Label2.Text & "','" & 手工餅乾.TextBox3.Text & "')"
        Dim add14a = New SqlCommand(sqladd14a, conn)
        add14a.ExecuteNonQuery()
        Me.Visible = False
        conn.Close()

        Try
            Me.訂購TableAdapter.InsertQuery(m_會員編號14, m_商品編號14a, m_訂購數量14a)
        Catch ex29 As Exception
        End Try

        Me.訂購DataGridView.Refresh()
        Me.訂購BindingSource.DataSource = 訂購TableAdapter.GetData()
        Me.訂購BindingSource.ResetBindings(False)

        '修改商品編號1庫存數量
        conn.Open()

        Dim m_庫存數量1 = Val(耳環.Label21.Text) - Val(耳環.TextBox2.Text)
        Dim m_商品編號1b = 耳環.Label25.Text


        Dim sqlupd1 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(耳環.Label21.Text) - Val(耳環.TextBox2.Text) & "' WHERE 商品編號 ='" & 耳環.Label25.Text & "'"
        Dim upd1 = New SqlCommand(sqlupd1, conn)
        Try
            upd1.ExecuteNonQuery()
        Catch ex30 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量1, m_商品編號1b)
        Catch ex31 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號2庫存數量
        conn.Open()

        Dim m_庫存數量2 = Val(耳環.Label22.Text) - Val(耳環.TextBox3.Text)
        Dim m_商品編號2b = 耳環.Label26.Text


        Dim sqlupd2 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(耳環.Label22.Text) - Val(耳環.TextBox3.Text) & "' WHERE 商品編號 ='" & 耳環.Label26.Text & "'"
        Dim upd2 = New SqlCommand(sqlupd2, conn)
        Try
            upd2.ExecuteNonQuery()
        Catch ex32 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量2, m_商品編號2b)
        Catch ex33 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號3庫存數量
        conn.Open()

        Dim m_庫存數量3 = Val(耳環.Label23.Text) - Val(耳環.TextBox4.Text)
        Dim m_商品編號3b = 耳環.Label27.Text


        Dim sqlupd3 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(耳環.Label23.Text) - Val(耳環.TextBox4.Text) & "' WHERE 商品編號 ='" & 耳環.Label27.Text & "'"
        Dim upd3 = New SqlCommand(sqlupd3, conn)
        Try
            upd3.ExecuteNonQuery()
        Catch ex34 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量3, m_商品編號3b)
        Catch ex35 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號4庫存數量
        conn.Open()

        Dim m_庫存數量4 = Val(耳環.Label24.Text) - Val(耳環.TextBox5.Text)
        Dim m_商品編號4b = 耳環.Label28.Text


        Dim sqlupd4 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(耳環.Label24.Text) - Val(耳環.TextBox5.Text) & "' WHERE 商品編號 ='" & 耳環.Label28.Text & "'"
        Dim upd4 = New SqlCommand(sqlupd4, conn)
        Try
            upd4.ExecuteNonQuery()
        Catch ex36 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量4, m_商品編號4b)
        Catch ex37 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號5庫存數量
        conn.Open()

        Dim m_庫存數量5 = Val(吊飾.Label20.Text) - Val(吊飾.TextBox2.Text)
        Dim m_商品編號5b = 吊飾.Label12.Text


        Dim sqlupd5 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(吊飾.Label20.Text) - Val(吊飾.TextBox2.Text) & "' WHERE 商品編號 ='" & 吊飾.Label12.Text & "'"
        Dim upd5 = New SqlCommand(sqlupd5, conn)
        Try
            upd5.ExecuteNonQuery()
        Catch ex38 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量5, m_商品編號5b)
        Catch ex39 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號6庫存數量
        conn.Open()

        Dim m_庫存數量6 = Val(吊飾.Label21.Text) - Val(吊飾.TextBox3.Text)
        Dim m_商品編號6b = 吊飾.Label13.Text


        Dim sqlupd6 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(吊飾.Label21.Text) - Val(吊飾.TextBox3.Text) & "' WHERE 商品編號 ='" & 吊飾.Label13.Text & "'"
        Dim upd6 = New SqlCommand(sqlupd6, conn)
        Try
            upd6.ExecuteNonQuery()
        Catch ex40 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量6, m_商品編號6b)
        Catch ex41 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號7庫存數量
        conn.Open()

        Dim m_庫存數量7 = Val(吊飾.Label22.Text) - Val(吊飾.TextBox4.Text)
        Dim m_商品編號7b = 吊飾.Label14.Text


        Dim sqlupd7 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(吊飾.Label22.Text) - Val(吊飾.TextBox4.Text) & "' WHERE 商品編號 ='" & 吊飾.Label14.Text & "'"
        Dim upd7 = New SqlCommand(sqlupd7, conn)
        Try
            upd7.ExecuteNonQuery()
        Catch ex42 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量7, m_商品編號7b)
        Catch ex43 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號8庫存數量
        conn.Open()

        Dim m_庫存數量8 = Val(吊飾.Label23.Text) - Val(吊飾.TextBox5.Text)
        Dim m_商品編號8b = 吊飾.Label15.Text


        Dim sqlupd8 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(吊飾.Label23.Text) - Val(吊飾.TextBox5.Text) & "' WHERE 商品編號 ='" & 吊飾.Label15.Text & "'"
        Dim upd8 = New SqlCommand(sqlupd8, conn)
        Try
            upd8.ExecuteNonQuery()
        Catch ex44 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量8, m_商品編號8b)
        Catch ex45 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號9庫存數量
        conn.Open()

        Dim m_庫存數量9 = Val(指甲油.Label20.Text) - Val(指甲油.TextBox3.Text)
        Dim m_商品編號9b = 指甲油.Label12.Text


        Dim sqlupd9 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(指甲油.Label20.Text) - Val(指甲油.TextBox3.Text) & "' WHERE 商品編號 ='" & 指甲油.Label12.Text & "'"
        Dim upd9 = New SqlCommand(sqlupd9, conn)
        Try
            upd9.ExecuteNonQuery()
        Catch ex46 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量9, m_商品編號9b)
        Catch ex47 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號10庫存數量
        conn.Open()

        Dim m_庫存數量10 = Val(指甲油.Label21.Text) - Val(指甲油.TextBox2.Text)
        Dim m_商品編號10b = 指甲油.Label13.Text


        Dim sqlupd10 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(指甲油.Label21.Text) - Val(指甲油.TextBox2.Text) & "' WHERE 商品編號 ='" & 指甲油.Label13.Text & "'"
        Dim upd10 = New SqlCommand(sqlupd10, conn)
        Try
            upd10.ExecuteNonQuery()
        Catch ex48 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量10, m_商品編號10b)
        Catch ex49 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號11庫存數量
        conn.Open()

        Dim m_庫存數量11 = Val(指甲油.Label22.Text) - Val(指甲油.TextBox4.Text)
        Dim m_商品編號11b = 指甲油.Label14.Text


        Dim sqlupd11 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(指甲油.Label22.Text) - Val(指甲油.TextBox4.Text) & "' WHERE 商品編號 ='" & 指甲油.Label14.Text & "'"
        Dim upd11 = New SqlCommand(sqlupd11, conn)
        Try
            upd11.ExecuteNonQuery()
        Catch ex50 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量11, m_商品編號11b)
        Catch ex51 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號12庫存數量
        conn.Open()

        Dim m_庫存數量12 = Val(指甲油.Label23.Text) - Val(指甲油.TextBox5.Text)
        Dim m_商品編號12b = 指甲油.Label15.Text


        Dim sqlupd12 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(指甲油.Label23.Text) - Val(指甲油.TextBox5.Text) & "' WHERE 商品編號 ='" & 指甲油.Label15.Text & "'"
        Dim upd12 = New SqlCommand(sqlupd12, conn)
        Try
            upd12.ExecuteNonQuery()
        Catch ex52 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量12, m_商品編號12b)
        Catch ex53 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號13庫存數量
        conn.Open()

        Dim m_庫存數量13 = Val(便籤夾.Label5.Text) - Val(便籤夾.TextBox3.Text)
        Dim m_商品編號13b = 便籤夾.Label2.Text


        Dim sqlupd13 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(便籤夾.Label5.Text) - Val(便籤夾.TextBox3.Text) & "' WHERE 商品編號 ='" & 便籤夾.Label2.Text & "'"
        Dim upd13 = New SqlCommand(sqlupd13, conn)
        Try
            upd13.ExecuteNonQuery()
        Catch ex54 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量13, m_商品編號13b)
        Catch ex55 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)

        '修改商品編號14庫存數量
        conn.Open()

        Dim m_庫存數量14 = Val(手工餅乾.Label5.Text) - Val(手工餅乾.TextBox3.Text)
        Dim m_商品編號14b = 手工餅乾.Label2.Text


        Dim sqlupd14 As String = "UPDATE 商品 Set 商品編號 = 庫存數量 = '" & Val(手工餅乾.Label5.Text) - Val(手工餅乾.TextBox3.Text) & "' WHERE 商品編號 ='" & 手工餅乾.Label2.Text & "'"
        Dim upd14 = New SqlCommand(sqlupd14, conn)
        Try
            upd14.ExecuteNonQuery()
        Catch ex56 As Exception
        End Try
        conn.Close()

        Try
            商品TableAdapter.UpdateQueryNumber(m_庫存數量14, m_商品編號14b)
        Catch ex57 As Exception
        End Try
        Me.商品DataGridView.Refresh()
        Me.商品BindingSource.DataSource = 商品TableAdapter.GetData()
        Me.商品BindingSource.ResetBindings(False)
    End Sub

    Private Sub 訂單確認_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.商品' 資料表。您可以視需要進行移動或移除。
        Me.商品TableAdapter.Fill(Me.謎鹿DataSet.商品)
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.訂購' 資料表。您可以視需要進行移動或移除。
        Me.訂購TableAdapter.Fill(Me.謎鹿DataSet.訂購)
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.紀錄' 資料表。您可以視需要進行移動或移除。
        Me.紀錄TableAdapter.Fill(Me.謎鹿DataSet.紀錄)
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.訂單' 資料表。您可以視需要進行移動或移除。
        Me.訂單TableAdapter.Fill(Me.謎鹿DataSet.訂單)
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.訂單' 資料表。您可以視需要進行移動或移除。
        Me.訂單TableAdapter.Fill(Me.謎鹿DataSet.訂單)

        Label6.Text = 購物車.Label48.Text
    End Sub
End Class