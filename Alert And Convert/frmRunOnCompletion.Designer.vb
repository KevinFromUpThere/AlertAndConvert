<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRunOnCompletion
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
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.grpAfterEach = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRunAfterEachFile = New System.Windows.Forms.TextBox
        Me.grpAfterAll = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRunAfterALLFiles = New System.Windows.Forms.TextBox
        Me.chkRunOnCompletion = New System.Windows.Forms.CheckBox
        Me.grpAfterEach.SuspendLayout()
        Me.grpAfterAll.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(443, 202)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "OK"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(524, 202)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpAfterEach
        '
        Me.grpAfterEach.Controls.Add(Me.Label1)
        Me.grpAfterEach.Controls.Add(Me.txtRunAfterEachFile)
        Me.grpAfterEach.Location = New System.Drawing.Point(12, 43)
        Me.grpAfterEach.Name = "grpAfterEach"
        Me.grpAfterEach.Size = New System.Drawing.Size(587, 70)
        Me.grpAfterEach.TabIndex = 2
        Me.grpAfterEach.TabStop = False
        Me.grpAfterEach.Text = "Run After Each File"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Command string to run after each file is completed. (%s = SourceFile, %d = most r" & _
            "ecently created file, %f = folder )"
        '
        'txtRunAfterEachFile
        '
        Me.txtRunAfterEachFile.Location = New System.Drawing.Point(7, 38)
        Me.txtRunAfterEachFile.Name = "txtRunAfterEachFile"
        Me.txtRunAfterEachFile.Size = New System.Drawing.Size(562, 20)
        Me.txtRunAfterEachFile.TabIndex = 0
        '
        'grpAfterAll
        '
        Me.grpAfterAll.Controls.Add(Me.Label2)
        Me.grpAfterAll.Controls.Add(Me.txtRunAfterALLFiles)
        Me.grpAfterAll.Location = New System.Drawing.Point(12, 119)
        Me.grpAfterAll.Name = "grpAfterAll"
        Me.grpAfterAll.Size = New System.Drawing.Size(587, 70)
        Me.grpAfterAll.TabIndex = 3
        Me.grpAfterAll.TabStop = False
        Me.grpAfterAll.Text = "Run After EVERYTHING Else Has"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Command string to run after ALL files have been completed. (%f = Source folder)"
        '
        'txtRunAfterALLFiles
        '
        Me.txtRunAfterALLFiles.Location = New System.Drawing.Point(6, 44)
        Me.txtRunAfterALLFiles.Name = "txtRunAfterALLFiles"
        Me.txtRunAfterALLFiles.Size = New System.Drawing.Size(562, 20)
        Me.txtRunAfterALLFiles.TabIndex = 1
        '
        'chkRunOnCompletion
        '
        Me.chkRunOnCompletion.AutoSize = True
        Me.chkRunOnCompletion.Location = New System.Drawing.Point(12, 12)
        Me.chkRunOnCompletion.Name = "chkRunOnCompletion"
        Me.chkRunOnCompletion.Size = New System.Drawing.Size(243, 17)
        Me.chkRunOnCompletion.TabIndex = 4
        Me.chkRunOnCompletion.Text = "Run Processes On Completion of Conversions"
        Me.chkRunOnCompletion.UseVisualStyleBackColor = True
        '
        'frmRunOnCompletion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 237)
        Me.Controls.Add(Me.chkRunOnCompletion)
        Me.Controls.Add(Me.grpAfterAll)
        Me.Controls.Add(Me.grpAfterEach)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmRunOnCompletion"
        Me.Text = "Run on Competion"
        Me.grpAfterEach.ResumeLayout(False)
        Me.grpAfterEach.PerformLayout()
        Me.grpAfterAll.ResumeLayout(False)
        Me.grpAfterAll.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpAfterEach As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRunAfterEachFile As System.Windows.Forms.TextBox
    Friend WithEvents grpAfterAll As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRunAfterALLFiles As System.Windows.Forms.TextBox
    Friend WithEvents chkRunOnCompletion As System.Windows.Forms.CheckBox
End Class
