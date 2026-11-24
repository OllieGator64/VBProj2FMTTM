Imports System.Data.SQLite
Imports System.IO
Imports SourceGear.sqlite3
Public Class frmUpdateCustomer
    Dim CustomerID As Integer ' A class variable
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        CustomerID = intReceivedValue
    End Sub

    Private Sub frmUpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\flyme2themoon.db"))
        Dim connectionString As String =
    "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String = "SELECT intStateID, strState FROM TStates"
            Using command As New SQLiteCommand(strQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                cboState.DataSource = dataTable
                cboState.DisplayMember = "strState"
                cboState.ValueMember = "intStateID"
            End Using
        End Using
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strAddress As String
        Dim strCity As String
        Dim strZip As String
        Dim strPhone As String
        Dim strEmail As String
        Dim intStateID As Integer
        Dim intPassengerID As Integer

        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        strAddress = txtAddress.Text
        strCity = txtCity.Text
        strZip = txtZip.Text
        strPhone = txtPhone.Text
        strEmail = txtEmail.Text
        intStateID = cboState.SelectedValue
        intPassengerID = CustomerID

        Dim strUpdateQuery As String =
            $"UPDATE TPassengers
            SET strFirstName = '{strFirstName}',
            strLastName = '{strLastName}',
            strAddress = '{strAddress}',
            strCity = '{strCity}',
            strZip = '{strZip}',
            strPhoneNumber = '{strPhone}',
            strEmail = '{strEmail}',
            intStateID = {intStateID}
            WHERE intPassengerID = {intPassengerID}"

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