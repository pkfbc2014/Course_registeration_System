Public Class Stmodify
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sname, bdate, ssn, status, gendate As String ' 读取 box 中的 text
        Dim sqls As String

        If snamebox.Text = "" Then Exit Sub Else sname = Trim(snamebox.Text)
        If bdatebox.Text = "" Then Exit Sub Else bdate = Trim(bdatebox.Text)
        If ssnbox.Text = "" Then Exit Sub Else ssn = Trim(ssnbox.Text)
        If statusbox.Text = "" Then Exit Sub Else status = Trim(statusbox.Text)
        If gendatebox.Text = "" Then Exit Sub Else gendate = Trim(gendatebox.Text)

        sqls = "update student set name = '" & sname & "', birthday = '" & bdate & "', ssn = '" & ssn & "', status = '" & status & "', graduationday = '" & gendate & "' where sid = '" & whole_sid & "'"
        exsql(sqls)

        Stmain.Form1_Load(sender, e)
        Me.Close()
    End Sub
End Class