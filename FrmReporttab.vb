Public Class FrmReporttab
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbldatefrom.Click

    End Sub



    Private Sub FrmReporttab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Frmmainpage


        cmbReportType.Items.Clear()
        cmbReportType.Items.Add("Stock Status Report")
        cmbReportType.Items.Add("Dispensing History Report")
        cmbReportType.Items.Add("Revenue Report")
        cmbReportType.Items.Add("Reorder List Report")

        'date retrisctions 
        dtpDateFrom.MaxDate = DateTime.Today
        dtpDateTo.MaxDate = DateTime.Today
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        generateReport()
    End Sub

    'creating sub for generate report
    Private Sub generateReport()
        Try

            'Clear any old red exclamation indicators immediately
            epgeneratereport.Clear()
            Dim isFormValid As Boolean = True

            'Validate Report Type Selection (Must have an item selected)
            If cmbReportType.SelectedIndex = -1 Then
                epgeneratereport.SetError(cmbReportType, "Please select a report type.")
                isFormValid = False
            End If

            'Validate Date Range Logic (Date To cannot be earlier than Date From)
            If dtpDateTo.Value.Date < dtpDateFrom.Value.Date Then
                epgeneratereport.SetError(dtpDateTo, "The 'Date To' cannot be earlier than the 'Date From'.")
                isFormValid = False
            End If

            'Block execution if validation fails
            If isFormValid = False Then
                MsgBox("Please, correct the highlighted selections before generating the report.", MsgBoxStyle.Exclamation, "Validation Error")
                Exit Sub ' Hard stop Prevents the report from processing.
            End If

            '''''''''''''''''''''''''''''

            ' Replace with this:
            Select Case cmbReportType.SelectedItem.ToString()

                Case "Stock Status Report"
                    ' Shows all stocked drugs and their current quantities
                    Dim result As String = "STOCK STATUS REPORT" & vbNewLine
                    result &= "─────────────────────────────────────────" & vbNewLine
                    result &= "Drug Name".PadRight(25) &
                              "Category".PadRight(15) &
                              "Stock".PadRight(8) &
                              "Reorder" & vbNewLine
                    result &= "─────────────────────────────────────────" & vbNewLine
                    For Each d As Modmainlog.Drug In Modmainlog.DrugList.Where(Function(x) x.IsStocked)
                        result &= d.Drugname.PadRight(25) &
                                  d.Category.PadRight(15) &
                                  d.CurrentStock.ToString().PadRight(8) &
                                  d.Reorderlevel.ToString() & vbNewLine
                    Next
                    MessageBox.Show(result, "Stock Status Report",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                Case "Dispensing History Report"
                    ' Shows prescriptions dispensed within the selected date range
                    Dim dispensed = Modmainlog.PrescriptionList.Where(
                        Function(p) p.status = "Dispensed" AndAlso
                                    p.DateSent.Date >= dtpDateFrom.Value.Date AndAlso
                                    p.DateSent.Date <= dtpDateTo.Value.Date).ToList()

                    If dispensed.Count = 0 Then
                        MsgBox("No dispensing records found for the selected date range.",
                               MsgBoxStyle.Information, "No Records")
                        Return
                    End If

                    Dim result As String = "DISPENSING HISTORY REPORT" & vbNewLine
                    result &= "From: " & dtpDateFrom.Value.ToString("dd/MM/yyyy") &
                              "   To: " & dtpDateTo.Value.ToString("dd/MM/yyyy") & vbNewLine
                    result &= "─────────────────────────────────────────" & vbNewLine
                    result &= "Patient".PadRight(20) &
                              "Drug".PadRight(20) &
                              "Date" & vbNewLine
                    result &= "─────────────────────────────────────────" & vbNewLine
                    For Each p As Modmainlog.Prescription In dispensed
                        result &= p.PatientName.PadRight(20) &
                                  p.DrugName.PadRight(20) &
                                  p.DateSent.ToString("dd/MM/yyyy HH:mm") & vbNewLine
                    Next
                    MessageBox.Show(result, "Dispensing History Report",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                Case "Revenue Report"
                    ' Shows total revenue — date range for context only
                    Dim result As String = "REVENUE REPORT" & vbNewLine
                    result &= "─────────────────────────────────────────" & vbNewLine
                    result &= "Total Revenue:   GHS " &
                              Modmainlog.TotalRevenue.ToString("F2") & vbNewLine
                    result &= "Total Dispensed: " &
                             Modmainlog.PrescriptionList.Where(
                           Function(p) p.status = "Dispensed").Count.ToString() &
                           " prescriptions" & vbNewLine
                    MessageBox.Show(result, "Revenue Report",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                Case "Reorder List Report"
                    ' Shows all drugs at or below reorder level — no date range needed
                    Dim lowDrugs As List(Of Modmainlog.Drug) = Modmainlog.GetLowStockDrugs()

                    If lowDrugs.Count = 0 Then
                        MsgBox("All drugs are sufficiently stocked. No reorder needed.",
                               MsgBoxStyle.Information, "Reorder List")
                        Return
                    End If

                    Dim result As String = "REORDER LIST REPORT" & vbNewLine
                    result &= "Generated: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm") & vbNewLine
                    result &= "─────────────────────────────────────────" & vbNewLine
                    result &= "Drug Name".PadRight(25) &
                              "Stock".PadRight(8) &
                              "Reorder".PadRight(10) &
                              "Shortage" & vbNewLine
                    result &= "─────────────────────────────────────────" & vbNewLine
                    For Each d As Modmainlog.Drug In lowDrugs
                        Dim shortage As Integer = d.Reorderlevel - d.CurrentStock
                        result &= d.Drugname.PadRight(25) &
                                  d.CurrentStock.ToString().PadRight(8) &
                                  d.Reorderlevel.ToString().PadRight(10) &
                                  shortage.ToString() & vbNewLine
                    Next
                    MessageBox.Show(result, "Reorder List Report",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Select


        Catch ex As Exception
            MessageBox.Show("An error occur during the input. Please, check your inputs again." & ex.Message,
                                       "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tlsgenerate.Click
        generateReport()
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged

        dtpDateTo.MinDate = dtpDateFrom.Value
    End Sub
End Class