<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim Cp_noLabel As System.Windows.Forms.Label
        Dim Part_numberLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim Specific_gravityLabel As System.Windows.Forms.Label
        Dim Cp_costLabel As System.Windows.Forms.Label
        Dim ObsoleteLabel As System.Windows.Forms.Label
        Dim Part_numberLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ThermodbDataSet = New Compound.thermodbDataSet()
        Me.Cond_compoundBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cond_compoundTableAdapter = New Compound.thermodbDataSetTableAdapters.cond_compoundTableAdapter()
        Me.TableAdapterManager = New Compound.thermodbDataSetTableAdapters.TableAdapterManager()
        Me.Cond_compoundBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Cond_compoundBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cp_noTextBox = New System.Windows.Forms.TextBox()
        Me.Part_numberTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Specific_gravityTextBox = New System.Windows.Forms.TextBox()
        Me.Cp_costTextBox = New System.Windows.Forms.TextBox()
        Me.ObsoleteTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Part_numberListBox = New System.Windows.Forms.ListBox()
        Me.ObsoleteTextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Cp_noLabel = New System.Windows.Forms.Label()
        Part_numberLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        Specific_gravityLabel = New System.Windows.Forms.Label()
        Cp_costLabel = New System.Windows.Forms.Label()
        ObsoleteLabel = New System.Windows.Forms.Label()
        Part_numberLabel1 = New System.Windows.Forms.Label()
        CType(Me.ThermodbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cond_compoundBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cond_compoundBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cond_compoundBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cp_noLabel
        '
        Cp_noLabel.AutoSize = True
        Cp_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cp_noLabel.Location = New System.Drawing.Point(46, 114)
        Cp_noLabel.Name = "Cp_noLabel"
        Cp_noLabel.Size = New System.Drawing.Size(151, 20)
        Cp_noLabel.TabIndex = 1
        Cp_noLabel.Text = "Compound Number:"
        '
        'Part_numberLabel
        '
        Part_numberLabel.AutoSize = True
        Part_numberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Part_numberLabel.Location = New System.Drawing.Point(46, 160)
        Part_numberLabel.Name = "Part_numberLabel"
        Part_numberLabel.Size = New System.Drawing.Size(102, 20)
        Part_numberLabel.TabIndex = 3
        Part_numberLabel.Text = "Part Number:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(46, 204)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(93, 20)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'Specific_gravityLabel
        '
        Specific_gravityLabel.AutoSize = True
        Specific_gravityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Specific_gravityLabel.Location = New System.Drawing.Point(46, 248)
        Specific_gravityLabel.Name = "Specific_gravityLabel"
        Specific_gravityLabel.Size = New System.Drawing.Size(122, 20)
        Specific_gravityLabel.TabIndex = 7
        Specific_gravityLabel.Text = "Specific Gravity:"
        '
        'Cp_costLabel
        '
        Cp_costLabel.AutoSize = True
        Cp_costLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cp_costLabel.Location = New System.Drawing.Point(46, 292)
        Cp_costLabel.Name = "Cp_costLabel"
        Cp_costLabel.Size = New System.Drawing.Size(128, 20)
        Cp_costLabel.TabIndex = 9
        Cp_costLabel.Text = "Compound Cost:"
        '
        'ObsoleteLabel
        '
        ObsoleteLabel.AutoSize = True
        ObsoleteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsoleteLabel.Location = New System.Drawing.Point(46, 377)
        ObsoleteLabel.Name = "ObsoleteLabel"
        ObsoleteLabel.Size = New System.Drawing.Size(82, 20)
        ObsoleteLabel.TabIndex = 11
        ObsoleteLabel.Text = "Obsolete?"
        '
        'Part_numberLabel1
        '
        Part_numberLabel1.AutoSize = True
        Part_numberLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Part_numberLabel1.Location = New System.Drawing.Point(844, 248)
        Part_numberLabel1.Name = "Part_numberLabel1"
        Part_numberLabel1.Size = New System.Drawing.Size(157, 20)
        Part_numberLabel1.TabIndex = 14
        Part_numberLabel1.Text = "Search Part Number:"
        '
        'ThermodbDataSet
        '
        Me.ThermodbDataSet.DataSetName = "thermodbDataSet"
        Me.ThermodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cond_compoundBindingSource
        '
        Me.Cond_compoundBindingSource.DataMember = "cond_compound"
        Me.Cond_compoundBindingSource.DataSource = Me.ThermodbDataSet
        '
        'Cond_compoundTableAdapter
        '
        Me.Cond_compoundTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cond_compoundTableAdapter = Me.Cond_compoundTableAdapter
        Me.TableAdapterManager.UpdateOrder = Compound.thermodbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Cond_compoundBindingNavigator
        '
        Me.Cond_compoundBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Cond_compoundBindingNavigator.BindingSource = Me.Cond_compoundBindingSource
        Me.Cond_compoundBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Cond_compoundBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Cond_compoundBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Cond_compoundBindingNavigatorSaveItem})
        Me.Cond_compoundBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Cond_compoundBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Cond_compoundBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Cond_compoundBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Cond_compoundBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Cond_compoundBindingNavigator.Name = "Cond_compoundBindingNavigator"
        Me.Cond_compoundBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Cond_compoundBindingNavigator.Size = New System.Drawing.Size(1169, 25)
        Me.Cond_compoundBindingNavigator.TabIndex = 0
        Me.Cond_compoundBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Cond_compoundBindingNavigatorSaveItem
        '
        Me.Cond_compoundBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cond_compoundBindingNavigatorSaveItem.Image = CType(resources.GetObject("Cond_compoundBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Cond_compoundBindingNavigatorSaveItem.Name = "Cond_compoundBindingNavigatorSaveItem"
        Me.Cond_compoundBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Cond_compoundBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Cp_noTextBox
        '
        Me.Cp_noTextBox.AllowDrop = True
        Me.Cp_noTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cp_noTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cp_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cond_compoundBindingSource, "cp_no", True))
        Me.Cp_noTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cp_noTextBox.Location = New System.Drawing.Point(228, 111)
        Me.Cp_noTextBox.MaxLength = 6
        Me.Cp_noTextBox.Name = "Cp_noTextBox"
        Me.Cp_noTextBox.Size = New System.Drawing.Size(131, 22)
        Me.Cp_noTextBox.TabIndex = 2
        '
        'Part_numberTextBox
        '
        Me.Part_numberTextBox.AllowDrop = True
        Me.Part_numberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Part_numberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Part_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cond_compoundBindingSource, "part_number", True))
        Me.Part_numberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part_numberTextBox.Location = New System.Drawing.Point(228, 157)
        Me.Part_numberTextBox.MaxLength = 30
        Me.Part_numberTextBox.Name = "Part_numberTextBox"
        Me.Part_numberTextBox.Size = New System.Drawing.Size(429, 22)
        Me.Part_numberTextBox.TabIndex = 4
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.AllowDrop = True
        Me.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cond_compoundBindingSource, "description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(228, 201)
        Me.DescriptionTextBox.MaxLength = 80
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(590, 22)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'Specific_gravityTextBox
        '
        Me.Specific_gravityTextBox.AllowDrop = True
        Me.Specific_gravityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Specific_gravityTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Specific_gravityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cond_compoundBindingSource, "specific_gravity", True))
        Me.Specific_gravityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specific_gravityTextBox.Location = New System.Drawing.Point(228, 245)
        Me.Specific_gravityTextBox.MaxLength = 6
        Me.Specific_gravityTextBox.Name = "Specific_gravityTextBox"
        Me.Specific_gravityTextBox.Size = New System.Drawing.Size(131, 22)
        Me.Specific_gravityTextBox.TabIndex = 8
        '
        'Cp_costTextBox
        '
        Me.Cp_costTextBox.AllowDrop = True
        Me.Cp_costTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cp_costTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cp_costTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cond_compoundBindingSource, "cp_cost", True))
        Me.Cp_costTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cp_costTextBox.Location = New System.Drawing.Point(228, 289)
        Me.Cp_costTextBox.MaxLength = 8
        Me.Cp_costTextBox.Name = "Cp_costTextBox"
        Me.Cp_costTextBox.Size = New System.Drawing.Size(131, 22)
        Me.Cp_costTextBox.TabIndex = 10
        '
        'ObsoleteTextBox
        '
        Me.ObsoleteTextBox.AllowDrop = True
        Me.ObsoleteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ObsoleteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ObsoleteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cond_compoundBindingSource, "obsolete", True))
        Me.ObsoleteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObsoleteTextBox.Location = New System.Drawing.Point(228, 374)
        Me.ObsoleteTextBox.MaxLength = 1
        Me.ObsoleteTextBox.Name = "ObsoleteTextBox"
        Me.ObsoleteTextBox.Size = New System.Drawing.Size(62, 22)
        Me.ObsoleteTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 42)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Compound Data"
        '
        'Part_numberListBox
        '
        Me.Part_numberListBox.BackColor = System.Drawing.SystemColors.Info
        Me.Part_numberListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Cond_compoundBindingSource, "part_number", True))
        Me.Part_numberListBox.DataSource = Me.Cond_compoundBindingSource
        Me.Part_numberListBox.DisplayMember = "part_number"
        Me.Part_numberListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part_numberListBox.FormattingEnabled = True
        Me.Part_numberListBox.ItemHeight = 24
        Me.Part_numberListBox.Location = New System.Drawing.Point(848, 286)
        Me.Part_numberListBox.Name = "Part_numberListBox"
        Me.Part_numberListBox.Size = New System.Drawing.Size(256, 172)
        Me.Part_numberListBox.TabIndex = 15
        '
        'ObsoleteTextBox1
        '
        Me.ObsoleteTextBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ObsoleteTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ObsoleteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cond_compoundBindingSource, "obsolete", True))
        Me.ObsoleteTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObsoleteTextBox1.ForeColor = System.Drawing.Color.Red
        Me.ObsoleteTextBox1.Location = New System.Drawing.Point(446, 274)
        Me.ObsoleteTextBox1.MaxLength = 15
        Me.ObsoleteTextBox1.Name = "ObsoleteTextBox1"
        Me.ObsoleteTextBox1.ReadOnly = True
        Me.ObsoleteTextBox1.Size = New System.Drawing.Size(325, 55)
        Me.ObsoleteTextBox1.TabIndex = 17
        Me.ObsoleteTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(834, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1169, 513)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ObsoleteTextBox1)
        Me.Controls.Add(Part_numberLabel1)
        Me.Controls.Add(Me.Part_numberListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ObsoleteLabel)
        Me.Controls.Add(Me.ObsoleteTextBox)
        Me.Controls.Add(Cp_costLabel)
        Me.Controls.Add(Me.Cp_costTextBox)
        Me.Controls.Add(Specific_gravityLabel)
        Me.Controls.Add(Me.Specific_gravityTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Part_numberLabel)
        Me.Controls.Add(Me.Part_numberTextBox)
        Me.Controls.Add(Cp_noLabel)
        Me.Controls.Add(Me.Cp_noTextBox)
        Me.Controls.Add(Me.Cond_compoundBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Compound"
        CType(Me.ThermodbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cond_compoundBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cond_compoundBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cond_compoundBindingNavigator.ResumeLayout(False)
        Me.Cond_compoundBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ThermodbDataSet As thermodbDataSet
    Friend WithEvents Cond_compoundBindingSource As BindingSource
    Friend WithEvents Cond_compoundTableAdapter As thermodbDataSetTableAdapters.cond_compoundTableAdapter
    Friend WithEvents TableAdapterManager As thermodbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cond_compoundBindingNavigator As BindingNavigator
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
    Friend WithEvents Cond_compoundBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Cp_noTextBox As TextBox
    Friend WithEvents Part_numberTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents Specific_gravityTextBox As TextBox
    Friend WithEvents Cp_costTextBox As TextBox
    Friend WithEvents ObsoleteTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Part_numberListBox As ListBox
    Friend WithEvents ObsoleteTextBox1 As TextBox
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
End Class
