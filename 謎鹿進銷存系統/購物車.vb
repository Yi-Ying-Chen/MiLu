Imports System.Data.SqlClient
Public Class 購物車
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\資管\大三上\系分\謎鹿\謎鹿.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((Val(耳環.TextBox2.Text) > Val(耳環.Label21.Text)) Or
            (Val(耳環.TextBox3.Text) > Val(耳環.Label22.Text)) Or
            (Val(耳環.TextBox4.Text) > Val(耳環.Label23.Text)) Or
            (Val(耳環.TextBox5.Text) > Val(耳環.Label24.Text))) Or
            (Val(吊飾.TextBox2.Text) > Val(吊飾.Label20.Text)) Or
            (Val(吊飾.TextBox3.Text) > Val(吊飾.Label21.Text)) Or
            (Val(吊飾.TextBox4.Text) > Val(吊飾.Label22.Text)) Or
            (Val(吊飾.TextBox5.Text) > Val(吊飾.Label23.Text)) Or
            (Val(指甲油.TextBox3.Text) > Val(指甲油.Label20.Text)) Or
            (Val(指甲油.TextBox2.Text) > Val(指甲油.Label21.Text)) Or
            (Val(指甲油.TextBox4.Text) > Val(指甲油.Label22.Text)) Or
            (Val(指甲油.TextBox5.Text) > Val(指甲油.Label23.Text)) Or
            (Val(便籤夾.TextBox3.Text) > Val(便籤夾.Label5.Text)) Or
            (Val(手工餅乾.TextBox3.Text) > Val(手工餅乾.Label5.Text)) Then
            MsgBox("庫存數量不足，請重新確認購買數量")
        Else
            訂單確認.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub 購物車_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Val(Label10.Text) = 0) Then
            Label10.Text = Nothing
        End If

        If (Val(Label11.Text) = 0) Then
            Label11.Text = Nothing
        End If

        If (Val(Label12.Text) = 0) Then
            Label12.Text = Nothing
        End If

        If (Val(Label13.Text) = 0) Then
            Label13.Text = Nothing
        End If

        If (Val(Label14.Text) = 0) Then
            Label14.Text = Nothing
        End If

        If (Val(Label15.Text) = 0) Then
            Label15.Text = Nothing
        End If

        If (Val(Label16.Text) = 0) Then
            Label16.Text = Nothing
        End If

        If (Val(Label17.Text) = 0) Then
            Label17.Text = Nothing
        End If

        If (Val(Label18.Text) = 0) Then
            Label18.Text = Nothing
        End If

        If (Val(Label19.Text) = 0) Then
            Label19.Text = Nothing
        End If

        If (Val(Label20.Text) = 0) Then
            Label20.Text = Nothing
        End If

        If (Val(Label21.Text) = 0) Then
            Label21.Text = Nothing
        End If

        If (Val(Label22.Text) = 0) Then
            Label22.Text = Nothing
        End If

        If (Val(Label23.Text) = 0) Then
            Label23.Text = Nothing
        End If

        If (Val(Label24.Text) = 0) Then
            Label24.Text = Nothing
        End If

        If (Val(Label25.Text) = 0) Then
            Label25.Text = Nothing
        End If

        If (Val(Label30.Text) = 0) Then
            Label30.Text = Nothing
        End If

        If (Val(Label31.Text) = 0) Then
            Label31.Text = Nothing
        End If

        If (Val(Label32.Text) = 0) Then
            Label32.Text = Nothing
        End If

        If (Val(Label33.Text) = 0) Then
            Label33.Text = Nothing
        End If

        If (Val(Label34.Text) = 0) Then
            Label34.Text = Nothing
        End If

        If (Val(Label35.Text) = 0) Then
            Label35.Text = Nothing
        End If

        If (Val(Label36.Text) = 0) Then
            Label36.Text = Nothing
        End If

        If (Val(Label37.Text) = 0) Then
            Label37.Text = Nothing
        End If

        If (Val(Label43.Text) = 0) Then
            Label43.Text = Nothing
        End If

        If (Val(Label45.Text) = 0) Then
            Label45.Text = Nothing
        End If

        Label48.Text = Val(Label14.Text) + Val(Label15.Text) + Val(Label16.Text) + Val(Label17.Text) +
            Val(Label18.Text) + Val(Label19.Text) + Val(Label20.Text) + Val(Label21.Text) +
            Val(Label30.Text) + Val(Label31.Text) + Val(Label32.Text) + Val(Label33.Text) +
            Val(Label43.Text) + Val(Label45.Text) + Val(Label51.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        耳環.Show()
        Me.Visible = False
    End Sub

End Class