Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '参考URL: https://www.atmarkit.co.jp/bbs/phpBB/viewtopic.php?topic=15269&forum=7
        AddHandler Application.ThreadException, New System.Threading.ThreadExceptionEventHandler(AddressOf UnhandledException)

        '自分自身のプロセスを取得する
        Dim p1 As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess()

        'プロセス情報を表示する
        Debug.WriteLine("")
        Debug.WriteLine("-- Button1_Click before ShowDialog --")
        Debug.WriteLine("プロセスID: {0}", p1.Id)
        Try
            Dim f = New Form2
            f.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim p2 As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess()
        Debug.WriteLine("")
        Debug.WriteLine("-- Button1_Click after ShowDialog --")
        Debug.WriteLine("プロセスID: {0}", p2.Id)
    End Sub


    '参考URL: https://www.atmarkit.co.jp/bbs/phpBB/viewtopic.php?topic=15269&forum=7
    Sub UnhandledException(ByVal o As Object, ByVal e As System.Threading.ThreadExceptionEventArgs)
        'デバッグなしで実行するとここへ来る
        MsgBox("UnhandledException come...")
        MessageBox.Show(e.Exception.Message, "にしざきさんに感謝", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
