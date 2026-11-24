Imports System.Data.SQLite
Imports SourceGear.sqlite3
Public Class frmPilotSelect
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim frmPilotMainMenuDisplay As New frmPilotMainMenu(intPilot)
        frmPilotMainMenuDisplay.ShowDialog()
    End Sub
End Class