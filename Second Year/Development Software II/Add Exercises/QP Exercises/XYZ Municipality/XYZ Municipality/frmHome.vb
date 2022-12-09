Option Explicit On
Option Strict Off
Option Infer On

Imports System.Globalization
Public Class frmHome
    ReadOnly TIObject As Object = New CultureInfo("en-US", False).TextInfo

    Public FormClose As Int32 = 0

    '                                   Variables To Use in Both Forms (home and Calculations) in Class-Level Scope
    'Input Variables
    Public NameofOwner As String
    Public NameofStreet As String
    Public Suburb As String
    Public City As String
    Public Province As String
    Public Postal As String ' before  --> (Int16 'Short Integer Value)
    Public HouseArea As Double
    Public LandArea As Double
    Public HouseAgeYears As Int32

    'Calculations Variables
    Public HouseTax As Double
    Public LandTax As Double
    Public Discount As Double
    Public PropertyTax_Year As Double
    Public PropertyTax_Month As Double

    'Variable For Whole Address
    Public Address As String


    'Display MessageBox And Wait For Confirmation Before Closing Form
    Private Sub frmHome_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If FormClose = 0 Then
            Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    e.Cancel = False
                Case DialogResult.No
                    e.Cancel = True
            End Select
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        cboProvince.Cursor = Cursors.Hand
        cboProvince.Items.Add("Limpopo")
        cboProvince.Items.Add("Gauteng")
        cboProvince.Items.Add("North West")
        cboProvince.Items.Add("Mpumalanga")
        cboProvince.Items.Add("Northern Cape")
        cboProvince.Items.Add("Free State")
        cboProvince.Items.Add("Kwa-Zulu Natal")
        cboProvince.Items.Add("Western Cape")
        cboProvince.Items.Add("Eastern Cape")

        cboProvince.SelectedItem = cboProvince.Items(1)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        FormClose = 1
        Select Case MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                FormClose = 0
                Exit Sub
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Select Case MessageBox.Show("Are You Sure You Want To Clear?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                txtName.Clear()
                txtStreetName.Clear()
                txtSuburb.Clear()
                txtCity.Clear()
                txtPostalCode.Clear()
                txtHouseArea.Clear()
                txtLandArea.Clear()
                txtHouseAge.Clear()
                cboProvince.SelectedItem = cboProvince.Items(1)
                txtName.Focus()
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    'Validating Name of Property Owner
    Function OwnerName(ByRef Name As String, ByRef Type As Int32) As Boolean
        If (Name.Trim() <> "") Then
            Name = Name.Trim().ToUpper()
            For P As Int32 = 0 To Name.Length() - 1
                Select Case Name.Substring(P, 1)
                    Case "A" To "Z", " "
                        'OwnerName is Valid 
                    Case Else
                        Type = 1 'Invalid Charatcers
                        Return False
                End Select
            Next
            Name = Name.ToLower()
            Name = CStr(TIObject.ToTitleCase(Name))
        Else
            Type = 0 'Empty
            Return False
        End If
        'Valid Characters
        Return True
    End Function

    'Validating Street Name
    Function StreetName(ByRef Name As String, ByRef Type As Int32) As Boolean
        If (Name.Trim() <> "") Then
            Name = Name.Trim().ToUpper()
            For P As Int32 = 0 To Name.Length() - 1
                Select Case Name.Substring(P, 1)
                    Case "A" To "Z", " ", "0" To "9", "-"
                        'Street Name is Valid 
                    Case Else
                        Type = 1 'Invalid Characters
                        Return False
                End Select
            Next
            Name = Name.ToLower()
            Name = TIObject.ToTitleCase(Name)
        Else
            Type = 0 'Empty
            Return False
        End If
        'Valid Characters
        Return True
    End Function

    'Validating Suburb & City
    Function SuburbCity(ByRef Name As String, ByRef Type As Int32) As Boolean
        If (Name.Trim() <> "") Then
            Name = Name.Trim().ToUpper()
            For P As Int32 = 0 To Name.Length() - 1
                Select Case Name.Substring(P, 1)
                    Case "A" To "Z", " ", "-"
                        'Suburb is Valid 
                    Case Else
                        Type = 1 'Invalid Characters
                        Return False
                End Select
            Next
            Name = Name.ToLower()
            Name = TIObject.ToTitleCase(Name)
        Else
            Type = 0 'Empty
            Return False
        End If
        'Valid Characters
        Return True
    End Function

    'Validating Postal Code
    Function PostalCode(ByRef Value As String, ByRef Type As Int32) As Boolean
        If (Value.Trim() <> "") Then
            Value = Value.Trim()
            If IsNumeric(Value) Then
                For P As Int32 = 0 To Value.Length() - 1
                    Select Case Value.Substring(P, 1)
                        Case " "
                            Type = 2 'Contains A Space Character
                            Return False
                        Case ","
                            Type = 3 'Contains A Comma
                            Return False
                        Case Else
                            'Valid and Numeric (Whole Number)
                    End Select
                Next

                'Checking The Length of The Postal Code
                If Value.Length() = 4 Then
                    ' Postal Code is Valid
                Else
                    Type = 4 ' Values Length Is Not Equal To 4
                    Return False
                End If

                'Checking The Code if is not 0000 or Less
                If CInt(Value) > 0 Then
                    ' Postal Code is Valid and Not 0000 or Less
                Else
                    Type = 5 ' Postal Code is 0000 or Less
                    Return False
                End If
            Else
                Type = 1 'Not Numeric
                Return False
            End If
        Else
            Type = 0 'Empty
            Return False
        End If
        'Valid and Numeric (Whole Number) of 4 Digits
        Return True
    End Function

    'Validating House & Land Area
    Function HouseLandArea(ByRef Value As String, ByRef Type As Int32) As Boolean
        If (Value.Trim() <> "") Then
            Value = Value.Trim()
            If IsNumeric(Value) Then
                For P As Int32 = 0 To Value.Length() - 1
                    Select Case Value.Substring(P, 1)
                        Case " "
                            Type = 2 'Contains A Space Character
                            Return False
                        Case Else
                            'Valid and Numeric
                    End Select
                Next
                If CDbl(Value) > 0 Then
                    ' House or Land Area is Valid and Greater Than 0m²
                Else
                    Type = 3 ' House or Land Area is Invalid and Equal or Less Than 0m²
                    Return False
                End If
            Else
                Type = 1 'Not Numeric
                Return False
            End If
        Else
            Type = 0 'Empty
            Return False
        End If
        'Valid House or Land Area and Greater than 0m²
        Return True
    End Function

    'Validating House Age (Years)
    Function HouseAge(ByRef Value As String, ByRef Type As Int32) As Boolean
        'Using Function Name (HouseAge) To Return Value
        If Value.Trim() <> "" Then
            Value = Value.Trim()
            If IsNumeric(Value) Then
                For P As Int32 = 0 To Value.Length() - 1
                    Select Case Value.Substring(P, 1)
                        Case " "
                            Type = 2 'Contains A Space Character
                            HouseAge = False
                            Exit Function
                        Case ","
                            Type = 3 'Contains A Comma
                            HouseAge = False
                            Exit Function
                        Case Else
                            'Valid and Numeric (Whole Number)
                    End Select
                Next
                If CInt(Value) > 0 Then
                    ' House Age is Greater Than 0
                Else
                    Type = 4 ' House Age is Equal or Less Than 0
                    HouseAge = False
                    Exit Function
                End If
            Else
                Type = 1 'Not Numeric
                HouseAge = False
                Exit Function
            End If
        Else
            Type = 0 'Empty
            HouseAge = False
            Exit Function
        End If
        'House Age is Valid And Greater Than 0
        HouseAge = True
        'Exit Function (Optional)
    End Function


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Type As Int32

        'Validate Property's Owner Name Using OwnerName Function Procedure
        NameofOwner = txtName.Text
        If Not (OwnerName(NameofOwner, Type)) Then
            If (Type = 0) Then
                MessageBox.Show("Input Name of Propery's Owner", "Property's Owner", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtName.Clear()
                txtName.Focus()
                Exit Sub
            End If
            If (Type = 1) Then
                MessageBox.Show("Name of Propery's Owner Must Be Alphabetic", "Property's Owner", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtName.Clear()
                txtName.Focus()
                Exit Sub
            End If
        End If

        'Validate Street Name of Property using StreetName Function Procedure
        NameofStreet = txtStreetName.Text
        If Not (StreetName(NameofStreet, Type)) Then
            If (Type = 0) Then
                MessageBox.Show("Input Street Name", "Street Name", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtStreetName.Clear()
                txtStreetName.Focus()
                Exit Sub
            End If
            If (Type = 1) Then
                MessageBox.Show("Street Name Must Be AlphaNumeric " & vbCrLf & vbCrLf & "Cannot Contain Other Characters Except For Dash (-)", "Street Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStreetName.Clear()
                txtStreetName.Focus()
                Exit Sub
            End If
        End If


        'Validate Suburb Name of Property using SuburbCity Function Procedure
        Suburb = txtSuburb.Text
        If Not (SuburbCity(Suburb, Type)) Then
            If (Type = 0) Then
                MessageBox.Show("Input Suburb Name", "Suburb Name", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtSuburb.Clear()
                txtSuburb.Focus()
                Exit Sub
            End If
            If (Type = 1) Then
                MessageBox.Show("Suburb Name Must Be Alphabetic", "Suburb Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSuburb.Clear()
                txtSuburb.Focus()
                Exit Sub
            End If
        End If


        'Validate City Name of Property using SuburbCity Function Procedure
        City = txtCity.Text
        If Not (SuburbCity(City, Type)) Then
            If (Type = 0) Then
                MessageBox.Show("Input City Name", "City Name", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtCity.Clear()
                txtCity.Focus()
                Exit Sub
            End If
            If (Type = 1) Then
                MessageBox.Show("City Name Must Be Alphabetic", "City Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCity.Clear()
                txtCity.Focus()
                Exit Sub
            End If
        End If

        'Value for Province Name
        Province = CStr(cboProvince.SelectedItem)


        'Validate Postal Code using PostalCode Function Procedure
        Dim PHLValue As String = txtPostalCode.Text
        If PostalCode(Type:=Type, Value:=PHLValue) Then
            'Postal Code is Valid and is Between 0001 & 9999
            Postal = PHLValue
        Else
            If (Type = 0) Then
                MessageBox.Show("Input Postal Code", "Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtPostalCode.Clear()
                txtPostalCode.Focus()
                Exit Sub
            End If
            If (Type = 1) Then
                MessageBox.Show("Postal Code Must Be Numeric", "Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPostalCode.Clear()
                txtPostalCode.Focus()
                Exit Sub
            End If
            If (Type = 2) Then
                MessageBox.Show("Postal Code Must Be A Whole Number Without A Space Character", "Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPostalCode.Clear()
                txtPostalCode.Focus()
                Exit Sub
            End If
            If (Type = 3) Then
                MessageBox.Show("Postal Code Must Be A Whole Number", "Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPostalCode.Clear()
                txtPostalCode.Focus()
                Exit Sub
            End If
            If (Type = 4) Then
                MessageBox.Show("Postal Code Must Be 4 Digits", "Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPostalCode.Clear()
                txtPostalCode.Focus()
                Exit Sub
            End If
            If (Type = 5) Then
                MessageBox.Show("Postal Code Must Be Between 0001 & 9999 ", "Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPostalCode.Clear()
                txtPostalCode.Focus()
                Exit Sub
            End If
        End If


        'Validate House Area Using HouseLandArea Function Procedure
        PHLValue = txtHouseArea.Text
        If (HouseLandArea(Type:=Type, Value:=PHLValue)) Then
            'Valid House Area and Greater than 0m²
            HouseArea = Double.Parse(PHLValue)
        Else
            If (Type = 0) Then
                MessageBox.Show("Input House Area (m²)", "House Area", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtHouseArea.Clear()
                txtHouseArea.Focus()
                Exit Sub
            End If
            If (Type = 1) Then
                MessageBox.Show("House Area Must Be Numeric", "House Area", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHouseArea.Clear()
                txtHouseArea.Focus()
                Exit Sub
            End If
            If (Type = 2) Then
                MessageBox.Show("House Area Must Be Numeric Without A Space Character", "House Area", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHouseArea.Clear()
                txtHouseArea.Focus()
                Exit Sub
            End If
            If (Type = 3) Then
                MessageBox.Show("House Area Must Be Greater Than 0m²", "House Area", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHouseArea.Clear()
                txtHouseArea.Focus()
                Exit Sub
            End If
        End If


        'Validate Land Area Using HouseLandArea Function Procedure
        PHLValue = txtLandArea.Text
        If (HouseLandArea(Type:=Type, Value:=PHLValue)) Then
            'Valid Land Area and Greater than 0m²
            LandArea = Double.Parse(PHLValue)
        Else
            If (Type = 0) Then
                MessageBox.Show("Input Land Area (m²)", "Land Area", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtLandArea.Clear()
                txtLandArea.Focus()
                Exit Sub
            End If
            If (Type = 1) Then
                MessageBox.Show("Land Area Must Be Numeric", "Land Area", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLandArea.Clear()
                txtLandArea.Focus()
                Exit Sub
            End If
            If (Type = 2) Then
                MessageBox.Show("Land Area Must Be Numeric Without A Space Character", "Land Area", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLandArea.Clear()
                txtLandArea.Focus()
                Exit Sub
            End If
            If (Type = 3) Then
                MessageBox.Show("Land Area Must Be Greater Than 0m²", "Land Area", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLandArea.Clear()
                txtLandArea.Focus()
                Exit Sub
            End If
        End If


        'Validate House Age (Years) Using HouseAge Function Procedure
        PHLValue = txtHouseAge.Text
        If (HouseAge(Type:=Type, Value:=PHLValue)) Then
            'Valid House Age and Greater than 0
            HouseAgeYears = Integer.Parse(PHLValue)
        Else
            If (Type = 0) Then
                MessageBox.Show("Input House Age (Years)", "House Age", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtHouseAge.Clear()
                txtHouseAge.Focus()
                Exit Sub
            End If
            If (Type = 1) Then
                MessageBox.Show("House Age Must Be Numeric", "House Age", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHouseAge.Clear()
                txtHouseAge.Focus()
                Exit Sub
            End If
            If (Type = 2) Then
                MessageBox.Show("House Age Must Be A Whole Number Without A Space Character", "House Age", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHouseAge.Clear()
                txtHouseAge.Focus()
                Exit Sub
            End If
            If (Type = 3) Then
                MessageBox.Show("House Age Must Be A Whole Number", "House Age", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHouseAge.Clear()
                txtHouseAge.Focus()
                Exit Sub
            End If
            If (Type = 4) Then
                MessageBox.Show("House Age Must Be Greater Than 0 Years", "House Age", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHouseAge.Clear()
                txtHouseAge.Focus()
                Exit Sub
            End If
        End If


        '                                                       'CALCULATIONS
        'House Tax Calculation
        If (HouseArea <= 100) Then
            HouseTax = HouseArea * 10
        ElseIf (HouseArea > 100 And HouseArea <= 200) Then
            HouseTax = (HouseArea - 100) * 11 + 1000
        ElseIf (HouseArea > 200 And HouseArea <= 300) Then
            HouseTax = (HouseArea - 200) * 12 + 2100
        ElseIf (HouseArea > 300 And HouseArea <= 400) Then
            HouseTax = (HouseArea - 300) * 13 + 3300
        ElseIf (HouseArea > 400 And HouseArea <= 500) Then
            HouseTax = (HouseArea - 400) * 14 + 4600
        ElseIf (HouseArea > 500) Then
            HouseTax = (HouseArea - 500) * 17 + 6000
        End If

        'Land Tax Calculation
        If (LandArea <= 1000) Then
            LandTax = LandArea * 1
        ElseIf (LandArea > 1000 And LandArea <= 2000) Then
            LandTax = (LandArea - 1000) * 1.5 + 1000
        ElseIf (LandArea > 2000) Then
            LandTax = (LandArea - 2000) * 2.5 + 2500
        End If

        'Discount Calculation
        If (HouseAgeYears < 5) Then
            Discount = 0
        ElseIf (HouseAgeYears >= 5 And HouseAgeYears <= 19) Then
            Discount = (HouseTax + LandTax) * (7.5 / 100)
        ElseIf (HouseAgeYears >= 20) Then
            Discount = (HouseTax + LandTax) * (25 / 100)
        End If

        'Property Year Tax & Month Tax
        PropertyTax_Year = HouseTax + LandTax - Discount
        PropertyTax_Month = PropertyTax_Year / 12

        'Rounding-Off Values
        HouseArea = Math.Round(HouseArea, 2)
        LandArea = Math.Round(LandArea, 2)
        HouseTax = Math.Round(HouseTax, 2)
        LandTax = Math.Round(LandTax, 2)
        Discount = Math.Round(Discount, 2)
        PropertyTax_Year = Math.Round(PropertyTax_Year, 2)
        PropertyTax_Month = Math.Round(PropertyTax_Month, 2)


        'Creating Full Address (Each Value on New Line)
        Address = "Street Name: " & NameofStreet & vbCrLf &
            "Suburb: " & Suburb & vbCrLf &
            "City: " & City & vbCrLf &
            "Province: " & Province & vbCrLf &
            "Postal Code: " & Postal & vbCrLf

        'Opening Second Form To Display Information
        frmCalculations.Show()

        'Hiding The Home Page Form 
        Me.Hide()
    End Sub
End Class