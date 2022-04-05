Public Class Form1
    Protected Overrides Sub WndProc(ByRef m As Message)
        DarkMode.WndProc(Me, m, DarkMode.DarkMode.Theme.SYSTEM)
        MyBase.WndProc(m)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(Me, "Hello")
    End Sub
End Class
