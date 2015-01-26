'  main form to navigate in application
Public Class frmBerrysBugMain

    ' create new customer form (menu option)
    Private Sub mnuNewCustomer_Click(sender As Object, e As EventArgs) Handles mnuNewCustomer.Click
        Dim newCustomer As New frmNewCustomer
        newCustomer.Show()
        Me.Hide()
    End Sub

    ' look up existing customers (menu option)
    Private Sub mnuLookupCustomer_Click(sender As Object, e As EventArgs) Handles mnuLookupCustomer.Click
        Dim lookupForm As New frmLookUpCustomer
        lookupForm.Show()
        Me.Hide()
    End Sub

    ' exit program (menu option)
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    ' create new customer form 
    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        Dim newCustomer As New frmNewCustomer
        newCustomer.Show()
        Me.Hide()
    End Sub

    ' open customer lookup form
    Private Sub btnLookupCustomer_Click(sender As Object, e As EventArgs) Handles btnLookupCustomer.Click
        Dim lookupForm As New frmLookUpCustomer
        lookupForm.Show()
        Me.Hide()
    End Sub

    ' exit program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
