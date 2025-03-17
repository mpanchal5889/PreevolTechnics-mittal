﻿Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
'Imports ELCF
Public Class Frm_SelectBank

    Dim Invoice As String
    Dim Val As Integer
    Dim ChkIGST As Boolean
    Dim InvoiceType As String
    Dim ChkDis As Boolean

    Public Sub New(ByVal InvoiceID As String, ByVal Flag As Integer, ByVal isIGST As Boolean, ByVal type As String, ByVal isDis As Boolean)
        InitializeComponent()
        Invoice = InvoiceID
        Val = Flag
        ChkIGST = isIGST
        InvoiceType = type
        ChkDis = isDis
    End Sub

    Private Sub FrmSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitLookup()
        Bank1IDLookUpEdit.Focus()
        PanelCtrlMain.Dock = DockStyle.Fill
        themes(PanelCtrl)
    End Sub
    Sub InitLookup()
        SetLookUp("SELECT BankID,BankName FROM Bank", "Bank", "BankID", "BankName", Bank1IDLookUpEdit, "Bank")
    End Sub
    Function Validation() As Boolean
        If Bank1IDLookUpEdit.EditValue Is Nothing Then
            Bank1IDLookUpEdit.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles OkSimpleButton.Click
        If Validation() Then
            Dim DA As New OleDbDataAdapter
            Dim DT As New DataTable

            DA.SelectCommand = New OleDbCommand("Select BankID,CompanyID,BankName,BranchName,AccountNo,MICRCode,IFSCCode,SwiftCode From Bank Where BankID=" + Bank1IDLookUpEdit.EditValue.ToString, ConStr)
            DA.Fill(DT)

            Dim DACompany As New OleDbDataAdapter
            Dim DTCompany As New DataTable

            DACompany.SelectCommand = New OleDbCommand("Select CompanyID,Name,Address,Phone1,State,StateCode,EmailID1,Website,GSTIN,PANNo,SupplyFrom,ISOText From Company Where Name='" + PubCompanyName + "'", ConStr)
            DACompany.Fill(DTCompany)

            Me.Close()

            If ChkIGST = False Then
                If InvoiceType = "Sales Invoice" Then
                    If ChkDis = True Then
                        If Val = 1 Then
                            Dim Rpt As New XR_Invoice
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            'Dim newString As String = origString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()

                        ElseIf Val = 2 Then
                            Dim Rpt As New XR_Invoice
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel77.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 3 Then
                            Dim Rpt As New XR_Invoice
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 7 Then
                            Dim Rpt As New XR_Invoice
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            'Dim newString As String = origString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True



                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 8 Then
                            Dim Rpt As New XR_Invoice
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        End If
                    Else
                        If Val = 1 Then
                            Dim Rpt As New XR_InvoiceWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            'Dim newString As String = origString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()

                        ElseIf Val = 2 Then
                            Dim Rpt As New XR_InvoiceWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel77.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 3 Then
                            Dim Rpt As New XR_InvoiceWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 7 Then
                            Dim Rpt As New XR_InvoiceWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            'Dim newString As String = origString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True



                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 8 Then
                            Dim Rpt As New XR_InvoiceWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        End If
                    End If
                ElseIf InvoiceType = "Service Invoice" Then
                    If ChkDis = True Then
                        If Val = 4 Then
                            Dim Rpt As New XR_ServiceInvoice
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 5 Then
                            Dim Rpt As New XR_ServiceInvoice
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel77.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 6 Then
                            Dim Rpt As New XR_ServiceInvoice
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 9 Then
                            Dim Rpt As New XR_ServiceInvoice
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 10 Then
                            Dim Rpt As New XR_ServiceInvoice
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        End If
                    Else
                        If Val = 4 Then
                            Dim Rpt As New XR_ServiceInvoiceWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 5 Then
                            Dim Rpt As New XR_ServiceInvoiceWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel77.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 6 Then
                            Dim Rpt As New XR_ServiceInvoiceWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 9 Then
                            Dim Rpt As New XR_ServiceInvoiceWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 10 Then
                            Dim Rpt As New XR_ServiceInvoiceWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel40.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        End If
                    End If
                End If
            ElseIf ChkIGST = True Then
                If InvoiceType = "SEZ Sales Invoice IGST" Then
                    If PubWithLUT Then
                        If ChkDis = True Then
                            If Val = 1 Then
                                Dim Rpt As New XR_SEZSalesWithLUT
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel148.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel146.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 2 Then
                                Dim Rpt As New XR_SEZSalesWithLUT
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel77.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel148.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel146.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 3 Then
                                Dim Rpt As New XR_SEZSalesWithLUT
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel148.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel146.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 7 Then
                                Dim Rpt As New XR_SEZSalesWithLUT
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel148.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel146.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True
                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 8 Then
                                Dim Rpt As New XR_SEZSalesWithLUT
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel148.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel146.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            End If
                        Else
                            If Val = 1 Then
                                Dim Rpt As New XR_SEZSalesWithLUTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel148.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel146.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 2 Then
                                Dim Rpt As New XR_SEZSalesWithLUTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel77.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel148.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel146.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 3 Then
                                Dim Rpt As New XR_SEZSalesWithLUTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel148.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel146.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 7 Then
                                Dim Rpt As New XR_SEZSalesWithLUTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel148.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel146.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True
                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 8 Then
                                Dim Rpt As New XR_SEZSalesWithLUTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel148.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel146.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            End If
                        End If
                    Else
                        If ChkDis = True Then
                            If Val = 1 Then
                                Dim Rpt As New XR_SEZSalesIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString

                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 2 Then
                                Dim Rpt As New XR_SEZSalesIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel77.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 3 Then
                                Dim Rpt As New XR_SEZSalesIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 7 Then
                                Dim Rpt As New XR_SEZSalesIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString

                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 8 Then
                                Dim Rpt As New XR_SEZSalesIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            End If
                        Else
                            If Val = 1 Then
                                Dim Rpt As New XR_SEZSalesIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString

                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 2 Then
                                Dim Rpt As New XR_SEZSalesIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel77.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 3 Then
                                Dim Rpt As New XR_SEZSalesIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 7 Then
                                Dim Rpt As New XR_SEZSalesIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString

                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 8 Then
                                Dim Rpt As New XR_SEZSalesIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            End If
                        End If
                    End If
                ElseIf InvoiceType = "Export Sales Invoice IGST" Then
                    If PubWithLUT Then
                        If ChkDis = True Then
                            If Val = 1 Then
                                Dim Rpt As New XR_ExportSalesIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 2 Then
                                Dim Rpt As New XR_ExportSalesIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel77.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 3 Then
                                Dim Rpt As New XR_ExportSalesIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 7 Then
                                Dim Rpt As New XR_ExportSalesIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True


                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 8 Then
                                Dim Rpt As New XR_ExportSalesIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            End If
                        Else
                            If Val = 1 Then
                                Dim Rpt As New XR_ExportSalesIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 2 Then
                                Dim Rpt As New XR_ExportSalesIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel77.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 3 Then
                                Dim Rpt As New XR_ExportSalesIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 7 Then
                                Dim Rpt As New XR_ExportSalesIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True


                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 8 Then
                                Dim Rpt As New XR_ExportSalesIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            End If
                        End If
                    Else
                    End If
                ElseIf InvoiceType = "SEZ Service Invoice IGST" Then
                    If PubWithLUT Then
                        If ChkDis = True Then
                            If Val = 4 Then
                                Dim Rpt As New XR_SEZServiceWithLUT
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 5 Then
                                Dim Rpt As New XR_SEZServiceWithLUT
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel77.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 6 Then
                                Dim Rpt As New XR_SEZServiceWithLUT
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 9 Then
                                Dim Rpt As New XR_SEZServiceWithLUT
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 10 Then
                                Dim Rpt As New XR_SEZServiceWithLUT
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            End If
                        Else
                            If Val = 4 Then
                                Dim Rpt As New XR_SEZServiceWithLUTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 5 Then
                                Dim Rpt As New XR_SEZServiceWithLUTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel77.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 6 Then
                                Dim Rpt As New XR_SEZServiceWithLUTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 9 Then
                                Dim Rpt As New XR_SEZServiceWithLUTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 10 Then
                                Dim Rpt As New XR_SEZServiceWithLUTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            End If
                        End If
                    Else
                        If ChkDis = True Then
                            If Val = 4 Then
                                Dim Rpt As New XR_SEZService
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 5 Then
                                Dim Rpt As New XR_SEZService
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel77.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 6 Then
                                Dim Rpt As New XR_SEZService
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 9 Then
                                Dim Rpt As New XR_SEZService
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 10 Then
                                Dim Rpt As New XR_SEZService
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            End If
                        Else
                            If Val = 4 Then
                                Dim Rpt As New XR_SEZServiceWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 5 Then
                                Dim Rpt As New XR_SEZServiceWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel77.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 6 Then
                                Dim Rpt As New XR_SEZServiceWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 9 Then
                                Dim Rpt As New XR_SEZServiceWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 10 Then
                                Dim Rpt As New XR_SEZServiceWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            End If
                        End If
                    End If
                ElseIf InvoiceType = "Export Service Invoice IGST" Then
                    If PubWithLUT Then
                        If ChkDis = True Then
                            If Val = 4 Then
                                Dim Rpt As New XR_ExportServiceIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 5 Then
                                Dim Rpt As New XR_ExportServiceIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel77.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 6 Then
                                Dim Rpt As New XR_ExportServiceIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 9 Then
                                Dim Rpt As New XR_ExportServiceIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 10 Then
                                Dim Rpt As New XR_ExportServiceIGST
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            End If
                        Else
                            If Val = 4 Then
                                Dim Rpt As New XR_ExportServiceIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 5 Then
                                Dim Rpt As New XR_ExportServiceIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel77.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 6 Then
                                Dim Rpt As New XR_ExportServiceIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 9 Then
                                Dim Rpt As New XR_ExportServiceIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel76.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            ElseIf Val = 10 Then
                                Dim Rpt As New XR_ExportServiceIGSTWithoutDis
                                Rpt.Invoice.Value = Invoice
                                Rpt.Invoice.Visible = False
                                Rpt.FillDataSource()
                                Rpt.XrLabel78.Text = "✔"
                                'Company Info----
                                'If InvoiceType = "Export Sales Invoice IGST" Then
                                '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                                'End If
                                Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                                Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                                Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                                Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                                Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                                Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                                Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                                Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                                Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                                Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                                'Bank Info----
                                Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                                Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                                Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                                Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                                Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                                Rpt.XrPictureBox2.Visible = True

                                Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                                ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                                End_Waiting()

                                Rpt.ShowRibbonPreviewDialog()
                            End If
                        End If
                    Else
                    End If
                ElseIf InvoiceType = "Sales Invoice IGST" Then
                    If ChkDis = True Then
                        If Val = 1 Then
                            Dim Rpt As New XR_InvoiceIGST
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 2 Then
                            Dim Rpt As New XR_InvoiceIGST
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel77.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 3 Then
                            Dim Rpt As New XR_InvoiceIGST
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()

                        ElseIf Val = 7 Then
                            Dim Rpt As New XR_InvoiceIGST
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 8 Then
                            Dim Rpt As New XR_InvoiceIGST
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        End If
                    Else
                        If Val = 1 Then
                            Dim Rpt As New XR_InvoiceIGSTWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 2 Then
                            Dim Rpt As New XR_InvoiceIGSTWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel77.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 3 Then
                            Dim Rpt As New XR_InvoiceIGSTWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()

                        ElseIf Val = 7 Then
                            Dim Rpt As New XR_InvoiceIGSTWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 8 Then
                            Dim Rpt As New XR_InvoiceIGSTWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel16.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel28.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        End If
                    End If
                ElseIf InvoiceType = "Service Invoice IGST" Then
                    If ChkDis = True Then
                        If Val = 4 Then
                            Dim Rpt As New XR_ServiceInvoiceIGST
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 5 Then
                            Dim Rpt As New XR_ServiceInvoiceIGST
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel77.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 6 Then
                            Dim Rpt As New XR_ServiceInvoiceIGST
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 9 Then
                            Dim Rpt As New XR_ServiceInvoiceIGST
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 10 Then
                            Dim Rpt As New XR_ServiceInvoiceIGST
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        End If
                    Else
                        If Val = 4 Then
                            Dim Rpt As New XR_ServiceInvoiceIGSTWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 5 Then
                            Dim Rpt As New XR_ServiceInvoiceIGSTWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel77.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 6 Then
                            Dim Rpt As New XR_ServiceInvoiceIGSTWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 9 Then
                            Dim Rpt As New XR_ServiceInvoiceIGSTWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel76.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        ElseIf Val = 10 Then
                            Dim Rpt As New XR_ServiceInvoiceIGSTWithoutDis
                            Rpt.Invoice.Value = Invoice
                            Rpt.Invoice.Visible = False
                            Rpt.FillDataSource()
                            Rpt.XrLabel78.Text = "✔"
                            'Company Info----
                            'If InvoiceType = "Export Sales Invoice IGST" Then
                            '    Rpt.XrLabel8.Text = "(We can prepare the invoice as if it is export. We need to file RFD -11 along with bond/LTU)"
                            'End If
                            Rpt.XrLabel59.Text = DTCompany.Rows(0).Item("Name").ToString
                            Rpt.XrLabel9.Text = DTCompany.Rows(0).Item("Address").ToString.Replace(vbCr, "").Replace(vbLf, "")
                            Rpt.XrLabel29.Text = "(P) " + DTCompany.Rows(0).Item("Phone1").ToString + "     Mail Id: " + DTCompany.Rows(0).Item("EmailID1").ToString
                            Rpt.XrLabel91.Text = "Website: " + DTCompany.Rows(0).Item("Website").ToString
                            Rpt.XrLabel18.Text = DTCompany.Rows(0).Item("GSTIN").ToString
                            Rpt.XrLabel90.Text = DTCompany.Rows(0).Item("PANNo").ToString
                            Rpt.XrLabel6.Text = DTCompany.Rows(0).Item("State").ToString
                            Rpt.XrLabel11.Text = DTCompany.Rows(0).Item("StateCode").ToString
                            Rpt.XrLabel47.Text = DTCompany.Rows(0).Item("SupplyFrom").ToString
                            Rpt.XrLabelISO.Text = DTCompany.Rows(0).Item("ISOText").ToString
                            'Bank Info----
                            Rpt.XrLabel138.Text = DT.Rows(0).Item("BankName").ToString
                            Rpt.XrLabel139.Text = DT.Rows(0).Item("BranchName").ToString
                            Rpt.XrLabel143.Text = DT.Rows(0).Item("AccountNo").ToString
                            Rpt.XrLabel140.Text = DT.Rows(0).Item("MICRCode").ToString
                            Rpt.XrLabel141.Text = DT.Rows(0).Item("IFSCCode").ToString
                            Rpt.XrPictureBox2.Visible = True

                            Dim ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Rpt)
                            ReportPrintTool.PreviewRibbonForm.Text = String.Format("- Invoice -")
                            End_Waiting()

                            Rpt.ShowRibbonPreviewDialog()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Me.Close()
    End Sub
End Class