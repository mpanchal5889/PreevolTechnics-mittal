﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XR_ProformaSEZServiceWithLUT
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XR_ProformaSEZServiceWithLUT))
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.XrCrossBandLine1 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Invoice = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalGSTCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PackingChargeCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TaxableValLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TaxableValueCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.RoundOffCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GrandTotalLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GrandTotalCell = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel162 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel163 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel164 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TaxableValueLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel166 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel167 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel168 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel157 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel158 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel159 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel160 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel161 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel115 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel129 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel138 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel139 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel133 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel150 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel143 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel140 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel153 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel141 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel155 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel156 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel107 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel110 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel111 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel106 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel104 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel87 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel88 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel102 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel103 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCrossBandLine4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.DS_ProformaServiceInvoice1 = New PreevolTechnics.DS_ProformaServiceInvoice()
        Me.DT_ProformaServiceTableAdapter = New PreevolTechnics.DS_ProformaServiceInvoiceTableAdapters.DT_ProformaServiceTableAdapter()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel92 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel85 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel84 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel83 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel82 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel81 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel80 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel79 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel63 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel64 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel69 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel71 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel72 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel73 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel74 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel75 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel93 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel120 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel121 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel126 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel127 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel91 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel90 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel89 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel123 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel122 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCrossBandLine2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.XrCrossBandLine3 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ProformaServiceInvoice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseBorders = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1})
        Me.TopMargin.HeightF = 48.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 45.70834!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(777.6944!, 2.083336!)
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'XrCrossBandLine1
        '
        Me.XrCrossBandLine1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine1.EndBand = Nothing
        Me.XrCrossBandLine1.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrCrossBandLine1.Name = "XrCrossBandLine1"
        Me.XrCrossBandLine1.StartBand = Nothing
        Me.XrCrossBandLine1.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrCrossBandLine1.WidthF = 9.375!
        '
        'Invoice
        '
        Me.Invoice.Description = "Invoice"
        Me.Invoice.Name = "Invoice"
        Me.Invoice.Type = GetType(Integer)
        Me.Invoice.ValueInfo = "0"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.Expanded = False
        Me.PageFooter.HeightF = 23.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(677.7236!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16, Me.XrTable4, Me.XrPictureBox2, Me.XrTable1, Me.XrTable3, Me.XrLabel162, Me.XrLabel163, Me.XrLabel164, Me.TaxableValueLabel, Me.XrLabel166, Me.XrLabel167, Me.XrLabel168, Me.XrLabel157, Me.XrLabel158, Me.XrLabel159, Me.XrLabel160, Me.XrLabel161, Me.XrLabel115, Me.XrLabel129, Me.XrLabel138, Me.XrLabel139, Me.XrLabel133, Me.XrLabel150, Me.XrLabel143, Me.XrLabel140, Me.XrLabel153, Me.XrLabel141, Me.XrLabel155, Me.XrLabel156, Me.XrLabel107, Me.XrLabel110, Me.XrLabel111, Me.XrLabel106, Me.XrLabel104, Me.XrLabel87, Me.XrLabel88, Me.XrLabel102, Me.XrLabel103})
        Me.GroupFooter2.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.GroupFooter2.HeightF = 379.0933!
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.StylePriority.UseBorders = False
        Me.GroupFooter2.StylePriority.UseFont = False
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel16.CanGrow = False
        Me.XrLabel16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DiscountVal])")})
        Me.XrLabel16.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(486.0437!, 4.999955!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(49.50494!, 17.56259!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel16.Summary = XrSummary1
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel16.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrTable4
        '
        Me.XrTable4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0.3695679!, 0.00003480911!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(777.7729!, 5.0!)
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell23, Me.XrTableCell7, Me.XrTableCell10, Me.XrTableCell12, Me.XrTableCell26, Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell34, Me.XrTableCell30, Me.XrTableCell31, Me.XrTableCell32, Me.XrTableCell33})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.23688934326172R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell23.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell23.StylePriority.UseBorders = False
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.StylePriority.UsePadding = False
        Me.XrTableCell23.Weight = 1.091993196023952R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell7.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UsePadding = False
        Me.XrTableCell7.Weight = 6.1879615873167078R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell10.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UsePadding = False
        Me.XrTableCell10.Weight = 1.8240767502195923R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell12.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.Weight = 1.0919893026283909R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell26.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell26.StylePriority.UseBorders = False
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.StylePriority.UsePadding = False
        Me.XrTableCell26.Weight = 1.9173259478370373R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell27.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell27.StylePriority.UseBorders = False
        Me.XrTableCell27.StylePriority.UseFont = False
        Me.XrTableCell27.StylePriority.UsePadding = False
        Me.XrTableCell27.Weight = 2.1741376513411512R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell28.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell28.StylePriority.UseBorders = False
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.StylePriority.UsePadding = False
        Me.XrTableCell28.Weight = 2.1533473304354978R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell29.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell29.StylePriority.UseBorders = False
        Me.XrTableCell29.StylePriority.UseFont = False
        Me.XrTableCell29.StylePriority.UsePadding = False
        Me.XrTableCell29.Weight = 1.2375945067727945R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell34.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell34.Multiline = True
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell34.StylePriority.UseBorders = False
        Me.XrTableCell34.StylePriority.UseFont = False
        Me.XrTableCell34.StylePriority.UsePadding = False
        Me.XrTableCell34.Weight = 1.8019698188698197R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell30.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell30.StylePriority.UseBorders = False
        Me.XrTableCell30.StylePriority.UseFont = False
        Me.XrTableCell30.StylePriority.UsePadding = False
        Me.XrTableCell30.Weight = 1.8744082982539223R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell31.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell31.StylePriority.UseBorders = False
        Me.XrTableCell31.StylePriority.UseFont = False
        Me.XrTableCell31.StylePriority.UsePadding = False
        Me.XrTableCell31.Weight = 0.94638962255800807R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell32.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell32.StylePriority.UseBorders = False
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.StylePriority.UsePadding = False
        Me.XrTableCell32.Weight = 2.7335819445522209R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell33.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100.0!)
        Me.XrTableCell33.StylePriority.UseBorders = False
        Me.XrTableCell33.StylePriority.UseFont = False
        Me.XrTableCell33.StylePriority.UsePadding = False
        Me.XrTableCell33.Weight = 3.2759799413026491R
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox2.ImageSource"))
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(614.17!, 283.99!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(63.66998!, 63.11002!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox2.StylePriority.UseBorders = False
        Me.XrPictureBox2.Visible = False
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.2113024!, 22.56266!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(299.9999!, 47.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UsePadding = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.Text = "Taxable Value"
        Me.XrTableCell1.Weight = 0.999999999999995R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.Text = "IGST Rate"
        Me.XrTableCell2.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.Text = "IGST Amt"
        Me.XrTableCell3.Weight = 0.99349163418240516R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.Weight = 0.99349163418240516R
        '
        'XrTable3
        '
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(300.2112!, 22.56273!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7, Me.XrTableRow8, Me.XrTableRow9, Me.XrTableRow10})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(478.0003!, 100.0!)
        Me.XrTable3.StylePriority.UsePadding = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.XrTableCell9, Me.TotalGSTCell})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = " Packing / Courier"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell8.Weight = 1.7710110473632772R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.Text = "Total GST"
        Me.XrTableCell9.Weight = 1.3600012207031216R
        '
        'TotalGSTCell
        '
        Me.TotalGSTCell.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TotalGSTCell.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.TotalGSTTax]")})
        Me.TotalGSTCell.Name = "TotalGSTCell"
        Me.TotalGSTCell.StylePriority.UseBorders = False
        Me.TotalGSTCell.StylePriority.UseTextAlignment = False
        Me.TotalGSTCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TotalGSTCell.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        Me.TotalGSTCell.Weight = 1.6489907836914113R
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.PackingChargeCell, Me.TaxableValLabel, Me.TaxableValueCell})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseBorders = False
        Me.XrTableCell11.Text = "Amount"
        Me.XrTableCell11.Weight = 0.714490051269531R
        '
        'PackingChargeCell
        '
        Me.PackingChargeCell.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.PackingCharge]")})
        Me.PackingChargeCell.Name = "PackingChargeCell"
        Me.PackingChargeCell.StylePriority.UseTextAlignment = False
        Me.PackingChargeCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.PackingChargeCell.TextFormatString = "{0:f}"
        Me.PackingChargeCell.Weight = 1.05652099609375R
        '
        'TaxableValLabel
        '
        Me.TaxableValLabel.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TaxableValLabel.Name = "TaxableValLabel"
        Me.TaxableValLabel.StylePriority.UseBorders = False
        Me.TaxableValLabel.Text = "Taxable Value"
        Me.TaxableValLabel.Weight = 1.360001220703128R
        '
        'TaxableValueCell
        '
        Me.TaxableValueCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TaxableValueCell.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.TotalAmtAfterTax]")})
        Me.TaxableValueCell.Name = "TaxableValueCell"
        Me.TaxableValueCell.StylePriority.UseBorders = False
        Me.TaxableValueCell.StylePriority.UseTextAlignment = False
        Me.TaxableValueCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TaxableValueCell.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        Me.TaxableValueCell.Weight = 1.6489907836914139R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell20, Me.XrTableCell21, Me.XrTableCell22, Me.RoundOffCell})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.0R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.PIGSTRate]")})
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseBorders = False
        Me.XrTableCell20.TextFormatString = "(IGST {0}%)"
        Me.XrTableCell20.Weight = 0.714490051269531R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.PIGSTAmt]")})
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell21.TextFormatString = "{0:f}"
        Me.XrTableCell21.Weight = 1.0565209960937505R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseBorders = False
        Me.XrTableCell22.Text = "Round Off"
        Me.XrTableCell22.Weight = 1.3600024414062513R
        '
        'RoundOffCell
        '
        Me.RoundOffCell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.RoundOffCell.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.RoundOff]")})
        Me.RoundOffCell.Name = "RoundOffCell"
        Me.RoundOffCell.StylePriority.UseBorders = False
        Me.RoundOffCell.StylePriority.UseTextAlignment = False
        Me.RoundOffCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.RoundOffCell.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        Me.RoundOffCell.Weight = 1.6489895629882811R
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell24, Me.XrTableCell25, Me.GrandTotalLabel, Me.GrandTotalCell})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 1.0R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseBorders = False
        Me.XrTableCell24.Weight = 0.714490051269531R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseBorders = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell25.Weight = 1.0565209960937505R
        '
        'GrandTotalLabel
        '
        Me.GrandTotalLabel.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.GrandTotalLabel.Name = "GrandTotalLabel"
        Me.GrandTotalLabel.StylePriority.UseBorders = False
        Me.GrandTotalLabel.Text = "Total Taxable Value "
        Me.GrandTotalLabel.Weight = 1.3600024414062513R
        '
        'GrandTotalCell
        '
        Me.GrandTotalCell.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.GrandTotalCell.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.GrandTotalAmount]")})
        Me.GrandTotalCell.Name = "GrandTotalCell"
        Me.GrandTotalCell.StylePriority.UseBorders = False
        Me.GrandTotalCell.StylePriority.UseTextAlignment = False
        Me.GrandTotalCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.GrandTotalCell.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        Me.GrandTotalCell.Weight = 1.6489895629882811R
        '
        'XrLabel162
        '
        Me.XrLabel162.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel162.CanGrow = False
        Me.XrLabel162.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel162.LocationFloat = New DevExpress.Utils.PointFloat(0.2111726!, 4.999955!)
        Me.XrLabel162.Multiline = True
        Me.XrLabel162.Name = "XrLabel162"
        Me.XrLabel162.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel162.SizeF = New System.Drawing.SizeF(280.2706!, 17.56264!)
        Me.XrLabel162.StylePriority.UseBorders = False
        Me.XrLabel162.StylePriority.UseFont = False
        Me.XrLabel162.StylePriority.UseTextAlignment = False
        Me.XrLabel162.Text = "Total"
        Me.XrLabel162.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel163
        '
        Me.XrLabel163.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel163.CanGrow = False
        Me.XrLabel163.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DT_Invoice.Qty])")})
        Me.XrLabel163.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel163.LocationFloat = New DevExpress.Utils.PointFloat(280.4818!, 4.999955!)
        Me.XrLabel163.Multiline = True
        Me.XrLabel163.Name = "XrLabel163"
        Me.XrLabel163.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel163.SizeF = New System.Drawing.SizeF(52.67413!, 17.56259!)
        Me.XrLabel163.StylePriority.UseBorders = False
        Me.XrLabel163.StylePriority.UseFont = False
        Me.XrLabel163.StylePriority.UseTextAlignment = False
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel163.Summary = XrSummary2
        Me.XrLabel163.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel163.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel164
        '
        Me.XrLabel164.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel164.CanGrow = False
        Me.XrLabel164.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel164.LocationFloat = New DevExpress.Utils.PointFloat(333.1559!, 4.999955!)
        Me.XrLabel164.Multiline = True
        Me.XrLabel164.Name = "XrLabel164"
        Me.XrLabel164.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel164.SizeF = New System.Drawing.SizeF(152.8878!, 17.56264!)
        Me.XrLabel164.StylePriority.UseBorders = False
        Me.XrLabel164.StylePriority.UseFont = False
        Me.XrLabel164.StylePriority.UseTextAlignment = False
        Me.XrLabel164.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TaxableValueLabel
        '
        Me.TaxableValueLabel.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.TaxableValueLabel.CanGrow = False
        Me.TaxableValueLabel.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DT_Invoice.TaxableValue])")})
        Me.TaxableValueLabel.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.TaxableValueLabel.LocationFloat = New DevExpress.Utils.PointFloat(535.5487!, 4.999966!)
        Me.TaxableValueLabel.Multiline = True
        Me.TaxableValueLabel.Name = "TaxableValueLabel"
        Me.TaxableValueLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TaxableValueLabel.SizeF = New System.Drawing.SizeF(51.495!, 17.56259!)
        Me.TaxableValueLabel.StylePriority.UseBorders = False
        Me.TaxableValueLabel.StylePriority.UseFont = False
        Me.TaxableValueLabel.StylePriority.UseTextAlignment = False
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.TaxableValueLabel.Summary = XrSummary3
        Me.TaxableValueLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.TaxableValueLabel.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel166
        '
        Me.XrLabel166.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel166.CanGrow = False
        Me.XrLabel166.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel166.LocationFloat = New DevExpress.Utils.PointFloat(587.0437!, 5.000051!)
        Me.XrLabel166.Multiline = True
        Me.XrLabel166.Name = "XrLabel166"
        Me.XrLabel166.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel166.SizeF = New System.Drawing.SizeF(26.26868!, 17.56264!)
        Me.XrLabel166.StylePriority.UseBorders = False
        Me.XrLabel166.StylePriority.UseFont = False
        Me.XrLabel166.StylePriority.UseTextAlignment = False
        Me.XrLabel166.Text = "-"
        Me.XrLabel166.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel167
        '
        Me.XrLabel167.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel167.CanGrow = False
        Me.XrLabel167.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DT_Invoice.IGSTAmt])")})
        Me.XrLabel167.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel167.LocationFloat = New DevExpress.Utils.PointFloat(613.3124!, 5.000051!)
        Me.XrLabel167.Multiline = True
        Me.XrLabel167.Name = "XrLabel167"
        Me.XrLabel167.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel167.SizeF = New System.Drawing.SizeF(74.83008!, 17.56264!)
        Me.XrLabel167.StylePriority.UseBorders = False
        Me.XrLabel167.StylePriority.UseFont = False
        Me.XrLabel167.StylePriority.UseTextAlignment = False
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel167.Summary = XrSummary4
        Me.XrLabel167.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel167.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel168
        '
        Me.XrLabel168.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel168.CanGrow = False
        Me.XrLabel168.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DT_Invoice.TaxableValue])")})
        Me.XrLabel168.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel168.LocationFloat = New DevExpress.Utils.PointFloat(688.1425!, 5.000093!)
        Me.XrLabel168.Multiline = True
        Me.XrLabel168.Name = "XrLabel168"
        Me.XrLabel168.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel168.SizeF = New System.Drawing.SizeF(90.22711!, 17.56264!)
        Me.XrLabel168.StylePriority.UseBorders = False
        Me.XrLabel168.StylePriority.UseFont = False
        Me.XrLabel168.StylePriority.UseTextAlignment = False
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel168.Summary = XrSummary5
        Me.XrLabel168.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel168.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel157
        '
        Me.XrLabel157.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel157.CanGrow = False
        Me.XrLabel157.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, CType((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Underline), DevExpress.Drawing.DXFontStyle))
        Me.XrLabel157.LocationFloat = New DevExpress.Utils.PointFloat(0.2111753!, 263.8769!)
        Me.XrLabel157.Multiline = True
        Me.XrLabel157.Name = "XrLabel157"
        Me.XrLabel157.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel157.SizeF = New System.Drawing.SizeF(515.662!, 16.91849!)
        Me.XrLabel157.StylePriority.UseBorders = False
        Me.XrLabel157.StylePriority.UseFont = False
        Me.XrLabel157.StylePriority.UseTextAlignment = False
        Me.XrLabel157.Text = "TERMS & CONDITIONS :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel157.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel158
        '
        Me.XrLabel158.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel158.CanGrow = False
        Me.XrLabel158.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.XrLabel158.LocationFloat = New DevExpress.Utils.PointFloat(515.8729!, 280.9387!)
        Me.XrLabel158.Multiline = True
        Me.XrLabel158.Name = "XrLabel158"
        Me.XrLabel158.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel158.SizeF = New System.Drawing.SizeF(262.4966!, 67.88641!)
        Me.XrLabel158.StylePriority.UseBorders = False
        Me.XrLabel158.StylePriority.UseFont = False
        Me.XrLabel158.StylePriority.UseTextAlignment = False
        Me.XrLabel158.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel159
        '
        Me.XrLabel159.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel159.CanGrow = False
        Me.XrLabel159.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel159.LocationFloat = New DevExpress.Utils.PointFloat(515.8729!, 264.0201!)
        Me.XrLabel159.Multiline = True
        Me.XrLabel159.Name = "XrLabel159"
        Me.XrLabel159.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel159.SizeF = New System.Drawing.SizeF(262.3383!, 16.9185!)
        Me.XrLabel159.StylePriority.UseBorders = False
        Me.XrLabel159.StylePriority.UseFont = False
        Me.XrLabel159.StylePriority.UseTextAlignment = False
        Me.XrLabel159.Text = "FOR PREEVOL TECHNICS,"
        Me.XrLabel159.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel160
        '
        Me.XrLabel160.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel160.CanGrow = False
        Me.XrLabel160.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!)
        Me.XrLabel160.LocationFloat = New DevExpress.Utils.PointFloat(0.2111753!, 280.7953!)
        Me.XrLabel160.Multiline = True
        Me.XrLabel160.Name = "XrLabel160"
        Me.XrLabel160.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100.0!)
        Me.XrLabel160.SizeF = New System.Drawing.SizeF(515.6619!, 86.63643!)
        Me.XrLabel160.StylePriority.UseBorders = False
        Me.XrLabel160.StylePriority.UseFont = False
        Me.XrLabel160.StylePriority.UsePadding = False
        Me.XrLabel160.StylePriority.UseTextAlignment = False
        Me.XrLabel160.Text = resources.GetString("XrLabel160.Text")
        Me.XrLabel160.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel161
        '
        Me.XrLabel161.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel161.CanGrow = False
        Me.XrLabel161.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!)
        Me.XrLabel161.LocationFloat = New DevExpress.Utils.PointFloat(515.8729!, 348.8251!)
        Me.XrLabel161.Multiline = True
        Me.XrLabel161.Name = "XrLabel161"
        Me.XrLabel161.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel161.SizeF = New System.Drawing.SizeF(262.3383!, 18.60663!)
        Me.XrLabel161.StylePriority.UseBorders = False
        Me.XrLabel161.StylePriority.UseFont = False
        Me.XrLabel161.StylePriority.UseTextAlignment = False
        Me.XrLabel161.Text = "(Authorised Signatory)"
        Me.XrLabel161.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel115
        '
        Me.XrLabel115.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel115.CanGrow = False
        Me.XrLabel115.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel115.LocationFloat = New DevExpress.Utils.PointFloat(0.2111734!, 209.7338!)
        Me.XrLabel115.Multiline = True
        Me.XrLabel115.Name = "XrLabel115"
        Me.XrLabel115.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel115.SizeF = New System.Drawing.SizeF(100.0!, 18.0!)
        Me.XrLabel115.StylePriority.UseBorders = False
        Me.XrLabel115.StylePriority.UseFont = False
        Me.XrLabel115.StylePriority.UseTextAlignment = False
        Me.XrLabel115.Text = "BANK NAME      :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel129
        '
        Me.XrLabel129.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel129.CanGrow = False
        Me.XrLabel129.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel129.LocationFloat = New DevExpress.Utils.PointFloat(0.2111753!, 227.7339!)
        Me.XrLabel129.Multiline = True
        Me.XrLabel129.Name = "XrLabel129"
        Me.XrLabel129.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel129.SizeF = New System.Drawing.SizeF(100.0!, 18.0!)
        Me.XrLabel129.StylePriority.UseBorders = False
        Me.XrLabel129.StylePriority.UseFont = False
        Me.XrLabel129.StylePriority.UseTextAlignment = False
        Me.XrLabel129.Text = "BRANCH NAME :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel129.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel138
        '
        Me.XrLabel138.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel138.CanGrow = False
        Me.XrLabel138.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel138.LocationFloat = New DevExpress.Utils.PointFloat(100.2112!, 209.7338!)
        Me.XrLabel138.Multiline = True
        Me.XrLabel138.Name = "XrLabel138"
        Me.XrLabel138.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel138.SizeF = New System.Drawing.SizeF(177.681!, 17.99998!)
        Me.XrLabel138.StylePriority.UseBorders = False
        Me.XrLabel138.StylePriority.UseFont = False
        Me.XrLabel138.StylePriority.UseTextAlignment = False
        Me.XrLabel138.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel139
        '
        Me.XrLabel139.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel139.CanGrow = False
        Me.XrLabel139.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel139.LocationFloat = New DevExpress.Utils.PointFloat(100.2112!, 227.734!)
        Me.XrLabel139.Multiline = True
        Me.XrLabel139.Name = "XrLabel139"
        Me.XrLabel139.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel139.SizeF = New System.Drawing.SizeF(177.6886!, 17.99997!)
        Me.XrLabel139.StylePriority.UseBorders = False
        Me.XrLabel139.StylePriority.UseFont = False
        Me.XrLabel139.StylePriority.UseTextAlignment = False
        Me.XrLabel139.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel133
        '
        Me.XrLabel133.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel133.CanGrow = False
        Me.XrLabel133.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel133.LocationFloat = New DevExpress.Utils.PointFloat(277.8998!, 209.877!)
        Me.XrLabel133.Multiline = True
        Me.XrLabel133.Name = "XrLabel133"
        Me.XrLabel133.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel133.SizeF = New System.Drawing.SizeF(90.0!, 17.99994!)
        Me.XrLabel133.StylePriority.UseBorders = False
        Me.XrLabel133.StylePriority.UseFont = False
        Me.XrLabel133.StylePriority.UseTextAlignment = False
        Me.XrLabel133.Text = "ACCOUNT NO :"
        Me.XrLabel133.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel150
        '
        Me.XrLabel150.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel150.CanGrow = False
        Me.XrLabel150.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel150.LocationFloat = New DevExpress.Utils.PointFloat(277.8998!, 227.877!)
        Me.XrLabel150.Multiline = True
        Me.XrLabel150.Name = "XrLabel150"
        Me.XrLabel150.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel150.SizeF = New System.Drawing.SizeF(90.0!, 17.85692!)
        Me.XrLabel150.StylePriority.UseBorders = False
        Me.XrLabel150.StylePriority.UseFont = False
        Me.XrLabel150.StylePriority.UseTextAlignment = False
        Me.XrLabel150.Text = "MICR CODE     :"
        Me.XrLabel150.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel143
        '
        Me.XrLabel143.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel143.CanGrow = False
        Me.XrLabel143.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel143.LocationFloat = New DevExpress.Utils.PointFloat(367.8998!, 209.877!)
        Me.XrLabel143.Multiline = True
        Me.XrLabel143.Name = "XrLabel143"
        Me.XrLabel143.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel143.SizeF = New System.Drawing.SizeF(147.9732!, 17.99997!)
        Me.XrLabel143.StylePriority.UseBorders = False
        Me.XrLabel143.StylePriority.UseFont = False
        Me.XrLabel143.StylePriority.UseTextAlignment = False
        Me.XrLabel143.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel140
        '
        Me.XrLabel140.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel140.CanGrow = False
        Me.XrLabel140.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel140.LocationFloat = New DevExpress.Utils.PointFloat(367.8998!, 227.877!)
        Me.XrLabel140.Multiline = True
        Me.XrLabel140.Name = "XrLabel140"
        Me.XrLabel140.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel140.SizeF = New System.Drawing.SizeF(147.4005!, 17.85692!)
        Me.XrLabel140.StylePriority.UseBorders = False
        Me.XrLabel140.StylePriority.UseFont = False
        Me.XrLabel140.StylePriority.UseTextAlignment = False
        Me.XrLabel140.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel153
        '
        Me.XrLabel153.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel153.CanGrow = False
        Me.XrLabel153.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel153.LocationFloat = New DevExpress.Utils.PointFloat(0.2111753!, 245.7339!)
        Me.XrLabel153.Multiline = True
        Me.XrLabel153.Name = "XrLabel153"
        Me.XrLabel153.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel153.SizeF = New System.Drawing.SizeF(100.0!, 18.14297!)
        Me.XrLabel153.StylePriority.UseBorders = False
        Me.XrLabel153.StylePriority.UseFont = False
        Me.XrLabel153.StylePriority.UseTextAlignment = False
        Me.XrLabel153.Text = "IFSC CODE          :"
        Me.XrLabel153.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel141
        '
        Me.XrLabel141.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel141.CanGrow = False
        Me.XrLabel141.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel141.LocationFloat = New DevExpress.Utils.PointFloat(100.2112!, 245.7339!)
        Me.XrLabel141.Multiline = True
        Me.XrLabel141.Name = "XrLabel141"
        Me.XrLabel141.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel141.SizeF = New System.Drawing.SizeF(177.6887!, 18.14297!)
        Me.XrLabel141.StylePriority.UseBorders = False
        Me.XrLabel141.StylePriority.UseFont = False
        Me.XrLabel141.StylePriority.UseTextAlignment = False
        Me.XrLabel141.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel155
        '
        Me.XrLabel155.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel155.CanGrow = False
        Me.XrLabel155.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel155.LocationFloat = New DevExpress.Utils.PointFloat(277.8998!, 245.7339!)
        Me.XrLabel155.Multiline = True
        Me.XrLabel155.Name = "XrLabel155"
        Me.XrLabel155.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel155.SizeF = New System.Drawing.SizeF(237.4005!, 18.14294!)
        Me.XrLabel155.StylePriority.UseBorders = False
        Me.XrLabel155.StylePriority.UseFont = False
        Me.XrLabel155.StylePriority.UseTextAlignment = False
        Me.XrLabel155.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel156
        '
        Me.XrLabel156.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel156.CanGrow = False
        Me.XrLabel156.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Underline)
        Me.XrLabel156.LocationFloat = New DevExpress.Utils.PointFloat(515.8732!, 210.0202!)
        Me.XrLabel156.Multiline = True
        Me.XrLabel156.Name = "XrLabel156"
        Me.XrLabel156.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel156.SizeF = New System.Drawing.SizeF(262.338!, 53.99994!)
        Me.XrLabel156.StylePriority.UseBorders = False
        Me.XrLabel156.StylePriority.UseFont = False
        Me.XrLabel156.StylePriority.UseTextAlignment = False
        Me.XrLabel156.Text = "Certified that the particulars given above are true"
        Me.XrLabel156.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel107
        '
        Me.XrLabel107.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel107.CanGrow = False
        Me.XrLabel107.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel107.LocationFloat = New DevExpress.Utils.PointFloat(0.2111753!, 192.1713!)
        Me.XrLabel107.Multiline = True
        Me.XrLabel107.Name = "XrLabel107"
        Me.XrLabel107.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel107.SizeF = New System.Drawing.SizeF(515.4418!, 17.56251!)
        Me.XrLabel107.StylePriority.UseBorders = False
        Me.XrLabel107.StylePriority.UseFont = False
        Me.XrLabel107.StylePriority.UseTextAlignment = False
        Me.XrLabel107.Text = "BANK DETAILS FOR NEFT/ RTGS PAYMENTS"
        Me.XrLabel107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel110
        '
        Me.XrLabel110.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel110.CanGrow = False
        Me.XrLabel110.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel110.LocationFloat = New DevExpress.Utils.PointFloat(515.8729!, 192.1713!)
        Me.XrLabel110.Multiline = True
        Me.XrLabel110.Name = "XrLabel110"
        Me.XrLabel110.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel110.SizeF = New System.Drawing.SizeF(156.7648!, 17.84897!)
        Me.XrLabel110.StylePriority.UseBorders = False
        Me.XrLabel110.StylePriority.UseFont = False
        Me.XrLabel110.StylePriority.UseTextAlignment = False
        Me.XrLabel110.Text = "GST Payable on Reverse Charge"
        Me.XrLabel110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel111
        '
        Me.XrLabel111.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel111.CanGrow = False
        Me.XrLabel111.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.GSTReverseCharge]")})
        Me.XrLabel111.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel111.LocationFloat = New DevExpress.Utils.PointFloat(673.0392!, 192.1713!)
        Me.XrLabel111.Multiline = True
        Me.XrLabel111.Name = "XrLabel111"
        Me.XrLabel111.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel111.SizeF = New System.Drawing.SizeF(105.1641!, 17.84897!)
        Me.XrLabel111.StylePriority.UseBorders = False
        Me.XrLabel111.StylePriority.UseFont = False
        Me.XrLabel111.StylePriority.UseTextAlignment = False
        Me.XrLabel111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel111.TextFormatString = "{0:#,##0.00;(#,##0.00)}"
        '
        'XrLabel106
        '
        Me.XrLabel106.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel106.CanGrow = False
        Me.XrLabel106.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.Remarks]")})
        Me.XrLabel106.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel106.LocationFloat = New DevExpress.Utils.PointFloat(102.2946!, 175.3937!)
        Me.XrLabel106.Multiline = True
        Me.XrLabel106.Name = "XrLabel106"
        Me.XrLabel106.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel106.SizeF = New System.Drawing.SizeF(675.9091!, 16.77754!)
        Me.XrLabel106.StylePriority.UseBorders = False
        Me.XrLabel106.StylePriority.UseFont = False
        Me.XrLabel106.StylePriority.UseTextAlignment = False
        Me.XrLabel106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel104
        '
        Me.XrLabel104.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel104.CanGrow = False
        Me.XrLabel104.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel104.LocationFloat = New DevExpress.Utils.PointFloat(0.2113024!, 174.7522!)
        Me.XrLabel104.Multiline = True
        Me.XrLabel104.Name = "XrLabel104"
        Me.XrLabel104.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel104.SizeF = New System.Drawing.SizeF(102.0833!, 17.41902!)
        Me.XrLabel104.StylePriority.UseBorders = False
        Me.XrLabel104.StylePriority.UseFont = False
        Me.XrLabel104.StylePriority.UseTextAlignment = False
        Me.XrLabel104.Text = "Remarks"
        Me.XrLabel104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel87
        '
        Me.XrLabel87.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel87.CanGrow = False
        Me.XrLabel87.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel87.LocationFloat = New DevExpress.Utils.PointFloat(0.2111753!, 122.5628!)
        Me.XrLabel87.Multiline = True
        Me.XrLabel87.Name = "XrLabel87"
        Me.XrLabel87.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel87.SizeF = New System.Drawing.SizeF(371.449!, 16.77755!)
        Me.XrLabel87.StylePriority.UseBorders = False
        Me.XrLabel87.StylePriority.UseFont = False
        Me.XrLabel87.StylePriority.UseTextAlignment = False
        Me.XrLabel87.Text = "Total GST Amount in Words"
        Me.XrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel88
        '
        Me.XrLabel88.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel88.CanGrow = False
        Me.XrLabel88.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.TaxInWords]")})
        Me.XrLabel88.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel88.LocationFloat = New DevExpress.Utils.PointFloat(0.2111753!, 139.3401!)
        Me.XrLabel88.Multiline = True
        Me.XrLabel88.Name = "XrLabel88"
        Me.XrLabel88.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel88.SizeF = New System.Drawing.SizeF(371.449!, 35.41217!)
        Me.XrLabel88.StylePriority.UseBorders = False
        Me.XrLabel88.StylePriority.UseFont = False
        Me.XrLabel88.StylePriority.UseTextAlignment = False
        Me.XrLabel88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel102
        '
        Me.XrLabel102.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel102.CanGrow = False
        Me.XrLabel102.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel102.LocationFloat = New DevExpress.Utils.PointFloat(371.6602!, 122.5626!)
        Me.XrLabel102.Multiline = True
        Me.XrLabel102.Name = "XrLabel102"
        Me.XrLabel102.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel102.SizeF = New System.Drawing.SizeF(406.5513!, 17.41893!)
        Me.XrLabel102.StylePriority.UseBorders = False
        Me.XrLabel102.StylePriority.UseFont = False
        Me.XrLabel102.StylePriority.UseTextAlignment = False
        Me.XrLabel102.Text = "Total Invoice Amount in Words"
        Me.XrLabel102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel103
        '
        Me.XrLabel103.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel103.CanGrow = False
        Me.XrLabel103.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.TotalInWords]")})
        Me.XrLabel103.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel103.LocationFloat = New DevExpress.Utils.PointFloat(371.6602!, 139.9816!)
        Me.XrLabel103.Multiline = True
        Me.XrLabel103.Name = "XrLabel103"
        Me.XrLabel103.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel103.SizeF = New System.Drawing.SizeF(406.5513!, 35.41217!)
        Me.XrLabel103.StylePriority.UseBorders = False
        Me.XrLabel103.StylePriority.UseFont = False
        Me.XrLabel103.StylePriority.UseTextAlignment = False
        Me.XrLabel103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrCrossBandLine4
        '
        Me.XrCrossBandLine4.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine4.EndBand = Me.GroupFooter2
        Me.XrCrossBandLine4.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 122.5628!)
        Me.XrCrossBandLine4.Name = "XrCrossBandLine4"
        Me.XrCrossBandLine4.StartBand = Me.GroupFooter2
        Me.XrCrossBandLine4.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 69.56266!)
        Me.XrCrossBandLine4.WidthF = 1.041667!
        '
        'DS_ProformaServiceInvoice1
        '
        Me.DS_ProformaServiceInvoice1.DataSetName = "DS_ProformaServiceInvoice"
        Me.DS_ProformaServiceInvoice1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_ProformaServiceTableAdapter
        '
        Me.DT_ProformaServiceTableAdapter.ClearBeforeFill = True
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel92, Me.XrLabel85, Me.XrLabel84, Me.XrLabel83, Me.XrLabel82, Me.XrLabel81, Me.XrLabel80, Me.XrLabel79, Me.XrLabel30, Me.XrLabel27, Me.XrLabel31, Me.XrLabel32, Me.XrLabel33, Me.XrLabel23, Me.XrLabel22, Me.XrLabel12, Me.XrLabel8, Me.XrLabel17, Me.XrLabel44, Me.XrLabel45, Me.XrLabel46, Me.XrLabel47, Me.XrLabel4, Me.XrLabel6, Me.XrLabel7, Me.XrLabel11, Me.XrLabel55, Me.XrLabel56, Me.XrLabel57, Me.XrLabel58, Me.XrLabel61, Me.XrLabel62, Me.XrLabel63, Me.XrLabel64, Me.XrLabel66, Me.XrLabel65, Me.XrLabel67, Me.XrLabel69, Me.XrLabel71, Me.XrLabel72, Me.XrLabel73, Me.XrLabel74, Me.XrLabel75, Me.XrLabel93, Me.XrLabel120, Me.XrLabel121, Me.XrLabel126, Me.XrLabel127, Me.XrPictureBox1, Me.XrLabel59, Me.XrLabel91, Me.XrLabel29, Me.XrLabel9, Me.XrLabel90, Me.XrLabel89, Me.XrLabel28, Me.XrLabel18, Me.XrLabel60, Me.XrLabel70, Me.XrLabel10, Me.XrLabel15, Me.XrLabel1, Me.XrLabel52, Me.XrLabel50, Me.XrLabel53, Me.XrLabel49, Me.XrLabel123, Me.XrLabel122, Me.XrLabel43, Me.XrLabel36, Me.XrLabel34, Me.XrLabel13, Me.XrLabel21, Me.XrLabel20, Me.XrLabel3, Me.XrLabel2, Me.XrLabel14, Me.XrLabel5})
        Me.GroupHeader1.HeightF = 403.4081!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel92
        '
        Me.XrLabel92.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel92.CanGrow = False
        Me.XrLabel92.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel92.LocationFloat = New DevExpress.Utils.PointFloat(687.7731!, 363.4048!)
        Me.XrLabel92.Multiline = True
        Me.XrLabel92.Name = "XrLabel92"
        Me.XrLabel92.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel92.SizeF = New System.Drawing.SizeF(90.0!, 40.0!)
        Me.XrLabel92.StylePriority.UseBorders = False
        Me.XrLabel92.StylePriority.UseFont = False
        Me.XrLabel92.StylePriority.UseTextAlignment = False
        Me.XrLabel92.Text = "Total Amount"
        Me.XrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel85
        '
        Me.XrLabel85.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel85.CanGrow = False
        Me.XrLabel85.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel85.LocationFloat = New DevExpress.Utils.PointFloat(612.6741!, 382.448!)
        Me.XrLabel85.Multiline = True
        Me.XrLabel85.Name = "XrLabel85"
        Me.XrLabel85.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel85.SizeF = New System.Drawing.SizeF(75.09888!, 20.96002!)
        Me.XrLabel85.StylePriority.UseBorders = False
        Me.XrLabel85.StylePriority.UseFont = False
        Me.XrLabel85.StylePriority.UseTextAlignment = False
        Me.XrLabel85.Text = "Amount"
        Me.XrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel84
        '
        Me.XrLabel84.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel84.CanGrow = False
        Me.XrLabel84.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel84.LocationFloat = New DevExpress.Utils.PointFloat(586.674!, 382.448!)
        Me.XrLabel84.Multiline = True
        Me.XrLabel84.Name = "XrLabel84"
        Me.XrLabel84.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel84.SizeF = New System.Drawing.SizeF(26.0!, 20.96!)
        Me.XrLabel84.StylePriority.UseBorders = False
        Me.XrLabel84.StylePriority.UseFont = False
        Me.XrLabel84.StylePriority.UseTextAlignment = False
        Me.XrLabel84.Text = "Rate"
        Me.XrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel83
        '
        Me.XrLabel83.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel83.CanGrow = False
        Me.XrLabel83.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel83.LocationFloat = New DevExpress.Utils.PointFloat(586.674!, 363.4052!)
        Me.XrLabel83.Multiline = True
        Me.XrLabel83.Name = "XrLabel83"
        Me.XrLabel83.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel83.SizeF = New System.Drawing.SizeF(101.0989!, 19.04297!)
        Me.XrLabel83.StylePriority.UseBorders = False
        Me.XrLabel83.StylePriority.UseFont = False
        Me.XrLabel83.StylePriority.UseTextAlignment = False
        Me.XrLabel83.Text = "IGST"
        Me.XrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel82
        '
        Me.XrLabel82.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel82.CanGrow = False
        Me.XrLabel82.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel82.LocationFloat = New DevExpress.Utils.PointFloat(535.1791!, 363.4081!)
        Me.XrLabel82.Multiline = True
        Me.XrLabel82.Name = "XrLabel82"
        Me.XrLabel82.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel82.SizeF = New System.Drawing.SizeF(51.49506!, 39.99997!)
        Me.XrLabel82.StylePriority.UseBorders = False
        Me.XrLabel82.StylePriority.UseFont = False
        Me.XrLabel82.StylePriority.UseTextAlignment = False
        Me.XrLabel82.Text = "Taxable Value"
        Me.XrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel81
        '
        Me.XrLabel81.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel81.CanGrow = False
        Me.XrLabel81.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel81.LocationFloat = New DevExpress.Utils.PointFloat(451.674!, 363.4047!)
        Me.XrLabel81.Multiline = True
        Me.XrLabel81.Name = "XrLabel81"
        Me.XrLabel81.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel81.SizeF = New System.Drawing.SizeF(34.0!, 40.0!)
        Me.XrLabel81.StylePriority.UseBorders = False
        Me.XrLabel81.StylePriority.UseFont = False
        Me.XrLabel81.StylePriority.UseTextAlignment = False
        Me.XrLabel81.Text = "Dis.(%)"
        Me.XrLabel81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel80
        '
        Me.XrLabel80.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel80.CanGrow = False
        Me.XrLabel80.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel80.LocationFloat = New DevExpress.Utils.PointFloat(250.1123!, 363.405!)
        Me.XrLabel80.Multiline = True
        Me.XrLabel80.Name = "XrLabel80"
        Me.XrLabel80.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel80.SizeF = New System.Drawing.SizeF(30.0!, 40.0!)
        Me.XrLabel80.StylePriority.UseBorders = False
        Me.XrLabel80.StylePriority.UseFont = False
        Me.XrLabel80.StylePriority.UseTextAlignment = False
        Me.XrLabel80.Text = "UOM"
        Me.XrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel79
        '
        Me.XrLabel79.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel79.CanGrow = False
        Me.XrLabel79.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel79.LocationFloat = New DevExpress.Utils.PointFloat(200.0!, 363.4052!)
        Me.XrLabel79.Multiline = True
        Me.XrLabel79.Name = "XrLabel79"
        Me.XrLabel79.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel79.SizeF = New System.Drawing.SizeF(50.0!, 40.0!)
        Me.XrLabel79.StylePriority.UseBorders = False
        Me.XrLabel79.StylePriority.UseFont = False
        Me.XrLabel79.StylePriority.UseTextAlignment = False
        Me.XrLabel79.Text = "HSN/SAC"
        Me.XrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel30
        '
        Me.XrLabel30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel30.CanGrow = False
        Me.XrLabel30.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(30.00001!, 363.4052!)
        Me.XrLabel30.Multiline = True
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(170.0!, 40.0!)
        Me.XrLabel30.StylePriority.UseBorders = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "Description"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel27
        '
        Me.XrLabel27.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel27.CanGrow = False
        Me.XrLabel27.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(0!, 363.4081!)
        Me.XrLabel27.Multiline = True
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(30.0!, 39.99667!)
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "Sr. No"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel31
        '
        Me.XrLabel31.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel31.CanGrow = False
        Me.XrLabel31.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(280.1123!, 363.4081!)
        Me.XrLabel31.Multiline = True
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(52.67398!, 39.99994!)
        Me.XrLabel31.StylePriority.UseBorders = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Qty"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel32
        '
        Me.XrLabel32.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel32.CanGrow = False
        Me.XrLabel32.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(332.7863!, 363.4081!)
        Me.XrLabel32.Multiline = True
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(59.72943!, 40.0!)
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "Rate"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel33
        '
        Me.XrLabel33.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel33.CanGrow = False
        Me.XrLabel33.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(392.5157!, 363.405!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(59.15826!, 40.0!)
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Amount"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel23
        '
        Me.XrLabel23.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel23.CanGrow = False
        Me.XrLabel23.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(485.674!, 363.4046!)
        Me.XrLabel23.Multiline = True
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(49.50504!, 40.00003!)
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Dis." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Val"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel22
        '
        Me.XrLabel22.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel22.CanGrow = False
        Me.XrLabel22.Font = New DevExpress.Drawing.DXFont("Calibri", 11.25!, CType((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic), DevExpress.Drawing.DXFontStyle), DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(0.2113051!, 110.9168!)
        Me.XrLabel22.Multiline = True
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(777.6124!, 18.38234!)
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.CanGrow = False
        Me.XrLabel12.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(249.4358!, 325.9912!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(49.49001!, 18.45395!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "PANNo : "
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(634.3655!, 325.9912!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(49.48999!, 18.45392!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "PANNo : "
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.CanGrow = False
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("Calibri", 15.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0!, 129.2992!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(777.6508!, 31.31239!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "PROFORMA  INVOICE"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel44
        '
        Me.XrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel44.CanGrow = False
        Me.XrLabel44.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(0.007750941!, 183.4659!)
        Me.XrLabel44.Multiline = True
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(81.37976!, 18.60429!)
        Me.XrLabel44.StylePriority.UseBorders = False
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "Proforma No. : "
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel45
        '
        Me.XrLabel45.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel45.CanGrow = False
        Me.XrLabel45.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(392.5505!, 202.0703!)
        Me.XrLabel45.Multiline = True
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(80.97391!, 18.60429!)
        Me.XrLabel45.StylePriority.UseBorders = False
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = "Supply From :"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel46
        '
        Me.XrLabel46.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel46.CanGrow = False
        Me.XrLabel46.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.InvoiceNo]")})
        Me.XrLabel46.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(81.38756!, 183.4659!)
        Me.XrLabel46.Multiline = True
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(141.57!, 18.60463!)
        Me.XrLabel46.StylePriority.UseBorders = False
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel47
        '
        Me.XrLabel47.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel47.CanGrow = False
        Me.XrLabel47.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(473.5244!, 202.0703!)
        Me.XrLabel47.Multiline = True
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(125.0576!, 18.60431!)
        Me.XrLabel47.StylePriority.UseBorders = False
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.StylePriority.UseTextAlignment = False
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.007750941!, 239.2785!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(81.37978!, 18.75!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "State               :"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(81.38754!, 239.2785!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(141.1562!, 18.75!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.CanGrow = False
        Me.XrLabel7.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(222.544!, 239.2785!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(78.81131!, 18.74997!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "State Code     :"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.CanGrow = False
        Me.XrLabel11.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(301.3553!, 239.2785!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(91.16901!, 18.75!)
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel55
        '
        Me.XrLabel55.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel55.CanGrow = False
        Me.XrLabel55.Font = New DevExpress.Drawing.DXFont("Calibri", 11.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(0.007750941!, 258.0285!)
        Me.XrLabel55.Multiline = True
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(392.5166!, 18.31287!)
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "Details Of Receiver | Billed to :"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel56
        '
        Me.XrLabel56.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel56.CanGrow = False
        Me.XrLabel56.Font = New DevExpress.Drawing.DXFont("Calibri", 11.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(392.5505!, 258.0285!)
        Me.XrLabel56.Multiline = True
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel56.SizeF = New System.Drawing.SizeF(385.0625!, 18.31287!)
        Me.XrLabel56.StylePriority.UseBorders = False
        Me.XrLabel56.StylePriority.UseFont = False
        Me.XrLabel56.StylePriority.UseTextAlignment = False
        Me.XrLabel56.Text = "Details Of Consignee | Shipped to :"
        Me.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel57
        '
        Me.XrLabel57.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel57.CanGrow = False
        Me.XrLabel57.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(0.007750941!, 276.3415!)
        Me.XrLabel57.Multiline = True
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel57.SizeF = New System.Drawing.SizeF(53.0!, 18.6!)
        Me.XrLabel57.StylePriority.UseBorders = False
        Me.XrLabel57.StylePriority.UseFont = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        Me.XrLabel57.Text = "Name     : "
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel58
        '
        Me.XrLabel58.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel58.CanGrow = False
        Me.XrLabel58.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.ReceiverName]")})
        Me.XrLabel58.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(53.00776!, 276.3415!)
        Me.XrLabel58.Multiline = True
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel58.SizeF = New System.Drawing.SizeF(339.5166!, 18.60428!)
        Me.XrLabel58.StylePriority.UseBorders = False
        Me.XrLabel58.StylePriority.UseFont = False
        Me.XrLabel58.StylePriority.UseTextAlignment = False
        Me.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel61
        '
        Me.XrLabel61.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel61.CanGrow = False
        Me.XrLabel61.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel61.LocationFloat = New DevExpress.Utils.PointFloat(0.0001402462!, 325.9865!)
        Me.XrLabel61.Multiline = True
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel61.SizeF = New System.Drawing.SizeF(53.00762!, 18.60428!)
        Me.XrLabel61.StylePriority.UseBorders = False
        Me.XrLabel61.StylePriority.UseFont = False
        Me.XrLabel61.StylePriority.UseTextAlignment = False
        Me.XrLabel61.Text = "GSTIN    : "
        Me.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel62
        '
        Me.XrLabel62.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel62.CanGrow = False
        Me.XrLabel62.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.ReceiverGSTIN]")})
        Me.XrLabel62.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel62.LocationFloat = New DevExpress.Utils.PointFloat(53.00776!, 325.9868!)
        Me.XrLabel62.Multiline = True
        Me.XrLabel62.Name = "XrLabel62"
        Me.XrLabel62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel62.SizeF = New System.Drawing.SizeF(196.428!, 18.45862!)
        Me.XrLabel62.StylePriority.UseBorders = False
        Me.XrLabel62.StylePriority.UseFont = False
        Me.XrLabel62.StylePriority.UseTextAlignment = False
        Me.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel63
        '
        Me.XrLabel63.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel63.CanGrow = False
        Me.XrLabel63.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel63.LocationFloat = New DevExpress.Utils.PointFloat(0!, 344.5909!)
        Me.XrLabel63.Multiline = True
        Me.XrLabel63.Name = "XrLabel63"
        Me.XrLabel63.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel63.SizeF = New System.Drawing.SizeF(53.00776!, 18.74997!)
        Me.XrLabel63.StylePriority.UseBorders = False
        Me.XrLabel63.StylePriority.UseFont = False
        Me.XrLabel63.StylePriority.UseTextAlignment = False
        Me.XrLabel63.Text = "State      : "
        Me.XrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel64
        '
        Me.XrLabel64.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel64.CanGrow = False
        Me.XrLabel64.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.ReceiverState]")})
        Me.XrLabel64.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel64.LocationFloat = New DevExpress.Utils.PointFloat(53.00776!, 344.5909!)
        Me.XrLabel64.Multiline = True
        Me.XrLabel64.Name = "XrLabel64"
        Me.XrLabel64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel64.SizeF = New System.Drawing.SizeF(196.428!, 18.60419!)
        Me.XrLabel64.StylePriority.UseBorders = False
        Me.XrLabel64.StylePriority.UseFont = False
        Me.XrLabel64.StylePriority.UseTextAlignment = False
        Me.XrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel66
        '
        Me.XrLabel66.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel66.CanGrow = False
        Me.XrLabel66.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel66.LocationFloat = New DevExpress.Utils.PointFloat(249.4358!, 344.5912!)
        Me.XrLabel66.Multiline = True
        Me.XrLabel66.Name = "XrLabel66"
        Me.XrLabel66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel66.SizeF = New System.Drawing.SizeF(69.99998!, 18.45816!)
        Me.XrLabel66.StylePriority.UseBorders = False
        Me.XrLabel66.StylePriority.UseFont = False
        Me.XrLabel66.StylePriority.UseTextAlignment = False
        Me.XrLabel66.Text = "State Code :"
        Me.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel65
        '
        Me.XrLabel65.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel65.CanGrow = False
        Me.XrLabel65.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.ReceiverStateCode]")})
        Me.XrLabel65.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel65.LocationFloat = New DevExpress.Utils.PointFloat(319.4358!, 344.5909!)
        Me.XrLabel65.Multiline = True
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel65.SizeF = New System.Drawing.SizeF(73.08002!, 18.60422!)
        Me.XrLabel65.StylePriority.UseBorders = False
        Me.XrLabel65.StylePriority.UseFont = False
        Me.XrLabel65.StylePriority.UseTextAlignment = False
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel67
        '
        Me.XrLabel67.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel67.CanGrow = False
        Me.XrLabel67.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel67.LocationFloat = New DevExpress.Utils.PointFloat(392.5505!, 276.3415!)
        Me.XrLabel67.Multiline = True
        Me.XrLabel67.Name = "XrLabel67"
        Me.XrLabel67.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel67.SizeF = New System.Drawing.SizeF(53.0!, 18.6!)
        Me.XrLabel67.StylePriority.UseBorders = False
        Me.XrLabel67.StylePriority.UseFont = False
        Me.XrLabel67.StylePriority.UseTextAlignment = False
        Me.XrLabel67.Text = "Name     : "
        Me.XrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel69
        '
        Me.XrLabel69.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel69.CanGrow = False
        Me.XrLabel69.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.ConsigneeName]")})
        Me.XrLabel69.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel69.LocationFloat = New DevExpress.Utils.PointFloat(445.5505!, 276.3415!)
        Me.XrLabel69.Multiline = True
        Me.XrLabel69.Name = "XrLabel69"
        Me.XrLabel69.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel69.SizeF = New System.Drawing.SizeF(332.0626!, 18.60428!)
        Me.XrLabel69.StylePriority.UseBorders = False
        Me.XrLabel69.StylePriority.UseFont = False
        Me.XrLabel69.StylePriority.UseTextAlignment = False
        Me.XrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel71
        '
        Me.XrLabel71.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel71.CanGrow = False
        Me.XrLabel71.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel71.LocationFloat = New DevExpress.Utils.PointFloat(392.5505!, 325.9868!)
        Me.XrLabel71.Multiline = True
        Me.XrLabel71.Name = "XrLabel71"
        Me.XrLabel71.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel71.SizeF = New System.Drawing.SizeF(53.0!, 18.60425!)
        Me.XrLabel71.StylePriority.UseBorders = False
        Me.XrLabel71.StylePriority.UseFont = False
        Me.XrLabel71.StylePriority.UseTextAlignment = False
        Me.XrLabel71.Text = "GSTIN    : "
        Me.XrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel72
        '
        Me.XrLabel72.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel72.CanGrow = False
        Me.XrLabel72.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.ConsigneeGSTIN]")})
        Me.XrLabel72.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel72.LocationFloat = New DevExpress.Utils.PointFloat(445.5505!, 325.9868!)
        Me.XrLabel72.Multiline = True
        Me.XrLabel72.Name = "XrLabel72"
        Me.XrLabel72.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel72.SizeF = New System.Drawing.SizeF(188.815!, 18.60425!)
        Me.XrLabel72.StylePriority.UseBorders = False
        Me.XrLabel72.StylePriority.UseFont = False
        Me.XrLabel72.StylePriority.UseTextAlignment = False
        Me.XrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel73
        '
        Me.XrLabel73.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel73.CanGrow = False
        Me.XrLabel73.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel73.LocationFloat = New DevExpress.Utils.PointFloat(392.5497!, 344.5909!)
        Me.XrLabel73.Multiline = True
        Me.XrLabel73.Name = "XrLabel73"
        Me.XrLabel73.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel73.SizeF = New System.Drawing.SizeF(53.00085!, 18.74988!)
        Me.XrLabel73.StylePriority.UseBorders = False
        Me.XrLabel73.StylePriority.UseFont = False
        Me.XrLabel73.StylePriority.UseTextAlignment = False
        Me.XrLabel73.Text = "State      : "
        Me.XrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel74
        '
        Me.XrLabel74.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel74.CanGrow = False
        Me.XrLabel74.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel74.LocationFloat = New DevExpress.Utils.PointFloat(634.3655!, 344.5912!)
        Me.XrLabel74.Multiline = True
        Me.XrLabel74.Name = "XrLabel74"
        Me.XrLabel74.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel74.SizeF = New System.Drawing.SizeF(70.12775!, 18.60379!)
        Me.XrLabel74.StylePriority.UseBorders = False
        Me.XrLabel74.StylePriority.UseFont = False
        Me.XrLabel74.StylePriority.UseTextAlignment = False
        Me.XrLabel74.Text = "State Code  :"
        Me.XrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel75
        '
        Me.XrLabel75.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel75.CanGrow = False
        Me.XrLabel75.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.ConsigneeStateCode]")})
        Me.XrLabel75.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel75.LocationFloat = New DevExpress.Utils.PointFloat(704.4932!, 344.5912!)
        Me.XrLabel75.Multiline = True
        Me.XrLabel75.Name = "XrLabel75"
        Me.XrLabel75.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel75.SizeF = New System.Drawing.SizeF(73.11987!, 18.7496!)
        Me.XrLabel75.StylePriority.UseBorders = False
        Me.XrLabel75.StylePriority.UseFont = False
        Me.XrLabel75.StylePriority.UseTextAlignment = False
        Me.XrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel93
        '
        Me.XrLabel93.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel93.CanGrow = False
        Me.XrLabel93.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.ConsigneeState]")})
        Me.XrLabel93.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel93.LocationFloat = New DevExpress.Utils.PointFloat(445.5505!, 344.5909!)
        Me.XrLabel93.Multiline = True
        Me.XrLabel93.Name = "XrLabel93"
        Me.XrLabel93.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel93.SizeF = New System.Drawing.SizeF(188.815!, 18.60428!)
        Me.XrLabel93.StylePriority.UseBorders = False
        Me.XrLabel93.StylePriority.UseFont = False
        Me.XrLabel93.StylePriority.UseTextAlignment = False
        Me.XrLabel93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel120
        '
        Me.XrLabel120.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel120.CanGrow = False
        Me.XrLabel120.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel120.LocationFloat = New DevExpress.Utils.PointFloat(222.9576!, 183.4659!)
        Me.XrLabel120.Multiline = True
        Me.XrLabel120.Name = "XrLabel120"
        Me.XrLabel120.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel120.SizeF = New System.Drawing.SizeF(78.39769!, 18.60464!)
        Me.XrLabel120.StylePriority.UseBorders = False
        Me.XrLabel120.StylePriority.UseFont = False
        Me.XrLabel120.StylePriority.UseTextAlignment = False
        Me.XrLabel120.Text = "Date                :"
        Me.XrLabel120.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel121
        '
        Me.XrLabel121.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel121.CanGrow = False
        Me.XrLabel121.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.InvoiceDate]")})
        Me.XrLabel121.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel121.LocationFloat = New DevExpress.Utils.PointFloat(301.3553!, 183.4659!)
        Me.XrLabel121.Multiline = True
        Me.XrLabel121.Name = "XrLabel121"
        Me.XrLabel121.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel121.SizeF = New System.Drawing.SizeF(91.16888!, 18.45889!)
        Me.XrLabel121.StylePriority.UseBorders = False
        Me.XrLabel121.StylePriority.UseFont = False
        Me.XrLabel121.StylePriority.UseTextAlignment = False
        Me.XrLabel121.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel121.TextFormatString = "{0:dd-MM-yyyy}"
        '
        'XrLabel126
        '
        Me.XrLabel126.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel126.CanGrow = False
        Me.XrLabel126.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel126.LocationFloat = New DevExpress.Utils.PointFloat(0!, 294.9457!)
        Me.XrLabel126.Multiline = True
        Me.XrLabel126.Name = "XrLabel126"
        Me.XrLabel126.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel126.SizeF = New System.Drawing.SizeF(53.00776!, 18.60428!)
        Me.XrLabel126.StylePriority.UseBorders = False
        Me.XrLabel126.StylePriority.UseFont = False
        Me.XrLabel126.StylePriority.UseTextAlignment = False
        Me.XrLabel126.Text = "Address : "
        Me.XrLabel126.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel127
        '
        Me.XrLabel127.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel127.CanGrow = False
        Me.XrLabel127.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel127.LocationFloat = New DevExpress.Utils.PointFloat(392.5505!, 294.9457!)
        Me.XrLabel127.Multiline = True
        Me.XrLabel127.Name = "XrLabel127"
        Me.XrLabel127.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel127.SizeF = New System.Drawing.SizeF(53.0!, 18.60428!)
        Me.XrLabel127.StylePriority.UseBorders = False
        Me.XrLabel127.StylePriority.UseFont = False
        Me.XrLabel127.StylePriority.UseTextAlignment = False
        Me.XrLabel127.Text = "Address : "
        Me.XrLabel127.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.6460622!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(88.0!, 88.0!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox1.StylePriority.UseBorders = False
        '
        'XrLabel59
        '
        Me.XrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel59.CanGrow = False
        Me.XrLabel59.Font = New DevExpress.Drawing.DXFont("Calibri", 20.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(88.64607!, 0!)
        Me.XrLabel59.Multiline = True
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(689.6053!, 33.99998!)
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel91
        '
        Me.XrLabel91.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel91.CanGrow = False
        Me.XrLabel91.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!)
        Me.XrLabel91.LocationFloat = New DevExpress.Utils.PointFloat(88.64606!, 69.99999!)
        Me.XrLabel91.Multiline = True
        Me.XrLabel91.Name = "XrLabel91"
        Me.XrLabel91.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel91.SizeF = New System.Drawing.SizeF(689.6054!, 17.99999!)
        Me.XrLabel91.StylePriority.UseBorders = False
        Me.XrLabel91.StylePriority.UseFont = False
        Me.XrLabel91.StylePriority.UseTextAlignment = False
        Me.XrLabel91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel29
        '
        Me.XrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel29.CanGrow = False
        Me.XrLabel29.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(88.64606!, 51.99999!)
        Me.XrLabel29.Multiline = True
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(689.6054!, 18.0!)
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.Font = New DevExpress.Drawing.DXFont("Calibri", 11.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(88.64607!, 33.99998!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(689.6053!, 17.99999!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel90
        '
        Me.XrLabel90.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel90.CanGrow = False
        Me.XrLabel90.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel90.LocationFloat = New DevExpress.Utils.PointFloat(680.7911!, 87.99997!)
        Me.XrLabel90.Multiline = True
        Me.XrLabel90.Name = "XrLabel90"
        Me.XrLabel90.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel90.SizeF = New System.Drawing.SizeF(97.57849!, 22.91669!)
        Me.XrLabel90.StylePriority.UseBorders = False
        Me.XrLabel90.StylePriority.UseFont = False
        Me.XrLabel90.StylePriority.UseTextAlignment = False
        Me.XrLabel90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel89
        '
        Me.XrLabel89.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel89.CanGrow = False
        Me.XrLabel89.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel89.LocationFloat = New DevExpress.Utils.PointFloat(405.4625!, 87.99999!)
        Me.XrLabel89.Multiline = True
        Me.XrLabel89.Name = "XrLabel89"
        Me.XrLabel89.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel89.SizeF = New System.Drawing.SizeF(275.2935!, 22.91667!)
        Me.XrLabel89.StylePriority.UseBorders = False
        Me.XrLabel89.StylePriority.UseFont = False
        Me.XrLabel89.StylePriority.UseTextAlignment = False
        Me.XrLabel89.Text = "PAN No :"
        Me.XrLabel89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel28
        '
        Me.XrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel28.CanGrow = False
        Me.XrLabel28.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(52.64606!, 87.99999!)
        Me.XrLabel28.Multiline = True
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(352.8163!, 22.91667!)
        Me.XrLabel28.StylePriority.UseBorders = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel18.CanGrow = False
        Me.XrLabel18.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(0.6460612!, 87.99999!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(52.0!, 22.91667!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "GSTIN: "
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel60
        '
        Me.XrLabel60.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.ReceiverAddress]")})
        Me.XrLabel60.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(53.00776!, 294.9459!)
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel60.SizeF = New System.Drawing.SizeF(339.5081!, 31.04092!)
        Me.XrLabel60.StylePriority.UseFont = False
        '
        'XrLabel70
        '
        Me.XrLabel70.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel70.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.ConsigneeAddress]")})
        Me.XrLabel70.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel70.LocationFloat = New DevExpress.Utils.PointFloat(445.5505!, 294.9457!)
        Me.XrLabel70.Name = "XrLabel70"
        Me.XrLabel70.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel70.SizeF = New System.Drawing.SizeF(332.1729!, 31.04102!)
        Me.XrLabel70.StylePriority.UseBorders = False
        Me.XrLabel70.StylePriority.UseFont = False
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.CanGrow = False
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.ReceiverPanNo]")})
        Me.XrLabel10.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(298.9258!, 325.9912!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(93.59!, 18.45392!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel15.CanGrow = False
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.ConsigneePanNo]")})
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(683.8555!, 325.9912!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(93.71765!, 18.60001!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 160.6114!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(777.613!, 22.85422!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel52
        '
        Me.XrLabel52.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel52.CanGrow = False
        Me.XrLabel52.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.AgainstForm]")})
        Me.XrLabel52.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(473.5244!, 238.9864!)
        Me.XrLabel52.Multiline = True
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.SizeF = New System.Drawing.SizeF(304.0886!, 19.04218!)
        Me.XrLabel52.StylePriority.UseBorders = False
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel50
        '
        Me.XrLabel50.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel50.CanGrow = False
        Me.XrLabel50.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(392.5244!, 239.4242!)
        Me.XrLabel50.Multiline = True
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(81.0!, 18.6!)
        Me.XrLabel50.StylePriority.UseBorders = False
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        Me.XrLabel50.Text = "Way Bill No.  :"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel53
        '
        Me.XrLabel53.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel53.CanGrow = False
        Me.XrLabel53.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.SupplyTo]")})
        Me.XrLabel53.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(667.5435!, 202.0704!)
        Me.XrLabel53.Multiline = True
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.SizeF = New System.Drawing.SizeF(110.0695!, 18.60408!)
        Me.XrLabel53.StylePriority.UseBorders = False
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel49
        '
        Me.XrLabel49.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel49.CanGrow = False
        Me.XrLabel49.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(598.582!, 202.0703!)
        Me.XrLabel49.Multiline = True
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(68.96161!, 18.60425!)
        Me.XrLabel49.StylePriority.UseBorders = False
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = "Supply To  :"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel123
        '
        Me.XrLabel123.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel123.CanGrow = False
        Me.XrLabel123.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.PODate]")})
        Me.XrLabel123.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel123.LocationFloat = New DevExpress.Utils.PointFloat(301.3553!, 220.5285!)
        Me.XrLabel123.Multiline = True
        Me.XrLabel123.Name = "XrLabel123"
        Me.XrLabel123.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel123.SizeF = New System.Drawing.SizeF(91.19522!, 18.75008!)
        Me.XrLabel123.StylePriority.UseBorders = False
        Me.XrLabel123.StylePriority.UseFont = False
        Me.XrLabel123.StylePriority.UseTextAlignment = False
        Me.XrLabel123.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel123.TextFormatString = "{0:dd-MM-yyyy}"
        '
        'XrLabel122
        '
        Me.XrLabel122.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel122.CanGrow = False
        Me.XrLabel122.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel122.LocationFloat = New DevExpress.Utils.PointFloat(222.9576!, 220.5285!)
        Me.XrLabel122.Multiline = True
        Me.XrLabel122.Name = "XrLabel122"
        Me.XrLabel122.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel122.SizeF = New System.Drawing.SizeF(78.39789!, 18.75006!)
        Me.XrLabel122.StylePriority.UseBorders = False
        Me.XrLabel122.StylePriority.UseFont = False
        Me.XrLabel122.StylePriority.UseTextAlignment = False
        Me.XrLabel122.Text = "PO Date          :"
        Me.XrLabel122.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel43
        '
        Me.XrLabel43.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel43.CanGrow = False
        Me.XrLabel43.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.PO]")})
        Me.XrLabel43.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(81.38754!, 220.6743!)
        Me.XrLabel43.Multiline = True
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(141.5699!, 18.60429!)
        Me.XrLabel43.StylePriority.UseBorders = False
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel36
        '
        Me.XrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel36.CanGrow = False
        Me.XrLabel36.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(0!, 220.6743!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(81.38754!, 18.60429!)
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "P. O.                :"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel34.CanGrow = False
        Me.XrLabel34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.TransportationMode]")})
        Me.XrLabel34.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(518.8488!, 183.4659!)
        Me.XrLabel34.Multiline = True
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(258.7642!, 18.4585!)
        Me.XrLabel34.StylePriority.UseBorders = False
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel13.CanGrow = False
        Me.XrLabel13.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(392.5242!, 183.6116!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(126.3246!, 18.45847!)
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Transportation Mode  : "
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel21.CanGrow = False
        Me.XrLabel21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.PartyDCDate]")})
        Me.XrLabel21.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(301.3553!, 202.0704!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(91.16046!, 18.45782!)
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel21.TextFormatString = "{0:dd-MM-yyyy}"
        '
        'XrLabel20
        '
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel20.CanGrow = False
        Me.XrLabel20.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(222.544!, 202.0704!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(78.81126!, 18.45801!)
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "Party DC Date:"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT_Invoice.PartyDCNo]")})
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(81.38754!, 202.0704!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(141.1562!, 18.60381!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 202.0698!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(81.38754!, 18.60443!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Party DC No.  :"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Packing]")})
        Me.XrLabel14.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(473.4897!, 220.6746!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(304.1232!, 18.31183!)
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(392.5505!, 220.6746!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(80.93918!, 18.60397!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Packing          :"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrCrossBandLine2
        '
        Me.XrCrossBandLine2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine2.EndBand = Me.GroupHeader1
        Me.XrCrossBandLine2.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 325.9868!)
        Me.XrCrossBandLine2.Name = "XrCrossBandLine2"
        Me.XrCrossBandLine2.StartBand = Me.GroupHeader1
        Me.XrCrossBandLine2.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 313.55!)
        Me.XrCrossBandLine2.WidthF = 1.041668!
        '
        'XrCrossBandLine3
        '
        Me.XrCrossBandLine3.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.XrCrossBandLine3.EndBand = Me.GroupHeader1
        Me.XrCrossBandLine3.EndPointFloat = New DevExpress.Utils.PointFloat(392.5505!, 325.9868!)
        Me.XrCrossBandLine3.Name = "XrCrossBandLine3"
        Me.XrCrossBandLine3.StartBand = Me.GroupHeader1
        Me.XrCrossBandLine3.StartPointFloat = New DevExpress.Utils.PointFloat(392.5505!, 313.55!)
        Me.XrCrossBandLine3.WidthF = 1.006958!
        '
        'XR_ProformaSEZServiceWithLUT
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.GroupFooter2, Me.GroupHeader1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandLine3, Me.XrCrossBandLine2, Me.XrCrossBandLine4, Me.XrCrossBandLine1})
        Me.DataAdapter = Me.DT_ProformaServiceTableAdapter
        Me.DataMember = "DT_ProformaService"
        Me.DataSource = Me.DS_ProformaServiceInvoice1
        Me.FilterString = "[ProformaServiceInvoiceID] = ?Invoice"
        Me.Font = New DevExpress.Drawing.DXFont("Times New Roman", 10.0!)
        Me.Margins = New DevExpress.Drawing.DXMargins(21.0!, 26.0!, 48.0!, 0!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Invoice})
        Me.Version = "23.2"
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ProformaServiceInvoice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher

    'Friend WithEvents DS_Invoice1 As DS_Invoice
    'Friend WithEvents DT_InvoiceTableAdapter As DS_InvoiceTableAdapters.DT_InvoiceTableAdapter
    Friend WithEvents XrCrossBandLine1 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents Invoice As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel87 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel88 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel102 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel103 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel104 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel106 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel107 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel110 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel111 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel157 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel158 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel159 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel160 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel161 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel115 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel129 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel138 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel139 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel133 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel150 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel143 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel140 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel153 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel141 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel155 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel156 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel162 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel163 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel164 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TaxableValueLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel166 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel167 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel168 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandLine4 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalGSTCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PackingChargeCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TaxableValLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TaxableValueCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents RoundOffCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GrandTotalLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GrandTotalCell As DevExpress.XtraReports.UI.XRTableCell

    Friend WithEvents DS_ProformaServiceInvoice1 As DS_ProformaServiceInvoice
    Friend WithEvents DT_ProformaServiceTableAdapter As DS_ProformaServiceInvoiceTableAdapters.DT_ProformaServiceTableAdapter
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel62 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel63 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel64 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel66 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel65 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel67 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel69 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel71 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel72 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel73 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel74 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel75 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel93 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel120 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel121 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel126 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel127 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel91 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel90 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel89 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel123 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel122 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCrossBandLine2 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrCrossBandLine3 As DevExpress.XtraReports.UI.XRCrossBandLine
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel92 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel85 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel84 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel83 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel82 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel81 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel80 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel79 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
End Class
