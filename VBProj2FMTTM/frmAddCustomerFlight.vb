Imports System.Data.SQLite
Imports SourceGear.sqlite3
Public Class frmAddCustomerFlight
    Dim intCustomerID As Integer ' A class variable
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intCustomerID = intReceivedValue
    End Sub

End Class