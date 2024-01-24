
Public Delegate Sub EinfacherDelegate()
Public Delegate Sub DelegateMitPara(msg As String)
Public Delegate Function CalcDele(a As Integer, b As Integer) As Long

Public Class HalloDelegates
    Sub New()

        Dim meineSub As EinfacherDelegate = AddressOf EinfacheMethode
        Dim meinSubAsAction As Action = AddressOf EinfacheMethode
        Dim meinSubAsActionAno As Action = Sub() 'anonyme method
                                               Console.WriteLine("HALLO")
                                           End Sub
        meineSub.Invoke()

        Dim meinSubMitPara As DelegateMitPara = AddressOf MethodeMitPara
        Dim meinSubMitParaAsAction As Action(Of String) = AddressOf MethodeMitPara
        Dim meinSubMitParaAno As DelegateMitPara = Sub(txt As String) Console.WriteLine($"Hallo {txt}")
        meinSubMitPara.Invoke("Fred")

        Dim meinCalc As CalcDele = AddressOf Minus
        Dim meinCalcFunc As Func(Of Integer, Integer, Long) = AddressOf Sum
        Dim meinCalcAno As CalcDele = Function(a As Integer, b As Integer) As Long
                                          Return a + b
                                      End Function

        Dim meinCalcAno2 As CalcDele = Function(a As Integer, b As Integer) a + b
        Dim result = meinCalc.Invoke(2, 3)

        Dim text = New List(Of String)
        text.Where(AddressOf Filter)
        text.Where(Function(x) x.StartsWith("b"))

    End Sub

    Private Function Filter(txt As String) As Boolean
        If txt.StartsWith("b") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function Minus(a As Integer, b As Integer) As Long
        Return a - b
    End Function

    Private Function Sum(a As Integer, b As Integer) As Long
        Return a + b
    End Function

    Private Sub MethodeMitPara(txt As String)
        Console.WriteLine($"Hallo {txt}")
    End Sub

    Private Sub EinfacheMethode()
        Console.WriteLine("Hallo")
    End Sub
End Class
