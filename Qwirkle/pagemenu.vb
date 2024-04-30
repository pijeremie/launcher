
Public Class frPagemenu

    Private Sub boutonInformations_Click(sender As Object, e As EventArgs) Handles boutonInformations.Click
        Me.Hide()
        membres.Show()
    End Sub

    Private Sub boutonAppli_Click(sender As Object, e As EventArgs) Handles boutonAppli.Click
        Me.Hide()
        appli.Show()
    End Sub

    Private Sub boutonExplications_Click(sender As Object, e As EventArgs) Handles boutonExplications.Click
        Me.Hide()
        explications.Show()
    End Sub

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles quitter.Click
        Dim rep As DialogResult
        rep = MessageBox.Show("Voulez vous vraiment quitter?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If rep = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub FrPagemenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class
