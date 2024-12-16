<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 訂單確認
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(訂單確認))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.訂單DataGridView = New System.Windows.Forms.DataGridView()
        Me.訂單編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.付款方式DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.取貨方式DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.訂單日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.會員編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.購物車編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.訂單BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.謎鹿DataSet = New 謎鹿進銷存系統.謎鹿DataSet()
        Me.訂單TableAdapter = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.訂單TableAdapter()
        Me.紀錄DataGridView = New System.Windows.Forms.DataGridView()
        Me.訂單編號DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.商品編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.訂購數量DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.價錢DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.紀錄BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.紀錄TableAdapter = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.紀錄TableAdapter()
        Me.訂購DataGridView = New System.Windows.Forms.DataGridView()
        Me.會員編號DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.商品編號DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.訂購數量DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.訂購BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.訂購TableAdapter = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.訂購TableAdapter()
        Me.商品DataGridView = New System.Windows.Forms.DataGridView()
        Me.商品編號DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.商品名稱DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.庫存數量DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.定價DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.種類DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.管理者編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.商品BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.商品TableAdapter = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.商品TableAdapter()
        CType(Me.訂單DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.訂單BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.謎鹿DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.紀錄DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.紀錄BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.訂購DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.訂購BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.商品DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.商品BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SeaShell
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 189)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SeaShell
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "付款方式"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SeaShell
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(230, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 24)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "取貨方式"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"貨到付款", "信用卡", "郵局轉帳"})
        Me.ComboBox1.Location = New System.Drawing.Point(374, 164)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 55
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"宅配到府", "超商取貨"})
        Me.ComboBox2.Location = New System.Drawing.Point(374, 211)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox2.TabIndex = 56
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.istockphoto_1023670900_1024x1024
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(395, 337)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 48)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "完成購買"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SeaShell
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(163, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 31)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "付款取貨"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.istockphoto_1023670900_1024x1024
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(247, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 48)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "上一步"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SeaShell
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(163, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 31)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "總金額"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SeaShell
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(292, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 24)
        Me.Label6.TabIndex = 61
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '訂單DataGridView
        '
        Me.訂單DataGridView.AutoGenerateColumns = False
        Me.訂單DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.訂單DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.訂單編號DataGridViewTextBoxColumn, Me.付款方式DataGridViewTextBoxColumn, Me.取貨方式DataGridViewTextBoxColumn, Me.訂單日期DataGridViewTextBoxColumn, Me.會員編號DataGridViewTextBoxColumn, Me.購物車編號DataGridViewTextBoxColumn})
        Me.訂單DataGridView.DataSource = Me.訂單BindingSource
        Me.訂單DataGridView.Location = New System.Drawing.Point(0, 439)
        Me.訂單DataGridView.Name = "訂單DataGridView"
        Me.訂單DataGridView.RowTemplate.Height = 24
        Me.訂單DataGridView.Size = New System.Drawing.Size(26, 12)
        Me.訂單DataGridView.TabIndex = 62
        '
        '訂單編號DataGridViewTextBoxColumn
        '
        Me.訂單編號DataGridViewTextBoxColumn.DataPropertyName = "訂單編號"
        Me.訂單編號DataGridViewTextBoxColumn.HeaderText = "訂單編號"
        Me.訂單編號DataGridViewTextBoxColumn.Name = "訂單編號DataGridViewTextBoxColumn"
        '
        '付款方式DataGridViewTextBoxColumn
        '
        Me.付款方式DataGridViewTextBoxColumn.DataPropertyName = "付款方式"
        Me.付款方式DataGridViewTextBoxColumn.HeaderText = "付款方式"
        Me.付款方式DataGridViewTextBoxColumn.Name = "付款方式DataGridViewTextBoxColumn"
        '
        '取貨方式DataGridViewTextBoxColumn
        '
        Me.取貨方式DataGridViewTextBoxColumn.DataPropertyName = "取貨方式"
        Me.取貨方式DataGridViewTextBoxColumn.HeaderText = "取貨方式"
        Me.取貨方式DataGridViewTextBoxColumn.Name = "取貨方式DataGridViewTextBoxColumn"
        '
        '訂單日期DataGridViewTextBoxColumn
        '
        Me.訂單日期DataGridViewTextBoxColumn.DataPropertyName = "訂單日期"
        Me.訂單日期DataGridViewTextBoxColumn.HeaderText = "訂單日期"
        Me.訂單日期DataGridViewTextBoxColumn.Name = "訂單日期DataGridViewTextBoxColumn"
        '
        '會員編號DataGridViewTextBoxColumn
        '
        Me.會員編號DataGridViewTextBoxColumn.DataPropertyName = "會員編號"
        Me.會員編號DataGridViewTextBoxColumn.HeaderText = "會員編號"
        Me.會員編號DataGridViewTextBoxColumn.Name = "會員編號DataGridViewTextBoxColumn"
        '
        '購物車編號DataGridViewTextBoxColumn
        '
        Me.購物車編號DataGridViewTextBoxColumn.DataPropertyName = "購物車編號"
        Me.購物車編號DataGridViewTextBoxColumn.HeaderText = "購物車編號"
        Me.購物車編號DataGridViewTextBoxColumn.Name = "購物車編號DataGridViewTextBoxColumn"
        '
        '訂單BindingSource
        '
        Me.訂單BindingSource.DataMember = "訂單"
        Me.訂單BindingSource.DataSource = Me.謎鹿DataSet
        '
        '謎鹿DataSet
        '
        Me.謎鹿DataSet.DataSetName = "謎鹿DataSet"
        Me.謎鹿DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '訂單TableAdapter
        '
        Me.訂單TableAdapter.ClearBeforeFill = True
        '
        '紀錄DataGridView
        '
        Me.紀錄DataGridView.AutoGenerateColumns = False
        Me.紀錄DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.紀錄DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.訂單編號DataGridViewTextBoxColumn1, Me.商品編號DataGridViewTextBoxColumn, Me.訂購數量DataGridViewTextBoxColumn, Me.價錢DataGridViewTextBoxColumn})
        Me.紀錄DataGridView.DataSource = Me.紀錄BindingSource
        Me.紀錄DataGridView.Location = New System.Drawing.Point(0, 431)
        Me.紀錄DataGridView.Name = "紀錄DataGridView"
        Me.紀錄DataGridView.RowTemplate.Height = 24
        Me.紀錄DataGridView.Size = New System.Drawing.Size(26, 20)
        Me.紀錄DataGridView.TabIndex = 63
        '
        '訂單編號DataGridViewTextBoxColumn1
        '
        Me.訂單編號DataGridViewTextBoxColumn1.DataPropertyName = "訂單編號"
        Me.訂單編號DataGridViewTextBoxColumn1.HeaderText = "訂單編號"
        Me.訂單編號DataGridViewTextBoxColumn1.Name = "訂單編號DataGridViewTextBoxColumn1"
        '
        '商品編號DataGridViewTextBoxColumn
        '
        Me.商品編號DataGridViewTextBoxColumn.DataPropertyName = "商品編號"
        Me.商品編號DataGridViewTextBoxColumn.HeaderText = "商品編號"
        Me.商品編號DataGridViewTextBoxColumn.Name = "商品編號DataGridViewTextBoxColumn"
        '
        '訂購數量DataGridViewTextBoxColumn
        '
        Me.訂購數量DataGridViewTextBoxColumn.DataPropertyName = "訂購數量"
        Me.訂購數量DataGridViewTextBoxColumn.HeaderText = "訂購數量"
        Me.訂購數量DataGridViewTextBoxColumn.Name = "訂購數量DataGridViewTextBoxColumn"
        '
        '價錢DataGridViewTextBoxColumn
        '
        Me.價錢DataGridViewTextBoxColumn.DataPropertyName = "價錢"
        Me.價錢DataGridViewTextBoxColumn.HeaderText = "價錢"
        Me.價錢DataGridViewTextBoxColumn.Name = "價錢DataGridViewTextBoxColumn"
        '
        '紀錄BindingSource
        '
        Me.紀錄BindingSource.DataMember = "紀錄"
        Me.紀錄BindingSource.DataSource = Me.謎鹿DataSet
        '
        '紀錄TableAdapter
        '
        Me.紀錄TableAdapter.ClearBeforeFill = True
        '
        '訂購DataGridView
        '
        Me.訂購DataGridView.AutoGenerateColumns = False
        Me.訂購DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.訂購DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.會員編號DataGridViewTextBoxColumn1, Me.商品編號DataGridViewTextBoxColumn1, Me.訂購數量DataGridViewTextBoxColumn1})
        Me.訂購DataGridView.DataSource = Me.訂購BindingSource
        Me.訂購DataGridView.Location = New System.Drawing.Point(0, 427)
        Me.訂購DataGridView.Name = "訂購DataGridView"
        Me.訂購DataGridView.RowTemplate.Height = 24
        Me.訂購DataGridView.Size = New System.Drawing.Size(26, 24)
        Me.訂購DataGridView.TabIndex = 64
        '
        '會員編號DataGridViewTextBoxColumn1
        '
        Me.會員編號DataGridViewTextBoxColumn1.DataPropertyName = "會員編號"
        Me.會員編號DataGridViewTextBoxColumn1.HeaderText = "會員編號"
        Me.會員編號DataGridViewTextBoxColumn1.Name = "會員編號DataGridViewTextBoxColumn1"
        '
        '商品編號DataGridViewTextBoxColumn1
        '
        Me.商品編號DataGridViewTextBoxColumn1.DataPropertyName = "商品編號"
        Me.商品編號DataGridViewTextBoxColumn1.HeaderText = "商品編號"
        Me.商品編號DataGridViewTextBoxColumn1.Name = "商品編號DataGridViewTextBoxColumn1"
        '
        '訂購數量DataGridViewTextBoxColumn1
        '
        Me.訂購數量DataGridViewTextBoxColumn1.DataPropertyName = "訂購數量"
        Me.訂購數量DataGridViewTextBoxColumn1.HeaderText = "訂購數量"
        Me.訂購數量DataGridViewTextBoxColumn1.Name = "訂購數量DataGridViewTextBoxColumn1"
        '
        '訂購BindingSource
        '
        Me.訂購BindingSource.DataMember = "訂購"
        Me.訂購BindingSource.DataSource = Me.謎鹿DataSet
        '
        '訂購TableAdapter
        '
        Me.訂購TableAdapter.ClearBeforeFill = True
        '
        '商品DataGridView
        '
        Me.商品DataGridView.AutoGenerateColumns = False
        Me.商品DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.商品DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.商品編號DataGridViewTextBoxColumn2, Me.商品名稱DataGridViewTextBoxColumn, Me.庫存數量DataGridViewTextBoxColumn, Me.定價DataGridViewTextBoxColumn, Me.種類DataGridViewTextBoxColumn, Me.管理者編號DataGridViewTextBoxColumn})
        Me.商品DataGridView.DataSource = Me.商品BindingSource
        Me.商品DataGridView.Location = New System.Drawing.Point(0, 425)
        Me.商品DataGridView.Name = "商品DataGridView"
        Me.商品DataGridView.RowTemplate.Height = 24
        Me.商品DataGridView.Size = New System.Drawing.Size(26, 26)
        Me.商品DataGridView.TabIndex = 65
        '
        '商品編號DataGridViewTextBoxColumn2
        '
        Me.商品編號DataGridViewTextBoxColumn2.DataPropertyName = "商品編號"
        Me.商品編號DataGridViewTextBoxColumn2.HeaderText = "商品編號"
        Me.商品編號DataGridViewTextBoxColumn2.Name = "商品編號DataGridViewTextBoxColumn2"
        '
        '商品名稱DataGridViewTextBoxColumn
        '
        Me.商品名稱DataGridViewTextBoxColumn.DataPropertyName = "商品名稱"
        Me.商品名稱DataGridViewTextBoxColumn.HeaderText = "商品名稱"
        Me.商品名稱DataGridViewTextBoxColumn.Name = "商品名稱DataGridViewTextBoxColumn"
        '
        '庫存數量DataGridViewTextBoxColumn
        '
        Me.庫存數量DataGridViewTextBoxColumn.DataPropertyName = "庫存數量"
        Me.庫存數量DataGridViewTextBoxColumn.HeaderText = "庫存數量"
        Me.庫存數量DataGridViewTextBoxColumn.Name = "庫存數量DataGridViewTextBoxColumn"
        '
        '定價DataGridViewTextBoxColumn
        '
        Me.定價DataGridViewTextBoxColumn.DataPropertyName = "定價"
        Me.定價DataGridViewTextBoxColumn.HeaderText = "定價"
        Me.定價DataGridViewTextBoxColumn.Name = "定價DataGridViewTextBoxColumn"
        '
        '種類DataGridViewTextBoxColumn
        '
        Me.種類DataGridViewTextBoxColumn.DataPropertyName = "種類"
        Me.種類DataGridViewTextBoxColumn.HeaderText = "種類"
        Me.種類DataGridViewTextBoxColumn.Name = "種類DataGridViewTextBoxColumn"
        '
        '管理者編號DataGridViewTextBoxColumn
        '
        Me.管理者編號DataGridViewTextBoxColumn.DataPropertyName = "管理者編號"
        Me.管理者編號DataGridViewTextBoxColumn.HeaderText = "管理者編號"
        Me.管理者編號DataGridViewTextBoxColumn.Name = "管理者編號DataGridViewTextBoxColumn"
        '
        '商品BindingSource
        '
        Me.商品BindingSource.DataMember = "商品"
        Me.商品BindingSource.DataSource = Me.謎鹿DataSet
        '
        '商品TableAdapter
        '
        Me.商品TableAdapter.ClearBeforeFill = True
        '
        '訂單確認
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.商品DataGridView)
        Me.Controls.Add(Me.訂購DataGridView)
        Me.Controls.Add(Me.紀錄DataGridView)
        Me.Controls.Add(Me.訂單DataGridView)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "訂單確認"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "訂單確認"
        CType(Me.訂單DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.訂單BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.謎鹿DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.紀錄DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.紀錄BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.訂購DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.訂購BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.商品DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.商品BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents 訂單DataGridView As DataGridView
    Friend WithEvents 謎鹿DataSet As 謎鹿DataSet
    Friend WithEvents 訂單BindingSource As BindingSource
    Friend WithEvents 訂單TableAdapter As 謎鹿DataSetTableAdapters.訂單TableAdapter
    Friend WithEvents 訂單編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 付款方式DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 取貨方式DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 訂單日期DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 會員編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 購物車編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 紀錄DataGridView As DataGridView
    Friend WithEvents 紀錄BindingSource As BindingSource
    Friend WithEvents 紀錄TableAdapter As 謎鹿DataSetTableAdapters.紀錄TableAdapter
    Friend WithEvents 訂單編號DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents 商品編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 訂購數量DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 價錢DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 訂購DataGridView As DataGridView
    Friend WithEvents 訂購BindingSource As BindingSource
    Friend WithEvents 訂購TableAdapter As 謎鹿DataSetTableAdapters.訂購TableAdapter
    Friend WithEvents 會員編號DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents 商品編號DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents 訂購數量DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents 商品DataGridView As DataGridView
    Friend WithEvents 商品BindingSource As BindingSource
    Friend WithEvents 商品TableAdapter As 謎鹿DataSetTableAdapters.商品TableAdapter
    Friend WithEvents 商品編號DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents 商品名稱DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 庫存數量DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 定價DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 種類DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 管理者編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
