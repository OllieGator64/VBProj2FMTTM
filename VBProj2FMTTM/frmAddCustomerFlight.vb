Imports System.Data.SQLite
Imports System.IO
Imports SourceGear.sqlite3
Public Class frmAddCustomerFlight
    Dim intCustomerID As Integer ' A class variable
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intCustomerID = intReceivedValue
    End Sub

    Private Sub frmAddCustomerFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
    "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String = "SELECT intFlightID, strFlightNumber FROM TFlights"
            Using command As New SQLiteCommand(strQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                cboFlights.DataSource = dataTable
                cboFlights.DisplayMember = "strFlightNumber"
                cboFlights.ValueMember = "intFlightID"
            End Using
        End Using
    End Sub
End Class