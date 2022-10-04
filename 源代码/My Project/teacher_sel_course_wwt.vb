Imports System
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class teacher_sel_course_wwt

    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '数据表中文名称定义
        Dim CId As String = "课程编号"
        Dim CName As String = "课程名称"
        Dim CCredit = "学分"
        Dim CPrerequisite = "前导课程编号"
        Dim CFee As String = "费用（元）"

        '查询所需的数据并向DataGridView填充
        'Dim MySQL_Statement_Querytest As String = "Select id as " & CId & ", name as " & CName & ", credit as " & CCredit & ", prerequisite as " & CPrerequisite & ", fee as " & CFee & " from `course`;"
        '调用函数
        Dim MySQL_Statement_Querytest As String = "Select c.id as " & CId & ", c.name as " & CName & ", c.credit as " & CCredit & ", c.prerequisite as " & CPrerequisite & ", c.fee as " & CFee & " from `course` c , `teachingqualification` t where c.id = t.cid and t.pid =" & teacher_main_wwt.A_PID & " ;"
        Dim DataTable As DataTable = DatabaseQuery(MySQL_Statement_Querytest, CommandType.Text)
        DataGridView1.DataSource = DataTable
        Console.WriteLine(MySQL_Statement_Querytest)
        'DataGridView1.Columns(StId).Visible = False
    End Sub

    '登录MYSQL数据库
    Private server = "localhost"
    Private Uid = "root"
    Private Pwd = "root"
    Private database = "course_catalog"
    Public cnStr As String = "server=" & server & ";Uid=" & Uid & ";Pwd=" & Pwd & ";database=" & database & ";"
    '连接数据库
    Public cn As New MySqlConnection(cnStr)

    '登录MYSQL数据库
    Private server2 = "localhost"
    Private Uid2 = "root"
    Private Pwd2 = "root"
    Private database2 = "admininstration_system"
    Public cnStr2 As String = "server=" & server2 & ";Uid=" & Uid2 & ";Pwd=" & Pwd2 & ";database=" & database2 & ";"
    '连接数据库
    Public cn2 As New MySqlConnection(cnStr2)

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
        Dim Execute_Command As MySqlCommand = New MySqlCommand(MySQL_Statement, cn2)
        Try
            cn2.Open()
            Return Execute_Command.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        Finally
            cn2.Close()
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        If DataGridView1.Rows.Count = 1 Then
            MsgBox("您当前无课可教，添加失败")
            teacher_main_wwt.Form1_Load(sender, e) '重新加载主窗体
            teacher_main_wwt.Show()
            Me.Close() '关闭窗体
        Else
            i = MsgBox("确定添加课程：" & DataGridView1.CurrentRow.Cells(1).Value, 1, "删除记录")
            If i <> vbOK Then Exit Sub
            Dim CCid = DataGridView1.CurrentRow.Cells(0).Value
            Dim CName = DataGridView1.CurrentRow.Cells(1).Value
            Dim CCredit = DataGridView1.CurrentRow.Cells(2).Value
            Dim CPrerequisite = DataGridView1.CurrentRow.Cells(3).Value
            Dim CFee = DataGridView1.CurrentRow.Cells(4).Value

            Dim MySQL_Statement_Insert As String = "INSERT INTO `course` VALUES ('" & CCid & "','" & teacher_main_wwt.A_PID & "','" & CName & "','" & CCredit & "','" & CPrerequisite & "','" & teacher_main_wwt.PREAENT_SEMESTER & "','" & CFee & "' ,'', null );"
            Dim flag = DatabaseModify(MySQL_Statement_Insert, CommandType.Text)

            If flag <> 0 Then
                MsgBox("添加成功！")
            End If

            If flag = 0 Then
                '直接更新
                MySQL_Statement_Insert = "UPDATE `course` SET semester= " & Chr(34) & teacher_main_wwt.PREAENT_SEMESTER & Chr(34) & "Where semester != " & Chr(34) & teacher_main_wwt.PREAENT_SEMESTER & Chr(34) & " And pid = " & teacher_main_wwt.A_PID & " And cid =  " & CCid & ";" 'Chr (34)表示双引号
                flag = DatabaseModify(MySQL_Statement_Insert, CommandType.Text)
                Console.WriteLine(MySQL_Statement_Insert)
                If flag <> 0 Then
                    MsgBox("添加成功！")
                End If
                If flag = 0 Then
                    MsgBox("添加失败，课程已存在！")
                End If
            End If
            teacher_main_wwt.Form1_Load(sender, e) '重新加载主窗体
            teacher_main_wwt.Show()
            Me.Close() '关闭窗体
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        teacher_main_wwt.Form1_Load(sender, e) '重新加载主窗体
        teacher_main_wwt.Show()
        Me.Close() '关闭窗体
    End Sub
End Class