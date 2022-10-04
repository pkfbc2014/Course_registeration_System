'选课窗体代码
'  加载选课信息到datagridview
Public Class SelectCourse1


    Public sqls As String
    Sub dspgrd()              ' 用于初始化或刷新datagridview控件
        sqls = “SELECT  grade.pid, professor.name  任课教师, grade.sid," 'scinfo:选课表
        sqls += “ grade.cid 课程编号, grade.cname 课程名称,grade.credit 学分"
        sqls += " FROM  grade JOIN professor ON grade.pid = professor.pid  "
        'sqls += “  JOIN course ON coursesel.CID =  course.CID"
        sqls += " WHERE sid='" & nowUserid & "'"
        'sqls += " WHERE Score IS NULL AND coursesel.StID='" & Sid & "'"
        disp(sqls, ds1)           ' 执行sqls变量中的查询语句，返回结果集到ds1中
        DataGridView1.DataSource = ds1.Tables(0)
        DataGridView1.Columns("sid").Visible = False
        DataGridView1.Columns("pid").Visible = False
    End Sub

    '退课按钮操作
    Private Sub btDel_Click(sender As Object, e As EventArgs) Handles btDel.Click
        Dim dels As String, ok As Integer
        If DataGridView1.CurrentRow.Cells(2).Value <> "" Then
            ok = MsgBox("确定删除吗?", vbYesNo, "删除课程")
            If ok = vbNo Then Exit Sub
            dels = "DELETE  FROM  grade  WHERE  sid='" & nowUserid & "' AND cid='"
            dels = dels & Trim(DataGridView1.CurrentRow.Cells(3).Value) & "' AND pid='"
            dels = dels & Trim(DataGridView1.CurrentRow.Cells(0).Value) & "'"
            exsql(dels)
            dspgrd()
        End If
    End Sub
    Public ds1 As New DataSet
    Dim MySQL_Statement As String = "INSERT INTO `administrator` VALUES ('Admi', '5');"

    '选课按钮操作
    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If DataGridView1.Rows.Count = 7 Then
            MsgBox("您已经够六门课程！不可再选其他课程！")
        Else
            SelectCourse2.ShowDialog()
        End If
    End Sub

    '选课框体加载

    Private Sub frmSc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStid.Text = "学号:" + nowUserid
        lblName.Text = "姓名:" + nowUsername
        lblClass.Text = "班级名:" '+ Status
        dspgrd()
    End Sub

    '返回按钮
    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        Me.Close()
    End Sub

    Private Sub lblStid_Click(sender As Object, e As EventArgs) Handles lblStid.Click

    End Sub
End Class
