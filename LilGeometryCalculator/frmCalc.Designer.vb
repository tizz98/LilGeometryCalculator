<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalc
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
        Me.lstShape = New System.Windows.Forms.ListBox()
        Me.lstFormula = New System.Windows.Forms.ListBox()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.grpConvert = New System.Windows.Forms.GroupBox()
        Me.rdoMetric = New System.Windows.Forms.RadioButton()
        Me.rdoConvertUS = New System.Windows.Forms.RadioButton()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnClearFormula = New System.Windows.Forms.Button()
        Me.btnClearValue = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.picDiagram = New System.Windows.Forms.PictureBox()
        Me.lblTopInput = New System.Windows.Forms.Label()
        Me.txtTopInput = New System.Windows.Forms.TextBox()
        Me.txtMiddleInput = New System.Windows.Forms.TextBox()
        Me.lblMiddleInput = New System.Windows.Forms.Label()
        Me.txtBottomInput = New System.Windows.Forms.TextBox()
        Me.lblBottomInput = New System.Windows.Forms.Label()
        Me.grpConvert.SuspendLayout()
        CType(Me.picDiagram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstShape
        '
        Me.lstShape.FormattingEnabled = True
        Me.lstShape.Location = New System.Drawing.Point(12, 237)
        Me.lstShape.Name = "lstShape"
        Me.lstShape.Size = New System.Drawing.Size(120, 95)
        Me.lstShape.TabIndex = 0
        '
        'lstFormula
        '
        Me.lstFormula.FormattingEnabled = True
        Me.lstFormula.Location = New System.Drawing.Point(12, 369)
        Me.lstFormula.Name = "lstFormula"
        Me.lstFormula.Size = New System.Drawing.Size(120, 30)
        Me.lstFormula.TabIndex = 1
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Location = New System.Drawing.Point(13, 350)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(47, 13)
        Me.lblFormula.TabIndex = 2
        Me.lblFormula.Text = "Formula:"
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(13, 218)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(41, 13)
        Me.lblShape.TabIndex = 3
        Me.lblShape.Text = "Shape:"
        '
        'grpConvert
        '
        Me.grpConvert.Controls.Add(Me.rdoMetric)
        Me.grpConvert.Controls.Add(Me.rdoConvertUS)
        Me.grpConvert.Location = New System.Drawing.Point(149, 151)
        Me.grpConvert.Name = "grpConvert"
        Me.grpConvert.Size = New System.Drawing.Size(189, 38)
        Me.grpConvert.TabIndex = 4
        Me.grpConvert.TabStop = False
        Me.grpConvert.Text = "Convert Answer"
        '
        'rdoMetric
        '
        Me.rdoMetric.AutoSize = True
        Me.rdoMetric.Location = New System.Drawing.Point(106, 15)
        Me.rdoMetric.Name = "rdoMetric"
        Me.rdoMetric.Size = New System.Drawing.Size(14, 13)
        Me.rdoMetric.TabIndex = 1
        Me.rdoMetric.UseVisualStyleBackColor = True
        '
        'rdoConvertUS
        '
        Me.rdoConvertUS.AutoSize = True
        Me.rdoConvertUS.Checked = True
        Me.rdoConvertUS.Location = New System.Drawing.Point(12, 15)
        Me.rdoConvertUS.Name = "rdoConvertUS"
        Me.rdoConvertUS.Size = New System.Drawing.Size(14, 13)
        Me.rdoConvertUS.TabIndex = 0
        Me.rdoConvertUS.TabStop = True
        Me.rdoConvertUS.UseVisualStyleBackColor = True
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(149, 108)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(189, 20)
        Me.txtAnswer.TabIndex = 5
        '
        'btnClearFormula
        '
        Me.btnClearFormula.Location = New System.Drawing.Point(149, 196)
        Me.btnClearFormula.Name = "btnClearFormula"
        Me.btnClearFormula.Size = New System.Drawing.Size(94, 36)
        Me.btnClearFormula.TabIndex = 6
        Me.btnClearFormula.Text = "C"
        Me.btnClearFormula.UseVisualStyleBackColor = True
        '
        'btnClearValue
        '
        Me.btnClearValue.Location = New System.Drawing.Point(249, 196)
        Me.btnClearValue.Name = "btnClearValue"
        Me.btnClearValue.Size = New System.Drawing.Size(89, 36)
        Me.btnClearValue.TabIndex = 7
        Me.btnClearValue.Text = "CE"
        Me.btnClearValue.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(149, 238)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(59, 36)
        Me.btn7.TabIndex = 8
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(214, 238)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(59, 36)
        Me.btn8.TabIndex = 9
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(279, 238)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(59, 36)
        Me.btn9.TabIndex = 10
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(279, 280)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(59, 36)
        Me.btn6.TabIndex = 13
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(214, 280)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(59, 36)
        Me.btn5.TabIndex = 12
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(149, 280)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(59, 36)
        Me.btn4.TabIndex = 11
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(279, 322)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(59, 36)
        Me.btn3.TabIndex = 16
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(214, 322)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(59, 36)
        Me.btn2.TabIndex = 15
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(149, 322)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(59, 36)
        Me.btn1.TabIndex = 14
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(149, 364)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(124, 36)
        Me.btn0.TabIndex = 17
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnDecimal
        '
        Me.btnDecimal.Location = New System.Drawing.Point(279, 364)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(59, 36)
        Me.btnDecimal.TabIndex = 18
        Me.btnDecimal.Text = "."
        Me.btnDecimal.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(358, 196)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 203)
        Me.btnCalculate.TabIndex = 19
        Me.btnCalculate.Text = "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "l" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "c" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "u" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "l" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'picDiagram
        '
        Me.picDiagram.Location = New System.Drawing.Point(484, 149)
        Me.picDiagram.Name = "picDiagram"
        Me.picDiagram.Size = New System.Drawing.Size(400, 250)
        Me.picDiagram.TabIndex = 20
        Me.picDiagram.TabStop = False
        '
        'lblTopInput
        '
        Me.lblTopInput.AutoSize = True
        Me.lblTopInput.Location = New System.Drawing.Point(481, 15)
        Me.lblTopInput.Name = "lblTopInput"
        Me.lblTopInput.Size = New System.Drawing.Size(39, 13)
        Me.lblTopInput.TabIndex = 21
        Me.lblTopInput.Text = "Label1"
        '
        'txtTopInput
        '
        Me.txtTopInput.Location = New System.Drawing.Point(528, 12)
        Me.txtTopInput.Name = "txtTopInput"
        Me.txtTopInput.Size = New System.Drawing.Size(356, 20)
        Me.txtTopInput.TabIndex = 22
        '
        'txtMiddleInput
        '
        Me.txtMiddleInput.Location = New System.Drawing.Point(528, 48)
        Me.txtMiddleInput.Name = "txtMiddleInput"
        Me.txtMiddleInput.Size = New System.Drawing.Size(356, 20)
        Me.txtMiddleInput.TabIndex = 24
        '
        'lblMiddleInput
        '
        Me.lblMiddleInput.AutoSize = True
        Me.lblMiddleInput.Location = New System.Drawing.Point(481, 51)
        Me.lblMiddleInput.Name = "lblMiddleInput"
        Me.lblMiddleInput.Size = New System.Drawing.Size(39, 13)
        Me.lblMiddleInput.TabIndex = 23
        Me.lblMiddleInput.Text = "Label2"
        '
        'txtBottomInput
        '
        Me.txtBottomInput.Location = New System.Drawing.Point(528, 87)
        Me.txtBottomInput.Name = "txtBottomInput"
        Me.txtBottomInput.Size = New System.Drawing.Size(356, 20)
        Me.txtBottomInput.TabIndex = 26
        '
        'lblBottomInput
        '
        Me.lblBottomInput.AutoSize = True
        Me.lblBottomInput.Location = New System.Drawing.Point(481, 90)
        Me.lblBottomInput.Name = "lblBottomInput"
        Me.lblBottomInput.Size = New System.Drawing.Size(39, 13)
        Me.lblBottomInput.TabIndex = 25
        Me.lblBottomInput.Text = "Label3"
        '
        'frmCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 424)
        Me.Controls.Add(Me.txtBottomInput)
        Me.Controls.Add(Me.lblBottomInput)
        Me.Controls.Add(Me.txtMiddleInput)
        Me.Controls.Add(Me.lblMiddleInput)
        Me.Controls.Add(Me.txtTopInput)
        Me.Controls.Add(Me.lblTopInput)
        Me.Controls.Add(Me.picDiagram)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnDecimal)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnClearValue)
        Me.Controls.Add(Me.btnClearFormula)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.grpConvert)
        Me.Controls.Add(Me.lblShape)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.lstFormula)
        Me.Controls.Add(Me.lstShape)
        Me.Name = "frmCalc"
        Me.Text = "Calculator"
        Me.grpConvert.ResumeLayout(False)
        Me.grpConvert.PerformLayout()
        CType(Me.picDiagram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstShape As ListBox
    Friend WithEvents lstFormula As ListBox
    Friend WithEvents lblFormula As Label
    Friend WithEvents lblShape As Label
    Friend WithEvents grpConvert As GroupBox
    Friend WithEvents rdoMetric As RadioButton
    Friend WithEvents rdoConvertUS As RadioButton
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnClearFormula As Button
    Friend WithEvents btnClearValue As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents picDiagram As PictureBox
    Friend WithEvents lblTopInput As Label
    Friend WithEvents txtTopInput As TextBox
    Friend WithEvents txtMiddleInput As TextBox
    Friend WithEvents lblMiddleInput As Label
    Friend WithEvents txtBottomInput As TextBox
    Friend WithEvents lblBottomInput As Label
End Class
