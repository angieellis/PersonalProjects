Imports System
Imports System.Data
Imports System.Data.SqlClient

' form to lookup and update customer records
Public Class frmLookUpCustomer

    Private Sub frmLookUpCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' populate form with customer values if search was performed
        If getSelectedAccount() > -1 Then
            btnEditInfo.Enabled = True
            lblAccountNumValue.Text = CStr(getAccountNumber())
            Me.CustomerInfoTableAdapter.FillBySearch(Me.DbCustomerInfoDataSet.CustomerInfo, getSelectedAccount())
        End If
    End Sub

    ' when the last name radio button is selected
    Private Sub rdoLastName_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLastName.CheckedChanged
        lblLookupOption.Text = "Last Name"
    End Sub

    ' when the Account number radio button is selected
    Private Sub rdoAccountNum_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAccountNum.CheckedChanged
        lblLookupOption.Text = "Account Number"
    End Sub

    ' when the Phone number radio button is selected
    Private Sub rdoPhone_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPhone.CheckedChanged
        lblLookupOption.Text = "Phone Number"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear radio buttons
        rdoPhone.Checked = False
        rdoLastName.Checked = False
        rdoAccountNum.Checked = False

        lblLookupOption.Text = "<Selected Option>" 'clearing the selected option label
    End Sub

    ' set values for database query; open search form
    Private Sub btnLookup_Click(sender As Object, e As EventArgs) Handles btnLookup.Click
        Try
            If txtLookupCustomer.Text = "" Then
                setLookupCategory("null")
            ElseIf rdoAccountNum.Checked Then
                Dim i As Integer
                Integer.TryParse(txtLookupCustomer.Text, i)
                setLookupValInt(i)
                setLookupCategory("accountNumber")
            ElseIf rdoLastName.Checked Then
                setLookupVal(txtLookupCustomer.Text)
                setLookupCategory("lastName")
            ElseIf rdoPhone.Checked Then
                setLookupVal(txtLookupCustomer.Text)
                setLookupCategory("phoneNumber")
            End If

            frmSearchResults.Visible = True
            Me.Close()
        Catch ex As Exception
            lblMessage.Text = "Error executing search"
        End Try
    End Sub

    ' when the panel is enabled and the Edit button is selected, the user can edit the Text Boxes and Save.
    ' until this button is selected, the text boxes are read only.
    Private Sub btnEditInfo_Click(sender As Object, e As EventArgs) Handles btnEditInfo.Click
        enableTextBoxes()
    End Sub

    ' a sub to enable the text boxes and buttons on the look up form
    Private Sub enableTextBoxes()
        txtAddressLine1.Enabled = True
        txtAddressLine2.Enabled = True
        txtBillingAddressLine1.Enabled = True
        txtBillingAddressLine2.Enabled = True
        txtBillingCity.Enabled = True
        txtBillingZip.Enabled = True
        txtCity.Enabled = True
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        dtpNextService.Enabled = True
        txtPhone.Enabled = True
        txtZip.Enabled = True
        cboServicePlan.Enabled = True
        cboState.Enabled = True
        cboAccountStatus.Enabled = True
        cboBillingState.Enabled = True
        btnEditInfo.Enabled = True
        btnSave.Enabled = True
    End Sub

    ' a sub to disable the text boxes and certain buttons on the look up form
    Private Sub disableTextBoxes()
        btnSave.Enabled = False
        txtAddressLine1.Enabled = False
        txtAddressLine2.Enabled = False
        txtBillingAddressLine1.Enabled = False
        txtBillingAddressLine2.Enabled = False
        txtBillingCity.Enabled = False
        txtBillingZip.Enabled = False
        txtCity.Enabled = False
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        dtpNextService.Enabled = False
        txtPhone.Enabled = False
        txtZip.Enabled = False
        cboServicePlan.Enabled = False
        cboState.Enabled = False
        cboAccountStatus.Enabled = False
        cboBillingState.Enabled = False
        btnEditInfo.Enabled = False
        btnSave.Enabled = False
    End Sub

    ' validating events
    Private Sub txtPhone_Leave(sender As Object, e As EventArgs) Handles txtPhone.Leave
        If txtPhone.MaskCompleted = False Then
            ErrorProvider1.SetError(txtPhone, "Invalid phone number")
        End If
    End Sub

    Private Sub txtZip_Leave(sender As Object, e As EventArgs) Handles txtZip.Leave
        If txtZip.MaskCompleted = False Then
            ErrorProvider1.SetError(txtZip, "Invalid zip code")
        End If
    End Sub

    Private Sub txtBillingZip_Leave(sender As Object, e As EventArgs) Handles txtBillingZip.Leave
        If txtBillingZip.MaskCompleted = False Then
            ErrorProvider1.SetError(txtBillingZip, "Invalid billing zip code")
        End If
    End Sub

    ' an action listener sub routine that handles the setting of the billing address info
    ' copying when selected, and clearing when unchecked
    Private Sub chkSameAddress_CheckedChanged(sender As Object, e As EventArgs) Handles chkSameAddress.CheckedChanged
        If chkSameAddress.Checked Then
            ' calling modules copy function.
            ' customer information first
            setFirstName(txtFirstName.Text)
            setLastName(txtLastName.Text)
            setAddress1(txtAddressLine1.Text)
            setAddress2(txtAddressLine2.Text)
            lblAccountNumValue.Text = CStr(getAccountNumber())
            setCity(txtCity.Text)
            setState(cboState.Text)
            setZip(CInt(txtZip.Text))

            ' setting information that was inserted to clone
            setAddressInformationToBillingInformation()

            ' output results to billing's section
            txtBillingAddressLine1.Text = getBillingAddress1().ToString
            txtBillingAddressLine2.Text = getBillingAddress2().ToString
            txtBillingCity.Text = getBillingCity().ToString
            cboBillingState.Text = getBillingState().ToString
            txtBillingZip.Text = getBillingZip().ToString
        End If

        If (chkSameAddress.Checked = False) Then ' if unchecked, clear the billing section
            clearBillingInformation()

            ' output results to billing section
            txtBillingAddressLine1.Text = getBillingAddress1().ToString
            txtBillingAddressLine2.Text = getBillingAddress2().ToString
            txtBillingCity.Text = getBillingCity().ToString
            cboBillingState.Text = getBillingState().ToString
            txtBillingZip.Text = getBillingZip().ToString
        End If
    End Sub

    ' save changes to customer record to database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim zip As Integer
        Try
            ' setting customer info section
            setFirstName(txtFirstName.Text)
            setLastName(txtLastName.Text)
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

            ' update customer record with new values in database
            Me.CustomerInfoBindingSource.EndEdit()
            Me.CustomerInfoTableAdapter.Update(DbCustomerInfoDataSet.CustomerInfo)
            lblMessage.Text = "Update successful"
        Catch ex As Exception
            lblMessage.Text = "Error updating to Database"
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmBerrysBugMain.Show()
        Me.Close()
    End Sub
End Class