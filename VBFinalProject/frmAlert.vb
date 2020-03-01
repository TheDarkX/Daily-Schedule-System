Imports System.Net
Imports System.Net.Mail
Imports System.IO
Imports System.Data.OleDb

Public Class frmAlert
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DSS_db.accdb")
    Dim CWebClient As WebClient = New WebClient

#Region "Form Dragable"
    'Form Dragable
    Dim bDrag As Boolean
    Dim iMouseX As Integer
    Dim iMouseY As Integer

    Private Sub frmAlert_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        bDrag = True
        iMouseX = Windows.Forms.Cursor.Position.X - Me.Left
        iMouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub frmAlert_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If bDrag = True Then
            Me.Left = Windows.Forms.Cursor.Position.X - iMouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - iMouseY
        End If
    End Sub
    Private Sub frmAlert_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        bDrag = False
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        bDrag = True
        iMouseX = Windows.Forms.Cursor.Position.X - Me.Left
        iMouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If bDrag = True Then
            Me.Left = Windows.Forms.Cursor.Position.X - iMouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - iMouseY
        End If
    End Sub
    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        bDrag = False
    End Sub
#End Region

    Private Sub vSendSMS()
        ' Add a user agent header in case the requested URI contains a query.
        CWebClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)")
        CWebClient.QueryString.Add("user", "nokiaking")
        CWebClient.QueryString.Add("password", "OXHKCSgIgADLAb")
        CWebClient.QueryString.Add("api_id", "3473628")
        CWebClient.QueryString.Add("to", "60102325425")
        CWebClient.QueryString.Add("text", "Schedule Alert Alarm!!!")
        Dim baseurl As String = "http://api.clickatell.com/http/sendmsg"
        Dim data As Stream = CWebClient.OpenRead(baseurl)
        Dim reader As StreamReader = New StreamReader(data)
        Dim s As String = reader.ReadToEnd()
        data.Close()
        reader.Close()
        Return
    End Sub
    Private Sub vSendEMailAlert()
        Dim strUserEmail As String = Nothing
        'Retrieve User Email from Database
        Try
            If Not conn.State = ConnectionState.Open Then
                conn.Open()
            End If

            Dim mysql_statement As String = "SELECT * FROM tblUser WHERE Username = @Username"
            Dim cmd As OleDbCommand = New OleDbCommand(mysql_statement, conn)
            cmd.Parameters.AddWithValue("@Username", frmLogin.txtLUsername.Text)

            Dim rdr As OleDbDataReader = cmd.ExecuteReader()
            rdr.Read()

            If rdr.HasRows = True Then
                strUserEmail = rdr("Email").ToString
            End If

            'Send Email Function Here
            Dim Mail As New MailMessage
            Mail.Subject = "Schedule Alert!"
            Mail.To.Add(strUserEmail)
            Mail.From = New MailAddress("PCAlertSchedule@PC.com")
            Mail.Body = "Subject : " & Me.lblSubject.Text & vbNewLine & "Note : " & Me.txtNote.Text & vbNewLine & "Date : " & Me.lblDate.Text & vbNewLine & "Time : " & Me.lblTime.Text

            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("illutionmagician@gmail.com", "edward5425")
            SMTP.Port = "587"
            SMTP.Send(Mail)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try


    End Sub

    Private Sub frmAlert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.vShowBalloonTip(5000, "Schedule Alert!", "Sending Email Alert..." & vbNewLine & "Sending SMS Alert...")
        Timer1.Start()
        'vSendEMailAlert()
        'vSendSMS()
    End Sub

    Private Sub frmAlert_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Beep()
        Beep()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class