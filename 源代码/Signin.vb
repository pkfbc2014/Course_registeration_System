Public Class Signin
    Dim sds, pds, ads As New DataSet
    Private Sub Signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ssql, psql, asql As String

        ssql = "select * from student"
        psql = "select * from professor"
        asql = "select * from admin"

        Try
            disp(ssql, sds)
            BindingSource1.DataSource = sds
            BindingSource1.DataMember = sds.Tables(0).TableName
            disp(psql, pds)
            BindingSource2.DataSource = pds
            BindingSource2.DataMember = pds.Tables(0).TableName
            disp(asql, ads)
            BindingSource3.DataSource = ads
            BindingSource3.DataMember = ads.Tables(0).TableName

        Catch
            MsgBox(Err.Description, vbYes, "从数据库获取人员信息失败")
            Exit Sub
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fd As Integer
        If idbox.Text = "" Or passwordbox.Text = "" Then
            MsgBox("请输入用户名与密码！",, "Error")
            Exit Sub
        End If

        If identybox.Text = "学生 (student)" Then
            fd = BindingSource1.Find("sid", idbox.Text) ' 用户名匹配上了
            If fd >= 0 Then
                If passwordbox.Text = sds.Tables(0).Rows(fd).Item(1) Then ' 密码也匹配上了
                    nowUserid = idbox.Text
                    nowUserpwd = passwordbox.Text
                    nowUserright = identybox.SelectedIndex
                    nowUsername = sds.Tables(0).Rows(fd).Item(2)
                    GradePrint.Show() '跳转到学生窗体
                    Me.Hide()
                Else
                    MsgBox("用户名或密码输入有误，请重新输入！",, "Error")
                End If
            End If
        ElseIf identybox.Text = "教师 (professor)" Then
            fd = BindingSource2.Find("pid", idbox.Text) ' 用户名匹配上了
            If fd >= 0 Then
                If passwordbox.Text = pds.Tables(0).Rows(fd).Item(1) Then ' 密码也匹配上了
                    nowUserid = idbox.Text
                    nowUserpwd = passwordbox.Text
                    nowUserright = identybox.SelectedIndex
                    nowUsername = pds.Tables(0).Rows(fd).Item(2)
                    CheckCourse.Show() ' 跳转到教师窗体
                    Me.Hide()
                Else
                    MsgBox("用户名或密码输入有误，请重新输入！",, "Error")
                End If
            End If
        ElseIf identybox.Text = "管理员 (admin)" Then
            fd = BindingSource3.Find("aid", idbox.Text) ' 用户名匹配上了
            If fd >= 0 Then
                If passwordbox.Text = ads.Tables(0).Rows(fd).Item(1) Then ' 密码也匹配上了
                    nowUserid = idbox.Text
                    nowUserpwd = passwordbox.Text
                    nowUserright = identybox.SelectedIndex
                    Messager.Show() ' 跳转到管理员窗体
                    Me.Hide()
                Else
                    MsgBox("用户名或密码输入有误，请重新输入！",, "Error")
                End If
            End If
        End If
    End Sub
End Class