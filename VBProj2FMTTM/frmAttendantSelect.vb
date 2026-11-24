Imports System.Data.SQLite
Imports SourceGear.sqlite3
Public Class frmAttendantSelect
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim frmAttendantMainMenuDisplay As New frmAttendantMainMenu(intAttendantID)
        frmAttendantMainMenuDisplay.ShowDialog()
    End Sub
End Class