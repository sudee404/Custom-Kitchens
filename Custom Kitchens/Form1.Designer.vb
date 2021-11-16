<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.gbxCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rmBudget = New System.Windows.Forms.TextBox()
        Me.rmWidth = New System.Windows.Forms.TextBox()
        Me.rmLength = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxKitchenStyles = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gbxBox = New System.Windows.Forms.GroupBox()
        Me.gbxCustomerDetails.SuspendLayout()
        Me.gbxKitchenStyles.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCustomerDetails
        '
        Me.gbxCustomerDetails.Controls.Add(Me.gbxKitchenStyles)
        Me.gbxCustomerDetails.Controls.Add(Me.lblRemarks)
        Me.gbxCustomerDetails.Controls.Add(Me.Button1)
        Me.gbxCustomerDetails.Controls.Add(Me.rmBudget)
        Me.gbxCustomerDetails.Controls.Add(Me.rmWidth)
        Me.gbxCustomerDetails.Controls.Add(Me.rmLength)
        Me.gbxCustomerDetails.Controls.Add(Me.Label3)
        Me.gbxCustomerDetails.Controls.Add(Me.Label2)
        Me.gbxCustomerDetails.Controls.Add(Me.Label1)
        Me.gbxCustomerDetails.Location = New System.Drawing.Point(12, 12)
        Me.gbxCustomerDetails.Name = "gbxCustomerDetails"
        Me.gbxCustomerDetails.Size = New System.Drawing.Size(353, 349)
        Me.gbxCustomerDetails.TabIndex = 0
        Me.gbxCustomerDetails.TabStop = False
        Me.gbxCustomerDetails.Text = "Customer Details"
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoEllipsis = True
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(94, 282)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(0, 13)
        Me.lblRemarks.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(115, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rmBudget
        '
        Me.rmBudget.Location = New System.Drawing.Point(138, 164)
        Me.rmBudget.Name = "rmBudget"
        Me.rmBudget.Size = New System.Drawing.Size(100, 20)
        Me.rmBudget.TabIndex = 5
        Me.rmBudget.Text = "25000"
        '
        'rmWidth
        '
        Me.rmWidth.Location = New System.Drawing.Point(138, 106)
        Me.rmWidth.Name = "rmWidth"
        Me.rmWidth.Size = New System.Drawing.Size(100, 20)
        Me.rmWidth.TabIndex = 4
        Me.rmWidth.Text = "200"
        '
        'rmLength
        '
        Me.rmLength.CausesValidation = False
        Me.rmLength.Location = New System.Drawing.Point(138, 51)
        Me.rmLength.Name = "rmLength"
        Me.rmLength.Size = New System.Drawing.Size(100, 20)
        Me.rmLength.TabIndex = 3
        Me.rmLength.Text = "520"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Budget :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Width :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length :"
        '
        'gbxKitchenStyles
        '
        Me.gbxKitchenStyles.Controls.Add(Me.gbxBox)
        Me.gbxKitchenStyles.Controls.Add(Me.Button2)
        Me.gbxKitchenStyles.Location = New System.Drawing.Point(0, 0)
        Me.gbxKitchenStyles.Name = "gbxKitchenStyles"
        Me.gbxKitchenStyles.Size = New System.Drawing.Size(353, 349)
        Me.gbxKitchenStyles.TabIndex = 8
        Me.gbxKitchenStyles.TabStop = False
        Me.gbxKitchenStyles.Text = "Kitchen Style"
        Me.gbxKitchenStyles.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(126, 293)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Proceed"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'gbxBox
        '
        Me.gbxBox.Location = New System.Drawing.Point(38, 19)
        Me.gbxBox.Name = "gbxBox"
        Me.gbxBox.Size = New System.Drawing.Size(278, 257)
        Me.gbxBox.TabIndex = 7
        Me.gbxBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbxCustomerDetails)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxCustomerDetails.ResumeLayout(False)
        Me.gbxCustomerDetails.PerformLayout()
        Me.gbxKitchenStyles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxCustomerDetails As GroupBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents rmBudget As TextBox
    Friend WithEvents rmWidth As TextBox
    Friend WithEvents rmLength As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbxKitchenStyles As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents gbxBox As GroupBox
End Class
