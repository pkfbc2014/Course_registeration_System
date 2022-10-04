Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Module ModuleMySQL ' 数据库连接相关
    '登录MYSQL数据库
    Private server = "localhost"
    Private Uid = "root" ' MySQL 用户名
    Private Pwd = "root" ' MySQL 密码
    Private database = "admininstration_system" ' 数据库名
    Public cnStr As String = "server=" & server & ";Uid=" & Uid & ";Pwd=" & Pwd & ";database=" & database & ";Charset=utf8;"
    Public cn As New MySqlConnection(cnStr) ' 数据库连接器
    Public da As MySqlDataAdapter ' 数据适配器对象

    Public whole_sid As String ' 全局变量 sid
    Public whole_pid As String ' 全局变量 pid
    Public nowsemester As String ' 全局变量 当前学期

    Public flag_disp = False ' disp函数的一个 bug

    Public nowUserid, nowUserpwd, nowUserright As String ' 当前登录系统的用户id、密码pwd和身份right（0-学生，1-教师，2-管理员）
    Public nowUsername As String ' 当前登录系统的用户名

    Public Sub disp(ByVal psql As String, ByVal sds As DataSet)  ' 从数据库获取数据填充数据集
        cn.Open()
        da = New MySqlDataAdapter(psql, cn) ' psql 为查询语句
        sds.Clear() ' 和慕课里面的不一样，原来使用 sds.refresh()，会导致第二次调用 disp() 时，数据全部清空的bug
        da.Fill(sds, "tableCQ")
        da = Nothing
        cn.Close()
    End Sub

    Public Sub exsql(ByVal psql As String)  ' 执行SQL语句，可以是插入、删除、修改语句
        cn.Open()
        Dim cmd As New MySqlCommand(psql, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Module

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
                    Form2.Show() '跳转到学生窗体
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
                    Form2.Show() '跳转到学生窗体
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
                    Form2.Show() '跳转到学生窗体
                    Me.Hide()
                Else
                    MsgBox("用户名或密码输入有误，请重新输入！",, "Error")
                End If
            End If
        End If
    End Sub
End Class