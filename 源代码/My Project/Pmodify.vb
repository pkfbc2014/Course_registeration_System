Public Class Pmodify
    Private Sub Pmodify_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pname, bdate, ssn, status, department As String ' 读取 box 中的 text
        Dim sqls As String

        If pnamebox.Text = "" Then Exit Sub Else pname = Trim(pnamebox.Text)
        If bdatebox.Text = "" Then Exit Sub Else bdate = Trim(bdatebox.Text)
        If ssnbox.Text = "" Then Exit Sub Else ssn = Trim(ssnbox.Text)
        If statusbox.Text = "" Then Exit Sub Else status = Trim(statusbox.Text)
        If departmentbox.Text = "" Then Exit Sub Else department = Trim(departmentbox.Text)

        sqls = "update professor set name = '" & pname & "', birthday = '" & bdate & "', ssn = '" & ssn & "', status = '" & status & "', department = '" & department & "' where pid = '" & whole_pid & "'"
        exsql(sqls)

        Pmain.Tmain_Load(sender, e)
        Me.Close()
    End Sub

End Class