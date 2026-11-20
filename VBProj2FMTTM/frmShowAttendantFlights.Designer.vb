<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowAttendantFlights
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
        Me.lblTotalMiles = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstAttendantFlight = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblTotalMiles
        '
        Me.lblTotalMiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalMiles.Location = New System.Drawing.Point(60, 8)
        Me.lblTotalMiles.Name = "lblTotalMiles"
        Me.lblTotalMiles.Size = New System.Drawing.Size(211, 23)
        Me.lblTotalMiles.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Miles:"
        '
        'lstAttendantFlight
        '
        Me.lstAttendantFlight.FormattingEnabled = True
        Me.lstAttendantFlight.ItemHeight = 16
        Me.lstAttendantFlight.Location = New System.Drawing.Point(277, 9)
        Me.lstAttendantFlight.Name = "lstAttendantFlight"
        Me.lstAttendantFlight.Size = New System.Drawing.Size(279, 420)
        Me.lstAttendantFlight.TabIndex = 3
        '
        'frmShowAttendantFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 450)
        Me.Controls.Add(Me.lblTotalMiles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAttendantFlight)
        Me.Name = "frmShowAttendantFlights"
        Me.Text = "frmShowAttendantFlights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalMiles As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstAttendantFlight As ListBox
End Class
