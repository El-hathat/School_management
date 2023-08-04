Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "select indice,pwd from utilisateur where cin='" & TextBox2.Text & "'"
            dr = cmd.ExecuteReader
            Dim str1 As String = ""
            Dim str2 As String = ""
            While dr.Read
                str1 = dr.Item(0)
                str2 = dr.Item(1)
            End While
            cn.Close()
            If str1.Replace(" ", "") = TextBox1.Text Then
                modifierpwd.TextBox1.Text = str2
                modifierpwd.Show()
                Me.Hide()
            Else
                MsgBox("Votre Indice est incorrect !!")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class