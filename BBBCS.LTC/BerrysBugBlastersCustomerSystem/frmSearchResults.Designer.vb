<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchResults
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
        Me.dgvCustomerResults = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbCustomerSearch = New BerrysBugBlastersCustomerSystem.dbCustomerSearch()
        Me.CustomerSearchTableAdapter = New BerrysBugBlastersCustomerSystem.dbCustomerSearchTableAdapters.CustomerInfoTableAdapter()
        Me.TableAdapterManager = New BerrysBugBlastersCustomerSystem.dbCustomerSearchTableAdapters.TableAdapterManager()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.CustomerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvCustomerResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCustomerResults
        '
        Me.dgvCustomerResults.AllowUserToAddRows = False
        Me.dgvCustomerResults.AllowUserToDeleteRows = False
        Me.dgvCustomerResults.AutoGenerateColumns = False
        Me.dgvCustomerResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.phoneNumber})
        Me.dgvCustomerResults.DataSource = Me.CustomerSearchBindingSource
        Me.dgvCustomerResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCustomerResults.Location = New System.Drawing.Point(0, 0)
        Me.dgvCustomerResults.Name = "dgvCustomerResults"
        Me.dgvCustomerResults.ReadOnly = True
        Me.dgvCustomerResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomerResults.Size = New System.Drawing.Size(443, 446)
        Me.dgvCustomerResults.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "accountNumber"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Account Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "firstName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "lastName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'phoneNumber
        '
        Me.phoneNumber.DataPropertyName = "phoneNumber"
        Me.phoneNumber.HeaderText = "Phone Number"
        Me.phoneNumber.Name = "phoneNumber"
        Me.phoneNumber.ReadOnly = True
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
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(176, 411)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'CustomerInfoBindingSource
        '
        Me.CustomerInfoBindingSource.DataMember = "CustomerInfo"
        Me.CustomerInfoBindingSource.DataSource = Me.DbCustomerSearch
        '
        'frmSearchResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(443, 446)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvCustomerResults)
        Me.Name = "frmSearchResults"
        Me.Text = "Search Results"
        CType(Me.dgvCustomerResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbCustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCustomerResults As System.Windows.Forms.DataGridView
    Friend WithEvents AccountNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents CustomerInformationBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents CustomerInformation As BerrysBugBlastersCustomerSystem.CustomerInformation
    'Friend WithEvents CustomerInformationBindingSource1 As System.Windows.Forms.BindingSource
    'Friend WithEvents CustomerInformationTableAdapter As BerrysBugBlastersCustomerSystem.CustomerInformationTableAdapters.CustomerInformationTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DbCustomerSearch As BerrysBugBlastersCustomerSystem.dbCustomerSearch
    Friend WithEvents CustomerSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerSearchTableAdapter As BerrysBugBlastersCustomerSystem.dbCustomerSearchTableAdapters.CustomerInfoTableAdapter
    Friend WithEvents TableAdapterManager As BerrysBugBlastersCustomerSystem.dbCustomerSearchTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents phoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents CustomerInfoBindingSource As System.Windows.Forms.BindingSource
End Class
