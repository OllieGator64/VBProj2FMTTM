<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPilotSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.cboPilot = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(12, 70)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(242, 23)
        Me.btnSelect.TabIndex = 6
        Me.btnSelect.Text = "Select Pilot"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'cboPilot
        '
        Me.cboPilot.FormattingEnabled = True
        Me.cboPilot.Location = New System.Drawing.Point(12, 11)
        Me.cboPilot.Name = "cboPilot"
        Me.cboPilot.Size = New System.Drawing.Size(242, 24)
        Me.cboPilot.TabIndex = 5
        '
        'frmPilotSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 104)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.cboPilot)
        Me.Name = "frmPilotSelect"
        Me.Text = "frmPilotSelect"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelect As Button
    Friend WithEvents cboPilot As ComboBox
End Class
