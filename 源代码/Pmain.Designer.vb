<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pmain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "输入教师id："
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(531, 28)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 30)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "搜索"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(287, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 25)
        Me.TextBox1.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(784, 293)
        Me.DataGridView1.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(531, 398)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "删除"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(350, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "修改"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "增加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Pmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Pmain"
        Me.Text = "教师信息"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BindingSource1 As BindingSource
End Class
