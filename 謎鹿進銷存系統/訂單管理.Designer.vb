<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 訂單管理
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(訂單管理))
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.訂單編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.付款方式DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.取貨方式DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.訂單日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.會員編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.購物車編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.訂單BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.謎鹿DataSet = New 謎鹿進銷存系統.謎鹿DataSet()
        Me.訂單TableAdapter = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.訂單TableAdapter()
        Me.TableAdapterManager = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.TableAdapterManager()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.訂單BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.謎鹿DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.SandyBrown
        Me.Button6.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.images
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Location = New System.Drawing.Point(23, 413)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 32)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "登入畫面"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SandyBrown
        Me.Button3.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.images
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(23, 247)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 32)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "會員管理"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.images
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(23, 191)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "訂單"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SandyBrown
        Me.Button1.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.images
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(23, 135)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "商品管理"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.訂單編號DataGridViewTextBoxColumn, Me.付款方式DataGridViewTextBoxColumn, Me.取貨方式DataGridViewTextBoxColumn, Me.訂單日期DataGridViewTextBoxColumn, Me.會員編號DataGridViewTextBoxColumn, Me.購物車編號DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.訂單BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(156, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(652, 201)
        Me.DataGridView1.TabIndex = 13
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = 謎鹿進銷存系統.謎鹿DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.商品TableAdapter = Nothing
        Me.TableAdapterManager.會員TableAdapter = Nothing
        Me.TableAdapterManager.紀錄TableAdapter = Nothing
        Me.TableAdapterManager.訂單TableAdapter = Me.訂單TableAdapter
        Me.TableAdapterManager.訂購TableAdapter = Nothing
        Me.TableAdapterManager.購物車TableAdapter = Nothing
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SandyBrown
        Me.Button4.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.images
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(11, 300)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 32)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "商品銷售紀錄"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SandyBrown
        Me.Button5.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.images
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(11, 355)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 32)
        Me.Button5.TabIndex = 54
        Me.Button5.Text = "會員購買紀錄"
        Me.Button5.UseVisualStyleBackColor = False
        '
        '訂單管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(835, 500)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "訂單管理"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "訂單管理"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.訂單BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.謎鹿DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents 謎鹿DataSet As 謎鹿DataSet
    Friend WithEvents 訂單BindingSource As BindingSource
    Friend WithEvents 訂單TableAdapter As 謎鹿DataSetTableAdapters.訂單TableAdapter
    Friend WithEvents 訂單編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 付款方式DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 取貨方式DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 訂單日期DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 會員編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 購物車編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As 謎鹿DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
