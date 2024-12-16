<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 會員管理
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
        Dim 姓名Label As System.Windows.Forms.Label
        Dim 密碼Label As System.Windows.Forms.Label
        Dim 帳號Label As System.Windows.Forms.Label
        Dim 會員編號Label As System.Windows.Forms.Label
        Dim emailLabel As System.Windows.Forms.Label
        Dim 住址Label As System.Windows.Forms.Label
        Dim 電話Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(會員管理))
        Me.會員DataGridView = New System.Windows.Forms.DataGridView()
        Me.會員編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.帳號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.密碼DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.姓名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.電話DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.住址DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.會員BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.謎鹿DataSet = New 謎鹿進銷存系統.謎鹿DataSet()
        Me.會員TableAdapter = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.會員TableAdapter()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.會員BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New 謎鹿進銷存系統.謎鹿DataSetTableAdapters.TableAdapterManager()
        Me.會員編號TextBox = New System.Windows.Forms.TextBox()
        Me.帳號TextBox = New System.Windows.Forms.TextBox()
        Me.密碼TextBox = New System.Windows.Forms.TextBox()
        Me.姓名TextBox = New System.Windows.Forms.TextBox()
        Me.電話TextBox = New System.Windows.Forms.TextBox()
        Me.住址TextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        姓名Label = New System.Windows.Forms.Label()
        密碼Label = New System.Windows.Forms.Label()
        帳號Label = New System.Windows.Forms.Label()
        會員編號Label = New System.Windows.Forms.Label()
        emailLabel = New System.Windows.Forms.Label()
        住址Label = New System.Windows.Forms.Label()
        電話Label = New System.Windows.Forms.Label()
        CType(Me.會員DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.會員BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.謎鹿DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.會員BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.會員BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        '姓名Label
        '
        姓名Label.AutoSize = True
        姓名Label.BackColor = System.Drawing.Color.MediumSpringGreen
        姓名Label.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        姓名Label.Location = New System.Drawing.Point(277, 355)
        姓名Label.Name = "姓名Label"
        姓名Label.Size = New System.Drawing.Size(54, 26)
        姓名Label.TabIndex = 40
        姓名Label.Text = "姓名"
        姓名Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '密碼Label
        '
        密碼Label.AutoSize = True
        密碼Label.BackColor = System.Drawing.Color.MediumSpringGreen
        密碼Label.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        密碼Label.Location = New System.Drawing.Point(277, 328)
        密碼Label.Name = "密碼Label"
        密碼Label.Size = New System.Drawing.Size(54, 26)
        密碼Label.TabIndex = 38
        密碼Label.Text = "密碼"
        密碼Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '帳號Label
        '
        帳號Label.AutoSize = True
        帳號Label.BackColor = System.Drawing.Color.MediumSpringGreen
        帳號Label.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        帳號Label.Location = New System.Drawing.Point(277, 300)
        帳號Label.Name = "帳號Label"
        帳號Label.Size = New System.Drawing.Size(54, 26)
        帳號Label.TabIndex = 36
        帳號Label.Text = "帳號"
        帳號Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '會員編號Label
        '
        會員編號Label.AutoSize = True
        會員編號Label.BackColor = System.Drawing.Color.MediumSpringGreen
        會員編號Label.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        會員編號Label.Location = New System.Drawing.Point(235, 271)
        會員編號Label.Name = "會員編號Label"
        會員編號Label.Size = New System.Drawing.Size(96, 26)
        會員編號Label.TabIndex = 34
        會員編號Label.Text = "會員編號"
        會員編號Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'emailLabel
        '
        emailLabel.AutoSize = True
        emailLabel.BackColor = System.Drawing.Color.MediumSpringGreen
        emailLabel.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        emailLabel.Location = New System.Drawing.Point(263, 436)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New System.Drawing.Size(68, 26)
        emailLabel.TabIndex = 51
        emailLabel.Text = "email"
        emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '住址Label
        '
        住址Label.AutoSize = True
        住址Label.BackColor = System.Drawing.Color.MediumSpringGreen
        住址Label.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        住址Label.Location = New System.Drawing.Point(277, 409)
        住址Label.Name = "住址Label"
        住址Label.Size = New System.Drawing.Size(54, 26)
        住址Label.TabIndex = 49
        住址Label.Text = "住址"
        住址Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '電話Label
        '
        電話Label.AutoSize = True
        電話Label.BackColor = System.Drawing.Color.MediumSpringGreen
        電話Label.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        電話Label.Location = New System.Drawing.Point(277, 382)
        電話Label.Name = "電話Label"
        電話Label.Size = New System.Drawing.Size(54, 26)
        電話Label.TabIndex = 47
        電話Label.Text = "電話"
        電話Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '會員DataGridView
        '
        Me.會員DataGridView.AutoGenerateColumns = False
        Me.會員DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.會員DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.會員編號DataGridViewTextBoxColumn, Me.帳號DataGridViewTextBoxColumn, Me.密碼DataGridViewTextBoxColumn, Me.姓名DataGridViewTextBoxColumn, Me.電話DataGridViewTextBoxColumn, Me.住址DataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.會員DataGridView.DataSource = Me.會員BindingSource
        Me.會員DataGridView.Location = New System.Drawing.Point(149, 106)
        Me.會員DataGridView.Name = "會員DataGridView"
        Me.會員DataGridView.RowTemplate.Height = 24
        Me.會員DataGridView.Size = New System.Drawing.Size(764, 150)
        Me.會員DataGridView.TabIndex = 13
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
        Me.會員BindingSource.DataSource = Me.謎鹿DataSet
        '
        '謎鹿DataSet
        '
        Me.謎鹿DataSet.DataSetName = "謎鹿DataSet"
        Me.謎鹿DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '會員TableAdapter
        '
        Me.會員TableAdapter.ClearBeforeFill = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.pngtree_simple_yellow_background_fluid_marble_shading_shading_background_image_40810
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button8.Location = New System.Drawing.Point(612, 271)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(70, 70)
        Me.Button8.TabIndex = 46
        Me.Button8.Text = "刪除"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.istockphoto_1023670900_1024x1024
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button9.Location = New System.Drawing.Point(717, 271)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(70, 70)
        Me.Button9.TabIndex = 45
        Me.Button9.Text = "修改"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources._4863ede4_0215_403e_a854_e504c35d4509
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button7.Location = New System.Drawing.Point(502, 271)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 70)
        Me.Button7.TabIndex = 44
        Me.Button7.Text = "新增"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 465)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 26)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "會員資訊修改"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.會員BindingSource
        Me.ComboBox1.DisplayMember = "會員編號"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(337, 466)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 42
        Me.ComboBox1.ValueMember = "會員編號"
        '
        '會員BindingNavigator
        '
        Me.會員BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.會員BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.會員BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.會員BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripTextBox1, Me.搜尋})
        Me.會員BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.會員BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.會員BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.會員BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.會員BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.會員BindingNavigator.Name = "會員BindingNavigator"
        Me.會員BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.會員BindingNavigator.Size = New System.Drawing.Size(933, 25)
        Me.會員BindingNavigator.TabIndex = 53
        Me.會員BindingNavigator.Text = "BindingNavigator1"
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
        Me.搜尋.AutoSize = False
        Me.搜尋.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.搜尋.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.搜尋.Name = "搜尋"
        Me.搜尋.Size = New System.Drawing.Size(50, 22)
        Me.搜尋.Text = "搜尋"
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.istockphoto_1023670900_1024x1024
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button10.Location = New System.Drawing.Point(833, 28)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(70, 70)
        Me.Button10.TabIndex = 54
        Me.Button10.Text = "重新整理"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = 謎鹿進銷存系統.謎鹿DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.商品TableAdapter = Nothing
        Me.TableAdapterManager.會員TableAdapter = Nothing
        Me.TableAdapterManager.紀錄TableAdapter = Nothing
        Me.TableAdapterManager.訂單TableAdapter = Nothing
        Me.TableAdapterManager.訂購TableAdapter = Nothing
        Me.TableAdapterManager.購物車TableAdapter = Nothing
        '
        '會員編號TextBox
        '
        Me.會員編號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.會員BindingSource, "會員編號", True))
        Me.會員編號TextBox.Location = New System.Drawing.Point(337, 272)
        Me.會員編號TextBox.Name = "會員編號TextBox"
        Me.會員編號TextBox.Size = New System.Drawing.Size(121, 22)
        Me.會員編號TextBox.TabIndex = 55
        '
        '帳號TextBox
        '
        Me.帳號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.會員BindingSource, "帳號", True))
        Me.帳號TextBox.Location = New System.Drawing.Point(337, 301)
        Me.帳號TextBox.Name = "帳號TextBox"
        Me.帳號TextBox.Size = New System.Drawing.Size(121, 22)
        Me.帳號TextBox.TabIndex = 56
        '
        '密碼TextBox
        '
        Me.密碼TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.會員BindingSource, "密碼", True))
        Me.密碼TextBox.Location = New System.Drawing.Point(337, 329)
        Me.密碼TextBox.Name = "密碼TextBox"
        Me.密碼TextBox.Size = New System.Drawing.Size(121, 22)
        Me.密碼TextBox.TabIndex = 57
        '
        '姓名TextBox
        '
        Me.姓名TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.會員BindingSource, "姓名", True))
        Me.姓名TextBox.Location = New System.Drawing.Point(337, 355)
        Me.姓名TextBox.Name = "姓名TextBox"
        Me.姓名TextBox.Size = New System.Drawing.Size(121, 22)
        Me.姓名TextBox.TabIndex = 58
        '
        '電話TextBox
        '
        Me.電話TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.會員BindingSource, "電話", True))
        Me.電話TextBox.Location = New System.Drawing.Point(337, 383)
        Me.電話TextBox.Name = "電話TextBox"
        Me.電話TextBox.Size = New System.Drawing.Size(121, 22)
        Me.電話TextBox.TabIndex = 59
        '
        '住址TextBox
        '
        Me.住址TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.會員BindingSource, "住址", True))
        Me.住址TextBox.Location = New System.Drawing.Point(337, 409)
        Me.住址TextBox.Name = "住址TextBox"
        Me.住址TextBox.Size = New System.Drawing.Size(121, 22)
        Me.住址TextBox.TabIndex = 60
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.會員BindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(337, 436)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(121, 22)
        Me.EmailTextBox.TabIndex = 61
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
        Me.Button5.TabIndex = 68
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
        Me.Button4.TabIndex = 67
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
        Me.Button6.TabIndex = 66
        Me.Button6.Text = "登入畫面"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkOrange
        Me.Button3.BackgroundImage = Global.謎鹿進銷存系統.My.Resources.Resources.images
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(23, 247)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 32)
        Me.Button3.TabIndex = 65
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
        Me.Button2.TabIndex = 64
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
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "商品管理"
        Me.Button1.UseVisualStyleBackColor = False
        '
        '會員管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(933, 500)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.住址TextBox)
        Me.Controls.Add(Me.電話TextBox)
        Me.Controls.Add(Me.姓名TextBox)
        Me.Controls.Add(Me.密碼TextBox)
        Me.Controls.Add(Me.帳號TextBox)
        Me.Controls.Add(Me.會員編號TextBox)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.會員BindingNavigator)
        Me.Controls.Add(emailLabel)
        Me.Controls.Add(住址Label)
        Me.Controls.Add(電話Label)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(姓名Label)
        Me.Controls.Add(密碼Label)
        Me.Controls.Add(帳號Label)
        Me.Controls.Add(會員編號Label)
        Me.Controls.Add(Me.會員DataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "會員管理"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "會員管理"
        CType(Me.會員DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.會員BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.謎鹿DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.會員BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.會員BindingNavigator.ResumeLayout(False)
        Me.會員BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 會員DataGridView As DataGridView
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
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents 會員BindingNavigator As BindingNavigator
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
    Friend WithEvents TableAdapterManager As 謎鹿DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 會員編號TextBox As TextBox
    Friend WithEvents 帳號TextBox As TextBox
    Friend WithEvents 密碼TextBox As TextBox
    Friend WithEvents 姓名TextBox As TextBox
    Friend WithEvents 電話TextBox As TextBox
    Friend WithEvents 住址TextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button10 As Button
End Class
