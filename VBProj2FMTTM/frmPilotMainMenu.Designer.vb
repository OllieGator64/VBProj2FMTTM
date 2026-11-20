<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPilotMainMenu
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
        Me.btnShowFlights = New System.Windows.Forms.Button()
        Me.btnUpdateCustomer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowFlights
        '
        Me.btnShowFlights.Location = New System.Drawing.Point(12, 166)
        Me.btnShowFlights.Name = "btnShowFlights"
        Me.btnShowFlights.Size = New System.Drawing.Size(776, 118)
        Me.btnShowFlights.TabIndex = 5
        Me.btnShowFlights.Text = "Show Flights"
        Me.btnShowFlights.UseVisualStyleBackColor = True
        '
        'btnUpdateCustomer
        '
        Me.btnUpdateCustomer.Location = New System.Drawing.Point(12, 12)
        Me.btnUpdateCustomer.Name = "btnUpdateCustomer"
        Me.btnUpdateCustomer.Size = New System.Drawing.Size(776, 118)
        Me.btnUpdateCustomer.TabIndex = 6
        Me.btnUpdateCustomer.Text = "Update Pilot"
        Me.btnUpdateCustomer.UseVisualStyleBackColor = True
        '
        'frmPilotMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 298)
        Me.Controls.Add(Me.btnUpdateCustomer)
        Me.Controls.Add(Me.btnShowFlights)
        Me.Name = "frmPilotMainMenu"
        Me.Text = "frmPilotMainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShowFlights As Button
    Friend WithEvents btnUpdateCustomer As Button
End Class
