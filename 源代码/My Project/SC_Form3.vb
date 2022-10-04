'主界面
Public Class SelectCourse3
    Public sqls3 As String = "select * from grade where sid =" & nowUserid
    Public ds3 As New DataSet
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "学号:" + nowUserid
        Label2.Text = "姓名:" + nowUsername
        Label3.Text = "班级名:" '+ Status
    End Sub

    '创建新选课表
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        disp(sqls3, ds3)
        'dataset表集合的第一张表的行数为0,即尚未选课
        If ds3.Tables(0).Rows.Count = 0 Then
            SelectCourse1.ShowDialog()
        Else
            MsgBox("当前选课计划课表已经存在！")
            SelectCourse1.ShowDialog()
        End If
    End Sub

    '更新选课表
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        disp(sqls3, ds3)
        'dataset表集合的第一张表的行数为0,即尚未选课
        If ds3.Tables(0).Rows.Count = 0 Then
            MsgBox("当前选课计划还未选课！将创建选课表！")
            SelectCourse1.ShowDialog()
        Else
            SelectCourse1.ShowDialog()
        End If
    End Sub

    '删除选课表
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        disp(sqls3, ds3)
        'dataset表集合的第一张表的行数为0,即尚未选课
        If ds3.Tables(0).Rows.Count = 0 Then
            MsgBox("当前选课计划还未选课！")
        Else
            SelectCourse4.ShowDialog()
        End If
    End Sub


End Class