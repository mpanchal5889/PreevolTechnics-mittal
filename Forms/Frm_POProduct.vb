﻿Imports System.Data.OleDb
Imports DevExpress.XtraEditors
'Imports ELCF
Public Class Frm_POProduct
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim BS As New BindingSource
    Dim DADetails As New OleDbDataAdapter
    Dim Status As Integer = 0

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDataTable()
        SetQuery()
        SetBinding()
        InitLookup()
        AddNew()
        ProductNameTextEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub

    Function SetDataTable()
        DS.Tables.Add("POProduct")
        With DS.Tables("POProduct").Columns
            .Add("POProductID", GetType(Integer))
            .Add("CategoryID", GetType(Integer))
            .Add("SubCategoryID", GetType(Integer))
            .Add("ProductName", GetType(String))
            .Add("UOM", GetType(String))
            .Add("HSNNoOrSACNo", GetType(String))
            .Add("MachineNo", GetType(String))
            .Add("Price", GetType(Double))
            .Add("FullProductName", GetType(String))
            .Add("Company", GetType(String))
        End With

        With DS.Tables("POProduct").Columns("POProductID")
            .AutoIncrement = True
            .AutoIncrementSeed = -1
            .AutoIncrementStep = -1
            .ReadOnly = True
            .Unique = True
        End With
        Return True
    End Function

    Function SetQuery()
        DA.SelectCommand = New OleDbCommand("Select POProductID,CategoryID,SubCategoryID,ProductName,UOM,HSNNoOrSACNo,MachineNo,Price,Company From POProduct Where POProductID=@POProductID", ConStr)
        DA.SelectCommand.Parameters.Add("@POProductID", OleDbType.Integer, 4, "POProductID")

        DA.InsertCommand = New OleDbCommand("Insert Into POProduct (CategoryID,SubCategoryID,ProductName,UOM,HSNNoOrSACNo,MachineNo,Price,FullProductName,Company) Values (@CategoryID,@SubCategoryID,@ProductName,@UOM,@HSNNoOrSACNo,@MachineNo,@Price,@FullProductName,@Company)", ConStr)
        DA.InsertCommand.Parameters.Add("@CategoryID", OleDbType.Integer, 4, "CategoryID")
        DA.InsertCommand.Parameters.Add("@SubCategoryID", OleDbType.Integer, 4, "SubCategoryID")
        DA.InsertCommand.Parameters.Add("@ProductName", OleDbType.VarChar, 50, "ProductName")
        DA.InsertCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DA.InsertCommand.Parameters.Add("@HSNNoOrSACNo", OleDbType.VarChar, 50, "HSNNoOrSACNo")
        DA.InsertCommand.Parameters.Add("@MachineNo", OleDbType.VarChar, 50, "MachineNo")
        DA.InsertCommand.Parameters.Add("@Price", OleDbType.Double, 8, "Price")
        DA.InsertCommand.Parameters.Add("@FullProductName", OleDbType.VarChar, 200, "FullProductName")
        DA.InsertCommand.Parameters.Add("@Company", OleDbType.VarChar, 50, "Company")

        DA.UpdateCommand = New OleDbCommand("Update POProduct Set CategoryID=@CategoryID,SubCategoryID=@SubCategoryID,ProductName=@ProductName,UOM=@UMO,HSNNoOrSACNo=@HSNNoOrSACNo,MachineNo=@MachineNo,Price=@Price,FullProductName=@FullProductName Where POProductID=@POProductID", ConStr)
        DA.UpdateCommand.Parameters.Add("@CategoryID", OleDbType.Integer, 4, "CategoryID")
        DA.UpdateCommand.Parameters.Add("@SubCategoryID", OleDbType.Integer, 4, "SubCategoryID")
        DA.UpdateCommand.Parameters.Add("@ProductName", OleDbType.VarChar, 50, "ProductName")
        DA.UpdateCommand.Parameters.Add("@UOM", OleDbType.VarChar, 50, "UOM")
        DA.UpdateCommand.Parameters.Add("@HSNNoOrSACNo", OleDbType.VarChar, 50, "HSNNoOrSACNo")
        DA.UpdateCommand.Parameters.Add("@MachineNo", OleDbType.VarChar, 50, "MachineNo")
        DA.UpdateCommand.Parameters.Add("@Price", OleDbType.Double, 8, "Price")
        DA.UpdateCommand.Parameters.Add("@FullProductName", OleDbType.VarChar, 200, "FullProductName")
        DA.UpdateCommand.Parameters.Add("@POProductID", OleDbType.Integer, 4, "POProductID")


        DA.DeleteCommand = New OleDbCommand("Delete From POProduct Where POProductID=@POProductID", ConStr)
        DA.DeleteCommand.Parameters.Add("@POProductID", OleDbType.Integer, 4, "POProductID")
        Return True
    End Function

    Function SetBinding()
        BS.DataSource = DS.Tables("POProduct")
        CategoryIDLookUpEdit.DataBindings.Add(New Binding("EditValue", BS, "CategoryID"))
        SubCategoryIDLookUpEdit.DataBindings.Add(New Binding("EditValue", BS, "SubCategoryID"))
        ProductNameTextEdit.DataBindings.Add(New Binding("EditValue", BS, "ProductName"))
        UOMComboBoxEdit.DataBindings.Add(New Binding("EditValue", BS, "UOM"))
        HSNNoOrSACNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "HSNNoOrSACNo"))
        MachineNoTextEdit.DataBindings.Add(New Binding("EditValue", BS, "MachineNo"))
        PriceTextEdit.DataBindings.Add(New Binding("EditValue", BS, "Price"))
        Return True
    End Function
    Sub InitLookup()
        SetLookUp("SELECT CategoryID, CategoryName FROM Category", "Category", "CategoryID", "CategoryName", CategoryIDLookUpEdit, "Category")
    End Sub

    Sub AddNew()
        BS.AddNew()
        CategoryIDLookUpEdit.Focus()
    End Sub

    Private Sub NewBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles NewBarButtonItem.ItemClick
        BS.CancelEdit()
        DS.RejectChanges()
        AddNew()
        CategoryIDLookUpEdit.Focus()
    End Sub

    Private Sub OpenBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles OpenBarButtonItem.ItemClick
        Dim ID = ShowRecord("Select * From POProduct Where Company ='" + PubCompanyName + "'", "POProductID")
        If ID > 0 Then
            Try
                DS.Tables("POProduct").Clear()
            Catch
            End Try
            DA.SelectCommand.Parameters("@POProductID").Value = ID
            DA.Fill(DS, "POProduct")
        End If
    End Sub

    Private Sub DeleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DeleteBarButtonItem.ItemClick
        Try
            Dim Delete = XtraMessageBox.Show("Are You Want To Delete This Record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Delete = 1 Then
                BS.RemoveCurrent()
                DA.Update(DS.Tables("POProduct"))
                AddNew()
            End If
        Catch ex As Exception
            BS.CancelEdit()
            DS.RejectChanges()
            XtraMessageBox.Show("Operation Failed :", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Validation() As Boolean
        If ProductNameTextEdit.EditValue Is DBNull.Value Then
            ProductNameTextEdit.Focus()
            Return False
            'ElseIf SubCategoryIDLookUpEdit.EditValue Is DBNull.Value Then
            '    SubCategoryIDLookUpEdit.Focus()
            '    Return False
            'ElseIf CategoryIDLookUpEdit.EditValue Is DBNull.Value Then
            '    CategoryIDLookUpEdit.Focus()
            '    Return False
            'ElseIf HSNNoOrSACNoTextEdit.EditValue Is DBNull.Value Then
            '    HSNNoOrSACNoTextEdit.Focus()
            '    Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        If Validation() Then
            BS.Current!Company = PubCompanyName
            BS.Current!UOM = UOMComboBoxEdit.Text
            BS.Current!FullProductName = SubCategoryIDLookUpEdit.Text + " _ " + ProductNameTextEdit.Text
            BS.EndEdit()
            DA.Update(DS.Tables("POProduct"))
            AddNew()
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub

    Private Sub ProductNameTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ProductNameTextEdit.Validating
        If Not ProductNameTextEdit.EditValue Is DBNull.Value Then
            Try
                Dim CMD As New OleDbCommand("SELECT Count(POProductID) FROM POProduct WHERE ProductName=@ProductName AND CategoryID=@CategoryID AND SubCategoryID=@SubCategoryID AND POProductID<>@POProductID", ConStr)
                CMD.Parameters.AddWithValue("@ProductName", ProductNameTextEdit.EditValue)
                CMD.Parameters.AddWithValue("@CategoryID", CategoryIDLookUpEdit.EditValue)
                CMD.Parameters.AddWithValue("@SubCategoryID", SubCategoryIDLookUpEdit.EditValue)
                CMD.Parameters.AddWithValue("@POProductID", IIf(BS.Current!POProductID Is DBNull.Value, -1, BS.Current!POProductID))
                CnnOpen() : Dim Verify As Integer = Val(CMD.ExecuteScalar & "") : CnnClose()
                If Verify <> 0 Then
                    XtraMessageBox.Show("Value Exist! Enter Unique Value.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ProductNameTextEdit.Focus()
                    e.Cancel = True
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub HSNNoOrSACNoTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles HSNNoOrSACNoTextEdit.Validating
        Dim iNumber As Integer
        If Not Integer.TryParse(HSNNoOrSACNoTextEdit.Text, iNumber) Then
            XtraMessageBox.Show("Not a Number! Please enter only Numerical Values.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'HSNNoOrSACNoTextEdit.Focus()
            'e.Cancel = True
        End If
    End Sub

    Private Sub CategoryIDLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles CategoryIDLookUpEdit.EditValueChanged
        Try
            If (CategoryIDLookUpEdit.EditValue IsNot DBNull.Value) Then
                SetLookUp("Select SubCategoryID,SubCategoryName From SubCategory Where CategoryID = " + CategoryIDLookUpEdit.EditValue.ToString + "", "SubCategory", "SubCategoryID", "SubCategoryName", SubCategoryIDLookUpEdit, "Sub Category")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AddNewSimpleButton_Click(sender As Object, e As EventArgs) Handles AddNewSimpleButton.Click
        Frm_AddSubCategory.StartPosition = FormStartPosition.CenterParent
        Frm_AddSubCategory.ShowDialog()
        If Frm_AddSubCategory.DialogResult = DialogResult.OK Then
            InitLookup()
            Frm_AddSubCategory.Close()
        Else
            Frm_AddSubCategory.Close()
        End If
    End Sub
End Class