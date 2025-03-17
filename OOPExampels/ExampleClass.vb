Public Class ExampleClass
    ''' <summary>
    ''' Takes two integers and return the sum
    ''' </summary>
    ''' <param name="firstNumber"></param>
    ''' <param name="secondNumber"></param>
    ''' <returns></returns>
    Shared Function SumOf(firstNumber As Integer, secondNumber As Integer) As Integer
        Return firstNumber + secondNumber
    End Function

    Public Sub DoSomething()
        MsgBox("hello")
    End Sub

End Class
