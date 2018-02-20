Public Class frmListFiles

    Private Sub frmListFiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        lstFiles.MultiColumn = True


    End Sub





    Private Sub frmListFiles_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        lstFiles.Width = Me.Width - 10
    End Sub
End Class