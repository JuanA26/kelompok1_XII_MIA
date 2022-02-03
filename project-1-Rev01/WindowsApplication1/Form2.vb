Public Class Form2

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmplkn.Click
        If Nam1.Text = String.Empty Then
            MessageBox.Show("Data tidak diisi tolong diisi ulang dengan benar", "Hasil", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Application.Restart()
        End If
        MessageBox.Show("Nama : " & Nam1.Text & vbCrLf & "Kelas : " & Kls.Text & vbCrLf & "Matpel : " & Matpel.Text & vbCrLf & "hasil : nilainya sangat rendah", "Hasil", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

    End Sub

    Private Sub ext2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ext2.Click
        Me.Dispose()
    End Sub
End Class