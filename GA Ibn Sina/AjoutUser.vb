Imports System.Data.SqlClient
Public Class AjoutUser
   

    Private Sub AjoutUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmd.Connection = cn
        cmd.CommandType = CommandType.Text

        If modifierU Then
            lister()

        End If
    End Sub
    Private Sub AccueilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccueilToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Sub ajouter()
        cn.Open()
        Dim typeee As String = ""
        Try

            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select count(cin) from utilisateur where cin='" & TextBox1.Text & "'"
            Dim nbe As Integer = cmd.ExecuteScalar()

            If modifierU = True And nbe <> 0 Then
                If RadioButton1.Checked Then
                    typeee = "admin"
                End If
                If RadioButton2.Checked Then
                    typeee = "employe"
                End If
                cmd = New sqlCommand("update utilisateur set cin='" & TextBox1.Text & "',nom='" & TextBox2.Text & "',prenom='" & TextBox3.Text & "',ville='" & TextBox4.Text & "',adresse='" & TextBox5.Text & "',dateN='" & DateTimePicker1.Value & "',tel='" & TextBox10.Text & "',email='" & TextBox7.Text & "',pwd='" & TextBox6.Text & "',indice='" & TextBox8.Text & "',type='" & typeee & "',blockage='non' where cin='" & cinm & "'",cn)
                cmd.ExecuteNonQuery()
                cn.Close()

                MsgBox("modifier avec succes12333")
                Me.Hide()
                AfficherToutU.Show()
                AfficherToutU.afficher()
                modifierU = False

            ElseIf modifierU = False And nbe = 0 Then
                '-----------------------------------------------
                If RadioButton1.Checked Then
                    typeee = "admin"
                End If
                If RadioButton2.Checked Then
                    typeee = "employe"
                End If
                cmd.CommandText = ("insert into utilisateur values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & DateTimePicker1.Value & "','" & TextBox10.Text & "','" & TextBox7.Text & "','" & TextBox6.Text & "','" & TextBox8.Text & "','" & typeee & "','non')")

                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("Ajouter avec succes")
                Me.Hide()
                AfficherToutU.Show()
                AfficherToutU.afficher()


            Else
                MsgBox("Ce Utilisateur deja exist")
                cn.Close()
            End If
        Catch a As Exception
            cn.Close()
            MsgBox("Il y a un champ vide !!")
        End Try



    End Sub
    Sub lister()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        If modifierU Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * from utilisateur where cin='" & cinm & "'"
            dr = cmd.ExecuteReader()
            If dr.Read Then
                TextBox1.Text = dr.Item(0)
                TextBox2.Text = dr.Item(1)
                TextBox3.Text = dr.Item(2)
                TextBox4.Text = dr.Item(3)
                TextBox5.Text = dr.Item(4)
                TextBox6.Text = dr.Item(8)
                TextBox7.Text = dr.Item(7)
                TextBox8.Text = dr.Item(9)
                TextBox9.Text = dr.Item(9)
                TextBox10.Text = dr.Item(6)
                DateTimePicker1.Text = dr.Item(5)
                If dr.Item(10) = "admin" Then
                    RadioButton1.Select()
                Else
                    RadioButton2.Select()

                End If

            End If
            dr.Close()
            cn.Close()
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ajouter()
    End Sub

    '-------------------------------------------------------------------------------------------------------


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

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'RechercherToolStripMenuItem.Enabled = False
        Label1.Text = nomcplt
    End Sub

    Private Sub ModifierMonCompteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierMonCompteToolStripMenuItem.Click
        Try
            modifierU = True
            cn.Open()
            cmd.CommandText = "select * from utilisateur where cin='" & moncin & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                cinm = moncin
                TextBox1.Text = dr.Item(0)
                TextBox2.Text = dr.Item(1)
                TextBox3.Text = dr.Item(2)
                TextBox4.Text = dr.Item(3)
                TextBox5.Text = dr.Item(4)
                DateTimePicker1.Value = dr.Item(5)
                TextBox10.Text = dr.Item(6)
                TextBox7.Text = dr.Item(7)
                TextBox6.Text = dr.Item(8)
                TextBox9.Text = dr.Item(8)
                TextBox8.Text = dr.Item(9)
                If dr.Item(10) = " Admin" Then
                    RadioButton1.Checked = True
                Else
                    RadioButton2.Checked = True
                End If

            End While
            cn.Close()

            



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
        Form2.Button5_Click(sender, e)
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form2.Button5_Click(sender, e)
        Me.Hide()
    End Sub

    Private Sub AjouterUnAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnAdminToolStripMenuItem.Click
        modifierU = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        statistique.Show()
    End Sub
End Class