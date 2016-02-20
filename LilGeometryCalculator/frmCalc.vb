'------------------------------------------------------------
'-                  File Name: frmCalc.vb                   -
'-                 Part of Project: Assign6                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 02/20/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This contains the frmCalc class that is used for the     -
'- MdiChildren of frmCalcContainer.                         -
'------------------------------------------------------------
Public Class frmCalc
    Private shapes As New List(Of Shape)
    Private currentShape As Shape = Nothing
    Private currentFormula As Formula = Nothing

    '------------------------------------------------------------
    '-              Subprogram Name: frmCalc_Load               -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Called when the form is loaded; sets up the fixture data -
    '- and sets the fixture data shapes to the form's shapes    -
    '- and resets the form.                                     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that called this event               -
    '- e - The EventArgs sent to this event                     -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modFixtureData.setupData()
        Me.shapes = modFixtureData.shapes

        resetForm()
    End Sub

    '------------------------------------------------------------
    '-       Subprogram Name: rdoConvertUS_CheckedChanged       -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This is raised when the US units radio button's checked  -
    '- state changes. If it is checked then it converts the     -
    '- answer to US units.                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The EventArgs sent to the event                      -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub rdoConvertUS_CheckedChanged(sender As Object, e As EventArgs) Handles rdoConvertUS.CheckedChanged
        If rdoConvertUS.Checked And Not String.IsNullOrWhiteSpace(txtAnswer.Text) Then
            txtAnswer.Text = currentFormula.convertMetricToUs(Convert.ToDouble(txtAnswer.Text))
        End If
    End Sub

    '------------------------------------------------------------
    '-        Subprogram Name: rdoMetric_CheckedChanged         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This is raised when the metric units radio button's      -
    '- checked state changes. If it is checked then it converts -
    '- the answer to metric units.                              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The EventArgs sent to this event                     -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub rdoMetric_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMetric.CheckedChanged
        If rdoMetric.Checked And Not String.IsNullOrWhiteSpace(txtAnswer.Text) Then
            txtAnswer.Text = currentFormula.convertUsToMetric(Convert.ToDouble(txtAnswer.Text))
        End If
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: resetForm                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets the form. It sets all of the shape items to  -
    '- the form's shapes and makes sure none are selected. It   -
    '- also clears the formula list items, sets the picture to  -
    '- nothing and resets all the text boxes to their default   -
    '- state.                                                   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub resetForm()
        lstShape.Items.AddRange((From shape In shapes Select shape.name).ToArray())
        lstShape.SelectedIndex = -1

        lstFormula.Items.Clear()

        resetInput()

        picDiagram.ImageLocation = Nothing
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: resetInputValues             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets all of the form's input values to either 0   -
    '- or a blank string.                                       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub resetInputValues()
        txtTopInput.Text = 0
        txtMiddleInput.Text = 0
        txtBottomInput.Text = 0
        txtAnswer.Text = ""

        rdoConvertUS.Text = ""
        rdoMetric.Text = ""
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: resetInput                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets all of the input fields, meaning all of the  -
    '- input text boxes are hidden and the US units radio       -
    '- button is checked. It also resets the text box input     -
    '- values.                                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub resetInput()
        lblTopInput.Hide()
        txtTopInput.Hide()

        lblMiddleInput.Hide()
        txtMiddleInput.Hide()

        lblBottomInput.Hide()
        txtBottomInput.Hide()

        rdoMetric.Checked = False
        rdoConvertUS.Checked = True

        resetInputValues()
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: lstShape_SelectedIndexChanged      -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This is raised when the selected index of the shape list -
    '- box changes. It resets the inputs and sets the           -
    '- currentShape to whatever shape was selected and sets the -
    '- formula list box to the shape's formulas. It also sets   -
    '- the image to whatever the shape's image is.              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub lstShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstShape.SelectedIndexChanged
        resetInput()

        currentShape = (From shape In shapes Where shape.name = lstShape.SelectedItem Select shape).First
        lstFormula.Items.Clear()
        lstFormula.Items.AddRange((From frmla In currentShape.formulas Select frmla.name).ToArray())
        picDiagram.ImageLocation = currentShape.imgPath
    End Sub

    '------------------------------------------------------------
    '-     Subprogram Name: lstFormula_SelectedIndexChanged     -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This is raised when the selected index of the formula    -
    '- list box changes. It resets the input and sets the       -
    '- currentFormula to whatever formula was selected. Then    -
    '- depending on the number of inputs for the formula, sets  -
    '- up the correct number of text boxes.                     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The EventArgs that were passed to the event          -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-          Subprogram Name: btnClearFormula_Click          -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets the form's input, sets the currentFormula to -
    '- Nothing and sets the formula list box selected input to  -
    '- -1.                                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnClearFormula_Click(sender As Object, e As EventArgs) Handles btnClearFormula.Click
        resetInput()
        currentFormula = Nothing
        lstFormula.SelectedIndex = -1
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnClearValue_Click           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets the input values to their default values.    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The EventArgs sent to this event                     -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnClearValue_Click(sender As Object, e As EventArgs) Handles btnClearValue.Click
        resetInputValues()

        If Not IsNothing(currentFormula) Then
            rdoConvertUS.Text = currentFormula.getUsUnitName()
            rdoMetric.Text = currentFormula.getMetricUnitName()
        End If
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnCalculate_Click            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This gets the values from the three input text boxes     -
    '- then sets them as the currentFormula's formula inputs    -
    '- then sets the answer text box to the currentFormula's    -
    '- answer                                                   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- input1 - The Double representation of the top text box's -
    '-          text                                            -
    '- input2 - The Double representation of the middle text    -
    '-          box's text                                      -
    '- input3 - The Double representation of the bottom text    -
    '-          box's text                                      -
    '------------------------------------------------------------
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

    '------------------------------------------------------------
    '-           Subprogram Name: appendCharToTextBox           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This appends a character to the top textbox. Used for    -
    '- when a number on the calculator is pressed.              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- chr - The character to append                            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub appendCharToTextBox(chr As String)
        If Not IsNothing(currentFormula) And txtTopInput.Visible Then
            txtTopInput.Text &= chr
        End If
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: btnDecimal_Click             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Appends a decimal point to the top text box.             -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        appendCharToTextBox(".")
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: btn0_Click                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Appends a 0 to the top text box.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        appendCharToTextBox("0")
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: btn1_Click                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Appends a 1 to the top text box.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        appendCharToTextBox("1")
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: btn2_Click                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Appends a 2 to the top text box.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        appendCharToTextBox("2")
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: btn3_Click                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Appends a 3 to the top text box.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        appendCharToTextBox("3")
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: btn4_Click                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Appends a 4 to the top text box.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        appendCharToTextBox("4")
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: btn5_Click                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Appends a 5 to the top text box.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        appendCharToTextBox("5")
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: btn6_Click                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Appends a 6 to the top text box.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        appendCharToTextBox("6")
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: btn7_Click                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Appends a 7 to the top text box.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        appendCharToTextBox("7")
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: btn8_Click                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Appends a 8 to the top text box.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        appendCharToTextBox("8")
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: btn9_Click                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Appends a 9 to the top text box.                         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        appendCharToTextBox("9")
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: frmCalc_FormClosing           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Handles the form closing event. If the reason the form   -
    '- is closing is because the MdiForm is closing then just   -
    '- return because this means the parent is going to handle  -
    '- it. If this is the last MdiChild and the user does want  -
    '- to close it, then it will also close the parent.         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised the event                -
    '- e - The FormClosingEventArgs sent to the event           -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmCalc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.MdiFormClosing Then
            Return
        End If

        If Not String.IsNullOrWhiteSpace(txtAnswer.Text) Then
            If Not MessageBox.Show("Are you sure you want to quit?", "You have unsaved changes!",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                ' Cancel
                e.Cancel = True
            End If
        End If

        If Not e.Cancel Then
            ' Close form
            Me.txtAnswer.Text = Nothing

            ' Just this form so close the parent too
            If Me.MdiParent.MdiChildren.Count = 1 Then
                Me.MdiParent.Close()
            End If
        End If
    End Sub
End Class