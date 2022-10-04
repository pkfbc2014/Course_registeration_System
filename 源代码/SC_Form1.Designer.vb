<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectCourse1
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
        Me.lblStid = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btDel = New System.Windows.Forms.Button()
        Me.btBack = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStid
        '
        Me.lblStid.AutoSize = True
        Me.lblStid.Location = New System.Drawing.Point(72, 53)
        Me.lblStid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStid.Name = "lblStid"
        Me.lblStid.Size = New System.Drawing.Size(52, 15)
        Me.lblStid.TabIndex = 1
        Me.lblStid.Text = "学号："
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(325, 53)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 15)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "姓名："
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(555, 53)
        Me.lblClass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(67, 15)
        Me.lblClass.TabIndex = 3
        Me.lblClass.Text = "班级名："
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 80)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(774, 274)
        Me.DataGridView1.TabIndex = 4
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(89, 384)
        Me.btAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(100, 28)
        Me.btAdd.TabIndex = 5
        Me.btAdd.Text = "选择其他课程"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btDel
        '
        Me.btDel.Location = New System.Drawing.Point(342, 384)
        Me.btDel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(100, 28)
        Me.btDel.TabIndex = 6
        Me.btDel.Text = "退课"
        Me.btDel.UseVisualStyleBackColor = True
        '
        'btBack
        '
        Me.btBack.Location = New System.Drawing.Point(558, 384)
        Me.btBack.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(100, 28)
        Me.btBack.TabIndex = 7
        Me.btBack.Text = "返回"
        Me.btBack.UseVisualStyleBackColor = True
        '
        'SelectCourse1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btBack)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblStid)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "SelectCourse1"
        Me.Text = "选课页面"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStid As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblClass As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btAdd As Button
    Friend WithEvents btDel As Button
    Friend WithEvents btBack As Button
End Class
