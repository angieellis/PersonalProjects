<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBerrysBugMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.filMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLookupCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.btnLookupCustomer = New System.Windows.Forms.Button()
        Me.gbxMainForm = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.gbxMainForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.filMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(386, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'filMenu
        '
        Me.filMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewCustomer, Me.mnuLookupCustomer, Me.mnuExit})
        Me.filMenu.Name = "filMenu"
        Me.filMenu.Size = New System.Drawing.Size(37, 20)
        Me.filMenu.Text = "&File"
        '
        'mnuNewCustomer
        '
        Me.mnuNewCustomer.Name = "mnuNewCustomer"
        Me.mnuNewCustomer.Size = New System.Drawing.Size(216, 22)
        Me.mnuNewCustomer.Text = "Create &New Customer"
        '
        'mnuLookupCustomer
        '
        Me.mnuLookupCustomer.Name = "mnuLookupCustomer"
        Me.mnuLookupCustomer.Size = New System.Drawing.Size(216, 22)
        Me.mnuLookupCustomer.Text = "&Look Up Existing Customer"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(216, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Location = New System.Drawing.Point(19, 34)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(152, 52)
        Me.btnNewCustomer.TabIndex = 1
        Me.btnNewCustomer.Text = "&Create New Customer"
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'btnLookupCustomer
        '
        Me.btnLookupCustomer.Location = New System.Drawing.Point(190, 34)
        Me.btnLookupCustomer.Name = "btnLookupCustomer"
        Me.btnLookupCustomer.Size = New System.Drawing.Size(155, 52)
        Me.btnLookupCustomer.TabIndex = 2
        Me.btnLookupCustomer.Text = "&Look Up Existing Customer"
        Me.btnLookupCustomer.UseVisualStyleBackColor = True
        '
        'gbxMainForm
        '
        Me.gbxMainForm.Controls.Add(Me.btnExit)
        Me.gbxMainForm.Controls.Add(Me.btnNewCustomer)
        Me.gbxMainForm.Controls.Add(Me.btnLookupCustomer)
        Me.gbxMainForm.Location = New System.Drawing.Point(12, 39)
        Me.gbxMainForm.Name = "gbxMainForm"
        Me.gbxMainForm.Size = New System.Drawing.Size(362, 153)
        Me.gbxMainForm.TabIndex = 3
        Me.gbxMainForm.TabStop = False
        Me.gbxMainForm.Text = "Select An Option"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(260, 111)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 27)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmBerrysBugMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 198)
        Me.Controls.Add(Me.gbxMainForm)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBerrysBugMain"
        Me.Text = "Berry's Bug Blasters Main Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbxMainForm.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents filMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLookupCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents btnLookupCustomer As System.Windows.Forms.Button
    Friend WithEvents gbxMainForm As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
