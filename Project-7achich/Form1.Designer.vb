<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SvgImageBox1 = New DevExpress.XtraEditors.SvgImageBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SvgImageBox2 = New DevExpress.XtraEditors.SvgImageBox()
        CType(Me.SvgImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SvgImageBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(469, 428)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(94, 29)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "add"
        '
        'SvgImageBox1
        '
        Me.SvgImageBox1.ItemAppearance.Normal.FillColor = System.Drawing.Color.Red
        Me.SvgImageBox1.Location = New System.Drawing.Point(41, 406)
        Me.SvgImageBox1.Name = "SvgImageBox1"
        Me.SvgImageBox1.Size = New System.Drawing.Size(79, 76)
        Me.SvgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch
        Me.SvgImageBox1.SvgImage = CType(resources.GetObject("SvgImageBox1.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SvgImageBox1.TabIndex = 1
        Me.SvgImageBox1.Text = "SvgImageBox1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.FontSizeDelta = 2
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(69, 381)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 19)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Add"
        '
        'SvgImageBox2
        '
        Me.SvgImageBox2.ItemAppearance.Normal.FillColor = System.Drawing.Color.Red
        Me.SvgImageBox2.Location = New System.Drawing.Point(289, 406)
        Me.SvgImageBox2.Name = "SvgImageBox2"
        Me.SvgImageBox2.Size = New System.Drawing.Size(77, 76)
        Me.SvgImageBox2.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch
        Me.SvgImageBox2.SvgImage = CType(resources.GetObject("SvgImageBox2.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SvgImageBox2.TabIndex = 3
        Me.SvgImageBox2.Text = "SvgImageBox2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 550)
        Me.Controls.Add(Me.SvgImageBox2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SvgImageBox1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SvgImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SvgImageBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SvgImageBox1 As DevExpress.XtraEditors.SvgImageBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SvgImageBox2 As DevExpress.XtraEditors.SvgImageBox
End Class
