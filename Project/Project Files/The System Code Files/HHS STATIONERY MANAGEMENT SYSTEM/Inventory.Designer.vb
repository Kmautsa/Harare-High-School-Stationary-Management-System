<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Item_IdLabel As System.Windows.Forms.Label
        Dim Item_TypeLabel As System.Windows.Forms.Label
        Dim Item_NameLabel As System.Windows.Forms.Label
        Dim Unit_SizeLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.NewStationeryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.New_StationeryDataSet = New HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSet()
        Me.Unit_SizeTextBox = New System.Windows.Forms.TextBox()
        Me.Item_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Item_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Item_IdTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNLST = New System.Windows.Forms.Button()
        Me.BTNPRV = New System.Windows.Forms.Button()
        Me.BTNFST = New System.Windows.Forms.Button()
        Me.BTNNXT = New System.Windows.Forms.Button()
        Me.BTNBACK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.NewStationeryTableAdapter = New HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.NewStationeryTableAdapter()
        Me.TableAdapterManager = New HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.TableAdapterManager()
        Item_IdLabel = New System.Windows.Forms.Label()
        Item_TypeLabel = New System.Windows.Forms.Label()
        Item_NameLabel = New System.Windows.Forms.Label()
        Unit_SizeLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NewStationeryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.New_StationeryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Item_IdLabel
        '
        Item_IdLabel.AutoSize = True
        Item_IdLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Item_IdLabel.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_IdLabel.Location = New System.Drawing.Point(14, 19)
        Item_IdLabel.Name = "Item_IdLabel"
        Item_IdLabel.Size = New System.Drawing.Size(51, 14)
        Item_IdLabel.TabIndex = 11
        Item_IdLabel.Text = "Item Id:"
        '
        'Item_TypeLabel
        '
        Item_TypeLabel.AutoSize = True
        Item_TypeLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Item_TypeLabel.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_TypeLabel.Location = New System.Drawing.Point(14, 49)
        Item_TypeLabel.Name = "Item_TypeLabel"
        Item_TypeLabel.Size = New System.Drawing.Size(64, 14)
        Item_TypeLabel.TabIndex = 12
        Item_TypeLabel.Text = "Item Type:"
        '
        'Item_NameLabel
        '
        Item_NameLabel.AutoSize = True
        Item_NameLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Item_NameLabel.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_NameLabel.Location = New System.Drawing.Point(14, 80)
        Item_NameLabel.Name = "Item_NameLabel"
        Item_NameLabel.Size = New System.Drawing.Size(68, 14)
        Item_NameLabel.TabIndex = 13
        Item_NameLabel.Text = "Item Name:"
        '
        'Unit_SizeLabel
        '
        Unit_SizeLabel.AutoSize = True
        Unit_SizeLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Unit_SizeLabel.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Unit_SizeLabel.Location = New System.Drawing.Point(14, 115)
        Unit_SizeLabel.Name = "Unit_SizeLabel"
        Unit_SizeLabel.Size = New System.Drawing.Size(63, 14)
        Unit_SizeLabel.TabIndex = 14
        Unit_SizeLabel.Text = "Unit Size:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        QuantityLabel.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(17, 142)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(58, 14)
        QuantityLabel.TabIndex = 15
        QuantityLabel.Text = "Quantity:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.BackgroundImage = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources.main
        Me.GroupBox1.Controls.Add(QuantityLabel)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Unit_SizeLabel)
        Me.GroupBox1.Controls.Add(Me.Unit_SizeTextBox)
        Me.GroupBox1.Controls.Add(Item_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Item_NameTextBox)
        Me.GroupBox1.Controls.Add(Item_TypeLabel)
        Me.GroupBox1.Controls.Add(Me.Item_TypeTextBox)
        Me.GroupBox1.Controls.Add(Item_IdLabel)
        Me.GroupBox1.Controls.Add(Me.Item_IdTextBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BTNBACK)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Available Stationery Details"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(81, 139)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(117, 19)
        Me.QuantityTextBox.TabIndex = 16
        '
        'NewStationeryBindingSource
        '
        Me.NewStationeryBindingSource.DataMember = "NewStationery"
        Me.NewStationeryBindingSource.DataSource = Me.New_StationeryDataSet
        '
        'New_StationeryDataSet
        '
        Me.New_StationeryDataSet.DataSetName = "New_StationeryDataSet"
        Me.New_StationeryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Unit_SizeTextBox
        '
        Me.Unit_SizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Unit Size", True))
        Me.Unit_SizeTextBox.Location = New System.Drawing.Point(81, 112)
        Me.Unit_SizeTextBox.Name = "Unit_SizeTextBox"
        Me.Unit_SizeTextBox.Size = New System.Drawing.Size(117, 19)
        Me.Unit_SizeTextBox.TabIndex = 15
        '
        'Item_NameTextBox
        '
        Me.Item_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Item Name", True))
        Me.Item_NameTextBox.Location = New System.Drawing.Point(81, 77)
        Me.Item_NameTextBox.Name = "Item_NameTextBox"
        Me.Item_NameTextBox.Size = New System.Drawing.Size(117, 19)
        Me.Item_NameTextBox.TabIndex = 14
        '
        'Item_TypeTextBox
        '
        Me.Item_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Item Type", True))
        Me.Item_TypeTextBox.Location = New System.Drawing.Point(81, 46)
        Me.Item_TypeTextBox.Name = "Item_TypeTextBox"
        Me.Item_TypeTextBox.Size = New System.Drawing.Size(117, 19)
        Me.Item_TypeTextBox.TabIndex = 13
        '
        'Item_IdTextBox
        '
        Me.Item_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Item Id", True))
        Me.Item_IdTextBox.Location = New System.Drawing.Point(66, 16)
        Me.Item_IdTextBox.Name = "Item_IdTextBox"
        Me.Item_IdTextBox.Size = New System.Drawing.Size(132, 19)
        Me.Item_IdTextBox.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox2.Controls.Add(Me.BTNLST)
        Me.GroupBox2.Controls.Add(Me.BTNPRV)
        Me.GroupBox2.Controls.Add(Me.BTNFST)
        Me.GroupBox2.Controls.Add(Me.BTNNXT)
        Me.GroupBox2.Location = New System.Drawing.Point(204, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 94)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'BTNLST
        '
        Me.BTNLST.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNLST.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLST.Location = New System.Drawing.Point(112, 56)
        Me.BTNLST.Name = "BTNLST"
        Me.BTNLST.Size = New System.Drawing.Size(75, 23)
        Me.BTNLST.TabIndex = 4
        Me.BTNLST.Text = "LAST >>"
        Me.BTNLST.UseVisualStyleBackColor = False
        '
        'BTNPRV
        '
        Me.BTNPRV.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNPRV.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPRV.Location = New System.Drawing.Point(112, 20)
        Me.BTNPRV.Name = "BTNPRV"
        Me.BTNPRV.Size = New System.Drawing.Size(75, 23)
        Me.BTNPRV.TabIndex = 3
        Me.BTNPRV.Text = "< PRV"
        Me.BTNPRV.UseVisualStyleBackColor = False
        '
        'BTNFST
        '
        Me.BTNFST.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNFST.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNFST.Location = New System.Drawing.Point(31, 56)
        Me.BTNFST.Name = "BTNFST"
        Me.BTNFST.Size = New System.Drawing.Size(75, 23)
        Me.BTNFST.TabIndex = 2
        Me.BTNFST.Text = "<< FIRST"
        Me.BTNFST.UseVisualStyleBackColor = False
        '
        'BTNNXT
        '
        Me.BTNNXT.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNNXT.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNXT.Location = New System.Drawing.Point(31, 20)
        Me.BTNNXT.Name = "BTNNXT"
        Me.BTNNXT.Size = New System.Drawing.Size(75, 23)
        Me.BTNNXT.TabIndex = 1
        Me.BTNNXT.Text = "NEXT >"
        Me.BTNNXT.UseVisualStyleBackColor = False
        '
        'BTNBACK
        '
        Me.BTNBACK.Location = New System.Drawing.Point(316, 177)
        Me.BTNBACK.Name = "BTNBACK"
        Me.BTNBACK.Size = New System.Drawing.Size(75, 23)
        Me.BTNBACK.TabIndex = 0
        Me.BTNBACK.Text = "BACK"
        Me.BTNBACK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HHS STATIONERY INVENTORY"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources._29433279_1828474300516213_26133772189564928_n
        Me.PictureBox1.Location = New System.Drawing.Point(6, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources.gi
        Me.PictureBox2.Location = New System.Drawing.Point(393, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'NewStationeryTableAdapter
        '
        Me.NewStationeryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.NewStationeryTableAdapter = Me.NewStationeryTableAdapter
        Me.TableAdapterManager.UpdateOrder = HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources.main_menu
        Me.ClientSize = New System.Drawing.Size(449, 304)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NewStationeryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.New_StationeryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNLST As System.Windows.Forms.Button
    Friend WithEvents BTNPRV As System.Windows.Forms.Button
    Friend WithEvents BTNFST As System.Windows.Forms.Button
    Friend WithEvents BTNNXT As System.Windows.Forms.Button
    Friend WithEvents BTNBACK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents New_StationeryDataSet As HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSet
    Friend WithEvents NewStationeryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NewStationeryTableAdapter As HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.NewStationeryTableAdapter
    Friend WithEvents TableAdapterManager As HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Item_IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Unit_SizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_TypeTextBox As System.Windows.Forms.TextBox
End Class
