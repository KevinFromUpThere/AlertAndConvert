<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListFiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListFiles))
        Me.lstFiles = New System.Windows.Forms.ListBox
        Me.lstvwFiles = New System.Windows.Forms.ListView
        Me.FileName = New System.Windows.Forms.ColumnHeader
        Me.Status = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'lstFiles
        '
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.Location = New System.Drawing.Point(1, 2)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(461, 212)
        Me.lstFiles.TabIndex = 0
        '
        'lstvwFiles
        '
        Me.lstvwFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileName, Me.Status})
        Me.lstvwFiles.Location = New System.Drawing.Point(1, 113)
        Me.lstvwFiles.Name = "lstvwFiles"
        Me.lstvwFiles.Size = New System.Drawing.Size(461, 106)
        Me.lstvwFiles.TabIndex = 1
        Me.lstvwFiles.UseCompatibleStateImageBehavior = False
        Me.lstvwFiles.Visible = False
        '
        'Status
        '
        Me.Status.Width = 10
        '
        'frmListFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 250)
        Me.Controls.Add(Me.lstvwFiles)
        Me.Controls.Add(Me.lstFiles)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListFiles"
        Me.Text = "ListFiles"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstFiles As System.Windows.Forms.ListBox
    Friend WithEvents lstvwFiles As System.Windows.Forms.ListView
    Friend WithEvents FileName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
End Class
