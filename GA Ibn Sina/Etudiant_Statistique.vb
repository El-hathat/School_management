Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient

Public Class Etudiant_Statistique

    Private Sub Etudiant_Statistique_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Sub loadData()
        Try
            Chart1.Titles.Add("Etudiant Statistique")
            cn.Open()

            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from stat2 where semesstre like 'S%'"
            cmd.ExecuteNonQuery()
            dr.Close()
            cmd.CommandText = "select s1,s2,s3,s4 from notes where cne='" & cneSelectionne & "'"
            dr = cmd.ExecuteReader()
            Dim s1, s2, s3, s4 As Double
            While dr.Read
                s1 = dr.Item(0)
                s2 = dr.Item(1)
                s3 = dr.Item(2)
                s4 = dr.Item(3)

            End While
            dr.Close()
            cmd.CommandText = "insert into stat2 values(" & s1 & ",'S1')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "insert into stat2 values(" & s2 & ",'S2')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "insert into stat2 values(" & s3 & ",'S3')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "insert into stat2 values(" & s4 & ",'S4')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT note,semesstre FROM stat2"
            dr = cmd.ExecuteReader
            Dim t As New DataTable
            t.Load(dr)
            Chart1.DataSource = t

            Chart1.Series("Series1").XValueMember = "semesstre"
            Chart1.Series("Series1").YValueMembers = "note"
            cn.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Hide()
        Form2.Show()
    End Sub

End Class