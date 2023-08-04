Imports System.Data.SqlClient
Public Class modifierpwd

    Private Sub modifierpwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cn.Open()
            cmd = New SqlCommand("select count(cin) from utilisateur where pwd='" & TextBox1.Text & "'", cn)
            Dim n As Integer = cmd.ExecuteScalar()
            If TextBox3.Text = TextBox2.Text And n <> 0 Then
                cmd = New SqlCommand("update utilisateur set pwd='" & TextBox2.Text & "' where cin='" & moncin & "'", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Le mot de passe a ete modifier avec succes")
            Else
                If n = 0 Then
                    MsgBox("l'ancien mot de passe est incorrecte !!")
                Else
                    MsgBox("Mot de passe non confirmer, verifier le nouveau mot de passe")
                End If
            End If
        Catch ex As Exception

        End Try
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class