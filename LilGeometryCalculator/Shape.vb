'------------------------------------------------------------
'-                   File Name: Shape.vb                    -
'-                 Part of Project: Assign6                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 02/20/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This contains the Shape class which has a list of        -
'- Formula, an image path and a name.                       -
'------------------------------------------------------------
Public Class Shape
    Public formulas As New List(Of Formula)
    Public imgPath As String
    Public name As String

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Create a new Shape object.                               -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name - The name to set for the Shape                     -
    '- imgPath - The imgPath to set for the Shape               -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(name As String, imgPath As String)
        Me.name = name
        Me.imgPath = imgPath
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: addFormula                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Adds a Formula object to the formulas list.              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- formulaToAdd - The Formula objec to be added to the      -
    '-                formula list                              -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub addFormula(formulaToAdd As Formula)
        Me.formulas.Add(formulaToAdd)
    End Sub
End Class
