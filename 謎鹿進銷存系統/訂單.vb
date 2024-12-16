Imports System.Data.SqlClient
Public Class 訂單
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\資管\大三上\系分\謎鹿\謎鹿.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        耳環.Show()
        Me.Visible = False
    End Sub

    Private Sub 訂單_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '謎鹿DataSet.訂單' 資料表。您可以視需要進行移動或移除。
        Me.訂單TableAdapter.Fill(Me.謎鹿DataSet.訂單)

        Dim myReader1 As SqlDataReader
        Dim mySqlCommand1 As SqlCommand
        mySqlCommand1 = New SqlCommand("SELECT 會員編號 from 訂單 WHERE 會員編號= '" & 耳環.Label6.Text & "'", conn)
        Try
            conn.Open()
            myReader1 = mySqlCommand1.ExecuteReader()
            Do While (myReader1.Read())
                Label7.Text = myReader1("會員編號").ToString() '→給Label值
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

        Dim myReader2 As SqlDataReader
        Dim mySqlCommand2 As SqlCommand
        mySqlCommand2 = New SqlCommand("SELECT 付款方式 from 訂單 WHERE 會員編號= '" & 耳環.Label6.Text & "'", conn)
        Try
            conn.Open()
            myReader2 = mySqlCommand2.ExecuteReader()
            Do While (myReader2.Read())
                Label8.Text = myReader2("付款方式").ToString() '→給Label值
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            If Not (myReader2 Is Nothing) Then
                myReader2.Close()
            End If

            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try

        Dim myReader3 As SqlDataReader
        Dim mySqlCommand3 As SqlCommand
        mySqlCommand3 = New SqlCommand("SELECT 取貨方式 from 訂單 WHERE 會員編號= '" & 耳環.Label6.Text & "'", conn)
        Try
            conn.Open()
            myReader3 = mySqlCommand3.ExecuteReader()
            Do While (myReader3.Read())
                Label9.Text = myReader3("取貨方式").ToString() '→給Label值
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            If Not (myReader3 Is Nothing) Then
                myReader3.Close()
            End If

            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try

        Dim myReader4 As SqlDataReader
        Dim mySqlCommand4 As SqlCommand
        mySqlCommand4 = New SqlCommand("SELECT 訂單日期 from 訂單 WHERE 會員編號= '" & 耳環.Label6.Text & "'", conn)
        Try
            conn.Open()
            myReader4 = mySqlCommand4.ExecuteReader()
            Do While (myReader4.Read())
                Label10.Text = myReader4("訂單日期").ToString() '→給Label值
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            If Not (myReader4 Is Nothing) Then
                myReader4.Close()
            End If

            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try

        Dim myReader5 As SqlDataReader
        Dim mySqlCommand5 As SqlCommand
        mySqlCommand5 = New SqlCommand("SELECT 訂單編號 from 訂單 WHERE 會員編號= '" & 耳環.Label6.Text & "'", conn)
        Try
            conn.Open()
            myReader5 = mySqlCommand5.ExecuteReader()
            Do While (myReader5.Read())
                Label11.Text = myReader5("訂單編號").ToString() '→給Label值
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            If Not (myReader5 Is Nothing) Then
                myReader5.Close()
            End If

            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn.Open()

        Dim m_訂單編號 = 耳環.Label6.Text

        Dim sqldel As String = "DELETE FROM 訂單 WHERE 訂單編號 IN ('" & Label11.Text & "')"
        Dim del = New SqlCommand(sqldel, conn)
        del.ExecuteNonQuery()
        MsgBox("刪除成功!!!")
        conn.Close()

        Me.訂單TableAdapter.DeleteQuery(m_訂單編號)

        訂單DataGridView.Refresh()
        Me.訂單BindingSource.DataSource = 訂單TableAdapter.GetData()
        Me.訂單BindingSource.ResetBindings(False)
    End Sub
End Class