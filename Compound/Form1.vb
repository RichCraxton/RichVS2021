Public Class Form1
    Private Sub Cond_compoundBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Cond_compoundBindingNavigatorSaveItem.Click
        Dim CompContinue As String = "Y"
        ChkData(CompContinue)
        If CompContinue = "Y" Then
            Me.Validate()
            Me.Cond_compoundBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ThermodbDataSet)
        End If

    End Sub
    Sub ChkData(ByRef CompContinue As String)
        If Part_numberTextBox.Text = "" Then
            MsgBox("Part Number can NOT be Blank, Save will Not Occur!!!!", vbCritical)
            CompContinue = "N"
        End If
        If Cp_noTextBox.Text = "" Then
            MsgBox("Compound Number can NOT be Blank, Save wil Not Occur!!!", vbCritical)
            CompContinue = "N"
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ThermodbDataSet.cond_compound' table. You can move, or remove it, as needed.
        Me.Cond_compoundTableAdapter.Fill(Me.ThermodbDataSet.cond_compound)

    End Sub

    Private Sub ObsoleteTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ObsoleteTextBox1.TextChanged
        If Not BindingNavigatorAddNewItem.Selected And Not Cond_compoundBindingNavigatorSaveItem.Selected Then
            If ObsoleteTextBox1.Text = "Y " Then
                ObsoleteTextBox1.Text = "OBSOLETED"
                ObsoleteTextBox1.BackColor = Color.Yellow
            End If
            If ObsoleteTextBox1.Text = "  " Then
                ObsoleteTextBox1.BackColor = Me.BackColor
                ObsoleteTextBox1.Text = "         "
            End If
        Else
            ObsoleteTextBox1.BackColor = Me.BackColor
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '  PrintDialog1.Document = PrintDocument1
        '  PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        '  PrintDialog1.AllowSomePages = True
        '  If PrintDialog1.ShowDialog = DialogResult.OK Then
        '  PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        '  PrintDocument1.Print()
        '  End If
        PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings
        Me.PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = CInt(0.1)
        Me.PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = CInt(0.1)
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)

    End Sub
End Class
