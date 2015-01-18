<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLookUpCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.rdoLastName = New System.Windows.Forms.RadioButton()
        Me.rdoAccountNum = New System.Windows.Forms.RadioButton()
        Me.rdoPhone = New System.Windows.Forms.RadioButton()
        Me.gbxLookupCustomer = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnLookup = New System.Windows.Forms.Button()
        Me.txtLookupCustomer = New System.Windows.Forms.TextBox()
        Me.lblLookupOption = New System.Windows.Forms.Label()
        Me.lblEnterValue = New System.Windows.Forms.Label()
        Me.pnlResults = New System.Windows.Forms.Panel()
        Me.txtBillingZip = New System.Windows.Forms.MaskedTextBox()
        Me.CustomerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCustomerInfoDataSet = New BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSet()
        Me.cboBillingState = New System.Windows.Forms.ComboBox()
        Me.txtBillingCity = New System.Windows.Forms.TextBox()
        Me.txtBillingAddressLine2 = New System.Windows.Forms.TextBox()
        Me.txtBillingAddressLine1 = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.MaskedTextBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddressLine2 = New System.Windows.Forms.TextBox()
        Me.txtAddressLine1 = New System.Windows.Forms.TextBox()
        Me.dtpNextService = New System.Windows.Forms.DateTimePicker()
        Me.cboServicePlan = New System.Windows.Forms.ComboBox()
        Me.cboAccountStatus = New System.Windows.Forms.ComboBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.chkSameAddress = New System.Windows.Forms.CheckBox()
        Me.lblBillingZip = New System.Windows.Forms.Label()
        Me.lblBillingState = New System.Windows.Forms.Label()
        Me.lblBillingCity = New System.Windows.Forms.Label()
        Me.lblBillingAddressLine2 = New System.Windows.Forms.Label()
        Me.lblBillingAddressLine1 = New System.Windows.Forms.Label()
        Me.lblBillingInfo = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddressLine2 = New System.Windows.Forms.Label()
        Me.lblAddressLine1 = New System.Windows.Forms.Label()
        Me.lblAddressInfo = New System.Windows.Forms.Label()
        Me.lblAccountNumValue = New System.Windows.Forms.Label()
        Me.lblNextService = New System.Windows.Forms.Label()
        Me.lblServicePlan = New System.Windows.Forms.Label()
        Me.lblAccountStatus = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblAccountNum = New System.Windows.Forms.Label()
        Me.lblAccountInfo = New System.Windows.Forms.Label()
        Me.btnEditInfo = New System.Windows.Forms.Button()
        Me.CustomerSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCustomerSearch = New BerrysBugBlastersCustomerSystem.dbCustomerSearch()
        Me.lblLookupCustomer = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CustomerSearchTableAdapter = New BerrysBugBlastersCustomerSystem.dbCustomerSearchTableAdapters.CustomerInfoTableAdapter()
        Me.TableAdapterManager = New BerrysBugBlastersCustomerSystem.dbCustomerSearchTableAdapters.TableAdapterManager()
        Me.CustomerInfoTableAdapter = New BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSetTableAdapters.CustomerInfoTableAdapter()
        Me.TableAdapterManager1 = New BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSetTableAdapters.TableAdapterManager()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblSubmission = New System.Windows.Forms.Label()
        Me.gbxLookupCustomer.SuspendLayout()
        Me.pnlResults.SuspendLayout()
        CType(Me.CustomerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCustomerInfoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoLastName
        '
        Me.rdoLastName.AutoSize = True
        Me.rdoLastName.Checked = True
        Me.rdoLastName.Location = New System.Drawing.Point(24, 22)
        Me.rdoLastName.Name = "rdoLastName"
        Me.rdoLastName.Size = New System.Drawing.Size(76, 17)
        Me.rdoLastName.TabIndex = 0
        Me.rdoLastName.TabStop = True
        Me.rdoLastName.Text = "Last Name"
        Me.rdoLastName.UseVisualStyleBackColor = True
        '
        'rdoAccountNum
        '
        Me.rdoAccountNum.AutoSize = True
        Me.rdoAccountNum.Location = New System.Drawing.Point(119, 22)
        Me.rdoAccountNum.Name = "rdoAccountNum"
        Me.rdoAccountNum.Size = New System.Drawing.Size(105, 17)
        Me.rdoAccountNum.TabIndex = 1
        Me.rdoAccountNum.Text = "Account Number"
        Me.rdoAccountNum.UseVisualStyleBackColor = True
        '
        'rdoPhone
        '
        Me.rdoPhone.AutoSize = True
        Me.rdoPhone.Location = New System.Drawing.Point(239, 22)
        Me.rdoPhone.Name = "rdoPhone"
        Me.rdoPhone.Size = New System.Drawing.Size(96, 17)
        Me.rdoPhone.TabIndex = 2
        Me.rdoPhone.Text = "Phone Number"
        Me.rdoPhone.UseVisualStyleBackColor = True
        '
        'gbxLookupCustomer
        '
        Me.gbxLookupCustomer.Controls.Add(Me.btnClear)
        Me.gbxLookupCustomer.Controls.Add(Me.btnLookup)
        Me.gbxLookupCustomer.Controls.Add(Me.txtLookupCustomer)
        Me.gbxLookupCustomer.Controls.Add(Me.lblLookupOption)
        Me.gbxLookupCustomer.Controls.Add(Me.lblEnterValue)
        Me.gbxLookupCustomer.Controls.Add(Me.rdoLastName)
        Me.gbxLookupCustomer.Controls.Add(Me.rdoPhone)
        Me.gbxLookupCustomer.Controls.Add(Me.rdoAccountNum)
        Me.gbxLookupCustomer.Location = New System.Drawing.Point(20, 36)
        Me.gbxLookupCustomer.Name = "gbxLookupCustomer"
        Me.gbxLookupCustomer.Size = New System.Drawing.Size(408, 114)
        Me.gbxLookupCustomer.TabIndex = 3
        Me.gbxLookupCustomer.TabStop = False
        Me.gbxLookupCustomer.Text = "Select An Option For Customer Look Up"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(209, 83)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(151, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnLookup
        '
        Me.btnLookup.Location = New System.Drawing.Point(32, 83)
        Me.btnLookup.Name = "btnLookup"
        Me.btnLookup.Size = New System.Drawing.Size(148, 23)
        Me.btnLookup.TabIndex = 6
        Me.btnLookup.Text = "Look Up"
        Me.btnLookup.UseVisualStyleBackColor = True
        '
        'txtLookupCustomer
        '
        Me.txtLookupCustomer.Location = New System.Drawing.Point(173, 52)
        Me.txtLookupCustomer.Name = "txtLookupCustomer"
        Me.txtLookupCustomer.Size = New System.Drawing.Size(187, 20)
        Me.txtLookupCustomer.TabIndex = 5
        '
        'lblLookupOption
        '
        Me.lblLookupOption.AutoSize = True
        Me.lblLookupOption.Location = New System.Drawing.Point(60, 54)
        Me.lblLookupOption.Name = "lblLookupOption"
        Me.lblLookupOption.Size = New System.Drawing.Size(95, 13)
        Me.lblLookupOption.TabIndex = 4
        Me.lblLookupOption.Text = "<Selected Option>"
        '
        'lblEnterValue
        '
        Me.lblEnterValue.AutoSize = True
        Me.lblEnterValue.Location = New System.Drawing.Point(21, 54)
        Me.lblEnterValue.Name = "lblEnterValue"
        Me.lblEnterValue.Size = New System.Drawing.Size(32, 13)
        Me.lblEnterValue.TabIndex = 3
        Me.lblEnterValue.Text = "Enter"
        '
        'pnlResults
        '
        Me.pnlResults.Controls.Add(Me.txtBillingZip)
        Me.pnlResults.Controls.Add(Me.cboBillingState)
        Me.pnlResults.Controls.Add(Me.txtBillingCity)
        Me.pnlResults.Controls.Add(Me.txtBillingAddressLine2)
        Me.pnlResults.Controls.Add(Me.txtBillingAddressLine1)
        Me.pnlResults.Controls.Add(Me.txtZip)
        Me.pnlResults.Controls.Add(Me.cboState)
        Me.pnlResults.Controls.Add(Me.txtCity)
        Me.pnlResults.Controls.Add(Me.txtAddressLine2)
        Me.pnlResults.Controls.Add(Me.txtAddressLine1)
        Me.pnlResults.Controls.Add(Me.dtpNextService)
        Me.pnlResults.Controls.Add(Me.cboServicePlan)
        Me.pnlResults.Controls.Add(Me.cboAccountStatus)
        Me.pnlResults.Controls.Add(Me.txtPhone)
        Me.pnlResults.Controls.Add(Me.txtLastName)
        Me.pnlResults.Controls.Add(Me.txtFirstName)
        Me.pnlResults.Controls.Add(Me.chkSameAddress)
        Me.pnlResults.Controls.Add(Me.lblBillingZip)
        Me.pnlResults.Controls.Add(Me.lblBillingState)
        Me.pnlResults.Controls.Add(Me.lblBillingCity)
        Me.pnlResults.Controls.Add(Me.lblBillingAddressLine2)
        Me.pnlResults.Controls.Add(Me.lblBillingAddressLine1)
        Me.pnlResults.Controls.Add(Me.lblBillingInfo)
        Me.pnlResults.Controls.Add(Me.lblZip)
        Me.pnlResults.Controls.Add(Me.lblState)
        Me.pnlResults.Controls.Add(Me.lblCity)
        Me.pnlResults.Controls.Add(Me.lblAddressLine2)
        Me.pnlResults.Controls.Add(Me.lblAddressLine1)
        Me.pnlResults.Controls.Add(Me.lblAddressInfo)
        Me.pnlResults.Controls.Add(Me.lblAccountNumValue)
        Me.pnlResults.Controls.Add(Me.lblNextService)
        Me.pnlResults.Controls.Add(Me.lblServicePlan)
        Me.pnlResults.Controls.Add(Me.lblAccountStatus)
        Me.pnlResults.Controls.Add(Me.lblPhone)
        Me.pnlResults.Controls.Add(Me.lblLastName)
        Me.pnlResults.Controls.Add(Me.lblFirstName)
        Me.pnlResults.Controls.Add(Me.lblAccountNum)
        Me.pnlResults.Controls.Add(Me.lblAccountInfo)
        Me.pnlResults.Controls.Add(Me.btnEditInfo)
        Me.pnlResults.Location = New System.Drawing.Point(20, 161)
        Me.pnlResults.Name = "pnlResults"
        Me.pnlResults.Size = New System.Drawing.Size(408, 466)
        Me.pnlResults.TabIndex = 5
        '
        'txtBillingZip
        '
        Me.txtBillingZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "billingZip", True))
        Me.txtBillingZip.Enabled = False
        Me.txtBillingZip.Location = New System.Drawing.Point(143, 436)
        Me.txtBillingZip.Mask = "00000"
        Me.txtBillingZip.Name = "txtBillingZip"
        Me.txtBillingZip.Size = New System.Drawing.Size(40, 20)
        Me.txtBillingZip.TabIndex = 62
        '
        'CustomerInfoBindingSource
        '
        Me.CustomerInfoBindingSource.DataMember = "CustomerInfo"
        Me.CustomerInfoBindingSource.DataSource = Me.DbCustomerInfoDataSet
        '
        'DbCustomerInfoDataSet
        '
        Me.DbCustomerInfoDataSet.DataSetName = "dbCustomerInfoDataSet"
        Me.DbCustomerInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboBillingState
        '
        Me.cboBillingState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "billingState", True))
        Me.cboBillingState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBillingState.Enabled = False
        Me.cboBillingState.FormattingEnabled = True
        Me.cboBillingState.Items.AddRange(New Object() {"Alabama" & Global.Microsoft.VisualBasic.ChrW(9) & "(AL)", "Alaska " & Global.Microsoft.VisualBasic.ChrW(9) & "(AK)", "Arizona " & Global.Microsoft.VisualBasic.ChrW(9) & "(AZ)", "Arkansas " & Global.Microsoft.VisualBasic.ChrW(9) & "(AR)", "California" & Global.Microsoft.VisualBasic.ChrW(9) & "(CA)", "Colorado" & Global.Microsoft.VisualBasic.ChrW(9) & "(CO)", "Connecticut (CT)", "Delaware" & Global.Microsoft.VisualBasic.ChrW(9) & "(DE)", "Florida" & Global.Microsoft.VisualBasic.ChrW(9) & "(FL)", "Georgia" & Global.Microsoft.VisualBasic.ChrW(9) & "(GA)", "Hawaii" & Global.Microsoft.VisualBasic.ChrW(9) & "(HI)", "Idaho" & Global.Microsoft.VisualBasic.ChrW(9) & "(ID)", "Illinois" & Global.Microsoft.VisualBasic.ChrW(9) & "(IL)", "Indiana" & Global.Microsoft.VisualBasic.ChrW(9) & "(IN)", "Iowa" & Global.Microsoft.VisualBasic.ChrW(9) & "(IA)", "Kansas" & Global.Microsoft.VisualBasic.ChrW(9) & "(KS)", "Kentucky" & Global.Microsoft.VisualBasic.ChrW(9) & "(KY)", "Louisiana" & Global.Microsoft.VisualBasic.ChrW(9) & "(LA)", "Maine" & Global.Microsoft.VisualBasic.ChrW(9) & "(ME)", "Maryland" & Global.Microsoft.VisualBasic.ChrW(9) & "(MD)", "Massachusetts  (MA)", "Michigan" & Global.Microsoft.VisualBasic.ChrW(9) & "(MI)", "Minnesota  (MN)", "Mississippi (MS)", "Missouri" & Global.Microsoft.VisualBasic.ChrW(9) & "(MO)", "Montana" & Global.Microsoft.VisualBasic.ChrW(9) & "(MT)", "Nebraska" & Global.Microsoft.VisualBasic.ChrW(9) & "(NE)", "Nevada" & Global.Microsoft.VisualBasic.ChrW(9) & "(NV)", "New Hampshire   (NH)", "New Jersey   (NJ)", "New Mexico   (NM)", "New York" & Global.Microsoft.VisualBasic.ChrW(9) & "(NY)", "North Carolina  (NC)", "North Dakota  (ND)", "Ohio  (OH)", "Oklahoma" & Global.Microsoft.VisualBasic.ChrW(9) & "  (OK)", "Oregon" & Global.Microsoft.VisualBasic.ChrW(9) & "(OR)", "Pennsylvania    (PA)", "Rhode Island   (RI)", "South Carolina   ( SC)", "South Dakota  (SD)", "Tennessee" & Global.Microsoft.VisualBasic.ChrW(9) & "  (TN)", "Texas   (TX)", "Utah" & Global.Microsoft.VisualBasic.ChrW(9) & "(UT)", "Vermont" & Global.Microsoft.VisualBasic.ChrW(9) & "(VT)", "Virginia" & Global.Microsoft.VisualBasic.ChrW(9) & "(VA)", "Washington  (WA)", "West Virginia   (WV)", "Wisconsin" & Global.Microsoft.VisualBasic.ChrW(9) & "  (WI)", "Wyoming" & Global.Microsoft.VisualBasic.ChrW(9) & "  (WY)"})
        Me.cboBillingState.Location = New System.Drawing.Point(143, 413)
        Me.cboBillingState.Name = "cboBillingState"
        Me.cboBillingState.Size = New System.Drawing.Size(121, 21)
        Me.cboBillingState.TabIndex = 61
        '
        'txtBillingCity
        '
        Me.txtBillingCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "billingCity", True))
        Me.txtBillingCity.Enabled = False
        Me.txtBillingCity.Location = New System.Drawing.Point(143, 391)
        Me.txtBillingCity.Name = "txtBillingCity"
        Me.txtBillingCity.Size = New System.Drawing.Size(207, 20)
        Me.txtBillingCity.TabIndex = 60
        '
        'txtBillingAddressLine2
        '
        Me.txtBillingAddressLine2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "billingAddressLine2", True))
        Me.txtBillingAddressLine2.Enabled = False
        Me.txtBillingAddressLine2.Location = New System.Drawing.Point(143, 369)
        Me.txtBillingAddressLine2.Name = "txtBillingAddressLine2"
        Me.txtBillingAddressLine2.Size = New System.Drawing.Size(207, 20)
        Me.txtBillingAddressLine2.TabIndex = 59
        '
        'txtBillingAddressLine1
        '
        Me.txtBillingAddressLine1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "billingAddressLine1", True))
        Me.txtBillingAddressLine1.Enabled = False
        Me.txtBillingAddressLine1.Location = New System.Drawing.Point(143, 347)
        Me.txtBillingAddressLine1.Name = "txtBillingAddressLine1"
        Me.txtBillingAddressLine1.Size = New System.Drawing.Size(207, 20)
        Me.txtBillingAddressLine1.TabIndex = 58
        '
        'txtZip
        '
        Me.txtZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "zip", True))
        Me.txtZip.Enabled = False
        Me.txtZip.Location = New System.Drawing.Point(125, 286)
        Me.txtZip.Mask = "00000"
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(40, 20)
        Me.txtZip.TabIndex = 57
        '
        'cboState
        '
        Me.cboState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "state", True))
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.Enabled = False
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"Alabama" & Global.Microsoft.VisualBasic.ChrW(9) & "(AL)", "Alaska " & Global.Microsoft.VisualBasic.ChrW(9) & "(AK)", "Arizona " & Global.Microsoft.VisualBasic.ChrW(9) & "(AZ)", "Arkansas " & Global.Microsoft.VisualBasic.ChrW(9) & "(AR)", "California" & Global.Microsoft.VisualBasic.ChrW(9) & "(CA)", "Colorado" & Global.Microsoft.VisualBasic.ChrW(9) & "(CO)", "Connecticut (CT)", "Delaware" & Global.Microsoft.VisualBasic.ChrW(9) & "(DE)", "Florida" & Global.Microsoft.VisualBasic.ChrW(9) & "(FL)", "Georgia" & Global.Microsoft.VisualBasic.ChrW(9) & "(GA)", "Hawaii" & Global.Microsoft.VisualBasic.ChrW(9) & "(HI)", "Idaho" & Global.Microsoft.VisualBasic.ChrW(9) & "(ID)", "Illinois" & Global.Microsoft.VisualBasic.ChrW(9) & "(IL)", "Indiana" & Global.Microsoft.VisualBasic.ChrW(9) & "(IN)", "Iowa" & Global.Microsoft.VisualBasic.ChrW(9) & "(IA)", "Kansas" & Global.Microsoft.VisualBasic.ChrW(9) & "(KS)", "Kentucky" & Global.Microsoft.VisualBasic.ChrW(9) & "(KY)", "Louisiana" & Global.Microsoft.VisualBasic.ChrW(9) & "(LA)", "Maine" & Global.Microsoft.VisualBasic.ChrW(9) & "(ME)", "Maryland" & Global.Microsoft.VisualBasic.ChrW(9) & "(MD)", "Massachusetts  (MA)", "Michigan" & Global.Microsoft.VisualBasic.ChrW(9) & "(MI)", "Minnesota  (MN)", "Mississippi (MS)", "Missouri" & Global.Microsoft.VisualBasic.ChrW(9) & "(MO)", "Montana" & Global.Microsoft.VisualBasic.ChrW(9) & "(MT)", "Nebraska" & Global.Microsoft.VisualBasic.ChrW(9) & "(NE)", "Nevada" & Global.Microsoft.VisualBasic.ChrW(9) & "(NV)", "New Hampshire   (NH)", "New Jersey   (NJ)", "New Mexico   (NM)", "New York" & Global.Microsoft.VisualBasic.ChrW(9) & "(NY)", "North Carolina  (NC)", "North Dakota  (ND)", "Ohio  (OH)", "Oklahoma" & Global.Microsoft.VisualBasic.ChrW(9) & "  (OK)", "Oregon" & Global.Microsoft.VisualBasic.ChrW(9) & "(OR)", "Pennsylvania    (PA)", "Rhode Island   (RI)", "South Carolina   ( SC)", "South Dakota  (SD)", "Tennessee" & Global.Microsoft.VisualBasic.ChrW(9) & "  (TN)", "Texas   (TX)", "Utah" & Global.Microsoft.VisualBasic.ChrW(9) & "(UT)", "Vermont" & Global.Microsoft.VisualBasic.ChrW(9) & "(VT)", "Virginia" & Global.Microsoft.VisualBasic.ChrW(9) & "(VA)", "Washington  (WA)", "West Virginia   (WV)", "Wisconsin" & Global.Microsoft.VisualBasic.ChrW(9) & "  (WI)", "Wyoming" & Global.Microsoft.VisualBasic.ChrW(9) & "  (WY)"})
        Me.cboState.Location = New System.Drawing.Point(125, 263)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(121, 21)
        Me.cboState.TabIndex = 56
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "city", True))
        Me.txtCity.Enabled = False
        Me.txtCity.Location = New System.Drawing.Point(125, 241)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(207, 20)
        Me.txtCity.TabIndex = 55
        '
        'txtAddressLine2
        '
        Me.txtAddressLine2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "addressLine2", True))
        Me.txtAddressLine2.Enabled = False
        Me.txtAddressLine2.Location = New System.Drawing.Point(125, 219)
        Me.txtAddressLine2.Name = "txtAddressLine2"
        Me.txtAddressLine2.Size = New System.Drawing.Size(207, 20)
        Me.txtAddressLine2.TabIndex = 54
        '
        'txtAddressLine1
        '
        Me.txtAddressLine1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "addressLine1", True))
        Me.txtAddressLine1.Enabled = False
        Me.txtAddressLine1.Location = New System.Drawing.Point(125, 197)
        Me.txtAddressLine1.Name = "txtAddressLine1"
        Me.txtAddressLine1.Size = New System.Drawing.Size(207, 20)
        Me.txtAddressLine1.TabIndex = 53
        '
        'dtpNextService
        '
        Me.dtpNextService.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInfoBindingSource, "nextServiceDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.dtpNextService.Enabled = False
        Me.dtpNextService.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNextService.Location = New System.Drawing.Point(125, 149)
        Me.dtpNextService.Name = "dtpNextService"
        Me.dtpNextService.Size = New System.Drawing.Size(121, 20)
        Me.dtpNextService.TabIndex = 52
        '
        'cboServicePlan
        '
        Me.cboServicePlan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "servicePlan", True))
        Me.cboServicePlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServicePlan.Enabled = False
        Me.cboServicePlan.FormattingEnabled = True
        Me.cboServicePlan.Items.AddRange(New Object() {"Yearly", "One-Time"})
        Me.cboServicePlan.Location = New System.Drawing.Point(125, 127)
        Me.cboServicePlan.Name = "cboServicePlan"
        Me.cboServicePlan.Size = New System.Drawing.Size(121, 21)
        Me.cboServicePlan.TabIndex = 51
        '
        'cboAccountStatus
        '
        Me.cboAccountStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "accountStatus", True))
        Me.cboAccountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccountStatus.Enabled = False
        Me.cboAccountStatus.FormattingEnabled = True
        Me.cboAccountStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboAccountStatus.Location = New System.Drawing.Point(124, 105)
        Me.cboAccountStatus.Name = "cboAccountStatus"
        Me.cboAccountStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboAccountStatus.TabIndex = 50
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "phoneNumber", True))
        Me.txtPhone.Enabled = False
        Me.txtPhone.Location = New System.Drawing.Point(125, 85)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(85, 20)
        Me.txtPhone.TabIndex = 49
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "lastName", True))
        Me.txtLastName.Enabled = False
        Me.txtLastName.Location = New System.Drawing.Point(124, 64)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 48
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "firstName", True))
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Location = New System.Drawing.Point(124, 43)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 47
        '
        'chkSameAddress
        '
        Me.chkSameAddress.AutoSize = True
        Me.chkSameAddress.Location = New System.Drawing.Point(12, 326)
        Me.chkSameAddress.Name = "chkSameAddress"
        Me.chkSameAddress.Size = New System.Drawing.Size(246, 17)
        Me.chkSameAddress.TabIndex = 39
        Me.chkSameAddress.Text = "Select if Address is the same as Billing Address"
        Me.chkSameAddress.UseVisualStyleBackColor = True
        '
        'lblBillingZip
        '
        Me.lblBillingZip.AutoSize = True
        Me.lblBillingZip.Location = New System.Drawing.Point(31, 437)
        Me.lblBillingZip.Name = "lblBillingZip"
        Me.lblBillingZip.Size = New System.Drawing.Size(55, 13)
        Me.lblBillingZip.TabIndex = 38
        Me.lblBillingZip.Text = "Billing Zip:"
        '
        'lblBillingState
        '
        Me.lblBillingState.AutoSize = True
        Me.lblBillingState.Location = New System.Drawing.Point(31, 416)
        Me.lblBillingState.Name = "lblBillingState"
        Me.lblBillingState.Size = New System.Drawing.Size(65, 13)
        Me.lblBillingState.TabIndex = 37
        Me.lblBillingState.Text = "Billing State:"
        '
        'lblBillingCity
        '
        Me.lblBillingCity.AutoSize = True
        Me.lblBillingCity.Location = New System.Drawing.Point(31, 394)
        Me.lblBillingCity.Name = "lblBillingCity"
        Me.lblBillingCity.Size = New System.Drawing.Size(57, 13)
        Me.lblBillingCity.TabIndex = 36
        Me.lblBillingCity.Text = "Billing City:"
        '
        'lblBillingAddressLine2
        '
        Me.lblBillingAddressLine2.AutoSize = True
        Me.lblBillingAddressLine2.Location = New System.Drawing.Point(31, 373)
        Me.lblBillingAddressLine2.Name = "lblBillingAddressLine2"
        Me.lblBillingAddressLine2.Size = New System.Drawing.Size(110, 13)
        Me.lblBillingAddressLine2.TabIndex = 35
        Me.lblBillingAddressLine2.Text = "Billing Address Line 2:"
        '
        'lblBillingAddressLine1
        '
        Me.lblBillingAddressLine1.AutoSize = True
        Me.lblBillingAddressLine1.Location = New System.Drawing.Point(32, 350)
        Me.lblBillingAddressLine1.Name = "lblBillingAddressLine1"
        Me.lblBillingAddressLine1.Size = New System.Drawing.Size(107, 13)
        Me.lblBillingAddressLine1.TabIndex = 34
        Me.lblBillingAddressLine1.Text = "Billing Address Line1:"
        '
        'lblBillingInfo
        '
        Me.lblBillingInfo.AutoSize = True
        Me.lblBillingInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingInfo.Location = New System.Drawing.Point(9, 306)
        Me.lblBillingInfo.Name = "lblBillingInfo"
        Me.lblBillingInfo.Size = New System.Drawing.Size(108, 13)
        Me.lblBillingInfo.TabIndex = 33
        Me.lblBillingInfo.Text = "Billing Information"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(28, 284)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(28, 13)
        Me.lblZip.TabIndex = 27
        Me.lblZip.Text = "Zip: "
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(28, 262)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(38, 13)
        Me.lblState.TabIndex = 26
        Me.lblState.Text = "State: "
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(29, 241)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(30, 13)
        Me.lblCity.TabIndex = 25
        Me.lblCity.Text = "City: "
        '
        'lblAddressLine2
        '
        Me.lblAddressLine2.AutoSize = True
        Me.lblAddressLine2.Location = New System.Drawing.Point(28, 221)
        Me.lblAddressLine2.Name = "lblAddressLine2"
        Me.lblAddressLine2.Size = New System.Drawing.Size(80, 13)
        Me.lblAddressLine2.TabIndex = 24
        Me.lblAddressLine2.Text = "Address Line 2:"
        '
        'lblAddressLine1
        '
        Me.lblAddressLine1.AutoSize = True
        Me.lblAddressLine1.Location = New System.Drawing.Point(28, 200)
        Me.lblAddressLine1.Name = "lblAddressLine1"
        Me.lblAddressLine1.Size = New System.Drawing.Size(80, 13)
        Me.lblAddressLine1.TabIndex = 23
        Me.lblAddressLine1.Text = "Address Line 1:"
        '
        'lblAddressInfo
        '
        Me.lblAddressInfo.AutoSize = True
        Me.lblAddressInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressInfo.Location = New System.Drawing.Point(6, 179)
        Me.lblAddressInfo.Name = "lblAddressInfo"
        Me.lblAddressInfo.Size = New System.Drawing.Size(119, 13)
        Me.lblAddressInfo.TabIndex = 22
        Me.lblAddressInfo.Text = "Address Information"
        '
        'lblAccountNumValue
        '
        Me.lblAccountNumValue.AutoSize = True
        Me.lblAccountNumValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "accountNumber", True))
        Me.lblAccountNumValue.Location = New System.Drawing.Point(127, 26)
        Me.lblAccountNumValue.Name = "lblAccountNumValue"
        Me.lblAccountNumValue.Size = New System.Drawing.Size(69, 13)
        Me.lblAccountNumValue.TabIndex = 15
        Me.lblAccountNumValue.Text = "<Generated>"
        '
        'lblNextService
        '
        Me.lblNextService.AutoSize = True
        Me.lblNextService.Location = New System.Drawing.Point(26, 152)
        Me.lblNextService.Name = "lblNextService"
        Me.lblNextService.Size = New System.Drawing.Size(97, 13)
        Me.lblNextService.TabIndex = 14
        Me.lblNextService.Text = "Next Service Date:"
        '
        'lblServicePlan
        '
        Me.lblServicePlan.AutoSize = True
        Me.lblServicePlan.Location = New System.Drawing.Point(26, 132)
        Me.lblServicePlan.Name = "lblServicePlan"
        Me.lblServicePlan.Size = New System.Drawing.Size(70, 13)
        Me.lblServicePlan.TabIndex = 13
        Me.lblServicePlan.Text = "Service Plan:"
        '
        'lblAccountStatus
        '
        Me.lblAccountStatus.AutoSize = True
        Me.lblAccountStatus.Location = New System.Drawing.Point(26, 111)
        Me.lblAccountStatus.Name = "lblAccountStatus"
        Me.lblAccountStatus.Size = New System.Drawing.Size(83, 13)
        Me.lblAccountStatus.TabIndex = 12
        Me.lblAccountStatus.Text = "Account Status:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(26, 89)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(81, 13)
        Me.lblPhone.TabIndex = 11
        Me.lblPhone.Text = "Phone Number:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(26, 68)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 10
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(25, 47)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 9
        Me.lblFirstName.Text = "First Name:"
        '
        'lblAccountNum
        '
        Me.lblAccountNum.AutoSize = True
        Me.lblAccountNum.Location = New System.Drawing.Point(24, 26)
        Me.lblAccountNum.Name = "lblAccountNum"
        Me.lblAccountNum.Size = New System.Drawing.Size(90, 13)
        Me.lblAccountNum.TabIndex = 8
        Me.lblAccountNum.Text = "Account Number:"
        '
        'lblAccountInfo
        '
        Me.lblAccountInfo.AutoSize = True
        Me.lblAccountInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountInfo.Location = New System.Drawing.Point(3, 8)
        Me.lblAccountInfo.Name = "lblAccountInfo"
        Me.lblAccountInfo.Size = New System.Drawing.Size(121, 13)
        Me.lblAccountInfo.TabIndex = 7
        Me.lblAccountInfo.Text = "Account Information"
        '
        'btnEditInfo
        '
        Me.btnEditInfo.Enabled = False
        Me.btnEditInfo.Location = New System.Drawing.Point(264, 3)
        Me.btnEditInfo.Name = "btnEditInfo"
        Me.btnEditInfo.Size = New System.Drawing.Size(141, 23)
        Me.btnEditInfo.TabIndex = 6
        Me.btnEditInfo.Text = "Edit Customer Info"
        Me.btnEditInfo.UseVisualStyleBackColor = True
        '
        'CustomerSearchBindingSource
        '
        Me.CustomerSearchBindingSource.DataMember = "CustomerInfo"
        Me.CustomerSearchBindingSource.DataSource = Me.DbCustomerSearch
        '
        'DbCustomerSearch
        '
        Me.DbCustomerSearch.DataSetName = "dbCustomerSearch"
        Me.DbCustomerSearch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblLookupCustomer
        '
        Me.lblLookupCustomer.AutoSize = True
        Me.lblLookupCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLookupCustomer.Location = New System.Drawing.Point(117, 9)
        Me.lblLookupCustomer.Name = "lblLookupCustomer"
        Me.lblLookupCustomer.Size = New System.Drawing.Size(193, 16)
        Me.lblLookupCustomer.TabIndex = 6
        Me.lblLookupCustomer.Text = "Look Up Existing Customer"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(231, 637)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(177, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(32, 637)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(169, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CustomerSearchTableAdapter
        '
        Me.CustomerSearchTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerInfoTableAdapter = Me.CustomerSearchTableAdapter
        Me.TableAdapterManager.UpdateOrder = BerrysBugBlastersCustomerSystem.dbCustomerSearchTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerInfoTableAdapter
        '
        Me.CustomerInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CustomerInfoTableAdapter = Me.CustomerInfoTableAdapter
        Me.TableAdapterManager1.UpdateOrder = BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(29, 671)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 11
        '
        'lblSubmission
        '
        Me.lblSubmission.AutoSize = True
        Me.lblSubmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubmission.ForeColor = System.Drawing.Color.Red
        Me.lblSubmission.Location = New System.Drawing.Point(225, 340)
        Me.lblSubmission.Name = "lblSubmission"
        Me.lblSubmission.Size = New System.Drawing.Size(0, 13)
        Me.lblSubmission.TabIndex = 12
        '
        'frmLookUpCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 693)
        Me.Controls.Add(Me.lblSubmission)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblLookupCustomer)
        Me.Controls.Add(Me.pnlResults)
        Me.Controls.Add(Me.gbxLookupCustomer)
        Me.Name = "frmLookUpCustomer"
        Me.Text = "Look Up Customer Form"
        Me.gbxLookupCustomer.ResumeLayout(False)
        Me.gbxLookupCustomer.PerformLayout()
        Me.pnlResults.ResumeLayout(False)
        Me.pnlResults.PerformLayout()
        CType(Me.CustomerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCustomerInfoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoLastName As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAccountNum As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPhone As System.Windows.Forms.RadioButton
    Friend WithEvents gbxLookupCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnLookup As System.Windows.Forms.Button
    Friend WithEvents txtLookupCustomer As System.Windows.Forms.TextBox
    Friend WithEvents lblLookupOption As System.Windows.Forms.Label
    Friend WithEvents lblEnterValue As System.Windows.Forms.Label
    Friend WithEvents pnlResults As System.Windows.Forms.Panel
    Friend WithEvents btnEditInfo As System.Windows.Forms.Button
    Friend WithEvents lblAccountNumValue As System.Windows.Forms.Label
    Friend WithEvents lblNextService As System.Windows.Forms.Label
    Friend WithEvents lblServicePlan As System.Windows.Forms.Label
    Friend WithEvents lblAccountStatus As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblAccountNum As System.Windows.Forms.Label
    Friend WithEvents lblAccountInfo As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblAddressLine2 As System.Windows.Forms.Label
    Friend WithEvents lblAddressLine1 As System.Windows.Forms.Label
    Friend WithEvents lblAddressInfo As System.Windows.Forms.Label
    Friend WithEvents lblBillingZip As System.Windows.Forms.Label
    Friend WithEvents lblBillingState As System.Windows.Forms.Label
    Friend WithEvents lblBillingCity As System.Windows.Forms.Label
    Friend WithEvents lblBillingAddressLine2 As System.Windows.Forms.Label
    Friend WithEvents lblBillingAddressLine1 As System.Windows.Forms.Label
    Friend WithEvents lblBillingInfo As System.Windows.Forms.Label
    Friend WithEvents chkSameAddress As System.Windows.Forms.CheckBox
    Friend WithEvents lblLookupCustomer As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents cboAccountStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboServicePlan As System.Windows.Forms.ComboBox
    Friend WithEvents dtpNextService As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAddressLine1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressLine2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents txtZip As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBillingZip As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboBillingState As System.Windows.Forms.ComboBox
    Friend WithEvents txtBillingCity As System.Windows.Forms.TextBox
    Friend WithEvents txtBillingAddressLine2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBillingAddressLine1 As System.Windows.Forms.TextBox
    Friend WithEvents DbCustomerSearch As BerrysBugBlastersCustomerSystem.dbCustomerSearch
    Friend WithEvents CustomerSearchTableAdapter As BerrysBugBlastersCustomerSystem.dbCustomerSearchTableAdapters.CustomerInfoTableAdapter
    Friend WithEvents TableAdapterManager As BerrysBugBlastersCustomerSystem.dbCustomerSearchTableAdapters.TableAdapterManager
    Friend WithEvents CustomerSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DbCustomerInfoDataSet As BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSet
    Friend WithEvents CustomerInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerInfoTableAdapter As BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSetTableAdapters.CustomerInfoTableAdapter
    Friend WithEvents TableAdapterManager1 As BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblSubmission As System.Windows.Forms.Label
End Class
