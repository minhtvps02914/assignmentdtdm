Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub



    Private Sub btnSanPham_Click(sender As Object, e As EventArgs) Handles btnSanPham.Click
        frmQuanlySp.Show()
    End Sub

    Private Sub btnXemSP_Click(sender As Object, e As EventArgs) Handles btnXemSP.Click
        frmXemsanpham.Show()
    End Sub

    Private Sub btnQuanlyKH_Click(sender As Object, e As EventArgs) Handles btnQuanlyKH.Click
        frmQuanLyKH.Show()
    End Sub

    Private Sub btnKH_Click(sender As Object, e As EventArgs) Handles btnKH.Click
        frmCapNhatTTKH.Show()
    End Sub
End Class
