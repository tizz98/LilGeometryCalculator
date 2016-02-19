Public Class frmCalc
    Private shapes As New List(Of Shape)

    Private Sub frmCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modFixtureData.setupData()
        Me.shapes = modFixtureData.shapes

        resetForm()
    End Sub

    Private Sub rdoConvertUS_CheckedChanged(sender As Object, e As EventArgs) Handles rdoConvertUS.CheckedChanged
        ' todo
    End Sub

    Private Sub resetForm()
        lstShape.Items.AddRange((From shape In shapes Select shape.name).ToArray())
        lstShape.SelectedIndex = -1

        lstFormula.Items.Clear()

        lblTopInput.Hide()
        txtTopInput.Hide()

        lblMiddleInput.Hide()
        txtMiddleInput.Hide()

        lblBottomInput.Hide()
        txtBottomInput.Hide()

        resetInputValues()

        picDiagram.ImageLocation = Nothing
    End Sub

    Private Sub resetInputValues()
        txtTopInput.Text = 0
        txtMiddleInput.Text = 0
        txtBottomInput.Text = 0
    End Sub

    Private Sub lstShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstShape.SelectedIndexChanged
        Dim shp As Shape = (From shape In shapes Where shape.name = lstShape.SelectedItem Select shape).First
        lstFormula.Items.Clear()
        lstFormula.Items.AddRange((From frmla In shp.formulas Select frmla.name).ToArray())
    End Sub
End Class