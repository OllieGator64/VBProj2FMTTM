Imports System.Data.SQLite
Imports SourceGear.sqlite3
Public Class frmCustomerMainMenu
    Dim intCustomerID As Integer ' A class variable
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intCustomerID = intReceivedValue
    End Sub

    Private Sub btnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        Dim frmUpdateCustomerDisplay As New frmUpdateCustomer(intCustomer)
        frmUpdateCustomerDisplay.ShowDialog()
    End Sub

    Private Sub btnCustomerFlight_Click(sender As Object, e As EventArgs) Handles btnCustomerFlight.Click
        Dim frmAddCustomerFlightDisplay As New frmAddCustomerFlight(intCustomer)
        frmAddCustomerFlightDisplay.ShowDialog()
    End Sub

    Private Sub btnShowFlights_Click(sender As Object, e As EventArgs) Handles btnShowFlights.Click
        Dim frmShowCustomerFlightsDisplay As New frmShowCustomerFlights(intCustomer)
        frmShowCustomerFlightsDisplay.ShowDialog()
    End Sub
End Class