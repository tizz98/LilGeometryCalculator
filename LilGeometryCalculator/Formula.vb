'------------------------------------------------------------
'-                  File Name: Formula.vb                   -
'-                 Part of Project: Assign6                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 02/20/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- Contains the Formula class.                              -
'------------------------------------------------------------
Public Class Formula
    Public name As String

    Public formulaFunc3Input As Func(Of Double, Double, Double, Double)
    Public formulaFunc2Input As Func(Of Double, Double, Double)
    Public formulaFunc1Input As Func(Of Double, Double)

    Public MetricToUsConversionFunc As Func(Of Double, Double)
    Public UsToMetricConversionFunc As Func(Of Double, Double)

    Public metricUnitsName As String
    Public usUnitsName As String

    Private conversionDimension As ConversionType

    Public formulaInput1 As Double
    Public formulaInput2 As Double  ' may not be used
    Public formulaInput3 As Double  ' may not be used

    Public numInputs As Integer

    Public input1Name As String
    Public input2Name As String  ' may not be used
    Public input3Name As String  ' may not be used

    Public Enum ConversionType
        dimen1
        dimen2
        dimen3
    End Enum

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Create a new Formula object                              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name - The name of the Formula                           -
    '- numInputs - How many inputs the formula has              -
    '- cDim - How many dimensions the units have                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(name As String, numInputs As Integer, cDim As ConversionType)
        Me.name = name
        Me.numInputs = numInputs
        Me.conversionDimension = cDim
    End Sub

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Create a new Formula object                              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name - The name of the Formula                           -
    '- numInputs - How many inputs the formula has              -
    '- formulaFunc3Input - The Function with 3 inputs to be     -
    '-                     used for calculating an answer       -
    '- cDim - The number of dimensions for the units            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(name As String, numInputs As Integer,
                   formulaFunc3Input As Func(Of Double, Double, Double, Double), cDim As ConversionType)
        Me.New(name, numInputs, cDim)
        Me.formulaFunc3Input = formulaFunc3Input
    End Sub

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Create a new Formula object                              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name - The name of the Formula                           -
    '- numInputs - How many inputs the formula has              -
    '- formulaFunc2Input - The 2 input function to be used for  -
    '-                     calculating the answer               -
    '- cDim - How many dimensions the units have                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(name As String, numInputs As Integer,
                   formulaFunc2Input As Func(Of Double, Double, Double), cDim As ConversionType)
        Me.New(name, numInputs, cDim)
        Me.formulaFunc2Input = formulaFunc2Input
    End Sub

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Create a new Formula object                              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name - The name of the formula                           -
    '- numInputs - How many inputs the formula has              -
    '- formulaFunc1Input - The 1 input function for calculating -
    '-                     the answer                           -
    '- cDim - How many dimensions the units have                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(name As String, numInputs As Integer,
                   formulaFunc1Input As Func(Of Double, Double), cDim As ConversionType)
        Me.New(name, numInputs, cDim)
        Me.formulaFunc1Input = formulaFunc1Input
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: setFormulaInputs             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Set the formula inputs.                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- input1 - The first input for the formula                 -
    '- input2 - The second input for the formula                -
    '- input3 - The third input for the formula                 -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub setFormulaInputs(input1 As Double, input2 As Double, input3 As Double)
        Me.formulaInput1 = input1
        Me.formulaInput2 = input2
        Me.formulaInput3 = input3
    End Sub

    '------------------------------------------------------------
    '-          Subprogram Name: setFormulaInputNames           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Set the formula inputs names.                            -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name1 - The first input name                             -
    '- name2 - The second input name                            -
    '- name3 - The third input name                             -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub setFormulaInputNames(name1 As String, name2 As String, name3 As String)
        Me.input1Name = name1
        Me.input2Name = name2
        Me.input3Name = name3
    End Sub

    '------------------------------------------------------------
    '-          Subprogram Name: setFormulaInputNames           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Set the formula inputs names.                            -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name1 - The first input name                             -
    '- name2 - The second input name                            -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub setFormulaInputNames(name1 As String, name2 As String)
        setFormulaInputNames(name1, name2, Nothing)
    End Sub

    '------------------------------------------------------------
    '-          Subprogram Name: setFormulaInputNames           -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Set the formula inputs names.                            -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- name1 - The first input name                             -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub setFormulaInputNames(name1 As String)
        setFormulaInputNames(name1, Nothing, Nothing)
    End Sub

    '------------------------------------------------------------
    '-              Function Name: calculateAnswer              -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Calculates the answer to the formula based on the number -
    '- of inputs                                                -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Double - The calculated answer to the formula            -
    '------------------------------------------------------------
    Public Function calculateAnswer() As Double
        If numInputs = 1 Then
            Return Me.formulaFunc1Input(Me.formulaInput1)
        ElseIf numInputs = 2 Then
            Return Me.formulaFunc2Input(Me.formulaInput1, Me.formulaInput2)
        ElseIf numInputs = 3 Then
            Return Me.formulaFunc3Input(Me.formulaInput1, Me.formulaInput2, Me.formulaInput3)
        End If

        Return 0
    End Function

    '------------------------------------------------------------
    '-             Function Name: convertMetricToUs             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Calculates a metric unit to US units based on the stored -
    '- dimension.                                               -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- metric - The metric value                                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Double - The US value                                    -
    '------------------------------------------------------------
    Public Function convertMetricToUs(metric As Double) As Double
        Select Case Me.conversionDimension
            Case ConversionType.dimen1
                Return modConversion.cmToInch(metric)
            Case ConversionType.dimen2
                Return modConversion.cmSqToInchSq(metric)
            Case ConversionType.dimen3
                Return modConversion.cmCubeToInchCube(metric)
        End Select

        Return metric
    End Function

    '------------------------------------------------------------
    '-             Function Name: convertUsToMetric             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Calculates a US unit to metric units based on the stored -
    '- dimension.                                               -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- us - The US value                                        -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Double - The metric value                                -
    '------------------------------------------------------------
    Public Function convertUsToMetric(us As Double) As Double
        Select Case Me.conversionDimension
            Case ConversionType.dimen1
                Return modConversion.inchToCm(us)
            Case ConversionType.dimen2
                Return modConversion.inchSqToCmSq(us)
            Case ConversionType.dimen3
                Return modConversion.inchCubeToCmCube(us)
        End Select

        Return us
    End Function

    '------------------------------------------------------------
    '-               Function Name: getUsUnitName               -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Gets the US units name based on the dimension stored.    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - The US units name                               -
    '------------------------------------------------------------
    Public Function getUsUnitName() As String
        Select Case Me.conversionDimension
            Case ConversionType.dimen1
                Return "inch"
            Case ConversionType.dimen2
                Return "sq in"
            Case ConversionType.dimen3
                Return "cu in"
        End Select

        Return Nothing
    End Function

    '------------------------------------------------------------
    '-             Function Name: getMetricUnitName             -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- Gets the metric units name based on the dimension        -
    '- stored.                                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String - The metric units name                           -
    '------------------------------------------------------------
    Public Function getMetricUnitName() As String
        Select Case Me.conversionDimension
            Case ConversionType.dimen1
                Return "cm"
            Case ConversionType.dimen2
                Return "sq cm"
            Case ConversionType.dimen3
                Return "cu cm"
        End Select

        Return Nothing
    End Function
End Class
