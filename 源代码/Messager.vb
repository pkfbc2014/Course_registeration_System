Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Module ModuleMySQL ' 数据库连接相关
    '登录MYSQL数据库
    Private server = "localhost"
    Private Uid = "root" ' MySQL 用户名
    Private Pwd = "root" ' MySQL 密码
    Private database = "admininstration_system" ' 数据库名
    Public cnStr As String = "server=" & server & ";Uid=" & Uid & ";Pwd=" & Pwd & ";database=" & database & ";"
    Public cn As New MySqlConnection(cnStr) ' 数据库连接器
    Public da As MySqlDataAdapter ' 数据适配器对象

    Public whole_sid As String ' 全局变量 sid
    Public whole_pid As String ' 全局变量 pid

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
    Public Function DatabaseModify(ByVal MySQL_Statement As String, ByVal Statement_Type As CommandType) As Integer
        Dim Execute_Command As MySqlCommand = New MySqlCommand(MySQL_Statement, cn)
        Try
            cn.Open()
            Return Execute_Command.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        Finally
            cn.Close()
        End Try
    End Function

    Public Function DatabaseQuery(ByVal MySQL_Statement As String, ByVal Statement_Type As CommandType) As DataTable
        Dim DataAdapter As New MySqlDataAdapter(MySQL_Statement, cn)
        Dim DataSet As New DataSet
        Try
            DataAdapter.Fill(DataSet)
            Return DataSet.Tables(0)
        Catch ex As Exception
            Return Nothing
        Finally
            cn.Close()
        End Try
    End Function

    Public Sub exsql(ByVal psql As String)  ' 执行SQL语句，可以是插入、删除、修改语句
        cn.Open()
        Dim cmd As New MySqlCommand(psql, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

End Module

Public Class Messager
    Private Sub frmCQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' 管理学生信息
        Me.Hide()
        Stmain.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click ' 管理老师信息
        Me.Hide()
        Pmain.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click ' 管理课程信息
        Me.Hide()
        ' GradePrint.Show() ' 管理员管理课程信息
    End Sub
End Class