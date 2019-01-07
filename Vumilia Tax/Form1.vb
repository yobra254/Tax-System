Public Class FrmAdvancedTax

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub FrmAdvancedTax_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbltax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltax.Click

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'txtPaye.Text = 0.1 * Val(txtGross.Text)
        'txtNet.Text = Val(txtGross) - (7000 + Val(txtPaye))
        'txtPaye = 0.1 * Val(txtGross.Text)
        'txtNet = Val(txtGross.Text) - num1
        'Dim discountPercent, diff, DiscountAmount As Double

        ' Dim num1, payy, grosss, deff As Double
        'num1 = Val(txtGross.Text)

        'If num1 <= 10000 Then
        'payy = 0
        'ElseIf num1 >= 10001 Then
        'grosss = num1 - 10000
        'If grosss < 12299 Then
        'payy = grosss * 0.1
        'ElseIf grosss < 23866 Then
        'deff = grosss - 12298
        'payy = (deff * 0.15) + (12298 * 0.1)
        'ElseIf grosss < 35473 Then
        'deff = grosss - 35472
        'payy = (deff * 0.2) + (23885 * 0.15) + (12298 * 0.1)
        'ElseIf grosss < 47060 Then
        'deff = grosss - 47059
        'payy = (deff * 0.25) + (35472 * 0.2) + (23885 * 0.15) + (12298 * 0.1)
        'ElseIf grosss > 47059 Then
        'deff = grosss - 47059
        'payy = (deff * 0.3) + (47059 * 0.25) + (35472 * 0.2) + (23885 * 0.15) + (12298 * 0.1)
        'End If

        'End If



        Dim grosspay, paye, diff, grosspaid As Double

        grosspay = Val(txtGross.Text)
        If grosspay < 10001 Then
            paye = 0

        ElseIf grosspay > 10000 Then
            grosspaid = grosspay - 10000

            Select Case grosspaid
                Case 0 To 12299
                    paye = grosspaid * 0.1
                Case 12299 To 23886
                    diff = grosspaid - 12298
                    paye = (diff * 0.15) + (12298 * 0.1)
                Case 23886 To 35473
                    diff = grosspaid - 35472
                    paye = (diff * 0.2) + (12298 * 0.1) + (11587 * 0.2)
                Case 35473 To 47059
                    diff = grosspaid - 47059
                    paye = (diff * 0.25) + (11587 * 0.2) + (11587 * 0.15) + (12298 * 0.1)
                Case 47061 To 100000000
                    diff = grosspaid - 47059
                    paye = (diff * 0.3) + (12298 * 0.1) + (11587 * 0.15) + (11587 * 0.2) + (11587 * 0.25)
                Case Else
                    MsgBox("enter valid pay please")


            End Select
        End If


        Dim Net As Double = txtGross.Text - (Val(paye) + Val(txtHelb.Text) + Val(txtSacco.Text))
        txtPaye.Text = Format(paye)
        txtNet.Text = (Net)

        ' txtDiscountPercent.Text = FormatPercent(discountPercent, 1)
        ' txtNet.Text = Val(txtGross.Text) - (Val(txtPaye.Text) + Val(txtHelb.Text) + Val(txtSacco.Text))
        'MessageBox.Show("Still In Progress", "Endelea Kuvumilia")



    End Sub

    Private Sub txtPaye_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaye.TextChanged

    End Sub

    Private Sub txtGross_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGross.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnquit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquit.Click
        If MsgBox("Are You Sure You Want To Exit This Awesome System!!!!!", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If

    End Sub

    Private Sub RbFemale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbFemale.Click
        BackColor = Color.Pink
    End Sub

    Private Sub RbMale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbMale.Click
        BackColor = Color.Blue
    End Sub

    Private Sub txtNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        txtNumber.Clear()
        txtName.Clear()
        txtGross.Clear()
        txtHelb.Clear()
        txtSacco.Clear()
        txtPaye.Clear()
        txtNet.Clear()

    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumber.TextChanged

    End Sub

    Private Sub RbFemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbFemale.CheckedChanged

    End Sub
End Class
