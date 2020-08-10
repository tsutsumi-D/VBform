Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '自分自身のプロセスを取得する
        Dim p As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess()

        'プロセス情報を表示する
        Debug.WriteLine("")
        Debug.WriteLine("-- Form2_Load --")
        Debug.WriteLine("プロセスID: {0}", p.Id)

        'Throw New Exception("Load")
        '上記Throwは
        'デバッグ有実行だとキャッチできない
        'デバッグ無実行だと参考URLコードを利用することでキャッチできる
    End Sub

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        '自分自身のプロセスを取得する
        Dim p As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess()

        'プロセス情報を表示する
        Debug.WriteLine("")
        Debug.WriteLine("-- Form2_Shown --")
        Debug.WriteLine("プロセスID: {0}", p.Id)

        Throw New Exception("Shown")
        '上記Throwは
        'デバッグ有実行だと参考URLコードを利用せずにキャッチできる
        'デバッグ無実行だと参考URLコードを利用することでキャッチできる
    End Sub
End Class