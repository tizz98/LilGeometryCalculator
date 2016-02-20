Public Class Shape
    Public formulas As New List(Of Formula)
    Public imgPath As String
    Public name As String

    Public Sub New(name As String, imgPath As String)
        Me.name = name
        Me.imgPath = imgPath
    End Sub

    Public Sub addFormula(formulaToAdd As Formula)
        Me.formulas.Add(formulaToAdd)
    End Sub
End Class
