<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTwitterDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTwitterDetails))
        Me.txtTwitterUserName = New System.Windows.Forms.TextBox
        Me.txtTwitterPassword = New System.Windows.Forms.TextBox
        Me.chkRememberPass = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnTest = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtTwitterUserName
        '
        Me.txtTwitterUserName.Location = New System.Drawing.Point(80, 12)
        Me.txtTwitterUserName.Name = "txtTwitterUserName"
        Me.txtTwitterUserName.Size = New System.Drawing.Size(143, 20)
        Me.txtTwitterUserName.TabIndex = 0
        '
        'txtTwitterPassword
        '
        Me.txtTwitterPassword.Location = New System.Drawing.Point(80, 38)
        Me.txtTwitterPassword.Name = "txtTwitterPassword"
        Me.txtTwitterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtTwitterPassword.Size = New System.Drawing.Size(143, 20)
        Me.txtTwitterPassword.TabIndex = 1
        '
        'chkRememberPass
        '
        Me.chkRememberPass.AutoSize = True
        Me.chkRememberPass.Checked = True
        Me.chkRememberPass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRememberPass.Location = New System.Drawing.Point(80, 67)
        Me.chkRememberPass.Name = "chkRememberPass"
        Me.chkRememberPass.Size = New System.Drawing.Size(126, 17)
        Me.chkRememberPass.TabIndex = 2
        Me.chkRememberPass.Text = "Remember Password"
        Me.chkRememberPass.UseVisualStyleBackColor = True
        Me.chkRememberPass.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(67, 94)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(148, 94)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(7, 94)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(48, 23)
        Me.btnTest.TabIndex = 7
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'frmTwitterDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 126)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkRememberPass)
        Me.Controls.Add(Me.txtTwitterPassword)
        Me.Controls.Add(Me.txtTwitterUserName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTwitterDetails"
        Me.Text = "Twitter Login Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTwitterUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtTwitterPassword As System.Windows.Forms.TextBox
    Friend WithEvents chkRememberPass As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
End Class
