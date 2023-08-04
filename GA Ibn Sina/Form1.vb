Imports System.Data.SqlClient
Public Class Form1
    Sub connecter()
       
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "E-mail" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = Nothing Then
            TextBox1.Text = "E-mail"
            TextBox1.ForeColor = Color.Gray
        End If

    End Sub

    Private Sub TextBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "Mot de passe" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub TextBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = Nothing Then
            TextBox2.Text = "Mot de passe"
            TextBox2.ForeColor = Color.Gray
            TextBox2.PasswordChar = ""
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        moncin = Nothing
        montype = Nothing
        monpwd = Nothing
        monemail = Nothing
        Try
            If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
                MsgBox("Il y a un champ vide !!")
            Else
                cn.Open()

                cmd = New SqlCommand("select cin,email,pwd,type,nom,prenom from utilisateur where email='" & TextBox1.Text & "' and pwd='" & TextBox2.Text & "'", cn)
                Dim nb As Integer
                dr = cmd.ExecuteReader
                Dim n As String = ""
                Dim p As String = ""
                While dr.Read
                    moncin = dr.Item(0)
                    monemail = dr.Item(1)
                    monpwd = dr.Item(2)
                    montype = dr.Item(3)
                    n = dr.Item(4)
                    p = dr.Item(5)
                End While
                n = n.Replace(" ", "")
                p = p.Replace(" ", "")
                nomcplt = n & " " & p
                dr.Close()

                cmd = New SqlCommand("select count(cin) from utilisateur where email='" & TextBox1.Text & "' and pwd='" & TextBox2.Text & "'", cn)
                nb = cmd.ExecuteScalar
                If nb = 1 Then
                    Me.Hide()
                    '  MsgBox(montype)
                    Form2.Show()
                    Form2.Form2_Load(sender, e)
                Else
                    MsgBox("E-mail ou mot de passe est incorrect !!")
                End If
                cn.Close()
            End If

        Catch ex As Exception
            MsgBox("Il y a un champ vide !!")
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class
