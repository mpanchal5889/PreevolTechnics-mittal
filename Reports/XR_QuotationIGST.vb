﻿Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Public Class XR_QuotationIGST

    Private Sub XrTable3_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable3.BeforePrint
        Dim daCgst As OleDbDataAdapter
        Dim dtCgst As New DataTable
        Dim sqlCgst As String

        Dim daLI As OleDbDataAdapter
        Dim dtLI As New DataTable
        Dim sqlLineItems As String

        'Dim daPacking As OleDbDataAdapter
        'Dim dtPacking As New DataTable
        'Dim sqlPacking As String

        Dim i, j As Integer
        sqlCgst = "SELECT DISTINCT IGSTRate from QuotationDetail Where QuotationID = " + Invoice.Value.ToString()
        sqlLineItems = "SELECT TaxableValue,IGSTRate,IGSTAmt from QuotationDetail Where QuotationID = " + Invoice.Value.ToString()
        'sqlPacking = "SELECT PackingCharge,PCGSTRate,PCGSTAmt,PSGSTRate,PSGSTAmt from Quotation Where QuotationID = " + Invoice.Value.ToString()

        Try
            daCgst = New OleDbDataAdapter(sqlCgst, ConStr)
            daCgst.Fill(dtCgst)
            daLI = New OleDbDataAdapter(sqlLineItems, ConStr)
            daLI.Fill(dtLI)
            'daPacking = New OleDbDataAdapter(sqlPacking, ConStr)
            'daPacking.Fill(dtPacking)
            Dim list1 As New List(Of Object)

            For i = 0 To dtCgst.Rows.Count - 1
                list1.Add(dtCgst.Rows(i).Item(0))
            Next
            'For j = 0 To dtPacking.Rows.Count - 1
            '    Dim Pcharge As Double
            '    Pcharge = CDec(dtPacking.Rows(j).Item(0))

            '    If Not list1.Contains(dtPacking.Rows(j).Item(1)) And Not Pcharge = 0 Then
            '        list1.Add(dtPacking.Rows(j).Item(1))
            '    End If
            'Next
            'For i = 0 To list1.Count - 1
            '    MsgBox("Value = " + list1.Item(i).ToString())
            'Next

            For i = 0 To list1.Count - 1
                Dim row As New DevExpress.XtraReports.UI.XRTableRow()
                Dim taxableVal As New DevExpress.XtraReports.UI.XRTableCell()
                Dim igstRate As New DevExpress.XtraReports.UI.XRTableCell()
                Dim igstAmt As New DevExpress.XtraReports.UI.XRTableCell()
                Dim taxVal As Decimal
                Dim igstAmnt As Decimal

                taxVal = 0
                igstAmnt = 0

                For j = 0 To dtLI.Rows.Count - 1
                    If CDec(list1.Item(i).ToString()) = Convert.ToDecimal(dtLI.Rows(j).Item(1)) Then
                        taxVal = taxVal + Convert.ToDecimal(dtLI.Rows(j).Item(0))
                        igstAmnt = igstAmnt + Convert.ToDecimal(dtLI.Rows(j).Item(2))
                    End If
                Next
                'For j = 0 To dtPacking.Rows.Count - 1
                '    If CDec(list1.Item(i).ToString()) = Convert.ToDecimal(dtPacking.Rows(j).Item(1)) Then
                '        taxVal = taxVal + Convert.ToDecimal(dtPacking.Rows(j).Item(0))
                '        cgstAmnt = cgstAmnt + Convert.ToDecimal(dtPacking.Rows(j).Item(2))
                '        sgstAmnt = sgstAmnt + Convert.ToDecimal(dtPacking.Rows(j).Item(4))
                '    End If
                'Next


                taxableVal.Borders = BorderSide.Bottom Or BorderSide.Left
                taxableVal.TextAlignment = TextAlignment.MiddleRight
                taxableVal.Text = Math.Round(taxVal, 2).ToString("F2")
                taxableVal.WidthF = 160

                igstRate.Text = list1.Item(i).ToString() + "%"
                igstRate.Borders = BorderSide.Bottom Or BorderSide.Left
                igstRate.TextAlignment = TextAlignment.MiddleRight
                igstRate.WidthF = 158.73
                igstAmt.Text = Math.Round(igstAmnt, 2).ToString("F2")
                igstAmt.Borders = BorderSide.Bottom Or BorderSide.Left
                igstAmt.TextAlignment = TextAlignment.MiddleRight
                igstAmt.WidthF = 154.82

                row.Cells.Add(taxableVal)
                row.Cells.Add(igstRate)
                row.Cells.Add(igstAmt)

                'row.Borders = BorderSide.All
                XrTable3.Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub XrTable1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable1.BeforePrint
        Dim i, j, diff As Integer
        i = XrTable1.Rows.Count
        j = XrTable3.Rows.Count
        If i <> j Then
            diff = j - i
            Dim k As Integer

            For k = 1 To diff - 1
                Dim row As New DevExpress.XtraReports.UI.XRTableRow()

                row.Borders = BorderSide.Bottom
                XrTable1.Rows.Add(row)
            Next

        End If
    End Sub

    'Private Sub XrTable2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs)

    'End Sub

    Private Sub XrTable4_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrTable4.BeforePrint
        Dim daCgst As OleDbDataAdapter
        Dim dtCgst As New DataTable
        Dim sqlCgst As String
        sqlCgst = "SELECT ProductName, Description, HSNACS, UOM, Qty, Rate, Amount, Discount, TaxableValue, IGSTRate, IGSTAmt, TotalAmount from QuotationDetail Where QuotationID = " + Invoice.Value.ToString()
        Try
            daCgst = New OleDbDataAdapter(sqlCgst, ConStr)
            daCgst.Fill(dtCgst)

            For i = 0 To dtCgst.Rows.Count - 1
                Dim RefVal As Integer
                RefVal = i + 1
                Dim row As New DevExpress.XtraReports.UI.XRTableRow()
                Dim Ref As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Prod As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Hsn As New DevExpress.XtraReports.UI.XRTableCell()
                Dim UOM As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Qty As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Rate As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Amt As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Dis As New DevExpress.XtraReports.UI.XRTableCell()
                Dim TaxVal As New DevExpress.XtraReports.UI.XRTableCell()
                Dim igstRate As New DevExpress.XtraReports.UI.XRTableCell()
                Dim igstAmt As New DevExpress.XtraReports.UI.XRTableCell()
                Dim Total As New DevExpress.XtraReports.UI.XRTableCell()

                Ref.Borders = BorderSide.Left Or BorderSide.Bottom Or BorderSide.Top
                Ref.TextAlignment = TextAlignment.MiddleCenter
                Ref.Text = RefVal.ToString()
                Ref.WidthF = 27.42

                If (dtCgst.Rows(i).Item(1) Is DBNull.Value) Then
                    Prod.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Prod.TextAlignment = TextAlignment.MiddleLeft
                    Prod.Padding = (2)
                    Prod.Text = dtCgst.Rows(i).Item(0).ToString()
                    Prod.WidthF = 148.06
                Else
                    Prod.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Prod.TextAlignment = TextAlignment.MiddleLeft
                    Prod.Padding = (2)
                    Prod.Text = dtCgst.Rows(i).Item(0).ToString() & Environment.NewLine & dtCgst.Rows(i).Item(1).ToString()
                    Prod.Multiline = True
                    Prod.WidthF = 148.06
                End If

                Hsn.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Hsn.TextAlignment = TextAlignment.MiddleCenter
                Hsn.Text = dtCgst.Rows(i).Item(2).ToString()
                Hsn.WidthF = 48.29

                UOM.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                UOM.TextAlignment = TextAlignment.MiddleCenter
                UOM.Padding = (2)
                UOM.Text = dtCgst.Rows(i).Item(3).ToString()
                UOM.WidthF = 30.68

                Qty.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Qty.TextAlignment = TextAlignment.MiddleCenter
                Qty.Text = dtCgst.Rows(i).Item(4).ToString()
                Qty.WidthF = 31.31

                Rate.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim rte As Decimal
                rte = Convert.ToDecimal(dtCgst.Rows(i).Item(5))
                Rate.Text = Math.Round(rte, 2).ToString("F2")
                Rate.TextAlignment = TextAlignment.MiddleRight
                Rate.WidthF = 55.84

                Amt.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim amount As Decimal
                amount = Convert.ToDecimal(dtCgst.Rows(i).Item(6))
                Amt.Text = Math.Round(amount, 2).ToString("F2")
                Amt.TextAlignment = TextAlignment.MiddleRight
                Amt.WidthF = 77.8

                If (dtCgst.Rows(i).Item(7) Is DBNull.Value) Then
                    Dis.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Dis.TextAlignment = TextAlignment.MiddleRight
                    Dis.Text = dtCgst.Rows(i).Item(7).ToString()
                    Dis.WidthF = 54.14
                Else
                    Dis.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                    Dim discount As Decimal
                    discount = Convert.ToDecimal(dtCgst.Rows(i).Item(7))
                    Dis.Text = Math.Round(discount, 2).ToString("F2")
                    Dis.TextAlignment = TextAlignment.MiddleRight
                    Dis.WidthF = 54.14
                End If

                TaxVal.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim taxableVal As Decimal
                taxableVal = Convert.ToDecimal(dtCgst.Rows(i).Item(8))
                TaxVal.Text = Math.Round(taxableVal, 2).ToString("F2")
                TaxVal.TextAlignment = TextAlignment.MiddleRight
                TaxVal.WidthF = 104.87

                igstRate.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                igstRate.Text = dtCgst.Rows(i).Item(9).ToString() + "%"
                igstRate.TextAlignment = TextAlignment.MiddleRight
                igstRate.WidthF = 31.15

                igstAmt.Borders = BorderSide.Bottom Or BorderSide.Top Or BorderSide.Left
                Dim iamt As Decimal
                iamt = Convert.ToDecimal(dtCgst.Rows(i).Item(10))
                igstAmt.Text = Math.Round(iamt, 2).ToString("F2")
                igstAmt.TextAlignment = TextAlignment.MiddleRight
                igstAmt.WidthF = 70.8

                Total.Borders = BorderSide.All
                Dim ttl As Decimal
                ttl = Convert.ToDecimal(dtCgst.Rows(i).Item(11))
                Total.Text = Math.Round(ttl, 2).ToString("F2")
                Total.TextAlignment = TextAlignment.MiddleRight
                Total.WidthF = 97.64

                row.Cells.Add(Ref)
                row.Cells.Add(Prod)
                row.Cells.Add(Hsn)
                row.Cells.Add(UOM)
                row.Cells.Add(Qty)
                row.Cells.Add(Rate)
                row.Cells.Add(Amt)
                row.Cells.Add(Dis)
                row.Cells.Add(TaxVal)
                row.Cells.Add(igstRate)
                row.Cells.Add(igstAmt)
                row.Cells.Add(Total)
                'row.Borders = BorderSide.All
                XrTable4.Rows.Add(row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TermsXrTable_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TermsXrTable.BeforePrint
        Dim daTerms As OleDbDataAdapter
        Dim dtTerms As New DataTable
        Dim sqlTerms As String
        sqlTerms = "Select PackingCharge,IsGST,DeliveryTime,NewFOR,PaymentTerm,Warranty,Validity From Quotation Where QuotationID = " + Invoice.Value.ToString()

        daTerms = New OleDbDataAdapter(sqlTerms, ConStr)
        daTerms.Fill(dtTerms)

        Dim chkGST = Convert.ToBoolean(dtTerms.Rows(0).Item("IsGST"))
        If Not (dtTerms.Rows(0).Item(0) Is DBNull.Value) And Not (dtTerms.Rows(0).Item(0) Is "") Then
            Dim PCRow As New XRTableRow()
            Dim PCLbl As New XRTableCell()
            Dim Cln As New XRTableCell()
            Dim PCVal As New XRTableCell()

            If chkGST = True Then
                PCLbl.Borders = BorderSide.Left
                PCLbl.TextAlignment = TextAlignment.MiddleLeft
                PCLbl.Padding = (2)
                PCLbl.Text = " * Packing Charge "
                PCLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
                PCLbl.WidthF = 70.25
                'Cln.Borders = BorderSide.Bottom
                Cln.TextAlignment = TextAlignment.MiddleLeft
                Cln.Padding = (2)
                Cln.Text = " : "
                Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
                Cln.WidthF = 12
                PCVal.Borders = BorderSide.Right
                PCVal.TextAlignment = TextAlignment.MiddleLeft
                PCVal.Padding = (2)
                PCVal.Text = dtTerms.Rows(0).Item("PackingCharge").ToString + " + GST" & Environment.NewLine
                PCVal.WidthF = 384.22
                PCRow.Cells.Add(PCLbl)
                PCRow.Cells.Add(Cln)
                PCRow.Cells.Add(PCVal)
            Else
                PCLbl.Borders = BorderSide.Left
                PCLbl.TextAlignment = TextAlignment.MiddleLeft
                PCLbl.Padding = (2)
                PCLbl.Text = " * Packing Charge "
                PCLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
                PCLbl.WidthF = 70.25
                'Cln.Borders = BorderSide.Bottom
                Cln.TextAlignment = TextAlignment.MiddleLeft
                Cln.Padding = (2)
                Cln.Text = " : "
                Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
                Cln.WidthF = 12
                PCVal.Borders = BorderSide.Right
                PCVal.TextAlignment = TextAlignment.MiddleLeft
                PCVal.Padding = (2)
                PCVal.Text = dtTerms.Rows(0).Item("PackingCharge").ToString & Environment.NewLine
                PCVal.WidthF = 384.22
                PCRow.Cells.Add(PCLbl)
                PCRow.Cells.Add(Cln)
                PCRow.Cells.Add(PCVal)
            End If
            TermsXrTable.Rows.Add(PCRow)
        End If
        If Not (dtTerms.Rows(0).Item(2) Is DBNull.Value) And Not (dtTerms.Rows(0).Item(2) Is "") Then
            Dim DTRow As New XRTableRow()
            Dim DTLbl As New XRTableCell()
            Dim Cln As New XRTableCell()
            Dim DTVal As New XRTableCell()
            DTLbl.Borders = BorderSide.Left
            DTLbl.TextAlignment = TextAlignment.MiddleLeft
            DTLbl.Padding = (2)
            DTLbl.Text = " * Delivery Time "
            DTLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
            DTLbl.WidthF = 70.25
            'Cln.Borders = BorderSide.Bottom
            Cln.TextAlignment = TextAlignment.MiddleLeft
            Cln.Padding = (2)
            Cln.Text = " : "
            Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
            Cln.WidthF = 12
            DTVal.Borders = BorderSide.Right
            DTVal.TextAlignment = TextAlignment.MiddleLeft
            DTVal.Padding = (2)
            DTVal.Text = dtTerms.Rows(0).Item("DeliveryTime").ToString & Environment.NewLine
            DTVal.WidthF = 384.22
            DTRow.Cells.Add(DTLbl)
            DTRow.Cells.Add(Cln)
            DTRow.Cells.Add(DTVal)
            TermsXrTable.Rows.Add(DTRow)
        End If
        If Not (dtTerms.Rows(0).Item(3) Is DBNull.Value) And Not (dtTerms.Rows(0).Item(3) Is "") Then
            Dim FORRow As New XRTableRow()
            Dim FORLbl As New XRTableCell()
            Dim Cln As New XRTableCell()
            Dim FORVal As New XRTableCell()
            FORLbl.Borders = BorderSide.Left
            FORLbl.TextAlignment = TextAlignment.MiddleLeft
            FORLbl.Padding = (2)
            FORLbl.Text = " * F.O.R "
            FORLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
            FORLbl.WidthF = 70.25
            'Cln.Borders = BorderSide.Bottom
            Cln.TextAlignment = TextAlignment.MiddleLeft
            Cln.Padding = (2)
            Cln.Text = " : "
            Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
            Cln.WidthF = 12
            FORVal.Borders = BorderSide.Right
            FORVal.TextAlignment = TextAlignment.MiddleLeft
            FORVal.Padding = (2)
            FORVal.Text = dtTerms.Rows(0).Item("NewFOR").ToString & Environment.NewLine
            FORVal.WidthF = 384.22
            FORRow.Cells.Add(FORLbl)
            FORRow.Cells.Add(Cln)
            FORRow.Cells.Add(FORVal)
            TermsXrTable.Rows.Add(FORRow)
        End If
        If Not (dtTerms.Rows(0).Item(4) Is DBNull.Value) And Not (dtTerms.Rows(0).Item(4) Is "") Then
            Dim PTRow As New XRTableRow()
            Dim PTLbl As New XRTableCell()
            Dim Cln As New XRTableCell()
            Dim PTVal As New XRTableCell()
            PTLbl.Borders = BorderSide.Left
            PTLbl.TextAlignment = TextAlignment.MiddleLeft
            PTLbl.Padding = (2)
            PTLbl.Text = " * Payment Term "
            PTLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
            PTLbl.WidthF = 70.25
            'Cln.Borders = BorderSide.Bottom
            Cln.TextAlignment = TextAlignment.MiddleLeft
            Cln.Padding = (2)
            Cln.Text = " : "
            Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
            Cln.WidthF = 12
            PTVal.Borders = BorderSide.Right
            PTVal.TextAlignment = TextAlignment.MiddleLeft
            PTVal.Padding = (2)
            PTVal.Text = dtTerms.Rows(0).Item("PaymentTerm").ToString & Environment.NewLine
            PTVal.WidthF = 384.22
            PTRow.Cells.Add(PTLbl)
            PTRow.Cells.Add(Cln)
            PTRow.Cells.Add(PTVal)
            TermsXrTable.Rows.Add(PTRow)
        End If
        If Not (dtTerms.Rows(0).Item(5) Is DBNull.Value) And Not (dtTerms.Rows(0).Item(5) Is "") Then
            Dim WRow As New XRTableRow()
            Dim WLbl As New XRTableCell()
            Dim Cln As New XRTableCell()
            Dim WVal As New XRTableCell()
            WLbl.Borders = BorderSide.Left
            WLbl.TextAlignment = TextAlignment.MiddleLeft
            WLbl.Padding = (2)
            WLbl.Text = " * Warranty "
            WLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
            WLbl.WidthF = 70.25
            'Cln.Borders = BorderSide.Bottom
            Cln.TextAlignment = TextAlignment.MiddleLeft
            Cln.Padding = (2)
            Cln.Text = " : "
            Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
            Cln.WidthF = 12
            WVal.Borders = BorderSide.Right
            WVal.TextAlignment = TextAlignment.MiddleLeft
            WVal.Padding = (2)
            WVal.Text = dtTerms.Rows(0).Item("Warranty").ToString & Environment.NewLine
            WVal.WidthF = 384.22
            WRow.Cells.Add(WLbl)
            WRow.Cells.Add(Cln)
            WRow.Cells.Add(WVal)
            TermsXrTable.Rows.Add(WRow)
        End If
        If Not (dtTerms.Rows(0).Item(6) Is DBNull.Value) And Not (dtTerms.Rows(0).Item(6) Is "") Then
            Dim VRow As New XRTableRow()
            Dim VLbl As New XRTableCell()
            Dim Cln As New XRTableCell()
            Dim VVal As New XRTableCell()
            VLbl.Borders = BorderSide.Bottom Or BorderSide.Left
            VLbl.TextAlignment = TextAlignment.MiddleLeft
            VLbl.Padding = (2)
            VLbl.Text = " * Validity "
            VLbl.Font = New Font("Calibri", 10, FontStyle.Bold)
            VLbl.WidthF = 70.25
            Cln.Borders = BorderSide.Bottom
            Cln.TextAlignment = TextAlignment.MiddleLeft
            Cln.Padding = (2)
            Cln.Text = " : "
            Cln.Font = New Font("Calibri", 10, FontStyle.Bold)
            Cln.WidthF = 12
            VVal.Borders = BorderSide.Bottom Or BorderSide.Right
            VVal.TextAlignment = TextAlignment.MiddleLeft
            VVal.Padding = (2)
            VVal.Text = dtTerms.Rows(0).Item("Validity").ToString & Environment.NewLine
            VVal.WidthF = 384.22
            VRow.Cells.Add(VLbl)
            VRow.Cells.Add(Cln)
            VRow.Cells.Add(VVal)
            TermsXrTable.Rows.Add(VRow)
        End If
    End Sub
End Class