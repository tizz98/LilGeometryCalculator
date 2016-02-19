Public Class frmCalc
    Private shapes As New List(Of Shape)
    Private currentShape As Shape
    Private currentFormula As Formula

    Private Sub frmCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modFixtureData.setupData()
        Me.shapes = modFixtureData.shapes

        resetForm()
    End Sub

    Private Sub rdoConvertUS_CheckedChanged(sender As Object, e As EventArgs) Handles rdoConvertUS.CheckedChanged
        If rdoConvertUS.Checked Then
            txtAnswer.Text = currentFormula.convertMetricToUs(Convert.ToDouble(txtAnswer.Text))
        End If
    End Sub

    Private Sub rdoMetric_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMetric.CheckedChanged
        If rdoMetric.Checked Then
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

        rdoConvertUS.Text = currentFormula.getUsUnitName()
        rdoMetric.Text = currentFormula.getMetricUnitName()
    End Sub
End Class