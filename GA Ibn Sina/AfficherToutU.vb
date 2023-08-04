﻿Imports System.Drawing.Printing

Public Class AfficherToutU
    Sub afficher()
        Dim a As Integer = 0
        Dim t As New DataTable
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT * FROM utilisateur"
        dr = cmd.ExecuteReader()
        t.Load(dr)
        cmd.CommandText = "SELECT COUNT(cin) FROM utilisateur"
        dr = cmd.ExecuteReader()
        dr.Read()
        a = dr.Item(0)

        cn.Close()

        DataGridView1.DataSource = t
        Label3.Text = "Nombre des utilisateur:  " & a
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
            ModifierMonCompteToolStripMenuItem.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
        Else
            Button1.Enabled = False
            AjouterToolStripMenuItem.Enabled = False
            ModifierToolStripMenuItem1.Enabled = False
            SupprimerMonCompteToolStripMenuItem.Enabled = False
            UtilisateursToolStripMenuItem.Enabled = False
            AjouterUnAdminToolStripMenuItem.Enabled = False
            ModifierToolStripMenuItem.Enabled = False
            ModifierMonCompteToolStripMenuItem.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
        End If
    End Sub
    Private Sub AfficherToutU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        afficher()
        enablediter()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim rep As DialogResult
        Dim s As String
        rep = MessageBox.Show("Vouler-vous vraiment supprimer ?", "Oui/Non", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = vbYes Then
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            s = DataGridView1.Rows(i).Cells(0).Value
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from utilisateur where cin='" & s & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Supprimer Avec succes")
        End If
        afficher()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim i As Integer = DataGridView1.CurrentCell.RowIndex
        cinm = DataGridView1.Rows(i).Cells(0).Value
        modifierU = True
        Me.Hide()
        AjoutUser.Show()
        AjoutUser.lister()
        ' MsgBox("cinm est :" & cinm)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If TextBox1.Text <> Nothing Then

                DataGridView1.DataSource = Nothing

                cn.Open()
                cmd.Connection = cn
                cmd.CommandType = CommandType.Text
                Dim t As New DataTable
                Dim a As Integer
                cmd.CommandText = "SELECT * FROM utilisateur where cin like'%" & TextBox1.Text & "%'"
                dr = cmd.ExecuteReader()
                t.Load(dr)
                cmd.CommandText = "SELECT COUNT(cin) FROM utilisateur where cin like'%" & TextBox1.Text & "%'"
                a = cmd.ExecuteScalar()

                cn.Close()
                DataGridView1.DataSource = t
                Label3.Text = "Nombre des etudiant:  " & a

            Else
                afficher()
            End If
        Catch ex As Exception
            MsgBox("Erreur ")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Button3_Click(sender, e)
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

    Private Sub AjouterUnAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnAdminToolStripMenuItem.Click
        Me.Hide()
        AjoutUser.Show()
    End Sub

    Private Sub AfficherInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AfficherInfoToolStripMenuItem.Click
        montype = Nothing
        Me.Hide()
        Form2.Button5_Click(sender, e)
    End Sub

    Private Sub AjouterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem.Click
        Me.Hide()
        AjoutEtudiant.Show()
        modifier = False
    End Sub


    Private Sub AjouterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem1.Click
        Me.Hide()
        AjoutUser.Show()
        modifierU = False
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        AjoutEtudiant.Show()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        statistique.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        montype = Nothing
        Form2.Button5_Click(sender, e)
        Me.Hide()
    End Sub

    Private Sub ImprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerToolStripMenuItem.Click
        Me.Hide()
        AfficherToutE.Show()
    End Sub

    Private Sub ChercherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChercherToolStripMenuItem.Click
        Me.Hide()
        AfficherToutE.Show()
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem.Click
        Me.Hide()
        AfficherToutE.Show()
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

    Private Sub AccueilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccueilToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        AfficherToutE.Show()
    End Sub
   End Class