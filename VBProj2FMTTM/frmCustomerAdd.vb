Imports System.Data.SQLite
Imports System.IO
Public Class frmCustomerAdd
    Private Sub frmCustomerAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim intNextPrimaryKey As Integer
        Dim strFirstName As String
        Dim strLastName As String
        Dim strAddress As String
        Dim strCity As String
        Dim strZip As String
        Dim strPhone As String
        Dim strEmail As String
        Dim intStateID As Integer

        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        strAddress = txtAddress.Text
        strCity = txtCity.Text
        strZip = txtZip.Text
        strPhone = txtPhone.Text
        strEmail = txtEmail.Text
        intStateID = cboState.SelectedValue


        Dim databasePath As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
    "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strKeyQuery As String = "SELECT MAX(intPassengerID) + 1 FROM TPassengers"
            Using command As New SQLiteCommand(strKeyQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    reader.Read()
                    intNextPrimaryKey = reader.GetInt32(0)
                End Using
            End Using

            Dim strInsertQuery As String =
            $"INSERT INTO TPassengers VALUES ({intNextPrimaryKey}, '{strFirstName}', '{strLastName}', '{strAddress}', '{strCity}', {intStateID},  '{strZip}', '{strPhone}', '{strEmail}')"
            Using command As New SQLiteCommand(strInsertQuery, conn)
                command.ExecuteNonQuery()
            End Using


        End Using

        MessageBox.Show("Added New Passenger!")
    End Sub
End Class