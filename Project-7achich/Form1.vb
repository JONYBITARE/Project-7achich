Imports DevExpress.XtraEditors

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraMessageBox.Show("hello")
    End Sub

    Private Sub SvgImageBox1_Click(sender As Object, e As EventArgs) Handles SvgImageBox1.Click
        XtraMessageBox.Show("hello")
        XtraMessageBox.Show("h")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        XtraMessageBox.Show("hello")
    End Sub
End Class