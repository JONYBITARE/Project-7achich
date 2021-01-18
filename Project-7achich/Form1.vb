Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Docking2010

Public Class Form1

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\project-7achich\database1.mdf;Integrated Security=True;Connect Timeout=30")
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim sql As New SqlCommand
    Dim WithEvents gv As New GridView

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        sql.Connection = con
        sql.CommandText = "select * from Province"
        da.SelectCommand = sql
        da.Fill(ds, "Pro")
        GridControl1.DataSource = ds.Tables("Pro")
        gv = TryCast(GridControl1.MainView, GridView)
        gv.OptionsSelection.MultiSelect = True
    End Sub



    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        XtraMessageBox.Show("hello")
    End Sub

    Private Sub SvgImageBox3_Click(sender As Object, e As EventArgs) Handles SvgImageBox3.Click
        XtraMessageBox.Show("hello")
    End Sub




    Private Sub SvgImageBox2_Click(sender As Object, e As EventArgs) Handles SvgImageBox2.Click
        '
    End Sub

    Private Sub SvgImageBox1_Click_1(sender As Object, e As EventArgs) Handles SvgImageBox1.Click
        XtraMessageBox.Show("hello")
        XtraMessageBox.Show("h")
        XtraMessageBox.Show("hii")
        Employee.Show()
    End Sub

    Private Sub GroupControl1_CustomButtonClick(sender As Object, e As BaseButtonEventArgs)
        If e.Button.Properties.ImageIndex = 0 Then
            Employee.Show()
        ElseIf e.Button.Properties.ImageIndex = 1 Then
            XtraMessageBox.Show("you have click on image 2")
        End If
    End Sub

    Private Sub GridControl_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        XtraMessageBox.Show("hello")
    End Sub
    Private Sub Gridview_Click(sender As Object, e As EventArgs) Handles gv.CellValueChanged
        XtraMessageBox.Show("hello")
    End Sub
    Private Sub Gridview_Click_1(sender As Object, e As EventArgs) Handles gv.CellValueChanging
        XtraMessageBox.Show("hello2312")
    End Sub
End Class