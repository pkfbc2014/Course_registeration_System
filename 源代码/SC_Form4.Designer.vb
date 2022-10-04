<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectCourse4
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
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.lblStid4 = New System.Windows.Forms.Label()
        Me.lblName4 = New System.Windows.Forms.Label()
        Me.lblClass4 = New System.Windows.Forms.Label()
        Me.Button_delete = New System.Windows.Forms.Button()
        Me.Button_Back = New System.Windows.Forms.Button()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(12, 69)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 62
        Me.DataGridView4.RowTemplate.Height = 30
        Me.DataGridView4.Size = New System.Drawing.Size(776, 280)
        Me.DataGridView4.TabIndex = 0
        '
        'lblStid4
        '
        Me.lblStid4.AutoSize = True
        Me.lblStid4.Location = New System.Drawing.Point(79, 37)
        Me.lblStid4.Name = "lblStid4"
        Me.lblStid4.Size = New System.Drawing.Size(52, 15)
        Me.lblStid4.TabIndex = 1
        Me.lblStid4.Text = "学号："
        '
        'lblName4
        '
        Me.lblName4.AutoSize = True
        Me.lblName4.Location = New System.Drawing.Point(264, 37)
        Me.lblName4.Name = "lblName4"
        Me.lblName4.Size = New System.Drawing.Size(52, 15)
        Me.lblName4.TabIndex = 2
        Me.lblName4.Text = "姓名："
        '
        'lblClass4
        '
        Me.lblClass4.AutoSize = True
        Me.lblClass4.Location = New System.Drawing.Point(452, 37)
        Me.lblClass4.Name = "lblClass4"
        Me.lblClass4.Size = New System.Drawing.Size(67, 15)
        Me.lblClass4.TabIndex = 3
        Me.lblClass4.Text = "班级名："
        '
        'Button_delete
        '
        Me.Button_delete.Location = New System.Drawing.Point(160, 374)
        Me.Button_delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_delete.Name = "Button_delete"
        Me.Button_delete.Size = New System.Drawing.Size(156, 32)
        Me.Button_delete.TabIndex = 4
        Me.Button_delete.Text = "删除本课表"
        Me.Button_delete.UseVisualStyleBackColor = True
        '
        'Button_Back
        '
        Me.Button_Back.Location = New System.Drawing.Point(427, 374)
        Me.Button_Back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(163, 32)
        Me.Button_Back.TabIndex = 5
        Me.Button_Back.Text = "退出"
        Me.Button_Back.UseVisualStyleBackColor = True
        '
        'SelectCourse4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Back)
        Me.Controls.Add(Me.Button_delete)
        Me.Controls.Add(Me.lblClass4)
        Me.Controls.Add(Me.lblName4)
        Me.Controls.Add(Me.lblStid4)
        Me.Controls.Add(Me.DataGridView4)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SelectCourse4"
        Me.Text = "删除课表"
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents lblStid4 As Label
    Friend WithEvents lblName4 As Label
    Friend WithEvents lblClass4 As Label
    Friend WithEvents Button_delete As Button
    Friend WithEvents Button_Back As Button
End Class
