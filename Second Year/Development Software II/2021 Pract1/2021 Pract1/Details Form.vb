Public Class frmDetailsApp

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Display Name an Major using the two Text Boxes Controls
        txtName.Text = "Percival Reddington"
        txtMajor.Text = "Software Development"
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the Form
        Me.Close()
        'Me.Dispose()
    End Sub

    Private Sub frmDetailsApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblCompanyName_Click(sender As Object, e As EventArgs) Handles lblCompanyName.Click
        Dim lblCompanyName As String = "PCP Software"
        lblCompanyName = "PCP Software"
    End Sub
End Class
