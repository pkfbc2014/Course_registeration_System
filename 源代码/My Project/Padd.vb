Public Class Padd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pname, bdate, ssn, status, department As String ' 学生姓名、出生日期、社保号、状态、毕业日期
        Dim sqls As String ' SQL语句
        Dim password As String '初始密码

        Dim randnum As Integer
        Randomize()
        randnum = Int((10000000 * Rnd()) + 1) ' ⽣成 1 到 10 之间的随机数值

        If pnamebox.Text = "" Then Exit Sub Else pname = Trim(pnamebox.Text)
        If bdatebox.Text = "" Then Exit Sub Else bdate = Trim(bdatebox.Text)
        If ssnbox.Text = "" Then Exit Sub Else ssn = Trim(ssnbox.Text)
        If statusbox.Text = "" Then Exit Sub Else status = Trim(statusbox.Text)
        If departmentbox.Text = "" Then Exit Sub Else department = Trim(departmentbox.Text)

        password = "123456" ' 默认密码 123456
        sqls = "insert professor values('" & randnum & "','" & password & "','" & pname & "','" & bdate & "','" & ssn & "','" & status & "','" & department & "')"
        exsql(sqls)

        Pmain.Tmain_Load(sender, e)
        Me.Close()
    End Sub
End Class