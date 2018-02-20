Public Class frmRunOnCompletion

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        MainCode.RegWrite("strRunAfterEachFile", txtRunAfterEachFile.Text)
        MainCode.RegWrite("strRunAfterAllFiles", txtRunAfterALLFiles.Text)
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub chkRunOnCompletion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRunOnCompletion.CheckedChanged
        If chkRunOnCompletion.CheckState = CheckState.Checked Then
            MainCode.RegWrite("flgRunOnCompletion", "1")
            grpAfterEach.Enabled = True
            grpAfterAll.Enabled = True
        Else
            MainCode.RegWrite("flgRunOnCompletion", "0")
            grpAfterEach.Enabled = False
            grpAfterAll.Enabled = False
        End If
    End Sub

    Private Sub frmRunOnCompletion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If MainCode.RegRead("flgRunOnCompletion") = 1 Then
            chkRunOnCompletion.CheckState = CheckState.Checked
            grpAfterEach.Enabled = True
            grpAfterAll.Enabled = True
        Else
            chkRunOnCompletion.CheckState = CheckState.Unchecked
            grpAfterEach.Enabled = False
            grpAfterAll.Enabled = False
        End If
        txtRunAfterALLFiles.Text = MainCode.RegRead("strRunAfterAllFiles")
        txtRunAfterEachFile.Text = MainCode.RegRead("strRunAfterEachFile")

    End Sub
End Class