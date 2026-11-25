Imports System.Data.SQLite
Imports SourceGear.sqlite3
Public Class frmAttendantSelect
    Private Sub frmAttendantSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=flyme2themoon.db;Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String = "SELECT strLastName FROM TPassengers"
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strLastName As String = reader.GetString(0)
                        cboAttendant.Items.Add(strLastName)
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim frmAttendantMainMenuDisplay As New frmAttendantMainMenu(cboAttendant.SelectedValue)
        frmAttendantMainMenuDisplay.ShowDialog()
    End Sub
End Class