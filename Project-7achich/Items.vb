Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Docking2010
Public Class Items

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\project-7achich\database1.mdf;Integrated Security=True;Connect Timeout=30")
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim sql As New SqlCommand
    Dim WithEvents gv As New GridView

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        sql.Connection = con
        sql.CommandText = "select * from Province"
        da.SelectCommand = sql
        da.Fill(ds, "Pro")
        GridControl1.DataSource = ds.Tables("Pro")
        gv = TryCast(GridControl1.MainView, GridView)
        gv.OptionsSelection.MultiSelect = True
        gv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect
        gv.Columns(0).OptionsColumn.ReadOnly = True
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        XtraMessageBox.Show("hello")
    End Sub

    Private Sub GroupControl1_CustomButtonClick(sender As Object, e As BaseButtonEventArgs)
        If e.Button.Properties.ImageIndex = 0 Then
            Employee.Show()
        ElseIf e.Button.Properties.ImageIndex = 1 Then
            XtraMessageBox.Show("you have click on image 2")
        End If
    End Sub

    Private Sub Gridview_Click(sender As Object, e As EventArgs) Handles gv.CellValueChanged
        sql.CommandText = "update Province set Prov_name = '" & gv.GetDataRow(gv.GetSelectedRows(0))("Prov_name") & "' where Prov_ID='" & gv.GetDataRow(gv.GetSelectedRows(0))("Prov_ID") & "'"
        sql.ExecuteNonQuery()
        Dim pkc As DataColumn = ds.Tables("Pro").Columns("Prov_ID")
        ds.Tables("Pro").PrimaryKey = New DataColumn() {pkc}
        ds.Tables("Pro").Rows.Find(gv.GetDataRow(gv.GetSelectedRows(0))("Prov_ID"))(1) = gv.GetDataRow(gv.GetSelectedRows(0))("Prov_name")
    End Sub
    Private Sub Gridview_Click_1(sender As Object, e As EventArgs) Handles gv.CellValueChanging
        'XtraMessageBox.Show("hello2312")
    End Sub
    Private Sub SvgImageBox1_Click(sender As Object, e As EventArgs) Handles SvgImageBox1.Click
        Dim selected As Int32() = gv.GetSelectedRows
        Dim rowarr As New ArrayList
        For I = 0 To gv.GetSelectedRows.Count - 1
            rowarr.Add(gv.GetDataRow(selected(I)))
        Next
        For I = 0 To gv.GetSelectedRows.Count - 1
            Dim r As DataRow = rowarr(I)
            MsgBox(r("Prov_ID"))
        Next
    End Sub
    Private Sub GridControl1_KeyPrx(sender As Object, e As KeyEventArgs) Handles GridControl1.ProcessGridKey
        If (e.KeyCode = Keys.KeyCode.Delete) Then
            sql.CommandText = "delete from Province where Prov_ID ='" & gv.GetDataRow(gv.GetSelectedRows(0))("Prov_ID") & "'"
            sql.ExecuteNonQuery()
            ds.Tables("Pro").Rows.Remove(gv.GetDataRow(gv.GetSelectedRows(0)))
            sql.CommandText = "select * from Caza"
            da.SelectCommand = sql
            da.Fill(ds, "CAZA")
        End If
    End Sub
    Private Sub GridControl1_KeyPrx1(sender As Object, e As DevExpress.Utils.DXMouseEventArgs) Handles GridControl1.Click

    End Sub
End Class