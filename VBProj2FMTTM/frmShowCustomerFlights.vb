Imports System.Data.SQLite
Imports SourceGear.sqlite3
Public Class frmShowCustomerFlights
    Dim intCustomerID As Integer ' A class variable
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intCustomerID = intReceivedValue
    End Sub

    Private Sub frmShowCustomerFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=flyme2themoon.db;Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String =
                "SELECT *
                FROM TPassengers"
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strPassenger As String = reader.GetString(1)
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class