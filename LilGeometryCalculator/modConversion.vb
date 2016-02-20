'------------------------------------------------------------
'-               File Name: modConversion.vb                -
'-                 Part of Project: Assign6                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 02/20/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- A module containing conversion formulas.                 -
'------------------------------------------------------------
Module modConversion
    Private Const NUM_CM_SQ_IN_INCH_SQ As Single = 6.4516
    Private Const NUM_CM_CUBE_IN_INCH_CUBE As Single = 16.3871
    Private Const NUM_INCH_SQ_IN_CM_SQ As Single = 0.155
    Private Const NUM_INCH_CUBE_IN_CM_CUBE As Single = 0.610237
    Private Const NUM_INCH_IN_CM As Single = 0.393701
    Private Const NUM_CM_IN_INCH As Single = 2.54

    '------------------------------------------------------------
    '-               Function Name: inchSqToCmSq                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Converts inches squared to cm squared.                   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- inchSq - Inches squared value                            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Double - Cm squared value                                -
    '------------------------------------------------------------
    Public Function inchSqToCmSq(inchSq As Double) As Double
        Return inchSq * NUM_CM_SQ_IN_INCH_SQ
    End Function

    '------------------------------------------------------------
    '-               Function Name: cmSqToInchSq                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Converts cm squared to inches squared.                   -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- cmSq - Cm squared value                                  -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Double - Inches squared value                            -
    '------------------------------------------------------------
    Public Function cmSqToInchSq(cmSq As Double) As Double
        Return cmSq * NUM_INCH_SQ_IN_CM_SQ
    End Function

    '------------------------------------------------------------
    '-             Function Name: inchCubeToCmCube              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Converts inches cubed to cm cubed.                       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- inchCube - Inches cubed value                            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Double - Cm cubed value                                  -
    '------------------------------------------------------------
    Public Function inchCubeToCmCube(inchCube As Double) As Double
        Return inchCube * NUM_CM_CUBE_IN_INCH_CUBE
    End Function

    '------------------------------------------------------------
    '-             Function Name: cmCubeToInchCube              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Converts cm cubed to inches cubed.                       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- cmCube - Cm cubed value                                  -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Double - Inches cubed value                              -
    '------------------------------------------------------------
    Public Function cmCubeToInchCube(cmCube As Double) As Double
        Return cmCube * NUM_INCH_CUBE_IN_CM_CUBE
    End Function

    '------------------------------------------------------------
    '-                 Function Name: inchToCm                  -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Converts inches to cm                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- inch - Inches value                                      -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Double - Cm value                                        -
    '------------------------------------------------------------
    Public Function inchToCm(inch As Double) As Double
        Return inch * NUM_CM_IN_INCH
    End Function

    '------------------------------------------------------------
    '-                 Function Name: cmToInch                  -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Converts cm to inches                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- cm - Cm value                                            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Double - Inches value                                    -
    '------------------------------------------------------------
    Public Function cmToInch(cm As Double) As Double
        Return cm * NUM_INCH_IN_CM
    End Function
End Module
