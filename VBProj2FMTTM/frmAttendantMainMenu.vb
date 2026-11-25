Imports System.Data.SQLite
Imports SourceGear.sqlite3
Public Class frmAttendantMainMenu
    Dim intAttendantID As Integer ' A class variable
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intAttendantID = intReceivedValue
    End Sub
    Private Sub btnShowFlights_Click(sender As Object, e As EventArgs) Handles btnShowFlights.Click
        Dim frmShowAttendantFlightsDisplay As New frmShowAttendantFlights(intAttendantID)
        frmShowAttendantFlightsDisplay.ShowDialog()
    End Sub

    Private Sub btnUpdateAttendant_Click(sender As Object, e As EventArgs) Handles btnUpdateAttendant.Click
        Dim frmUpdateAttendantDisplay As New frmUpdateAttendant(intAttendantID)
        frmUpdateAttendantDisplay.ShowDialog()
    End Sub
End Class