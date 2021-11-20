<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gboEnterDetails = New System.Windows.Forms.GroupBox()
        Me.txbLName = New System.Windows.Forms.TextBox()
        Me.tbxaddress = New System.Windows.Forms.TextBox()
        Me.tbxEmail = New System.Windows.Forms.TextBox()
        Me.txbFName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboCreditCard = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txbCreditNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxHouseNumber = New System.Windows.Forms.TextBox()
        Me.tbxTown = New System.Windows.Forms.TextBox()
        Me.tbxStreet = New System.Windows.Forms.TextBox()
        Me.tbxPostal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbxMonth = New System.Windows.Forms.TextBox()
        Me.tbxYear = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.gboEnterDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHECKOUT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email Address*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(322, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Last Name*"
        '
        'gboEnterDetails
        '
        Me.gboEnterDetails.Controls.Add(Me.txbLName)
        Me.gboEnterDetails.Controls.Add(Me.tbxaddress)
        Me.gboEnterDetails.Controls.Add(Me.tbxEmail)
        Me.gboEnterDetails.Controls.Add(Me.txbFName)
        Me.gboEnterDetails.Controls.Add(Me.Label2)
        Me.gboEnterDetails.Controls.Add(Me.Label12)
        Me.gboEnterDetails.Controls.Add(Me.Label5)
        Me.gboEnterDetails.Controls.Add(Me.Label3)
        Me.gboEnterDetails.Controls.Add(Me.Label4)
        Me.gboEnterDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboEnterDetails.Location = New System.Drawing.Point(42, 54)
        Me.gboEnterDetails.Name = "gboEnterDetails"
        Me.gboEnterDetails.Size = New System.Drawing.Size(574, 178)
        Me.gboEnterDetails.TabIndex = 4
        Me.gboEnterDetails.TabStop = False
        Me.gboEnterDetails.Text = "Enter Details"
        '
        'txbLName
        '
        Me.txbLName.Location = New System.Drawing.Point(325, 58)
        Me.txbLName.Name = "txbLName"
        Me.txbLName.Size = New System.Drawing.Size(215, 21)
        Me.txbLName.TabIndex = 4
        '
        'tbxaddress
        '
        Me.tbxaddress.Location = New System.Drawing.Point(325, 122)
        Me.tbxaddress.Name = "tbxaddress"
        Me.tbxaddress.Size = New System.Drawing.Size(215, 21)
        Me.tbxaddress.TabIndex = 4
        '
        'tbxEmail
        '
        Me.tbxEmail.Location = New System.Drawing.Point(15, 122)
        Me.tbxEmail.Name = "tbxEmail"
        Me.tbxEmail.Size = New System.Drawing.Size(215, 21)
        Me.tbxEmail.TabIndex = 4
        '
        'txbFName
        '
        Me.txbFName.Location = New System.Drawing.Point(15, 58)
        Me.txbFName.Name = "txbFName"
        Me.txbFName.Size = New System.Drawing.Size(215, 21)
        Me.txbFName.TabIndex = 4
        Me.txbFName.UseWaitCursor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(322, 349)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Credit Card Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(322, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Address*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "House Number*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Street Name*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Town/City*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(321, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Postal Code"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 15)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Credit Card Type*"
        '
        'cboCreditCard
        '
        Me.cboCreditCard.FormattingEnabled = True
        Me.cboCreditCard.Items.AddRange(New Object() {"VISA", "AMERICAN EXPRESS", "MASTERCARD"})
        Me.cboCreditCard.Location = New System.Drawing.Point(15, 53)
        Me.cboCreditCard.Name = "cboCreditCard"
        Me.cboCreditCard.Size = New System.Drawing.Size(215, 23)
        Me.cboCreditCard.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(329, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Expiration date*"
        '
        'txbCreditNumber
        '
        Me.txbCreditNumber.Location = New System.Drawing.Point(15, 112)
        Me.txbCreditNumber.Name = "txbCreditNumber"
        Me.txbCreditNumber.Size = New System.Drawing.Size(215, 21)
        Me.txbCreditNumber.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbxHouseNumber)
        Me.GroupBox1.Controls.Add(Me.tbxTown)
        Me.GroupBox1.Controls.Add(Me.tbxStreet)
        Me.GroupBox1.Controls.Add(Me.tbxPostal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 136)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Billing Address"
        '
        'tbxHouseNumber
        '
        Me.tbxHouseNumber.Location = New System.Drawing.Point(324, 95)
        Me.tbxHouseNumber.Name = "tbxHouseNumber"
        Me.tbxHouseNumber.Size = New System.Drawing.Size(99, 21)
        Me.tbxHouseNumber.TabIndex = 4
        '
        'tbxTown
        '
        Me.tbxTown.Location = New System.Drawing.Point(14, 95)
        Me.tbxTown.Name = "tbxTown"
        Me.tbxTown.Size = New System.Drawing.Size(215, 21)
        Me.tbxTown.TabIndex = 4
        '
        'tbxStreet
        '
        Me.tbxStreet.Location = New System.Drawing.Point(14, 52)
        Me.tbxStreet.Name = "tbxStreet"
        Me.tbxStreet.Size = New System.Drawing.Size(215, 21)
        Me.tbxStreet.TabIndex = 4
        '
        'tbxPostal
        '
        Me.tbxPostal.Location = New System.Drawing.Point(324, 52)
        Me.tbxPostal.Name = "tbxPostal"
        Me.tbxPostal.Size = New System.Drawing.Size(99, 21)
        Me.tbxPostal.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbxMonth)
        Me.GroupBox2.Controls.Add(Me.tbxYear)
        Me.GroupBox2.Controls.Add(Me.txbCreditNumber)
        Me.GroupBox2.Controls.Add(Me.cboCreditCard)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(42, 403)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(574, 149)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Financial Details"
        '
        'tbxMonth
        '
        Me.tbxMonth.Location = New System.Drawing.Point(332, 69)
        Me.tbxMonth.Name = "tbxMonth"
        Me.tbxMonth.Size = New System.Drawing.Size(41, 21)
        Me.tbxMonth.TabIndex = 4
        '
        'tbxYear
        '
        Me.tbxYear.Location = New System.Drawing.Point(397, 69)
        Me.tbxYear.Name = "tbxYear"
        Me.tbxYear.Size = New System.Drawing.Size(41, 21)
        Me.tbxYear.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(343, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "mm"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(401, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "yy"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(378, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "/"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 94)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 15)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Credit Card Number"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 596)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 26)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "CHECKOUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(255, 564)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 10
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 634)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gboEnterDetails)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Purchase Summary"
        Me.gboEnterDetails.ResumeLayout(False)
        Me.gboEnterDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gboEnterDetails As GroupBox
    Friend WithEvents txbFName As TextBox
    Friend WithEvents txbLName As TextBox
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents tbxaddress As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cboCreditCard As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txbCreditNumber As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbxHouseNumber As TextBox
    Friend WithEvents tbxTown As TextBox
    Friend WithEvents tbxStreet As TextBox
    Friend WithEvents tbxPostal As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbxMonth As TextBox
    Friend WithEvents tbxYear As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblError As Label
End Class
