Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class AfficherToutE
    Sub afficher()
        Dim a As Integer = 0
        Dim t As New DataTable
        DataGridView1.DataSource = Nothing
        cn.Close()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "SELECT e.cne, e.cin, e.nom, e.prenom, e.adresse, e.datenaiss, e.ville, e.filiere, e.dateInscr, e.bac, e.email, e.tel, n.s1, n.s2, n.s3, n.s4 FROM   etudiant AS e INNER JOIN notes AS n ON e.cne = n.cne"
        dr = cmd.ExecuteReader()
        t.Load(dr)
        cmd.CommandText = "SELECT COUNT(e.cne) FROM   etudiant AS e INNER JOIN  notes AS n ON e.cne = n.cne"
        dr = cmd.ExecuteReader()
        dr.Read()
        a = dr.Item(0)

        cn.Close()

        DataGridView1.DataSource = t
        Label3.Text = "Nombre des etudiant:  " & a
    End Sub
    
    
    Private Sub AccueilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccueilToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Public Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim rep As DialogResult
        Dim s As String
        rep = MessageBox.Show("Vouler-vous vraiment supprimer ?", "Oui/Non", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = vbYes Then
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            s = DataGridView1.Rows(i).Cells(0).Value
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from notes where cne='" & s & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from etudiant where cne='" & s & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Supprimer Avec succes")
        End If
        afficher()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim i As Integer = DataGridView1.CurrentCell.RowIndex
        cnem = DataGridView1.Rows(i).Cells(0).Value
        modifier = True
        Me.Hide()
        AjoutEtudiant.Show()
        AjoutEtudiant.lister()
        ' MsgBox("cnem est :" & cnem)
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
                cmd.CommandText = "SELECT e.cne, e.cin, e.nom, e.prenom, e.adresse, e.datenaiss, e.ville, e.filiere, e.dateInscr, e.bac, e.email, e.tel, n.s1, n.s2, n.s3, n.s4 FROM   etudiant AS e INNER JOIN notes AS n ON e.cne = n.cne and (e.cne like '%" & TextBox1.Text & "%' or e.cin like '%" & TextBox1.Text & "%')"
                dr = cmd.ExecuteReader()
                t.Load(dr)
                cmd.CommandText = "SELECT COUNT(e.cne) FROM etudiant AS e INNER JOIN  notes AS n ON e.cne = n.cne and (e.cne like '%" & TextBox1.Text & "%' or e.cin like '%" & TextBox1.Text & "%')"
                dr = cmd.ExecuteReader()
                dr.Read()
                a = dr.Item(0)

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

    Private Sub AjouterUnAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnAdminToolStripMenuItem.Click
        Me.Hide()
        AjoutUser.Show()
    End Sub

    Private Sub AfficherInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AfficherInfoToolStripMenuItem.Click
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

    Private Sub ModifierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem1.Click
        Me.Hide()
        AfficherToutU.Show()
        modifierU = True
    End Sub

    Private Sub RechercherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercherToolStripMenuItem.Click
        Me.Hide()
        AfficherToutU.Show()
    End Sub

    Private Sub AfficherToutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AfficherToutToolStripMenuItem1.Click
        Me.Hide()
        AfficherToutU.Show()
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

        Form2.Button5_Click(sender, e)
        Me.Hide()
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem.Click

        modifier = True
    End Sub

    Private Sub NotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotesToolStripMenuItem.Click
        Dim i As Integer = DataGridView1.CurrentCell.RowIndex
        cneSelectionne = DataGridView1.Rows(i).Cells(0).Value
        Me.Hide()
        Etudiant_Statistique.Show()
    End Sub

    Private Sub ImprimerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerToolStripMenuItem1.Click
        
        Dim docId As Integer = 1 'change this to the ID of the document you want to print
        Dim pdfData() As Byte
        Try
            cn.Close()
            cn.Open()
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim cne1 As String = DataGridView1.Rows(i).Cells(0).Value
            Dim cmd As New SqlCommand("SELECT rvNote FROM notes WHERE cne='" & cne1 & "'", cn)

            pdfData = DirectCast(cmd.ExecuteScalar(), Byte())


            'Récupérer les octets du fichier PDF à partir de la base de données
            Dim pdfBytes As Byte() = pdfData

            ' Enregistrer les octets dans un fichier temporaire
            Dim tempFilePath As String = "C:\temp_file.pdf"
            File.WriteAllBytes(tempFilePath, pdfBytes)

            ' Lancer Acrobat Reader et imprimer le fichier PDF
            Dim startInfo As New ProcessStartInfo()
            startInfo.FileName = "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Adobe Acrobat"
            startInfo.Arguments = String.Format("/t ""{0}""", tempFilePath)
            startInfo.WindowStyle = ProcessWindowStyle.Hidden
            Dim acrobatReaderProcess As Process = Process.Start(startInfo)
            acrobatReaderProcess.WaitForExit()

            ' Supprimer le fichier temporaire
            File.Delete(tempFilePath)
        Catch es As Exception
        End Try
    End Sub
    '_______________________________________________________________________________________________________________________________________________________________________________





    '____________________________________________________________________________________________________________________________________________________________________-
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
            Dim pagesetup As New PageSettings
            With pagesetup
                .Margins.Right = 50
                .Margins.Left = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
            End With
            PrintDocument1.DefaultPageSettings = pagesetup
        End If
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub AfficherToutE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-----------------------------------------------------------------
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
        ElseIf montype.Replace(" ", "") = "employe" Then
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
        '------------------------------------------------------------------
        Label1.Text = nomcplt
        afficher()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim i As Integer = DataGridView1.CurrentCell.RowIndex
        Dim s As String = DataGridView1.Rows(i).Cells(0).Value
        Dim nom1 As String = ""
        Dim prenom1 As String = ""
        Dim filiere1 As String = ""
        Dim s1 As Double = 0
        Dim s2 As Double = 0
        Dim s3 As Double = 0
        Dim s4 As Double = 0
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select nom,prenom,filiere,s1,s2,s3,s4 from etudiant et,notes nt where et.cne=nt.cne and et.cne='" & s & "'"
            dr = Nothing
            dr = cmd.ExecuteReader()
            While dr.Read

                nom1 = dr.Item(0)
                prenom1 = dr.Item(1)
                filiere1 = dr.Item(2)
                s1 = dr.Item(3)
                s2 = dr.Item(4)
                s3 = dr.Item(5)
                s4 = dr.Item(6)
            End While
            dr.Close()
            cn.Close()


        Catch ex As Exception

        End Try



        Dim pfont As Font = New Font("arial black", 18)
        Dim sfont As Font = New Font("Time New Roman", 25, FontStyle.Bold)
        Dim tfont As Font = New Font("baskertville Old Face", 18, FontStyle.Italic)
        Dim topmargin = PrintDocument1.DefaultPageSettings.Margins.Top
        Dim leftmargin = PrintDocument1.DefaultPageSettings.Margins.Left
        Dim line = "---------------------------Relever des Notes----------------------------" & vbCrLf & vbCrLf

        line &= "                      CNE: " & s.ToUpper() & vbCrLf & vbCrLf
        line &= "Nom Complet: " & prenom1.Replace(" ", "") & " " & nom1.Replace(" ", "") & vbCrLf & vbCrLf
        line &= "Filiere: " & filiere1.Replace(" ", "") & vbCrLf & vbCrLf
        line &= "Etablissement: BTS IbnSina Taounate" & vbCrLf & vbCrLf
        line &= "1er Annee                                      2eme Annee" & vbCrLf & vbCrLf
        line &= "Semestre 1 : " & s1 & "                       Semestre 3 : " & s3 & vbCrLf & vbCrLf
        line &= "Semestre 2 : " & s2 & "                       Semestre 4 : " & s4 & vbCrLf & vbCrLf
        line &= "                              Moyenne generale" & vbCrLf & vbCrLf
        Dim mg As Double = (s1 + s2 + s3 + s4) / 4
        line &= "                                         " & mg & vbCrLf & vbCrLf
        line &= "Fait a Tounate le : 17/04/2023" & vbCrLf & vbCrLf

        line &= " -----------------Cachet de l'etablissement------------------" & vbCrLf
        line &= "Le Directeur :            " & vbCrLf & vbCrLf

        e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds)
        e.Graphics.DrawString(My.Settings.name, sfont, Brushes.Blue, leftmargin + 25, topmargin + 25)
        e.Graphics.DrawString("Developped by : Mohamed El-hathat", tfont, Brushes.Gray, leftmargin + 25, topmargin + 25 + 30)
        e.Graphics.DrawLine(Pens.Black, leftmargin, 200, e.PageBounds.Width - leftmargin, 200)
        e.Graphics.DrawString(line, pfont, Brushes.Black, leftmargin + 25, topmargin + 190)


    End Sub
End Class