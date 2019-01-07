<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdvancedTax
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
        Me.lbltax = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RbMale = New System.Windows.Forms.RadioButton()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.RbFemale = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbldeductions = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtPaye = New System.Windows.Forms.TextBox()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHelb = New System.Windows.Forms.TextBox()
        Me.txtSacco = New System.Windows.Forms.TextBox()
        Me.txtNet = New System.Windows.Forms.TextBox()
        Me.grpGender.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltax
        '
        Me.lbltax.AutoSize = True
        Me.lbltax.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltax.Location = New System.Drawing.Point(210, 32)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(362, 31)
        Me.lbltax.TabIndex = 0
        Me.lbltax.Text = "Vumilia Monthly TAX System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Number"
        '
        'RbMale
        '
        Me.RbMale.AutoSize = True
        Me.RbMale.Location = New System.Drawing.Point(102, 43)
        Me.RbMale.Name = "RbMale"
        Me.RbMale.Size = New System.Drawing.Size(57, 19)
        Me.RbMale.TabIndex = 9
        Me.RbMale.TabStop = True
        Me.RbMale.Text = "Male"
        Me.RbMale.UseVisualStyleBackColor = True
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.RbFemale)
        Me.grpGender.Controls.Add(Me.RbMale)
        Me.grpGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGender.Location = New System.Drawing.Point(172, 506)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(200, 87)
        Me.grpGender.TabIndex = 12
        Me.grpGender.TabStop = False
        Me.grpGender.Text = "Gender"
        '
        'RbFemale
        '
        Me.RbFemale.AutoSize = True
        Me.RbFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RbFemale.Location = New System.Drawing.Point(6, 45)
        Me.RbFemale.Name = "RbFemale"
        Me.RbFemale.Size = New System.Drawing.Size(73, 19)
        Me.RbFemale.TabIndex = 0
        Me.RbFemale.TabStop = True
        Me.RbFemale.Text = "Female"
        Me.RbFemale.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(106, 599)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnquit
        '
        Me.btnquit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnquit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquit.Location = New System.Drawing.Point(358, 599)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(75, 23)
        Me.btnquit.TabIndex = 14
        Me.btnquit.Text = "Quit"
        Me.btnquit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(225, 599)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Gross Pay"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "P.A.Y.E"
        '
        'lbldeductions
        '
        Me.lbldeductions.AutoSize = True
        Me.lbldeductions.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldeductions.Location = New System.Drawing.Point(183, 315)
        Me.lbldeductions.Name = "lbldeductions"
        Me.lbldeductions.Size = New System.Drawing.Size(128, 19)
        Me.lbldeductions.TabIndex = 19
        Me.lbldeductions.Text = "Other Deductions"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "HELB Loan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 402)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "SACCO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(123, 464)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Net Pay"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(314, 86)
        Me.txtNumber.Multiline = True
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(206, 31)
        Me.txtNumber.TabIndex = 1
        '
        'txtPaye
        '
        Me.txtPaye.Location = New System.Drawing.Point(314, 223)
        Me.txtPaye.Multiline = True
        Me.txtPaye.Name = "txtPaye"
        Me.txtPaye.ReadOnly = True
        Me.txtPaye.Size = New System.Drawing.Size(206, 31)
        Me.txtPaye.TabIndex = 24
        Me.txtPaye.TabStop = False
        '
        'txtGross
        '
        Me.txtGross.Location = New System.Drawing.Point(314, 176)
        Me.txtGross.Multiline = True
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(206, 31)
        Me.txtGross.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(314, 131)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(206, 31)
        Me.txtName.TabIndex = 2
        '
        'txtHelb
        '
        Me.txtHelb.Location = New System.Drawing.Point(314, 340)
        Me.txtHelb.Multiline = True
        Me.txtHelb.Name = "txtHelb"
        Me.txtHelb.Size = New System.Drawing.Size(206, 31)
        Me.txtHelb.TabIndex = 4
        '
        'txtSacco
        '
        Me.txtSacco.Location = New System.Drawing.Point(314, 386)
        Me.txtSacco.Multiline = True
        Me.txtSacco.Name = "txtSacco"
        Me.txtSacco.Size = New System.Drawing.Size(206, 31)
        Me.txtSacco.TabIndex = 5
        '
        'txtNet
        '
        Me.txtNet.Location = New System.Drawing.Point(314, 437)
        Me.txtNet.Multiline = True
        Me.txtNet.Name = "txtNet"
        Me.txtNet.ReadOnly = True
        Me.txtNet.Size = New System.Drawing.Size(206, 42)
        Me.txtNet.TabIndex = 29
        Me.txtNet.TabStop = False
        '
        'FrmAdvancedTax
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.btnquit
        Me.ClientSize = New System.Drawing.Size(646, 645)
        Me.Controls.Add(Me.txtNet)
        Me.Controls.Add(Me.txtSacco)
        Me.Controls.Add(Me.txtHelb)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.txtPaye)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbldeductions)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnquit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpGender)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltax)
        Me.Name = "FrmAdvancedTax"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced Tax System"
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltax As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RbMale As System.Windows.Forms.RadioButton
    Friend WithEvents grpGender As System.Windows.Forms.GroupBox
    Friend WithEvents RbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnquit As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbldeductions As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPaye As System.Windows.Forms.TextBox
    Friend WithEvents txtGross As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtHelb As System.Windows.Forms.TextBox
    Friend WithEvents txtSacco As System.Windows.Forms.TextBox
    Friend WithEvents txtNet As System.Windows.Forms.TextBox

End Class
