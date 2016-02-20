'------------------------------------------------------------
'-              File Name: frmCalcContainer.vb              -
'-                 Part of Project: Assign6                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 02/20/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- Contains the frmCalcContainer class which is the         -
'- MdiParent and contains all the frmCalc forms as          -
'- MdiChildren.                                             -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- To show the use of Mdi forms and to have multiple        -
'- calculators on the screen at the same time.              -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- (None)                                                   -
'------------------------------------------------------------
Imports System.ComponentModel

Public Class frmCalcContainer
    Private calcNum As Integer = 0

    '------------------------------------------------------------
    '-           Subprogram Name: mnuHelpAbout_Click            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Handle when the about menu item is clicked.              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The EventArgs passed to the event                    -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- aboutForm - A frmAbout object that will be shown         -
    '------------------------------------------------------------
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        Dim aboutForm As New frmAbout()
        aboutForm.ShowDialog()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: mnuFileExit_Click            -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Handles when the exit menu item is clicked and attempts  -
    '- to close the entire form.                                -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The EventArgs sent to this event                     -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: mnuFileNew_Click             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Handles when the new menu item is clicked. It creates a  -
    '- new frmCalc object, sets the MdiParent to this form and  -
    '- then shows it.                                           -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The EventArgs sent to the event                      -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- calc - A frmCalc object that is created then shown       -
    '------------------------------------------------------------
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        calcNum += 1
        Dim calc As New frmCalc(calcNum)
        calc.MdiParent = Me
        calc.Show()
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: mnuWindowTileHorizontal_Click      -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Handles when the tile horizontal menu item is clicked.   -
    '- Sets the form's LayoutMdi to MdiLayout.TileHorizontal.   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The EventArgs that were sent to the event            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub mnuWindowTileHorizontal_Click(sender As Object, e As EventArgs) Handles mnuWindowTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    '------------------------------------------------------------
    '-       Subprogram Name: mnuWindowTileVertical_Click       -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Handles when the tile vertical menu item is clicked.     -
    '- Sets the form's LayoutMdi to MdiLayout.TileVertical.     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The EventArgs that were sent to this event           -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub mnuWindowTileVertical_Click(sender As Object, e As EventArgs) Handles mnuWindowTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    '------------------------------------------------------------
    '-         Subprogram Name: mnuWindowCascade_Click          -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Handles when the cascade item is clicked. Sets the       -
    '- form's LayoutMdi to MdiLayout.Cascade.                   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The EventArgs sent to this event                     -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    '------------------------------------------------------------
    '-        Subprogram Name: frmCalcContainer_Closing         -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Handles the closing event for the form. It attempts to   -
    '- close all the MdiChildren by prompting if they have data -
    '- in them. If any of the MdiChildren respond No then this  -
    '- container form does not get closed.                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - The object that raised this event               -
    '- e - The CancelEventArgs sent to the event                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- quit - A boolean that is set whether or ot the form      -
    '-        should actually close                             -
    '------------------------------------------------------------
    Private Sub frmCalcContainer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim quit As Boolean = True

        For Each calc As frmCalc In Me.MdiChildren
            If Not String.IsNullOrWhiteSpace(calc.txtAnswer.Text) Then
                If MessageBox.Show("Are you sure you want to quit?", "You have unsaved changes! (" & calc.Text & ")",
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
