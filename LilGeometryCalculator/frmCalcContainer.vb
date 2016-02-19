Public Class frmCalcContainer
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        Dim aboutForm As New frmAbout()
        aboutForm.ShowDialog()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        Dim calc As New frmCalc()
        calc.MdiParent = Me
        calc.Show()
    End Sub

    Private Sub mnuWindowTileHorizontal_Click(sender As Object, e As EventArgs) Handles mnuWindowTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuWindowTileVertical_Click(sender As Object, e As EventArgs) Handles mnuWindowTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
End Class
