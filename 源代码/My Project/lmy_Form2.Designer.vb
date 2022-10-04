<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.选课设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.更改密码ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.学生ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.课程表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.选课ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.教师ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.成绩录入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.管理ToolStripMenuItem, Me.学生ToolStripMenuItem, Me.教师ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '管理ToolStripMenuItem
        '
        Me.管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.选课设置ToolStripMenuItem, Me.更改密码ToolStripMenuItem})
        Me.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem"
        Me.管理ToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.管理ToolStripMenuItem.Text = "管理"
        '
        '选课设置ToolStripMenuItem
        '
        Me.选课设置ToolStripMenuItem.Name = "选课设置ToolStripMenuItem"
        Me.选课设置ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.选课设置ToolStripMenuItem.Text = "选课设置"
        '
        '更改密码ToolStripMenuItem
        '
        Me.更改密码ToolStripMenuItem.Name = "更改密码ToolStripMenuItem"
        Me.更改密码ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.更改密码ToolStripMenuItem.Text = "更改密码"
        '
        '学生ToolStripMenuItem
        '
        Me.学生ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.课程表ToolStripMenuItem, Me.选课ToolStripMenuItem})
        Me.学生ToolStripMenuItem.Name = "学生ToolStripMenuItem"
        Me.学生ToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.学生ToolStripMenuItem.Text = "学生"
        '
        '课程表ToolStripMenuItem
        '
        Me.课程表ToolStripMenuItem.Name = "课程表ToolStripMenuItem"
        Me.课程表ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.课程表ToolStripMenuItem.Text = "查看成绩"
        '
        '选课ToolStripMenuItem
        '
        Me.选课ToolStripMenuItem.Name = "选课ToolStripMenuItem"
        Me.选课ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.选课ToolStripMenuItem.Text = "选课"
        '
        '教师ToolStripMenuItem
        '
        Me.教师ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.成绩录入ToolStripMenuItem})
        Me.教师ToolStripMenuItem.Name = "教师ToolStripMenuItem"
        Me.教师ToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.教师ToolStripMenuItem.Text = "教师"
        '
        '成绩录入ToolStripMenuItem
        '
        Me.成绩录入ToolStripMenuItem.Name = "成绩录入ToolStripMenuItem"
        Me.成绩录入ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.成绩录入ToolStripMenuItem.Text = "成绩录入"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(521, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "当前用户"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(628, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(719, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(298, 190)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(208, 25)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "新密码"
        Me.Label4.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(525, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "提交"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "欢迎你"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 学生ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 教师ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 课程表ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 成绩录入ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents 选课设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 选课ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents BindingSource3 As BindingSource
    Friend WithEvents BindingSource4 As BindingSource
    Friend WithEvents 更改密码ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
