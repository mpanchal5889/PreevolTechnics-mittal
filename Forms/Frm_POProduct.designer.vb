﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_POProduct
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.XtraForm' is not defined.
    Inherits DevExpress.XtraEditors.XtraForm
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.XtraForm' is not defined.

    'Form overrides dispose to clean up the component list.
#Disable Warning BC30284 ' sub 'Dispose' cannot be declared 'Overrides' because it does not override a sub in a base class.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
#Enable Warning BC30284 ' sub 'Dispose' cannot be declared 'Overrides' because it does not override a sub in a base class.
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_POProduct))
        Me.PanelCtrl = New DevExpress.XtraEditors.PanelControl()
        Me.AddNewSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.PriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.NewBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.OpenBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.DeleteBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PrintBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SubCategoryIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.MachineNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.UOMComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.HSNNoOrSACNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProductNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CategoryIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelCtrlMain = New DevExpress.XtraEditors.PanelControl()
        Me.CancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.SaveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrl.SuspendLayout()
        CType(Me.PriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOMComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HSNNoOrSACNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCtrlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCtrl
        '
        Me.PanelCtrl.Controls.Add(Me.AddNewSimpleButton)
        Me.PanelCtrl.Controls.Add(Me.LabelControl9)
        Me.PanelCtrl.Controls.Add(Me.LabelControl7)
        Me.PanelCtrl.Controls.Add(Me.PriceTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl6)
        Me.PanelCtrl.Controls.Add(Me.SubCategoryIDLookUpEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl5)
        Me.PanelCtrl.Controls.Add(Me.LabelControl2)
        Me.PanelCtrl.Controls.Add(Me.MachineNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl4)
        Me.PanelCtrl.Controls.Add(Me.UOMComboBoxEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl3)
        Me.PanelCtrl.Controls.Add(Me.HSNNoOrSACNoTextEdit)
        Me.PanelCtrl.Controls.Add(Me.ProductNameTextEdit)
        Me.PanelCtrl.Controls.Add(Me.LabelControl1)
        Me.PanelCtrl.Controls.Add(Me.CategoryIDLookUpEdit)
        Me.PanelCtrl.Location = New System.Drawing.Point(5, 5)
        Me.PanelCtrl.Name = "PanelCtrl"
        Me.PanelCtrl.Size = New System.Drawing.Size(390, 161)
        Me.PanelCtrl.TabIndex = 0
        '
        'AddNewSimpleButton
        '
        Me.AddNewSimpleButton.Location = New System.Drawing.Point(331, 8)
        Me.AddNewSimpleButton.Name = "AddNewSimpleButton"
        Me.AddNewSimpleButton.Size = New System.Drawing.Size(54, 39)
        Me.AddNewSimpleButton.TabIndex = 3
        Me.AddNewSimpleButton.TabStop = False
        Me.AddNewSimpleButton.Text = "Add New"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Location = New System.Drawing.Point(84, 60)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl9.TabIndex = 46
        Me.LabelControl9.Text = "*"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(276, 138)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl7.TabIndex = 44
        Me.LabelControl7.Text = "Price"
        '
        'PriceTextEdit
        '
        Me.PriceTextEdit.Location = New System.Drawing.Point(305, 135)
        Me.PriceTextEdit.MenuManager = Me.BarManager1
        Me.PriceTextEdit.Name = "PriceTextEdit"
        Me.PriceTextEdit.Size = New System.Drawing.Size(80, 20)
        Me.PriceTextEdit.TabIndex = 6
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.NewBarButtonItem, Me.OpenBarButtonItem, Me.PrintBarButtonItem, Me.DeleteBarButtonItem})
        Me.BarManager1.MaxItemId = 4
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.NewBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.OpenBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.DeleteBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'NewBarButtonItem
        '
        Me.NewBarButtonItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.NewBarButtonItem.Caption = "New"
        Me.NewBarButtonItem.Glyph = CType(resources.GetObject("NewBarButtonItem.Glyph"), System.Drawing.Image)
        Me.NewBarButtonItem.Id = 0
        Me.NewBarButtonItem.LargeGlyph = CType(resources.GetObject("NewBarButtonItem.LargeGlyph"), System.Drawing.Image)
        Me.NewBarButtonItem.Name = "NewBarButtonItem"
        '
        'OpenBarButtonItem
        '
        Me.OpenBarButtonItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.OpenBarButtonItem.Caption = "Open"
        Me.OpenBarButtonItem.Glyph = CType(resources.GetObject("OpenBarButtonItem.Glyph"), System.Drawing.Image)
        Me.OpenBarButtonItem.Id = 1
        Me.OpenBarButtonItem.LargeGlyph = CType(resources.GetObject("OpenBarButtonItem.LargeGlyph"), System.Drawing.Image)
        Me.OpenBarButtonItem.Name = "OpenBarButtonItem"
        '
        'DeleteBarButtonItem
        '
        Me.DeleteBarButtonItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.DeleteBarButtonItem.Caption = "Delete"
        Me.DeleteBarButtonItem.Glyph = CType(resources.GetObject("DeleteBarButtonItem.Glyph"), System.Drawing.Image)
        Me.DeleteBarButtonItem.Id = 3
        Me.DeleteBarButtonItem.LargeGlyph = CType(resources.GetObject("DeleteBarButtonItem.LargeGlyph"), System.Drawing.Image)
        Me.DeleteBarButtonItem.Name = "DeleteBarButtonItem"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(422, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 250)
        Me.barDockControlBottom.Size = New System.Drawing.Size(422, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 219)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(422, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 219)
        '
        'PrintBarButtonItem
        '
        Me.PrintBarButtonItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.PrintBarButtonItem.Caption = "Print"
        Me.PrintBarButtonItem.Glyph = CType(resources.GetObject("PrintBarButtonItem.Glyph"), System.Drawing.Image)
        Me.PrintBarButtonItem.Id = 2
        Me.PrintBarButtonItem.LargeGlyph = CType(resources.GetObject("PrintBarButtonItem.LargeGlyph"), System.Drawing.Image)
        Me.PrintBarButtonItem.Name = "PrintBarButtonItem"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(8, 8)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl6.TabIndex = 41
        Me.LabelControl6.Text = "Category"
        '
        'SubCategoryIDLookUpEdit
        '
        Me.SubCategoryIDLookUpEdit.EnterMoveNextControl = True
        Me.SubCategoryIDLookUpEdit.Location = New System.Drawing.Point(104, 31)
        Me.SubCategoryIDLookUpEdit.Name = "SubCategoryIDLookUpEdit"
        Me.SubCategoryIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubCategoryIDLookUpEdit.Properties.NullText = ""
        Me.SubCategoryIDLookUpEdit.Size = New System.Drawing.Size(221, 20)
        Me.SubCategoryIDLookUpEdit.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(8, 34)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl5.TabIndex = 39
        Me.LabelControl5.Text = "Sub Category"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(8, 138)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 38
        Me.LabelControl2.Text = "Machine No."
        '
        'MachineNoTextEdit
        '
        Me.MachineNoTextEdit.Location = New System.Drawing.Point(104, 135)
        Me.MachineNoTextEdit.MenuManager = Me.BarManager1
        Me.MachineNoTextEdit.Name = "MachineNoTextEdit"
        Me.MachineNoTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.MachineNoTextEdit.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(8, 86)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl4.TabIndex = 36
        Me.LabelControl4.Text = "Unit Of Measure"
        '
        'UOMComboBoxEdit
        '
        Me.UOMComboBoxEdit.Location = New System.Drawing.Point(104, 83)
        Me.UOMComboBoxEdit.MenuManager = Me.BarManager1
        Me.UOMComboBoxEdit.Name = "UOMComboBoxEdit"
        Me.UOMComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UOMComboBoxEdit.Properties.Items.AddRange(New Object() {"Nos.", "Set", "Ltrs.", "Mtrs.", "KGs."})
        Me.UOMComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.UOMComboBoxEdit.Size = New System.Drawing.Size(119, 20)
        Me.UOMComboBoxEdit.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 112)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "HSN No/SAC No"
        '
        'HSNNoOrSACNoTextEdit
        '
        Me.HSNNoOrSACNoTextEdit.Location = New System.Drawing.Point(104, 109)
        Me.HSNNoOrSACNoTextEdit.MenuManager = Me.BarManager1
        Me.HSNNoOrSACNoTextEdit.Name = "HSNNoOrSACNoTextEdit"
        Me.HSNNoOrSACNoTextEdit.Size = New System.Drawing.Size(281, 20)
        Me.HSNNoOrSACNoTextEdit.TabIndex = 4
        '
        'ProductNameTextEdit
        '
        Me.ProductNameTextEdit.Location = New System.Drawing.Point(104, 57)
        Me.ProductNameTextEdit.MenuManager = Me.BarManager1
        Me.ProductNameTextEdit.Name = "ProductNameTextEdit"
        Me.ProductNameTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProductNameTextEdit.Size = New System.Drawing.Size(281, 20)
        Me.ProductNameTextEdit.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Product Name"
        '
        'CategoryIDLookUpEdit
        '
        Me.CategoryIDLookUpEdit.Location = New System.Drawing.Point(104, 5)
        Me.CategoryIDLookUpEdit.MenuManager = Me.BarManager1
        Me.CategoryIDLookUpEdit.Name = "CategoryIDLookUpEdit"
        Me.CategoryIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CategoryIDLookUpEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CategoryIDLookUpEdit.Properties.NullText = ""
        Me.CategoryIDLookUpEdit.Properties.PopupSizeable = False
        Me.CategoryIDLookUpEdit.Size = New System.Drawing.Size(221, 20)
        Me.CategoryIDLookUpEdit.TabIndex = 0
        '
        'PanelCtrlMain
        '
        Me.PanelCtrlMain.Controls.Add(Me.CancelSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.SaveSimpleButton)
        Me.PanelCtrlMain.Controls.Add(Me.PanelCtrl)
        Me.PanelCtrlMain.Location = New System.Drawing.Point(12, 37)
        Me.PanelCtrlMain.Name = "PanelCtrlMain"
        Me.PanelCtrlMain.Size = New System.Drawing.Size(401, 208)
        Me.PanelCtrlMain.TabIndex = 0
        '
        'CancelSimpleButton
        '
        Me.CancelSimpleButton.Image = CType(resources.GetObject("CancelSimpleButton.Image"), System.Drawing.Image)
        Me.CancelSimpleButton.Location = New System.Drawing.Point(190, 172)
        Me.CancelSimpleButton.Name = "CancelSimpleButton"
        Me.CancelSimpleButton.Size = New System.Drawing.Size(75, 30)
        Me.CancelSimpleButton.TabIndex = 2
        Me.CancelSimpleButton.Text = "Cancel"
        '
        'SaveSimpleButton
        '
        Me.SaveSimpleButton.Image = CType(resources.GetObject("SaveSimpleButton.Image"), System.Drawing.Image)
        Me.SaveSimpleButton.Location = New System.Drawing.Point(109, 172)
        Me.SaveSimpleButton.Name = "SaveSimpleButton"
        Me.SaveSimpleButton.Size = New System.Drawing.Size(75, 30)
        Me.SaveSimpleButton.TabIndex = 1
        Me.SaveSimpleButton.Text = "Save"
        '
        'Frm_POProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 250)
        Me.Controls.Add(Me.PanelCtrlMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_POProduct"
        Me.Text = "PO Product"
        CType(Me.PanelCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrl.ResumeLayout(False)
        Me.PanelCtrl.PerformLayout()
        CType(Me.PriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOMComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HSNNoOrSACNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelCtrlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCtrlMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
    Friend WithEvents PanelCtrl As DevExpress.XtraEditors.PanelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.
    Friend WithEvents PanelCtrlMain As DevExpress.XtraEditors.PanelControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.PanelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarManager' is not defined.
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarManager' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.Bar' is not defined.
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.Bar' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
    Friend WithEvents NewBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
    Friend WithEvents OpenBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
    Friend WithEvents PrintBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.
    Friend WithEvents DeleteBarButtonItem As DevExpress.XtraBars.BarButtonItem
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarButtonItem' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
#Enable Warning BC30002 ' Type 'DevExpress.XtraBars.BarDockControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.
    Friend WithEvents CancelSimpleButton As DevExpress.XtraEditors.SimpleButton
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.
    Friend WithEvents SaveSimpleButton As DevExpress.XtraEditors.SimpleButton
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.SimpleButton' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.LabelControl' is not defined.

#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProductNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HSNNoOrSACNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UOMComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MachineNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SubCategoryIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CategoryIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents AddNewSimpleButton As DevExpress.XtraEditors.SimpleButton
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.TextEdit' is not defined.
#Disable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
#Enable Warning BC30002 ' Type 'DevExpress.XtraEditors.MemoEdit' is not defined.
End Class
