<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantMainMenu
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
        Me.btnUpdateAttendant = New System.Windows.Forms.Button()
        Me.btnShowFlights = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUpdateAttendant
        '
        Me.btnUpdateAttendant.Location = New System.Drawing.Point(12, 13)
        Me.btnUpdateAttendant.Name = "btnUpdateAttendant"
        Me.btnUpdateAttendant.Size = New System.Drawing.Size(776, 118)
        Me.btnUpdateAttendant.TabIndex = 8
        Me.btnUpdateAttendant.Text = "Update Attendant"
        Me.btnUpdateAttendant.UseVisualStyleBackColor = True
        '
        'btnShowFlights
        '
        Me.btnShowFlights.Location = New System.Drawing.Point(12, 167)
        Me.btnShowFlights.Name = "btnShowFlights"
        Me.btnShowFlights.Size = New System.Drawing.Size(776, 118)
        Me.btnShowFlights.TabIndex = 7
        Me.btnShowFlights.Text = "Show Flights"
        Me.btnShowFlights.UseVisualStyleBackColor = True
        '
        'frmAttendantMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 298)
        Me.Controls.Add(Me.btnUpdateAttendant)
        Me.Controls.Add(Me.btnShowFlights)
        Me.Name = "frmAttendantMainMenu"
        Me.Text = "frmAttendantMainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdateAttendant As Button
    Friend WithEvents btnShowFlights As Button
End Class
