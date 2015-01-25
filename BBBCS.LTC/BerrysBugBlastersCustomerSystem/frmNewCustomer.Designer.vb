<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCustomer
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
        Dim lblFirstName As System.Windows.Forms.Label
        Dim lblLastName As System.Windows.Forms.Label
        Dim lblPhone As System.Windows.Forms.Label
        Me.lblAccountNum = New System.Windows.Forms.Label()
        Me.lblAccountStatus = New System.Windows.Forms.Label()
        Me.gbxCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.dtpNextService = New System.Windows.Forms.DateTimePicker()
        Me.CustomerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCustomerInfoDataSet = New BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSet()
        Me.dtpEnrollmentDate = New System.Windows.Forms.DateTimePicker()
        Me.cboServicePlan = New System.Windows.Forms.ComboBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblNextService = New System.Windows.Forms.Label()
        Me.lblEnrollmentDate = New System.Windows.Forms.Label()
        Me.lblServicePlan = New System.Windows.Forms.Label()
        Me.gbxServiceAddress = New System.Windows.Forms.GroupBox()
        Me.txtZip = New System.Windows.Forms.MaskedTextBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddressLine2 = New System.Windows.Forms.TextBox()
        Me.txtAddressLine1 = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddressLine2 = New System.Windows.Forms.Label()
        Me.lblAddressLine1 = New System.Windows.Forms.Label()
        Me.gbxBillingAddress = New System.Windows.Forms.GroupBox()
        Me.txtBillingZip = New System.Windows.Forms.MaskedTextBox()
        Me.cboBillingState = New System.Windows.Forms.ComboBox()
        Me.txtBillingCity = New System.Windows.Forms.TextBox()
        Me.txtBillingAddressLine2 = New System.Windows.Forms.TextBox()
        Me.txtBillingAddressLine1 = New System.Windows.Forms.TextBox()
        Me.lblBillingZip = New System.Windows.Forms.Label()
        Me.lblBillingState = New System.Windows.Forms.Label()
        Me.lblBillingCity = New System.Windows.Forms.Label()
        Me.lblBillingAddressLine2 = New System.Windows.Forms.Label()
        Me.lblBillingAddressLine1 = New System.Windows.Forms.Label()
        Me.chkSameAddress = New System.Windows.Forms.CheckBox()
        Me.gbxBillingMethod = New System.Windows.Forms.GroupBox()
        Me.dtpCardExp = New System.Windows.Forms.DateTimePicker()
        Me.txtCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.cboCardType = New System.Windows.Forms.ComboBox()
        Me.txtCheckNumber = New System.Windows.Forms.TextBox()
        Me.rdoCreditCard = New System.Windows.Forms.RadioButton()
        Me.rdoCheck = New System.Windows.Forms.RadioButton()
        Me.lblCardExp = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblSelectMethod = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblNewCustomer = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblAccountNumValue = New System.Windows.Forms.Label()
        Me.cboAccountStatus = New System.Windows.Forms.ComboBox()
        Me.CustomerInfoTableAdapter = New BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSetTableAdapters.CustomerInfoTableAdapter()
        Me.TableAdapterManager = New BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSetTableAdapters.TableAdapterManager()
        lblFirstName = New System.Windows.Forms.Label()
        lblLastName = New System.Windows.Forms.Label()
        lblPhone = New System.Windows.Forms.Label()
        Me.gbxCustomerInfo.SuspendLayout()
        CType(Me.CustomerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCustomerInfoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxServiceAddress.SuspendLayout()
        Me.gbxBillingAddress.SuspendLayout()
        Me.gbxBillingMethod.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        lblFirstName.AutoSize = True
        lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFirstName.Location = New System.Drawing.Point(8, 25)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New System.Drawing.Size(60, 13)
        lblFirstName.TabIndex = 14
        lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        lblLastName.AutoSize = True
        lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLastName.Location = New System.Drawing.Point(8, 51)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New System.Drawing.Size(61, 13)
        lblLastName.TabIndex = 15
        lblLastName.Text = "Last Name:"
        '
        'lblPhone
        '
        lblPhone.AutoSize = True
        lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPhone.Location = New System.Drawing.Point(9, 77)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New System.Drawing.Size(81, 13)
        lblPhone.TabIndex = 16
        lblPhone.Text = "Phone Number:"
        '
        'lblAccountNum
        '
        Me.lblAccountNum.AutoSize = True
        Me.lblAccountNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNum.Location = New System.Drawing.Point(21, 36)
        Me.lblAccountNum.Name = "lblAccountNum"
        Me.lblAccountNum.Size = New System.Drawing.Size(105, 13)
        Me.lblAccountNum.TabIndex = 1
        Me.lblAccountNum.Text = "Account Number:"
        '
        'lblAccountStatus
        '
        Me.lblAccountStatus.AutoSize = True
        Me.lblAccountStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountStatus.Location = New System.Drawing.Point(298, 39)
        Me.lblAccountStatus.Name = "lblAccountStatus"
        Me.lblAccountStatus.Size = New System.Drawing.Size(102, 13)
        Me.lblAccountStatus.TabIndex = 3
        Me.lblAccountStatus.Text = "Account Status: "
        '
        'gbxCustomerInfo
        '
        Me.gbxCustomerInfo.Controls.Add(Me.dtpNextService)
        Me.gbxCustomerInfo.Controls.Add(Me.dtpEnrollmentDate)
        Me.gbxCustomerInfo.Controls.Add(Me.cboServicePlan)
        Me.gbxCustomerInfo.Controls.Add(lblPhone)
        Me.gbxCustomerInfo.Controls.Add(Me.txtPhone)
        Me.gbxCustomerInfo.Controls.Add(lblLastName)
        Me.gbxCustomerInfo.Controls.Add(Me.txtLastName)
        Me.gbxCustomerInfo.Controls.Add(Me.txtFirstName)
        Me.gbxCustomerInfo.Controls.Add(lblFirstName)
        Me.gbxCustomerInfo.Controls.Add(Me.lblNextService)
        Me.gbxCustomerInfo.Controls.Add(Me.lblEnrollmentDate)
        Me.gbxCustomerInfo.Controls.Add(Me.lblServicePlan)
        Me.gbxCustomerInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCustomerInfo.Location = New System.Drawing.Point(20, 60)
        Me.gbxCustomerInfo.Name = "gbxCustomerInfo"
        Me.gbxCustomerInfo.Size = New System.Drawing.Size(500, 114)
        Me.gbxCustomerInfo.TabIndex = 5
        Me.gbxCustomerInfo.TabStop = False
        Me.gbxCustomerInfo.Text = "Customer Information"
        '
        'dtpNextService
        '
        Me.dtpNextService.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInfoBindingSource, "nextServiceDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.dtpNextService.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNextService.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNextService.Location = New System.Drawing.Point(365, 70)
        Me.dtpNextService.Name = "dtpNextService"
        Me.dtpNextService.Size = New System.Drawing.Size(121, 20)
        Me.dtpNextService.TabIndex = 20
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
        'dtpEnrollmentDate
        '
        Me.dtpEnrollmentDate.CustomFormat = ""
        Me.dtpEnrollmentDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInfoBindingSource, "enrollmentDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.dtpEnrollmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnrollmentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnrollmentDate.Location = New System.Drawing.Point(365, 42)
        Me.dtpEnrollmentDate.Name = "dtpEnrollmentDate"
        Me.dtpEnrollmentDate.Size = New System.Drawing.Size(121, 20)
        Me.dtpEnrollmentDate.TabIndex = 19
        '
        'cboServicePlan
        '
        Me.cboServicePlan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "servicePlan", True))
        Me.cboServicePlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServicePlan.FormattingEnabled = True
        Me.cboServicePlan.Items.AddRange(New Object() {"One Time Service", "Yearly Service"})
        Me.cboServicePlan.Location = New System.Drawing.Point(365, 14)
        Me.cboServicePlan.Name = "cboServicePlan"
        Me.cboServicePlan.Size = New System.Drawing.Size(121, 21)
        Me.cboServicePlan.TabIndex = 18
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "phoneNumber", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(104, 74)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(85, 20)
        Me.txtPhone.TabIndex = 17
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "lastName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(88, 48)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 16
        '
        'txtFirstName
        '
        Me.txtFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "firstName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(88, 23)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 15
        '
        'lblNextService
        '
        Me.lblNextService.AutoSize = True
        Me.lblNextService.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextService.Location = New System.Drawing.Point(254, 73)
        Me.lblNextService.Name = "lblNextService"
        Me.lblNextService.Size = New System.Drawing.Size(97, 13)
        Me.lblNextService.TabIndex = 10
        Me.lblNextService.Text = "Next Service Date:"
        '
        'lblEnrollmentDate
        '
        Me.lblEnrollmentDate.AutoSize = True
        Me.lblEnrollmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrollmentDate.Location = New System.Drawing.Point(263, 45)
        Me.lblEnrollmentDate.Name = "lblEnrollmentDate"
        Me.lblEnrollmentDate.Size = New System.Drawing.Size(88, 13)
        Me.lblEnrollmentDate.TabIndex = 8
        Me.lblEnrollmentDate.Text = "Enrollment Date: "
        '
        'lblServicePlan
        '
        Me.lblServicePlan.AutoSize = True
        Me.lblServicePlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicePlan.Location = New System.Drawing.Point(278, 18)
        Me.lblServicePlan.Name = "lblServicePlan"
        Me.lblServicePlan.Size = New System.Drawing.Size(73, 13)
        Me.lblServicePlan.TabIndex = 6
        Me.lblServicePlan.Text = "Service Plan: "
        '
        'gbxServiceAddress
        '
        Me.gbxServiceAddress.Controls.Add(Me.txtZip)
        Me.gbxServiceAddress.Controls.Add(Me.cboState)
        Me.gbxServiceAddress.Controls.Add(Me.txtCity)
        Me.gbxServiceAddress.Controls.Add(Me.txtAddressLine2)
        Me.gbxServiceAddress.Controls.Add(Me.txtAddressLine1)
        Me.gbxServiceAddress.Controls.Add(Me.lblZip)
        Me.gbxServiceAddress.Controls.Add(Me.lblState)
        Me.gbxServiceAddress.Controls.Add(Me.lblCity)
        Me.gbxServiceAddress.Controls.Add(Me.lblAddressLine2)
        Me.gbxServiceAddress.Controls.Add(Me.lblAddressLine1)
        Me.gbxServiceAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxServiceAddress.Location = New System.Drawing.Point(20, 164)
        Me.gbxServiceAddress.Name = "gbxServiceAddress"
        Me.gbxServiceAddress.Size = New System.Drawing.Size(500, 146)
        Me.gbxServiceAddress.TabIndex = 6
        Me.gbxServiceAddress.TabStop = False
        Me.gbxServiceAddress.Text = "Service Address"
        '
        'txtZip
        '
        Me.txtZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "zip", True))
        Me.txtZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(101, 120)
        Me.txtZip.Mask = "00000"
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(40, 20)
        Me.txtZip.TabIndex = 14
        '
        'cboState
        '
        Me.cboState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "state", True))
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"Alabama" & Global.Microsoft.VisualBasic.ChrW(9) & "(AL)", "Alaska " & Global.Microsoft.VisualBasic.ChrW(9) & "(AK)", "Arizona " & Global.Microsoft.VisualBasic.ChrW(9) & "(AZ)", "Arkansas " & Global.Microsoft.VisualBasic.ChrW(9) & "(AR)", "California" & Global.Microsoft.VisualBasic.ChrW(9) & "(CA)", "Colorado" & Global.Microsoft.VisualBasic.ChrW(9) & "(CO)", "Connecticut (CT)", "Delaware" & Global.Microsoft.VisualBasic.ChrW(9) & "(DE)", "Florida" & Global.Microsoft.VisualBasic.ChrW(9) & "(FL)", "Georgia" & Global.Microsoft.VisualBasic.ChrW(9) & "(GA)", "Hawaii" & Global.Microsoft.VisualBasic.ChrW(9) & "(HI)", "Idaho" & Global.Microsoft.VisualBasic.ChrW(9) & "(ID)", "Illinois" & Global.Microsoft.VisualBasic.ChrW(9) & "(IL)", "Indiana" & Global.Microsoft.VisualBasic.ChrW(9) & "(IN)", "Iowa" & Global.Microsoft.VisualBasic.ChrW(9) & "(IA)", "Kansas" & Global.Microsoft.VisualBasic.ChrW(9) & "(KS)", "Kentucky" & Global.Microsoft.VisualBasic.ChrW(9) & "(KY)", "Louisiana" & Global.Microsoft.VisualBasic.ChrW(9) & "(LA)", "Maine" & Global.Microsoft.VisualBasic.ChrW(9) & "(ME)", "Maryland" & Global.Microsoft.VisualBasic.ChrW(9) & "(MD)", "Massachusetts  (MA)", "Michigan" & Global.Microsoft.VisualBasic.ChrW(9) & "(MI)", "Minnesota  (MN)", "Mississippi (MS)", "Missouri" & Global.Microsoft.VisualBasic.ChrW(9) & "(MO)", "Montana" & Global.Microsoft.VisualBasic.ChrW(9) & "(MT)", "Nebraska" & Global.Microsoft.VisualBasic.ChrW(9) & "(NE)", "Nevada" & Global.Microsoft.VisualBasic.ChrW(9) & "(NV)", "New Hampshire   (NH)", "New Jersey   (NJ)", "New Mexico   (NM)", "New York" & Global.Microsoft.VisualBasic.ChrW(9) & "(NY)", "North Carolina  (NC)", "North Dakota  (ND)", "Ohio  (OH)", "Oklahoma" & Global.Microsoft.VisualBasic.ChrW(9) & "  (OK)", "Oregon" & Global.Microsoft.VisualBasic.ChrW(9) & "(OR)", "Pennsylvania    (PA)", "Rhode Island   (RI)", "South Carolina   ( SC)", "South Dakota  (SD)", "Tennessee" & Global.Microsoft.VisualBasic.ChrW(9) & "  (TN)", "Texas   (TX)", "Utah" & Global.Microsoft.VisualBasic.ChrW(9) & "(UT)", "Vermont" & Global.Microsoft.VisualBasic.ChrW(9) & "(VT)", "Virginia" & Global.Microsoft.VisualBasic.ChrW(9) & "(VA)", "Washington  (WA)", "West Virginia   (WV)", "Wisconsin" & Global.Microsoft.VisualBasic.ChrW(9) & "  (WI)", "Wyoming" & Global.Microsoft.VisualBasic.ChrW(9) & "  (WY)"})
        Me.cboState.Location = New System.Drawing.Point(100, 94)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(121, 21)
        Me.cboState.TabIndex = 13
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "city", True))
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(100, 69)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(208, 20)
        Me.txtCity.TabIndex = 12
        '
        'txtAddressLine2
        '
        Me.txtAddressLine2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "addressLine2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtAddressLine2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressLine2.Location = New System.Drawing.Point(101, 43)
        Me.txtAddressLine2.Name = "txtAddressLine2"
        Me.txtAddressLine2.Size = New System.Drawing.Size(207, 20)
        Me.txtAddressLine2.TabIndex = 11
        '
        'txtAddressLine1
        '
        Me.txtAddressLine1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "addressLine1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtAddressLine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressLine1.Location = New System.Drawing.Point(101, 18)
        Me.txtAddressLine1.Name = "txtAddressLine1"
        Me.txtAddressLine1.Size = New System.Drawing.Size(207, 20)
        Me.txtAddressLine1.TabIndex = 10
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(17, 122)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(25, 13)
        Me.lblZip.TabIndex = 4
        Me.lblZip.Text = "Zip:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(15, 97)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 3
        Me.lblState.Text = "State:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(16, 70)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 2
        Me.lblCity.Text = "City:"
        '
        'lblAddressLine2
        '
        Me.lblAddressLine2.AutoSize = True
        Me.lblAddressLine2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressLine2.Location = New System.Drawing.Point(15, 47)
        Me.lblAddressLine2.Name = "lblAddressLine2"
        Me.lblAddressLine2.Size = New System.Drawing.Size(80, 13)
        Me.lblAddressLine2.TabIndex = 1
        Me.lblAddressLine2.Text = "Address Line 2:"
        '
        'lblAddressLine1
        '
        Me.lblAddressLine1.AutoSize = True
        Me.lblAddressLine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressLine1.Location = New System.Drawing.Point(14, 21)
        Me.lblAddressLine1.Name = "lblAddressLine1"
        Me.lblAddressLine1.Size = New System.Drawing.Size(80, 13)
        Me.lblAddressLine1.TabIndex = 0
        Me.lblAddressLine1.Text = "Address Line 1:"
        '
        'gbxBillingAddress
        '
        Me.gbxBillingAddress.CausesValidation = False
        Me.gbxBillingAddress.Controls.Add(Me.txtBillingZip)
        Me.gbxBillingAddress.Controls.Add(Me.cboBillingState)
        Me.gbxBillingAddress.Controls.Add(Me.txtBillingCity)
        Me.gbxBillingAddress.Controls.Add(Me.txtBillingAddressLine2)
        Me.gbxBillingAddress.Controls.Add(Me.txtBillingAddressLine1)
        Me.gbxBillingAddress.Controls.Add(Me.lblBillingZip)
        Me.gbxBillingAddress.Controls.Add(Me.lblBillingState)
        Me.gbxBillingAddress.Controls.Add(Me.lblBillingCity)
        Me.gbxBillingAddress.Controls.Add(Me.lblBillingAddressLine2)
        Me.gbxBillingAddress.Controls.Add(Me.lblBillingAddressLine1)
        Me.gbxBillingAddress.Controls.Add(Me.chkSameAddress)
        Me.gbxBillingAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBillingAddress.Location = New System.Drawing.Point(19, 315)
        Me.gbxBillingAddress.Name = "gbxBillingAddress"
        Me.gbxBillingAddress.Size = New System.Drawing.Size(501, 161)
        Me.gbxBillingAddress.TabIndex = 7
        Me.gbxBillingAddress.TabStop = False
        Me.gbxBillingAddress.Text = "Billing Address"
        '
        'txtBillingZip
        '
        Me.txtBillingZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "billingZip", True))
        Me.txtBillingZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillingZip.Location = New System.Drawing.Point(127, 138)
        Me.txtBillingZip.Mask = "00000"
        Me.txtBillingZip.Name = "txtBillingZip"
        Me.txtBillingZip.Size = New System.Drawing.Size(40, 20)
        Me.txtBillingZip.TabIndex = 16
        '
        'cboBillingState
        '
        Me.cboBillingState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "billingState", True))
        Me.cboBillingState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBillingState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBillingState.FormattingEnabled = True
        Me.cboBillingState.Items.AddRange(New Object() {"Alabama" & Global.Microsoft.VisualBasic.ChrW(9) & "(AL)", "Alaska " & Global.Microsoft.VisualBasic.ChrW(9) & "(AK)", "Arizona " & Global.Microsoft.VisualBasic.ChrW(9) & "(AZ)", "Arkansas " & Global.Microsoft.VisualBasic.ChrW(9) & "(AR)", "California" & Global.Microsoft.VisualBasic.ChrW(9) & "(CA)", "Colorado" & Global.Microsoft.VisualBasic.ChrW(9) & "(CO)", "Connecticut (CT)", "Delaware" & Global.Microsoft.VisualBasic.ChrW(9) & "(DE)", "Florida" & Global.Microsoft.VisualBasic.ChrW(9) & "(FL)", "Georgia" & Global.Microsoft.VisualBasic.ChrW(9) & "(GA)", "Hawaii" & Global.Microsoft.VisualBasic.ChrW(9) & "(HI)", "Idaho" & Global.Microsoft.VisualBasic.ChrW(9) & "(ID)", "Illinois" & Global.Microsoft.VisualBasic.ChrW(9) & "(IL)", "Indiana" & Global.Microsoft.VisualBasic.ChrW(9) & "(IN)", "Iowa" & Global.Microsoft.VisualBasic.ChrW(9) & "(IA)", "Kansas" & Global.Microsoft.VisualBasic.ChrW(9) & "(KS)", "Kentucky" & Global.Microsoft.VisualBasic.ChrW(9) & "(KY)", "Louisiana" & Global.Microsoft.VisualBasic.ChrW(9) & "(LA)", "Maine" & Global.Microsoft.VisualBasic.ChrW(9) & "(ME)", "Maryland" & Global.Microsoft.VisualBasic.ChrW(9) & "(MD)", "Massachusetts  (MA)", "Michigan" & Global.Microsoft.VisualBasic.ChrW(9) & "(MI)", "Minnesota  (MN)", "Mississippi (MS)", "Missouri" & Global.Microsoft.VisualBasic.ChrW(9) & "(MO)", "Montana" & Global.Microsoft.VisualBasic.ChrW(9) & "(MT)", "Nebraska" & Global.Microsoft.VisualBasic.ChrW(9) & "(NE)", "Nevada" & Global.Microsoft.VisualBasic.ChrW(9) & "(NV)", "New Hampshire   (NH)", "New Jersey   (NJ)", "New Mexico   (NM)", "New York" & Global.Microsoft.VisualBasic.ChrW(9) & "(NY)", "North Carolina  (NC)", "North Dakota  (ND)", "Ohio  (OH)", "Oklahoma" & Global.Microsoft.VisualBasic.ChrW(9) & "  (OK)", "Oregon" & Global.Microsoft.VisualBasic.ChrW(9) & "(OR)", "Pennsylvania    (PA)", "Rhode Island   (RI)", "South Carolina   ( SC)", "South Dakota  (SD)", "Tennessee" & Global.Microsoft.VisualBasic.ChrW(9) & "  (TN)", "Texas   (TX)", "Utah" & Global.Microsoft.VisualBasic.ChrW(9) & "(UT)", "Vermont" & Global.Microsoft.VisualBasic.ChrW(9) & "(VT)", "Virginia" & Global.Microsoft.VisualBasic.ChrW(9) & "(VA)", "Washington  (WA)", "West Virginia   (WV)", "Wisconsin" & Global.Microsoft.VisualBasic.ChrW(9) & "  (WI)", "Wyoming" & Global.Microsoft.VisualBasic.ChrW(9) & "  (WY)"})
        Me.cboBillingState.Location = New System.Drawing.Point(127, 114)
        Me.cboBillingState.Name = "cboBillingState"
        Me.cboBillingState.Size = New System.Drawing.Size(121, 21)
        Me.cboBillingState.TabIndex = 15
        '
        'txtBillingCity
        '
        Me.txtBillingCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "billingCity", True))
        Me.txtBillingCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillingCity.Location = New System.Drawing.Point(127, 91)
        Me.txtBillingCity.Name = "txtBillingCity"
        Me.txtBillingCity.Size = New System.Drawing.Size(208, 20)
        Me.txtBillingCity.TabIndex = 14
        '
        'txtBillingAddressLine2
        '
        Me.txtBillingAddressLine2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "billingAddressLine2", True))
        Me.txtBillingAddressLine2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillingAddressLine2.Location = New System.Drawing.Point(127, 67)
        Me.txtBillingAddressLine2.Name = "txtBillingAddressLine2"
        Me.txtBillingAddressLine2.Size = New System.Drawing.Size(207, 20)
        Me.txtBillingAddressLine2.TabIndex = 13
        '
        'txtBillingAddressLine1
        '
        Me.txtBillingAddressLine1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "billingAddressLine1", True))
        Me.txtBillingAddressLine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillingAddressLine1.Location = New System.Drawing.Point(127, 43)
        Me.txtBillingAddressLine1.Name = "txtBillingAddressLine1"
        Me.txtBillingAddressLine1.Size = New System.Drawing.Size(207, 20)
        Me.txtBillingAddressLine1.TabIndex = 12
        '
        'lblBillingZip
        '
        Me.lblBillingZip.AutoSize = True
        Me.lblBillingZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingZip.Location = New System.Drawing.Point(11, 139)
        Me.lblBillingZip.Name = "lblBillingZip"
        Me.lblBillingZip.Size = New System.Drawing.Size(55, 13)
        Me.lblBillingZip.TabIndex = 5
        Me.lblBillingZip.Text = "Billing Zip:"
        '
        'lblBillingState
        '
        Me.lblBillingState.AutoSize = True
        Me.lblBillingState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingState.Location = New System.Drawing.Point(11, 117)
        Me.lblBillingState.Name = "lblBillingState"
        Me.lblBillingState.Size = New System.Drawing.Size(65, 13)
        Me.lblBillingState.TabIndex = 4
        Me.lblBillingState.Text = "Billing State:"
        '
        'lblBillingCity
        '
        Me.lblBillingCity.AutoSize = True
        Me.lblBillingCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingCity.Location = New System.Drawing.Point(11, 94)
        Me.lblBillingCity.Name = "lblBillingCity"
        Me.lblBillingCity.Size = New System.Drawing.Size(57, 13)
        Me.lblBillingCity.TabIndex = 3
        Me.lblBillingCity.Text = "Billing City:"
        '
        'lblBillingAddressLine2
        '
        Me.lblBillingAddressLine2.AutoSize = True
        Me.lblBillingAddressLine2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingAddressLine2.Location = New System.Drawing.Point(11, 70)
        Me.lblBillingAddressLine2.Name = "lblBillingAddressLine2"
        Me.lblBillingAddressLine2.Size = New System.Drawing.Size(110, 13)
        Me.lblBillingAddressLine2.TabIndex = 2
        Me.lblBillingAddressLine2.Text = "Billing Address Line 2:"
        '
        'lblBillingAddressLine1
        '
        Me.lblBillingAddressLine1.AutoSize = True
        Me.lblBillingAddressLine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillingAddressLine1.Location = New System.Drawing.Point(11, 46)
        Me.lblBillingAddressLine1.Name = "lblBillingAddressLine1"
        Me.lblBillingAddressLine1.Size = New System.Drawing.Size(110, 13)
        Me.lblBillingAddressLine1.TabIndex = 1
        Me.lblBillingAddressLine1.Text = "Billing Address Line 1:"
        '
        'chkSameAddress
        '
        Me.chkSameAddress.AutoSize = True
        Me.chkSameAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSameAddress.Location = New System.Drawing.Point(13, 21)
        Me.chkSameAddress.Name = "chkSameAddress"
        Me.chkSameAddress.Size = New System.Drawing.Size(385, 17)
        Me.chkSameAddress.TabIndex = 0
        Me.chkSameAddress.Text = "Select If Customer Billing Address is the same as the Service Address Above"
        Me.chkSameAddress.UseVisualStyleBackColor = True
        '
        'gbxBillingMethod
        '
        Me.gbxBillingMethod.Controls.Add(Me.dtpCardExp)
        Me.gbxBillingMethod.Controls.Add(Me.txtCardNumber)
        Me.gbxBillingMethod.Controls.Add(Me.cboCardType)
        Me.gbxBillingMethod.Controls.Add(Me.txtCheckNumber)
        Me.gbxBillingMethod.Controls.Add(Me.rdoCreditCard)
        Me.gbxBillingMethod.Controls.Add(Me.rdoCheck)
        Me.gbxBillingMethod.Controls.Add(Me.lblCardExp)
        Me.gbxBillingMethod.Controls.Add(Me.lblCardNumber)
        Me.gbxBillingMethod.Controls.Add(Me.lblSelectMethod)
        Me.gbxBillingMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBillingMethod.Location = New System.Drawing.Point(19, 482)
        Me.gbxBillingMethod.Name = "gbxBillingMethod"
        Me.gbxBillingMethod.Size = New System.Drawing.Size(501, 126)
        Me.gbxBillingMethod.TabIndex = 8
        Me.gbxBillingMethod.TabStop = False
        Me.gbxBillingMethod.Text = "Billing Method"
        '
        'dtpCardExp
        '
        Me.dtpCardExp.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInfoBindingSource, "cardExpiration", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.dtpCardExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCardExp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCardExp.Location = New System.Drawing.Point(366, 95)
        Me.dtpCardExp.Name = "dtpCardExp"
        Me.dtpCardExp.Size = New System.Drawing.Size(121, 20)
        Me.dtpCardExp.TabIndex = 16
        Me.dtpCardExp.Value = New Date(2014, 11, 30, 22, 16, 40, 0)
        '
        'txtCardNumber
        '
        Me.txtCardNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "cardNumber", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNumber.Location = New System.Drawing.Point(125, 93)
        Me.txtCardNumber.Mask = "0000 0000 0000 0000"
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(138, 20)
        Me.txtCardNumber.TabIndex = 15
        '
        'cboCardType
        '
        Me.cboCardType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "cardType", True))
        Me.cboCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCardType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCardType.FormattingEnabled = True
        Me.cboCardType.Items.AddRange(New Object() {"Visa", "MasterCard", "American Express", "Discover"})
        Me.cboCardType.Location = New System.Drawing.Point(111, 64)
        Me.cboCardType.Name = "cboCardType"
        Me.cboCardType.Size = New System.Drawing.Size(121, 21)
        Me.cboCardType.TabIndex = 14
        '
        'txtCheckNumber
        '
        Me.txtCheckNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "checkNumber", True))
        Me.txtCheckNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckNumber.Location = New System.Drawing.Point(111, 40)
        Me.txtCheckNumber.Name = "txtCheckNumber"
        Me.txtCheckNumber.Size = New System.Drawing.Size(120, 20)
        Me.txtCheckNumber.TabIndex = 13
        '
        'rdoCreditCard
        '
        Me.rdoCreditCard.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CustomerInfoBindingSource, "paymentType", True))
        Me.rdoCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCreditCard.Location = New System.Drawing.Point(21, 63)
        Me.rdoCreditCard.Name = "rdoCreditCard"
        Me.rdoCreditCard.Size = New System.Drawing.Size(88, 21)
        Me.rdoCreditCard.TabIndex = 12
        Me.rdoCreditCard.TabStop = True
        Me.rdoCreditCard.Text = "Credit Card"
        Me.rdoCreditCard.UseVisualStyleBackColor = True
        '
        'rdoCheck
        '
        Me.rdoCheck.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CustomerInfoBindingSource, "paymentType", True))
        Me.rdoCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCheck.Location = New System.Drawing.Point(21, 36)
        Me.rdoCheck.Name = "rdoCheck"
        Me.rdoCheck.Size = New System.Drawing.Size(58, 24)
        Me.rdoCheck.TabIndex = 11
        Me.rdoCheck.TabStop = True
        Me.rdoCheck.Text = "Check"
        Me.rdoCheck.UseVisualStyleBackColor = True
        '
        'lblCardExp
        '
        Me.lblCardExp.AutoSize = True
        Me.lblCardExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardExp.Location = New System.Drawing.Point(280, 98)
        Me.lblCardExp.Name = "lblCardExp"
        Me.lblCardExp.Size = New System.Drawing.Size(82, 13)
        Me.lblCardExp.TabIndex = 7
        Me.lblCardExp.Text = "Expiration Date:"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.Location = New System.Drawing.Point(46, 96)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(72, 13)
        Me.lblCardNumber.TabIndex = 5
        Me.lblCardNumber.Text = "Card Number:"
        '
        'lblSelectMethod
        '
        Me.lblSelectMethod.AutoSize = True
        Me.lblSelectMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectMethod.Location = New System.Drawing.Point(18, 18)
        Me.lblSelectMethod.Name = "lblSelectMethod"
        Me.lblSelectMethod.Size = New System.Drawing.Size(154, 13)
        Me.lblSelectMethod.TabIndex = 0
        Me.lblSelectMethod.Text = "Please Select A Billing Method:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(44, 614)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(105, 30)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(219, 614)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 30)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(390, 614)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(105, 30)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblNewCustomer
        '
        Me.lblNewCustomer.AutoSize = True
        Me.lblNewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewCustomer.Location = New System.Drawing.Point(199, 11)
        Me.lblNewCustomer.Name = "lblNewCustomer"
        Me.lblNewCustomer.Size = New System.Drawing.Size(146, 16)
        Me.lblNewCustomer.TabIndex = 12
        Me.lblNewCustomer.Text = "New Customer Form"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(27, 651)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 10
        '
        'lblAccountNumValue
        '
        Me.lblAccountNumValue.CausesValidation = False
        Me.lblAccountNumValue.Location = New System.Drawing.Point(129, 36)
        Me.lblAccountNumValue.Name = "lblAccountNumValue"
        Me.lblAccountNumValue.Size = New System.Drawing.Size(95, 16)
        Me.lblAccountNumValue.TabIndex = 15
        '
        'cboAccountStatus
        '
        Me.cboAccountStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerInfoBindingSource, "accountStatus", True))
        Me.cboAccountStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccountStatus.FormattingEnabled = True
        Me.cboAccountStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboAccountStatus.Location = New System.Drawing.Point(399, 36)
        Me.cboAccountStatus.Name = "cboAccountStatus"
        Me.cboAccountStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboAccountStatus.TabIndex = 16
        '
        'CustomerInfoTableAdapter
        '
        Me.CustomerInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerInfoTableAdapter = Me.CustomerInfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmNewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 670)
        Me.Controls.Add(Me.cboAccountStatus)
        Me.Controls.Add(Me.lblAccountNumValue)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblNewCustomer)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.gbxBillingMethod)
        Me.Controls.Add(Me.gbxBillingAddress)
        Me.Controls.Add(Me.gbxServiceAddress)
        Me.Controls.Add(Me.gbxCustomerInfo)
        Me.Controls.Add(Me.lblAccountStatus)
        Me.Controls.Add(Me.lblAccountNum)
        Me.Name = "frmNewCustomer"
        Me.Text = "New Customer Form"
        Me.gbxCustomerInfo.ResumeLayout(False)
        Me.gbxCustomerInfo.PerformLayout()
        CType(Me.CustomerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCustomerInfoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxServiceAddress.ResumeLayout(False)
        Me.gbxServiceAddress.PerformLayout()
        Me.gbxBillingAddress.ResumeLayout(False)
        Me.gbxBillingAddress.PerformLayout()
        Me.gbxBillingMethod.ResumeLayout(False)
        Me.gbxBillingMethod.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAccountNum As System.Windows.Forms.Label
    Friend WithEvents lblAccountStatus As System.Windows.Forms.Label
    Friend WithEvents gbxCustomerInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblNextService As System.Windows.Forms.Label
    Friend WithEvents lblEnrollmentDate As System.Windows.Forms.Label
    Friend WithEvents lblServicePlan As System.Windows.Forms.Label
    Friend WithEvents gbxServiceAddress As System.Windows.Forms.GroupBox
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblAddressLine2 As System.Windows.Forms.Label
    Friend WithEvents lblAddressLine1 As System.Windows.Forms.Label
    Friend WithEvents gbxBillingAddress As System.Windows.Forms.GroupBox
    Friend WithEvents lblBillingZip As System.Windows.Forms.Label
    Friend WithEvents lblBillingState As System.Windows.Forms.Label
    Friend WithEvents lblBillingCity As System.Windows.Forms.Label
    Friend WithEvents lblBillingAddressLine2 As System.Windows.Forms.Label
    Friend WithEvents lblBillingAddressLine1 As System.Windows.Forms.Label
    Friend WithEvents chkSameAddress As System.Windows.Forms.CheckBox
    Friend WithEvents gbxBillingMethod As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblCardExp As System.Windows.Forms.Label
    Friend WithEvents lblCardNumber As System.Windows.Forms.Label
    Friend WithEvents lblSelectMethod As System.Windows.Forms.Label
    Friend WithEvents lblNewCustomer As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    'Friend WithEvents CustomerInformationBindingNavigator As System.Windows.Forms.BindingNavigator
    'Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents CustomerInformationBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents CustomerInformation As BerrysBugBlastersCustomerSystem.CustomerInformation
    'Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    'Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    'Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents CustomerInformationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    'Friend WithEvents CustomerInformationTableAdapter As BerrysBugBlastersCustomerSystem.CustomerInformationTableAdapters.CustomerInformationTableAdapter
    'Friend WithEvents TableAdapterManager As BerrysBugBlastersCustomerSystem.CustomerInformationTableAdapters.TableAdapterManager
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents CustomerInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbCustomerInfoDataSet As BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSet
    Friend WithEvents CustomerInfoTableAdapter As BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSetTableAdapters.CustomerInfoTableAdapter
    Friend WithEvents TableAdapterManager As BerrysBugBlastersCustomerSystem.dbCustomerInfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dtpNextService As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnrollmentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboServicePlan As System.Windows.Forms.ComboBox
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblAccountNumValue As System.Windows.Forms.Label
    Friend WithEvents cboAccountStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressLine2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressLine1 As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBillingZip As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboBillingState As System.Windows.Forms.ComboBox
    Friend WithEvents txtBillingCity As System.Windows.Forms.TextBox
    Friend WithEvents txtBillingAddressLine2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBillingAddressLine1 As System.Windows.Forms.TextBox
    Friend WithEvents cboCardType As System.Windows.Forms.ComboBox
    Friend WithEvents txtCheckNumber As System.Windows.Forms.TextBox
    Friend WithEvents rdoCreditCard As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCheck As System.Windows.Forms.RadioButton
    Friend WithEvents txtCardNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtpCardExp As System.Windows.Forms.DateTimePicker
End Class
