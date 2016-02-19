Module modConversion
    Private Const NUM_CM_SQ_IN_INCH_SQ As Single = 6.4516
    Private Const NUM_CM_CUBE_IN_INCH_CUBE As Single = 16.3871
    Private Const NUM_INCH_SQ_IN_CM_SQ As Single = 0.155
    Private Const NUM_INCH_CUBE_IN_CM_CUBE As Single = 0.610237

    Public Function inchSqToCmSq(inchSq As Double) As Double
        Return inchSq * NUM_CM_SQ_IN_INCH_SQ
    End Function

    Public Function cmSqToInchSq(cmSq As Double) As Double
        Return cmSq * NUM_INCH_SQ_IN_CM_SQ
    End Function

    Public Function inchCubeToCmCube(inchCube As Double) As Double
        Return inchCube * NUM_CM_CUBE_IN_INCH_CUBE
    End Function

    Public Function cmCubeToInchCube(cmCube As Double) As Double
        Return cmCube * NUM_INCH_CUBE_IN_CM_CUBE
    End Function
End Module
