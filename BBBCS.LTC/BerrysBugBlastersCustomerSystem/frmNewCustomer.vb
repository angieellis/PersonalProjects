Imports System
Imports System.Data
Imports System.Data.SqlClient

' a (form) Class that handles the creation of a new customer record
Public Class frmNewCustomer
    Dim nextMonth As Date = DateAdd(DateInterval.Month, 1, Today())

    Private Sub frmNewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set default date values
        dtpEnrollmentDate.Value = Today()
        dtpNextService.Value = nextMonth
        dtpCardExp.Value = Today()

        gatherAccountNumber()
    End Sub

    ' query database for the next available account number and display in label
    Private Sub gatherAccountNumber()
        Dim returnValue As Integer
        returnValue = CType(CustomerInfoTableAdapter.AccountNumQuery(), Integer)
        setAccountNumber(returnValue)
        lblAccountNumValue.Text = getAccountNumber.ToString
    End Sub

    ' validating events
    Private Sub txtFirstName_Leave(sender As Object, e As EventArgs) Handles txtFirstName.Leave
        If txtFirstName.Text = "" Then
            ErrorProvider1.SetError(txtFirstName, "Please enter a first name")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtLastName_Leave(sender As Object, e As EventArgs) Handles txtLastName.Leave
        If txtLastName.Text = "" Then
            ErrorProvider1.SetError(txtLastName, "Please enter a last name")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtPhone_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        If txtPhone.MaskCompleted = False Then
            ErrorProvider1.SetError(txtPhone, "Invalid phone number")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtZip_Leave(sender As Object, e As EventArgs) Handles txtZip.Leave
        If txtZip.MaskCompleted = False Then
            ErrorProvider1.SetError(txtZip, "Invalid zip code")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtBillingZip_Leave(sender As Object, e As EventArgs) Handles txtBillingZip.Leave
        If txtBillingZip.MaskCompleted = False Then
            ErrorProvider1.SetError(txtBillingZip, "Invalid billing zip code")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtCardNumber_Leave(sender As Object, e As EventArgs) Handles txtCardNumber.Leave
        If txtCardNumber.MaskCompleted = False Then
            ErrorProvider1.SetError(txtCardNumber, "Invalid card number")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    ' an action listener sub routine that handles the setting of the billing address info
    ' copying when selected, and clearing when unchecked
    Private Sub chkSameAddress_CheckedChanged(sender As Object, e As EventArgs) Handles chkSameAddress.CheckedChanged
        Dim zip As Integer

        If chkSameAddress.Checked Then
            ' calling modules copy function
            ' customer information first
            setFirstName(txtFirstName.Text)
            setLastName(txtLastName.Text)
            setAddress1(txtAddressLine1.Text)
            setAddress2(txtAddressLine2.Text)
            lblAccountNumValue.Text = CStr(getAccountNumber())
            setCity(txtCity.Text)
            setState(cboState.Text)
            If Integer.TryParse(txtZip.Text, zip) Then
                setZip(zip)
            End If

            ' setting information that was inserted to clone
            setAddressInformationToBillingInformation()

            ' output results to billing's section
            txtBillingAddressLine1.Text = getBillingAddress1().ToString
            txtBillingAddressLine2.Text = getBillingAddress2().ToString
            txtBillingCity.Text = getBillingCity().ToString
            cboBillingState.Text = getBillingState().ToString
            txtBillingZip.Text = getBillingZip().ToString
        End If

        If (chkSameAddress.Checked = False) Then ' if unchecked
            ' clear the billing section
            clearBillingInformation()

            ' output results to billing's section that were just cleared
            txtBillingAddressLine1.Text = getBillingAddress1().ToString
            txtBillingAddressLine2.Text = getBillingAddress2().ToString
            txtBillingCity.Text = getBillingCity().ToString
            cboBillingState.Text = getBillingState().ToString
            txtBillingZip.Text = getBillingZip().ToString
        End If
    End Sub

    ' create a new database record; save all the values the user inserted to the new record
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim zip As Integer

        Try
            ' setting customer info section
            setAccountStatus(cboAccountStatus.Text)
            setServicePlan(cboServicePlan.Text)
            setEnrollmentDate(dtpEnrollmentDate.Value)
            setNextServiceDate(dtpNextService.Value)

            setFirstName(txtFirstName.Text)
            setLastName(txtLastName.Text)
            setPhoneNumber(txtPhone.Text)
            setAddress1(txtAddressLine1.Text)
            setAddress2(txtAddressLine2.Text)
            setCity(txtCity.Text)
            setState(cboState.Text)
            If Integer.TryParse(txtZip.Text, zip) Then
                setZip(zip)
            End If

            ' setting billing information 
            setBillingAddress1(txtBillingAddressLine1.Text)
            setBillingAddress2(txtBillingAddressLine2.Text)
            setBillingCity(txtBillingCity.Text)
            setBillingState(cboBillingState.Text)
            If Integer.TryParse(txtBillingZip.Text, zip) Then
                setBillingZip(zip)
            End If

            ' setting the card or check info
            If rdoCheck.Checked Then
                setCheckNumber(Integer.Parse(txtCheckNumber.Text))
                setCardType("")
                setCardNumber("")
                setCardExpiration(#1/1/1111#)
            ElseIf rdoCreditCard.Checked Then
                setCheckNumber(0)
                setCardType(cboCardType.Text)
                setCardNumber(txtCardNumber.Text)
                setCardExpiration(dtpCardExp.Value)
            Else
                setCardExpiration(#1/1/1111#)
            End If

            addRecordToDB()

            ' clear form after success
            clearForm()

            ' indicate a successful submission
            lblMessage.Text = "Contact written to the Database."
            gatherAccountNumber()

        Catch ex As Exception
            lblMessage.Text = "Error writing to Database"
        End Try
    End Sub

    ' insert customer record to the database
    Private Sub addRecordToDB()
        Try
            Me.CustomerInfoBindingSource.EndEdit()
            Me.CustomerInfoTableAdapter.InsertNewRow(getAccountNumber(), getFirstName(), getLastName(), getPhoneNumber(), getServicePlan(), getEnrollmentDate(), getNextServiceDate(), getAddress1(), getAddress2(), getCity(), getState(), getZip(), getBillingAddress1(), getBillingAddress2(), getBillingCity(), getBillingState(), getBillingZip(), getPaymentType(), getCheckNumber(), getCardType(), getCardNumber(), getCardExpiration(), getAccountStatus())
            Me.CustomerInfoTableAdapter.Update(Me.DbCustomerInfoDataSet.CustomerInfo)
        Catch ex As Exception
            lblMessage.Text = "Error writing to Database"
        End Try
    End Sub

    ' clear the contents of the form
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearForm()
    End Sub

    ' clear all values in the form and associated variable values
    Private Sub clearForm()
        setFirstName("")
        txtFirstName.Text = getFirstName()

        setLastName("")
        txtLastName.Text = getLastName()

        setAddress1("")
        txtAddressLine1.Text = getAddress1()

        setAddress2("")
        txtAddressLine2.Text = getAddress2()

        setCity("")
        txtCity.Text = getCity()

        setState("")
        cboState.Text = getState()

        setZip(0)
        txtZip.Text = getZip().ToString

        setPhoneNumber("")
        txtPhone.Text = getPhoneNumber()

        ' setting information that was inserted to clone of recently deleted info
        setAddressInformationToBillingInformation()

        ' output results to billing section
        txtBillingAddressLine1.Text = getBillingAddress1().ToString
        txtBillingAddressLine2.Text = getBillingAddress2().ToString
        txtBillingCity.Text = getBillingCity().ToString
        cboBillingState.Text = getBillingState().ToString
        txtBillingZip.Text = getBillingZip().ToString

        ' reset date values
        dtpEnrollmentDate.Value = Today()
        dtpNextService.Value = nextMonth
        dtpCardExp.Value = Today()

        'clear submission label
        lblMessage.Text = ""

        'clear billing section
        chkSameAddress.Checked = False
        rdoCheck.Checked = False
        rdoCreditCard.Checked = False
        setCardNumber("")
        txtCardNumber.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmBerrysBugMain.Show()
        Me.Close()
    End Sub
End Class



' additional validating events:
'        ' each time submit is selected a new account number is created. 
'        setAccountNumber(getAccountNumber())

'        ' first name validation
'        If validateField(txtFirstName.Text.Length) Then
'            setFirstName(txtFirstName.Text)
'        Else
'            ' frmError.txtErrorOutput.Text += "Insert Valid First Name Length" + vbCrLf
'            ErrorProvider1.SetError(txtFirstName, "Enter First Name")
'        End If

'        ' last name validation
'        If validateField(txtLastName.Text.Length) Then
'            setLastName(txtLastName.Text)
'        Else
'            ' frmError.txtErrorOutput.Text += "Insert Valid Last Name Length" + vbCrLf
'            ErrorProvider1.SetError(txtLastName, "Enter Last Name")
'        End If

'        'address line 1 validation
'        If validateField(txtAddressLine1.Text.Length) Then
'            setAddress1(txtAddressLine1.Text)
'        Else
'            ' frmError.txtErrorOutput.Text += "Insert Valid Address Length" + vbCrLf
'            ErrorProvider1.SetError(txtAddressLine1, "Enter Service Address")
'        End If

'        'optional address line 2, can be blank
'        setAddress2(txtAddressLine2.Text)

'        'can't alter this val
'        lblAccountNumValue.Text = CStr(CInt(getAccountNumber()))

'        If validateField(txtCity.Text.Length) Then
'            setCity(txtCity.Text)
'        Else
'            ' frmError.txtErrorOutput.Text += "Enter City Value" + vbCrLf
'            ErrorProvider1.SetError(txtCity, "Enter a City")
'        End If

'        If validateField(cboState.Text.Length) Then
'            setState(cboState.Text)
'        Else
'            ' frmError.txtErrorOutput.Text += "Select a State from the Drop Down" + vbCrLf
'            ErrorProvider1.SetError(cboState, "Select a State")
'        End If

'        If validateField(txtZip.Text.Length) Then
'            setZip(CInt(txtZip.Text))
'        Else
'            ' frmError.txtErrorOutput.Text += "Insert Valid entry for Zip Code" + vbCrLf
'            ErrorProvider1.SetError(txtZip, "Enter a Zipcode")
'        End If

'        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'        setEnrollmentDate(now)
'        setNextServiceDate(nextMonth)
'        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

'        If chkSameAddress.Checked Then
'            ' setting billing information 
'            setBillingAddress1(txtBillingAddressLine1.Text)
'            setBillingAddress2(txtBillingAddressLine2.Text)
'            setBillingCity(txtBillingCity.Text)
'            setBillingState(cboBillingState.Text)
'            setBillingZip(CInt(txtBillingZip.Text))
'        Else
'            setBillingAddress1("")
'            setBillingAddress2("")
'            setBillingCity("")
'            setBillingState("")
'            setBillingZip(0)
'        End If

'        'setting the card or check info
'        If rdoCheck.Checked Then
'            If validateField(txtCheckNumber.Text.Length) Then
'                setCheckNumber(Integer.Parse(txtCheckNumber.Text))
'            Else
'                ' frmError.txtErrorOutput.Text += "Insert a check number for Customer Check Payment Type" + vbCrLf
'                ErrorProvider1.SetError(txtCheckNumber, "Enter a Check Number")
'            End If

'        ElseIf rdoCreditCard.Checked Then
'            If validateField(cboCardType.Text.Length) Then
'                setCardType(cboCardType.Text)
'            Else
'                ' frmError.txtErrorOutput.Text += "Enter Customer Credit Card Number" + vbCrLf
'                ErrorProvider1.SetError(cboCardType, "Select a Card Type")
'            End If

'            If validateField(txtCardNumber.Text.Length) Then
'                setCardNumber(txtCardNumber.Text)
'            Else
'                ErrorProvider1.SetError(txtCardNumber, "Enter a Card Number")
'            End If

'            If dtpCardExp.Value = now Then
'                setCardExpiration(Date.Parse(dtpCardExp.Text))
'            Else
'                ErrorProvider1.SetError(dtpCardExp, "Select a Card Expiration Date")
'            End If
'        End If
'    End If
'   Catch ex As Exception
'        lblSubmission.Text = "Please enter valid input"
'   End Try
