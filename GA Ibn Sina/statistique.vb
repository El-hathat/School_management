Imports System.Windows.Forms.DataVisualization.Charting

Public Class statistique


    Private Sub statistique_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Sub loadData()
        Try
            Chart1.Titles.Add("Statistique des étudiants")
            cn.Open()
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from stat where type_AE='admis' or type_AE='echouer'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "insert into stat values((select * from dbo.f1()),'admis')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "insert into stat values((select * from dbo.f2()),'echouer')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT nbr,type_AE FROM stat"
            dr = cmd.ExecuteReader
            Dim t As New DataTable
            t.Load(dr)
            Chart1.DataSource = t
            Dim s2 As New Series()
            Chart1.Series("Series1").XValueMember = "type_AE"
            Chart1.Series("Series1").YValueMembers = "nbr"
            cn.Close()
        Catch ex As Exception

        End Try
        '
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub
End Class