<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmailDetails))
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkRememberPass = New System.Windows.Forms.CheckBox
        Me.txtEmailPassword = New System.Windows.Forms.TextBox
        Me.txtEmailUserName = New System.Windows.Forms.TextBox
        Me.btnTest = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSMTP = New System.Windows.Forms.TextBox
        Me.chkGmail = New System.Windows.Forms.CheckBox
        Me.lblGmailMsg = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(217, 235)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(136, 235)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "User Name"
        '
        'chkRememberPass
        '
        Me.chkRememberPass.AutoSize = True
        Me.chkRememberPass.Checked = True
        Me.chkRememberPass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRememberPass.Location = New System.Drawing.Point(36, 263)
        Me.chkRememberPass.Name = "chkRememberPass"
        Me.chkRememberPass.Size = New System.Drawing.Size(126, 17)
        Me.chkRememberPass.TabIndex = 9
        Me.chkRememberPass.Text = "Remember Password"
        Me.chkRememberPass.UseVisualStyleBackColor = True
        Me.chkRememberPass.Visible = False
        '
        'txtEmailPassword
        '
        Me.txtEmailPassword.Location = New System.Drawing.Point(100, 41)
        Me.txtEmailPassword.Name = "txtEmailPassword"
        Me.txtEmailPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEmailPassword.Size = New System.Drawing.Size(143, 20)
        Me.txtEmailPassword.TabIndex = 8
        '
        'txtEmailUserName
        '
        Me.txtEmailUserName.Location = New System.Drawing.Point(100, 15)
        Me.txtEmailUserName.Name = "txtEmailUserName"
        Me.txtEmailUserName.Size = New System.Drawing.Size(143, 20)
        Me.txtEmailUserName.TabIndex = 7
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(12, 234)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 15
        Me.btnTest.Text = "Test Email"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGmailMsg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSMTP)
        Me.GroupBox1.Controls.Add(Me.chkGmail)
        Me.GroupBox1.Controls.Add(Me.txtEmailPassword)
        Me.GroupBox1.Controls.Add(Me.txtEmailUserName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 216)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Email Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "port"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(99, 137)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(42, 20)
        Me.txtPort.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "smtp"
        '
        'txtSMTP
        '
        Me.txtSMTP.Location = New System.Drawing.Point(100, 111)
        Me.txtSMTP.Name = "txtSMTP"
        Me.txtSMTP.Size = New System.Drawing.Size(143, 20)
        Me.txtSMTP.TabIndex = 13
        '
        'chkGmail
        '
        Me.chkGmail.AutoSize = True
        Me.chkGmail.Location = New System.Drawing.Point(99, 88)
        Me.chkGmail.Name = "chkGmail"
        Me.chkGmail.Size = New System.Drawing.Size(87, 17)
        Me.chkGmail.TabIndex = 12
        Me.chkGmail.Text = "I Use GMAIL"
        Me.chkGmail.UseVisualStyleBackColor = True
        '
        'lblGmailMsg
        '
        Me.lblGmailMsg.AutoSize = True
        Me.lblGmailMsg.Location = New System.Drawing.Point(7, 175)
        Me.lblGmailMsg.Name = "lblGmailMsg"
        Me.lblGmailMsg.Size = New System.Drawing.Size(0, 13)
        Me.lblGmailMsg.TabIndex = 17
        '
        'frmEmailDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 268)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkRememberPass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmailDetails"
        Me.Text = "Email Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkRememberPass As System.Windows.Forms.CheckBox
    Friend WithEvents txtEmailPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailUserName As System.Windows.Forms.TextBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSMTP As System.Windows.Forms.TextBox
    Friend WithEvents chkGmail As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents lblGmailMsg As System.Windows.Forms.Label
End Class
