<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Padd
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.departmentbox = New System.Windows.Forms.TextBox()
        Me.statusbox = New System.Windows.Forms.TextBox()
        Me.ssnbox = New System.Windows.Forms.TextBox()
        Me.bdatebox = New System.Windows.Forms.TextBox()
        Me.pnamebox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "所属学院"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "状态"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "社会保险号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "出生日期"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "名字"
        '
        'departmentbox
        '
        Me.departmentbox.Location = New System.Drawing.Point(154, 325)
        Me.departmentbox.Name = "departmentbox"
        Me.departmentbox.Size = New System.Drawing.Size(161, 25)
        Me.departmentbox.TabIndex = 15
        '
        'statusbox
        '
        Me.statusbox.Location = New System.Drawing.Point(154, 254)
        Me.statusbox.Name = "statusbox"
        Me.statusbox.Size = New System.Drawing.Size(161, 25)
        Me.statusbox.TabIndex = 14
        '
        'ssnbox
        '
        Me.ssnbox.Location = New System.Drawing.Point(154, 188)
        Me.ssnbox.Name = "ssnbox"
        Me.ssnbox.Size = New System.Drawing.Size(161, 25)
        Me.ssnbox.TabIndex = 13
        '
        'bdatebox
        '
        Me.bdatebox.Location = New System.Drawing.Point(154, 119)
        Me.bdatebox.Name = "bdatebox"
        Me.bdatebox.Size = New System.Drawing.Size(161, 25)
        Me.bdatebox.TabIndex = 12
        '
        'pnamebox
        '
        Me.pnamebox.Location = New System.Drawing.Point(154, 48)
        Me.pnamebox.Name = "pnamebox"
        Me.pnamebox.Size = New System.Drawing.Size(161, 25)
        Me.pnamebox.TabIndex = 11
        '
        'Padd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 453)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.departmentbox)
        Me.Controls.Add(Me.statusbox)
        Me.Controls.Add(Me.ssnbox)
        Me.Controls.Add(Me.bdatebox)
        Me.Controls.Add(Me.pnamebox)
        Me.Name = "Padd"
        Me.Text = "添加教师信息"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents departmentbox As TextBox
    Friend WithEvents statusbox As TextBox
    Friend WithEvents ssnbox As TextBox
    Friend WithEvents bdatebox As TextBox
    Friend WithEvents pnamebox As TextBox
End Class
