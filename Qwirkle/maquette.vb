﻿Public Class maquette
    Private Sub cmdMenu_Click(sender As Object, e As EventArgs) Handles cmdMenu.Click
        Me.Hide()
        frPagemenu.Show()
    End Sub
    Private Sub quitter_Click(sender As Object, e As EventArgs) Handles quitter.Click
        Dim Rep As DialogResult
        Rep = MessageBox.Show("Voulez vous vraiment quitter?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Rep = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Retour_Click(sender As Object, e As EventArgs) Handles Retour.Click
        Me.Hide()
        appli.Show()
    End Sub
End Class