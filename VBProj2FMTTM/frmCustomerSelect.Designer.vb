<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerSelect
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
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(12, 42)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(242, 23)
        Me.btnAddCustomer.TabIndex = 0
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(12, 12)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(242, 24)
        Me.cboCustomer.TabIndex = 1
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(12, 71)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(242, 23)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "Select Customer"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'frmCustomerSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 104)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Name = "frmCustomerSelect"
        Me.Text = "FrmCustomerSelect"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents btnSelect As Button
End Class
