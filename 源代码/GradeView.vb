Public Class GradeView
    Public sid As String
    Public Sub GradeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqls As String
        Dim selectc As New DataSet
        sqls = "select distinct student.sid 学号, name 姓名, status 状态, graduationday 毕业日期, grade 当前成绩 from student join grade on student.sid = grade.sid where grade.cid = '" & CheckCourse.cid & "' and grade.pid = '" & nowUserid & "'"
        Try
            disp(sqls, selectc)
            BindingSource1.DataSource = selectc
            BindingSource1.DataMember = selectc.Tables(0).TableName
            DataGridView1.DataSource = BindingSource1
        Catch
            MsgBox(Err.Description, vbYes, "查询失败")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sid = DataGridView1.CurrentRow.Cells(0).Value
        SubmitGrade.Show()
        GradeView_Load(sender, e)
        DataGridView1.Refresh()
    End Sub
End Class