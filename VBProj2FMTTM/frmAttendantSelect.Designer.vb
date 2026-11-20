<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantSelect
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
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.cboAttendant = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(12, 71)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(242, 23)
        Me.btnSelect.TabIndex = 8
        Me.btnSelect.Text = "Select Attendant"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'cboAttendant
        '
        Me.cboAttendant.FormattingEnabled = True
        Me.cboAttendant.Location = New System.Drawing.Point(12, 12)
        Me.cboAttendant.Name = "cboAttendant"
        Me.cboAttendant.Size = New System.Drawing.Size(242, 24)
        Me.cboAttendant.TabIndex = 7
        '
        'frmAttendantSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 104)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.cboAttendant)
        Me.Name = "frmAttendantSelect"
        Me.Text = "frmAttendantSelect"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelect As Button
    Friend WithEvents cboAttendant As ComboBox
End Class
