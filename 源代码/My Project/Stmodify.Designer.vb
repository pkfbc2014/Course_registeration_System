<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stmodify
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gendatebox = New System.Windows.Forms.TextBox()
        Me.statusbox = New System.Windows.Forms.TextBox()
        Me.ssnbox = New System.Windows.Forms.TextBox()
        Me.bdatebox = New System.Windows.Forms.TextBox()
        Me.snamebox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "毕业日期"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "状态"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "社会保险号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "出生日期"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "名字"
        '
        'gendatebox
        '
        Me.gendatebox.Location = New System.Drawing.Point(153, 334)
        Me.gendatebox.Name = "gendatebox"
        Me.gendatebox.Size = New System.Drawing.Size(161, 25)
        Me.gendatebox.TabIndex = 14
        '
        'statusbox
        '
        Me.statusbox.Location = New System.Drawing.Point(153, 263)
        Me.statusbox.Name = "statusbox"
        Me.statusbox.Size = New System.Drawing.Size(161, 25)
        Me.statusbox.TabIndex = 13
        '
        'ssnbox
        '
        Me.ssnbox.Location = New System.Drawing.Point(153, 197)
        Me.ssnbox.Name = "ssnbox"
        Me.ssnbox.Size = New System.Drawing.Size(161, 25)
        Me.ssnbox.TabIndex = 12
        '
        'bdatebox
        '
        Me.bdatebox.Location = New System.Drawing.Point(153, 128)
        Me.bdatebox.Name = "bdatebox"
        Me.bdatebox.Size = New System.Drawing.Size(161, 25)
        Me.bdatebox.TabIndex = 11
        '
        'snamebox
        '
        Me.snamebox.Location = New System.Drawing.Point(153, 57)
        Me.snamebox.Name = "snamebox"
        Me.snamebox.Size = New System.Drawing.Size(161, 25)
        Me.snamebox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Stmodify
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
        Me.Controls.Add(Me.gendatebox)
        Me.Controls.Add(Me.statusbox)
        Me.Controls.Add(Me.ssnbox)
        Me.Controls.Add(Me.bdatebox)
        Me.Controls.Add(Me.snamebox)
        Me.Name = "Stmodify"
        Me.Text = "修改学生信息"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gendatebox As TextBox
    Friend WithEvents statusbox As TextBox
    Friend WithEvents ssnbox As TextBox
    Friend WithEvents bdatebox As TextBox
    Friend WithEvents snamebox As TextBox
    Friend WithEvents Button1 As Button
End Class
