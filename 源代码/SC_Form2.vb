Public Class SelectCourse2
    '待课窗体代码
    Dim s As String, ds3 As New DataSet, tb As DataTable, ds4 As New DataSet
    Public lsindex As Integer '源代码中未定义
    Dim cmd As New MySql.Data.MySqlClient.MySqlCommand '源代码中不合适
    Dim mysql1 As String = "select * from grade NATURAL JOIN professor"
    Dim dataset1 As New DataSet

    Public select_num As Integer

    '主框架加载代码
    Private Sub FrmCSD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        s = "SELECT  cid,course.name AS cname, credit, professor.name AS pname, professor.pid FROM course JOIN professor ON professor.pid=course.pid WHERE  cid NOT IN (SELECT  cid  FROM grade  WHERE sid = '1')"
        '加载信息到Listview，并留白教师信息
        Try
            disp(s, ds3)
            ListView1.Items.Clear()
            tb = ds3.Tables(0)
            Dim i As Integer, j As Integer
            For i = 0 To tb.Rows.Count() - 1
                ListView1.Items.Add(tb.Rows(i).Item(0))
                'For j = 1 To tb.Columns.Count - 1
                For j = 1 To tb.Columns.Count - 1
                    ListView1.Items(i).SubItems.Add(tb.Rows(i).Item(j))
                Next                                    'listview的结构:CID,CName,CCredit,TName,TID;其中后两项置空，在后续函数中进行填充
                'ListView1.Items(i).SubItems.Add("")     ' 加上教师姓名
                'ListView1.Items(i).SubItems.Add("")     ' 加上教号
            Next
        Catch
            MsgBox(Err.Description, vbYes, "出错了!")
            Exit Sub
        End Try
    End Sub

    'Button1代码
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sno, con, pid, cname, credit, scd, grade As String  ' 学号、课程编号、教号、课程名、学分、修课学期、成绩
        Dim item As ListViewItem, vsql As String
        Try 'listview的结构:CID,CName,CCredit,TName,pid;其中后两项置空，在后续函数中进行填充
            cn.Open()
            If ListView1.CheckedItems.Count <> 0 Then
                If ListView1.CheckedItems.Count + select_num > 7 Then
                    MsgBox("选课数目上限为 6 门")
                    cn.Close()
                Else
                    For Each item In ListView1.CheckedItems
                        sno = nowUserid
                        con = Trim(item.SubItems(0).Text)
                        pid = Trim(item.SubItems(4).Text)
                        cname = Trim(item.SubItems(1).Text) '新加
                        credit = Trim(item.SubItems(2).Text) '新加
                        scd = Format(Now, "yyyy") & "年第" & IIf(Now.Month > 7, "二学期", "一学期")
                        vsql = "INSERT INTO grade(sid,pid,cid,cname,credit,semester,grade) VALUES('" & sno & "','"
                        vsql &= pid & "','" & con & "','" & cname & "','" & credit & "','" & scd & "',NULL)"
                        cmd.CommandText = vsql
                        cmd.Connection = cn
                        cmd.ExecuteNonQuery()
                    Next
                    cn.Close()
                    Button2_Click(sender, e)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description, , "信息")
        End Try
    End Sub


    'Button2代码
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SelectCourse1.dspgrd()
        SelectCourse1.Show()
        Me.Close()
    End Sub

    'Listview代码
    'Listview选中某行
    Private Sub ListView1_ItemSelectionChanged(ByVal sender As Object,
           ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        lsindex = e.ItemIndex '当前被选中的行号
    End Sub


End Class