Public Class Form2

    
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        AjoutEtudiant.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        AfficherToutE.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        AfficherToutE.Show()

    End Sub

    Private Sub AjouterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem.Click
        Me.Hide()
        AjoutEtudiant.Show()
        modifier = False
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem.Click
        Me.Hide()
        AfficherToutE.Show()
        modifier = True
    End Sub

    Private Sub ChercherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChercherToolStripMenuItem.Click
        Me.Hide()
        AfficherToutE.Show()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        Me.Hide()
        AfficherToutE.Show()
    End Sub

    Private Sub ImprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerToolStripMenuItem.Click
        Me.Hide()
        AfficherToutE.Show()

    End Sub

    Private Sub AjouterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem1.Click
        Me.Hide()
        AjoutUser.Show()
        modifierU = False
    End Sub

    Private Sub ModifierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem1.Click
        Me.Hide()
        AfficherToutU.Show()
        modifierU = True
    End Sub

    Private Sub SupprimerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem1.Click
        Me.Hide()
        AfficherToutU.Show()
    End Sub

    Private Sub RechercherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercherToolStripMenuItem.Click
        Me.Hide()
        AfficherToutU.Show()
    End Sub

    Private Sub AfficherToutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AfficherToutToolStripMenuItem1.Click
        Me.Hide()
        AfficherToutU.Show()

    End Sub
    Sub enablediter()
        If montype.Replace(" ", "") = "admin" Then
            Button1.Enabled = True
            AjouterToolStripMenuItem.Enabled = True
            ModifierToolStripMenuItem1.Enabled = True
            SupprimerMonCompteToolStripMenuItem.Enabled = True
            UtilisateursToolStripMenuItem.Enabled = True
            AjouterUnAdminToolStripMenuItem.Enabled = True
            ModifierToolStripMenuItem.Enabled = True
            SupprimerToolStripMenuItem.Enabled = True
            ModifierMonCompteToolStripMenuItem.Enabled = True
            ' MsgBox("mon type:" & montype)

           
        ElseIf montype.Replace(" ", "") = "employe" Then
            Button1.Enabled = False
            AjouterToolStripMenuItem.Enabled = False
            ModifierToolStripMenuItem1.Enabled = False
            SupprimerMonCompteToolStripMenuItem.Enabled = False
            UtilisateursToolStripMenuItem.Enabled = False
            AjouterUnAdminToolStripMenuItem.Enabled = False
            ModifierToolStripMenuItem.Enabled = False
            SupprimerToolStripMenuItem.Enabled = False
            ModifierMonCompteToolStripMenuItem.Enabled = False
            ' MsgBox("mon type1:" & montype)
        End If
    End Sub
    Public Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' MsgBox(nomcplt)
        Label1.Text = nomcplt
        enablediter()

    End Sub

    Private Sub ModifierMonCompteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierMonCompteToolStripMenuItem.Click
        Try
            modifierU = True
            cn.Open()
            cmd.CommandText = "select * from utilisateur where cin='" & moncin & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                cinm = moncin
                AjoutUser.TextBox1.Text = dr.Item(0)
                AjoutUser.TextBox2.Text = dr.Item(1)
                AjoutUser.TextBox3.Text = dr.Item(2)
                AjoutUser.TextBox4.Text = dr.Item(3)
                AjoutUser.TextBox5.Text = dr.Item(4)
                AjoutUser.DateTimePicker1.Value = dr.Item(5)
                AjoutUser.TextBox10.Text = dr.Item(6)
                AjoutUser.TextBox7.Text = dr.Item(7)
                AjoutUser.TextBox6.Text = dr.Item(8)
                AjoutUser.TextBox9.Text = dr.Item(8)
                AjoutUser.TextBox8.Text = dr.Item(9)
                If dr.Item(10) = " Admin" Then
                    AjoutUser.RadioButton1.Checked = True
                Else
                    AjoutUser.RadioButton2.Checked = True
                End If

            End While
            cn.Close()

            Me.Hide()
            AjoutUser.Show()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChangerMotDePasseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangerMotDePasseToolStripMenuItem.Click
        Me.Hide()
        modifierpwd.Show()
    End Sub

    Private Sub SupprimerMonCompteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerMonCompteToolStripMenuItem.Click
        Dim pwdsupp = InputBox("Entrez votre mot de passe :")
        If pwdsupp = monpwd.Replace(" ", "") Then
            Try
                cn.Open()
                cmd.Connection = cn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from utilisateur where cin='" & moncin & "'"
                cmd.ExecuteNonQuery()
                cn.Close()
                Me.Hide()
                Form1.Show()
            Catch ex As Exception

            End Try
        Else
            MsgBox("mot de passe est incorrect !!")
        End If
    End Sub

    Private Sub AfficherInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AfficherInfoToolStripMenuItem.Click
        montype = Nothing
        AfficherToutE.Dispose()
        AfficherToutU.Dispose()
        AjoutEtudiant.Dispose()
        AjoutUser.Dispose()
        Me.Hide()
        Me.Dispose()
        Form1.Show()
    End Sub

    Public Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        montype = Nothing
        AfficherToutE.Dispose()
        AfficherToutU.Dispose()
        AjoutEtudiant.Dispose()
        AjoutUser.Dispose()

        Me.Hide()
        Me.Dispose()
        Form1.Show()
    End Sub

    Private Sub AjouterUnAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnAdminToolStripMenuItem.Click
        Me.Hide()

        AjoutUser.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        statistique.Show()
    End Sub

    
    Private Sub MassarServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MassarServiceToolStripMenuItem.Click
        Me.Hide()
        massar.Show()
    End Sub
End Class