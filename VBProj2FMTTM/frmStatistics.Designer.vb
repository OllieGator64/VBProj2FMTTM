<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatistics
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalCustomers = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFlightsTaken = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAverageMiles = New System.Windows.Forms.Label()
        Me.lstAttendantMiles = New System.Windows.Forms.ListBox()
        Me.lstPilotMiles = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total # Of Customers:"
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCustomers.Location = New System.Drawing.Point(232, 9)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = New System.Drawing.Size(149, 23)
        Me.lblTotalCustomers.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Flights Taken by Customers:"
        '
        'lblFlightsTaken
        '
        Me.lblFlightsTaken.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFlightsTaken.Location = New System.Drawing.Point(232, 32)
        Me.lblFlightsTaken.Name = "lblFlightsTaken"
        Me.lblFlightsTaken.Size = New System.Drawing.Size(149, 23)
        Me.lblFlightsTaken.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Average Miles Flown:"
        '
        'lblAverageMiles
        '
        Me.lblAverageMiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageMiles.Location = New System.Drawing.Point(232, 55)
        Me.lblAverageMiles.Name = "lblAverageMiles"
        Me.lblAverageMiles.Size = New System.Drawing.Size(149, 23)
        Me.lblAverageMiles.TabIndex = 5
        '
        'lstAttendantMiles
        '
        Me.lstAttendantMiles.FormattingEnabled = True
        Me.lstAttendantMiles.ItemHeight = 16
        Me.lstAttendantMiles.Location = New System.Drawing.Point(387, 98)
        Me.lstAttendantMiles.Name = "lstAttendantMiles"
        Me.lstAttendantMiles.Size = New System.Drawing.Size(401, 340)
        Me.lstAttendantMiles.TabIndex = 6
        '
        'lstPilotMiles
        '
        Me.lstPilotMiles.FormattingEnabled = True
        Me.lstPilotMiles.ItemHeight = 16
        Me.lstPilotMiles.Location = New System.Drawing.Point(15, 98)
        Me.lstPilotMiles.Name = "lstPilotMiles"
        Me.lstPilotMiles.Size = New System.Drawing.Size(366, 340)
        Me.lstPilotMiles.TabIndex = 7
        '
        'frmStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstPilotMiles)
        Me.Controls.Add(Me.lstAttendantMiles)
        Me.Controls.Add(Me.lblAverageMiles)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFlightsTaken)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalCustomers)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStatistics"
        Me.Text = "frmStatistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalCustomers As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFlightsTaken As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAverageMiles As Label
    Friend WithEvents lstAttendantMiles As ListBox
    Friend WithEvents lstPilotMiles As ListBox
End Class
