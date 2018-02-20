Public Class frmAbout

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=karchibald%40gmail%2ecom&lc=US&item_name=Kevs%20Software&item_number=alertandconvert&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHostedGuest")
    End Sub

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblVersionInfo.Text = "Version " & MainCode.GetVersion
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'http://pixeladdiction.co.uk/alertconvert
        System.Diagnostics.Process.Start("http://pixeladdiction.co.uk/alertconvert")
    End Sub

    Private Sub lblVersionInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVersionInfo.Click

    End Sub
End Class