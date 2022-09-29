Public Class Stadd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sname, bdate, ssn, status, gendate As String ' 学生姓名、出生日期、社保号、状态、毕业日期
        Dim sqls As String ' SQL语句
        Dim password As String '初始密码
        Dim randnum As Integer

        Randomize()
        randnum = Int((10000000 * Rnd()) + 1) ' ⽣成 1 到 10 之间的随机数值作为学号

        If snamebox.Text = "" Then Exit Sub Else sname = Trim(snamebox.Text)
        If bdatebox.Text = "" Then Exit Sub Else bdate = Trim(bdatebox.Text)
        If ssnbox.Text = "" Then Exit Sub Else ssn = Trim(ssnbox.Text)
        If statusbox.Text = "" Then Exit Sub Else status = Trim(statusbox.Text)
        If gendatebox.Text = "" Then Exit Sub Else gendate = Trim(gendatebox.Text)

        password = "123456" ' 默认密码 123456
        sqls = "insert student values('" & randnum & "','" & password & "','" & sname & "','" & bdate & "','" & ssn & "','" & status & "','" & gendate & "')"
        exsql(sqls)

        Stmain.Form1_Load(sender, e)
        Me.Close()
    End Sub
End Class