Public Class v2
    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
        AxWindowsMediaPlayer1.URL = "C:\Users\User\OneDrive\Documents\Visual Studio 2015\Projects\Homepage.vb\Video\Sexual Abuse in the Family.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub v2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        Homepage2.Show()
    End Sub
End Class