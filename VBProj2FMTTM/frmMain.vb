Imports System.Data.SQLite
Imports SourceGear.sqlite3

Public Class frmMain
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim frmCustomerSelectDisplay As New frmCustomerSelect
        frmCustomerSelectDisplay.ShowDialog()
    End Sub

    Private Sub btnPilots_Click(sender As Object, e As EventArgs) Handles btnPilots.Click
        Dim frmPilotSelectDisplay As New frmPilotSelect
        frmPilotSelectDisplay.ShowDialog()
    End Sub

    Private Sub btnAttendants_Click(sender As Object, e As EventArgs) Handles btnAttendants.Click
        Dim frmAttendantSelectDisplay As New frmAttendantSelect
        frmAttendantSelectDisplay.ShowDialog()
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Dim frmStatisticsDisplay As New frmStatistics
        frmStatisticsDisplay.ShowDialog()
    End Sub
End Class
