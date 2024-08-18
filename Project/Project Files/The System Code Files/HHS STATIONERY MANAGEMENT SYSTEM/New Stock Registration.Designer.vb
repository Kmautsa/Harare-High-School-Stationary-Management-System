<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Stock_Registration
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
        Dim Unit_PriceLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Date_ReceivedLabel As System.Windows.Forms.Label
        Dim Supplier_IdLabel As System.Windows.Forms.Label
        Dim Supplier_NameLabel As System.Windows.Forms.Label
        Dim Supplier_AdressLabel As System.Windows.Forms.Label
        Dim Contact_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Stock_Registration))
        Me.NewStationeryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.New_StationeryDataSet = New HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Contact_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_AdressTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_IdTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Date_ReceivedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Unit_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Unit_SizeTextBox = New System.Windows.Forms.TextBox()
        Me.Item_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Item_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Item_IdTextBox = New System.Windows.Forms.TextBox()
        Me.NewStationeryTableAdapter = New HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.NewStationeryTableAdapter()
        Me.TableAdapterManager = New HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.TableAdapterManager()
        Me.Btnadd = New System.Windows.Forms.Button()
        Item_IdLabel = New System.Windows.Forms.Label()
        Item_TypeLabel = New System.Windows.Forms.Label()
        Item_NameLabel = New System.Windows.Forms.Label()
        Unit_SizeLabel = New System.Windows.Forms.Label()
        Unit_PriceLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Date_ReceivedLabel = New System.Windows.Forms.Label()
        Supplier_IdLabel = New System.Windows.Forms.Label()
        Supplier_NameLabel = New System.Windows.Forms.Label()
        Supplier_AdressLabel = New System.Windows.Forms.Label()
        Contact_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.NewStationeryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.New_StationeryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Item_IdLabel
        '
        Item_IdLabel.AutoSize = True
        Item_IdLabel.BackColor = System.Drawing.Color.DarkGray
        Item_IdLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_IdLabel.Location = New System.Drawing.Point(19, 26)
        Item_IdLabel.Name = "Item_IdLabel"
        Item_IdLabel.Size = New System.Drawing.Size(57, 15)
        Item_IdLabel.TabIndex = 1
        Item_IdLabel.Text = "Item Id:"
        '
        'Item_TypeLabel
        '
        Item_TypeLabel.AutoSize = True
        Item_TypeLabel.BackColor = System.Drawing.Color.DarkGray
        Item_TypeLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_TypeLabel.Location = New System.Drawing.Point(19, 56)
        Item_TypeLabel.Name = "Item_TypeLabel"
        Item_TypeLabel.Size = New System.Drawing.Size(73, 15)
        Item_TypeLabel.TabIndex = 3
        Item_TypeLabel.Text = "Item Type:"
        '
        'Item_NameLabel
        '
        Item_NameLabel.AutoSize = True
        Item_NameLabel.BackColor = System.Drawing.Color.DarkGray
        Item_NameLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_NameLabel.Location = New System.Drawing.Point(19, 85)
        Item_NameLabel.Name = "Item_NameLabel"
        Item_NameLabel.Size = New System.Drawing.Size(78, 15)
        Item_NameLabel.TabIndex = 5
        Item_NameLabel.Text = "Item Name:"
        '
        'Unit_SizeLabel
        '
        Unit_SizeLabel.AutoSize = True
        Unit_SizeLabel.BackColor = System.Drawing.Color.DarkGray
        Unit_SizeLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Unit_SizeLabel.Location = New System.Drawing.Point(19, 115)
        Unit_SizeLabel.Name = "Unit_SizeLabel"
        Unit_SizeLabel.Size = New System.Drawing.Size(69, 15)
        Unit_SizeLabel.TabIndex = 7
        Unit_SizeLabel.Text = "Unit Size:"
        '
        'Unit_PriceLabel
        '
        Unit_PriceLabel.AutoSize = True
        Unit_PriceLabel.BackColor = System.Drawing.Color.DarkGray
        Unit_PriceLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Unit_PriceLabel.Location = New System.Drawing.Point(19, 146)
        Unit_PriceLabel.Name = "Unit_PriceLabel"
        Unit_PriceLabel.Size = New System.Drawing.Size(76, 15)
        Unit_PriceLabel.TabIndex = 9
        Unit_PriceLabel.Text = "Unit Price:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.BackColor = System.Drawing.Color.DarkGray
        QuantityLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(19, 183)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(65, 15)
        QuantityLabel.TabIndex = 11
        QuantityLabel.Text = "Quantity:"
        '
        'Date_ReceivedLabel
        '
        Date_ReceivedLabel.AutoSize = True
        Date_ReceivedLabel.BackColor = System.Drawing.Color.DarkGray
        Date_ReceivedLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_ReceivedLabel.Location = New System.Drawing.Point(19, 217)
        Date_ReceivedLabel.Name = "Date_ReceivedLabel"
        Date_ReceivedLabel.Size = New System.Drawing.Size(97, 15)
        Date_ReceivedLabel.TabIndex = 13
        Date_ReceivedLabel.Text = "Date Received:"
        '
        'Supplier_IdLabel
        '
        Supplier_IdLabel.AutoSize = True
        Supplier_IdLabel.BackColor = System.Drawing.Color.DarkGray
        Supplier_IdLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_IdLabel.Location = New System.Drawing.Point(27, 30)
        Supplier_IdLabel.Name = "Supplier_IdLabel"
        Supplier_IdLabel.Size = New System.Drawing.Size(81, 15)
        Supplier_IdLabel.TabIndex = 15
        Supplier_IdLabel.Text = "Supplier Id:"
        '
        'Supplier_NameLabel
        '
        Supplier_NameLabel.AutoSize = True
        Supplier_NameLabel.BackColor = System.Drawing.Color.DarkGray
        Supplier_NameLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_NameLabel.Location = New System.Drawing.Point(27, 56)
        Supplier_NameLabel.Name = "Supplier_NameLabel"
        Supplier_NameLabel.Size = New System.Drawing.Size(102, 15)
        Supplier_NameLabel.TabIndex = 16
        Supplier_NameLabel.Text = "Supplier Name:"
        AddHandler Supplier_NameLabel.Click, AddressOf Me.Supplier_NameLabel_Click
        '
        'Supplier_AdressLabel
        '
        Supplier_AdressLabel.AutoSize = True
        Supplier_AdressLabel.BackColor = System.Drawing.Color.DarkGray
        Supplier_AdressLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_AdressLabel.Location = New System.Drawing.Point(31, 96)
        Supplier_AdressLabel.Name = "Supplier_AdressLabel"
        Supplier_AdressLabel.Size = New System.Drawing.Size(109, 15)
        Supplier_AdressLabel.TabIndex = 19
        Supplier_AdressLabel.Text = "Supplier Adress:"
        AddHandler Supplier_AdressLabel.Click, AddressOf Me.Supplier_AdressLabel_Click
        '
        'Contact_NumberLabel
        '
        Contact_NumberLabel.AutoSize = True
        Contact_NumberLabel.BackColor = System.Drawing.Color.DarkGray
        Contact_NumberLabel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contact_NumberLabel.Location = New System.Drawing.Point(27, 141)
        Contact_NumberLabel.Name = "Contact_NumberLabel"
        Contact_NumberLabel.Size = New System.Drawing.Size(110, 15)
        Contact_NumberLabel.TabIndex = 20
        Contact_NumberLabel.Text = "Contact Number:"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NEW STOCK REGISTRATION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources._29433279_1828474300516213_26133772189564928_n
        Me.PictureBox1.Location = New System.Drawing.Point(0, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Btnclear
        '
        Me.Btnclear.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Btnclear.Location = New System.Drawing.Point(12, 381)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(75, 23)
        Me.Btnclear.TabIndex = 4
        Me.Btnclear.Text = "CLEAR"
        Me.Btnclear.UseVisualStyleBackColor = False
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Btnsave.Location = New System.Drawing.Point(209, 381)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(75, 23)
        Me.Btnsave.TabIndex = 5
        Me.Btnsave.Text = "SAVE"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Btnback
        '
        Me.Btnback.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Btnback.Location = New System.Drawing.Point(480, 381)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(75, 23)
        Me.Btnback.TabIndex = 6
        Me.Btnback.Text = "BACK"
        Me.Btnback.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources.gi
        Me.PictureBox2.Location = New System.Drawing.Point(499, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 67)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.BackgroundImage = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources.main
        Me.GroupBox2.Controls.Add(Contact_NumberLabel)
        Me.GroupBox2.Controls.Add(Me.Contact_NumberTextBox)
        Me.GroupBox2.Controls.Add(Supplier_AdressLabel)
        Me.GroupBox2.Controls.Add(Me.Supplier_AdressTextBox)
        Me.GroupBox2.Controls.Add(Supplier_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Supplier_NameTextBox)
        Me.GroupBox2.Controls.Add(Supplier_IdLabel)
        Me.GroupBox2.Controls.Add(Me.Supplier_IdTextBox)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(280, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 200)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SUPPLIER DETAILS"
        '
        'Contact_NumberTextBox
        '
        Me.Contact_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Contact Number", True))
        Me.Contact_NumberTextBox.Location = New System.Drawing.Point(143, 141)
        Me.Contact_NumberTextBox.Name = "Contact_NumberTextBox"
        Me.Contact_NumberTextBox.Size = New System.Drawing.Size(115, 20)
        Me.Contact_NumberTextBox.TabIndex = 21
        '
        'Supplier_AdressTextBox
        '
        Me.Supplier_AdressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Supplier Adress", True))
        Me.Supplier_AdressTextBox.Location = New System.Drawing.Point(143, 96)
        Me.Supplier_AdressTextBox.Name = "Supplier_AdressTextBox"
        Me.Supplier_AdressTextBox.Size = New System.Drawing.Size(115, 20)
        Me.Supplier_AdressTextBox.TabIndex = 20
        '
        'Supplier_NameTextBox
        '
        Me.Supplier_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Supplier Name", True))
        Me.Supplier_NameTextBox.Location = New System.Drawing.Point(143, 56)
        Me.Supplier_NameTextBox.Multiline = True
        Me.Supplier_NameTextBox.Name = "Supplier_NameTextBox"
        Me.Supplier_NameTextBox.Size = New System.Drawing.Size(115, 27)
        Me.Supplier_NameTextBox.TabIndex = 17
        '
        'Supplier_IdTextBox
        '
        Me.Supplier_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Supplier Id", True))
        Me.Supplier_IdTextBox.Location = New System.Drawing.Point(142, 30)
        Me.Supplier_IdTextBox.Name = "Supplier_IdTextBox"
        Me.Supplier_IdTextBox.Size = New System.Drawing.Size(116, 20)
        Me.Supplier_IdTextBox.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.BackgroundImage = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources.Login_background_
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Date_ReceivedLabel)
        Me.GroupBox1.Controls.Add(Me.Date_ReceivedDateTimePicker)
        Me.GroupBox1.Controls.Add(QuantityLabel)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Unit_PriceLabel)
        Me.GroupBox1.Controls.Add(Me.Unit_PriceTextBox)
        Me.GroupBox1.Controls.Add(Unit_SizeLabel)
        Me.GroupBox1.Controls.Add(Me.Unit_SizeTextBox)
        Me.GroupBox1.Controls.Add(Item_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Item_NameTextBox)
        Me.GroupBox1.Controls.Add(Item_TypeLabel)
        Me.GroupBox1.Controls.Add(Me.Item_TypeTextBox)
        Me.GroupBox1.Controls.Add(Item_IdLabel)
        Me.GroupBox1.Controls.Add(Me.Item_IdTextBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 298)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STATIONERY DETAILS"
        '
        'Date_ReceivedDateTimePicker
        '
        Me.Date_ReceivedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NewStationeryBindingSource, "Date Received", True))
        Me.Date_ReceivedDateTimePicker.Location = New System.Drawing.Point(144, 212)
        Me.Date_ReceivedDateTimePicker.Name = "Date_ReceivedDateTimePicker"
        Me.Date_ReceivedDateTimePicker.Size = New System.Drawing.Size(130, 20)
        Me.Date_ReceivedDateTimePicker.TabIndex = 14
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(107, 181)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 12
        '
        'Unit_PriceTextBox
        '
        Me.Unit_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Unit Price", True))
        Me.Unit_PriceTextBox.Location = New System.Drawing.Point(107, 144)
        Me.Unit_PriceTextBox.Name = "Unit_PriceTextBox"
        Me.Unit_PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Unit_PriceTextBox.TabIndex = 10
        '
        'Unit_SizeTextBox
        '
        Me.Unit_SizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Unit Size", True))
        Me.Unit_SizeTextBox.Location = New System.Drawing.Point(107, 113)
        Me.Unit_SizeTextBox.Name = "Unit_SizeTextBox"
        Me.Unit_SizeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Unit_SizeTextBox.TabIndex = 8
        '
        'Item_NameTextBox
        '
        Me.Item_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Item Name", True))
        Me.Item_NameTextBox.Location = New System.Drawing.Point(107, 86)
        Me.Item_NameTextBox.Name = "Item_NameTextBox"
        Me.Item_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Item_NameTextBox.TabIndex = 6
        '
        'Item_TypeTextBox
        '
        Me.Item_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Item Type", True))
        Me.Item_TypeTextBox.Location = New System.Drawing.Point(107, 56)
        Me.Item_TypeTextBox.Name = "Item_TypeTextBox"
        Me.Item_TypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Item_TypeTextBox.TabIndex = 4
        '
        'Item_IdTextBox
        '
        Me.Item_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Item Id", True))
        Me.Item_IdTextBox.Location = New System.Drawing.Point(107, 24)
        Me.Item_IdTextBox.Name = "Item_IdTextBox"
        Me.Item_IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Item_IdTextBox.TabIndex = 2
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
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Btnadd.Location = New System.Drawing.Point(111, 381)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(75, 23)
        Me.Btnadd.TabIndex = 8
        Me.Btnadd.Text = "Add >"
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'New_Stock_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources.Backgroundnewstock
        Me.ClientSize = New System.Drawing.Size(571, 410)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Btnback)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "New_Stock_Registration"
        Me.Text = "New_Stock_Registration"
        CType(Me.NewStationeryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.New_StationeryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btnclear As System.Windows.Forms.Button
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Btnback As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents New_StationeryDataSet As HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSet
    Friend WithEvents NewStationeryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NewStationeryTableAdapter As HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.NewStationeryTableAdapter
    Friend WithEvents TableAdapterManager As HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Supplier_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Supplier_IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_ReceivedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Unit_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Unit_SizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Supplier_AdressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Contact_NumberTextBox As System.Windows.Forms.TextBox
End Class
