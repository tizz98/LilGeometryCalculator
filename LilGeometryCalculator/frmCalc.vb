Imports System.ComponentModel

Public Class frmCalc
    Private shapes As New List(Of Shape)
    Private currentShape As Shape = Nothing
    Private currentFormula As Formula = Nothing

    Private Sub frmCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modFixtureData.setupData()
        Me.shapes = modFixtureData.shapes

        resetForm()
    End Sub

    Private Sub rdoConvertUS_CheckedChanged(sender As Object, e As EventArgs) Handles rdoConvertUS.CheckedChanged
        If rdoConvertUS.Checked And Not String.IsNullOrWhiteSpace(txtAnswer.Text) Then
            txtAnswer.Text = currentFormula.convertMetricToUs(Convert.ToDouble(txtAnswer.Text))
        End If
    End Sub

    Private Sub rdoMetric_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMetric.CheckedChanged
        If rdoMetric.Checked And Not String.IsNullOrWhiteSpace(txtAnswer.Text) Then
            txtAnswer.Text = currentFormula.convertUsToMetric(Convert.ToDouble(txtAnswer.Text))
        End If
    End Sub

    Private Sub resetForm()
        lstShape.Items.AddRange((From shape In shapes Select shape.name).ToArray())
        lstShape.SelectedIndex = -1

        lstFormula.Items.Clear()

        resetInput()

        picDiagram.ImageLocation = Nothing
    End Sub

    Private Sub resetInputValues()
        txtTopInput.Text = 0
        txtMiddleInput.Text = 0
        txtBottomInput.Text = 0
        txtAnswer.Text = ""

        rdoConvertUS.Text = ""
        rdoMetric.Text = ""
    End Sub

    Private Sub resetInput()
        lblTopInput.Hide()
        txtTopInput.Hide()

        lblMiddleInput.Hide()
        txtMiddleInput.Hide()

        lblBottomInput.Hide()
        txtBottomInput.Hide()

        resetInputValues()
    End Sub

    Private Sub lstShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstShape.SelectedIndexChanged
        resetInput()

        currentShape = (From shape In shapes Where shape.name = lstShape.SelectedItem Select shape).First
        lstFormula.Items.Clear()
        lstFormula.Items.AddRange((From frmla In currentShape.formulas Select frmla.name).ToArray())
        picDiagram.ImageLocation = currentShape.imgPath
    End Sub

    Private Sub lstFormula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFormula.SelectedIndexChanged
        resetInput()

        If lstFormula.SelectedIndex = -1 Then
            Return
        End If

        currentFormula = (From frmla In currentShape.formulas Where frmla.name = lstFormula.SelectedItem Select frmla).First

        ' setup form for action!
        lblTopInput.Text = currentFormula.input1Name
        lblTopInput.Show()
        txtTopInput.Show()

        If currentFormula.numInputs > 1 Then
            lblMiddleInput.Text = currentFormula.input2Name
            lblMiddleInput.Show()
            txtMiddleInput.Show()
        End If

        If currentFormula.numInputs > 2 Then
            lblBottomInput.Text = currentFormula.input3Name
            lblBottomInput.Show()
            txtBottomInput.Show()
        End If

        rdoConvertUS.Text = currentFormula.getUsUnitName()
        rdoMetric.Text = currentFormula.getMetricUnitName()
    End Sub

    Private Sub btnClearFormula_Click(sender As Object, e As EventArgs) Handles btnClearFormula.Click
        resetInput()
        currentFormula = Nothing
        lstFormula.SelectedIndex = -1
    End Sub

    Private Sub btnClearValue_Click(sender As Object, e As EventArgs) Handles btnClearValue.Click
        resetInputValues()

        If Not IsNothing(currentFormula) Then
            rdoConvertUS.Text = currentFormula.getUsUnitName()
            rdoMetric.Text = currentFormula.getMetricUnitName()
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If Not IsNothing(currentFormula) Then
            ' numba crunchin time
            Dim input1 As Double = Convert.ToDouble(txtTopInput.Text)
            Dim input2 As Double = Convert.ToDouble(txtMiddleInput.Text)
            Dim input3 As Double = Convert.ToDouble(txtBottomInput.Text)

            currentFormula.setFormulaInputs(input1, input2, input3)
            txtAnswer.Text = currentFormula.calculateAnswer()
        End If
    End Sub

    Private Sub appendCharToTextBox(chr As String)
        If Not IsNothing(currentFormula) And txtTopInput.Visible Then
            txtTopInput.Text &= chr
        End If
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        appendCharToTextBox(".")
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        appendCharToTextBox("0")
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        appendCharToTextBox("1")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        appendCharToTextBox("2")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        appendCharToTextBox("3")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        appendCharToTextBox("4")
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        appendCharToTextBox("5")
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        appendCharToTextBox("6")
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        appendCharToTextBox("7")
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        appendCharToTextBox("8")
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        appendCharToTextBox("9")
    End Sub

    Private Sub frmCalc_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not String.IsNullOrWhiteSpace(txtAnswer.Text) Then
            If Not MessageBox.Show("Are you sure you want to quit?", "You have unsaved changes!",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class