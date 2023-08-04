<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AfficherToutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierMonCompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangerMotDePasseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerMonCompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtudiantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChercherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherToutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MassarServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfficherToutToolStripMenuItem, Me.EtudiantToolStripMenuItem, Me.UtilisateursToolStripMenuItem, Me.MassarServiceToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1170, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AfficherToutToolStripMenuItem
        '
        Me.AfficherToutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierMonCompteToolStripMenuItem, Me.ChangerMotDePasseToolStripMenuItem, Me.SupprimerMonCompteToolStripMenuItem, Me.AjouterUnAdminToolStripMenuItem, Me.AfficherInfoToolStripMenuItem})
        Me.AfficherToutToolStripMenuItem.Name = "AfficherToutToolStripMenuItem"
        Me.AfficherToutToolStripMenuItem.Size = New System.Drawing.Size(127, 29)
        Me.AfficherToutToolStripMenuItem.Text = "Mon compte"
        '
        'ModifierMonCompteToolStripMenuItem
        '
        Me.ModifierMonCompteToolStripMenuItem.Name = "ModifierMonCompteToolStripMenuItem"
        Me.ModifierMonCompteToolStripMenuItem.Size = New System.Drawing.Size(278, 30)
        Me.ModifierMonCompteToolStripMenuItem.Text = "Modifier Mon Compte"
        '
        'ChangerMotDePasseToolStripMenuItem
        '
        Me.ChangerMotDePasseToolStripMenuItem.Name = "ChangerMotDePasseToolStripMenuItem"
        Me.ChangerMotDePasseToolStripMenuItem.Size = New System.Drawing.Size(278, 30)
        Me.ChangerMotDePasseToolStripMenuItem.Text = "changer Mot de passe"
        '
        'SupprimerMonCompteToolStripMenuItem
        '
        Me.SupprimerMonCompteToolStripMenuItem.Name = "SupprimerMonCompteToolStripMenuItem"
        Me.SupprimerMonCompteToolStripMenuItem.Size = New System.Drawing.Size(278, 30)
        Me.SupprimerMonCompteToolStripMenuItem.Text = "Supprimer Mon Compte"
        '
        'AjouterUnAdminToolStripMenuItem
        '
        Me.AjouterUnAdminToolStripMenuItem.Name = "AjouterUnAdminToolStripMenuItem"
        Me.AjouterUnAdminToolStripMenuItem.Size = New System.Drawing.Size(278, 30)
        Me.AjouterUnAdminToolStripMenuItem.Text = "Ajouter un admin"
        '
        'AfficherInfoToolStripMenuItem
        '
        Me.AfficherInfoToolStripMenuItem.Name = "AfficherInfoToolStripMenuItem"
        Me.AfficherInfoToolStripMenuItem.Size = New System.Drawing.Size(278, 30)
        Me.AfficherInfoToolStripMenuItem.Text = "Deconnexion"
        '
        'EtudiantToolStripMenuItem
        '
        Me.EtudiantToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.ChercherToolStripMenuItem, Me.SupprimerToolStripMenuItem, Me.ImprimerToolStripMenuItem})
        Me.EtudiantToolStripMenuItem.Name = "EtudiantToolStripMenuItem"
        Me.EtudiantToolStripMenuItem.Size = New System.Drawing.Size(97, 29)
        Me.EtudiantToolStripMenuItem.Text = "Etudiants"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(183, 30)
        Me.AjouterToolStripMenuItem.Text = "Ajouter"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(183, 30)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'ChercherToolStripMenuItem
        '
        Me.ChercherToolStripMenuItem.Name = "ChercherToolStripMenuItem"
        Me.ChercherToolStripMenuItem.Size = New System.Drawing.Size(183, 30)
        Me.ChercherToolStripMenuItem.Text = "Rechercher"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(183, 30)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(183, 30)
        Me.ImprimerToolStripMenuItem.Text = "Afficher tout"
        '
        'UtilisateursToolStripMenuItem
        '
        Me.UtilisateursToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem1, Me.ModifierToolStripMenuItem1, Me.SupprimerToolStripMenuItem1, Me.RechercherToolStripMenuItem, Me.AfficherToutToolStripMenuItem1})
        Me.UtilisateursToolStripMenuItem.Name = "UtilisateursToolStripMenuItem"
        Me.UtilisateursToolStripMenuItem.Size = New System.Drawing.Size(110, 29)
        Me.UtilisateursToolStripMenuItem.Text = "Utilisateurs"
        '
        'AjouterToolStripMenuItem1
        '
        Me.AjouterToolStripMenuItem1.Name = "AjouterToolStripMenuItem1"
        Me.AjouterToolStripMenuItem1.Size = New System.Drawing.Size(183, 30)
        Me.AjouterToolStripMenuItem1.Text = "Ajouter"
        '
        'ModifierToolStripMenuItem1
        '
        Me.ModifierToolStripMenuItem1.Name = "ModifierToolStripMenuItem1"
        Me.ModifierToolStripMenuItem1.Size = New System.Drawing.Size(183, 30)
        Me.ModifierToolStripMenuItem1.Text = "Modifier"
        '
        'SupprimerToolStripMenuItem1
        '
        Me.SupprimerToolStripMenuItem1.Name = "SupprimerToolStripMenuItem1"
        Me.SupprimerToolStripMenuItem1.Size = New System.Drawing.Size(183, 30)
        Me.SupprimerToolStripMenuItem1.Text = "Supprimer"
        '
        'RechercherToolStripMenuItem
        '
        Me.RechercherToolStripMenuItem.Name = "RechercherToolStripMenuItem"
        Me.RechercherToolStripMenuItem.Size = New System.Drawing.Size(183, 30)
        Me.RechercherToolStripMenuItem.Text = "Rechercher"
        '
        'AfficherToutToolStripMenuItem1
        '
        Me.AfficherToutToolStripMenuItem1.Name = "AfficherToutToolStripMenuItem1"
        Me.AfficherToutToolStripMenuItem1.Size = New System.Drawing.Size(183, 30)
        Me.AfficherToutToolStripMenuItem1.Text = "Afficher tout"
        '
        'MassarServiceToolStripMenuItem
        '
        Me.MassarServiceToolStripMenuItem.Name = "MassarServiceToolStripMenuItem"
        Me.MassarServiceToolStripMenuItem.Size = New System.Drawing.Size(140, 29)
        Me.MassarServiceToolStripMenuItem.Text = "Massar Service"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 628)
        Me.Panel1.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(9, 558)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(217, 33)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Deconnexion"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(9, 411)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(217, 33)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Statistique"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(8, 352)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(217, 33)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Rechercher"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(217, 33)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Afficher tout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ajouter Etudiant"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(4, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "________________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(29, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mohamed el-hathat"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(235, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(935, 627)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1170, 651)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1192, 707)
        Me.MinimumSize = New System.Drawing.Size(1192, 707)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UtilisateursToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EtudiantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChercherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AfficherToutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierMonCompteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangerMotDePasseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerMonCompteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AfficherInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AjouterUnAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents AfficherToutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MassarServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
