Imports System.Data.SQLite
Imports System.IO
Imports SourceGear.sqlite3
Public Class frmUpdatePilot
    Dim intPilotID As Integer ' A class variable
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intPilotID = intReceivedValue
    End Sub

    Private Sub frmUpdatePilot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\flyme2themoon.db"))
        Dim connectionString As String =
    "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String = "SELECT intPilotRoleID, strPilotRole FROM TPilotRoles"
            Using command As New SQLiteCommand(strQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                cboRole.DataSource = dataTable
                cboRole.DisplayMember = "strPilotRole"
                cboRole.ValueMember = "intPilotRoleID"
            End Using
        End Using
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strEmployeeID As Integer
        Dim strHireDate As String
        Dim strTerminationDate As String
        Dim strLicenseDate As String
        Dim intPilotRole As Integer
        Dim intPilotsID As Integer

        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        strEmployeeID = txtEmployeeID.Text
        strHireDate = txtDateOfHire.Text
        strTerminationDate = txtDateofTermination.Text
        strLicenseDate = txtDateofLicense.Text
        intPilotRole = cboRole.SelectedValue
        intPilotsID = intPilotID

        Dim strUpdateQuery As String =
            $"UPDATE TPilots
            SET strFirstName = '{strFirstName}',
            strLastName = '{strLastName}',
            strEmployeeID = '{strEmployeeID}',
            dtmDateOfHire = '{strHireDate}',
            dtmDateOfTermination = '{strTerminationDate}',
            dtmDateOfLicense = '{strLicenseDate}',
            intPilotRoleID = {intPilotRole}
            WHERE intPilotID = {intPilotsID}"

        Dim databasePath As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\flyme2themoon.db"))
        Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using command As New SQLiteCommand(strUpdateQuery, conn)
                command.ExecuteNonQuery()
            End Using

        End Using

    End Sub
End Class