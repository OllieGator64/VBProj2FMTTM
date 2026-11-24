Imports System.Data.SQLite
Imports SourceGear.sqlite3
Public Class frmPilotMainMenu
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intPilotID = intReceivedValue
    End Sub
    Private Sub btnUpdatePilot_Click(sender As Object, e As EventArgs) Handles btnUpdatePilot.Click
        Dim frmUpdatePilotDisplay As New frmUpdatePilot(intPilotID)
        frmUpdatePilotDisplay.ShowDialog()
    End Sub

    Private Sub btnShowFlights_Click(sender As Object, e As EventArgs) Handles btnShowFlights.Click
        Dim frmShowPilotFlightsDisplay As New frmShowPilotFlights(intPilotID)
        frmShowPilotFlightsDisplay.ShowDialog()
    End Sub
End Class