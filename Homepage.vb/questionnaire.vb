Public Class questionnaire
    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Homepage2.Show()

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PrintDialogQuestionnaire.Document = PrintDocumentUser
        PrintDialogQuestionnaire.PrinterSettings = PrintDocumentUser.PrinterSettings
        If PrintDialogQuestionnaire.ShowDialog <> DialogResult.Cancel Then
            PrintDocumentUser.PrinterSettings = PrintDialogQuestionnaire.PrinterSettings
            PrintDocumentUser.Print()
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PrintToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialogQuestionnaire.Document = PrintDocumentUser
        PrintDialogQuestionnaire.PrinterSettings = PrintDocumentUser.PrinterSettings
        If PrintDialogQuestionnaire.ShowDialog <> DialogResult.Cancel Then
            PrintDocumentUser.PrinterSettings = PrintDialogQuestionnaire.PrinterSettings
            PrintDocumentUser.Print()
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        Homepage2.Show()

    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        contactUs.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("You are stress !")

    End Sub
End Class