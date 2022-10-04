Public Class GradePrint
    Dim s As String  ' s 查询学生 SQL 语句
    Dim sds As New DataSet ' 学生数据集对象
    Private Sub GradePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s = "select grade.sid 学号, cname 课程名, grade 成绩 from grade where sid = '" & nowUserid & "'"
        Try
            disp(s, sds)
            BindingSource1.DataSource = sds
            BindingSource1.DataMember = sds.Tables(0).TableName
            DataGridView1.DataSource = BindingSource1
        Catch
            MsgBox(Err.Description, vbYes, "查询失败")
        End Try
    End Sub
End Class