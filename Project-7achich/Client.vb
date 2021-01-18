Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Docking2010
Public Class Client
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\Project-7achich\Project-7achich\database1.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btngrp_CustomButtonClick(sender As Object, e As BaseButtonEventArgs) Handles btngrp.CustomButtonClick
        If e.Button.Properties.ImageIndex = 0 Then
            Add_Client.Show()
        ElseIf e.Button.Properties.ImageIndex = 1 Then

        End If
    End Sub
End Class
