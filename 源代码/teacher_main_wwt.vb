Imports System
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class teacher_main_wwt
    '以下两项为全局变量，暂时定义，整合的时候可以直接使用已经定义并完成赋值的全局变量
    Public PREAENT_SEMESTER As String = nowsemester '当前选课的学期
    Public A_PID As String = nowUserid '教师教师号

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '数据表中文名称定义
        Dim CId As String = "课程编号"
        Dim CName As String = "课程名称"

        '查询所需的数据并向DataGridView填充
        Dim MySQL_Statement_Querytest As String = "Select cid as " & CId & ", name as " & CName & " from `course`" & "Where semester = " & Chr(34) & PREAENT_SEMESTER & Chr(34) & " And pid = " & A_PID & ";" 'Chr (34)表示双引号
        '调用函数
        Dim DataTable As DataTable = DatabaseQuery(MySQL_Statement_Querytest, CommandType.Text)
        DataGridView1.DataSource = DataTable
        'Console.WriteLine(MySQL_Statement_Querytest)
        'DataGridView1.Columns(StId).Visible = False
    End Sub

    '登录MYSQL数据库
    Private server = "localhost"
    Private Uid = "root"
    Private Pwd = "root"
    Private database = "admininstration_system"
    Public cnStr As String = "server=" & server & ";Uid=" & Uid & ";Pwd=" & Pwd & ";database=" & database & ";"
    '连接数据库
    Public cn As New MySqlConnection(cnStr)
    '数据库查询函数
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
    '数据库插，删，改函数
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        teacher_sel_course_wwt.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MySQL_Statement_Delete As String
        Dim i As Integer
        If (DataGridView1.Rows.Count = 1) Then

        Else
            i = MsgBox("确定删除课程：" & DataGridView1.CurrentRow.Cells(1).Value, 1, "删除记录")
            If i <> vbOK Then Exit Sub
            Dim A_CID = DataGridView1.CurrentRow.Cells(0).Value
            MySQL_Statement_Delete = "DELETE FROM `course` " & "Where semester = " & Chr(34) & PREAENT_SEMESTER & Chr(34) & " And pid = " & A_PID & " And cid = " & A_CID & ";" 'Chr (34)表示双引号
            DatabaseModify(MySQL_Statement_Delete, CommandType.Text)
            Form1_Load(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        teacher_past_course_wwt.Show()
        Me.Hide()
    End Sub
End Class