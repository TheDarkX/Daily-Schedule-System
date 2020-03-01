Public Class frmAbout

#Region "Form Dragable"
    'Form Dragable
    Dim bDrag As Boolean
    Dim iMouseX As Integer
    Dim iMouseY As Integer

    Private Sub frmAbout_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        bDrag = True
        iMouseX = Windows.Forms.Cursor.Position.X - Me.Left
        iMouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub frmAbout_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If bDrag = True Then
            Me.Left = Windows.Forms.Cursor.Position.X - iMouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - iMouseY
        End If
    End Sub
    Private Sub frmAbout_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.facebook.com/edward.ho.0000")
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        'Removed
    End Sub
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        'Removed
    End Sub
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        'Removed
    End Sub

    
End Class