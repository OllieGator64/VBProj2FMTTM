<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerMainMenu
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
        Me.btnUpdateCustomer = New System.Windows.Forms.Button()
        Me.btnCustomerFlight = New System.Windows.Forms.Button()
        Me.btnShowFlights = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUpdateCustomer
        '
        Me.btnUpdateCustomer.Location = New System.Drawing.Point(12, 12)
        Me.btnUpdateCustomer.Name = "btnUpdateCustomer"
        Me.btnUpdateCustomer.Size = New System.Drawing.Size(776, 118)
        Me.btnUpdateCustomer.TabIndex = 1
        Me.btnUpdateCustomer.Text = "Update Customer"
        Me.btnUpdateCustomer.UseVisualStyleBackColor = True
        '
        'btnCustomerFlight
        '
        Me.btnCustomerFlight.Location = New System.Drawing.Point(12, 166)
        Me.btnCustomerFlight.Name = "btnCustomerFlight"
        Me.btnCustomerFlight.Size = New System.Drawing.Size(776, 118)
        Me.btnCustomerFlight.TabIndex = 2
        Me.btnCustomerFlight.Text = "Add Customer Flight"
        Me.btnCustomerFlight.UseVisualStyleBackColor = True
        '
        'btnShowFlights
        '
        Me.btnShowFlights.Location = New System.Drawing.Point(12, 320)
        Me.btnShowFlights.Name = "btnShowFlights"
        Me.btnShowFlights.Size = New System.Drawing.Size(776, 118)
        Me.btnShowFlights.TabIndex = 3
        Me.btnShowFlights.Text = "Show Flights"
        Me.btnShowFlights.UseVisualStyleBackColor = True
        '
        'frmCustomerMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnShowFlights)
        Me.Controls.Add(Me.btnCustomerFlight)
        Me.Controls.Add(Me.btnUpdateCustomer)
        Me.Name = "frmCustomerMainMenu"
        Me.Text = "frmCustomerMainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdateCustomer As Button
    Friend WithEvents btnCustomerFlight As Button
    Friend WithEvents btnShowFlights As Button
End Class
