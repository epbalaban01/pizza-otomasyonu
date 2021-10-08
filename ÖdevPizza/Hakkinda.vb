Public Class Hakkinda
    Private Sub buttonOK_Click(sender As Object, e As EventArgs) Handles buttonOK.Click
        Me.Close()
    End Sub

    Private Sub Hakkinda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label5.Text = "Dosya Adı: " & Application.ProductName.Trim
        Label7.Text = "Version: " & Application.ProductVersion.Trim
    End Sub

    Private Sub linkLabelWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://dinarmyo.aku.edu.tr")
    End Sub
End Class