Public Class Stmain
    Dim s As String  ' s 查询学生 SQL 语句
    Dim sds As New DataSet ' 学生数据集对象

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s = "select student.sid 学号, name 学生姓名, birthday 出生日期, ssn 社会保障号, status 状态, graduationday 毕业日期 from student"
        Try
            disp(s, sds)
            BindingSource1.DataSource = sds
            BindingSource1.DataMember = sds.Tables(0).TableName
            DataGridView1.DataSource = BindingSource1
        Catch
            MsgBox(Err.Description, vbYes, "查询失败")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '修改学生信息
        whole_sid = DataGridView1.CurrentRow.Cells(0).Value
        Stmodify.snamebox.Text = DataGridView1.CurrentRow.Cells(1).Value
        Stmodify.bdatebox.Text = DataGridView1.CurrentRow.Cells(2).Value
        Stmodify.ssnbox.Text = DataGridView1.CurrentRow.Cells(3).Value
        Stmodify.statusbox.Text = DataGridView1.CurrentRow.Cells(4).Value
        Stmodify.gendatebox.Text = DataGridView1.CurrentRow.Cells(5).Value
        Stmodify.Show()
        DataGridView1.Refresh()
        Form1_Load(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' 增加学生信息
        Stadd.Show()
        DataGridView1.Refresh()
        Form1_Load(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click ' 删除学生信息
        Dim i As Integer
        Dim sqls As String

        i = MsgBox("确定删除学生：" & DataGridView1.CurrentRow.Cells(1).Value, 1, "删除学生记录")
        If i <> vbOK Then Exit Sub

        sqls = "delete from student where sid = '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        exsql(sqls)
        DataGridView1.Refresh()
        Form1_Load(sender, e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click ' 根据 sid 搜索学生
        BindingSource1.Filter = " 学号 LIKE '" & TextBox1.Text & "%'"
        DataGridView1.DataSource = BindingSource1 ' 学生相关查询
        DataGridView1.Refresh()
        Form1_Load(sender, e)
    End Sub
End Class