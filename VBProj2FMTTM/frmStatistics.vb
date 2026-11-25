Imports System.Data.SQLite
Imports SourceGear.sqlite3
Public Class frmStatistics
    Private Sub frmStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFlightsTaken.Text = ""
        lblTotalCustomers.Text = ""
        lblAverageMiles.Text = ""

    End Sub
End Class