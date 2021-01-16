<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim SvgImageItem1 As DevExpress.XtraEditors.SvgImageItem = New DevExpress.XtraEditors.SvgImageItem("1/0")
        Me.SvgImageBox2 = New DevExpress.XtraEditors.SvgImageBox()
        Me.SvgImageBox1 = New DevExpress.XtraEditors.SvgImageBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SvgImageBox3 = New DevExpress.XtraEditors.SvgImageBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.SvgImageBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SvgImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SvgImageBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SvgImageBox2
        '
        Me.SvgImageBox2.ItemAppearance.Normal.FillColor = System.Drawing.Color.Red
        Me.SvgImageBox2.Location = New System.Drawing.Point(145, 30)
        Me.SvgImageBox2.Name = "SvgImageBox2"
        Me.SvgImageBox2.Size = New System.Drawing.Size(77, 76)
        Me.SvgImageBox2.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch
        Me.SvgImageBox2.SvgImage = CType(resources.GetObject("SvgImageBox2.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SvgImageBox2.TabIndex = 3
        Me.SvgImageBox2.Text = "SvgImageBox2"
        '
        'SvgImageBox1
        '
        SvgImageItem1.Appearance.Normal.FillColor = System.Drawing.Color.Black
        Me.SvgImageBox1.CustomizedItems.Add(SvgImageItem1)
        Me.SvgImageBox1.ItemAppearance.Normal.FillColor = System.Drawing.Color.Yellow
        Me.SvgImageBox1.Location = New System.Drawing.Point(12, 30)
        Me.SvgImageBox1.Name = "SvgImageBox1"
        Me.SvgImageBox1.Size = New System.Drawing.Size(81, 76)
        Me.SvgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch
        Me.SvgImageBox1.SvgImage = CType(resources.GetObject("SvgImageBox1.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SvgImageBox1.TabIndex = 4
        Me.SvgImageBox1.Text = "SvgImageBox1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.FontSizeDelta = 3
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(108, 22)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "LabelControl1"
        '
        'SvgImageBox3
        '
        Me.SvgImageBox3.ItemAppearance.Normal.FillColor = System.Drawing.Color.Red
        Me.SvgImageBox3.Location = New System.Drawing.Point(266, 30)
        Me.SvgImageBox3.Name = "SvgImageBox3"
        Me.SvgImageBox3.Size = New System.Drawing.Size(80, 76)
        Me.SvgImageBox3.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch
        Me.SvgImageBox3.SvgImage = CType(resources.GetObject("SvgImageBox3.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SvgImageBox3.TabIndex = 7
        Me.SvgImageBox3.Text = "SvgImageBox3"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(266, 159)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(545, 379)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 550)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SvgImageBox3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SvgImageBox1)
        Me.Controls.Add(Me.SvgImageBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SvgImageBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SvgImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SvgImageBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SvgImageBox2 As DevExpress.XtraEditors.SvgImageBox
    Friend WithEvents SvgImageBox1 As DevExpress.XtraEditors.SvgImageBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SvgImageBox3 As DevExpress.XtraEditors.SvgImageBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
