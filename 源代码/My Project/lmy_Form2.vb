Public Class Form2
    Dim todaytime As String
    Dim s As String
    Dim flag_textbox1 As Integer
    Dim sds2 As New DataSet
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = nowUserid
        Label3.Text = nowUsername
        todaytime = DateString
        flag_textbox1 = 0
        s = "SELECT * FROM select_time"
        disp(s, sds2)
        BindingSource1.DataSource = sds2
        BindingSource1.DataMember = sds2.Tables(0).TableName
        Select Case nowUserright
            Case 0      ' 学生
                管理ToolStripMenuItem.Visible = False
                教师ToolStripMenuItem.Visible = False
            Case 1      ' 教师
                管理ToolStripMenuItem.Visible = False
                学生ToolStripMenuItem.Visible = False
            Case 2      ' 管理员
                教师ToolStripMenuItem.Visible = False
                学生ToolStripMenuItem.Visible = False

                Dim i As Integer
                For i = 0 To BindingSource1.Count - 1
                    Dim endttime As String
                    endttime = sds2.Tables(0).Rows(i).Item(1)
                    todaytime = "2022-10-22"
                    If todaytime > endttime Then
                        Dim semester As String
                        semester = sds2.Tables(0).Rows(i).Item(2)
                        s = "SELECT * FROM grade"
                        'bind2,sds1里面是grade
                        Dim sds1 As New DataSet
                        disp(s, sds1)
                        BindingSource2.DataSource = sds1
                        BindingSource2.DataMember = sds1.Tables(0).TableName
                        'bind3里面是course
                        s = "SELECT * FROM course"
                        Dim sds4 As New DataSet
                        disp(s, sds4)
                        BindingSource3.DataSource = sds4
                        BindingSource3.DataMember = sds4.Tables(0).TableName
                        '
                        Dim j As Integer
                        For j = 0 To BindingSource3.Count - 1
                            If sds4.Tables(0).Rows(j).Item(5) = semester Then
                                Dim cid As String
                                cid = sds4.Tables(0).Rows(j).Item(0)
                                Dim sq As String
                                sq = "SELECT COUNT(*) FROM grade WHERE cid="""
                                sq &= cid
                                sq &= """"
                                Dim sds5 As New DataSet
                                disp(sq, sds5)
                                If sds5.Tables(0).Rows(0).Item(0) < 3 Then
                                    sq = "delete from grade where cid="""
                                    sq &= cid
                                    sq &= """"
                                    exsql(sq)
                                End If

                            End If
                        Next
                    End If
                Next
        End Select
    End Sub

    Private Sub 菜单ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 管理ToolStripMenuItem.Click

    End Sub

    Private Sub 成绩录入ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 成绩录入ToolStripMenuItem.Click
        CheckCourse.Show()
    End Sub

    Private Sub 选课设置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 选课设置ToolStripMenuItem.Click
        lmy_Form4.Show()
    End Sub

    Private Sub 选课ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 选课ToolStripMenuItem.Click
        Dim i As Integer
        Dim flag As Integer

        For i = 0 To BindingSource1.Count - 1
            Dim starttime As String
            starttime = sds2.Tables(0).Rows(i).Item(0)
            flag = 0
            If todaytime >= starttime Then
                Dim endttime As String
                endttime = sds2.Tables(0).Rows(i).Item(1)
                If StrComp(starttime, todaytime) Then
                    SelectCourse3.Show() ' 此处弹出选课界面
                    flag = 1
                End If
            End If
        Next
        If flag = 0 Then
            MsgBox("不在选课时间内")
        End If
        Dim fd As String
        fd = BindingSource1.Find("start_time", TimeOfDay)

    End Sub

    Private Sub 更改密码ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 更改密码ToolStripMenuItem.Click
        TextBox1.Visible = True
        Label4.Visible = True
        Button1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If flag_textbox1 = 1 Then
            Dim sq As String
            Dim key As String

            key = TextBox1.Text
            sq = " UPDATE admin SET password = """
            sq &= key
            sq &= """ where aid="""
            sq &= nowUserid
            sq &= """"
            exsql(sq)
            MsgBox("修改成功")
            TextBox1.Visible = False
            Label4.Visible = False
            Button1.Visible = False
        Else
            MsgBox("未输入密码，请输入后提交")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        flag_textbox1 = 1
    End Sub

    Private Sub 课程表ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 课程表ToolStripMenuItem.Click
        GradePrint.Show()
    End Sub
End Class