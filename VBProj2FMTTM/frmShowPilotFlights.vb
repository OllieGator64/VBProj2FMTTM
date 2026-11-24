Imports System.Data.SQLite
Imports SourceGear.sqlite3
Public Class frmShowPilotFlights
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intPilotID = intReceivedValue
    End Sub
    Private Sub frmShowPilotFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class