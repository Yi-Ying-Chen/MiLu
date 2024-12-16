<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 商品管理
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
        Dim 商品編號Label As System.Windows.Forms.Label
        Dim 商品名稱Label As System.Windows.Forms.Label
        Dim 庫存數量Label As System.Windows.Forms.Label
        Dim 定價Label As System.Windows.Forms.Label
        Dim 種類Label As System.Windows.Forms.Label
        Dim 管理者編號Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(商品管理))
        Me.商品DataGridView = New System.Windows.Forms.DataGridView()
        Me.商品編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.商品名稱DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.庫存數量DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.定價DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.種類DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.管理者編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.商品BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.謎鹿DataSet = New 謎鹿進銷存系統.謎鹿DataSet()
        Me.商品TableAdapter = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.商品TableAdapter()
        Me.訂單BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.訂單TableAdapter = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.訂單TableAdapter()
        Me.TableAdapterManager = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.TableAdapterManager()
        Me.商品編號TextBox = New System.Windows.Forms.TextBox()
        Me.商品名稱TextBox = New System.Windows.Forms.TextBox()
        Me.庫存數量TextBox = New System.Windows.Forms.TextBox()
        Me.定價TextBox = New System.Windows.Forms.TextBox()
        Me.種類TextBox = New System.Windows.Forms.TextBox()
        Me.管理者編號TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.搜尋 = New System.Windows.Forms.ToolStripButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        商品編號Label = New System.Windows.Forms.Label()
        商品名稱Label = New System.Windows.Forms.Label()
        庫存數量Label = New System.Windows.Forms.Label()
        定價Label = New System.Windows.Forms.Label()
        種類Label = New System.Windows.Forms.Label()
        管理者編號Label = New System.Windows.Forms.Label()
        CType(Me.商品DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.商品BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.謎鹿DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.訂單BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        '商品編號Label
        '
        商品編號Label.AutoSize = True
        商品編號Label.BackColor = System.Drawing.Color.LightSkyBlue
        商品編號Label.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        商品編號Label.Location = New System.Drawing.Point(194, 274)
        商品編號Label.Name = "商品編號Label"
        商品編號Label.Size = New System.Drawing.Size(96, 26)
        商品編號Label.TabIndex = 13
        商品編號Label.Text = "商品編號"
        '
        '商品名稱Label
        '
        商品名稱Label.AutoSize = True
        商品名稱Label.BackColor = System.Drawing.Color.LightSkyBlue
        商品名稱Label.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        商品名稱Label.Location = New System.Drawing.Point(194, 305)
        商品名稱Label.Name = "商品名稱Label"
        商品名稱Label.Size = New System.Drawing.Size(96, 26)
        商品名稱Label.TabIndex = 14
        商品名稱Label.Text = "商品名稱"
        '
        '庫存數量Label
        '
        庫存數量Label.AutoSize = True
        庫存數量Label.BackColor = System.Drawing.Color.LightSkyBlue
        庫存數量Label.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        庫存數量Label.Location = New System.Drawing.Point(194, 334)
        庫存數量Label.Name = "庫存數量Label"
        庫存數量Label.Size = New System.Drawing.Size(96, 26)
        庫存數量Label.TabIndex = 15
        庫存數量Label.Text = "庫存數量"
        '
        '定價Label
        '
        定價Label.AutoSize = True
        定價Label.BackColor = System.Drawing.Color.LightSkyBlue
        定價Label.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        定價Label.Location = New System.Drawing.Point(236, 363)
        定價Label.Name = "定價Label"
        定價Label.Size = New System.Drawing.Size(54, 26)
        定價Label.TabIndex = 16
        定價Label.Text = "定價"
        '
        '種類Label
        '
        種類Label.AutoSize = True
        種類Label.BackColor = System.Drawing.Color.LightSkyBlue
        種類Label.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        種類Label.Location = New System.Drawing.Point(236, 390)
        種類Label.Name = "種類Label"
        種類Label.Size = New System.Drawing.Size(54, 26)
        種類Label.TabIndex = 17
        種類Label.Text = "種類"
        '
        '管理者編號Label
        '
        管理者編號Label.AutoSize = True
        管理者編號Label.BackColor = System.Drawing.Color.LightSkyBlue
        管理者編號Label.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        管理者編號Label.Location = New System.Drawing.Point(173, 418)
        管理者編號Label.Name = "管理者編號Label"
        管理者編號Label.Size = New System.Drawing.Size(117, 26)
        管理者編號Label.TabIndex = 18
        管理者編號Label.Text = "管理者編號"
        '
        '商品DataGridView
        '
        Me.商品DataGridView.AutoGenerateColumns = False
        Me.商品DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.商品DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.商品編號DataGridViewTextBoxColumn, Me.商品名稱DataGridViewTextBoxColumn, Me.庫存數量DataGridViewTextBoxColumn, Me.定價DataGridViewTextBoxColumn, Me.種類DataGridViewTextBoxColumn, Me.管理者編號DataGridViewTextBoxColumn})
        Me.商品DataGridView.DataSource = Me.商品BindingSource
        Me.商品DataGridView.Location = New System.Drawing.Point(156, 112)
        Me.商品DataGridView.Name = "商品DataGridView"
        Me.商品DataGridView.RowTemplate.Height = 24
        Me.商品DataGridView.Size = New System.Drawing.Size(657, 150)
        Me.商品DataGridView.TabIndex = 13
        '
        '商品編號DataGridViewTextBoxColumn
        '
        Me.商品編號DataGridViewTextBoxColumn.DataPropertyName = "商品編號"
        Me.商品編號DataGridViewTextBoxColumn.HeaderText = "商品編號"
        Me.商品編號DataGridViewTextBoxColumn.Name = "商品編號DataGridViewTextBoxColumn"
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
        '謎鹿DataSet
        '
        Me.謎鹿DataSet.DataSetName = "謎鹿DataSet"
        Me.謎鹿DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '商品TableAdapter
        '
        Me.商品TableAdapter.ClearBeforeFill = True
        '
        '訂單BindingSource
        '
        Me.訂單BindingSource.DataMember = "訂單"
        Me.訂單BindingSource.DataSource = Me.謎鹿DataSet
        '
        '訂單TableAdapter
        '
        Me.訂單TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = 謎鹿進銷存系統.謎鹿DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.商品TableAdapter = Me.商品TableAdapter
        Me.TableAdapterManager.會員TableAdapter = Nothing
        Me.TableAdapterManager.紀錄TableAdapter = Nothing
        Me.TableAdapterManager.訂單TableAdapter = Me.訂單TableAdapter
        Me.TableAdapterManager.訂購TableAdapter = Nothing
        Me.TableAdapterManager.購物車TableAdapter = Nothing
        '
        '商品編號TextBox
        '
        Me.商品編號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.商品BindingSource, "商品編號", True))
        Me.商品編號TextBox.Location = New System.Drawing.Point(296, 276)
        Me.商品編號TextBox.Name = "商品編號TextBox"
        Me.商品編號TextBox.Size = New System.Drawing.Size(100, 22)
        Me.商品編號TextBox.TabIndex = 14
        '
        '商品名稱TextBox
        '
        Me.商品名稱TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.商品BindingSource, "商品名稱", True))
        Me.商品名稱TextBox.Location = New System.Drawing.Point(296, 306)
        Me.商品名稱TextBox.Name = "商品名稱TextBox"
        Me.商品名稱TextBox.Size = New System.Drawing.Size(100, 22)
        Me.商品名稱TextBox.TabIndex = 15
        '
        '庫存數量TextBox
        '
        Me.庫存數量TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.商品BindingSource, "庫存數量", True))
        Me.庫存數量TextBox.Location = New System.Drawing.Point(296, 335)
        Me.庫存數量TextBox.Name = "庫存數量TextBox"
        Me.庫存數量TextBox.Size = New System.Drawing.Size(100, 22)
        Me.庫存數量TextBox.TabIndex = 16
        '
        '定價TextBox
        '
        Me.定價TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.商品BindingSource, "定價", True))
        Me.定價TextBox.Location = New System.Drawing.Point(296, 364)
        Me.定價TextBox.Name = "定價TextBox"
        Me.定價TextBox.Size = New System.Drawing.Size(100, 22)
        Me.定價TextBox.TabIndex = 17
        '
        '種類TextBox
        '
        Me.種類TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.商品BindingSource, "種類", True))
        Me.種類TextBox.Location = New System.Drawing.Point(296, 391)
        Me.種類TextBox.Name = "種類TextBox"
        Me.種類TextBox.Size = New System.Drawing.Size(100, 22)
        Me.種類TextBox.TabIndex = 18
        '
        '管理者編號TextBox
        '
        Me.管理者編號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.商品BindingSource, "管理者編號", True))
        Me.管理者編號TextBox.Location = New System.Drawing.Point(296, 419)
        Me.管理者編號TextBox.Name = "管理者編號TextBox"
        Me.管理者編號TextBox.Size = New System.Drawing.Size(100, 22)
        Me.管理者編號TextBox.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 452)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 26)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "商品資訊修改"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.商品BindingSource
        Me.ComboBox1.DisplayMember = "商品編號"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(296, 452)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 45
        Me.ComboBox1.ValueMember = "商品編號"
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.pngtree_simple_yellow_background_fluid_marble_shading_shading_background_image_40810
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button8.Location = New System.Drawing.Point(558, 276)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(70, 70)
        Me.Button8.TabIndex = 49
        Me.Button8.Text = "刪除"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.istockphoto_1023670900_1024x1024
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button9.Location = New System.Drawing.Point(663, 276)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(70, 70)
        Me.Button9.TabIndex = 48
        Me.Button9.Text = "修改"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources._4863ede4_0215_403e_a854_e504c35d4509
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button7.Location = New System.Drawing.Point(448, 276)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 70)
        Me.Button7.TabIndex = 47
        Me.Button7.Text = "新增"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.istockphoto_1023670900_1024x1024
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button10.Location = New System.Drawing.Point(753, 28)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(70, 70)
        Me.Button10.TabIndex = 55
        Me.Button10.Text = "重新整理"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripTextBox1, Me.搜尋})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(835, 25)
        Me.BindingNavigator1.TabIndex = 56
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "加入新的"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(27, 22)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目總數"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "刪除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "移到最前面"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "移到上一個"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "目前的位置"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "移到下一個"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "移到最後面"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        '搜尋
        '
        Me.搜尋.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.搜尋.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.搜尋.Name = "搜尋"
        Me.搜尋.Size = New System.Drawing.Size(35, 22)
        Me.搜尋.Text = "搜尋"
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
        Me.Button5.TabIndex = 62
        Me.Button5.Text = "會員購買紀錄"
        Me.Button5.UseVisualStyleBackColor = False
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
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "商品銷售紀錄"
        Me.Button4.UseVisualStyleBackColor = False
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
        Me.Button6.TabIndex = 60
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
        Me.Button3.TabIndex = 59
        Me.Button3.Text = "會員管理"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SandyBrown
        Me.Button2.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.images
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(23, 191)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 32)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "訂單"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.images
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(23, 135)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "商品管理"
        Me.Button1.UseVisualStyleBackColor = False
        '
        '商品管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(835, 491)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(管理者編號Label)
        Me.Controls.Add(Me.管理者編號TextBox)
        Me.Controls.Add(種類Label)
        Me.Controls.Add(Me.種類TextBox)
        Me.Controls.Add(定價Label)
        Me.Controls.Add(Me.定價TextBox)
        Me.Controls.Add(庫存數量Label)
        Me.Controls.Add(Me.庫存數量TextBox)
        Me.Controls.Add(商品名稱Label)
        Me.Controls.Add(Me.商品名稱TextBox)
        Me.Controls.Add(商品編號Label)
        Me.Controls.Add(Me.商品編號TextBox)
        Me.Controls.Add(Me.商品DataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "商品管理"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "商品管理"
        CType(Me.商品DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.商品BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.謎鹿DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.訂單BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 商品DataGridView As DataGridView
    Friend WithEvents 謎鹿DataSet As 謎鹿DataSet
    Friend WithEvents 商品BindingSource As BindingSource
    Friend WithEvents 商品TableAdapter As 謎鹿DataSetTableAdapters.商品TableAdapter
    Friend WithEvents 訂單BindingSource As BindingSource
    Friend WithEvents 訂單TableAdapter As 謎鹿DataSetTableAdapters.訂單TableAdapter
    Friend WithEvents TableAdapterManager As 謎鹿DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 商品編號TextBox As TextBox
    Friend WithEvents 商品名稱TextBox As TextBox
    Friend WithEvents 庫存數量TextBox As TextBox
    Friend WithEvents 定價TextBox As TextBox
    Friend WithEvents 種類TextBox As TextBox
    Friend WithEvents 管理者編號TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents 搜尋 As ToolStripButton
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents 商品編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 商品名稱DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 庫存數量DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 定價DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 種類DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 管理者編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
