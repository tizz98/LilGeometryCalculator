'------------------------------------------------------------
'-               File Name: modFixtureData.vb               -
'-                 Part of Project: Assign6                 -
'------------------------------------------------------------
'-                Written By: Elijah Wilson                 -
'-                  Written On: 02/20/2016                  -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- Contains fixture data to be used for the default         -
'- calculator form. Shapes and their formula.               -
'------------------------------------------------------------
Module modFixtureData
    Public shapes As List(Of Shape) = Nothing

    '------------------------------------------------------------
    '-                Subprogram Name: setupData                -
    '------------------------------------------------------------
    '-                Written By: Elijah Wilson                 -
    '-                  Written On: 02/20/2016                  -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- Sets up the shapes data.                                 -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- frmla - A Formula object used a temporary holder of a    -
    '-         Formula                                          -
    '- shp - A Shape object used as a temporary holder of a     -
    '-       Shape                                              -
    '------------------------------------------------------------
    Public Sub setupData()
        ' Only setup data once
        If Not IsNothing(shapes) Then
            Return
        End If

        shapes = New List(Of Shape)

        Dim shp As Shape
        Dim frmla As Formula

#Region "2D- Rectangle"
        shp = New Shape("2D - Rectangle", "rectangle.jpg")
        frmla = New Formula("Perimeter", 2, Function(l, w) (2 * l) + (2 * w),
                            Formula.ConversionType.dimen1)
        frmla.setFormulaInputNames("L", "W")
        shp.addFormula(frmla)

        frmla = New Formula("Area", 2, Function(l, w) l * w,
                            Formula.ConversionType.dimen2)
        frmla.setFormulaInputNames("L", "W")
        shp.addFormula(frmla)

        shapes.Add(shp)
#End Region

#Region "2D - Square"
        shp = New Shape("2D - Square", "square.jpg")
        frmla = New Formula("Perimeter", 1, Function(l) 4 * l,
                            Formula.ConversionType.dimen1)
        frmla.setFormulaInputNames("L")
        shp.addFormula(frmla)

        frmla = New Formula("Area", 1, Function(l) Math.Pow(l, 2),
                            Formula.ConversionType.dimen2)
        frmla.setFormulaInputNames("L")
        shp.addFormula(frmla)

        shapes.Add(shp)
#End Region

#Region "2D - Right Triangle"
        shp = New Shape("2D - Right Triangle", "triangle.jpg")
        frmla = New Formula("Perimeter", 2,
                            Function(b, h) h + b + Math.Sqrt(Math.Pow(h, 2) + Math.Pow(b, 2)),
                            Formula.ConversionType.dimen1)
        frmla.setFormulaInputNames("B", "H")
        shp.addFormula(frmla)

        frmla = New Formula("Area", 2, Function(b, h) (b * h) / 2,
                            Formula.ConversionType.dimen2)
        frmla.setFormulaInputNames("B", "H")
        shp.addFormula(frmla)

        shapes.Add(shp)
#End Region

#Region "2D - Circle"
        shp = New Shape("2D - Circle", "circle.jpg")
        frmla = New Formula("Circumference", 1, Function(r) 2 * Math.PI * r,
                            Formula.ConversionType.dimen1)
        frmla.setFormulaInputNames("R")
        shp.addFormula(frmla)

        frmla = New Formula("Area", 1, Function(r) Math.PI * Math.Pow(r, 2),
                            Formula.ConversionType.dimen2)
        frmla.setFormulaInputNames("R")
        shp.addFormula(frmla)

        shapes.Add(shp)
#End Region

#Region "3D - Cube"
        shp = New Shape("3D - Cube", "cube.jpg")
        frmla = New Formula("Volume", 3, Function(h, w, l) h * w * l,
                            Formula.ConversionType.dimen3)
        frmla.setFormulaInputNames("H", "W", "L")
        shp.addFormula(frmla)

        frmla = New Formula("Surface Area", 3,
                            Function(h, w, l) (2 * l * w) + (2 * l * h) + (2 * w * h),
                            Formula.ConversionType.dimen2)
        frmla.setFormulaInputNames("H", "W", "L")
        shp.addFormula(frmla)

        shapes.Add(shp)
#End Region

#Region "3D - Sphere"
        shp = New Shape("3D - Sphere", "sphere.jpg")
        frmla = New Formula("Volume", 1, Function(r) (4.0 / 3.0) * Math.PI * Math.Pow(r, 3),
                            Formula.ConversionType.dimen3)
        frmla.setFormulaInputNames("R")
        shp.addFormula(frmla)

        frmla = New Formula("Surface Area", 1, Function(r) 4 * Math.PI * Math.Pow(r, 2),
                            Formula.ConversionType.dimen2)
        frmla.setFormulaInputNames("R")
        shp.addFormula(frmla)

        shapes.Add(shp)
#End Region

#Region "3D - Cylinder"
        shp = New Shape("3D- Cylinder", "cylinder.jpg")
        frmla = New Formula("Volume", 2, Function(r, h) Math.PI * Math.Pow(r, 2) * h,
                            Formula.ConversionType.dimen3)
        frmla.setFormulaInputNames("R", "H")
        shp.addFormula(frmla)

        frmla = New Formula("Surface Area", 2,
                            Function(r, h) 2 * Math.PI * r * h + 2 * Math.PI * Math.Pow(r, 2),
                            Formula.ConversionType.dimen2)
        frmla.setFormulaInputNames("R", "H")
        shp.addFormula(frmla)

        shapes.Add(shp)
#End Region

#Region "3D - Cone"
        shp = New Shape("3D - Cone", "cone.jpg")
        frmla = New Formula("Volume", 2, Function(r, h) (1.0 / 3.0) * Math.PI * Math.Pow(r, 2) * h,
                            Formula.ConversionType.dimen3)
        frmla.setFormulaInputNames("R", "H")
        shp.addFormula(frmla)

        frmla = New Formula("Surface Area", 2,
                            Function(r, h) (Math.PI * r) * (r + Math.Sqrt(Math.Pow(r, 2) + Math.Pow(h, 2))),
                            Formula.ConversionType.dimen2)
        frmla.setFormulaInputNames("R", "H")
        shp.addFormula(frmla)

        shapes.Add(shp)
#End Region
    End Sub
End Module
