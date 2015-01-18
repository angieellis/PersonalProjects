' form to show search results from the lookup form and allow the user to select a customer record
Public Class frmSearchResults

    Private Sub frmSearchResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' determine which select query to use based on the information entered in the lookup field on the lookup form
        ' fill the dgv with query results
        If getLookupCategory() = "accountNumber" Then
            Me.CustomerSearchTableAdapter.FillByAccountNumber(Me.DbCustomerSearch.CustomerInfo, getLookupValInt())
        ElseIf getLookupCategory() = "lastName" Then
            Me.CustomerSearchTableAdapter.FillByLastName(Me.DbCustomerSearch.CustomerInfo, getLookupVal())
        ElseIf getLookupCategory() = "phoneNumber" Then
            Me.CustomerSearchTableAdapter.FillByPhone(Me.DbCustomerSearch.CustomerInfo, getLookupVal())
        Else
            Me.CustomerSearchTableAdapter.Fill(Me.DbCustomerSearch.CustomerInfo)
        End If
    End Sub

    Private Sub dgvCustomerResults_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvCustomerResults.MouseDoubleClick
        selectCustomer()
    End Sub

    Private Sub dgvCustomerResults_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCustomerResults.CellMouseDoubleClick
        selectCustomer()
    End Sub

    Private Sub dgvCustomerResults_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerResults.CellContentClick
        selectCustomer()
    End Sub

    ' select the customer record that was clicked on and populate the lookup form with the results
    Private Sub selectCustomer()
        setSelectedAccount(CInt(dgvCustomerResults.Item(0, dgvCustomerResults.CurrentRow.Index).Value()))
        frmLookUpCustomer.Visible = True
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmLookUpCustomer.Visible = True
        Me.Close()
    End Sub
End Class