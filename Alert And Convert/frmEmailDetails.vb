Public Class frmEmailDetails

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        RegWrite("strEmailUserName", txtEmailUserName.Text)
        RegWrite("strEmailSMTP", txtSMTP.Text)
        RegWrite("strEmailPort", txtPort.Text)
        If chkRememberPass.Checked = True Then
            RegWrite("strEmailPassword", txtEmailPassword.Text)
        Else
            RegWrite("strEmailPassword", "XXX")
        End If
        Me.Hide()
        MainForm.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
        MainForm.Focus()
    End Sub

    Private Sub frmEmailDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        txtEmailUserName.Text = RegRead("strEmailUserName")
        If RegRead("strEmailPassword") <> "XXX" Then
            txtEmailPassword.Text = RegRead("strEmailPassword")
        End If
        txtPort.Text = RegRead("strEmailPort")
        txtSMTP.Text = RegRead("strEmailSMTP")
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        RegWrite("strEmailUserName", txtEmailUserName.Text)
        RegWrite("strEmailSMTP", txtSMTP.Text)
        RegWrite("strEmailPort", txtPort.Text)
        If chkRememberPass.Checked = True Then
            RegWrite("strEmailPassword", txtEmailPassword.Text)
        Else
            RegWrite("strEmailPassword", "XXX")
        End If
        MainForm.chkEmail.Checked = True
        MainCode.Alert("Testing ALERT & CONVERT " & Now())
    End Sub


    Private Sub chkGmail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGmail.CheckedChanged
        If chkGmail.Checked = True Then
            Me.txtSMTP.Text = "smtp.gmail.com"
            Me.txtPort.Text = "587"
            lblGmailMsg.Text = "Be sure your username has the full username@gmail.com"
        End If
    End Sub
End Class