Public Class Admin
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim adminpanel As New AdminPanel
        adminpanel.Show()
        Me.Hide()
    End Sub
End Class