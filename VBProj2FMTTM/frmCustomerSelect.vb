Imports System.Data.SQLite
Imports SourceGear.sqlite3
Public Class frmCustomerSelect
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim frmAddCustomerDisplay As New frmCustomerAdd
        frmAddCustomerDisplay.ShowDialog()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim frmCustomerMainMenuDisplay As New frmCustomerMainMenu(intCustomer)
        frmCustomerMainMenuDisplay.ShowDialog()
    End Sub
End Class