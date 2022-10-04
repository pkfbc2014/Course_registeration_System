Public Class SubmitGrade
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqls As String
        sqls = "update grade set grade = '" & ComboBox1.Text & "'where sid = '" & GradeView.sid & "' and cid = '" & CheckCourse.cid & "'"
        exsql(sqls)
        Me.Close()
        GradeView.GradeView_Load(sender, e)
    End Sub
End Class