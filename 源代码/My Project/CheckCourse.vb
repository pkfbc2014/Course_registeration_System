Public Class CheckCourse
    Dim course As String  ' course 查询课程 SQL 语句
    Dim courseds As New DataSet ' 课程数据集对象
    Public cid As String

    Private Sub CheckCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teachername.Text = nowUsername
        course = "select course.cid 课程号, name 课程名, credit 学分, fee 学费, semester 开课学期, timeslot 开课时间 from course where pid = '" & nowUserid & "'"
        Try
            disp(course, courseds)
            BindingSource1.DataSource = courseds
            BindingSource1.DataMember = courseds.Tables(0).TableName
            DataGridView1.DataSource = BindingSource1
        Catch
            MsgBox(Err.Description, vbYes, "查询失败")
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cid = DataGridView1.CurrentRow.Cells(0).Value
        GradeView.Show()
        Me.Hide()
        CheckCourse_Load(sender, e)
        DataGridView1.Refresh()
    End Sub
End Class