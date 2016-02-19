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

    Public Sub New(name As String, numInputs As Integer, cDim As ConversionType)
        Me.name = name
        Me.numInputs = numInputs
        Me.conversionDimension = cDim
    End Sub

    Public Sub New(name As String, numInputs As Integer,
                   formulaFunc3Input As Func(Of Double, Double, Double, Double), cDim As ConversionType)
        Me.New(name, numInputs, cDim)
        Me.formulaFunc3Input = formulaFunc3Input
    End Sub

    Public Sub New(name As String, numInputs As Integer,
                   formulaFunc2Input As Func(Of Double, Double, Double), cDim As ConversionType)
        Me.New(name, numInputs, cDim)
        Me.formulaFunc2Input = formulaFunc2Input
    End Sub

    Public Sub New(name As String, numInputs As Integer,
                   formulaFunc2Input As Func(Of Double, Double), cDim As ConversionType)
        Me.New(name, numInputs, cDim)
        Me.formulaFunc1Input = formulaFunc1Input
    End Sub

    Public Sub setFormulaInputs(input1 As Double, input2 As Double, input3 As Double)
        Me.formulaInput1 = input1
        Me.formulaInput2 = input2
        Me.formulaInput3 = input3
    End Sub

    Public Sub setFormulaInputs(input1 As Double, input2 As Double)
        setFormulaInputs(input1, input2, -1)
    End Sub

    Public Sub setFormulaInputs(input1 As Double)
        setFormulaInputs(input1, -1, -1)
    End Sub

    Public Sub setFormulaInputNames(name1 As String, name2 As String, name3 As String)
        Me.input1Name = name1
        Me.input2Name = name2
        Me.input3Name = name3
    End Sub

    Public Sub setFormulaInputNames(name1 As String, name2 As String)
        setFormulaInputNames(name1, name2, Nothing)
    End Sub

    Public Sub setFormulaInputNames(name1 As String)
        setFormulaInputNames(name1, Nothing, Nothing)
    End Sub

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
