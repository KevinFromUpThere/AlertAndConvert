Public Class frmTwitterDetails

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        RegWrite("strTwitterUserName", txtTwitterUserName.Text)
        If chkRememberPass.Checked = True Then
            RegWrite("strTwitterPassword", txtTwitterPassword.Text)
        Else
            RegWrite("strTwitterPassword", "XXX")
        End If
        Me.Hide()
        MainForm.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        MainForm.Focus()
    End Sub

    Private Sub frmTwitterDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        txtTwitterUserName.Text = RegRead("strTwitterUserName")
        If RegRead("strTwitterPassword") <> "XXX" Then
            txtTwitterPassword.Text = RegRead("strTwitterPassword")
        End If
    End Sub

    Private Sub txtTwitterUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTwitterUserName.TextChanged

    End Sub

    Private Sub txtTwitterPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTwitterPassword.TextChanged

    End Sub

    Private Sub chkRememberPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRememberPass.CheckedChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        MainForm.chkTwitter.Checked = True
        RegWrite("strTwitterUserName", txtTwitterUserName.Text)
        If chkRememberPass.Checked = True Then
            RegWrite("strTwitterPassword", txtTwitterPassword.Text)
        Else
            RegWrite("strTwitterPassword", "XXX")
        End If
        MainCode.Alert("Test ALERT & CONVERT Message " & Now().ToString)
        MsgBox("Test Sent")
    End Sub
End Class