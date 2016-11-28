Public Class Question
    Public id As Integer
    Public question As String
    Public answer(3) As String
    Public correct As String


    Sub New(i As Integer, q As String, a1 As String, a2 As String, a3 As String, ac As String)
        id = i
        question = q
        answer = {a1, a2, a3}
        correct = ac
    End Sub


    Sub Load(current As Question)
        Dim q As Form
        q = New frmAsk()
        q.ShowDialog()
    End Sub

End Class
