Module MainModule

    Sub Main()
        'DoSomethingInMainModule()
        'DoSomethingInSecondModule()
        MsgBox(ExampleClass.SumOf(4, 3))

        Dim jimmy As New Animal
        Dim bob As New Mammal
        Dim lucky As New Dog
        Dim pepe As New Dog

        jimmy.Move()
        Console.WriteLine(jimmy.skinType)
        bob.Move()
        Console.WriteLine(bob.skinType)
        lucky.Move()
        Console.WriteLine(lucky.skinType)
        lucky.speak()

        pepe.movement = "shiver"
        pepe.skinType = "hairless rat"
        pepe.speak()
        pepe.Move()

    End Sub


    Sub DoSomethingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub

End Module
