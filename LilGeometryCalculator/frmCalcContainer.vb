Imports System.ComponentModel

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

    Private Sub frmCalcContainer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim quit As Boolean = True

        For Each calc As frmCalc In Me.MdiChildren
            If Not String.IsNullOrWhiteSpace(calc.txtAnswer.Text) Then
                If MessageBox.Show("Are you sure you want to quit?", "You have unsaved changes!",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                    calc.txtAnswer.Text = Nothing
                    calc.Close()
                Else
                    quit = False
                End If
            End If
        Next

        e.Cancel = Not quit
    End Sub
End Class
