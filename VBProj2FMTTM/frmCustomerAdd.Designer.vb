<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerAdd
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
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboState
        '
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(159, 121)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(121, 24)
        Me.cboState.TabIndex = 67
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(159, 205)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(121, 22)
        Me.txtEmail.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Email:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(159, 177)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(121, 22)
        Me.txtPhone.TabIndex = 64
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(15, 233)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(265, 86)
        Me.btnSubmit.TabIndex = 63
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(159, 149)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(121, 22)
        Me.txtZip.TabIndex = 62
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(159, 93)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(121, 22)
        Me.txtCity.TabIndex = 61
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(159, 65)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(121, 22)
        Me.txtAddress.TabIndex = 60
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(159, 37)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(121, 22)
        Me.txtLastName.TabIndex = 59
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(159, 9)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(121, 22)
        Me.txtFirstName.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Phone Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 16)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Zip:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "State:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "City:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "First Name:"
        '
        'frmCustomerAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 327)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCustomerAdd"
        Me.Text = "frmCustomerAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboState As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
