Public Class Pmain
    Dim p As String  ' p 查询教师 SQL 语句
    Dim pds As New DataSet ' 教师数据集对象
    Public Sub Tmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p = "select distinct professor.pid 教号, name 教师姓名, birthday 出生日期, ssn 社会保障号, status 状态, department 学院 from professor"
        Try
            disp(p, pds)
            BindingSource1.DataSource = pds
            BindingSource1.DataMember = pds.Tables(0).TableName
            DataGridView1.DataSource = BindingSource1
        Catch
            MsgBox(Err.Description, vbYes, "查询失败")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' 增加教师
        Padd.Show()
        DataGridView1.Refresh()
        Tmain_Load(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click ' 修改教师
        whole_pid = DataGridView1.CurrentRow.Cells(0).Value
        Pmodify.pnamebox.Text = DataGridView1.CurrentRow.Cells(1).Value
        Pmodify.bdatebox.Text = DataGridView1.CurrentRow.Cells(2).Value
        Pmodify.ssnbox.Text = DataGridView1.CurrentRow.Cells(3).Value
        Pmodify.statusbox.Text = DataGridView1.CurrentRow.Cells(4).Value
        Pmodify.departmentbox.Text = DataGridView1.CurrentRow.Cells(5).Value
        Pmodify.Show()
        DataGridView1.Refresh()
        Tmain_Load(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click ' 删除教师
        Dim i As Integer
        Dim sqls As String

        i = MsgBox("确定删除教师：" & DataGridView1.CurrentRow.Cells(1).Value, 1, "删除教师记录")
        If i <> vbOK Then Exit Sub

        sqls = "delete from professor where pid = '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        exsql(sqls)
        DataGridView1.Refresh()
        Tmain_Load(sender, e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click ' 根据 pid 搜索教师
        BindingSource1.Filter = " 教号 LIKE '" & TextBox1.Text & "%'"
        DataGridView1.DataSource = BindingSource1 ' 教师相关查询
        DataGridView1.Refresh()
        Tmain_Load(sender, e)
    End Sub
End Class