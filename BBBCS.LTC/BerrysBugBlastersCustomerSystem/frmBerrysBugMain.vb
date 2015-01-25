'  main form to navigate in application
Public Class frmBerrysBugMain

    'New Customer Form Creation Options: Selecting Button or Selecting from File

    ' Creates a new customer from the Menu option
    Private Sub mnuNewCustomer_Click(sender As Object, e As EventArgs) Handles mnuNewCustomer.Click
        ' When the new customer button is selected, the new customer form opens
        Dim newCustomer As New frmNewCustomer
        newCustomer.Show()
        Me.Hide()
    End Sub

    ' Looks up existing customers from the Menu item
    Private Sub mnuLookupCustomer_Click(sender As Object, e As EventArgs) Handles mnuLookupCustomer.Click
        ' When File>Look Up Existing Customer is selected
        Dim lookupForm As New frmLookUpCustomer
        lookupForm.Show()
        Me.Hide()
    End Sub

    ' File>Exit Closes the Main Form
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    ' Creates a new customer form when the new customer button is clicked
    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        Dim newCustomer As New frmNewCustomer
        newCustomer.Show()
        Me.Hide()
    End Sub

    ' Handles the look up customer button click event
    Private Sub btnLookupCustomer_Click(sender As Object, e As EventArgs) Handles btnLookupCustomer.Click
        Dim lookupForm As New frmLookUpCustomer
        lookupForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
