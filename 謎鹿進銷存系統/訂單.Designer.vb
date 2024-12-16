<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 訂單
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(訂單))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.訂單TableAdapter = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.訂單TableAdapter()
        CType(Me.訂單DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.訂單BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.謎鹿DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.istockphoto_1023670900_1024x1024
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(667, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "返回"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SeaShell
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 86)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SeaShell
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(519, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "訂單編號"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SeaShell
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(252, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 34)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "付款方式"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SeaShell
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(341, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 34)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "取貨方式"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SeaShell
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(430, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 34)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "訂單日期"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SeaShell
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(163, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 34)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "會員編號"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '訂單DataGridView
        '
        Me.訂單DataGridView.AutoGenerateColumns = False
        Me.訂單DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.訂單DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.訂單編號DataGridViewTextBoxColumn, Me.付款方式DataGridViewTextBoxColumn, Me.取貨方式DataGridViewTextBoxColumn, Me.訂單日期DataGridViewTextBoxColumn, Me.會員編號DataGridViewTextBoxColumn, Me.購物車編號DataGridViewTextBoxColumn})
        Me.訂單DataGridView.DataSource = Me.訂單BindingSource
        Me.訂單DataGridView.Location = New System.Drawing.Point(-3, 432)
        Me.訂單DataGridView.Name = "訂單DataGridView"
        Me.訂單DataGridView.RowTemplate.Height = 24
        Me.訂單DataGridView.Size = New System.Drawing.Size(38, 20)
        Me.訂單DataGridView.TabIndex = 12
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
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SeaShell
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(252, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 38)
        Me.Label8.TabIndex = 13
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SeaShell
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(341, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 38)
        Me.Label9.TabIndex = 14
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SeaShell
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(430, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 38)
        Me.Label10.TabIndex = 15
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SeaShell
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(519, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 38)
        Me.Label11.TabIndex = 16
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SeaShell
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(163, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 38)
        Me.Label7.TabIndex = 17
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(301, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 38)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "最新一筆訂單"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.images
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(650, 227)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 38)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "←刪除訂單"
        Me.Button2.UseVisualStyleBackColor = True
        '
        '訂單TableAdapter
        '
        Me.訂單TableAdapter.ClearBeforeFill = True
        '
        '訂單
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.訂單DataGridView)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "訂單"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "訂單"
        CType(Me.訂單DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.訂單BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.謎鹿DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
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
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
End Class
