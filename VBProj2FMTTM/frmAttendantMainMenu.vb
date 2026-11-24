Imports System.Data.SQLite
Imports SourceGear.sqlite3
Public Class frmAttendantMainMenu
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intAttendantID = intReceivedValue
    End Sub
    Private Sub btnShowFlights_Click(sender As Object, e As EventArgs) Handles btnShowFlights.Click
        Dim frmShowAttendantFlightsDisplay As New frmShowAttendantFlights(intAttendantID)
        frmShowAttendantFlightsDisplay.ShowDialog()
    End Sub
End Class