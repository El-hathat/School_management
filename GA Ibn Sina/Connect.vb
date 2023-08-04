Imports System.Data.SqlClient
Module Connect
    Public cn As New SqlConnection("server=DESKTOP-DU1V4SQ;database=GA_IbnSina;integrated security=true")
    Public cmd As New SqlCommand

    Public dr As SqlDataReader
    ' Public modifier As Boolean = False
    ' Public img As Image = Image.FromFile("../../images/aucuneimage.PNG")


    'variable global
    Public cnem As String
    Public modifier As Boolean = False
    Public modifierU As Boolean = False
    Public cinm As String

    Public monemail As String
    Public monpwd As String
    Public montype As String
    Public moncin As String
    Public nomcplt As String
    Public cneSelectionne As String
End Module
