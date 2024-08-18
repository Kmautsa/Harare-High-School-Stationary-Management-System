<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock_Out_Transaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stock_Out_Transaction))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txrsrch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Btndeduct = New System.Windows.Forms.Button()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.NewStationeryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.New_StationeryDataSet = New HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSet()
        Me.Unit_SizeTextBox = New System.Windows.Forms.TextBox()
        Me.Item_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Item_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Item_IdTextBox = New System.Windows.Forms.TextBox()
        Me.NewStationeryTableAdapter = New HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.NewStationeryTableAdapter()
        Me.TableAdapterManager = New HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.TableAdapterManager()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Item_IdLabel = New System.Windows.Forms.Label()
        Item_TypeLabel = New System.Windows.Forms.Label()
        Item_NameLabel = New System.Windows.Forms.Label()
        Unit_SizeLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NewStationeryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.New_StationeryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Item_IdLabel
        '
        Item_IdLabel.AutoSize = True
        Item_IdLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Item_IdLabel.Location = New System.Drawing.Point(21, 74)
        Item_IdLabel.Name = "Item_IdLabel"
        Item_IdLabel.Size = New System.Drawing.Size(55, 15)
        Item_IdLabel.TabIndex = 0
        Item_IdLabel.Text = "Item Id:"
        '
        'Item_TypeLabel
        '
        Item_TypeLabel.AutoSize = True
        Item_TypeLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Item_TypeLabel.Location = New System.Drawing.Point(21, 103)
        Item_TypeLabel.Name = "Item_TypeLabel"
        Item_TypeLabel.Size = New System.Drawing.Size(69, 15)
        Item_TypeLabel.TabIndex = 2
        Item_TypeLabel.Text = "Item Type:"
        '
        'Item_NameLabel
        '
        Item_NameLabel.AutoSize = True
        Item_NameLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Item_NameLabel.Location = New System.Drawing.Point(21, 132)
        Item_NameLabel.Name = "Item_NameLabel"
        Item_NameLabel.Size = New System.Drawing.Size(74, 15)
        Item_NameLabel.TabIndex = 4
        Item_NameLabel.Text = "Item Name:"
        '
        'Unit_SizeLabel
        '
        Unit_SizeLabel.AutoSize = True
        Unit_SizeLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Unit_SizeLabel.Location = New System.Drawing.Point(21, 164)
        Unit_SizeLabel.Name = "Unit_SizeLabel"
        Unit_SizeLabel.Size = New System.Drawing.Size(65, 15)
        Unit_SizeLabel.TabIndex = 6
        Unit_SizeLabel.Text = "Unit Size:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        QuantityLabel.Location = New System.Drawing.Point(21, 199)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(62, 15)
        QuantityLabel.TabIndex = 8
        QuantityLabel.Text = "Quantity:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources.Login_background_
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txrsrch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.Btndeduct)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 265)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stationery Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "<ItemName"
        '
        'Txrsrch
        '
        Me.Txrsrch.Location = New System.Drawing.Point(101, 31)
        Me.Txrsrch.Name = "Txrsrch"
        Me.Txrsrch.Size = New System.Drawing.Size(143, 20)
        Me.Txrsrch.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Search"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnSave.Location = New System.Drawing.Point(139, 225)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 11
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Btndeduct
        '
        Me.Btndeduct.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Btndeduct.Location = New System.Drawing.Point(24, 225)
        Me.Btndeduct.Name = "Btndeduct"
        Me.Btndeduct.Size = New System.Drawing.Size(75, 23)
        Me.Btndeduct.TabIndex = 10
        Me.Btndeduct.Text = "Deduct >>"
        Me.Btndeduct.UseVisualStyleBackColor = False
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(101, 199)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(111, 20)
        Me.QuantityTextBox.TabIndex = 9
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
        Me.Unit_SizeTextBox.Location = New System.Drawing.Point(101, 164)
        Me.Unit_SizeTextBox.Name = "Unit_SizeTextBox"
        Me.Unit_SizeTextBox.Size = New System.Drawing.Size(111, 20)
        Me.Unit_SizeTextBox.TabIndex = 7
        '
        'Item_NameTextBox
        '
        Me.Item_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Item Name", True))
        Me.Item_NameTextBox.Location = New System.Drawing.Point(101, 132)
        Me.Item_NameTextBox.Name = "Item_NameTextBox"
        Me.Item_NameTextBox.Size = New System.Drawing.Size(111, 20)
        Me.Item_NameTextBox.TabIndex = 5
        '
        'Item_TypeTextBox
        '
        Me.Item_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Item Type", True))
        Me.Item_TypeTextBox.Location = New System.Drawing.Point(103, 103)
        Me.Item_TypeTextBox.Name = "Item_TypeTextBox"
        Me.Item_TypeTextBox.Size = New System.Drawing.Size(111, 20)
        Me.Item_TypeTextBox.TabIndex = 3
        '
        'Item_IdTextBox
        '
        Me.Item_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewStationeryBindingSource, "Item Id", True))
        Me.Item_IdTextBox.Location = New System.Drawing.Point(103, 71)
        Me.Item_IdTextBox.Name = "Item_IdTextBox"
        Me.Item_IdTextBox.Size = New System.Drawing.Size(111, 20)
        Me.Item_IdTextBox.TabIndex = 1
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
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(364, 332)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 12
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Harare High Stationery"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources._29433279_1828474300516213_26133772189564928_n
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.Image = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources.gi
        Me.PictureBox2.Location = New System.Drawing.Point(299, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 67)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Stationery HandOut"
        '
        'Stock_Out_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = Global.HHS_STATIONERY_MANAGEMENT_SYSTEM.My.Resources.Resources.main
        Me.ClientSize = New System.Drawing.Size(466, 359)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Stock_Out_Transaction"
        Me.Text = "Stock_Out_Transaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NewStationeryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.New_StationeryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents New_StationeryDataSet As HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSet
    Friend WithEvents NewStationeryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NewStationeryTableAdapter As HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.NewStationeryTableAdapter
    Friend WithEvents TableAdapterManager As HHS_STATIONERY_MANAGEMENT_SYSTEM.New_StationeryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Item_IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Btndeduct As System.Windows.Forms.Button
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Unit_SizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txrsrch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
