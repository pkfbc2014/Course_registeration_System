Public Class SelectCourse4
    Public ds4 As New DataSet
    Dim sqls As String ' SQL语句
    Sub dspgrd()              ' 用于初始化或刷新datagridview控件
        sqls = “SELECT  grade.pid, professor.name  任课教师, grade.sid," 'scinfo:选课表
        sqls += “ grade.cid 课程编号, grade.cname 课程名称,grade.credit 学分"
        sqls += " FROM  grade JOIN professor ON grade.pid = professor.pid  "
        sqls += " WHERE sid='" & nowUserid & "'"
        disp(sqls, ds4)  ' 执行sqls变量中的查询语句，返回结果集到ds1中
        DataGridView4.DataSource = ds4.Tables(0)
        DataGridView4.Columns("sid").Visible = False
        DataGridView4.Columns("pid").Visible = False
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStid4.Text = "学号:" + nowUserid
        lblName4.Text = "姓名:" + nowUsername
        lblClass4.Text = "班级名:" '+ Status
        dspgrd()
    End Sub




    '删除课表
    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        Dim dels As String, ok As Integer
        If DataGridView4.CurrentRow.Cells(2).Value <> "" Then
            ok = MsgBox("确定删除吗?", vbYesNo, "删除课程")
            If ok = vbNo Then Exit Sub
            dels = "DELETE  FROM  grade  WHERE  sid='" & nowUserid & "'" '& "' AND CID='"
            exsql(dels)
            dspgrd()
        End If
    End Sub

    '关闭窗体
    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        Me.Close()
    End Sub
End Class