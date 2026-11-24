<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnPilots = New System.Windows.Forms.Button()
        Me.btnAttendants = New System.Windows.Forms.Button()
        Me.btnAdministration = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(12, 12)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(665, 75)
        Me.btnCustomer.TabIndex = 0
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnPilots
        '
        Me.btnPilots.Location = New System.Drawing.Point(12, 93)
        Me.btnPilots.Name = "btnPilots"
        Me.btnPilots.Size = New System.Drawing.Size(665, 75)
        Me.btnPilots.TabIndex = 1
        Me.btnPilots.Text = "Pilots"
        Me.btnPilots.UseVisualStyleBackColor = True
        '
        'btnAttendants
        '
        Me.btnAttendants.Location = New System.Drawing.Point(12, 174)
        Me.btnAttendants.Name = "btnAttendants"
        Me.btnAttendants.Size = New System.Drawing.Size(665, 75)
        Me.btnAttendants.TabIndex = 2
        Me.btnAttendants.Text = "Attendants"
        Me.btnAttendants.UseVisualStyleBackColor = True
        '
        'btnAdministration
        '
        Me.btnAdministration.Location = New System.Drawing.Point(12, 255)
        Me.btnAdministration.Name = "btnAdministration"
        Me.btnAdministration.Size = New System.Drawing.Size(665, 75)
        Me.btnAdministration.TabIndex = 3
        Me.btnAdministration.Text = "Administration"
        Me.btnAdministration.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.Location = New System.Drawing.Point(12, 336)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(665, 75)
        Me.btnStatistics.TabIndex = 4
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 424)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnAdministration)
        Me.Controls.Add(Me.btnAttendants)
        Me.Controls.Add(Me.btnPilots)
        Me.Controls.Add(Me.btnCustomer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnPilots As Button
    Friend WithEvents btnAttendants As Button
    Friend WithEvents btnAdministration As Button
    Friend WithEvents btnStatistics As Button
End Class
