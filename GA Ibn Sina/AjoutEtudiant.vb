Imports System.IO

Public Class AjoutEtudiant
    Public img As System.Drawing.Image
    Public rvNotes() As Byte
    Function Enreg_img() As Byte()
        Dim mst As New System.IO.MemoryStream
        PictureBox2.Image.Save(mst, System.Drawing.Imaging.ImageFormat.Png)
        Dim imgbyte() As Byte = mst.GetBuffer()
        mst.Close()
        Return imgbyte
    End Function
    Sub lister()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        If modifier Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT e.cne, e.cin, e.nom, e.prenom, e.adresse, e.datenaiss, e.ville, e.filiere, e.dateInscr, e.bac, e.img, e.email, e.tel, n.s1, n.s2, n.s3, n.s4, n.rvNote FROM   etudiant AS e INNER JOIN notes AS n ON e.cne = n.cne AND e.cne = '" & cnem & "'"
            dr = cmd.ExecuteReader()
            If dr.Read Then
                TextBox1.Text = dr.Item(0)
                TextBox2.Text = dr.Item(1)
                TextBox3.Text = dr.Item(2)
                TextBox4.Text = dr.Item(3)
                TextBox5.Text = dr.Item(4)
                TextBox6.Text = dr.Item(14)
                TextBox7.Text = dr.Item(13)
                TextBox8.Text = dr.Item(15)
                TextBox9.Text = dr.Item(12)
                TextBox10.Text = dr.Item(6)
                TextBox11.Text = dr.Item(16)
                TextBox12.Text = dr.Item(11)
                DateTimePicker1.Text = dr.Item(5)
                DateTimePicker2.Text = dr.Item(8)
                ComboBox1.Text = dr.Item(7)
                ComboBox2.Text = dr.Item(9)
                rvNotes = dr.Item(17)

                Dim imgbyte() As Byte = dr.Item(10)
                Dim pic As New System.IO.MemoryStream(imgbyte)
                PictureBox2.Image = Image.FromStream(pic)

            End If
            dr.Close()
            cn.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        OpenFileDialog1.Filter = "Image files (*.png,*.jpg,*.jpeg)|*.png;*.jpg;*.jpeg"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            img = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            PictureBox2.Image = img
        End If
    End Sub

    Sub ajouter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cn.Open()
        Try

        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select count(cne) from etudiant where cne='" & TextBox1.Text & "'"
        If cmd.ExecuteScalar() = 0 Then
            If modifier Then



                cmd.CommandText = "delete from notes where cne='" & cnem & "'"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "delete from etudiant where cne='" & cnem & "'"
                cmd.ExecuteNonQuery()

                    cmd.CommandText = ("insert into etudiant values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & DateTimePicker1.Value & "','" & TextBox10.Text & "','" & ComboBox1.Text & "','" & DateTimePicker2.Value & "','" & ComboBox2.Text & "',@toof,'" & TextBox12.Text & "','" & TextBox9.Text & "')")
                    cmd.Parameters.AddWithValue("toof", Enreg_img())
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = ("insert into notes values(" & TextBox7.Text & "," & TextBox6.Text & "," & TextBox8.Text & "," & TextBox11.Text & ",'" & TextBox1.Text & "',@pdfe)")
                    cmd.Parameters.AddWithValue("pdfe", rvNotes)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                    cn.Close()
                    MsgBox("modifier avec succes")
                    Me.Hide()
                    AfficherToutE.Show()
                    AfficherToutE.afficher()

                Else
                    '-----------------------------------------------
                    cmd.CommandText = ("insert into etudiant values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & DateTimePicker1.Value & "','" & TextBox10.Text & "','" & ComboBox1.Text & "','" & DateTimePicker2.Value & "','" & ComboBox2.Text & "',@toof,'" & TextBox12.Text & "','" & TextBox9.Text & "')")
                    cmd.Parameters.AddWithValue("toof", Enreg_img())
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = ("insert into notes values(" & TextBox7.Text & "," & TextBox6.Text & "," & TextBox8.Text & "," & TextBox11.Text & ",'" & TextBox1.Text & "',@pdfe)")
                    cmd.Parameters.AddWithValue("pdfe", rvNotes)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                    cn.Close()
                    MsgBox("Ajouter avec succes")
                    Me.Hide()
                    AfficherToutE.Show()
                    AfficherToutE.afficher()

                End If
            Else
                MsgBox("Ce etudiant deja exist")
                cn.Close()
            End If
        Catch a As Exception
            cn.Close()
            MsgBox("Il y a un champ vide !!")
        End Try



    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ajouter(sender, e)
    End Sub

    Private Sub AjoutEtudiant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lister()
    End Sub
    Private Sub AccueilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccueilToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim contenuFichier As String
        OpenFileDialog2.Filter = "files (*.pdf,*.docx,*.xls)|*.pdf;*.docx;*.xls"

        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            contenuFichier = File.ReadAllText(OpenFileDialog2.FileName)
            Dim s As Stream = OpenFileDialog2.OpenFile()
            Dim r As New BinaryReader(s)
            rvNotes = r.ReadBytes(CType(s.Length, Integer))

            Label19.Text = contenuFichier
        End If
    End Sub


    
    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If IsNumeric(TextBox7.Text) Then
           
            If TextBox7.Text > 20 Or TextBox7.Text < 0 Then
                TextBox7.Text = Nothing
                MsgBox("s'il vous plais entrer une note entre 0 et 20 ")
            End If
            
        Else

            If TextBox7.Text = Nothing Then
            Else
                TextBox7.Text = Nothing
                MsgBox("Erreur , la note est un nombre reel")
            End If
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If IsNumeric(TextBox6.Text) Then
            If TextBox6.Text > 20 Or TextBox6.Text < 0 Then
                TextBox6.Text = Nothing
                MsgBox("s'il vous plais entrer une note entre 0 et 20 ")
            End If

        Else
            If TextBox6.Text = Nothing Then
            Else
                TextBox6.Text = Nothing
                MsgBox("Erreur , la note est un nombre reel")
            End If
        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        If IsNumeric(TextBox8.Text) Then
        
            If TextBox8.Text > 20 Or TextBox8.Text < 0 Then
                MsgBox("s'il vous plais entrer une note entre 0 et 20 ")
                TextBox8.Text = Nothing
            End If
            
        Else

            If TextBox8.Text = Nothing Then
            Else
                TextBox8.Text = Nothing
                MsgBox("Erreur , la note est un nombre reel")
            End If
        End If
    End Sub


    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        If IsNumeric(TextBox11.Text) Then
            If TextBox11.Text > 20 Or TextBox11.Text < 0 Then
                TextBox11.Text = Nothing
                MsgBox("s'il vous plais entrer une note entre 0 et 20 ")
            End If
        Else


            If TextBox11.Text = Nothing Then
            Else
                TextBox11.Text = Nothing
                MsgBox("Erreur , la note est un nombre reel")
            End If
        End If

    End Sub
    '----------------------------------------------------------------------------------------------------


   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        AfficherToutE.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        AfficherToutE.Show()

    End Sub

    Private Sub AjouterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem.Click
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
        Form2.Button5_Click(sender, e)
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        montype = Nothing
        Form2.Button5_Click(sender, e)
        Me.Hide()
    End Sub

    Private Sub AjouterUnAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnAdminToolStripMenuItem.Click
        Me.Hide()
        AjoutUser.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        statistique.Show()
    End Sub

End Class