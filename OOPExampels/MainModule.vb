Module MainModule

    Sub Main()
        'DoSomethingInMainModule()
        'DoSomethingInSecondModule()
        MsgBox(ExampleClass.SumOf(4, 3))

        Dim Jimmy As New Animal
        Jimmy.Move()
    End Sub


    Sub DoSomethingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub

End Module
