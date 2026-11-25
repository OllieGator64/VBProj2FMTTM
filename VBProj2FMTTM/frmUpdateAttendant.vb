Public Class frmUpdateAttendant
    Dim intAttendantID As Integer ' A class variable
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intAttendantID = intReceivedValue
    End Sub
    Private Sub frmUpdateAttendant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class