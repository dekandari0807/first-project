Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If textuser.Text = "devi" And textpass.Text = "123" Then
            MsgBox("anda berhasil login")
        Else
            MsgBox("username atau pass salah")
        End If


    End Sub
End Class
