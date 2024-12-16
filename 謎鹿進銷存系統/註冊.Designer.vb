<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 註冊
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(註冊))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.會員DataGridView = New System.Windows.Forms.DataGridView()
        Me.會員編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.帳號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.密碼DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.姓名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.電話DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.住址DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.會員BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.謎鹿DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.謎鹿DataSet = New 謎鹿進銷存系統.謎鹿DataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.會員TableAdapter = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.會員TableAdapter()
        CType(Me.會員DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.會員BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.謎鹿DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.謎鹿DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Gray
        Me.Button3.Location = New System.Drawing.Point(500, 409)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 32)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "註冊"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(382, 107)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 78)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "會員登入"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(209, 107)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 78)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "註冊會員"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(273, 238)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(211, 22)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(273, 200)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 22)
        Me.TextBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SeaShell
        Me.Label1.Location = New System.Drawing.Point(210, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 362)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(286, 275)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(211, 22)
        Me.TextBox3.TabIndex = 14
        Me.TextBox3.UseSystemPasswordChar = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(273, 343)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(211, 22)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(273, 379)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(211, 22)
        Me.TextBox6.TabIndex = 16
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(273, 415)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(211, 22)
        Me.TextBox7.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SeaShell
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "帳號"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SeaShell
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(229, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "密碼"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SeaShell
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(211, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "再次輸入密碼"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.SeaShell
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(216, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 19)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "E-mail"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.SeaShell
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(212, 381)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "手機號碼"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.SeaShell
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(229, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "地址"
        '
        '會員DataGridView
        '
        Me.會員DataGridView.AutoGenerateColumns = False
        Me.會員DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.會員DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.會員編號DataGridViewTextBoxColumn, Me.帳號DataGridViewTextBoxColumn, Me.密碼DataGridViewTextBoxColumn, Me.姓名DataGridViewTextBoxColumn, Me.電話DataGridViewTextBoxColumn, Me.住址DataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.會員DataGridView.DataSource = Me.會員BindingSource
        Me.會員DataGridView.Location = New System.Drawing.Point(0, 461)
        Me.會員DataGridView.Name = "會員DataGridView"
        Me.會員DataGridView.RowTemplate.Height = 24
        Me.會員DataGridView.Size = New System.Drawing.Size(30, 17)
        Me.會員DataGridView.TabIndex = 24
        '
        '會員編號DataGridViewTextBoxColumn
        '
        Me.會員編號DataGridViewTextBoxColumn.DataPropertyName = "會員編號"
        Me.會員編號DataGridViewTextBoxColumn.HeaderText = "會員編號"
        Me.會員編號DataGridViewTextBoxColumn.Name = "會員編號DataGridViewTextBoxColumn"
        '
        '帳號DataGridViewTextBoxColumn
        '
        Me.帳號DataGridViewTextBoxColumn.DataPropertyName = "帳號"
        Me.帳號DataGridViewTextBoxColumn.HeaderText = "帳號"
        Me.帳號DataGridViewTextBoxColumn.Name = "帳號DataGridViewTextBoxColumn"
        '
        '密碼DataGridViewTextBoxColumn
        '
        Me.密碼DataGridViewTextBoxColumn.DataPropertyName = "密碼"
        Me.密碼DataGridViewTextBoxColumn.HeaderText = "密碼"
        Me.密碼DataGridViewTextBoxColumn.Name = "密碼DataGridViewTextBoxColumn"
        '
        '姓名DataGridViewTextBoxColumn
        '
        Me.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名"
        Me.姓名DataGridViewTextBoxColumn.HeaderText = "姓名"
        Me.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn"
        '
        '電話DataGridViewTextBoxColumn
        '
        Me.電話DataGridViewTextBoxColumn.DataPropertyName = "電話"
        Me.電話DataGridViewTextBoxColumn.HeaderText = "電話"
        Me.電話DataGridViewTextBoxColumn.Name = "電話DataGridViewTextBoxColumn"
        '
        '住址DataGridViewTextBoxColumn
        '
        Me.住址DataGridViewTextBoxColumn.DataPropertyName = "住址"
        Me.住址DataGridViewTextBoxColumn.HeaderText = "住址"
        Me.住址DataGridViewTextBoxColumn.Name = "住址DataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        '會員BindingSource
        '
        Me.會員BindingSource.DataMember = "會員"
        Me.會員BindingSource.DataSource = Me.謎鹿DataSetBindingSource
        '
        '謎鹿DataSetBindingSource
        '
        Me.謎鹿DataSetBindingSource.DataSource = Me.謎鹿DataSet
        Me.謎鹿DataSetBindingSource.Position = 0
        '
        '謎鹿DataSet
        '
        Me.謎鹿DataSet.DataSetName = "謎鹿DataSet"
        Me.謎鹿DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SeaShell
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(230, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 19)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "姓名"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(273, 308)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(211, 22)
        Me.TextBox4.TabIndex = 26
        '
        '會員TableAdapter
        '
        Me.會員TableAdapter.ClearBeforeFill = True
        '
        '註冊
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(815, 478)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.會員DataGridView)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "註冊"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.會員DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.會員BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.謎鹿DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.謎鹿DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents 會員DataGridView As DataGridView
    Friend WithEvents 謎鹿DataSetBindingSource As BindingSource
    Friend WithEvents 謎鹿DataSet As 謎鹿DataSet
    Friend WithEvents 會員BindingSource As BindingSource
    Friend WithEvents 會員TableAdapter As 謎鹿DataSetTableAdapters.會員TableAdapter
    Friend WithEvents 會員編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 帳號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 密碼DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 姓名DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 電話DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 住址DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
