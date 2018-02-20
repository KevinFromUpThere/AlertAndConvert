Public Class Scheduler

    Private Sub Scheduler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        TimePicker.Format = DateTimePickerFormat.Time
        TimePicker.ShowUpDown = True
        TimePicker.Width = 100
        TimePicker.Value = Now
        TimePicker.Value = #1/1/2009 7:00:00 AM#

        Controls.Add(TimePicker)

        TimePicker2.Format = DateTimePickerFormat.Time
        TimePicker2.ShowUpDown = True
        TimePicker2.Width = 100
        Controls.Add(TimePicker2)
        TimePicker2.Value = #1/1/2009 11:00:00 PM#


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim StartTime As String
        Dim EndTime As String
        StartTime = TimePicker.Value.Hour.ToString & Microsoft.VisualBasic.Right("00" & TimePicker.Value.Minute.ToString, 2)
        EndTime = TimePicker2.Value.Hour.ToString & Microsoft.VisualBasic.Right("00" & TimePicker2.Value.Minute.ToString, 2)
        MainCode.RegWrite("ScheduleStart", StartTime)
        MainCode.RegWrite("ScheduleEnd", EndTime)
        MainForm.chkSchedule.Text = "No Conversions Between " & TimePicker.Value.Hour & " And " & TimePicker2.Value.Hour
        Me.Close()

    End Sub
End Class