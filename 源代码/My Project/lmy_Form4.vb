Public Class lmy_Form4
    Dim flag As Integer
    Dim allisselect(3) As Integer

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        allisselect(0) = 0
        allisselect(1) = 0
        allisselect(2) = 0
        flag = 0
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        If flag = 0 Then
            TextBox2.Text = MonthCalendar1.SelectionStart
        ElseIf flag = 1 Then
            TextBox3.Text = MonthCalendar1.SelectionStart
        End If


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        allisselect(0) = 1
        flag = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        allisselect(1) = 1
        flag = 2
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        flag = 0
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        flag = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        For i = 0 To 2
            If allisselect(i) = 0 Then
                MsgBox("尚有内容未被选择")
                Return
            End If
        Next
        TextBox2.Text = TextBox2.Text.Replace("/", "-")
        TextBox3.Text = TextBox3.Text.Replace("/", "-")

        Dim sqls As String = "insert into select_time  values ("""
        sqls &= TextBox2.Text
        sqls &= ""","""
        sqls &= TextBox3.Text
        sqls &= ""","""
        sqls &= ComboBox1.Text
        sqls &= """)"
        exsql(sqls)
        MsgBox("设定成功")
        Me.Close()
        Return
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        allisselect(2) = 1
    End Sub
End Class