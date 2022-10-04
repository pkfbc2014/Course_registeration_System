Imports System
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class teacher_past_course_wwt
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '数据表中文名称定义
        Dim CId As String = "课程编号"
        Dim CName As String = "课程名称"
        Dim CCredit As String = "学分"
        Dim CPrerequisite As String = "前导课程编号"
        Dim CSemester As String = "学期"
        Dim CFee As String = "费用（元）"
        Dim CTimeslot As String = "星期"
        Dim CNumber As String = "序号"

        '查询所需的数据并向DataGridView填充
        Dim MySQL_Statement_Querytest As String = "Select cid as " & CId & ", name as " & CName & ", credit as " & CCredit & ", prerequisite as " & CPrerequisite & ", semester as " & CSemester & ", fee as " & CFee & ", timeslot as " & CTimeslot & ", number as " & CNumber & " from `course`" & "Where semester != " & Chr(34) & teacher_main_wwt.PREAENT_SEMESTER & Chr(34) & " And pid = " & teacher_main_wwt.A_PID & ";" 'Chr (34)表示双引号
        '调用函数
        Dim DataTable As DataTable = DatabaseQuery(MySQL_Statement_Querytest, CommandType.Text)
        DataGridView1.DataSource = DataTable
        Console.WriteLine(MySQL_Statement_Querytest)
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

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        teacher_main_wwt.Form1_Load(sender, e) '重新加载主窗体
        teacher_main_wwt.Show()
        Me.Close() '关闭窗体
    End Sub

End Class